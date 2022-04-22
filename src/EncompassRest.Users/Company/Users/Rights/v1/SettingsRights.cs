using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SettingsRights
    /// </summary>
    public sealed class SettingsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// SettingsRights AIQLaunchType
        /// </summary>
        public bool? AIQLaunchType { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SettingsRights CompanySettings
        /// </summary>
        [AllowNull]
        public CompanySettingsRights CompanySettings { get => GetEntity<CompanySettingsRights>(); set => SetEntity(value); }

        /// <summary>
        /// SettingsRights EncompassAIQAccess
        /// </summary>
        public bool? EncompassAIQAccess { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SettingsRights Other
        /// </summary>
        [AllowNull]
        public SettingsOtherRights Other { get => GetEntity<SettingsOtherRights>(); set => SetEntity(value); }

        /// <summary>
        /// SettingsRights PersonalSettings
        /// </summary>
        [AllowNull]
        public PersonalSettingsRights PersonalSettings { get => GetEntity<PersonalSettingsRights>(); set => SetEntity(value); }
    }
}