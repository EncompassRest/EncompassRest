using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest
{
    [Entity(SerializeWholeListWhenDirty = true, PropertiesToAlwaysSerialize = nameof(EntityType))]
    public class EntityReference : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _entityId;
        private DirtyValue<StringEnumValue<EntityType>> _entityType;
        private DirtyValue<string> _entityName;
        private DirtyValue<string> _entityUri;

        public string EntityId { get => _entityId; set => SetField(ref _entityId, value); }

        public StringEnumValue<EntityType> EntityType { get => _entityType; set => SetField(ref _entityType, value); }

        public string EntityName { get => _entityName; set => SetField(ref _entityName, value); }

        public string EntityUri { get => _entityUri; set => SetField(ref _entityUri, value); }

        [IdPropertyName(nameof(EntityId))]
        string IIdentifiable.Id { get => EntityId; set => EntityId = value; }

        public EntityReference(string entityId, EntityType entityType)
            : this(entityId, entityType.Validate(nameof(entityType)).GetValue())
        {
        }
        
        public EntityReference(string entityId, string entityType)
        {
            Preconditions.NotNullOrEmpty(entityId, nameof(entityId));
            Preconditions.NotNullOrEmpty(entityType, nameof(entityType));

            EntityId = entityId;
            EntityType = entityType;
        }

        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public EntityReference()
        {
        }
    }
}