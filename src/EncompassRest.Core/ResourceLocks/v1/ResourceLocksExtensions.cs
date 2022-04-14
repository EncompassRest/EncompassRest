using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.ResourceLocks.v1
{
    /// <summary>
    /// The Resource Locks Api extension methods.
    /// </summary>
    public static class ResourceLocksExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IResourceLocksV1? V1 { get; set; }

        private static IResourceLocksV1 GetV1(IResourceLocks resourceLocks)
        {
            var v1 = V1;
            if (resourceLocks is ResourceLocks l)
            {
                v1 = l.ExtensionData.GetOrAdd(() => new ResourceLocksV1(l.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(resourceLocks, nameof(resourceLocks));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves lock information for the specified resource.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="resourceLock">The resource lock to retrieve.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ResourceLock> GetResourceLockAsync(this IResourceLocks resourceLocks, ResourceLock resourceLock, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLockAsync(resourceLock, cancellationToken);

        /// <summary>
        /// Retrieves lock information for the specified resource.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ResourceLock> GetResourceLockAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLockAsync(resourceLocks, lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetValue(), cancellationToken);

        /// <summary>
        /// Retrieves lock information for the specified resource.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ResourceLock> GetResourceLockAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLockAsync(lockId, resourceId, resourceType, cancellationToken);

        /// <summary>
        /// Retrieves lock information for the specified resource as raw json.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetResourceLockRawAsync(this IResourceLocks resourceLocks, string lockId, string queryString, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLockRawAsync(lockId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves a list of locked resources and metadata from Encompass.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ResourceLock>> GetResourceLocksAsync(this IResourceLocks resourceLocks, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLocksAsync(resourceLocks, resourceId, resourceType.Validate(nameof(resourceType)).GetValue(), cancellationToken);

        /// <summary>
        /// Retrieves a list of locked resources and metadata from Encompass.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ResourceLock>> GetResourceLocksAsync(this IResourceLocks resourceLocks, string resourceId, string resourceType, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLocksAsync(resourceId, resourceType, cancellationToken);

        /// <summary>
        /// Retrieves a list of locked resources and metadata from Encompass as raw json.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetResourceLocksRawAsync(this IResourceLocks resourceLocks, string queryString, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLocksRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Locks the specified resource in Encompass and returns the lock id.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="resourceLock">The resource lock.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="populate">Indicates if the resource lock object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> LockResourceAsync(this IResourceLocks resourceLocks, ResourceLock resourceLock, bool force = false, bool populate = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).LockResourceAsync(resourceLock, force, populate, cancellationToken);

        /// <summary>
        /// Locks the specified resource in Encompass and returns the lock id.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> LockResourceAsync(this IResourceLocks resourceLocks, ResourceLockType lockType, string resourceId, EntityType resourceType, bool force = false, CancellationToken cancellationToken = default) => LockResourceAsync(resourceLocks, lockType.Validate(nameof(lockType)).GetValue(), resourceId, resourceType.Validate(nameof(resourceType)).GetValue(), force, cancellationToken);

        /// <summary>
        /// Locks the specified resource in Encompass and returns the lock id.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> LockResourceAsync(this IResourceLocks resourceLocks, string lockType, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).LockResourceAsync(lockType, resourceId, resourceType, force, cancellationToken);

        /// <summary>
        /// Locks the specified resource in Encompass and returns the response as raw json or if empty the lock id.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="resourceLock">The resource lock.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> LockResourceRawAsync(this IResourceLocks resourceLocks, string resourceLock, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(resourceLocks).LockResourceRawAsync(resourceLock, queryString, cancellationToken);

        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="resourceLock">The resource lock to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryUnlockResourceAsync(this IResourceLocks resourceLocks, ResourceLock resourceLock, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).TryUnlockResourceAsync(resourceLock, force, cancellationToken);

        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryUnlockResourceAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, EntityType resourceType, bool force = false, CancellationToken cancellationToken = default) => TryUnlockResourceAsync(resourceLocks, lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetValue(), force, cancellationToken);

        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryUnlockResourceAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).TryUnlockResourceAsync(lockId, resourceId, resourceType, force, cancellationToken);

        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="resourceLock">The resource lock to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UnlockResourceAsync(this IResourceLocks resourceLocks, ResourceLock resourceLock, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).UnlockResourceAsync(resourceLock, force, cancellationToken);

        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UnlockResourceAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, EntityType resourceType, bool force = false, CancellationToken cancellationToken = default) => UnlockResourceAsync(resourceLocks, lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetValue(), force, cancellationToken);

        /// <summary>
        /// Unlocks the specified resource in Encompass.
        /// </summary>
        /// <param name="resourceLocks">The Resource Locks Api Object.</param>
        /// <param name="lockId">The unique identifier assigned to the lock and returned in the response when the lock is created.</param>
        /// <param name="resourceId">GUID of the resource E.g. Loan GUID</param>
        /// <param name="resourceType">The type of resource is loan.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to true, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is false.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UnlockResourceAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).UnlockResourceAsync(lockId, resourceId, resourceType, force, cancellationToken);
    }
}