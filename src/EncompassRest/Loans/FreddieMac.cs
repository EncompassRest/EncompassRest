using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class FreddieMac
    {
        public string AffordableProduct { get; set; }
        public JsonNullable<decimal?> AlimonyAsIncomeReduction { get; set; }
        public JsonNullable<decimal?> AllMonthlyPayments { get; set; }
        public JsonNullable<bool?> AllowsNegativeAmortizationIndicator { get; set; }
        public string AmountOfFinancedMI { get; set; }
        public string APNCity { get; set; }
        public JsonNullable<bool?> ArmsLengthTransactionIndicator { get; set; }
        public JsonNullable<bool?> BorrowerQualifiesAsVeteranIndicator { get; set; }
        public string BrokerOriginated { get; set; }
        public string BuydownContributor { get; set; }
        public string CondoClass { get; set; }
        public JsonNullable<decimal?> ConvertibleFeeAmount { get; set; }
        public JsonNullable<decimal?> ConvertibleFeePercent { get; set; }
        public JsonNullable<decimal?> ConvertibleMaxRateAdjPercent { get; set; }
        public JsonNullable<decimal?> ConvertibleMinRateAdjPercent { get; set; }
        public string County { get; set; }
        public string CreditReportCompany { get; set; }
        public JsonNullable<decimal?> FinancingConcessions { get; set; }
        public string FreddieFiel11 { get; set; }
        public string FreddieFiel12 { get; set; }
        public string FreddieFiel13 { get; set; }
        public string FreddieFiel14 { get; set; }
        public string FreddieFiel15 { get; set; }
        public string FreddieField3 { get; set; }
        public string FreddieField7 { get; set; }
        public string HELOCActualBalance { get; set; }
        public string HELOCCreditLimit { get; set; }
        public string Id { get; set; }
        public string LenderAltPhone { get; set; }
        public string LenderRegistration { get; set; }
        public string LoanProspectorID { get; set; }
        public string LoanToConduitCode { get; set; }
        public string LongLegalDescription { get; set; }
        public string LossCoverage { get; set; }
        public string LPKeyNumber { get; set; }
        public string MIRefundOption { get; set; }
        public string MortgageInsuranceCompany { get; set; }
        public JsonNullable<decimal?> NetPurchasePrice { get; set; }
        public string NewConstructionType { get; set; }
        public string NoAppraisalMAF { get; set; }
        public JsonNullable<decimal?> NonOccupantNonHousingDebt { get; set; }
        public JsonNullable<decimal?> NonOccupantPresentHE { get; set; }
        public JsonNullable<bool?> OrderCreditEvaluationIndicator { get; set; }
        public JsonNullable<bool?> OrderMergedCreditReportIndicator { get; set; }
        public string OrderMortgageInsurance { get; set; }
        public JsonNullable<bool?> OrderRiskGradeEvaluationIndicator { get; set; }
        public JsonNullable<decimal?> OriginalIntRate { get; set; }
        public string OriginateID { get; set; }
        public string PaymentFrequency { get; set; }
        public string PaymentOption { get; set; }
        public JsonNullable<decimal?> PersonIncomeForSelfEmployment1 { get; set; }
        public JsonNullable<decimal?> PersonIncomeForSelfEmployment2 { get; set; }
        public JsonNullable<int?> PersonPercentOfBusinessOwned1 { get; set; }
        public JsonNullable<int?> PersonPercentOfBusinessOwned2 { get; set; }
        public string PremiumSource { get; set; }
        public JsonNullable<decimal?> PresentHousingExpense { get; set; }
        public string ProcessingPoint { get; set; }
        public string PropertyType { get; set; }
        public string PurposeOfLoan { get; set; }
        public string RenewalOption { get; set; }
        public string RenewalType { get; set; }
        public string RequiredDocumentType { get; set; }
        public JsonNullable<decimal?> Reserves { get; set; }
        public JsonNullable<bool?> RetailLoanIndicator { get; set; }
        public string RiskClass { get; set; }
        public string RiskGradeEvaluationType { get; set; }
        public JsonNullable<decimal?> SalesConcessions { get; set; }
        public string SecondaryFinancingType { get; set; }
        public JsonNullable<bool?> SecondTrustRefiIndicator { get; set; }
        public JsonNullable<decimal?> SimulatedPITI { get; set; }
        public string SizeOfHousehold { get; set; }
        public string SpecialInstruction1 { get; set; }
        public string SpecialInstruction2 { get; set; }
        public string SpecialInstruction3 { get; set; }
        public string SpecialInstruction4 { get; set; }
        public string SpecialInstruction5 { get; set; }
        public string State { get; set; }
        public JsonNullable<bool?> TransferLoanToConduitIndicator { get; set; }
        public string YearsOfCoverage { get; set; }
    }
}