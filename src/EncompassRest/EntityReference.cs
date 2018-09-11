namespace EncompassRest
{
    public class EntityReference : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _entityId;
        public string EntityId { get => _entityId; set => SetField(ref _entityId, value); }
        private DirtyValue<StringEnumValue<EntityType>> _entityType;
        public StringEnumValue<EntityType> EntityType { get => _entityType; set => SetField(ref _entityType, value); }
        private DirtyValue<string> _entityName;
        public string EntityName { get => _entityName; set => SetField(ref _entityName, value); }
        private DirtyValue<string> _entityUri;
        public string EntityUri { get => _entityUri; set => SetField(ref _entityUri, value); }

        [IdPropertyName(nameof(EntityId))]
        string IIdentifiable.Id { get => EntityId; set => EntityId = value; }
    }
}