using EncompassRest.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.ResourceLocks
{
    public sealed class ResourceLocks : ApiObject
    {
        internal ResourceLocks(EncompassRestClient client) : 
            base(client, "encompass/v1/resourceLocks")
        {
        }

        public Task<ResourceLock> GetResourceLockAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));
            return GetResourceLockAsync(resourceLock.Resource.EntityId, resourceLock.Id, resourceLock.Resource.EntityType, cancellationToken);
        }
        public Task<ResourceLock> GetResourceLockAsync(string resourceId, string lockId,  CancellationToken cancellationToken = default) => GetResourceLockAsync(resourceId, lockId, nameof(ResourceEntityType.Loan), cancellationToken);
        public Task<ResourceLock> GetResourceLockAsync(string resourceId, string lockId, ResourceEntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLockAsync(resourceId, lockId, nameof(resourceType), cancellationToken);
        private async Task<ResourceLock> GetResourceLockAsync(string resourceId, string lockId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));

            return await GetAsync<ResourceLock>(lockId, queryParameters.ToString(), nameof(GetResourceLockAsync), lockId, cancellationToken);
        }

        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, CancellationToken cancellationToken = default) => GetResourceLocksAsync(resourceId, "loan", cancellationToken);
        private async Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, string resourceType,  CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));
            return await GetAsync<List<ResourceLock>>(null, queryParameters.ToString(), nameof(GetResourceLocksAsync), null, cancellationToken);
        }

        public Task<string> LockResourceAsync(ResourceLock resource, CancellationToken cancellationToken = default) => LockResourceAsync(resource, false, false, cancellationToken);
        public Task<string> LockResourceAsync(ResourceLock resource, bool force, CancellationToken cancellationToken = default) => LockResourceAsync(resource, force, false, cancellationToken);

        public Task<string> LockResourceAsync(ResourceLock resourceLock, bool force, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("force", force? "true" : "false"));

            return PostPopulateDirtyAsync<ResourceLock>(null, queryParameters.ToString(), resourceLock, nameof(LockResourceAsync),populate, cancellationToken);
        }

        public Task<bool> UnlockResourceAsync(string resourceId, string lockId, CancellationToken cancellationToken = default) => UnlockResourceAsync(resourceId, lockId, "loan", false, cancellationToken);
        public Task<bool> UnlockResourceAsync(string resourceId, string lockId, bool force, CancellationToken cancellationToken = default) => UnlockResourceAsync(resourceId, lockId, "loan", force, cancellationToken);
        private Task<bool> UnlockResourceAsync(string resourceId, string lockId, string resourceType, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));
            queryParameters.Add(new QueryParameter("force", force? "true" : "false"));

            return DeleteAsync(lockId, queryParameters.ToString(), cancellationToken);
        }
        public Task<bool> UnlockResourceAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default) => UnlockResourceAsync(resourceLock, false, cancellationToken);
        public Task<bool> UnlockResourceAsync(ResourceLock resourceLock, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));

            return UnlockResourceAsync(resourceLock.Id, resourceLock.Id, resourceLock.LockType, force, cancellationToken);
        }
    }
}
