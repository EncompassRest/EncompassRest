namespace EncompassRest
{
    public class EntityReference : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _entityId;
        public string EntityId { get => _entityId; set => _entityId = value; }
        private DirtyValue<StringEnumValue<EntityType>> _entityType;
        public StringEnumValue<EntityType> EntityType { get => _entityType; set => _entityType = value; }
        private DirtyValue<string> _entityName;
        public string EntityName { get => _entityName; set => _entityName = value; }
        private DirtyValue<string> _entityUri;
        public string EntityUri { get => _entityUri; set => _entityUri = value; }

        [IdPropertyName(nameof(EntityId))]
        string IIdentifiable.Id { get => EntityId; set => EntityId = value; }
    }
}