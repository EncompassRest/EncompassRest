using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public class EntityReference : ExtensibleObject
    {
        private DirtyValue<string> _entityId;
        public string EntityId { get => _entityId; set => _entityId = value; }
        private DirtyValue<StringEnumValue<EntityType>> _entityType;
        public StringEnumValue<EntityType> EntityType { get => _entityType; set => _entityType = value; }
        private DirtyValue<string> _entityName;
        public string EntityName { get => _entityName; set => _entityName = value; }
        private DirtyValue<string> _entityUri;
        public string EntityUri { get => _entityUri; set => _entityUri = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _entityId.Dirty
                    || _entityType.Dirty
                    || _entityName.Dirty
                    || _entityUri.Dirty;
            }
            set
            {
                _entityId.Dirty = value;
                _entityType.Dirty = value;
                _entityName.Dirty = value;
                _entityUri.Dirty = value;
            }
        }
    }
}