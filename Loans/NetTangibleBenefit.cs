using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class NetTangibleBenefit
    {
        public DateTime? ExistingLoanDateLoanClosed { get; set; }
        public decimal? ExistingLoanLoanAmount { get; set; }
        public int? ExistingLoanLoanTerm { get; set; }
        public int? ExistingLoanMonthsRemaining { get; set; }
        public string ExistingLoanLoanAmortizationType { get; set; }
        public int? ExistingLoanPrepaymentPenaltyTerm { get; set; }
        public decimal? ExistingLoanInterestRatePercent { get; set; }
        public decimal? ExistingLoanAprPercent { get; set; }
        public decimal? ExistingLoanFullyIndexRatePercent { get; set; }
        public decimal? ExistingLoanMaximumRatePercent { get; set; }
        public decimal? ExistingLoanWeightedAverageInterestRatePercent { get; set; }
        public bool? ExistingLoanIsNegativeAmortizationFeatureIndicator { get; set; }
        public bool? ExistingLoanIsPrepaymentPenalty { get; set; }
        public decimal? ExistingLoanPrepaymentPenaltyPercentage { get; set; }
        public bool? ExistingLoanIsLoanRefinancedAsSpecial { get; set; }
        public decimal? ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get; set; }
        public decimal? ExistingLoanLtvPercent { get; set; }
        public decimal? ExistingLoanBottomRatioPercent { get; set; }
        public string ExistingLoanPurposeType { get; set; }
        public decimal? ExistingLoanPaymentAmount { get; set; }
        public decimal? ExistingLoanPaymentIncludeMiObligation { get; set; }
        public decimal? ExistingLoanPaymentIncludeMortgageInsurance { get; set; }
        public bool? NewLoanIsSpecialMortgageOriginatedIndicator { get; set; }
        public decimal? NewLoanWeightedAverageInterestRatePercent { get; set; }
        public bool? NewLoanIsNegativeAmortizationFeatureIndicator { get; set; }
        public string ExistingLoanPrepaymentPenaltyBasedOn { get; set; }
        public decimal? NewLoanPaymentWithMiDifference { get; set; }
        public decimal? NewLoanPaymentWithObligationDifference { get; set; }
        public decimal? ExistingLoanPaymentDifference { get; set; }
        public bool? ExistingLoanBorrowerReceivesCashOutIndicator { get; set; }
        public decimal? ExistingLoanBorrowerReceivesCashOutAmount { get; set; }
        public decimal? ExistingLoanSavingsAmount { get; set; }
        public int? ExistingLoanRecoupCostsYears { get; set; }
        public string ExistingLoanProvidedByLicenseeType { get; set; }
        public bool? NewLoanPayOffConsolidateDebtIndicator { get; set; }
        public decimal? ExistingLoanTotalDebtPayoff { get; set; }
        public bool? ObtainingLowerIntRateIndicator { get; set; }
        public bool? ObtainingLowerIntMonthlyPaymentIndicator { get; set; }
        public bool? ObtainingShortAmortScheduleIndicator { get; set; }
        public bool? ChangingLoanToFixedRateIndicator { get; set; }
        public bool? EliminatingNegArmIndicator { get; set; }
        public bool? EliminatingBalloonPaymentIndicator { get; set; }
        public bool? ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get; set; }
        public bool? AvoidingForeclosureIndicator { get; set; }
        public bool? EliminatingPrivateMortgageInsuranceIndicator { get; set; }
        public bool? ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get; set; }
        public bool? ProceedsOfNewLoanWillBeUsedIndicator { get; set; }
        public bool? NewLoanIsGuaranteedIndicator { get; set; }
        public bool? ExistingLoanIsGuaranteedIndicator { get; set; }
        public bool? BeneficialChangedForBorrowerIndicator { get; set; }
        public bool? BorrowerReceivesAmountExcessCostAndFeesIndicator { get; set; }
        public bool? AprNotExceedIndicator { get; set; }
        public bool? RefinancingLoanIsHomeEquityIndicator { get; set; }
        public bool? BorrowerCanRecoupIndicator { get; set; }
        public bool? BorrowerMonthlyPaymentLowerThan20Indicator { get; set; }
        public bool? ChangeLoanFromArmtoFixedIndicator { get; set; }
        public bool? BorrowerCanRecoupCostofRefinancingIndicator { get; set; }
        public string BonaFideFinancialEmergency { get; set; }
        public string BorrowerReceivedReasonable { get; set; }
        public bool? PrintBorrowerInitialLinesIndicator { get; set; }
        public bool? ExistingLoanBalloonIndicator { get; set; }
        public bool? HomeLoanComplianceWith209 { get; set; }
        public bool? RefinancingRespondBonaFide { get; set; }
        public bool? OtherReason { get; set; }
        public string OtherReasonDescription { get; set; }
        public bool? LenderDeterminedBorrowersInterest { get; set; }
        public bool? NewLoanIsSafeHarborQM { get; set; }
        public string Id { get; set; }
    }
}