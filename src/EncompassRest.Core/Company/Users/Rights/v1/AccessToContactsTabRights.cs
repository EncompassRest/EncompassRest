using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToContactsTabRights
    /// </summary>
    public sealed class AccessToContactsTabRights : ParentAccessRights
    {
        private BorrowerContactsRights? _borrowerContacts;
        private BusinessContactsRights? _businessContacts;
        private CampaignManagementRights? _campaignManagement;
        private DirtyValue<bool?>? _contactSynchronization;
        private DirtyValue<bool?>? _contactUpdateOptOut;

        /// <summary>
        /// AccessToContactsTabRights BorrowerContacts
        /// </summary>
        [AllowNull]
        public BorrowerContactsRights BorrowerContacts { get => GetField(ref _borrowerContacts); set => SetField(ref _borrowerContacts, value); }

        /// <summary>
        /// AccessToContactsTabRights BusinessContacts
        /// </summary>
        [AllowNull]
        public BusinessContactsRights BusinessContacts { get => GetField(ref _businessContacts); set => SetField(ref _businessContacts, value); }

        /// <summary>
        /// AccessToContactsTabRights CampaignManagement
        /// </summary>
        [AllowNull]
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