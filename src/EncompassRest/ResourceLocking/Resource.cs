using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.ResourceLocking
{
    public sealed class Resource : ExtensibleObject
    {
        private DirtyValue<string> _entityId;
        public string EntityId { get => _entityId; set => _entityId = value; }
        private DirtyValue<string> _entityType;
        public string EntityType { get => _entityType; set => _entityType = value; }

        internal override bool DirtyInternal
        {
            get
            {
                return _entityId.Dirty
                    || _entityType.Dirty;
            }
            set
            {
                _entityId.Dirty = value;
                _entityType.Dirty = value;
            }
        }
    }
}
