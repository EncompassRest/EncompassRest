using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// ManageServiceProvidersRights
    /// </summary>
    public sealed class ManageServiceProvidersRights : DirtyExtensibleObject
    {
        private DirtyValue<StringEnumValue<AccessSetting>>? _accessSetting;
        private DirtyList<string>? _rights;

        /// <summary>
        /// ManageServiceProvidersRights AccessSetting
        /// </summary>
        public StringEnumValue<AccessSetting> AccessSetting { get => _accessSetting; set => SetField(ref _accessSetting, value); }

        /// <summary>
        /// ManageServiceProvidersRights Rights
        /// </summary>
        [AllowNull]
        public IList<string> Rights { get => GetField(ref _rights); set => SetField(ref _rights, value); }
    }
}