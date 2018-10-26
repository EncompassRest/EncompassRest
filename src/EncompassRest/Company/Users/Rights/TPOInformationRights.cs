using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TPOInformationRights
    /// </summary>
    public sealed class TPOInformationRights : ParentAccessRights
    {
        private DirtyValue<bool?> _attachmentsTab;
        private DirtyValue<bool?> _basicInfoTab;
        private DirtyValue<bool?> _commitmentsTab;
        private CustomFieldsTabRights _customFieldsTab;
        private DirtyValue<bool?> _dBATab;
        private DirtyValue<bool?> _feesTab;
        private DirtyValue<bool?> _keyContactsTab;
        private DirtyValue<bool?> _lenderContacts;
        private DirtyValue<bool?> _licenseTab;
        private DirtyValue<bool?> _loanCriteriaTab;
        private DirtyValue<bool?> _lOCompTab;
        private DirtyValue<bool?> _notesTab;
        private DirtyValue<bool?> _salesRepsAETab;
        private DirtyValue<bool?> _tPOWebCenterDocsTab;
        private DirtyValue<bool?> _tPOWebCenterSetupTab;
        private DirtyValue<bool?> _warehouseTab;

        /// <summary>
        /// TPOInformationRights AttachmentsTab
        /// </summary>
        public bool? AttachmentsTab { get => _attachmentsTab; set => SetField(ref _attachmentsTab, value); }

        /// <summary>
        /// TPOInformationRights BasicInfoTab
        /// </summary>
        public bool? BasicInfoTab { get => _basicInfoTab; set => SetField(ref _basicInfoTab, value); }

        /// <summary>
        /// TPOInformationRights CommitmentsTab
        /// </summary>
        public bool? CommitmentsTab { get => _commitmentsTab; set => SetField(ref _commitmentsTab, value); }

        /// <summary>
        /// TPOInformationRights CustomFieldsTab
        /// </summary>
        public CustomFieldsTabRights CustomFieldsTab { get => GetField(ref _customFieldsTab); set => SetField(ref _customFieldsTab, value); }

        /// <summary>
        /// TPOInformationRights DBATab
        /// </summary>
        public bool? DBATab { get => _dBATab; set => SetField(ref _dBATab, value); }

        /// <summary>
        /// TPOInformationRights FeesTab
        /// </summary>
        public bool? FeesTab { get => _feesTab; set => SetField(ref _feesTab, value); }

        /// <summary>
        /// TPOInformationRights KeyContactsTab
        /// </summary>
        public bool? KeyContactsTab { get => _keyContactsTab; set => SetField(ref _keyContactsTab, value); }

        /// <summary>
        /// TPOInformationRights LenderContacts
        /// </summary>
        public bool? LenderContacts { get => _lenderContacts; set => SetField(ref _lenderContacts, value); }

        /// <summary>
        /// TPOInformationRights LicenseTab
        /// </summary>
        public bool? LicenseTab { get => _licenseTab; set => SetField(ref _licenseTab, value); }

        /// <summary>
        /// TPOInformationRights LoanCriteriaTab
        /// </summary>
        public bool? LoanCriteriaTab { get => _loanCriteriaTab; set => SetField(ref _loanCriteriaTab, value); }

        /// <summary>
        /// TPOInformationRights LOCompTab
        /// </summary>
        public bool? LOCompTab { get => _lOCompTab; set => SetField(ref _lOCompTab, value); }

        /// <summary>
        /// TPOInformationRights NotesTab
        /// </summary>
        public bool? NotesTab { get => _notesTab; set => SetField(ref _notesTab, value); }

        /// <summary>
        /// TPOInformationRights SalesRepsAETab
        /// </summary>
        [JsonProperty("salesReps/AETab")]
        public bool? SalesRepsAETab { get => _salesRepsAETab; set => SetField(ref _salesRepsAETab, value); }

        /// <summary>
        /// TPOInformationRights TPOWebCenterDocsTab
        /// </summary>
        public bool? TPOWebCenterDocsTab { get => _tPOWebCenterDocsTab; set => SetField(ref _tPOWebCenterDocsTab, value); }

        /// <summary>
        /// TPOInformationRights TPOWebCenterSetupTab
        /// </summary>
        public bool? TPOWebCenterSetupTab { get => _tPOWebCenterSetupTab; set => SetField(ref _tPOWebCenterSetupTab, value); }

        /// <summary>
        /// TPOInformationRights WarehouseTab
        /// </summary>
        public bool? WarehouseTab { get => _warehouseTab; set => SetField(ref _warehouseTab, value); }
    }
}