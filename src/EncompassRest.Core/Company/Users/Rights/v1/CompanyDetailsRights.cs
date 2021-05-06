using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CompanyDetailsRights
    /// </summary>
    public sealed class CompanyDetailsRights : ParentAccessRights
    {
        private CreateEditBanksRights? _createEditBanks;
        private DirtyValue<bool?>? _createOrganizations;
        private DirtyValue<bool?>? _deleteOrganizations;
        private DirtyValue<bool?>? _exportOrganizations;
        private TPOContactsRights? _tPOContacts;
        private TPOOrganizationSettingsRights? _tPOOrganizationSettings;

        /// <summary>
        /// CompanyDetailsRights CreateEditBanks
        /// </summary>
        [JsonProperty("create/EditBanks")]
        [AllowNull]
        public CreateEditBanksRights CreateEditBanks { get => GetField(ref _createEditBanks); set => SetField(ref _createEditBanks, value); }

        /// <summary>
        /// CompanyDetailsRights CreateOrganizations
        /// </summary>
        public bool? CreateOrganizations { get => _createOrganizations; set => SetField(ref _createOrganizations, value); }

        /// <summary>
        /// CompanyDetailsRights DeleteOrganizations
        /// </summary>
        public bool? DeleteOrganizations { get => _deleteOrganizations; set => SetField(ref _deleteOrganizations, value); }

        /// <summary>
        /// CompanyDetailsRights ExportOrganizations
        /// </summary>
        public bool? ExportOrganizations { get => _exportOrganizations; set => SetField(ref _exportOrganizations, value); }

        /// <summary>
        /// CompanyDetailsRights TPOContacts
        /// </summary>
        [AllowNull]
        public TPOContactsRights TPOContacts { get => GetField(ref _tPOContacts); set => SetField(ref _tPOContacts, value); }

        /// <summary>
        /// CompanyDetailsRights TPOOrganizationSettings
        /// </summary>
        [AllowNull]
        public TPOOrganizationSettingsRights TPOOrganizationSettings { get => GetField(ref _tPOOrganizationSettings); set => SetField(ref _tPOOrganizationSettings, value); }
    }
}