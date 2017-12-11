using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.ResourceLocking
{
    public sealed class Resource : ExtensibleObject
    {
        public string EntityId { get; set; }
        public StringEnumValue<ResourceEntityType> EntityType { get; set; }
    }
}
