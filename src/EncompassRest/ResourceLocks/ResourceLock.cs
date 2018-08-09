using System;

namespace EncompassRest.ResourceLocks
{
    public sealed class ResourceLock : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private EntityReference _resource; 
        public EntityReference Resource { get => _resource ?? (_resource = new EntityReference()); set => _resource = value; }
        private DirtyValue<string> _userId;
        public string UserId { get => _userId; set => _userId = value; }
        private DirtyValue<StringEnumValue<ResourceLockType>> _lockType;
        public StringEnumValue<ResourceLockType> LockType { get => _lockType; set => _lockType = value; }
        private DirtyValue<DateTime?> _lockTime;
        public DateTime? LockTime { get => _lockTime; set => _lockTime = value; }
    }
}