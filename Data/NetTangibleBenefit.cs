
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class NetTangibleBenefit
{
public DateTime? existingLoanDateLoanClosed { get; set; }
public decimal? existingLoanLoanAmount { get; set; }
public int? existingLoanLoanTerm { get; set; }
public int? existingLoanMonthsRemaining { get; set; }
public string existingLoanLoanAmortizationType { get; set; }
public int? existingLoanPrepaymentPenaltyTerm { get; set; }
public decimal? existingLoanInterestRatePercent { get; set; }
public decimal? existingLoanAprPercent { get; set; }
public decimal? existingLoanFullyIndexRatePercent { get; set; }
public decimal? existingLoanMaximumRatePercent { get; set; }
public decimal? existingLoanWeightedAverageInterestRatePercent { get; set; }
public bool? existingLoanIsNegativeAmortizationFeatureIndicator { get; set; }
public bool? existingLoanIsPrepaymentPenalty { get; set; }
public decimal? existingLoanPrepaymentPenaltyPercentage { get; set; }
public bool? existingLoanIsLoanRefinancedAsSpecial { get; set; }
public decimal? existingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get; set; }
public decimal? existingLoanLtvPercent { get; set; }
public decimal? existingLoanBottomRatioPercent { get; set; }
public string existingLoanPurposeType { get; set; }
public decimal? existingLoanPaymentAmount { get; set; }
public decimal? existingLoanPaymentIncludeMiObligation { get; set; }
public decimal? existingLoanPaymentIncludeMortgageInsurance { get; set; }
public bool? newLoanIsSpecialMortgageOriginatedIndicator { get; set; }
public decimal? newLoanWeightedAverageInterestRatePercent { get; set; }
public bool? newLoanIsNegativeAmortizationFeatureIndicator { get; set; }
public string existingLoanPrepaymentPenaltyBasedOn { get; set; }
public decimal? newLoanPaymentWithMiDifference { get; set; }
public decimal? newLoanPaymentWithObligationDifference { get; set; }
public decimal? existingLoanPaymentDifference { get; set; }
public bool? existingLoanBorrowerReceivesCashOutIndicator { get; set; }
public decimal? existingLoanBorrowerReceivesCashOutAmount { get; set; }
public decimal? existingLoanSavingsAmount { get; set; }
public int? existingLoanRecoupCostsYears { get; set; }
public string existingLoanProvidedByLicenseeType { get; set; }
public bool? newLoanPayOffConsolidateDebtIndicator { get; set; }
public decimal? existingLoanTotalDebtPayoff { get; set; }
public bool? obtainingLowerIntRateIndicator { get; set; }
public bool? obtainingLowerIntMonthlyPaymentIndicator { get; set; }
public bool? obtainingShortAmortScheduleIndicator { get; set; }
public bool? changingLoanToFixedRateIndicator { get; set; }
public bool? eliminatingNegArmIndicator { get; set; }
public bool? eliminatingBalloonPaymentIndicator { get; set; }
public bool? receivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get; set; }
public bool? avoidingForeclosureIndicator { get; set; }
public bool? eliminatingPrivateMortgageInsuranceIndicator { get; set; }
public bool? consolidatingOtherExistingLoansIntoNewLoanIndicator { get; set; }
public bool? proceedsOfNewLoanWillBeUsedIndicator { get; set; }
public bool? newLoanIsGuaranteedIndicator { get; set; }
public bool? existingLoanIsGuaranteedIndicator { get; set; }
public bool? beneficialChangedForBorrowerIndicator { get; set; }
public bool? borrowerReceivesAmountExcessCostAndFeesIndicator { get; set; }
public bool? aprNotExceedIndicator { get; set; }
public bool? refinancingLoanIsHomeEquityIndicator { get; set; }
public bool? borrowerCanRecoupIndicator { get; set; }
public bool? borrowerMonthlyPaymentLowerThan20Indicator { get; set; }
public bool? changeLoanFromArmtoFixedIndicator { get; set; }
public bool? borrowerCanRecoupCostofRefinancingIndicator { get; set; }
public string bonaFideFinancialEmergency { get; set; }
public string borrowerReceivedReasonable { get; set; }
public bool? printBorrowerInitialLinesIndicator { get; set; }
public bool? existingLoanBalloonIndicator { get; set; }
public bool? homeLoanComplianceWith209 { get; set; }
public bool? refinancingRespondBonaFide { get; set; }
public bool? otherReason { get; set; }
public string otherReasonDescription { get; set; }
public bool? lenderDeterminedBorrowersInterest { get; set; }
public bool? newLoanIsSafeHarborQM { get; set; }
public string id { get; set; }

    }
}