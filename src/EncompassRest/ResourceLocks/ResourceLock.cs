using System;

namespace EncompassRest.ResourceLocks
{
    public sealed class ResourceLock : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => SetField(ref _id, value); }
        private EntityReference _resource; 
        public EntityReference Resource { get => GetField(ref _resource); set => SetField(ref _resource, value); }
        private DirtyValue<string> _userId;
        public string UserId { get => _userId; set => SetField(ref _userId, value); }
        private DirtyValue<StringEnumValue<ResourceLockType>> _lockType;
        public StringEnumValue<ResourceLockType> LockType { get => _lockType; set => SetField(ref _lockType, value); }
        private DirtyValue<DateTime?> _lockTime;
        public DateTime? LockTime { get => _lockTime; set => SetField(ref _lockTime, value); }
    }
}