namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ContactSetupRights
    /// </summary>
    public sealed class ContactSetupRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _borrowerContactStatus;
        private DirtyValue<bool?>? _borrowerCustomFields;
        private DirtyValue<bool?>? _borrwerContactUpdate;
        private DirtyValue<bool?>? _businessCategories;
        private DirtyValue<bool?>? _businessCustomFields;
        private DirtyValue<bool?>? _emailServerSettings;
        private DirtyValue<bool?>? _publicBusinessContactGroups;

        /// <summary>
        /// ContactSetupRights BorrowerContactStatus
        /// </summary>
        public bool? BorrowerContactStatus { get => _borrowerContactStatus; set => SetField(ref _borrowerContactStatus, value); }

        /// <summary>
        /// ContactSetupRights BorrowerCustomFields
        /// </summary>
        public bool? BorrowerCustomFields { get => _borrowerCustomFields; set => SetField(ref _borrowerCustomFields, value); }

        /// <summary>
        /// ContactSetupRights BorrwerContactUpdate
        /// </summary>
        public bool? BorrwerContactUpdate { get => _borrwerContactUpdate; set => SetField(ref _borrwerContactUpdate, value); }

        /// <summary>
        /// ContactSetupRights BusinessCategories
        /// </summary>
        public bool? BusinessCategories { get => _businessCategories; set => SetField(ref _businessCategories, value); }

        /// <summary>
        /// ContactSetupRights BusinessCustomFields
        /// </summary>
        public bool? BusinessCustomFields { get => _businessCustomFields; set => SetField(ref _businessCustomFields, value); }

        /// <summary>
        /// ContactSetupRights EmailServerSettings
        /// </summary>
        public bool? EmailServerSettings { get => _emailServerSettings; set => SetField(ref _emailServerSettings, value); }

        /// <summary>
        /// ContactSetupRights PublicBusinessContactGroups
        /// </summary>
        public bool? PublicBusinessContactGroups { get => _publicBusinessContactGroups; set => SetField(ref _publicBusinessContactGroups, value); }
    }
}