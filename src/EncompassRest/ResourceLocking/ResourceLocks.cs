using EncompassRest.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncompassRest.ResourceLocking
{
    public sealed class ResourceLocks : ApiObject
    {
        internal ResourceLocks(EncompassRestClient client) : 
            base(client, "encompass/v1/resourceLocks")
        {
        }

        public Task<ResourceLock> GetResourceLockAsync(string resourceId, string lockId,  CancellationToken cancellationToken) => GetResourceLockAsync(resourceId, lockId, ResourceEntityType.Loan, cancellationToken);
        private Task<ResourceLock> GetResourceLockAsync(string resourceId, string lockId, ResourceEntityType resourceType, CancellationToken cancellationToken = CancellationToken.None)
        {
            Preconditions.NotNullOrEmpty(resourceId, nameof(resourceId));
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            Preconditions.NotNullOrEmpty(lockId, nameof(lockId));

            return GetAsync(lockId, $"resourceType={resourceType}&resourceId={resourceId}", nameof(GetResourceLockAsync), lockId, cancellationToken, async response =>
               {
                   var resourceLock = await response.Content.ReadAsAsync<ResourceLock>().ConfigureAwait(false);
                   resourceLock.Dirty = false;
                   return resourceLock;
               });
        }

        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceType) => GetResourceLocksAsync(resourceType, "loan", CancellationToken.None);
        public Task<List<ResourceLock>> GetResourceLocksAsync(string resourceType, CancellationToken cancellationToken) => GetResourceLocksAsync(resourceType, "loan", cancellationToken);
        private Task<List<ResourceLock>> GetResourceLocksAsync(string resourceType, string resourceId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(resourceType, nameof(resourceType));
            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("resourceType", resourceType));
            queryParameters.Add(new QueryParameter("resourceId", resourceId));
            return GetAsync(null, queryParameters.ToString(), nameof(GetResourceLocksAsync), null, cancellationToken, async response =>
             {
                 var resourceLocks = await response.Content.ReadAsAsync<List<ResourceLock>>().ConfigureAwait(false);
                 foreach (var resourceLock in resourceLocks)
                 {
                     resourceLock.Dirty = false;
                 }
                 return resourceLocks;
             });
        }

        public Task<string> LockResourceAsync(ResourceLock resource) => LockResourceAsync(resource, false, false, CancellationToken.None);
        public Task<string> LockResourceAsync(ResourceLock resource, bool force) => LockResourceAsync(resource, force, false, CancellationToken.None);
        public Task<string> LockResourceAsync(ResourceLock resource, bool force, bool populate) => LockResourceAsync(resource, force, populate, CancellationToken.None);
        public Task<string> LockResourceAsync(ResourceLock resource, CancellationToken cancellationToken) => LockResourceAsync(resource, false, false, cancellationToken);
        public Task<string> LockResourceAsync(ResourceLock resource, bool force, CancellationToken cancellationToken) => LockResourceAsync(resource, force, false, cancellationToken);
        public Task<string> LockResourceAsync(ResourceLock resource, bool force, bool populate, CancellationToken cancellationToken)
        {
            Preconditions.NotNull(resource, nameof(resource));
            Preconditions.NotNullOrEmpty(resource.Resource.EntityId, $"{nameof(resource)}.{nameof(resource.Resource)}.{nameof(resource.Resource.EntityId)}");
            Preconditions.NotNullOrEmpty(resource.Resource.EntityType, $"{nameof(resource)}.{nameof(resource.Resource)}.{nameof(resource.Resource.EntityType)}");
            Preconditions.NotNullOrEmpty(resource.LockType, $"{nameof(resource)}.{nameof(resource.LockType)}");

            var queryParameters = new QueryParameters();
            queryParameters.Add(new QueryParameter("view", populate ? "entity" : "id"));
            queryParameters.Add(new QueryParameter("force", force? "true" : "false"));


            return PostAsync(JsonStreamContent.Create(resource), null, queryParameters.ToString(), nameof(LockResourceAsync), null, cancellationToken, async response =>
               {
                   if (populate)
                   {
                       await response.Content.PopulateAsync(resource).ConfigureAwait(false);
                   }
                   resource.Dirty = false;
                   return Path.GetFileName(response.Headers.Location.OriginalString);
               });
        }

        public Task<bool> UnlockResourceAsync(string resourceId, string lockId) => UnlockResourceAsync(resourceId, lockId, "loan", false, CancellationToken.None);
        public Task<bool> UnlockResourceAsync(string resourceId, string lockId, bool force) => UnlockResourceAsync(resourceId, lockId, "loan", force, CancellationToken.None);
        public Task<bool> UnlockResourceAsync(string resourceId, string lockId, CancellationToken cancellationToken) => UnlockResourceAsync(resourceId, lockId, "loan", false, cancellationToken);
        public Task<bool> UnlockResourceAsync(string resourceId, string lockId, bool force, CancellationToken cancellationToken) => UnlockResourceAsync(resourceId, lockId, "loan", force, cancellationToken);
        private Task<bool> UnlockResourceAsync(string resourceId, string lockId, string resourceType, bool force, CancellationToken cancellationToken)
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
    }
}
