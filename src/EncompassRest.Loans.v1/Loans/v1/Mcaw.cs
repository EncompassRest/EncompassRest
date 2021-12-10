using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// Mcaw
    /// </summary>
    public sealed partial class Mcaw : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AcceptOrReject>>? _adequacyOfAvailableAssetsType;
        private DirtyValue<StringEnumValue<AcceptOrReject>>? _adequacyOfEffectiveIncomeType;
        private DirtyValue<decimal?>? _adjustedPurchasePrice;
        private DirtyValue<decimal?>? _appraisedValue1;
        private DirtyValue<decimal?>? _appraisedValue2;
        private DirtyValue<decimal?>? _borrowerPaidClosingCost;
        private DirtyValue<decimal?>? _calculatedMortgageAmount;
        private DirtyValue<decimal?>? _cashReserves;
        private DirtyValue<StringEnumValue<ConstructionType>>? _constructionType;
        private DirtyValue<decimal?>? _contractSalesPrice;
        private DirtyValue<StringEnumValue<AcceptOrReject>>? _creditCharacteristicsType;
        private DirtyValue<decimal?>? _equityToExSpouse;
        private DirtyValue<decimal?>? _fhaMaxLoanAmount;
        private DirtyValue<string?>? _fhaUnderwriterChumsId;
        private DirtyValue<StringEnumValue<GiftFundsSource>>? _giftFundsSource;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _lesserSalesPrice;
        private DirtyValue<decimal?>? _ltv1;
        private DirtyValue<decimal?>? _ltv2;
        private DirtyValue<decimal?>? _maximumSellerContribution4Percent;
        private DirtyValue<decimal?>? _mortgageAmount;
        private DirtyValue<decimal?>? _mortgageAmountPercent;
        private DirtyValue<decimal?>? _mortgageBasisPurchase;
        private DirtyValue<decimal?>? _mortgageBasisRefinance;
        private DirtyValue<StringEnumValue<PaidType>>? _paidType1;
        private DirtyValue<StringEnumValue<PaidType>>? _paidType2;
        private DirtyValue<decimal?>? _principalBalance;
        private DirtyValue<StringEnumValue<RefinanceType>>? _refinanceType;
        private DirtyValue<string?>? _remarks;
        private DirtyValue<decimal?>? _repairsAndImprovements;
        private DirtyValue<string?>? _repairsAndImprovementsDescription;
        private DirtyValue<decimal?>? _repairsImprovementAmount;
        private DirtyValue<decimal?>? _repairsRequiredByAppraiser;
        private DirtyValue<decimal?>? _requiredInvestment;
        private DirtyValue<decimal?>? _requirementAdjustment;
        private DirtyValue<bool?>? _roundTo50Indicator;
        private DirtyValue<decimal?>? _seasonedSubordinateLiens;
        private DirtyValue<string?>? _secondMortgageSource;
        private DirtyValue<decimal?>? _sixPercentOfLineA1;
        private DirtyValue<StringEnumValue<AcceptOrReject>>? _stabilityOfEffectiveIncomeType;
        private DirtyValue<decimal?>? _statutoryInvestment;
        private DirtyValue<decimal?>? _toBePaidAmount;
        private DirtyValue<decimal?>? _totalCashToClose;
        private DirtyValue<decimal?>? _totalRequirements;
        private DirtyValue<decimal?>? _totalSellerContribution;
        private DirtyValue<decimal?>? _unadjustedAcquisition;
        private DirtyValue<bool?>? _use85PercentRuleIndicator;

        /// <summary>
        /// FHA MCAW Borr Rating Avail Assets [1167]
        /// </summary>
        public StringEnumValue<AcceptOrReject> AdequacyOfAvailableAssetsType { get => _adequacyOfAvailableAssetsType; set => SetField(ref _adequacyOfAvailableAssetsType, value); }

        /// <summary>
        /// FHA MCAW Borr Rating Effective Income [1165]
        /// </summary>
        public StringEnumValue<AcceptOrReject> AdequacyOfEffectiveIncomeType { get => _adequacyOfEffectiveIncomeType; set => SetField(ref _adequacyOfEffectiveIncomeType, value); }

        /// <summary>
        /// FHA MCAW Adjusted Purchase Price [MCAWPUR.X28]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? AdjustedPurchasePrice { get => _adjustedPurchasePrice; set => SetField(ref _adjustedPurchasePrice, value); }

        /// <summary>
        /// FHA MCAW Mtg Basis Calc 1 [1154]
        /// </summary>
        public decimal? AppraisedValue1 { get => _appraisedValue1; set => SetField(ref _appraisedValue1, value); }

        /// <summary>
        /// FHA MCAW Mtg Basis Calc 2 [1157]
        /// </summary>
        public decimal? AppraisedValue2 { get => _appraisedValue2; set => SetField(ref _appraisedValue2, value); }

        /// <summary>
        /// Mcaw BorrowerPaidClosingCost [SLREFI.X34]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BorrowerPaidClosingCost { get => _borrowerPaidClosingCost; set => SetField(ref _borrowerPaidClosingCost, value); }

        /// <summary>
        /// FHA MCAW Max Mtg Amt [MCAWPUR.X25]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CalculatedMortgageAmount { get => _calculatedMortgageAmount; set => SetField(ref _calculatedMortgageAmount, value); }

        /// <summary>
        /// FHA MCAW Cash Reserves [MCAWPUR.X11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CashReserves { get => _cashReserves; set => SetField(ref _cashReserves, value); }

        /// <summary>
        /// Loan Info Constr Loan Type [1067]
        /// </summary>
        public StringEnumValue<ConstructionType> ConstructionType { get => _constructionType; set => SetField(ref _constructionType, value); }

        /// <summary>
        /// FHA MCAW Contract Sales Price [MCAWPUR.X12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? ContractSalesPrice { get => _contractSalesPrice; set => SetField(ref _contractSalesPrice, value); }

        /// <summary>
        /// FHA MCAW Borr Rating Credit Characteristics [1164]
        /// </summary>
        public StringEnumValue<AcceptOrReject> CreditCharacteristicsType { get => _creditCharacteristicsType; set => SetField(ref _creditCharacteristicsType, value); }

        /// <summary>
        /// Mcaw EquityToExSpouse [SLREFI.X8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? EquityToExSpouse { get => _equityToExSpouse; set => SetField(ref _equityToExSpouse, value); }

        /// <summary>
        /// FHA MCAW Max County Loan Amount [MCAWPUR.X27]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? FhaMaxLoanAmount { get => _fhaMaxLoanAmount; set => SetField(ref _fhaMaxLoanAmount, value); }

        /// <summary>
        /// FHA Underwriter CHUMS ID [980]
        /// </summary>
        public string? FhaUnderwriterChumsId { get => _fhaUnderwriterChumsId; set => SetField(ref _fhaUnderwriterChumsId, value); }

        /// <summary>
        /// FHA MCAW Gift Funds Source [MCAWPUR.X9]
        /// </summary>
        public StringEnumValue<GiftFundsSource> GiftFundsSource { get => _giftFundsSource; set => SetField(ref _giftFundsSource, value); }

        /// <summary>
        /// Mcaw Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// FHA MCAW Lesser of Sales Price or Value [MCAWPUR.X13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LesserSalesPrice { get => _lesserSalesPrice; set => SetField(ref _lesserSalesPrice, value); }

        /// <summary>
        /// FHA MCAW Loan-to-Value Ratio [MCAWPUR.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Ltv1 { get => _ltv1; set => SetField(ref _ltv1, value); }

        /// <summary>
        /// FHA MCAW Ratio Loan-to-Value [GMCAW.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Ltv2 { get => _ltv2; set => SetField(ref _ltv2, value); }

        /// <summary>
        /// VA Maximum Seller Contribution (4%) [4180]
        /// </summary>
        public decimal? MaximumSellerContribution4Percent { get => _maximumSellerContribution4Percent; set => SetField(ref _maximumSellerContribution4Percent, value); }

        /// <summary>
        /// FHA MCAW Mtg Amt [MCAWPUR.X14]
        /// </summary>
        public decimal? MortgageAmount { get => _mortgageAmount; set => SetField(ref _mortgageAmount, value); }

        /// <summary>
        /// FHA MCAW Max Mtg Calc LTV Factor [MCAWPUR.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MortgageAmountPercent { get => _mortgageAmountPercent; set => SetField(ref _mortgageAmountPercent, value); }

        /// <summary>
        /// FHA MCAW Mtg Basis [1090]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MortgageBasisPurchase { get => _mortgageBasisPurchase; set => SetField(ref _mortgageBasisPurchase, value); }

        /// <summary>
        /// FHA MCAW Mortgage Basis [GMCAW.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MortgageBasisRefinance { get => _mortgageBasisRefinance; set => SetField(ref _mortgageBasisRefinance, value); }

        /// <summary>
        /// FHA MCAW Amt Paid Type [943]
        /// </summary>
        public StringEnumValue<PaidType> PaidType1 { get => _paidType1; set => SetField(ref _paidType1, value); }

        /// <summary>
        /// FHA MCAW Amt to be Paid Type [945]
        /// </summary>
        public StringEnumValue<PaidType> PaidType2 { get => _paidType2; set => SetField(ref _paidType2, value); }

        /// <summary>
        /// Mcaw PrincipalBalance [SLREFI.X6]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? PrincipalBalance { get => _principalBalance; set => SetField(ref _principalBalance, value); }

        /// <summary>
        /// FHA MCAW Refi Type [1669]
        /// </summary>
        public StringEnumValue<RefinanceType> RefinanceType { get => _refinanceType; set => SetField(ref _refinanceType, value); }

        /// <summary>
        /// FHA MCAW Remarks [1228]
        /// </summary>
        public string? Remarks { get => _remarks; set => SetField(ref _remarks, value); }

        /// <summary>
        /// FHA MCAW Repairs/Improvements [MCAWPUR.X7]
        /// </summary>
        public decimal? RepairsAndImprovements { get => _repairsAndImprovements; set => SetField(ref _repairsAndImprovements, value); }

        /// <summary>
        /// FHA MCAW Repairs/Improvements Descr [1670]
        /// </summary>
        public string? RepairsAndImprovementsDescription { get => _repairsAndImprovementsDescription; set => SetField(ref _repairsAndImprovementsDescription, value); }

        /// <summary>
        /// FHA MCAW Repairs or Improvement Amount [MCAWPUR.X29]
        /// </summary>
        public decimal? RepairsImprovementAmount { get => _repairsImprovementAmount; set => SetField(ref _repairsImprovementAmount, value); }

        /// <summary>
        /// Mcaw RepairsRequiredByAppraiser [SLREFI.X33]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? RepairsRequiredByAppraiser { get => _repairsRequiredByAppraiser; set => SetField(ref _repairsRequiredByAppraiser, value); }

        /// <summary>
        /// FHA MCAW Required Investment [1135]
        /// </summary>
        public decimal? RequiredInvestment { get => _requiredInvestment; set => SetField(ref _requiredInvestment, value); }

        /// <summary>
        /// FHA MCAW Required Adj [MCAWPUR.X3]
        /// </summary>
        public decimal? RequirementAdjustment { get => _requirementAdjustment; set => SetField(ref _requirementAdjustment, value); }

        /// <summary>
        /// FHA Process Management Solution Round To $50 [SYS.X11]
        /// </summary>
        public bool? RoundTo50Indicator { get => _roundTo50Indicator; set => SetField(ref _roundTo50Indicator, value); }

        /// <summary>
        /// Mcaw SeasonedSubordinateLiens [SLREFI.X9]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? SeasonedSubordinateLiens { get => _seasonedSubordinateLiens; set => SetField(ref _seasonedSubordinateLiens, value); }

        /// <summary>
        /// FHA MCAW 2nd Mtg Source [MCAWPUR.X10]
        /// </summary>
        public string? SecondMortgageSource { get => _secondMortgageSource; set => SetField(ref _secondMortgageSource, value); }

        /// <summary>
        /// FHA MCAW Attach A Info A2:6% of Line A1 [1116]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? SixPercentOfLineA1 { get => _sixPercentOfLineA1; set => SetField(ref _sixPercentOfLineA1, value); }

        /// <summary>
        /// FHA MCAW Borr Rating Effective Income Stability [1166]
        /// </summary>
        public StringEnumValue<AcceptOrReject> StabilityOfEffectiveIncomeType { get => _stabilityOfEffectiveIncomeType; set => SetField(ref _stabilityOfEffectiveIncomeType, value); }

        /// <summary>
        /// FHA MCAW Statutory Investment Requir [MCAWPUR.X2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? StatutoryInvestment { get => _statutoryInvestment; set => SetField(ref _statutoryInvestment, value); }

        /// <summary>
        /// FHA MCAW Amt to be paid in Cash /Other [1139]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? ToBePaidAmount { get => _toBePaidAmount; set => SetField(ref _toBePaidAmount, value); }

        /// <summary>
        /// FHA MCAW Total Cash to Close [MCAWPUR.X8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalCashToClose { get => _totalCashToClose; set => SetField(ref _totalCashToClose, value); }

        /// <summary>
        /// FHA MCAW Total Requirements [1138]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalRequirements { get => _totalRequirements; set => SetField(ref _totalRequirements, value); }

        /// <summary>
        /// FHA MCAW Total Seller Contribution [135]
        /// </summary>
        public decimal? TotalSellerContribution { get => _totalSellerContribution; set => SetField(ref _totalSellerContribution, value); }

        /// <summary>
        /// FHA MCAW Unadj Acquisition [MCAWPUR.X1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnadjustedAcquisition { get => _unadjustedAcquisition; set => SetField(ref _unadjustedAcquisition, value); }

        /// <summary>
        /// FHA MCAW Appraised Value - Mult by 85% Check Box [1983]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"multiplied by 85%\"}")]
        public bool? Use85PercentRuleIndicator { get => _use85PercentRuleIndicator; set => SetField(ref _use85PercentRuleIndicator, value); }
    }
}