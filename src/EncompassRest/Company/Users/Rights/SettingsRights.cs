using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// SettingsRights
    /// </summary>
    public sealed class SettingsRights : DirtyExtensibleObject
    {
        private CompanySettingsRights? _companySettings;
        private SettingsOtherRights? _other;
        private PersonalSettingsRights? _personalSettings;

        /// <summary>
        /// SettingsRights CompanySettings
        /// </summary>
        [AllowNull]
        public CompanySettingsRights CompanySettings { get => GetField(ref _companySettings); set => SetField(ref _companySettings, value); }

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