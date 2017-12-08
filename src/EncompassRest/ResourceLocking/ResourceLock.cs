using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.ResourceLocking
{
    public sealed class ResourceLock : ExtensibleObject
    {
        public string Id { get; set; }
        public Resource Resource { get; set; }
        public string UserId { get; set; }
        public ResourceLockType LockType { get; set; }
        public string LockTime { get; set; }
    }
}
