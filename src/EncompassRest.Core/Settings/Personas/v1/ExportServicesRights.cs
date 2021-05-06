using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// ExportServicesRights
    /// </summary>
    public sealed class ExportServicesRights : DirtyExtensibleObject
    {
        private DirtyValue<StringEnumValue<AccessSetting>>? _accessSetting;
        private DirtyValue<StringEnumValue<RightsDefaultAccess>>? _defaultAccess;
        private DirtyList<string>? _allowedServices;

        /// <summary>
        /// ExportServicesRights AccessSetting
        /// </summary>
        public StringEnumValue<AccessSetting> AccessSetting { get => _accessSetting; set => SetField(ref _accessSetting, value); }

        /// <summary>
        /// ExportServicesRights DefaultAccess
        /// </summary>
        public StringEnumValue<RightsDefaultAccess> DefaultAccess { get => _defaultAccess; set => SetField(ref _defaultAccess, value); }

        /// <summary>
        /// ExportServicesRights AllowedServices
        /// </summary>
        [AllowNull]
        public IList<string> AllowedServices { get => GetField(ref _allowedServices); set => SetField(ref _allowedServices, value); }
    }
}