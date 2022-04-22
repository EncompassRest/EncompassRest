using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CompanySettingsRights
    /// </summary>
    public sealed class CompanySettingsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// CompanySettingsRights AdditionalServices
        /// </summary>
        [AllowNull]
        public AdditionalServicesRights AdditionalServices { get => GetEntity<AdditionalServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights AutomatedRequestForEConsent
        /// </summary>
        public bool? AutomatedRequestForEConsent { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanySettingsRights BusinessRules
        /// </summary>
        [AllowNull]
        public BusinessRulesRights BusinessRules { get => GetEntity<BusinessRulesRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights CompanyUserSetup
        /// </summary>
        [JsonProperty("company/UserSetup")]
        public CompanyUserSetupRights CompanyUserSetup { get => GetEntity<CompanyUserSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights ContactSetup
        /// </summary>
        [AllowNull]
        public ContactSetupRights ContactSetup { get => GetEntity<ContactSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights DocsSetup
        /// </summary>
        [AllowNull]
        public DocsSetupRights DocsSetup { get => GetEntity<DocsSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights DynamicDataManagement
        /// </summary>
        [AllowNull]
        public DynamicDataManagementRights DynamicDataManagement { get => GetEntity<DynamicDataManagementRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights EFolderSetup
        /// </summary>
        [AllowNull]
        public EFolderSetupRights EFolderSetup { get => GetEntity<EFolderSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights FeeGroups
        /// </summary>
        public bool? FeeGroups { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanySettingsRights LoanSetup
        /// </summary>
        [AllowNull]
        public LoanSetupRights LoanSetup { get => GetEntity<LoanSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights PersonalTemplates
        /// </summary>
        [AllowNull]
        public PersonalTemplatesRights PersonalTemplates { get => GetEntity<PersonalTemplatesRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights SecondarySetup
        /// </summary>
        [AllowNull]
        public SecondarySetupRights SecondarySetup { get => GetEntity<SecondarySetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights SystemAdministration
        /// </summary>
        [AllowNull]
        public SystemAdministrationRights SystemAdministration { get => GetEntity<SystemAdministrationRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanySettingsRights TablesAndFees
        /// </summary>
        [AllowNull]
        public TablesAndFeesRights TablesAndFees { get => GetEntity<TablesAndFeesRights>(); set => SetEntity(value); }
    }
}