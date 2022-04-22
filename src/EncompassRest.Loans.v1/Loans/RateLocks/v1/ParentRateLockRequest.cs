using Newtonsoft.Json;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// ParentRateLockRequest
    /// </summary>
    public sealed partial class ParentRateLockRequest : EntityReference
    {
        /// <summary>
        /// Lock request type of the parent lock request.
        /// </summary>
        public string? RequestType { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Lock status of the parent lock request.
        /// </summary>
        public string? LockStatus { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// ParentRateLockRequest constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public ParentRateLockRequest(string entityId, EntityType entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// ParentRateLockRequest constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        [JsonConstructor]
        public ParentRateLockRequest(string entityId, string entityType)
            : base(entityId, entityType)
        {
        }
    }
}