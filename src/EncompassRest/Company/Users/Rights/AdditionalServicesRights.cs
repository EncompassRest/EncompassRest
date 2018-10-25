using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AdditionalServicesRights
    /// </summary>
    public sealed class AdditionalServicesRights : ParentAccessRights
    {
        private DirtyValue<bool?> _n4506TService;
        private DirtyValue<bool?> _appraisalService;
        private DirtyValue<bool?> _companyStatusOnline;
        private DirtyValue<bool?> _complianceReviewSetup;
        private DirtyValue<bool?> _dataTracConnection;
        private DirtyValue<bool?> _eDocumentManagement;
        private DirtyValue<bool?> _eDisclosureFulfillment;
        private DirtyValue<bool?> _fannieMaeUCDTransfer;
        private DirtyValue<bool?> _fannieMaeWorkflow;
        private DirtyValue<bool?> _floodService;
        private DirtyValue<bool?> _fraudService;
        private DirtyValue<bool?> _freddieMacCAC;
        private DirtyValue<bool?> _freddieMacOrderAlert;
        private DirtyValue<bool?> _mortgageInsuranceService;
        private DirtyValue<bool?> _titleService;
        private DirtyValue<bool?> _tQLServices;
        private DirtyValue<bool?> _valuationService;

        /// <summary>
        /// AdditionalServicesRights 4506TService
        /// </summary>
        [JsonProperty("4506TService")]
        public bool? n4506TService { get => _n4506TService; set => SetField(ref _n4506TService, value); }

        /// <summary>
        /// AdditionalServicesRights AppraisalService
        /// </summary>
        public bool? AppraisalService { get => _appraisalService; set => SetField(ref _appraisalService, value); }

        /// <summary>
        /// AdditionalServicesRights CompanyStatusOnline
        /// </summary>
        public bool? CompanyStatusOnline { get => _companyStatusOnline; set => SetField(ref _companyStatusOnline, value); }

        /// <summary>
        /// AdditionalServicesRights ComplianceReviewSetup
        /// </summary>
        public bool? ComplianceReviewSetup { get => _complianceReviewSetup; set => SetField(ref _complianceReviewSetup, value); }

        /// <summary>
        /// AdditionalServicesRights DataTracConnection
        /// </summary>
        public bool? DataTracConnection { get => _dataTracConnection; set => SetField(ref _dataTracConnection, value); }

        /// <summary>
        /// AdditionalServicesRights EDocumentManagement
        /// </summary>
        [JsonProperty("e-DocumentManagement")]
        public bool? EDocumentManagement { get => _eDocumentManagement; set => SetField(ref _eDocumentManagement, value); }

        /// <summary>
        /// AdditionalServicesRights EDisclosureFulfillment
        /// </summary>
        public bool? EDisclosureFulfillment { get => _eDisclosureFulfillment; set => SetField(ref _eDisclosureFulfillment, value); }

        /// <summary>
        /// AdditionalServicesRights FannieMaeUCDTransfer
        /// </summary>
        public bool? FannieMaeUCDTransfer { get => _fannieMaeUCDTransfer; set => SetField(ref _fannieMaeUCDTransfer, value); }

        /// <summary>
        /// AdditionalServicesRights FannieMaeWorkflow
        /// </summary>
        public bool? FannieMaeWorkflow { get => _fannieMaeWorkflow; set => SetField(ref _fannieMaeWorkflow, value); }

        /// <summary>
        /// AdditionalServicesRights FloodService
        /// </summary>
        public bool? FloodService { get => _floodService; set => SetField(ref _floodService, value); }

        /// <summary>
        /// AdditionalServicesRights FraudService
        /// </summary>
        public bool? FraudService { get => _fraudService; set => SetField(ref _fraudService, value); }

        /// <summary>
        /// AdditionalServicesRights FreddieMacCAC
        /// </summary>
        public bool? FreddieMacCAC { get => _freddieMacCAC; set => SetField(ref _freddieMacCAC, value); }

        /// <summary>
        /// AdditionalServicesRights FreddieMacOrderAlert
        /// </summary>
        public bool? FreddieMacOrderAlert { get => _freddieMacOrderAlert; set => SetField(ref _freddieMacOrderAlert, value); }

        /// <summary>
        /// AdditionalServicesRights MortgageInsuranceService
        /// </summary>
        public bool? MortgageInsuranceService { get => _mortgageInsuranceService; set => SetField(ref _mortgageInsuranceService, value); }

        /// <summary>
        /// AdditionalServicesRights TitleService
        /// </summary>
        public bool? TitleService { get => _titleService; set => SetField(ref _titleService, value); }

        /// <summary>
        /// AdditionalServicesRights TQLServices
        /// </summary>
        public bool? TQLServices { get => _tQLServices; set => SetField(ref _tQLServices, value); }

        /// <summary>
        /// AdditionalServicesRights ValuationService
        /// </summary>
        public bool? ValuationService { get => _valuationService; set => SetField(ref _valuationService, value); }
    }
}