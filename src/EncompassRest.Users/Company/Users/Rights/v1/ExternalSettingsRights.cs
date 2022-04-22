using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ExternalSettingsRights
    /// </summary>
    public sealed class ExternalSettingsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ExternalSettingsRights AllTPOContactInformation
        /// </summary>
        public bool? AllTPOContactInformation { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights CompanyDetails
        /// </summary>
        [AllowNull]
        public CompanyDetailsRights CompanyDetails { get => GetEntity<CompanyDetailsRights>(); set => SetEntity(value); }

        /// <summary>
        /// ExternalSettingsRights CompanyUserAccountManagement
        /// </summary>
        [JsonProperty("company/UserAccountManagement")]
        public bool? CompanyUserAccountManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights GlobalAccess
        /// </summary>
        public bool? GlobalAccess { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights InvestorConnectSettings
        /// </summary>
        public bool? InvestorConnectSettings { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights TPOConnectSiteManagement
        /// </summary>
        public bool? TPOConnectSiteManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights TPOCustomFields
        /// </summary>
        public bool? TPOCustomFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights TPODisclosureSettings
        /// </summary>
        public bool? TPODisclosureSettings { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights TPOFees
        /// </summary>
        [AllowNull]
        public TPOFeesRights TPOFees { get => GetEntity<TPOFeesRights>(); set => SetEntity(value); }

        /// <summary>
        /// ExternalSettingsRights TPOGlobalLenderContacts
        /// </summary>
        public bool? TPOGlobalLenderContacts { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights TPOReassignment
        /// </summary>
        public bool? TPOReassignment { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights TPOSettings
        /// </summary>
        public bool? TPOSettings { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ExternalSettingsRights TPOWebCenterDocumentListSettings
        /// </summary>
        [AllowNull]
        public TPOWebCenterDocumentListSettingsRights TPOWebCenterDocumentListSettings { get => GetEntity<TPOWebCenterDocumentListSettingsRights>(); set => SetEntity(value); }
    }
}