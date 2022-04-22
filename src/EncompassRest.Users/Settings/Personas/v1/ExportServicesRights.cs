using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// ExportServicesRights
    /// </summary>
    public sealed class ExportServicesRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ExportServicesRights AccessSetting
        /// </summary>
        public StringEnumValue<AccessSetting> AccessSetting { get => GetValue<StringEnumValue<AccessSetting>>(); set => SetValue(value); }

        /// <summary>
        /// ExportServicesRights DefaultAccess
        /// </summary>
        public StringEnumValue<RightsDefaultAccess> DefaultAccess { get => GetValue<StringEnumValue<RightsDefaultAccess>>(); set => SetValue(value); }

        /// <summary>
        /// ExportServicesRights AllowedServices
        /// </summary>
        [AllowNull]
        public IList<string> AllowedServices { get => GetList<string>(); set => SetList(value); }
    }
}