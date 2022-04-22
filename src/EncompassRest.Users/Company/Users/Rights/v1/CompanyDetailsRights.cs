using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CompanyDetailsRights
    /// </summary>
    public sealed class CompanyDetailsRights : ParentAccessRights
    {
        /// <summary>
        /// CompanyDetailsRights CreateEditBanks
        /// </summary>
        [JsonProperty("create/EditBanks")]
        [AllowNull]
        public CreateEditBanksRights CreateEditBanks { get => GetEntity<CreateEditBanksRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanyDetailsRights CreateOrganizations
        /// </summary>
        public bool? CreateOrganizations { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanyDetailsRights DeleteOrganizations
        /// </summary>
        public bool? DeleteOrganizations { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanyDetailsRights ExportOrganizations
        /// </summary>
        public bool? ExportOrganizations { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanyDetailsRights TPOContacts
        /// </summary>
        [AllowNull]
        public TPOContactsRights TPOContacts { get => GetEntity<TPOContactsRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanyDetailsRights TPOOrganizationSettings
        /// </summary>
        [AllowNull]
        public TPOOrganizationSettingsRights TPOOrganizationSettings { get => GetEntity<TPOOrganizationSettingsRights>(); set => SetEntity(value); }
    }
}