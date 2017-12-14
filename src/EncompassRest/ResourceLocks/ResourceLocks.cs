using EncompassRest.Loans;
using EncompassRest.Loans.Enums;
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
            return GetResourceLockAsync(resourceLock.Id, resourceLock.Resource.EntityId, resourceLock.Resource.EntityType, cancellationToken);
        }
        public Task<ResourceLock> GetResourceLockAsync(string lockId, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLockAsync(lockId, resourceId, resourceType.ToString(), cancellationToken);
        public async Task<ResourceLock> GetResourceLockAsync(string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));

            return await GetAsync<ResourceLock>(lockId, queryParameters.ToString(), nameof(GetResourceLockAsync), lockId, cancellationToken);
        }

        public Task<string> GetResourceLockRawAsync(string resourceId, string lockId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));

            return GetRawAsync(lockId, queryParameters.ToString(), nameof(GetResourceLockRawAsync), lockId, cancellationToken);
        }

        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLocksAsync(resourceId, resourceType.ToString(), cancellationToken);
        public async Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, string resourceType,  CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));

            return await GetAsync<List<ResourceLock>>(null, queryParameters.ToString(), nameof(GetResourceLocksAsync), null, cancellationToken);
        }

        public Task<string> GetResourceLocksRawAsync(string resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));

            return GetRawAsync(null, queryParameters.ToString(), nameof(GetResourceLockRawAsync), resourceId, cancellationToken);
        }

        public Task<string> LockResourceAsync(ResourceLock resource, CancellationToken cancellationToken = default) => LockResourceAsync(resource, false, false, cancellationToken);
        public Task<string> LockResourceAsync(ResourceLock resource, bool force, CancellationToken cancellationToken = default) => LockResourceAsync(resource, force, false, cancellationToken);
        public Task<string> LockResourceAsync(ResourceLock resourceLock, bool force, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("force", force? "true" : "false"));
            queryParameters.Add(new QueryParameter("view", populate ? "entity" : "id"));

            return PostPopulateDirtyAsync<ResourceLock>(null, queryParameters.ToString(), null, nameof(LockResourceAsync),populate, cancellationToken);
        }

        public Task<string> LockResourceAsync(string lockType, string resourceId, string resourceType, bool force, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockType, nameof(lockType));

            ResourceLock resourceLock = new ResourceLock();
            resourceLock.Resource.EntityId = resourceId;
            resourceLock.Resource.EntityType = resourceType;
            resourceLock.LockType = lockType;

            return LockResourceAsync(resourceLock, force, populate, cancellationToken);
        }

        public Task<string> LockResourceRawAsync(string resource, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resource, nameof(resource));

            return PostAsync(null, queryString, new JsonStringContent(resource), nameof(LockResourceRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task<bool> UnlockResourceAsync(string lockId, string resourceId, string resourceType, bool force, CancellationToken cancellationToken = default)
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
