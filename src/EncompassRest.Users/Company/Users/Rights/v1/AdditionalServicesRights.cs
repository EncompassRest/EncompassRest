using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AdditionalServicesRights
    /// </summary>
    public sealed class AdditionalServicesRights : ParentAccessRights
    {
        /// <summary>
        /// AdditionalServicesRights 4506TService
        /// </summary>
        [JsonProperty("4506TService")]
        public bool? n4506TService { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights AppraisalService
        /// </summary>
        public bool? AppraisalService { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights CompanyStatusOnline
        /// </summary>
        public bool? CompanyStatusOnline { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights ComplianceReviewSetup
        /// </summary>
        public bool? ComplianceReviewSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights DataTracConnection
        /// </summary>
        public bool? DataTracConnection { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights EClose
        /// </summary>
        public bool? EClose { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights EDocumentManagement
        /// </summary>
        [JsonProperty("e-DocumentManagement")]
        public bool? EDocumentManagement { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights EDisclosureFulfillment
        /// </summary>
        public bool? EDisclosureFulfillment { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights ElliemaeAIQ
        /// </summary>
        public bool? ElliemaeAIQ { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights FannieMaeUCDTransfer
        /// </summary>
        public bool? FannieMaeUCDTransfer { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights FannieMaeWorkflow
        /// </summary>
        public bool? FannieMaeWorkflow { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights FloodService
        /// </summary>
        public bool? FloodService { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights FraudService
        /// </summary>
        public bool? FraudService { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights FreddieMacCAC
        /// </summary>
        public bool? FreddieMacCAC { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights FreddieMacLPA
        /// </summary>
        public bool? FreddieMacLPA { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights FreddieMacOrderAlert
        /// </summary>
        public bool? FreddieMacOrderAlert { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights MortgageInsuranceService
        /// </summary>
        public bool? MortgageInsuranceService { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights TitleService
        /// </summary>
        public bool? TitleService { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights TQLServices
        /// </summary>
        public bool? TQLServices { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// AdditionalServicesRights ValuationService
        /// </summary>
        public bool? ValuationService { get => GetValue<bool?>(); set => SetValue(value); }
    }
}