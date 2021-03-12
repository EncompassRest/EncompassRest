using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Loans;
using EncompassApi.Schema;
using EncompassApi.Utilities;

namespace EncompassApi
{
    /// <summary>
    /// A common cache object that is meant to be shared between multiple clients. This can be done through the <see cref="ClientParameters.CommonCache"/> property when creating a client.
    /// </summary>
    public sealed class CommonCache
    {
        private readonly ConcurrentDictionary<string, FieldDescriptor> _customFields = new ConcurrentDictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// The custom fields cache.
        /// </summary>
        public ReadOnlyDictionary<string, FieldDescriptor> CustomFields { get; }

        /// <summary>
        /// The utc date and time custom fields were last refreshed.
        /// </summary>
        public DateTime? CustomFieldsLastRefreshedUtc { get; private set; }

        /// <summary>
        /// The common cache constructor.
        /// </summary>
        public CommonCache()
        {
            CustomFields = new ReadOnlyDictionary<string, FieldDescriptor>(_customFields);
        }

        /// <summary>
        /// Refreshes the custom fields cache.
        /// </summary>
        /// <param name="client">The client to use to retrieve the custom fields.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task RefreshCustomFieldsAsync(IEncompassApiClient client, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(client, nameof(client));

            var retrievedCustomFields = new Dictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

            var customFieldsList = await client.Settings.Loan.CustomFields.GetCustomFieldsAsync(cancellationToken).ConfigureAwait(false);

            foreach (var customField in customFieldsList)
            {
                var modelPath = $"Loan.CustomFields[(FieldName == '{customField.Id}')].StringValue";
                retrievedCustomFields[customField.Id!] = new NonStandardFieldDescriptor(customField.Id!, LoanFieldDescriptors.CreateModelPath(modelPath)!, modelPath, customField.Description!, customField.Format, customField.Options?.Select(o => new FieldOption(o)).ToList(), false);
            }

            var customFields = _customFields;
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
    }
}