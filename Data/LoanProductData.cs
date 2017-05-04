using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class LoanProductData
    {
        public decimal? rateAdjustmentLifetimeCapPercent { get; set; }
        public int? balloonLoanMaturityTermMonthsCount { get; set; }
        public string lienPriorityType { get; set; }
        public string paymentFrequencyType { get; set; }
        public string loanRepaymentType { get; set; }
        public decimal? miCoveragePercent { get; set; }
        public bool? prepaymentPenaltyIndicator { get; set; }
        public DateTime? scheduledFirstPaymentDate { get; set; }
        public decimal? indexCurrentValuePercent { get; set; }
        public decimal? indexMarginPercent { get; set; }
        public int? paymentAdjustmentDurationMonthsCount { get; set; }
        public decimal? paymentAdjustmentPeriodicCapPercent { get; set; }
        public int? rateAdjustmentDurationMonthsCount { get; set; }
        public decimal? rateAdjustmentSubsequentCapPercent { get; set; }
        public int? subsequentRateAdjustmentMonthsCount { get; set; }
        public decimal? rateAdjustmentPercent { get; set; }
        public decimal? negativeAmortizationLimitPercent { get; set; }
        public DateTime? loanScheduledClosingDate { get; set; }
        public string fnmProductPlanIdentifier { get; set; }
        public string gseProjectClassificationType { get; set; }
        public decimal? qualifyingRatePercent { get; set; }
        public string gsePropertyType { get; set; }
        public List<Buydown> buydowns { get; set; }
        public bool? convertibleIndicator { get; set; }
        public decimal? minimumPaymentPercent { get; set; }
        public decimal? minimumPaymentAmount { get; set; }
        public bool? balloonIndicator { get; set; }
        public decimal? floorPercent { get; set; }
        public decimal? roundPercent { get; set; }
        public decimal? initialAdvanceAmount { get; set; }
        public int? drawPeriodMonthsCount { get; set; }
        public int? repayPeriodMonthsCount { get; set; }
        public decimal? annualFeeNeededAmount { get; set; }
        public decimal? minimumAdvanceAmount { get; set; }
        public decimal? minimumAllowableApr { get; set; }
        public string fullPrepaymentPenaltyOptionType { get; set; }
        public int? prepaymentPenaltyTermMonthsCount { get; set; }
        public decimal? prepaymentPenaltyPercent { get; set; }
        public string armDisclosureType { get; set; }
        public decimal? thirdPartyFeeFromAmount { get; set; }
        public decimal? thirdPartyFeeToAmount { get; set; }
        public string discounted { get; set; }
        public decimal? discountedRate { get; set; }
        public List<PrepaymentPenalty> prepaymentPenalties { get; set; }
        public string helocPeriodTemplateName { get; set; }
        public decimal? terminationFeeAmount { get; set; }
        public int? terminationPeriodMonthsCount { get; set; }
        public string freddieMacArmIndexType { get; set; }
        public string freOfferingIdentifier { get; set; }
        public List<HelocRepaymentDrawPeriod> helocRepaymentDrawPeriods { get; set; }
        public bool? escrowWaiverIndicator { get; set; }
        public string productName { get; set; }
        public string loanDocumentationType { get; set; }
        public string armIndexType { get; set; }
        public string roundType { get; set; }
        public decimal? maxLifeInterestCapPercent { get; set; }
        public string timelyPaymentRewards { get; set; }
        public decimal? timelyPaymentRateReductionPercent { get; set; }
        public int? monthsAppliedToPrepaymentPenaltyFeeCount { get; set; }
        public string prepaymentPenaltyBasedOn { get; set; }
        public int? hardPrepaymentPenaltyMonths { get; set; }
        public DateTime? scheduledFirstPaymentAdjustmentDate { get; set; }
        public decimal? totalSubsidyAmount { get; set; }
        public decimal? remainingBuydownAmount { get; set; }
        public decimal? maximumMonthlyPayment { get; set; }
        public string nmlsLoanType { get; set; }
        public string nmlsFirstMortgageType { get; set; }
        public string nmlsDocumentationType { get; set; }
        public bool? nmlsOptionARMIndicator { get; set; }
        public bool? nmlsPiggyBackOrFundedHELOCIndicator { get; set; }
        public string nmlsRefinancePurposeType { get; set; }
        public string nmlsProductionSoldToType { get; set; }
        public string branchManagerNmlsId { get; set; }
        public string branchLocationNmlsId { get; set; }
        public string nmlsReverseMortgageType { get; set; }
        public decimal? initialApplicationAmount { get; set; }
        public decimal? netInitialAndFinal { get; set; }
        public bool? inquiryOrPreQualificationIndicator { get; set; }
        public bool? oralRequestForExtensionOfCreditIndicator { get; set; }
        public bool? excludeLoanFromNMLSReportIndicator { get; set; }
        public bool? applyLifeCapLowIndicator { get; set; }
        public string floorBasis { get; set; }
        public string floorVerbiage { get; set; }
        public string indexLookbackPeriod { get; set; }
        public string prepaymentPenaltyVerbiage { get; set; }
        public decimal? participationFees { get; set; }
        public decimal? transactionFees { get; set; }
        public decimal? minimumPaymentUpbPercent { get; set; }
        public decimal? overLimitCharge { get; set; }
        public decimal? overLimitReturnCharge { get; set; }
        public decimal? releaseRecoringCharge { get; set; }
        public decimal? returnedCheckCharge { get; set; }
        public decimal? returnedCheckMaxCharge { get; set; }
        public decimal? returnedCheckMinCharge { get; set; }
        public decimal? returnedCheckChargeRatePercent { get; set; }
        public decimal? stopPaymentCharge { get; set; }
        public decimal? wireFee { get; set; }
        public decimal? minimumPaymentUpbAmount { get; set; }
        public decimal? minimumPaymentLessThanAmount { get; set; }
        public decimal? minimumRepayPeriodPaymentPercent { get; set; }
        public decimal? minimumDrawPeroidPaymentPercent { get; set; }
        public DateTime? borrowerEstimatedClosingDate { get; set; }
        public string id { get; set; }

    }
}
