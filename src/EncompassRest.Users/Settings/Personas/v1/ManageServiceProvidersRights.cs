using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// ManageServiceProvidersRights
    /// </summary>
    public sealed class ManageServiceProvidersRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ManageServiceProvidersRights AccessSetting
        /// </summary>
        public StringEnumValue<AccessSetting> AccessSetting { get => GetValue<StringEnumValue<AccessSetting>>(); set => SetValue(value); }

        /// <summary>
        /// ManageServiceProvidersRights Rights
        /// </summary>
        [AllowNull]
        public IList<string> Rights { get => GetList<string>(); set => SetList(value); }
    }
}