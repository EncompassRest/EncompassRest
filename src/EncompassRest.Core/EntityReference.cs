using System;
using System.ComponentModel;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest
{
    /// <summary>
    /// Object containing information about the entity.
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true, PropertiesToAlwaysSerialize = nameof(EntityType))]
    public class EntityReference : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// The ID of the entity.
        /// </summary>
        public string? EntityId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The entity type.
        /// </summary>
        public StringEnumValue<EntityType> EntityType { get => GetValue<StringEnumValue<EntityType>>(); set => SetValue(value); }

        /// <summary>
        /// The name of the entity.
        /// </summary>
        public string? EntityName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Entity reference URI.
        /// </summary>
        public string? EntityUri { get => GetValue<string?>(); set => SetValue(value); }

        [IdPropertyName(nameof(EntityId))]
        string? IIdentifiable.Id { get => EntityId; set => EntityId = value; }

        /// <summary>
        /// EntityReference constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public EntityReference(string entityId, EntityType entityType)
            : this(entityId, entityType.Validate(nameof(entityType)).GetValue())
        {
        }

        /// <summary>
        /// EntityReference constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public EntityReference(string entityId, string entityType)
        {
            Preconditions.NotNullOrEmpty(entityId, nameof(entityId));
            Preconditions.NotNullOrEmpty(entityType, nameof(entityType));

            EntityId = entityId;
            EntityType = entityType;
        }

        /// <summary>
        /// EntityReference deserialization constructor.
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public EntityReference()
        {
        }
    }
}