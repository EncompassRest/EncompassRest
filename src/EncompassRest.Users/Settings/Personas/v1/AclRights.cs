using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// Access Rights associated with the persona. All the rights that are enabled for the persona are returned as part of this object.
    /// </summary>
    public sealed class AclRights : DirtyExtensibleObject
    {
        private DirtyList<string>? _access;
        private AdditionalServicesRights? _additionalServices;
        private AusTrackingRights? _ausTracking;
        private BorrowerContactsRights? _borrowerContacts;
        private BusinessContactsRights? _businessContacts;
        private BusinessRulesRights? _businessRules;
        private DirtyList<string>? _closingDocs;
        private CompanyUserSetupRights? _companyUserSetup;
        private ContactsRights? _contacts;
        private ContactSetupRights? _contactSetup;
        private DirtyList<string>? _consumerConnect;
        private DashboardRights? _dashboard;
        private DeliveryConditionsRights? _deliveryConditions;
        private DisclosureTrackingRights? _disclosureTracking;
        private DocsSetupRights? _docsSetup;
        private DocumentsRights? _documents;
        private DirtyList<EntityReference>? _duplicateLoans;
        private DynamicDataManagementRights? _dynamicDataManagement;
        private EDisclosuresRights? _eDisclosures;
        private EFolderHistoryRights? _eFolderHistory;
        private EFolderSetupRights? _eFolderSetup;
        private EncompassWebServicesRights? _encompassWebServices;
        private EnhancedConditionsRights? _enhancedConditions;
        private DirtyList<string>? _externalSettings;
        private FileContactsRights? _fileContacts;
        private DirtyList<EntityReference>? _forms;
        private GseServicesRights? _gseServices;
        private DirtyList<string>? _home;
        private DirtyList<EntityReference>? _importLoans;
        private DirtyList<string>? _itemizationFee;
        private DirtyList<string>? _loan;
        private LoanSetupRights? _loanSetup;
        private LoConnectTasksRights? _loConnectTasks;
        private ManageServiceProvidersRights? _manageServiceProviders;
        private MilestoneWorkflowManagementRights? _milestoneWorkflowManagement;
        private MoveLoansRights? _moveLoans;
        private DirtyList<string>? _personalSettings;
        private PersonalTemplatesRights? _personalTemplates;
        private PipelineRights? _pipeline;
        private ExportServicesRights? _exportServices;
        private PostClosingConditionsRights? _postClosingConditions;
        private PreliminaryConditionsRights? _preliminaryConditions;
        private PurchaseConditionsRights? _purchaseConditions;
        private DirtyList<string>? _reports;
        private PrintRights? _print;
        private SecondarySetupRights? _secondarySetup;
        private SellConditionsRights? _sellConditions;
        private DirtyList<ServiceRights>? _services;
        private DirtyList<string>? _settings;
        private DirtyList<string>? _smartClient;
        private SystemAdministrationRights? _systemAdministration;
        private TablesAndFeesRights? _tablesAndFees;
        private DirtyList<EntityReference>? _tools;
        private TpoCompanyDetailsRights? _tpoCompanyDetails;
        private TpoConnectSiteSettingsRights? _tpoConnectSiteSettings;
        private TpoContactsRights? _tpoContacts;
        private TpoFeesRights? _tpoFees;
        private TpoInformationRights? _tpoInformation;
        private TpoOrganizationSettingsRights? _tpoOrganizationSettings;
        private TqlServicesRights? _tqlServices;
        private TradesRights? _trades;
        private UnderwritingCenterRights? _underwritingCenter;
        private UnderwritingConditionsRights? _underwritingConditions;

        /// <summary>
        /// AclRights Access
        /// </summary>
        [AllowNull]
        public IList<string> Access { get => GetField(ref _access); set => SetField(ref _access, value); }

        /// <summary>
        /// AclRights AdditionalServices
        /// </summary>
        [AllowNull]
        public AdditionalServicesRights AdditionalServices { get => GetField(ref _additionalServices); set => SetField(ref _additionalServices, value); }

        /// <summary>
        /// AclRights AusTracking
        /// </summary>
        [AllowNull]
        public AusTrackingRights AusTracking { get => GetField(ref _ausTracking); set => SetField(ref _ausTracking, value); }

        /// <summary>
        /// AclRights BorrowerContacts
        /// </summary>
        [AllowNull]
        public BorrowerContactsRights BorrowerContacts { get => GetField(ref _borrowerContacts); set => SetField(ref _borrowerContacts, value); }

        /// <summary>
        /// AclRights BusinessContacts
        /// </summary>
        [AllowNull]
        public BusinessContactsRights BusinessContacts { get => GetField(ref _businessContacts); set => SetField(ref _businessContacts, value); }

        /// <summary>
        /// AclRights BusinessRules
        /// </summary>
        [AllowNull]
        public BusinessRulesRights BusinessRules { get => GetField(ref _businessRules); set => SetField(ref _businessRules, value); }

        /// <summary>
        /// AclRights ClosingDocs
        /// </summary>
        [AllowNull]
        public IList<string> ClosingDocs { get => GetField(ref _closingDocs); set => SetField(ref _closingDocs, value); }

        /// <summary>
        /// AclRights CompanyUserSetup
        /// </summary>
        [AllowNull]
        public CompanyUserSetupRights CompanyUserSetup { get => GetField(ref _companyUserSetup); set => SetField(ref _companyUserSetup, value); }

        /// <summary>
        /// AclRights Contacts
        /// </summary>
        [AllowNull]
        public ContactsRights Contacts { get => GetField(ref _contacts); set => SetField(ref _contacts, value); }

        /// <summary>
        /// AclRights ContactSetup
        /// </summary>
        [AllowNull]
        public ContactSetupRights ContactSetup { get => GetField(ref _contactSetup); set => SetField(ref _contactSetup, value); }

        /// <summary>
        /// AclRights ConsumerConnect
        /// </summary>
        [AllowNull]
        public IList<string> ConsumerConnect { get => GetField(ref _consumerConnect); set => SetField(ref _consumerConnect, value); }

        /// <summary>
        /// AclRights Dashboard
        /// </summary>
        [AllowNull]
        public DashboardRights Dashboard { get => GetField(ref _dashboard); set => SetField(ref _dashboard, value); }

        /// <summary>
        /// AclRights DeliveryConditions
        /// </summary>
        [AllowNull]
        public DeliveryConditionsRights DeliveryConditions { get => GetField(ref _deliveryConditions); set => SetField(ref _deliveryConditions, value); }

        /// <summary>
        /// AclRights DisclosureTracking
        /// </summary>
        [AllowNull]
        public DisclosureTrackingRights DisclosureTracking { get => GetField(ref _disclosureTracking); set => SetField(ref _disclosureTracking, value); }

        /// <summary>
        /// AclRights DocsSetup
        /// </summary>
        [AllowNull]
        public DocsSetupRights DocsSetup { get => GetField(ref _docsSetup); set => SetField(ref _docsSetup, value); }

        /// <summary>
        /// AclRights Documents
        /// </summary>
        [AllowNull]
        public DocumentsRights Documents { get => GetField(ref _documents); set => SetField(ref _documents, value); }

        /// <summary>
        /// AclRights DuplicateLoans
        /// </summary>
        [AllowNull]
        public IList<EntityReference> DuplicateLoans { get => GetField(ref _duplicateLoans); set => SetField(ref _duplicateLoans, value); }

        /// <summary>
        /// AclRights DynamicDataManagement
        /// </summary>
        [AllowNull]
        public DynamicDataManagementRights DynamicDataManagement { get => GetField(ref _dynamicDataManagement); set => SetField(ref _dynamicDataManagement, value); }

        /// <summary>
        /// AclRights EDisclosures
        /// </summary>
        [AllowNull]
        public EDisclosuresRights EDisclosures { get => GetField(ref _eDisclosures); set => SetField(ref _eDisclosures, value); }

        /// <summary>
        /// AclRights EFolderHistory
        /// </summary>
        [AllowNull]
        public EFolderHistoryRights EFolderHistory { get => GetField(ref _eFolderHistory); set => SetField(ref _eFolderHistory, value); }

        /// <summary>
        /// AclRights EFolderSetup
        /// </summary>
        [AllowNull]
        public EFolderSetupRights EFolderSetup { get => GetField(ref _eFolderSetup); set => SetField(ref _eFolderSetup, value); }

        /// <summary>
        /// AclRights EncompassWebServices
        /// </summary>
        [AllowNull]
        public EncompassWebServicesRights EncompassWebServices { get => GetField(ref _encompassWebServices); set => SetField(ref _encompassWebServices, value); }

        /// <summary>
        /// AclRights EnhancedConditions
        /// </summary>
        [AllowNull]
        public EnhancedConditionsRights EnhancedConditions { get => GetField(ref _enhancedConditions); set => SetField(ref _enhancedConditions, value); }

        /// <summary>
        /// AclRights ExternalSettings
        /// </summary>
        [AllowNull]
        public IList<string> ExternalSettings { get => GetField(ref _externalSettings); set => SetField(ref _externalSettings, value); }

        /// <summary>
        /// AclRights FileContacts
        /// </summary>
        [AllowNull]
        public FileContactsRights FileContacts { get => GetField(ref _fileContacts); set => SetField(ref _fileContacts, value); }

        /// <summary>
        /// AclRights Forms
        /// </summary>
        [AllowNull]
        public IList<EntityReference> Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }

        /// <summary>
        /// AclRights GseServices
        /// </summary>
        [AllowNull]
        public GseServicesRights GseServices { get => GetField(ref _gseServices); set => SetField(ref _gseServices, value); }

        /// <summary>
        /// AclRights Home
        /// </summary>
        [AllowNull]
        public IList<string> Home { get => GetField(ref _home); set => SetField(ref _home, value); }

        /// <summary>
        /// AclRights ImportLoans
        /// </summary>
        [AllowNull]
        public IList<EntityReference> ImportLoans { get => GetField(ref _importLoans); set => SetField(ref _importLoans, value); }

        /// <summary>
        /// AclRights ItemizationFee
        /// </summary>
        [AllowNull]
        public IList<string> ItemizationFee { get => GetField(ref _itemizationFee); set => SetField(ref _itemizationFee, value); }

        /// <summary>
        /// AclRights Loan
        /// </summary>
        [AllowNull]
        public IList<string> Loan { get => GetField(ref _loan); set => SetField(ref _loan, value); }

        /// <summary>
        /// AclRights LoanSetup
        /// </summary>
        [AllowNull]
        public LoanSetupRights LoanSetup { get => GetField(ref _loanSetup); set => SetField(ref _loanSetup, value); }

        /// <summary>
        /// AclRights LoConnectTasks
        /// </summary>
        [AllowNull]
        public LoConnectTasksRights LoConnectTasks { get => GetField(ref _loConnectTasks); set => SetField(ref _loConnectTasks, value); }

        /// <summary>
        /// AclRights ManageServiceProviders
        /// </summary>
        [AllowNull]
        public ManageServiceProvidersRights ManageServiceProviders { get => GetField(ref _manageServiceProviders); set => SetField(ref _manageServiceProviders, value); }

        /// <summary>
        /// AclRights MilestoneWorkflowManagement
        /// </summary>
        [AllowNull]
        public MilestoneWorkflowManagementRights MilestoneWorkflowManagement { get => GetField(ref _milestoneWorkflowManagement); set => SetField(ref _milestoneWorkflowManagement, value); }

        /// <summary>
        /// AclRights MoveLoans
        /// </summary>
        [AllowNull]
        public MoveLoansRights MoveLoans { get => GetField(ref _moveLoans); set => SetField(ref _moveLoans, value); }

        /// <summary>
        /// AclRights PersonalSettings
        /// </summary>
        [AllowNull]
        public IList<string> PersonalSettings { get => GetField(ref _personalSettings); set => SetField(ref _personalSettings, value); }

        /// <summary>
        /// AclRights PersonalTemplates
        /// </summary>
        [AllowNull]
        public PersonalTemplatesRights PersonalTemplates { get => GetField(ref _personalTemplates); set => SetField(ref _personalTemplates, value); }

        /// <summary>
        /// AclRights Pipeline
        /// </summary>
        [AllowNull]
        public PipelineRights Pipeline { get => GetField(ref _pipeline); set => SetField(ref _pipeline, value); }

        /// <summary>
        /// AclRights ExportServices
        /// </summary>
        [AllowNull]
        public ExportServicesRights ExportServices { get => GetField(ref _exportServices); set => SetField(ref _exportServices, value); }

        /// <summary>
        /// AclRights PostClosingConditions
        /// </summary>
        [AllowNull]
        public PostClosingConditionsRights PostClosingConditions { get => GetField(ref _postClosingConditions); set => SetField(ref _postClosingConditions, value); }

        /// <summary>
        /// AclRights PreliminaryConditions
        /// </summary>
        [AllowNull]
        public PreliminaryConditionsRights PreliminaryConditions { get => GetField(ref _preliminaryConditions); set => SetField(ref _preliminaryConditions, value); }

        /// <summary>
        /// AclRights PurchaseConditions
        /// </summary>
        [AllowNull]
        public PurchaseConditionsRights PurchaseConditions { get => GetField(ref _purchaseConditions); set => SetField(ref _purchaseConditions, value); }

        /// <summary>
        /// AclRights Reports
        /// </summary>
        [AllowNull]
        public IList<string> Reports { get => GetField(ref _reports); set => SetField(ref _reports, value); }

        /// <summary>
        /// AclRights Print
        /// </summary>
        [AllowNull]
        public PrintRights Print { get => GetField(ref _print); set => SetField(ref _print, value); }

        /// <summary>
        /// AclRights SecondarySetup
        /// </summary>
        [AllowNull]
        public SecondarySetupRights SecondarySetup { get => GetField(ref _secondarySetup); set => SetField(ref _secondarySetup, value); }

        /// <summary>
        /// AclRights SellConditions
        /// </summary>
        [AllowNull]
        public SellConditionsRights SellConditions { get => GetField(ref _sellConditions); set => SetField(ref _sellConditions, value); }

        /// <summary>
        /// AclRights Services
        /// </summary>
        [AllowNull]
        public IList<ServiceRights> Services { get => GetField(ref _services); set => SetField(ref _services, value); }

        /// <summary>
        /// AclRights Settings
        /// </summary>
        [AllowNull]
        public IList<string> Settings { get => GetField(ref _settings); set => SetField(ref _settings, value); }

        /// <summary>
        /// AclRights SmartClient
        /// </summary>
        [AllowNull]
        public IList<string> SmartClient { get => GetField(ref _smartClient); set => SetField(ref _smartClient, value); }

        /// <summary>
        /// AclRights SystemAdministration
        /// </summary>
        [AllowNull]
        public SystemAdministrationRights SystemAdministration { get => GetField(ref _systemAdministration); set => SetField(ref _systemAdministration, value); }

        /// <summary>
        /// AclRights TablesAndFees
        /// </summary>
        [AllowNull]
        public TablesAndFeesRights TablesAndFees { get => GetField(ref _tablesAndFees); set => SetField(ref _tablesAndFees, value); }

        /// <summary>
        /// AclRights Tools
        /// </summary>
        [AllowNull]
        public IList<EntityReference> Tools { get => GetField(ref _tools); set => SetField(ref _tools, value); }

        /// <summary>
        /// AclRights TpoCompanyDetails
        /// </summary>
        [AllowNull]
        public TpoCompanyDetailsRights TpoCompanyDetails { get => GetField(ref _tpoCompanyDetails); set => SetField(ref _tpoCompanyDetails, value); }

        /// <summary>
        /// AclRights TpoConnectSiteSettings
        /// </summary>
        [AllowNull]
        public TpoConnectSiteSettingsRights TpoConnectSiteSettings { get => GetField(ref _tpoConnectSiteSettings); set => SetField(ref _tpoConnectSiteSettings, value); }

        /// <summary>
        /// AclRights TpoContacts
        /// </summary>
        [AllowNull]
        public TpoContactsRights TpoContacts { get => GetField(ref _tpoContacts); set => SetField(ref _tpoContacts, value); }

        /// <summary>
        /// AclRights TpoFees
        /// </summary>
        [AllowNull]
        public TpoFeesRights TpoFees { get => GetField(ref _tpoFees); set => SetField(ref _tpoFees, value); }

        /// <summary>
        /// AclRights TpoInformation
        /// </summary>
        [AllowNull]
        public TpoInformationRights TpoInformation { get => GetField(ref _tpoInformation); set => SetField(ref _tpoInformation, value); }

        /// <summary>
        /// AclRights TpoOrganizationSettings
        /// </summary>
        [AllowNull]
        public TpoOrganizationSettingsRights TpoOrganizationSettings { get => GetField(ref _tpoOrganizationSettings); set => SetField(ref _tpoOrganizationSettings, value); }

        /// <summary>
        /// AclRights TqlServices
        /// </summary>
        [AllowNull]
        public TqlServicesRights TqlServices { get => GetField(ref _tqlServices); set => SetField(ref _tqlServices, value); }

        /// <summary>
        /// AclRights Trades
        /// </summary>
        [AllowNull]
        public TradesRights Trades { get => GetField(ref _trades); set => SetField(ref _trades, value); }

        /// <summary>
        /// AclRights UnderwritingCenter
        /// </summary>
        [AllowNull]
        public UnderwritingCenterRights UnderwritingCenter { get => GetField(ref _underwritingCenter); set => SetField(ref _underwritingCenter, value); }

        /// <summary>
        /// AclRights UnderwritingConditions
        /// </summary>
        [AllowNull]
        public UnderwritingConditionsRights UnderwritingConditions { get => GetField(ref _underwritingConditions); set => SetField(ref _underwritingConditions, value); }
    }
}