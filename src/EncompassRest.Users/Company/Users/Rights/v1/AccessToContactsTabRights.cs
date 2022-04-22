using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToContactsTabRights
    /// </summary>
    public sealed class AccessToContactsTabRights : ParentAccessRights
    {
        /// <summary>
        /// AccessToContactsTabRights BorrowerContacts
        /// </summary>
        [AllowNull]
        public BorrowerContactsRights BorrowerContacts { get => GetEntity<BorrowerContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToContactsTabRights BusinessContacts
        /// </summary>
        [AllowNull]
        public BusinessContactsRights BusinessContacts { get => GetEntity<BusinessContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToContactsTabRights CampaignManagement
        /// </summary>
        [AllowNull]
        public CampaignManagementRights CampaignManagement { get => GetEntity<CampaignManagementRights>(); set => SetEntity(value); }

        /// <summary>
        /// AccessToContactsTabRights ContactSynchronization
        /// </summary>
        public bool? ContactSynchronization { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AccessToContactsTabRights ContactUpdateOptOut
        /// </summary>
        public bool? ContactUpdateOptOut { get => GetValue<bool?>(); set => SetValue(value); }
    }
}