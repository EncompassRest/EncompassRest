using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Schema;
using EncompassRest.Settings.Loan.v1;
using EncompassRest.Utilities;

namespace EncompassRest.v1
{
    /// <summary>
    /// The Common Cache extension methods.
    /// </summary>
    public static class CommonCacheExtensions
    {
        /// <summary>
        /// The custom fields cache.
        /// </summary>
        /// <param name="commonCache">The common cache.</param>
        /// <returns></returns>
        public static ReadOnlyDictionary<string, FieldDescriptor> GetCustomFields(this CommonCache commonCache) => (ReadOnlyDictionary<string, FieldDescriptor>)commonCache.ExtensionData.GetOrAdd("v1ReadOnlyCustomFields", k => new ReadOnlyDictionary<string, FieldDescriptor>(GetCustomFieldsInternal(commonCache)));

        private static ConcurrentDictionary<string, FieldDescriptor> GetCustomFieldsInternal(CommonCache commonCache) => (ConcurrentDictionary<string, FieldDescriptor>)commonCache.ExtensionData.GetOrAdd("v1CustomFields", k => new ConcurrentDictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase));

        /// <summary>
        /// The utc date and time custom fields were last refreshed.
        /// </summary>
        /// <param name="commonCache">The common cache.</param>
        /// <returns></returns>
        public static DateTime? GetCustomFieldsLastRefreshedUtc(this CommonCache commonCache) => commonCache.ExtensionData.TryGetValue("v1CustomFieldsLastRefreshedUtc", out var dateTime) ? (DateTime)dateTime : null;

        /// <summary>
        /// Refreshes the custom fields cache.
        /// </summary>
        /// <param name="commonCache">The common cache.</param>
        /// <param name="client">The client to use to retrieve the custom fields.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static async Task RefreshCustomFieldsAsync(this CommonCache commonCache, IEncompassRestClient client, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(client, nameof(client));

            var retrievedCustomFields = new Dictionary<string, FieldDescriptor>(StringComparer.OrdinalIgnoreCase);

            var customFieldsList = await client.Settings.Loan.CustomFields.GetCustomFieldsAsync(cancellationToken).ConfigureAwait(false);

            foreach (var customField in customFieldsList)
            {
                var modelPath = $"Loan.CustomFields[(FieldName == '{customField.Id}')].StringValue";
                retrievedCustomFields[customField.Id!] = new NonStandardFieldDescriptor(customField.Id!, LoanFieldDescriptors.CreateModelPath(modelPath)!, modelPath, customField.Description!, customField.Format, customField.Options?.Select(o => new FieldOption(o)).ToList(), false);
            }

            var customFields = GetCustomFieldsInternal(commonCache);
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

            commonCache.ExtensionData["v1CustomFieldsLastRefreshedUtc"] = DateTime.UtcNow;
        }
    }
}
