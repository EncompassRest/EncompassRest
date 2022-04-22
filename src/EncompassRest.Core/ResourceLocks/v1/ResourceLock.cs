using System;

namespace EncompassRest.ResourceLocks.v1
{
    /// <summary>
    /// ResourceLock
    /// </summary>
    public sealed class ResourceLock : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// The lockId, which is the unique identifier assigned to the lock and returned in the response when the lock is created.
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// References the entity ID and entity type.
        /// </summary>
        public EntityReference? Resource { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// The Encompass user ID of the user holding the lock.
        /// </summary>
        public string? UserId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the type of lock is exclusive or shared.
        /// </summary>
        public StringEnumValue<ResourceLockType> LockType { get => GetValue<StringEnumValue<ResourceLockType>>(); set => SetValue(value); }

        /// <summary>
        /// The date and time the resource was locked.
        /// </summary>
        public DateTime? LockTime { get => GetValue<DateTime?>(); set => SetValue(value); }
    }
}