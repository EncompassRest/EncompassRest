using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TPOOrganizationSettingsRights
    /// </summary>
    public sealed class TPOOrganizationSettingsRights : ParentAccessRights
    {
        /// <summary>
        /// TPOOrganizationSettingsRights LenderContacts
        /// </summary>
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Reuse)]
        [AllowNull]
        public LenderContactsRights LenderContacts { get => GetEntity<LenderContactsRights>(); set => SetEntity(value); }

        [JsonProperty(" LenderContacts", ObjectCreationHandling = ObjectCreationHandling.Reuse)]
        private LenderContactsRights _LenderContacts { get => LenderContacts; set => LenderContacts = value; }

        /// <summary>
        /// TPOOrganizationSettingsRights Attachments
        /// </summary>
        [AllowNull]
        public AttachmentsRights Attachments { get => GetEntity<AttachmentsRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights BasicInfo
        /// </summary>
        [AllowNull]
        public BasicInfoRights BasicInfo { get => GetEntity<BasicInfoRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights Commitments
        /// </summary>
        [AllowNull]
        public CommitmentsRights Commitments { get => GetEntity<CommitmentsRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights CustomFields
        /// </summary>
        [AllowNull]
        public CustomFieldsRights CustomFields { get => GetEntity<CustomFieldsRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights DBA
        /// </summary>
        [AllowNull]
        public DBARights DBA { get => GetEntity<DBARights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights EditLoanriteria
        /// </summary>
        public bool? EditLoanriteria { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights Fees
        /// </summary>
        [AllowNull]
        public TPOFeesRights Fees { get => GetEntity<TPOFeesRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights License
        /// </summary>
        [AllowNull]
        public LicenseRights License { get => GetEntity<LicenseRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights LoanCriteria
        /// </summary>
        [AllowNull]
        public LoanCriteriaRights LoanCriteria { get => GetEntity<LoanCriteriaRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights LOComp
        /// </summary>
        [AllowNull]
        public LOCompRights LOComp { get => GetEntity<LOCompRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights Notes
        /// </summary>
        [AllowNull]
        public NotesRights Notes { get => GetEntity<NotesRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights ONRP
        /// </summary>
        [AllowNull]
        public ONRPRights ONRP { get => GetEntity<ONRPRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights SalesRepsAE
        /// </summary>
        [JsonProperty("salesReps/AE")]
        [AllowNull]
        public SalesRepsAERights SalesRepsAE { get => GetEntity<SalesRepsAERights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TPOContacts
        /// </summary>
        [AllowNull]
        public TPOOrganizationSettingsContactsRights TPOContacts { get => GetEntity<TPOOrganizationSettingsContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TPOWebCenterDocumentsTab
        /// </summary>
        [AllowNull]
        public TPOWebCenterDocumentsTabRights TPOWebCenterDocumentsTab { get => GetEntity<TPOWebCenterDocumentsTabRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TPOWebCenterSetup
        /// </summary>
        [AllowNull]
        public TPOWebCenterSetupRights TPOWebCenterSetup { get => GetEntity<TPOWebCenterSetupRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TPOWebCenterSiteManagement
        /// </summary>
        public bool? TPOWebCenterSiteManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TradeMgmt
        /// </summary>
        [AllowNull]
        public TradeMgmtRights TradeMgmt { get => GetEntity<TradeMgmtRights>(); set => SetEntity(value); }

        /// <summary>
        /// TPOOrganizationSettingsRights WarehouseTab
        /// </summary>
        [AllowNull]
        public WarehouseTabRights WarehouseTab { get => GetEntity<WarehouseTabRights>(); set => SetEntity(value); }
    }
}