using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Mcaw
    /// </summary>
    public sealed partial class Mcaw : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<AcceptOrReject>> _adequacyOfAvailableAssetsType;
        /// <summary>
        /// FHA MCAW Borr Rating Avail Assets [1167]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Borr Rating Avail Assets")]
        public StringEnumValue<AcceptOrReject> AdequacyOfAvailableAssetsType { get => _adequacyOfAvailableAssetsType; set => _adequacyOfAvailableAssetsType = value; }
        private DirtyValue<StringEnumValue<AcceptOrReject>> _adequacyOfEffectiveIncomeType;
        /// <summary>
        /// FHA MCAW Borr Rating Effective Income [1165]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Borr Rating Effective Income")]
        public StringEnumValue<AcceptOrReject> AdequacyOfEffectiveIncomeType { get => _adequacyOfEffectiveIncomeType; set => _adequacyOfEffectiveIncomeType = value; }
        private DirtyValue<decimal?> _adjustedPurchasePrice;
        /// <summary>
        /// FHA MCAW Adjusted Purchase Price [MCAWPUR.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Adjusted Purchase Price")]
        public decimal? AdjustedPurchasePrice { get => _adjustedPurchasePrice; set => _adjustedPurchasePrice = value; }
        private DirtyValue<decimal?> _appraisedValue1;
        /// <summary>
        /// FHA MCAW Mtg Basis Calc 1 [1154]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Mtg Basis Calc 1")]
        public decimal? AppraisedValue1 { get => _appraisedValue1; set => _appraisedValue1 = value; }
        private DirtyValue<decimal?> _appraisedValue2;
        /// <summary>
        /// FHA MCAW Mtg Basis Calc 2 [1157]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Mtg Basis Calc 2")]
        public decimal? AppraisedValue2 { get => _appraisedValue2; set => _appraisedValue2 = value; }
        private DirtyValue<decimal?> _borrowerPaidClosingCost;
        /// <summary>
        /// Mcaw BorrowerPaidClosingCost [SLREFI.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BorrowerPaidClosingCost { get => _borrowerPaidClosingCost; set => _borrowerPaidClosingCost = value; }
        private DirtyValue<decimal?> _calculatedMortgageAmount;
        /// <summary>
        /// FHA MCAW Max Mtg Amt [MCAWPUR.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Max Mtg Amt")]
        public decimal? CalculatedMortgageAmount { get => _calculatedMortgageAmount; set => _calculatedMortgageAmount = value; }
        private DirtyValue<decimal?> _cashReserves;
        /// <summary>
        /// FHA MCAW Cash Reserves [MCAWPUR.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Cash Reserves")]
        public decimal? CashReserves { get => _cashReserves; set => _cashReserves = value; }
        private DirtyValue<StringEnumValue<ConstructionType>> _constructionType;
        /// <summary>
        /// Loan Info Constr Loan Type [1067]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Constr Loan Type")]
        public StringEnumValue<ConstructionType> ConstructionType { get => _constructionType; set => _constructionType = value; }
        private DirtyValue<decimal?> _contractSalesPrice;
        /// <summary>
        /// FHA MCAW Contract Sales Price [MCAWPUR.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Contract Sales Price")]
        public decimal? ContractSalesPrice { get => _contractSalesPrice; set => _contractSalesPrice = value; }
        private DirtyValue<StringEnumValue<AcceptOrReject>> _creditCharacteristicsType;
        /// <summary>
        /// FHA MCAW Borr Rating Credit Characteristics [1164]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Borr Rating Credit Characteristics")]
        public StringEnumValue<AcceptOrReject> CreditCharacteristicsType { get => _creditCharacteristicsType; set => _creditCharacteristicsType = value; }
        private DirtyValue<decimal?> _equityToExSpouse;
        /// <summary>
        /// Mcaw EquityToExSpouse [SLREFI.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? EquityToExSpouse { get => _equityToExSpouse; set => _equityToExSpouse = value; }
        private DirtyValue<decimal?> _fhaMaxLoanAmount;
        /// <summary>
        /// FHA MCAW Max County Loan Amount [MCAWPUR.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Max County Loan Amount")]
        public decimal? FhaMaxLoanAmount { get => _fhaMaxLoanAmount; set => _fhaMaxLoanAmount = value; }
        private DirtyValue<string> _fhaUnderwriterChumsId;
        /// <summary>
        /// FHA Underwriter CHUMS ID [980]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Underwriter CHUMS ID")]
        public string FhaUnderwriterChumsId { get => _fhaUnderwriterChumsId; set => _fhaUnderwriterChumsId = value; }
        private DirtyValue<StringEnumValue<GiftFundsSource>> _giftFundsSource;
        /// <summary>
        /// FHA MCAW Gift Funds Source [MCAWPUR.X9]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Gift Funds Source")]
        public StringEnumValue<GiftFundsSource> GiftFundsSource { get => _giftFundsSource; set => _giftFundsSource = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Mcaw Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _lesserSalesPrice;
        /// <summary>
        /// FHA MCAW Lesser of Sales Price or Value [MCAWPUR.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Lesser of Sales Price or Value")]
        public decimal? LesserSalesPrice { get => _lesserSalesPrice; set => _lesserSalesPrice = value; }
        private DirtyValue<decimal?> _ltv1;
        /// <summary>
        /// FHA MCAW Loan-to-Value Ratio [MCAWPUR.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Loan-to-Value Ratio")]
        public decimal? Ltv1 { get => _ltv1; set => _ltv1 = value; }
        private DirtyValue<decimal?> _ltv2;
        /// <summary>
        /// FHA MCAW Ratio Loan-to-Value [GMCAW.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "FHA MCAW Ratio Loan-to-Value")]
        public decimal? Ltv2 { get => _ltv2; set => _ltv2 = value; }
        private DirtyValue<decimal?> _maximumSellerContribution4Percent;
        /// <summary>
        /// VA Maximum Seller Contribution (4%) [4180]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "VA Maximum Seller Contribution (4%)")]
        public decimal? MaximumSellerContribution4Percent { get => _maximumSellerContribution4Percent; set => _maximumSellerContribution4Percent = value; }
        private DirtyValue<decimal?> _mortgageAmount;
        /// <summary>
        /// FHA MCAW Mtg Amt [MCAWPUR.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Mtg Amt")]
        public decimal? MortgageAmount { get => _mortgageAmount; set => _mortgageAmount = value; }
        private DirtyValue<decimal?> _mortgageAmountPercent;
        /// <summary>
        /// FHA MCAW Max Mtg Calc LTV Factor [MCAWPUR.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "FHA MCAW Max Mtg Calc LTV Factor")]
        public decimal? MortgageAmountPercent { get => _mortgageAmountPercent; set => _mortgageAmountPercent = value; }
        private DirtyValue<decimal?> _mortgageBasisPurchase;
        /// <summary>
        /// FHA MCAW Mtg Basis [1090]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Mtg Basis")]
        public decimal? MortgageBasisPurchase { get => _mortgageBasisPurchase; set => _mortgageBasisPurchase = value; }
        private DirtyValue<decimal?> _mortgageBasisRefinance;
        /// <summary>
        /// FHA MCAW Mortgage Basis [GMCAW.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Mortgage Basis")]
        public decimal? MortgageBasisRefinance { get => _mortgageBasisRefinance; set => _mortgageBasisRefinance = value; }
        private DirtyValue<StringEnumValue<PaidType>> _paidType1;
        /// <summary>
        /// FHA MCAW Amt Paid Type [943]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Amt Paid Type")]
        public StringEnumValue<PaidType> PaidType1 { get => _paidType1; set => _paidType1 = value; }
        private DirtyValue<StringEnumValue<PaidType>> _paidType2;
        /// <summary>
        /// FHA MCAW Amt to be Paid Type [945]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Amt to be Paid Type")]
        public StringEnumValue<PaidType> PaidType2 { get => _paidType2; set => _paidType2 = value; }
        private DirtyValue<decimal?> _principalBalance;
        /// <summary>
        /// Mcaw PrincipalBalance [SLREFI.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PrincipalBalance { get => _principalBalance; set => _principalBalance = value; }
        private DirtyValue<StringEnumValue<RefinanceType>> _refinanceType;
        /// <summary>
        /// FHA MCAW Refi Type [1669]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Refi Type")]
        public StringEnumValue<RefinanceType> RefinanceType { get => _refinanceType; set => _refinanceType = value; }
        private DirtyValue<string> _remarks;
        /// <summary>
        /// FHA MCAW Remarks [1228]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Remarks")]
        public string Remarks { get => _remarks; set => _remarks = value; }
        private DirtyValue<decimal?> _repairsAndImprovements;
        /// <summary>
        /// FHA MCAW Repairs/Improvements [MCAWPUR.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Repairs/Improvements")]
        public decimal? RepairsAndImprovements { get => _repairsAndImprovements; set => _repairsAndImprovements = value; }
        private DirtyValue<string> _repairsAndImprovementsDescription;
        /// <summary>
        /// FHA MCAW Repairs/Improvements Descr [1670]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Repairs/Improvements Descr")]
        public string RepairsAndImprovementsDescription { get => _repairsAndImprovementsDescription; set => _repairsAndImprovementsDescription = value; }
        private DirtyValue<decimal?> _repairsImprovementAmount;
        /// <summary>
        /// FHA MCAW Repairs or Improvement Amount [MCAWPUR.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Repairs or Improvement Amount")]
        public decimal? RepairsImprovementAmount { get => _repairsImprovementAmount; set => _repairsImprovementAmount = value; }
        private DirtyValue<decimal?> _repairsRequiredByAppraiser;
        /// <summary>
        /// Mcaw RepairsRequiredByAppraiser [SLREFI.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? RepairsRequiredByAppraiser { get => _repairsRequiredByAppraiser; set => _repairsRequiredByAppraiser = value; }
        private DirtyValue<decimal?> _requiredInvestment;
        /// <summary>
        /// FHA MCAW Required Investment [1135]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Required Investment")]
        public decimal? RequiredInvestment { get => _requiredInvestment; set => _requiredInvestment = value; }
        private DirtyValue<decimal?> _requirementAdjustment;
        /// <summary>
        /// FHA MCAW Required Adj [MCAWPUR.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Required Adj")]
        public decimal? RequirementAdjustment { get => _requirementAdjustment; set => _requirementAdjustment = value; }
        private DirtyValue<bool?> _roundTo50Indicator;
        /// <summary>
        /// FHA Process Management Solution Round To $50 [SYS.X11]
        /// </summary>
        [LoanFieldProperty(Description = "FHA Process Management Solution Round To $50")]
        public bool? RoundTo50Indicator { get => _roundTo50Indicator; set => _roundTo50Indicator = value; }
        private DirtyValue<decimal?> _seasonedSubordinateLiens;
        /// <summary>
        /// Mcaw SeasonedSubordinateLiens [SLREFI.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SeasonedSubordinateLiens { get => _seasonedSubordinateLiens; set => _seasonedSubordinateLiens = value; }
        private DirtyValue<string> _secondMortgageSource;
        /// <summary>
        /// FHA MCAW 2nd Mtg Source [MCAWPUR.X10]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW 2nd Mtg Source")]
        public string SecondMortgageSource { get => _secondMortgageSource; set => _secondMortgageSource = value; }
        private DirtyValue<decimal?> _sixPercentOfLineA1;
        /// <summary>
        /// FHA MCAW Attach A Info A2:6% of Line A1 [1116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Attach A Info A2:6% of Line A1")]
        public decimal? SixPercentOfLineA1 { get => _sixPercentOfLineA1; set => _sixPercentOfLineA1 = value; }
        private DirtyValue<StringEnumValue<AcceptOrReject>> _stabilityOfEffectiveIncomeType;
        /// <summary>
        /// FHA MCAW Borr Rating Effective Income Stability [1166]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Borr Rating Effective Income Stability")]
        public StringEnumValue<AcceptOrReject> StabilityOfEffectiveIncomeType { get => _stabilityOfEffectiveIncomeType; set => _stabilityOfEffectiveIncomeType = value; }
        private DirtyValue<decimal?> _statutoryInvestment;
        /// <summary>
        /// FHA MCAW Statutory Investment Requir [MCAWPUR.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Statutory Investment Requir")]
        public decimal? StatutoryInvestment { get => _statutoryInvestment; set => _statutoryInvestment = value; }
        private DirtyValue<decimal?> _toBePaidAmount;
        /// <summary>
        /// FHA MCAW Amt to be paid in Cash /Other [1139]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Amt to be paid in Cash /Other")]
        public decimal? ToBePaidAmount { get => _toBePaidAmount; set => _toBePaidAmount = value; }
        private DirtyValue<decimal?> _totalCashToClose;
        /// <summary>
        /// FHA MCAW Total Cash to Close [MCAWPUR.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Cash to Close")]
        public decimal? TotalCashToClose { get => _totalCashToClose; set => _totalCashToClose = value; }
        private DirtyValue<decimal?> _totalRequirements;
        /// <summary>
        /// FHA MCAW Total Requirements [1138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Total Requirements")]
        public decimal? TotalRequirements { get => _totalRequirements; set => _totalRequirements = value; }
        private DirtyValue<decimal?> _totalSellerContribution;
        /// <summary>
        /// FHA MCAW Total Seller Contribution [135]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "FHA MCAW Total Seller Contribution")]
        public decimal? TotalSellerContribution { get => _totalSellerContribution; set => _totalSellerContribution = value; }
        private DirtyValue<decimal?> _unadjustedAcquisition;
        /// <summary>
        /// FHA MCAW Unadj Acquisition [MCAWPUR.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "FHA MCAW Unadj Acquisition")]
        public decimal? UnadjustedAcquisition { get => _unadjustedAcquisition; set => _unadjustedAcquisition = value; }
        private DirtyValue<bool?> _use85PercentRuleIndicator;
        /// <summary>
        /// FHA MCAW Appraised Value - Mult by 85% Check Box [1983]
        /// </summary>
        [LoanFieldProperty(Description = "FHA MCAW Appraised Value - Mult by 85% Check Box", OptionsJson = "{\"true\":\"multiplied by 85%\"}")]
        public bool? Use85PercentRuleIndicator { get => _use85PercentRuleIndicator; set => _use85PercentRuleIndicator = value; }
    }
}