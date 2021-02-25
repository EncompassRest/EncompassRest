using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// TPOOrganizationSettingsRights
    /// </summary>
    public sealed class TPOOrganizationSettingsRights : ParentAccessRights
    {
        private LenderContactsRights? _lenderContacts;
        private AttachmentsRights? _attachments;
        private BasicInfoRights? _basicInfo;
        private CommitmentsRights? _commitments;
        private CustomFieldsRights? _customFields;
        private DBARights? _dBA;
        private DirtyValue<bool?>? _editLoanriteria;
        private TPOFeesRights? _fees;
        private LicenseRights? _license;
        private LoanCriteriaRights? _loanCriteria;
        private LOCompRights? _lOComp;
        private NotesRights? _notes;
        private SalesRepsAERights? _salesRepsAE;
        private TPOOrganizationSettingsContactsRights? _tPOContacts;
        private TPOWebCenterDocumentsTabRights? _tPOWebCenterDocumentsTab;
        private TPOWebCenterSetupRights? _tPOWebCenterSetup;
        private DirtyValue<bool?>? _tPOWebCenterSiteManagement;
        private WarehouseTabRights? _warehouseTab;

        /// <summary>
        /// TPOOrganizationSettingsRights LenderContacts
        /// </summary>
        [JsonProperty(ObjectCreationHandling = ObjectCreationHandling.Reuse)]
        [AllowNull]
        public LenderContactsRights LenderContacts { get => GetField(ref _lenderContacts); set => SetField(ref _lenderContacts, value); }

        [JsonProperty(" LenderContacts", ObjectCreationHandling = ObjectCreationHandling.Reuse)]
        private LenderContactsRights _LenderContacts { get => LenderContacts; set => LenderContacts = value; }

        /// <summary>
        /// TPOOrganizationSettingsRights Attachments
        /// </summary>
        [AllowNull]
        public AttachmentsRights Attachments { get => GetField(ref _attachments); set => SetField(ref _attachments, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights BasicInfo
        /// </summary>
        [AllowNull]
        public BasicInfoRights BasicInfo { get => GetField(ref _basicInfo); set => SetField(ref _basicInfo, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights Commitments
        /// </summary>
        [AllowNull]
        public CommitmentsRights Commitments { get => GetField(ref _commitments); set => SetField(ref _commitments, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights CustomFields
        /// </summary>
        [AllowNull]
        public CustomFieldsRights CustomFields { get => GetField(ref _customFields); set => SetField(ref _customFields, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights DBA
        /// </summary>
        [AllowNull]
        public DBARights DBA { get => GetField(ref _dBA); set => SetField(ref _dBA, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights EditLoanriteria
        /// </summary>
        public bool? EditLoanriteria { get => _editLoanriteria; set => SetField(ref _editLoanriteria, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights Fees
        /// </summary>
        [AllowNull]
        public TPOFeesRights Fees { get => GetField(ref _fees); set => SetField(ref _fees, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights License
        /// </summary>
        [AllowNull]
        public LicenseRights License { get => GetField(ref _license); set => SetField(ref _license, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights LoanCriteria
        /// </summary>
        [AllowNull]
        public LoanCriteriaRights LoanCriteria { get => GetField(ref _loanCriteria); set => SetField(ref _loanCriteria, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights LOComp
        /// </summary>
        [AllowNull]
        public LOCompRights LOComp { get => GetField(ref _lOComp); set => SetField(ref _lOComp, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights Notes
        /// </summary>
        [AllowNull]
        public NotesRights Notes { get => GetField(ref _notes); set => SetField(ref _notes, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights SalesRepsAE
        /// </summary>
        [JsonProperty("salesReps/AE")]
        [AllowNull]
        public SalesRepsAERights SalesRepsAE { get => GetField(ref _salesRepsAE); set => SetField(ref _salesRepsAE, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TPOContacts
        /// </summary>
        [AllowNull]
        public TPOOrganizationSettingsContactsRights TPOContacts { get => GetField(ref _tPOContacts); set => SetField(ref _tPOContacts, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TPOWebCenterDocumentsTab
        /// </summary>
        [AllowNull]
        public TPOWebCenterDocumentsTabRights TPOWebCenterDocumentsTab { get => GetField(ref _tPOWebCenterDocumentsTab); set => SetField(ref _tPOWebCenterDocumentsTab, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TPOWebCenterSetup
        /// </summary>
        [AllowNull]
        public TPOWebCenterSetupRights TPOWebCenterSetup { get => GetField(ref _tPOWebCenterSetup); set => SetField(ref _tPOWebCenterSetup, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights TPOWebCenterSiteManagement
        /// </summary>
        public bool? TPOWebCenterSiteManagement { get => _tPOWebCenterSiteManagement; set => SetField(ref _tPOWebCenterSiteManagement, value); }

        /// <summary>
        /// TPOOrganizationSettingsRights WarehouseTab
        /// </summary>
        [AllowNull]
        public WarehouseTabRights WarehouseTab { get => GetField(ref _warehouseTab); set => SetField(ref _warehouseTab, value); }
    }
}