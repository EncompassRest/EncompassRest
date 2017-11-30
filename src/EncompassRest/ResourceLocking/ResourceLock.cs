using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.ResourceLocking
{
    public sealed class ResourceLock : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private Resource _resource;
        public Resource Resource { get => _resource ?? (_resource = new Resource()); set => _resource = value; }
        private DirtyValue<string> _userId;
        public string UserId { get => _userId; set => _userId = value; }
        private DirtyValue<string> _lockType;
        public string LockType { get => _lockType; set => _lockType = value; }
        private DirtyValue<string> _lockTime;
        public string LockTime { get => _lockTime; set => _lockTime = value; }

        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
                    || _resource.Dirty
                    || _userId.Dirty
                    || _lockType.Dirty
                    || _lockTime.Dirty;
            }
            set
            {
                _id.Dirty = value;
                _resource.Dirty = value;
                _userId.Dirty = value;
                _lockType.Dirty = value;
                _lockTime.Dirty = value;
            }
        }
    }
}
