namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AccessToContactsTabRights
    /// </summary>
    public sealed class AccessToContactsTabRights : ParentAccessRights
    {
        private BorrowerContactsRights _borrowerContacts;
        private BusinessContactsRights _businessContacts;
        private CampaignManagementRights _campaignManagement;
        private DirtyValue<bool?> _contactSynchronization;
        private DirtyValue<bool?> _contactUpdateOptOut;

        /// <summary>
        /// AccessToContactsTabRights BorrowerContacts
        /// </summary>
        public BorrowerContactsRights BorrowerContacts { get => GetField(ref _borrowerContacts); set => SetField(ref _borrowerContacts, value); }

        /// <summary>
        /// AccessToContactsTabRights BusinessContacts
        /// </summary>
        public BusinessContactsRights BusinessContacts { get => GetField(ref _businessContacts); set => SetField(ref _businessContacts, value); }

        /// <summary>
        /// AccessToContactsTabRights CampaignManagement
        /// </summary>
        public CampaignManagementRights CampaignManagement { get => GetField(ref _campaignManagement); set => SetField(ref _campaignManagement, value); }

        /// <summary>
        /// AccessToContactsTabRights ContactSynchronization
        /// </summary>
        public bool? ContactSynchronization { get => _contactSynchronization; set => SetField(ref _contactSynchronization, value); }

        /// <summary>
        /// AccessToContactsTabRights ContactUpdateOptOut
        /// </summary>
        public bool? ContactUpdateOptOut { get => _contactUpdateOptOut; set => SetField(ref _contactUpdateOptOut, value); }
    }
}