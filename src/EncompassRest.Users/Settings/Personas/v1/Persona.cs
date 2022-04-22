using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// Persona
    /// </summary>
    public sealed class Persona : DirtyExtensibleObject
    {
        /// <summary>
        /// Persona ID
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Name of the persona.
        /// </summary>
        public string? Name { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the persona has access granted to all Encompass features or access to no features.
        /// </summary>
        public StringEnumValue<DefaultAccess> DefaultAccess { get => GetValue<StringEnumValue<DefaultAccess>>(); set => SetValue(value); }

        /// <summary>
        /// Whether the persona is an Internal persona
        /// </summary>
        public bool? IsInternal { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Whether the persona is an external persona. A persona can be internal and/ or external.
        /// </summary>
        public bool? IsExternal { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The order in which the persona is to be displayed.
        /// </summary>
        public int? DisplayOrder { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Access Rights associated with the persona. All the rights that are enabled for the persona are returned as part of this object.
        /// </summary>
        [AllowNull]
        public AclRights AclRights { get => GetEntity<AclRights>(); set => SetEntity(value); }
}
}
