using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.ResourceLocks
{
    public sealed class Resource : ExtensibleObject, IIdentifiable
    {
        public string EntityId { get; set; }
        public StringEnumValue<ResourceEntityType> EntityType { get; set; }

        [IdPropertyName(nameof(EntityId))]
        string IIdentifiable.Id { get => EntityId; set => EntityId = value; }
    }
}
