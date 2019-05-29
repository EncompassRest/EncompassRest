using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// SecondarySetupRights
    /// </summary>
    public sealed class SecondarySetupRights : ParentAccessRights
    {
        private DirtyValue<bool?> _adjustmentTemplates;
        private DirtyValue<bool?> _autoLock;
        private DirtyValue<bool?> _correspondentPurchaseAdviceManagementSetup;
        private DirtyValue<bool?> _ePPSLoanProgramTable;
        private DirtyValue<bool?> _fundingTemplates;
        private DirtyValue<bool?> _investorTemplates;
        private DirtyValue<bool?> _loanPricingDecimalPlaces;
        private DirtyValue<bool?> _lockDeskSetup;
        private DirtyValue<bool?> _lockRequestAdditionalFields;
        private DirtyValue<bool?> _normalizedBidTapeTemplate;
        private DirtyValue<bool?> _productandPricing;
        private DirtyValue<bool?> _purchaseAdviceForm;
        private DirtyValue<bool?> _secondaryLockFields;
        private DirtyValue<bool?> _servicing;
        private DirtyValue<bool?> _sRPTemplates;
        private DirtyValue<bool?> _tradeManagementSetup;

        /// <summary>
        /// SecondarySetupRights AdjustmentTemplates
        /// </summary>
        public bool? AdjustmentTemplates { get => _adjustmentTemplates; set => SetField(ref _adjustmentTemplates, value); }

        /// <summary>
        /// SecondarySetupRights AutoLock
        /// </summary>
        [JsonProperty("auto-Lock")]
        public bool? AutoLock { get => _autoLock; set => SetField(ref _autoLock, value); }

        /// <summary>
        /// SecondarySetupRights CorrespondentPurchaseAdviceManagementSetup
        /// </summary>
        public bool? CorrespondentPurchaseAdviceManagementSetup { get => _correspondentPurchaseAdviceManagementSetup; set => SetField(ref _correspondentPurchaseAdviceManagementSetup, value); }

        /// <summary>
        /// SecondarySetupRights EPPSLoanProgramTable
        /// </summary>
        public bool? EPPSLoanProgramTable { get => _ePPSLoanProgramTable; set => SetField(ref _ePPSLoanProgramTable, value); }

        /// <summary>
        /// SecondarySetupRights FundingTemplates
        /// </summary>
        public bool? FundingTemplates { get => _fundingTemplates; set => SetField(ref _fundingTemplates, value); }

        /// <summary>
        /// SecondarySetupRights InvestorTemplates
        /// </summary>
        public bool? InvestorTemplates { get => _investorTemplates; set => SetField(ref _investorTemplates, value); }

        /// <summary>
        /// SecondarySetupRights LoanPricingDecimalPlaces
        /// </summary>
        public bool? LoanPricingDecimalPlaces { get => _loanPricingDecimalPlaces; set => SetField(ref _loanPricingDecimalPlaces, value); }

        /// <summary>
        /// SecondarySetupRights LockDeskSetup
        /// </summary>
        public bool? LockDeskSetup { get => _lockDeskSetup; set => SetField(ref _lockDeskSetup, value); }

        /// <summary>
        /// SecondarySetupRights LockRequestAdditionalFields
        /// </summary>
        public bool? LockRequestAdditionalFields { get => _lockRequestAdditionalFields; set => SetField(ref _lockRequestAdditionalFields, value); }

        /// <summary>
        /// SecondarySetupRights NormalizedBidTapeTemplate
        /// </summary>
        public bool? NormalizedBidTapeTemplate { get => _normalizedBidTapeTemplate; set => SetField(ref _normalizedBidTapeTemplate, value); }

        /// <summary>
        /// SecondarySetupRights ProductandPricing
        /// </summary>
        public bool? ProductandPricing { get => _productandPricing; set => SetField(ref _productandPricing, value); }

        /// <summary>
        /// SecondarySetupRights PurchaseAdviceForm
        /// </summary>
        public bool? PurchaseAdviceForm { get => _purchaseAdviceForm; set => SetField(ref _purchaseAdviceForm, value); }

        /// <summary>
        /// SecondarySetupRights SecondaryLockFields
        /// </summary>
        public bool? SecondaryLockFields { get => _secondaryLockFields; set => SetField(ref _secondaryLockFields, value); }

        /// <summary>
        /// SecondarySetupRights Servicing
        /// </summary>
        public bool? Servicing { get => _servicing; set => SetField(ref _servicing, value); }

        /// <summary>
        /// SecondarySetupRights SRPTemplates
        /// </summary>
        public bool? SRPTemplates { get => _sRPTemplates; set => SetField(ref _sRPTemplates, value); }

        /// <summary>
        /// SecondarySetupRights TradeManagementSetup
        /// </summary>
        public bool? TradeManagementSetup { get => _tradeManagementSetup; set => SetField(ref _tradeManagementSetup, value); }
    }
}