using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SettingsRights
    /// </summary>
    public sealed class SettingsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _aIQLaunchType;
        private CompanySettingsRights? _companySettings;
        private DirtyValue<bool?>? _encompassAIQAccess;
        private SettingsOtherRights? _other;
        private PersonalSettingsRights? _personalSettings;

        /// <summary>
        /// SettingsRights AIQLaunchType
        /// </summary>
        public bool? AIQLaunchType { get => _aIQLaunchType; set => SetField(ref _aIQLaunchType, value); }

        /// <summary>
        /// SettingsRights CompanySettings
        /// </summary>
        [AllowNull]
        public CompanySettingsRights CompanySettings { get => GetField(ref _companySettings); set => SetField(ref _companySettings, value); }

        /// <summary>
        /// SettingsRights EncompassAIQAccess
        /// </summary>
        public bool? EncompassAIQAccess { get => _encompassAIQAccess; set => SetField(ref _encompassAIQAccess, value); }

        /// <summary>
        /// SettingsRights Other
        /// </summary>
        [AllowNull]
        public SettingsOtherRights Other { get => GetField(ref _other); set => SetField(ref _other, value); }

        /// <summary>
        /// SettingsRights PersonalSettings
        /// </summary>
        [AllowNull]
        public PersonalSettingsRights PersonalSettings { get => GetField(ref _personalSettings); set => SetField(ref _personalSettings, value); }
    }
}