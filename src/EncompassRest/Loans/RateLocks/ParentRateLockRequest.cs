using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// ParentRateLockRequest
    /// </summary>
    public sealed partial class ParentRateLockRequest : EntityReference
    {
        private DirtyValue<string?>? _requestType;
        private DirtyValue<string?>? _lockStatus;

        /// <summary>
        /// Lock request type of the parent lock request.
        /// </summary>
        public string? RequestType { get => _requestType; set => SetField(ref _requestType, value); }

        /// <summary>
        /// Lock status of the parent lock request.
        /// </summary>
        public string? LockStatus { get => _lockStatus; set => SetField(ref _lockStatus, value); }

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