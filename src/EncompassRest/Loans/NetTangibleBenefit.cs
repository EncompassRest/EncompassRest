using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class NetTangibleBenefit
    {
        public JsonNullable<bool?> AprNotExceedIndicator { get; set; }
        public JsonNullable<bool?> AvoidingForeclosureIndicator { get; set; }
        public JsonNullable<bool?> BeneficialChangedForBorrowerIndicator { get; set; }
        public string BonaFideFinancialEmergency { get; set; }
        public JsonNullable<bool?> BorrowerCanRecoupCostofRefinancingIndicator { get; set; }
        public JsonNullable<bool?> BorrowerCanRecoupIndicator { get; set; }
        public JsonNullable<bool?> BorrowerMonthlyPaymentLowerThan20Indicator { get; set; }
        public string BorrowerReceivedReasonable { get; set; }
        public JsonNullable<bool?> BorrowerReceivesAmountExcessCostAndFeesIndicator { get; set; }
        public JsonNullable<bool?> ChangeLoanFromArmtoFixedIndicator { get; set; }
        public JsonNullable<bool?> ChangingLoanToFixedRateIndicator { get; set; }
        public JsonNullable<bool?> ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get; set; }
        public JsonNullable<bool?> EliminatingBalloonPaymentIndicator { get; set; }
        public JsonNullable<bool?> EliminatingNegArmIndicator { get; set; }
        public JsonNullable<bool?> EliminatingPrivateMortgageInsuranceIndicator { get; set; }
        public JsonNullable<decimal?> ExistingLoanAprPercent { get; set; }
        public JsonNullable<bool?> ExistingLoanBalloonIndicator { get; set; }
        public JsonNullable<decimal?> ExistingLoanBorrowerReceivesCashOutAmount { get; set; }
        public JsonNullable<bool?> ExistingLoanBorrowerReceivesCashOutIndicator { get; set; }
        public JsonNullable<decimal?> ExistingLoanBottomRatioPercent { get; set; }
        public JsonNullable<DateTime?> ExistingLoanDateLoanClosed { get; set; }
        public JsonNullable<decimal?> ExistingLoanFullyIndexRatePercent { get; set; }
        public JsonNullable<decimal?> ExistingLoanInterestRatePercent { get; set; }
        public JsonNullable<bool?> ExistingLoanIsGuaranteedIndicator { get; set; }
        public JsonNullable<bool?> ExistingLoanIsLoanRefinancedAsSpecial { get; set; }
        public JsonNullable<bool?> ExistingLoanIsNegativeAmortizationFeatureIndicator { get; set; }
        public JsonNullable<bool?> ExistingLoanIsPrepaymentPenalty { get; set; }
        public string ExistingLoanLoanAmortizationType { get; set; }
        public JsonNullable<decimal?> ExistingLoanLoanAmount { get; set; }
        public JsonNullable<int?> ExistingLoanLoanTerm { get; set; }
        public JsonNullable<decimal?> ExistingLoanLtvPercent { get; set; }
        public JsonNullable<decimal?> ExistingLoanMaximumRatePercent { get; set; }
        public JsonNullable<int?> ExistingLoanMonthsRemaining { get; set; }
        public JsonNullable<decimal?> ExistingLoanPaymentAmount { get; set; }
        public JsonNullable<decimal?> ExistingLoanPaymentDifference { get; set; }
        public JsonNullable<decimal?> ExistingLoanPaymentIncludeMiObligation { get; set; }
        public JsonNullable<decimal?> ExistingLoanPaymentIncludeMortgageInsurance { get; set; }
        public JsonNullable<decimal?> ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get; set; }
        public string ExistingLoanPrepaymentPenaltyBasedOn { get; set; }
        public JsonNullable<decimal?> ExistingLoanPrepaymentPenaltyPercentage { get; set; }
        public JsonNullable<int?> ExistingLoanPrepaymentPenaltyTerm { get; set; }
        public string ExistingLoanProvidedByLicenseeType { get; set; }
        public string ExistingLoanPurposeType { get; set; }
        public JsonNullable<int?> ExistingLoanRecoupCostsYears { get; set; }
        public JsonNullable<decimal?> ExistingLoanSavingsAmount { get; set; }
        public JsonNullable<decimal?> ExistingLoanTotalDebtPayoff { get; set; }
        public JsonNullable<decimal?> ExistingLoanWeightedAverageInterestRatePercent { get; set; }
        public JsonNullable<bool?> HomeLoanComplianceWith209 { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> LenderDeterminedBorrowersInterest { get; set; }
        public JsonNullable<bool?> NewLoanIsGuaranteedIndicator { get; set; }
        public JsonNullable<bool?> NewLoanIsNegativeAmortizationFeatureIndicator { get; set; }
        public JsonNullable<bool?> NewLoanIsSafeHarborQM { get; set; }
        public JsonNullable<bool?> NewLoanIsSpecialMortgageOriginatedIndicator { get; set; }
        public JsonNullable<decimal?> NewLoanPaymentWithMiDifference { get; set; }
        public JsonNullable<decimal?> NewLoanPaymentWithObligationDifference { get; set; }
        public JsonNullable<bool?> NewLoanPayOffConsolidateDebtIndicator { get; set; }
        public JsonNullable<decimal?> NewLoanWeightedAverageInterestRatePercent { get; set; }
        public JsonNullable<bool?> ObtainingLowerIntMonthlyPaymentIndicator { get; set; }
        public JsonNullable<bool?> ObtainingLowerIntRateIndicator { get; set; }
        public JsonNullable<bool?> ObtainingShortAmortScheduleIndicator { get; set; }
        public JsonNullable<bool?> OtherReason { get; set; }
        public string OtherReasonDescription { get; set; }
        public JsonNullable<bool?> PrintBorrowerInitialLinesIndicator { get; set; }
        public JsonNullable<bool?> ProceedsOfNewLoanWillBeUsedIndicator { get; set; }
        public JsonNullable<bool?> ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get; set; }
        public JsonNullable<bool?> RefinancingLoanIsHomeEquityIndicator { get; set; }
        public JsonNullable<bool?> RefinancingRespondBonaFide { get; set; }
    }
}