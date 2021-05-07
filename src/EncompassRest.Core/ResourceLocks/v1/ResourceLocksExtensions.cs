using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.ResourceLocks.v1
{
    public static class ResourceLocksExtensions
    {
        public static IResourceLocksV1? V1 { get; set; }

        private static IResourceLocksV1 GetV1(IResourceLocks resourceLocks)
        {
            var v1 = V1;
            if (resourceLocks is ResourceLocks l)
            {
                v1 = (IResourceLocksV1)l.ExtensionData.GetOrAdd("v1", k => new ResourceLocksV1(l.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(resourceLocks, nameof(resourceLocks));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        public static Task<ResourceLock> GetResourceLockAsync(this IResourceLocks resourceLocks, ResourceLock resourceLock, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLockAsync(resourceLock, cancellationToken);

        public static Task<ResourceLock> GetResourceLockAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLockAsync(resourceLocks, lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetValue()!, cancellationToken);

        public static Task<ResourceLock> GetResourceLockAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, string resourceType, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLockAsync(lockId, resourceId, resourceType, cancellationToken);

        public static Task<string> GetResourceLockRawAsync(this IResourceLocks resourceLocks, string lockId, string queryString, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLockRawAsync(lockId, queryString, cancellationToken);

        public static Task<List<ResourceLock>> GetResourceLocksAsync(this IResourceLocks resourceLocks, string resourceId, EntityType resourceType, CancellationToken cancellationToken = default) => GetResourceLocksAsync(resourceLocks, resourceId, resourceType.Validate(nameof(resourceType)).GetValue()!, cancellationToken);

        public static Task<List<ResourceLock>> GetResourceLocksAsync(this IResourceLocks resourceLocks, string resourceId, string resourceType, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLocksAsync(resourceId, resourceType, cancellationToken);

        public static Task<string> GetResourceLocksRawAsync(this IResourceLocks resourceLocks, string queryString, CancellationToken cancellationToken = default) => GetV1(resourceLocks).GetResourceLocksRawAsync(queryString, cancellationToken);

        public static Task<string> LockResourceAsync(this IResourceLocks resourceLocks, ResourceLock resourceLock, bool force = false, bool populate = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).LockResourceAsync(resourceLock, force, populate, cancellationToken);

        public static Task<string> LockResourceAsync(this IResourceLocks resourceLocks, ResourceLockType lockType, string resourceId, EntityType resourceType, bool force = false, CancellationToken cancellationToken = default) => LockResourceAsync(resourceLocks, lockType.Validate(nameof(lockType)).GetValue()!, resourceId, resourceType.Validate(nameof(resourceType)).GetValue()!, force, cancellationToken);

        public static Task<string> LockResourceAsync(this IResourceLocks resourceLocks, string lockType, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).LockResourceAsync(lockType, resourceId, resourceType, force, cancellationToken);

        public static Task<string> LockResourceRawAsync(this IResourceLocks resourceLocks, string resourceLock, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(resourceLocks).LockResourceRawAsync(resourceLock, queryString, cancellationToken);

        public static Task<bool> TryUnlockResourceAsync(this IResourceLocks resourceLocks, ResourceLock resourceLock, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).TryUnlockResourceAsync(resourceLock, force, cancellationToken);

        public static Task<bool> TryUnlockResourceAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, EntityType resourceType, bool force = false, CancellationToken cancellationToken = default) => TryUnlockResourceAsync(resourceLocks, lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetValue()!, force, cancellationToken);

        public static Task<bool> TryUnlockResourceAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).TryUnlockResourceAsync(lockId, resourceId, resourceType, force, cancellationToken);

        public static Task UnlockResourceAsync(this IResourceLocks resourceLocks, ResourceLock resourceLock, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).UnlockResourceAsync(resourceLock, force, cancellationToken);

        public static Task UnlockResourceAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, EntityType resourceType, bool force = false, CancellationToken cancellationToken = default) => UnlockResourceAsync(resourceLocks, lockId, resourceId, resourceType.Validate(nameof(resourceType)).GetValue()!, force, cancellationToken);

        public static Task UnlockResourceAsync(this IResourceLocks resourceLocks, string lockId, string resourceId, string resourceType, bool force = false, CancellationToken cancellationToken = default) => GetV1(resourceLocks).UnlockResourceAsync(lockId, resourceId, resourceType, force, cancellationToken);
    }
}