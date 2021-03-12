using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// CompanySettingsRights
    /// </summary>
    public sealed class CompanySettingsRights : DirtyExtensibleObject
    {
        private AdditionalServicesRights? _additionalServices;
        private DirtyValue<bool?>? _automatedRequestForEConsent;
        private BusinessRulesRights? _businessRules;
        private CompanyUserSetupRights? _companyUserSetup;
        private ContactSetupRights? _contactSetup;
        private DocsSetupRights? _docsSetup;
        private DynamicDataManagementRights? _dynamicDataManagement;
        private EFolderSetupRights? _eFolderSetup;
        private DirtyValue<bool?>? _feeGroups;
        private LoanSetupRights? _loanSetup;
        private PersonalTemplatesRights? _personalTemplates;
        private SecondarySetupRights? _secondarySetup;
        private SystemAdministrationRights? _systemAdministration;
        private TablesAndFeesRights? _tablesAndFees;

        /// <summary>
        /// CompanySettingsRights AdditionalServices
        /// </summary>
        [AllowNull]
        public AdditionalServicesRights AdditionalServices { get => GetField(ref _additionalServices); set => SetField(ref _additionalServices, value); }

        /// <summary>
        /// CompanySettingsRights AutomatedRequestForEConsent
        /// </summary>
        public bool? AutomatedRequestForEConsent { get => _automatedRequestForEConsent; set => SetField(ref _automatedRequestForEConsent, value); }

        /// <summary>
        /// CompanySettingsRights BusinessRules
        /// </summary>
        [AllowNull]
        public BusinessRulesRights BusinessRules { get => GetField(ref _businessRules); set => SetField(ref _businessRules, value); }

        /// <summary>
        /// CompanySettingsRights CompanyUserSetup
        /// </summary>
        [JsonProperty("company/UserSetup")]
        public CompanyUserSetupRights CompanyUserSetup { get => GetField(ref _companyUserSetup); set => SetField(ref _companyUserSetup, value); }

        /// <summary>
        /// CompanySettingsRights ContactSetup
        /// </summary>
        [AllowNull]
        public ContactSetupRights ContactSetup { get => GetField(ref _contactSetup); set => SetField(ref _contactSetup, value); }

        /// <summary>
        /// CompanySettingsRights DocsSetup
        /// </summary>
        [AllowNull]
        public DocsSetupRights DocsSetup { get => GetField(ref _docsSetup); set => SetField(ref _docsSetup, value); }

        /// <summary>
        /// CompanySettingsRights DynamicDataManagement
        /// </summary>
        [AllowNull]
        public DynamicDataManagementRights DynamicDataManagement { get => GetField(ref _dynamicDataManagement); set => SetField(ref _dynamicDataManagement, value); }

        /// <summary>
        /// CompanySettingsRights EFolderSetup
        /// </summary>
        [AllowNull]
        public EFolderSetupRights EFolderSetup { get => GetField(ref _eFolderSetup); set => SetField(ref _eFolderSetup, value); }

        /// <summary>
        /// CompanySettingsRights FeeGroups
        /// </summary>
        public bool? FeeGroups { get => _feeGroups; set => SetField(ref _feeGroups, value); }

        /// <summary>
        /// CompanySettingsRights LoanSetup
        /// </summary>
        [AllowNull]
        public LoanSetupRights LoanSetup { get => GetField(ref _loanSetup); set => SetField(ref _loanSetup, value); }

        /// <summary>
        /// CompanySettingsRights PersonalTemplates
        /// </summary>
        [AllowNull]
        public PersonalTemplatesRights PersonalTemplates { get => GetField(ref _personalTemplates); set => SetField(ref _personalTemplates, value); }

        /// <summary>
        /// CompanySettingsRights SecondarySetup
        /// </summary>
        [AllowNull]
        public SecondarySetupRights SecondarySetup { get => GetField(ref _secondarySetup); set => SetField(ref _secondarySetup, value); }

        /// <summary>
        /// CompanySettingsRights SystemAdministration
        /// </summary>
        [AllowNull]
        public SystemAdministrationRights SystemAdministration { get => GetField(ref _systemAdministration); set => SetField(ref _systemAdministration, value); }

        /// <summary>
        /// CompanySettingsRights TablesAndFees
        /// </summary>
        [AllowNull]
        public TablesAndFeesRights TablesAndFees { get => GetField(ref _tablesAndFees); set => SetField(ref _tablesAndFees, value); }
    }
}