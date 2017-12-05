using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.CustomDataObjects
{
    public class CustomDataObjects : ApiObject
    {
        internal CustomDataObjects(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        public Task<List<string>> GetCustomDataObjectsAsync() => GetCustomDataObjectsAsync(CancellationToken.None);

        public Task<List<string>> GetCustomDataObjectsAsync(CancellationToken cancellationToken) => GetAsync<List<string>>(null, null, nameof(GetCustomDataObjectsAsync), null, cancellationToken);

        public Task<string> GetCustomDataObjectsRawAsync() => GetCustomDataObjectsRawAsync(CancellationToken.None);

        public Task<string> GetCustomDataObjectsRawAsync(CancellationToken cancellationToken) => GetRawAsync(null, null, nameof(GetCustomDataObjectsRawAsync), null, cancellationToken);

        public Task<CustomDataObject> GetCustomDataObjectAsync(string objectName) => GetCustomDataObjectAsync(objectName, CancellationToken.None);

        public Task<CustomDataObject> GetCustomDataObjectAsync(string objectName, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return GetAsync<CustomDataObject>(objectName, null, nameof(GetCustomDataObjectAsync), objectName, cancellationToken);
        }

        public Task<string> GetCustomDataObjectRawAsync(string objectName) => GetCustomDataObjectRawAsync(objectName, CancellationToken.None);

        public Task<string> GetCustomDataObjectRawAsync(string objectName, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return GetRawAsync(objectName, null, nameof(GetCustomDataObjectRawAsync), objectName, cancellationToken);
        }

        public Task CreateOrReplaceCustomDataObjectAsync(CustomDataObject cdo) => CreateOrReplaceCustomDataObjectAsync(cdo, CancellationToken.None);

        public Task CreateOrReplaceCustomDataObjectAsync(CustomDataObject cdo, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(cdo, nameof(cdo));
            Preconditions.NotNullOrEmpty(cdo.Name, $"{cdo}.{cdo.Name}");

            return PutAsync(JsonStreamContent.Create(cdo), cdo.Name, null, nameof(CreateOrReplaceCustomDataObjectAsync), cdo.Name, cancellationToken);
        }

        public Task<string> CreateOrReplaceCustomDataObjectRawAsync(string objectName, string cdo) => CreateOrReplaceCustomDataObjectRawAsync(objectName, cdo, CancellationToken.None);

        public Task<string> CreateOrReplaceCustomDataObjectRawAsync(string objectName, string cdo, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));
            Preconditions.NotNullOrEmpty(cdo, nameof(cdo));

            return PutRawAsync(new JsonStringContent(cdo), objectName, null, nameof(CreateOrReplaceCustomDataObjectRawAsync), objectName, cancellationToken);
        }

        public Task<bool> DeleteCustomDataObjectAsync(string objectName) => DeleteCustomDataObjectAsync(objectName, CancellationToken.None);

        public Task<bool> DeleteCustomDataObjectAsync(string objectName, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return DeleteAsync(objectName, cancellationToken);
        }

        public Task AppendToCustomDataObjectAsync(CustomDataObject cdo) => AppendToCustomDataObjectAsync(cdo, false, CancellationToken.None);

        public Task AppendToCustomDataObjectAsync(CustomDataObject cdo, CancellationToken cancellationToken) => AppendToCustomDataObjectAsync(cdo, false, cancellationToken);

        public Task AppendToCustomDataObjectAsync(CustomDataObject cdo, bool populate) => AppendToCustomDataObjectAsync(cdo, populate, CancellationToken.None);

        public Task AppendToCustomDataObjectAsync(CustomDataObject cdo, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(cdo, nameof(cdo));
            Preconditions.NotNullOrEmpty(cdo.Name, $"{cdo}.{cdo.Name}");

            return PatchAsync(JsonStreamContent.Create(cdo), cdo.Name, populate ? new QueryParameters(new QueryParameter("view", "entity")).ToString() : null, nameof(AppendToCustomDataObjectAsync), cdo.Name, cancellationToken, async response =>
            {
                if (populate)
                {
                    await response.Content.PopulateAsync(cdo).ConfigureAwait(false);
                }
                return string.Empty;
            });
        }

        public Task<string> AppendToCustomDataObjectRawAsync(string objectName, string cdo) => AppendToCustomDataObjectRawAsync(objectName, cdo, null, CancellationToken.None);

        public Task<string> AppendToCustomDataObjectRawAsync(string objectName, string cdo, CancellationToken cancellationToken) => AppendToCustomDataObjectRawAsync(objectName, cdo, null, cancellationToken);

        public Task<string> AppendToCustomDataObjectRawAsync(string objectName, string cdo, string queryString) => AppendToCustomDataObjectRawAsync(objectName, cdo, queryString, CancellationToken.None);

        public Task<string> AppendToCustomDataObjectRawAsync(string objectName, string cdo, string queryString, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));
            Preconditions.NotNullOrEmpty(cdo, nameof(cdo));

            return PatchRawAsync(new JsonStringContent(cdo), objectName, queryString, nameof(AppendToCustomDataObjectRawAsync), objectName, cancellationToken);
        }
    }
}