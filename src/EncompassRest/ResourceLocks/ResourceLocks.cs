using EncompassRest.Utilities;
using EnumsNET;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.ResourceLocks
{
    internal sealed class ResourceLocks : ApiObject
    {
        internal ResourceLocks(EncompassRestClient client) : 
            base(client, "encompass/v1/resourceLocks")
        {
        }

        public Task<ResourceLock> GetResourceLockAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));
            return GetResourceLockAsync(resourceLock.Id, resourceLock.Resource.EntityId, resourceLock.Resource.EntityType, cancellationToken);
        }
        public Task<ResourceLock> GetResourceLockAsync(string lockId, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLockAsync(lockId, resourceId, resourceType.AsString(), cancellationToken);
        public Task<ResourceLock> GetResourceLockAsync(string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));

            return GetAsync<ResourceLock>(lockId, queryParameters.ToString(), nameof(GetResourceLockAsync), lockId, cancellationToken);
        }

        public Task<string> GetResourceLockRawAsync(string lockId, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));

            return GetRawAsync(lockId, queryString, nameof(GetResourceLockRawAsync), lockId, cancellationToken);
        }

        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLocksAsync(resourceId, resourceType.TsString(), cancellationToken);
        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));

            return GetAsync<List<ResourceLock>>(null, queryParameters.ToString(), nameof(GetResourceLocksAsync), null, cancellationToken);
        }

        public Task<string> GetResourceLocksRawAsync(string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return GetRawAsync(null, queryString, nameof(GetResourceLockRawAsync), null, cancellationToken);
        }

        public Task<string> LockResourceAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default) => LockResourceAsync(resourceLock, false, false, cancellationToken);
        public Task<string> LockResourceAsync(ResourceLock resourceLock, bool force, CancellationToken cancellationToken = default) => LockResourceAsync(resourceLock, force, false, cancellationToken);
        public Task<string> LockResourceAsync(ResourceLock resourceLock, bool force, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));

            var queryParameters = new QueryParameters();
            if (force) queryParameters.Add(new QueryParameter("force", "true"));
            if (populate) queryParameters.Add(new QueryParameter("view", "entity"));

            return PostPopulateDirtyAsync<ResourceLock>(null, queryParameters.ToString(), resourceLock, nameof(LockResourceAsync), populate, cancellationToken);
        }
        public Task<string> LockResourceAsync(ResourceLockType lockType, string resourceId, EntityType resourceType, bool force, CancellationToken cancellationToken = default) =>
            LockResourceAsync(lockType.AsString(), resourceId, resourceType.AsString(), force, cancellationToken);
        public Task<string> LockResourceAsync(string lockType, string resourceId, EntityType resourceType, bool force, CancellationToken cancellationToken = default) =>
            LockResourceAsync(lockType, resourceId, resourceType.AsString(), force, cancellationToken);
        public Task<string> LockResourceAsync(ResourceLockType lockType, string resourceId, string resourceType, bool force, CancellationToken cancellationToken = default) =>
            LockResourceAsync(lockType.AsString(), resourceId, resourceType, force, cancellationToken);
        public Task<string> LockResourceAsync(string lockType, string resourceId, string resourceType, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockType, nameof(lockType));

            ResourceLock resourceLock = new ResourceLock();
            resourceLock.Resource.EntityId = resourceId;
            resourceLock.Resource.EntityType = resourceType;
            resourceLock.LockType = lockType;

            return LockResourceAsync(resourceLock, force, false, cancellationToken);
        }

        public Task<string> LockResourceRawAsync(string resourceLock, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceLock, nameof(resourceLock));

            return PostAsync(null, queryString, new JsonStringContent(resourceLock), nameof(LockResourceRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task<bool> UnlockResourceAsync(string lockId, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) =>
            UnlockResourceAsync(lockId, resourceId, resourceType, false, cancellationToken);
        public Task<bool> UnlockResourceAsync(string lockId, string resourceId, EntityType resourceType, bool force, CancellationToken cancellationToken = default) =>
            UnlockResourceAsync(lockId, resourceId, resourceType.AsString(), force, cancellationToken);
        public Task<bool> UnlockResourceAsync(string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default) =>
            UnlockResourceAsync(lockId, resourceId, resourceType, false, cancellationToken);
        public Task<bool> UnlockResourceAsync(string lockId, string resourceId, string resourceType, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));
            if (force) queryParameters.Add(new QueryParameter("force", "true"));

            return DeleteAsync(lockId, queryParameters.ToString(), cancellationToken);
        }
        public Task<bool> UnlockResourceAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default) => UnlockResourceAsync(resourceLock, false, cancellationToken);
        public Task<bool> UnlockResourceAsync(ResourceLock resourceLock, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));

            return UnlockResourceAsync(resourceLock.Id, resourceLock.Resource.EntityId, resourceLock.Resource.EntityType, force, cancellationToken);
        }
    }
}
