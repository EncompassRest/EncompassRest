using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.CustomDataObjects
{
    public abstract class CustomDataObjects : ApiObject
    {
        internal CustomDataObjects(EncompassRestClient client, string baseApiPath)
            : base(client, baseApiPath)
        {
        }

        public Task<List<string>> GetCustomDataObjectsAsync(CancellationToken cancellationToken = default) => GetAsync<List<string>>(null, null, nameof(GetCustomDataObjectsAsync), null, cancellationToken);

        public Task<string> GetCustomDataObjectsRawAsync(CancellationToken cancellationToken = default) => GetRawAsync(null, null, nameof(GetCustomDataObjectsRawAsync), null, cancellationToken);

        public Task<CustomDataObject> GetCustomDataObjectAsync(string objectName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return GetAsync<CustomDataObject>(objectName, null, nameof(GetCustomDataObjectAsync), objectName, cancellationToken);
        }

        public Task<string> GetCustomDataObjectRawAsync(string objectName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return GetRawAsync(objectName, null, nameof(GetCustomDataObjectRawAsync), objectName, cancellationToken);
        }

        public Task CreateOrReplaceCustomDataObjectAsync(CustomDataObject cdo, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(cdo, nameof(cdo));
            Preconditions.NotNullOrEmpty(cdo.Name, $"{cdo}.{cdo.Name}");

            return PutAsync(cdo.Name, null, JsonStreamContent.Create(cdo), nameof(CreateOrReplaceCustomDataObjectAsync), cdo.Name, cancellationToken);
        }

        public Task<string> CreateOrReplaceCustomDataObjectRawAsync(string objectName, string cdo, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));
            Preconditions.NotNullOrEmpty(cdo, nameof(cdo));

            return PutRawAsync(objectName, null, new JsonStringContent(cdo), nameof(CreateOrReplaceCustomDataObjectRawAsync), objectName, cancellationToken);
        }

        public Task<bool> DeleteCustomDataObjectAsync(string objectName, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));

            return DeleteAsync(objectName, cancellationToken);
        }

        public Task AppendToCustomDataObjectAsync(CustomDataObject cdo, CancellationToken cancellationToken = default) => AppendToCustomDataObjectAsync(cdo, false, cancellationToken);

        public Task AppendToCustomDataObjectAsync(CustomDataObject cdo, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(cdo, nameof(cdo));
            Preconditions.NotNullOrEmpty(cdo.Name, $"{cdo}.{cdo.Name}");

            return PatchPopulateDirtyAsync(cdo.Name, populate ? ViewEntityQueryString : null, JsonStreamContent.Create(cdo), nameof(AppendToCustomDataObjectAsync), cdo.Name, cancellationToken, cdo, populate);
        }

        public Task<string> AppendToCustomDataObjectRawAsync(string objectName, string cdo, CancellationToken cancellationToken = default) => AppendToCustomDataObjectRawAsync(objectName, cdo, null, cancellationToken);

        public Task<string> AppendToCustomDataObjectRawAsync(string objectName, string cdo, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(objectName, nameof(objectName));
            Preconditions.NotNullOrEmpty(cdo, nameof(cdo));

            return PatchRawAsync(objectName, queryString, new JsonStringContent(cdo), nameof(AppendToCustomDataObjectRawAsync), objectName, cancellationToken);
        }
    }
}