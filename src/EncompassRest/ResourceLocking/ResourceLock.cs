using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.ResourceLocks
{
    public sealed class ResourceLock : ExtensibleObject, IIdentifiable
    {
        public string Id { get; set; }
        public Resource Resource { get; set; }
        public string UserId { get; set; }
        public StringEnumValue<ResourceLockType> LockType { get; set; }
        public string LockTime { get; set; }

    }
}
