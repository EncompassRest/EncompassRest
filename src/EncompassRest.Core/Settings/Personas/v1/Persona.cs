using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// Persona
    /// </summary>
    public sealed class Persona : DirtyExtensibleObject
    {
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _name;
        private DirtyValue<StringEnumValue<DefaultAccess>>? _defaultAccess;
        private DirtyValue<bool?>? _isInternal;
        private DirtyValue<bool?>? _isExternal;
        private DirtyValue<int?>? _displayOrder;
        private AclRights? _aclRights;

        /// <summary>
        /// Persona ID
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Name of the persona.
        /// </summary>
        public string? Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// Whether the persona has access granted to all Encompass features or access to no features.
        /// </summary>
        public StringEnumValue<DefaultAccess> DefaultAccess { get => _defaultAccess; set => SetField(ref _defaultAccess, value); }

        /// <summary>
        /// Whether the persona is an Internal persona
        /// </summary>
        public bool? IsInternal { get => _isInternal; set => SetField(ref _isInternal, value); }

        /// <summary>
        /// Whether the persona is an external persona. A persona can be internal and/ or external.
        /// </summary>
        public bool? IsExternal { get => _isExternal; set => SetField(ref _isExternal, value); }

        /// <summary>
        /// The order in which the persona is to be displayed.
        /// </summary>
        public int? DisplayOrder { get => _displayOrder; set => SetField(ref _displayOrder, value); }

        /// <summary>
        /// Access Rights associated with the persona. All the rights that are enabled for the persona are returned as part of this object.
        /// </summary>
        [AllowNull]
        public AclRights AclRights { get => GetField(ref _aclRights); set => SetField(ref _aclRights, value); }
}
}
