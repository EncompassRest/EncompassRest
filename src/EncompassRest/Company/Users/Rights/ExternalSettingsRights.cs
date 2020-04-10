using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ExternalSettingsRights
    /// </summary>
    public sealed class ExternalSettingsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _allTPOContactInformation;
        private CompanyDetailsRights? _companyDetails;
        private DirtyValue<bool?>? _globalAccess;
        private DirtyValue<bool?>? _investorConnectSettings;
        private DirtyValue<bool?>? _tPOConnectSiteManagement;
        private DirtyValue<bool?>? _tPOCustomFields;
        private DirtyValue<bool?>? _tPODisclosureSettings;
        private TPOFeesRights? _tPOFees;
        private DirtyValue<bool?>? _tPOGlobalLenderContacts;
        private DirtyValue<bool?>? _tPOReassignment;
        private DirtyValue<bool?>? _tPOSettings;
        private TPOWebCenterDocumentListSettingsRights? _tPOWebCenterDocumentListSettings;

        /// <summary>
        /// ExternalSettingsRights AllTPOContactInformation
        /// </summary>
        public bool? AllTPOContactInformation { get => _allTPOContactInformation; set => SetField(ref _allTPOContactInformation, value); }

        /// <summary>
        /// ExternalSettingsRights CompanyDetails
        /// </summary>
        [AllowNull]
        public CompanyDetailsRights CompanyDetails { get => GetField(ref _companyDetails); set => SetField(ref _companyDetails, value); }

        /// <summary>
        /// ExternalSettingsRights GlobalAccess
        /// </summary>
        public bool? GlobalAccess { get => _globalAccess; set => SetField(ref _globalAccess, value); }

        /// <summary>
        /// ExternalSettingsRights InvestorConnectSettings
        /// </summary>
        public bool? InvestorConnectSettings { get => _investorConnectSettings; set => SetField(ref _investorConnectSettings, value); }

        /// <summary>
        /// ExternalSettingsRights TPOConnectSiteManagement
        /// </summary>
        public bool? TPOConnectSiteManagement { get => _tPOConnectSiteManagement; set => SetField(ref _tPOConnectSiteManagement, value); }

        /// <summary>
        /// ExternalSettingsRights TPOCustomFields
        /// </summary>
        public bool? TPOCustomFields { get => _tPOCustomFields; set => SetField(ref _tPOCustomFields, value); }

        /// <summary>
        /// ExternalSettingsRights TPODisclosureSettings
        /// </summary>
        public bool? TPODisclosureSettings { get => _tPODisclosureSettings; set => SetField(ref _tPODisclosureSettings, value); }

        /// <summary>
        /// ExternalSettingsRights TPOFees
        /// </summary>
        [AllowNull]
        public TPOFeesRights TPOFees { get => GetField(ref _tPOFees); set => SetField(ref _tPOFees, value); }

        /// <summary>
        /// ExternalSettingsRights TPOGlobalLenderContacts
        /// </summary>
        public bool? TPOGlobalLenderContacts { get => _tPOGlobalLenderContacts; set => SetField(ref _tPOGlobalLenderContacts, value); }

        /// <summary>
        /// ExternalSettingsRights TPOReassignment
        /// </summary>
        public bool? TPOReassignment { get => _tPOReassignment; set => SetField(ref _tPOReassignment, value); }

        /// <summary>
        /// ExternalSettingsRights TPOSettings
        /// </summary>
        public bool? TPOSettings { get => _tPOSettings; set => SetField(ref _tPOSettings, value); }

        /// <summary>
        /// ExternalSettingsRights TPOWebCenterDocumentListSettings
        /// </summary>
        [AllowNull]
        public TPOWebCenterDocumentListSettingsRights TPOWebCenterDocumentListSettings { get => GetField(ref _tPOWebCenterDocumentListSettings); set => SetField(ref _tPOWebCenterDocumentListSettings, value); }
    }
}