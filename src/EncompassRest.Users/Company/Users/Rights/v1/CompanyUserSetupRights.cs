using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CompanyUserSetupRights
    /// </summary>
    public sealed class CompanyUserSetupRights : ParentAccessRights
    {
        /// <summary>
        /// CompanyUserSetupRights CompanyInformation
        /// </summary>
        public bool? CompanyInformation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanyUserSetupRights EllieMaeNetworkCompany
        /// </summary>
        [JsonProperty("ellie MaeNetworkCompany")]
        public bool? EllieMaeNetworkCompany { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanyUserSetupRights Milestones
        /// </summary>
        public bool? Milestones { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanyUserSetupRights OrganizationsUser
        /// </summary>
        [JsonProperty("organizations/User")]
        [AllowNull]
        public OrganizationsUserRights OrganizationsUser { get => GetEntity<OrganizationsUserRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanyUserSetupRights Personas
        /// </summary>
        [AllowNull]
        public PersonasRights Personas { get => GetEntity<PersonasRights>(); set => SetEntity(value); }

        /// <summary>
        /// CompanyUserSetupRights Roles
        /// </summary>
        public bool? Roles { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanyUserSetupRights ServicesPasswordManager
        /// </summary>
        public bool? ServicesPasswordManager { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CompanyUserSetupRights UserGroups
        /// </summary>
        public bool? UserGroups { get => GetValue<bool?>(); set => SetValue(value); }
    }
}