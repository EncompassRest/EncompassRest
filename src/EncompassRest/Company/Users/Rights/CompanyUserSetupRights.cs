using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// CompanyUserSetupRights
    /// </summary>
    public sealed class CompanyUserSetupRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _companyInformation;
        private DirtyValue<bool?>? _ellieMaeNetworkCompany;
        private DirtyValue<bool?>? _milestones;
        private OrganizationsUserRights? _organizationsUser;
        private PersonasRights? _personas;
        private DirtyValue<bool?>? _roles;
        private DirtyValue<bool?>? _servicesPasswordManager;
        private DirtyValue<bool?>? _userGroups;

        /// <summary>
        /// CompanyUserSetupRights CompanyInformation
        /// </summary>
        public bool? CompanyInformation { get => _companyInformation; set => SetField(ref _companyInformation, value); }

        /// <summary>
        /// CompanyUserSetupRights EllieMaeNetworkCompany
        /// </summary>
        [JsonProperty("ellie MaeNetworkCompany")]
        public bool? EllieMaeNetworkCompany { get => _ellieMaeNetworkCompany; set => SetField(ref _ellieMaeNetworkCompany, value); }

        /// <summary>
        /// CompanyUserSetupRights Milestones
        /// </summary>
        public bool? Milestones { get => _milestones; set => SetField(ref _milestones, value); }

        /// <summary>
        /// CompanyUserSetupRights OrganizationsUser
        /// </summary>
        [JsonProperty("organizations/User")]
        [AllowNull]
        public OrganizationsUserRights OrganizationsUser { get => GetField(ref _organizationsUser); set => SetField(ref _organizationsUser, value); }

        /// <summary>
        /// CompanyUserSetupRights Personas
        /// </summary>
        [AllowNull]
        public PersonasRights Personas { get => GetField(ref _personas); set => SetField(ref _personas, value); }

        /// <summary>
        /// CompanyUserSetupRights Roles
        /// </summary>
        public bool? Roles { get => _roles; set => SetField(ref _roles, value); }

        /// <summary>
        /// CompanyUserSetupRights ServicesPasswordManager
        /// </summary>
        public bool? ServicesPasswordManager { get => _servicesPasswordManager; set => SetField(ref _servicesPasswordManager, value); }

        /// <summary>
        /// CompanyUserSetupRights UserGroups
        /// </summary>
        public bool? UserGroups { get => _userGroups; set => SetField(ref _userGroups, value); }
    }
}