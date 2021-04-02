using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Extensions;
using EncompassApi.Utilities;
using EnumsNET;

namespace EncompassApi.ResourceLocks
{
    public sealed class ResourceLocks : ApiObject
    {
        public ResourceLocks(IEncompassApiClient client)
            : base(client, "encompass/v1/resourceLocks")
        {
        }

        public Task<ResourceLock> GetResourceLockAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));
            Preconditions.NotNull(resourceLock, $"{nameof(resourceLock)}.{nameof(resourceLock.Resource)}");

            return GetResourceLockAsync(resourceLock.Id!, resourceLock.Resource!.EntityId!, resourceLock.Resource.EntityType!, cancellationToken);
        }

        public Task<ResourceLock> GetResourceLockAsync(string lockId, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLockAsync(lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetName()!, cancellationToken);

        public Task<ResourceLock> GetResourceLockAsync(string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var queryParameters = new QueryParameters(
                new QueryParameter("resourceType", resourceType),
                new QueryParameter("resourceId", resourceId));

            return GetAsync<ResourceLock>(lockId, queryParameters.ToString(), nameof(GetResourceLockAsync), lockId, cancellationToken);
        }

        public Task<string> GetResourceLockRawAsync(string lockId, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return GetRawAsync(lockId, queryString, nameof(GetResourceLockRawAsync), lockId, cancellationToken);
        }

        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLocksAsync(resourceId, resourceType.Validate(nameof(resourceType)).GetName()!, cancellationToken);

        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var queryParameters = new QueryParameters(
                new QueryParameter("resourceType", resourceType),
                new QueryParameter("resourceId", resourceId));

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
            if (force)
            {
                queryParameters.Add("force", "true");
            }
            if (populate)
            {
                queryParameters.Add("view", "entity");
            }

            return PostPopulateDirtyAsync(null, queryParameters.ToString(), nameof(LockResourceAsync), resourceLock, populate, cancellationToken);
        }

        public Task<string> LockResourceAsync(ResourceLockType lockType, string resourceId, EntityType resourceType, bool force, CancellationToken cancellationToken = default) =>
            LockResourceAsync(lockType.Validate(nameof(lockType)).GetValue()!, resourceId, resourceType.Validate(nameof(resourceType)).GetName()!, force, cancellationToken);

        public Task<string> LockResourceAsync(string lockType, string resourceId, string resourceType, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(lockType, nameof(lockType));
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var resourceLock = new ResourceLock
            {
                LockType = lockType,
                Resource = new EntityReference(resourceId, resourceType)
            };

            return LockResourceAsync(resourceLock, force, false, cancellationToken);
        }

        public Task<string> LockResourceRawAsync(string resourceLock, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceLock, nameof(resourceLock));

            return PostAsync(null, queryString, new JsonStringContent(resourceLock), nameof(LockResourceRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task<bool> TryUnlockResourceAsync(string lockId, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) =>
            TryUnlockResourceAsync(lockId, resourceId, resourceType, false, cancellationToken);

        public Task<bool> TryUnlockResourceAsync(string lockId, string resourceId, EntityType resourceType, bool force, CancellationToken cancellationToken = default) =>
            TryUnlockResourceAsync(lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetName()!, force, cancellationToken);

        public Task<bool> TryUnlockResourceAsync(string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default) =>
            TryUnlockResourceAsync(lockId, resourceId, resourceType, false, cancellationToken);

        public Task<bool> TryUnlockResourceAsync(string lockId, string resourceId, string resourceType, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var queryParameters = new QueryParameters(
                new QueryParameter("resourceType", resourceType),
                new QueryParameter("resourceId", resourceId));
            if (force)
            {
                queryParameters.Add("force", "true");
            }

            return TryDeleteAsync(lockId, queryParameters.ToString(), cancellationToken);
        }

        public Task<bool> TryUnlockResourceAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default) => TryUnlockResourceAsync(resourceLock, false, cancellationToken);

        public Task<bool> TryUnlockResourceAsync(ResourceLock resourceLock, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));
            Preconditions.NotNull(resourceLock, $"{nameof(resourceLock)}.{nameof(resourceLock.Resource)}");

            return TryUnlockResourceAsync(resourceLock.Id!, resourceLock.Resource!.EntityId!, resourceLock.Resource.EntityType!, force, cancellationToken);
        }

        public Task UnlockResourceAsync(string lockId, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) =>
            UnlockResourceAsync(lockId, resourceId, resourceType, false, cancellationToken);

        public Task UnlockResourceAsync(string lockId, string resourceId, EntityType resourceType, bool force, CancellationToken cancellationToken = default) =>
            UnlockResourceAsync(lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetName()!, force, cancellationToken);

        public Task UnlockResourceAsync(string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default) =>
            UnlockResourceAsync(lockId, resourceId, resourceType, false, cancellationToken);

        public Task UnlockResourceAsync(string lockId, string resourceId, string resourceType, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var queryParameters = new QueryParameters(
                new QueryParameter("resourceType", resourceType),
                new QueryParameter("resourceId", resourceId));
            if (force)
            {
                queryParameters.Add("force", "true");
            }

            return DeleteAsync(lockId, queryParameters.ToString(), cancellationToken);
        }

        public Task UnlockResourceAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default) => UnlockResourceAsync(resourceLock, false, cancellationToken);

        public Task UnlockResourceAsync(ResourceLock resourceLock, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));
            Preconditions.NotNull(resourceLock, $"{nameof(resourceLock)}.{nameof(resourceLock.Resource)}");

            return UnlockResourceAsync(resourceLock.Id!, resourceLock.Resource!.EntityId!, resourceLock.Resource.EntityType!, force, cancellationToken);
        }
    }
}