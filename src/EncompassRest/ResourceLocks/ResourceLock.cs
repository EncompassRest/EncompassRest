using System;

namespace EncompassRest.ResourceLocks
{
    /// <summary>
    /// ResourceLock
    /// </summary>
    public sealed class ResourceLock : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private EntityReference _resource;
        private DirtyValue<string> _userId;
        private DirtyValue<StringEnumValue<ResourceLockType>> _lockType;
        private DirtyValue<DateTime?> _lockTime;

        /// <summary>
        /// The lockId, which is the unique identifier assigned to the lock and returned in the response when the lock is created.
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// References the entity ID and entity type.
        /// </summary>
        public EntityReference Resource { get => GetField(ref _resource); set => SetField(ref _resource, value); }

        /// <summary>
        /// The Encompass user ID of the user holding the lock.
        /// </summary>
        public string UserId { get => _userId; set => SetField(ref _userId, value); }

        /// <summary>
        /// Whether the type of lock is exclusive or shared.
        /// </summary>
        public StringEnumValue<ResourceLockType> LockType { get => _lockType; set => SetField(ref _lockType, value); }

        /// <summary>
        /// The date and time the resource was locked.
        /// </summary>
        public DateTime? LockTime { get => _lockTime; set => SetField(ref _lockTime, value); }
    }
}