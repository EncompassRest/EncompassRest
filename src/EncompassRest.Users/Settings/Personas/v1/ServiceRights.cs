using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// ServiceRights
    /// </summary>
    public sealed class ServiceRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ServiceRights AccessSetting
        /// </summary>
        public StringEnumValue<AccessSetting> AccessSetting { get => GetValue<StringEnumValue<AccessSetting>>(); set => SetValue(value); }

        /// <summary>
        /// ServiceRights AllowedServices
        /// </summary>
        [AllowNull]
        public IList<string> AllowedServices { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// ServiceRights Category
        /// </summary>
        public StringEnumValue<ServiceCategory> Category { get => GetValue<StringEnumValue<ServiceCategory>>(); set => SetValue(value); }

        /// <summary>
        /// ServiceRights DefaultAccess
        /// </summary>
        public StringEnumValue<RightsDefaultAccess> DefaultAccess { get => GetValue<StringEnumValue<RightsDefaultAccess>>(); set => SetValue(value); }
    }
}