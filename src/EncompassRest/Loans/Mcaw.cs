using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Mcaw
    {
        public string AdequacyOfAvailableAssetsType { get; set; }
        public string AdequacyOfEffectiveIncomeType { get; set; }
        public JsonNullable<decimal?> AdjustedPurchasePrice { get; set; }
        public JsonNullable<decimal?> AppraisedValue1 { get; set; }
        public JsonNullable<decimal?> AppraisedValue2 { get; set; }
        public JsonNullable<decimal?> BorrowerPaidClosingCost { get; set; }
        public JsonNullable<decimal?> CalculatedMortgageAmount { get; set; }
        public JsonNullable<decimal?> CashReserves { get; set; }
        public string ConstructionType { get; set; }
        public JsonNullable<decimal?> ContractSalesPrice { get; set; }
        public string CreditCharacteristicsType { get; set; }
        public JsonNullable<decimal?> EquityToExSpouse { get; set; }
        public JsonNullable<decimal?> FhaMaxLoanAmount { get; set; }
        public string FhaUnderwriterChumsId { get; set; }
        public string GiftFundsSource { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> LesserSalesPrice { get; set; }
        public JsonNullable<decimal?> Ltv1 { get; set; }
        public JsonNullable<decimal?> Ltv2 { get; set; }
        public JsonNullable<decimal?> MaximumSellerContribution4Percent { get; set; }
        public JsonNullable<decimal?> MortgageAmount { get; set; }
        public JsonNullable<decimal?> MortgageAmountPercent { get; set; }
        public JsonNullable<decimal?> MortgageBasisPurchase { get; set; }
        public JsonNullable<decimal?> MortgageBasisRefinance { get; set; }
        public string PaidType1 { get; set; }
        public string PaidType2 { get; set; }
        public JsonNullable<decimal?> PrincipalBalance { get; set; }
        public string RefinanceType { get; set; }
        public string Remarks { get; set; }
        public JsonNullable<decimal?> RepairsAndImprovements { get; set; }
        public string RepairsAndImprovementsDescription { get; set; }
        public JsonNullable<decimal?> RepairsImprovementAmount { get; set; }
        public JsonNullable<decimal?> RepairsRequiredByAppraiser { get; set; }
        public JsonNullable<decimal?> RequiredInvestment { get; set; }
        public JsonNullable<decimal?> RequirementAdjustment { get; set; }
        public JsonNullable<bool?> RoundTo50Indicator { get; set; }
        public JsonNullable<decimal?> SeasonedSubordinateLiens { get; set; }
        public string SecondMortgageSource { get; set; }
        public JsonNullable<decimal?> SixPercentOfLineA1 { get; set; }
        public string StabilityOfEffectiveIncomeType { get; set; }
        public JsonNullable<decimal?> StatutoryInvestment { get; set; }
        public JsonNullable<decimal?> ToBePaidAmount { get; set; }
        public JsonNullable<decimal?> TotalCashToClose { get; set; }
        public JsonNullable<decimal?> TotalRequirements { get; set; }
        public JsonNullable<decimal?> TotalSellerContribution { get; set; }
        public JsonNullable<decimal?> UnadjustedAcquisition { get; set; }
        public JsonNullable<bool?> Use85PercentRuleIndicator { get; set; }
    }
}