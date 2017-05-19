using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class FreddieMac
    {
        public bool? BorrowerQualifiesAsVeteranIndicator { get; set; }
        public string County { get; set; }
        public bool? OrderCreditEvaluationIndicator { get; set; }
        public bool? TransferLoanToConduitIndicator { get; set; }
        public string SpecialInstruction1 { get; set; }
        public string SpecialInstruction2 { get; set; }
        public string SpecialInstruction3 { get; set; }
        public string SpecialInstruction4 { get; set; }
        public string SpecialInstruction5 { get; set; }
        public string LoanToConduitCode { get; set; }
        public string ProcessingPoint { get; set; }
        public decimal? NetPurchasePrice { get; set; }
        public string SecondaryFinancingType { get; set; }
        public string AffordableProduct { get; set; }
        public string LPKeyNumber { get; set; }
        public decimal? NonOccupantPresentHE { get; set; }
        public string PropertyType { get; set; }
        public string BuydownContributor { get; set; }
        public decimal? OriginalIntRate { get; set; }
        public string RequiredDocumentType { get; set; }
        public string SizeOfHousehold { get; set; }
        public string MIRefundOption { get; set; }
        public string RenewalType { get; set; }
        public decimal? SimulatedPITI { get; set; }
        public string RenewalOption { get; set; }
        public string PaymentOption { get; set; }
        public string PaymentFrequency { get; set; }
        public string YearsOfCoverage { get; set; }
        public string PremiumSource { get; set; }
        public decimal? AlimonyAsIncomeReduction { get; set; }
        public decimal? PresentHousingExpense { get; set; }
        public string LossCoverage { get; set; }
        public string LenderRegistration { get; set; }
        public string FreddieField3 { get; set; }
        public string NoAppraisalMAF { get; set; }
        public string BrokerOriginated { get; set; }
        public string FreddieField7 { get; set; }
        public string HELOCActualBalance { get; set; }
        public string HELOCCreditLimit { get; set; }
        public string AmountOfFinancedMI { get; set; }
        public string APNCity { get; set; }
        public string RiskGradeEvaluationType { get; set; }
        public decimal? NonOccupantNonHousingDebt { get; set; }
        public int? PersonPercentOfBusinessOwned1 { get; set; }
        public int? PersonPercentOfBusinessOwned2 { get; set; }
        public decimal? PersonIncomeForSelfEmployment1 { get; set; }
        public decimal? PersonIncomeForSelfEmployment2 { get; set; }
        public string State { get; set; }
        public decimal? SalesConcessions { get; set; }
        public string NewConstructionType { get; set; }
        public string CreditReportCompany { get; set; }
        public decimal? FinancingConcessions { get; set; }
        public string LoanProspectorID { get; set; }
        public string OriginateID { get; set; }
        public string PurposeOfLoan { get; set; }
        public string MortgageInsuranceCompany { get; set; }
        public bool? SecondTrustRefiIndicator { get; set; }
        public string FreddieFiel11 { get; set; }
        public string FreddieFiel12 { get; set; }
        public string FreddieFiel13 { get; set; }
        public string FreddieFiel14 { get; set; }
        public string FreddieFiel15 { get; set; }
        public bool? OrderRiskGradeEvaluationIndicator { get; set; }
        public string LongLegalDescription { get; set; }
        public bool? RetailLoanIndicator { get; set; }
        public decimal? Reserves { get; set; }
        public string LenderAltPhone { get; set; }
        public bool? ArmsLengthTransactionIndicator { get; set; }
        public string CondoClass { get; set; }
        public bool? AllowsNegativeAmortizationIndicator { get; set; }
        public bool? OrderMergedCreditReportIndicator { get; set; }
        public string OrderMortgageInsurance { get; set; }
        public string RiskClass { get; set; }
        public decimal? AllMonthlyPayments { get; set; }
        public decimal? ConvertibleFeeAmount { get; set; }
        public decimal? ConvertibleFeePercent { get; set; }
        public decimal? ConvertibleMaxRateAdjPercent { get; set; }
        public decimal? ConvertibleMinRateAdjPercent { get; set; }
        public string Id { get; set; }
    }
}