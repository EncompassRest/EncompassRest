using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.ResourceLocks.v1
{
    /// <summary>
    /// The Resource Locks Api.
    /// </summary>
    public interface IResourceLocksV1
    {
        /// <summary>
        /// Retrieves lock information for the specified resource.
        /// </summary>
        /// <param name="resourceLock">The resource lock to retrieve.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ResourceLock> GetResourceLockAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves lock information for the specified resource.
        /// </summary>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ResourceLock> GetResourceLockAsync(string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves lock information for the specified resource as raw json.
        /// </summary>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetResourceLockRawAsync(string lockId, string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of locked resources and metadata from Encompass.
        /// </summary>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, string resourceType, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of locked resources and metadata from Encompass as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetResourceLocksRawAsync(string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Locks the specified resource in Encompass and returns the lock id.
        /// </summary>
        /// <param name="resourceLock">The resource lock.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="populate">Indicates if the resource lock object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> LockResourceAsync(ResourceLock resourceLock, bool force = false, bool populate = false, CancellationToken cancellationToken = default);
        /// <summary>
        /// Locks the specified resource in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> LockResourceAsync(string lockType, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default);
        /// <summary>
        /// Locks the specified resource in Encompass and returns the response as raw json or if empty the lock id.
        /// </summary>
        /// <param name="resourceLock">The resource lock.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> LockResourceRawAsync(string resourceLock, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="resourceLock">The resource lock to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryUnlockResourceAsync(ResourceLock resourceLock, bool force = false, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryUnlockResourceAsync(string lockId, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="resourceLock">The resource lock to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UnlockResourceAsync(ResourceLock resourceLock, bool force = false, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        Task UnlockResourceAsync(string lockId, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default);
    }

    internal sealed class ResourceLocksV1 : ApiObject, IResourceLocksV1
    {
        internal ResourceLocksV1(EncompassRestClient client)
            : base(client, "encompass/v1/resourceLocks")
        {
        }

        public Task<ResourceLock> GetResourceLockAsync(ResourceLock resourceLock, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));
            Preconditions.NotNull(resourceLock, $"{nameof(resourceLock)}.{nameof(resourceLock.Resource)}");

            return GetResourceLockAsync(resourceLock.Id!, resourceLock.Resource!.EntityId!, resourceLock.Resource.EntityType!, cancellationToken);
        }

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

        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceId, string resourceType, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));

            var queryParameters = new QueryParameters(
                new QueryParameter("resourceType", resourceType),
                new QueryParameter("resourceId", resourceId));

            return GetListAsync<ResourceLock>(null, queryParameters.ToString(), nameof(GetResourceLocksAsync), null, cancellationToken);
        }

        public Task<string> GetResourceLocksRawAsync(string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return GetRawAsync(null, queryString, nameof(GetResourceLockRawAsync), null, cancellationToken);
        }

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

        public Task<bool> TryUnlockResourceAsync(ResourceLock resourceLock, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));
            Preconditions.NotNull(resourceLock, $"{nameof(resourceLock)}.{nameof(resourceLock.Resource)}");

            return TryUnlockResourceAsync(resourceLock.Id!, resourceLock.Resource!.EntityId!, resourceLock.Resource.EntityType!, force, cancellationToken);
        }

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

        public Task UnlockResourceAsync(ResourceLock resourceLock, bool force, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(resourceLock, nameof(resourceLock));
            Preconditions.NotNull(resourceLock, $"{nameof(resourceLock)}.{nameof(resourceLock.Resource)}");

            return UnlockResourceAsync(resourceLock.Id!, resourceLock.Resource!.EntityId!, resourceLock.Resource.EntityType!, force, cancellationToken);
        }
    }
}