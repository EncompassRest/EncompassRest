using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Schema;
using EncompassRest.Utilities;

namespace EncompassRest
{
    public sealed class CommonCache
    {
        private ConcurrentDictionary<string, FieldDescriptor> _customFields;

        private ReadOnlyDictionary<string, FieldDescriptor> _readOnlyCustomFields;

        public ReadOnlyDictionary<string, FieldDescriptor> CustomFields => _readOnlyCustomFields;

        public DateTime? CustomFieldsLastRefreshedUtc { get; private set; }

        public async Task RefreshCustomFieldsAsync(EncompassRestClient client, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(client, nameof(client));

            var retrievedCustomFields = new Dictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

            var customFieldsList = await client.Settings.Loan.CustomFields.GetCustomFieldsAsync(cancellationToken).ConfigureAwait(false);

            foreach (var customField in customFieldsList)
            {
                retrievedCustomFields[customField.Id] = new NonStandardFieldDescriptor(customField.Id, LoanFieldDescriptors.CreateModelPath($"Loan.CustomFields[(FieldName == '{customField.Id}')].StringValue"), LoanFieldType.Custom, customField.Description, customField.Format, customField.Options?.Select(o => new FieldOption(o)).ToList(), false);
            }

            var customFields = _customFields;
            if (customFields == null)
            {
                customFields = Interlocked.CompareExchange(ref _customFields, (customFields = new ConcurrentDictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase)), null) ?? customFields;
                Interlocked.CompareExchange(ref _readOnlyCustomFields, new ReadOnlyDictionary<string, FieldDescriptor>(customFields), null);
            }

            foreach (var pair in customFields)
            {
                if (retrievedCustomFields.TryGetValue(pair.Key, out var descriptor))
                {
                    customFields[pair.Key] = descriptor;
                    retrievedCustomFields.Remove(pair.Key);
                }
                else
                {
                    customFields.TryRemove(pair.Key, out _);
                }
            }

            foreach (var pair in retrievedCustomFields)
            {
                customFields[pair.Key] = pair.Value;
            }

            CustomFieldsLastRefreshedUtc = DateTime.UtcNow;
        }

        internal Task TryInitializeAsync(EncompassRestClient client, ClientParameters parameters, CancellationToken cancellationToken)
        {
            if (parameters.CustomFieldsCacheInitialization != CacheInitialization.Never && !((DateTime.UtcNow - CustomFieldsLastRefreshedUtc)?.TotalMinutes < (int)parameters.CustomFieldsCacheInitialization))
            {
                return RefreshCustomFieldsAsync(client, cancellationToken);
            }
            return TaskHelper.CompletedTask;
        }
    }
}