using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// Access Rights associated with the persona. All the rights that are enabled for the persona are returned as part of this object.
    /// </summary>
    public sealed class AclRights : DirtyExtensibleObject
    {
        /// <summary>
        /// AclRights Access
        /// </summary>
        [AllowNull]
        public IList<string> Access { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights AdditionalServices
        /// </summary>
        [AllowNull]
        public AdditionalServicesRights AdditionalServices { get => GetEntity<AdditionalServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights AusTracking
        /// </summary>
        [AllowNull]
        public AusTrackingRights AusTracking { get => GetEntity<AusTrackingRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights BorrowerContacts
        /// </summary>
        [AllowNull]
        public BorrowerContactsRights BorrowerContacts { get => GetEntity<BorrowerContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights BusinessContacts
        /// </summary>
        [AllowNull]
        public BusinessContactsRights BusinessContacts { get => GetEntity<BusinessContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights BusinessRules
        /// </summary>
        [AllowNull]
        public BusinessRulesRights BusinessRules { get => GetEntity<BusinessRulesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights ClosingDocs
        /// </summary>
        [AllowNull]
        public IList<string> ClosingDocs { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights CompanyUserSetup
        /// </summary>
        [AllowNull]
        public CompanyUserSetupRights CompanyUserSetup { get => GetEntity<CompanyUserSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Contacts
        /// </summary>
        [AllowNull]
        public ContactsRights Contacts { get => GetEntity<ContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights ContactSetup
        /// </summary>
        [AllowNull]
        public ContactSetupRights ContactSetup { get => GetEntity<ContactSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights ConsumerConnect
        /// </summary>
        [AllowNull]
        public IList<string> ConsumerConnect { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights Dashboard
        /// </summary>
        [AllowNull]
        public DashboardRights Dashboard { get => GetEntity<DashboardRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights DeliveryConditions
        /// </summary>
        [AllowNull]
        public DeliveryConditionsRights DeliveryConditions { get => GetEntity<DeliveryConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights DisclosureTracking
        /// </summary>
        [AllowNull]
        public DisclosureTrackingRights DisclosureTracking { get => GetEntity<DisclosureTrackingRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights DocsSetup
        /// </summary>
        [AllowNull]
        public DocsSetupRights DocsSetup { get => GetEntity<DocsSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Documents
        /// </summary>
        [AllowNull]
        public DocumentsRights Documents { get => GetEntity<DocumentsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights DuplicateLoans
        /// </summary>
        [AllowNull]
        public IList<EntityReference> DuplicateLoans { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// AclRights DynamicDataManagement
        /// </summary>
        [AllowNull]
        public DynamicDataManagementRights DynamicDataManagement { get => GetEntity<DynamicDataManagementRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights EDisclosures
        /// </summary>
        [AllowNull]
        public EDisclosuresRights EDisclosures { get => GetEntity<EDisclosuresRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights EFolderHistory
        /// </summary>
        [AllowNull]
        public EFolderHistoryRights EFolderHistory { get => GetEntity<EFolderHistoryRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights EFolderSetup
        /// </summary>
        [AllowNull]
        public EFolderSetupRights EFolderSetup { get => GetEntity<EFolderSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights EncompassWebServices
        /// </summary>
        [AllowNull]
        public EncompassWebServicesRights EncompassWebServices { get => GetEntity<EncompassWebServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights EnhancedConditions
        /// </summary>
        [AllowNull]
        public EnhancedConditionsRights EnhancedConditions { get => GetEntity<EnhancedConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights EVault
        /// </summary>
        [AllowNull]
        public EVaultRights EVault { get => GetEntity<EVaultRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights ExternalSettings
        /// </summary>
        [AllowNull]
        public IList<string> ExternalSettings { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights FileContacts
        /// </summary>
        [AllowNull]
        public FileContactsRights FileContacts { get => GetEntity<FileContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Forms
        /// </summary>
        [AllowNull]
        public IList<EntityReference> Forms { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// AclRights GseServices
        /// </summary>
        [AllowNull]
        public GseServicesRights GseServices { get => GetEntity<GseServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Home
        /// </summary>
        [AllowNull]
        public IList<string> Home { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights ImportLoans
        /// </summary>
        [AllowNull]
        public IList<EntityReference> ImportLoans { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// AclRights ItemizationFee
        /// </summary>
        [AllowNull]
        public IList<string> ItemizationFee { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights Loan
        /// </summary>
        [AllowNull]
        public IList<string> Loan { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights LoanSetup
        /// </summary>
        [AllowNull]
        public LoanSetupRights LoanSetup { get => GetEntity<LoanSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights LoConnectTasks
        /// </summary>
        [AllowNull]
        public LoConnectTasksRights LoConnectTasks { get => GetEntity<LoConnectTasksRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights ManageServiceProviders
        /// </summary>
        [AllowNull]
        public ManageServiceProvidersRights ManageServiceProviders { get => GetEntity<ManageServiceProvidersRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights MilestoneWorkflowManagement
        /// </summary>
        [AllowNull]
        public MilestoneWorkflowManagementRights MilestoneWorkflowManagement { get => GetEntity<MilestoneWorkflowManagementRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights MoveLoans
        /// </summary>
        [AllowNull]
        public MoveLoansRights MoveLoans { get => GetEntity<MoveLoansRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights PersonalSettings
        /// </summary>
        [AllowNull]
        public IList<string> PersonalSettings { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights PersonalTemplates
        /// </summary>
        [AllowNull]
        public PersonalTemplatesRights PersonalTemplates { get => GetEntity<PersonalTemplatesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Pipeline
        /// </summary>
        [AllowNull]
        public PipelineRights Pipeline { get => GetEntity<PipelineRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights ExportServices
        /// </summary>
        [AllowNull]
        public ExportServicesRights ExportServices { get => GetEntity<ExportServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights PostClosingConditions
        /// </summary>
        [AllowNull]
        public PostClosingConditionsRights PostClosingConditions { get => GetEntity<PostClosingConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights PreliminaryConditions
        /// </summary>
        [AllowNull]
        public PreliminaryConditionsRights PreliminaryConditions { get => GetEntity<PreliminaryConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights PurchaseConditions
        /// </summary>
        [AllowNull]
        public PurchaseConditionsRights PurchaseConditions { get => GetEntity<PurchaseConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Reports
        /// </summary>
        [AllowNull]
        public IList<string> Reports { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights Print
        /// </summary>
        [AllowNull]
        public PrintRights Print { get => GetEntity<PrintRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights SecondarySetup
        /// </summary>
        [AllowNull]
        public SecondarySetupRights SecondarySetup { get => GetEntity<SecondarySetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights SellConditions
        /// </summary>
        [AllowNull]
        public SellConditionsRights SellConditions { get => GetEntity<SellConditionsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Services
        /// </summary>
        [AllowNull]
        public IList<ServiceRights> Services { get => GetList<ServiceRights>(); set => SetList(value); }

        /// <summary>
        /// AclRights Settings
        /// </summary>
        [AllowNull]
        public IList<string> Settings { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights SmartClient
        /// </summary>
        [AllowNull]
        public IList<string> SmartClient { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// AclRights SystemAdministration
        /// </summary>
        [AllowNull]
        public SystemAdministrationRights SystemAdministration { get => GetEntity<SystemAdministrationRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights TablesAndFees
        /// </summary>
        [AllowNull]
        public TablesAndFeesRights TablesAndFees { get => GetEntity<TablesAndFeesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Tools
        /// </summary>
        [AllowNull]
        public IList<EntityReference> Tools { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// AclRights TpoCompanyDetails
        /// </summary>
        [AllowNull]
        public TpoCompanyDetailsRights TpoCompanyDetails { get => GetEntity<TpoCompanyDetailsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights TpoConnectSiteSettings
        /// </summary>
        [AllowNull]
        public TpoConnectSiteSettingsRights TpoConnectSiteSettings { get => GetEntity<TpoConnectSiteSettingsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights TpoContacts
        /// </summary>
        [AllowNull]
        public TpoContactsRights TpoContacts { get => GetEntity<TpoContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights TpoFees
        /// </summary>
        [AllowNull]
        public TpoFeesRights TpoFees { get => GetEntity<TpoFeesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights TpoInformation
        /// </summary>
        [AllowNull]
        public TpoInformationRights TpoInformation { get => GetEntity<TpoInformationRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights TpoOrganizationSettings
        /// </summary>
        [AllowNull]
        public TpoOrganizationSettingsRights TpoOrganizationSettings { get => GetEntity<TpoOrganizationSettingsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights TqlServices
        /// </summary>
        [AllowNull]
        public TqlServicesRights TqlServices { get => GetEntity<TqlServicesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights Trades
        /// </summary>
        [AllowNull]
        public TradesRights Trades { get => GetEntity<TradesRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights UnderwritingCenter
        /// </summary>
        [AllowNull]
        public UnderwritingCenterRights UnderwritingCenter { get => GetEntity<UnderwritingCenterRights>(); set => SetEntity(value); }

        /// <summary>
        /// AclRights UnderwritingConditions
        /// </summary>
        [AllowNull]
        public UnderwritingConditionsRights UnderwritingConditions { get => GetEntity<UnderwritingConditionsRights>(); set => SetEntity(value); }
    }
}