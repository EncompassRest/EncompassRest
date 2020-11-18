using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// ParentRateLockRequest
    /// </summary>
    public sealed partial class ParentRateLockRequest : DirtyExtensibleObject
    {
        private DirtyValue<string?>? _requestType;
        private DirtyValue<string?>? _lockStatus;
        private DirtyValue<string?>? _entityId;
        private DirtyValue<string?>? _entityType;
        private DirtyValue<string?>? _entityName;
        private DirtyValue<string?>? _entityUri;

        /// <summary>
        /// Lock request type of the parent lock request.
        /// </summary>
        public string? RequestType { get => _requestType; set => SetField(ref _requestType, value); }

        /// <summary>
        /// Lock status of the parent lock request.
        /// </summary>
        public string? LockStatus { get => _lockStatus; set => SetField(ref _lockStatus, value); }

        /// <summary>
        /// Unique identifier of the parent lock request.
        /// </summary>
        public string? EntityId { get => _entityId; set => SetField(ref _entityId, value); }

        /// <summary>
        /// Type of the entity (lock request).
        /// </summary>
        public string? EntityType { get => _entityType; set => SetField(ref _entityType, value); }

        /// <summary>
        /// Name of the parent lock request.
        /// </summary>
        public string? EntityName { get => _entityName; set => SetField(ref _entityName, value); }

        /// <summary>
        /// Location of the parent lock request.
        /// </summary>
        public string? EntityUri { get => _entityUri; set => SetField(ref _entityUri, value); }
    }
}