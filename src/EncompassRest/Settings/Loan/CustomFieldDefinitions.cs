using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Settings.Loan
{
    public sealed class CustomFieldDefinitions : ApiObject
    {
        internal CustomFieldDefinitions(EncompassRestClient client)
            : base(client, "encompass/v1/settings/loan/customFields")
        {
        }

        public Task<List<CustomFieldDefinition>> GetCustomFieldsAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<CustomFieldDefinition>(null, null, nameof(GetCustomFieldsAsync), null, cancellationToken);

        public Task<string> GetCustomFieldsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetCustomFieldsRawAsync), null, cancellationToken);

        public Task<CustomFieldDefinition> GetCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetDirtyAsync<CustomFieldDefinition>(fieldId, null, nameof(GetCustomFieldAsync), fieldId, cancellationToken);
        }

        public Task<string> GetCustomFieldRawAsync(string fieldId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetRawAsync(fieldId, queryString, nameof(GetCustomFieldRawAsync), fieldId, cancellationToken);
        }

        public Task CreateCustomFieldAsync(CustomFieldDefinition customField, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(customField, nameof(customField));
            Preconditions.NotNullOrEmpty(customField.Id, $"{nameof(customField)}.{nameof(customField.Id)}");

            return PutAsync(customField.Id, null, JsonStreamContent.Create(customField), nameof(CreateCustomFieldAsync), customField.Id, cancellationToken);
        }

        public Task CreateCustomFieldRawAsync(string fieldId, string customField, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNull(customField, nameof(customField));

            return PutAsync(fieldId, queryString, new JsonStringContent(customField), nameof(CreateCustomFieldRawAsync), fieldId, cancellationToken);
        }

        public Task UpdateCustomFieldAsync(CustomFieldDefinition customField, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(customField, nameof(customField));
            Preconditions.NotNullOrEmpty(customField.Id, $"{nameof(customField)}.{nameof(customField.Id)}");

            return PatchAsync(customField.Id, null, JsonStreamContent.Create(customField), nameof(UpdateCustomFieldAsync), customField.Id, cancellationToken);
        }

        public Task UpdateCustomFieldRawAsync(string fieldId, string customField, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNull(customField, nameof(customField));

            return PatchAsync(fieldId, queryString, JsonStreamContent.Create(customField), nameof(UpdateCustomFieldRawAsync), fieldId, cancellationToken);
        }

        public Task<bool> DeleteCustomFieldAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return DeleteAsync(fieldId, null, cancellationToken);
        }
    }
}