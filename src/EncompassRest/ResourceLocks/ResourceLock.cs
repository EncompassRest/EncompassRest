using System;

namespace EncompassRest.ResourceLocks
{
    public sealed class ResourceLock : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private EntityReference _resource;
        private DirtyValue<string> _userId;
        private DirtyValue<StringEnumValue<ResourceLockType>> _lockType;
        private DirtyValue<DateTime?> _lockTime;

        public string Id { get => _id; set => SetField(ref _id, value); }

        public EntityReference Resource { get => GetField(ref _resource); set => SetField(ref _resource, value); }

        public string UserId { get => _userId; set => SetField(ref _userId, value); }

        public StringEnumValue<ResourceLockType> LockType { get => _lockType; set => SetField(ref _lockType, value); }

        public DateTime? LockTime { get => _lockTime; set => SetField(ref _lockTime, value); }
    }
}