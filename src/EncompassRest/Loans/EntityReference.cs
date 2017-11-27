using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public class EntityReference
    {
        public string EntityId { get; set; }
        public StringEnumValue<EntityType> EntityType { get; set; }
        public string EntityName { get; set; }
        public string EntityUri { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}