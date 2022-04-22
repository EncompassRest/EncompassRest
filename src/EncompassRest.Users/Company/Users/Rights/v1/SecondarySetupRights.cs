using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SecondarySetupRights
    /// </summary>
    public sealed class SecondarySetupRights : ParentAccessRights
    {
        /// <summary>
        /// SecondarySetupRights AdjustmentTemplates
        /// </summary>
        public bool? AdjustmentTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights AutoLock
        /// </summary>
        [JsonProperty("auto-Lock")]
        public bool? AutoLock { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights CorrespondentPurchaseAdviceManagementSetup
        /// </summary>
        public bool? CorrespondentPurchaseAdviceManagementSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights EPPSLoanProgramTable
        /// </summary>
        public bool? EPPSLoanProgramTable { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights FundingTemplates
        /// </summary>
        public bool? FundingTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights InvestorTemplates
        /// </summary>
        public bool? InvestorTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights LoanPricingDecimalPlaces
        /// </summary>
        public bool? LoanPricingDecimalPlaces { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights LockComparisonTool
        /// </summary>
        public bool? LockComparisonTool { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights LockDeskSetup
        /// </summary>
        public bool? LockDeskSetup { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights LockRequestAdditionalFields
        /// </summary>
        public bool? LockRequestAdditionalFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights NormalizedBidTapeTemplate
        /// </summary>
        public bool? NormalizedBidTapeTemplate { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights ProductandPricing
        /// </summary>
        public bool? ProductandPricing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights PurchaseAdviceForm
        /// </summary>
        public bool? PurchaseAdviceForm { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights SecondaryLockFields
        /// </summary>
        public bool? SecondaryLockFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights Servicing
        /// </summary>
        public bool? Servicing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights SRPTemplates
        /// </summary>
        public bool? SRPTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SecondarySetupRights TradeManagementSetup
        /// </summary>
        public bool? TradeManagementSetup { get => GetValue<bool?>(); set => SetValue(value); }
    }
}