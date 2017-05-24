using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanProductData
    {
        public Value<decimal?> AnnualFeeNeededAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFeeNeededAmount() => !AnnualFeeNeededAmount.Clean;
        public Value<bool?> ApplyLifeCapLowIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplyLifeCapLowIndicator() => !ApplyLifeCapLowIndicator.Clean;
        public Value<string> ArmDisclosureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArmDisclosureType() => !ArmDisclosureType.Clean;
        public Value<string> ArmIndexType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArmIndexType() => !ArmIndexType.Clean;
        public Value<bool?> BalloonIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalloonIndicator() => !BalloonIndicator.Clean;
        public Value<int?> BalloonLoanMaturityTermMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalloonLoanMaturityTermMonthsCount() => !BalloonLoanMaturityTermMonthsCount.Clean;
        public Value<DateTime?> BorrowerEstimatedClosingDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerEstimatedClosingDate() => !BorrowerEstimatedClosingDate.Clean;
        public Value<string> BranchLocationNmlsId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchLocationNmlsId() => !BranchLocationNmlsId.Clean;
        public Value<string> BranchManagerNmlsId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranchManagerNmlsId() => !BranchManagerNmlsId.Clean;
        public Value<List<Buydown>> Buydowns { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydowns() => !Buydowns.Clean;
        public Value<bool?> ConvertibleIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConvertibleIndicator() => !ConvertibleIndicator.Clean;
        public Value<string> Discounted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscounted() => !Discounted.Clean;
        public Value<decimal?> DiscountedRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountedRate() => !DiscountedRate.Clean;
        public Value<int?> DrawPeriodMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawPeriodMonthsCount() => !DrawPeriodMonthsCount.Clean;
        public Value<bool?> EscrowWaiverIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowWaiverIndicator() => !EscrowWaiverIndicator.Clean;
        public Value<bool?> ExcludeLoanFromNMLSReportIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExcludeLoanFromNMLSReportIndicator() => !ExcludeLoanFromNMLSReportIndicator.Clean;
        public Value<string> FloorBasis { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloorBasis() => !FloorBasis.Clean;
        public Value<decimal?> FloorPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloorPercent() => !FloorPercent.Clean;
        public Value<string> FloorVerbiage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloorVerbiage() => !FloorVerbiage.Clean;
        public Value<string> FnmProductPlanIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFnmProductPlanIdentifier() => !FnmProductPlanIdentifier.Clean;
        public Value<string> FreddieMacArmIndexType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMacArmIndexType() => !FreddieMacArmIndexType.Clean;
        public Value<string> FreOfferingIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreOfferingIdentifier() => !FreOfferingIdentifier.Clean;
        public Value<string> FullPrepaymentPenaltyOptionType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullPrepaymentPenaltyOptionType() => !FullPrepaymentPenaltyOptionType.Clean;
        public Value<string> GseProjectClassificationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGseProjectClassificationType() => !GseProjectClassificationType.Clean;
        public Value<string> GsePropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGsePropertyType() => !GsePropertyType.Clean;
        public Value<int?> HardPrepaymentPenaltyMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHardPrepaymentPenaltyMonths() => !HardPrepaymentPenaltyMonths.Clean;
        public Value<string> HelocPeriodTemplateName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHelocPeriodTemplateName() => !HelocPeriodTemplateName.Clean;
        public Value<List<HelocRepaymentDrawPeriod>> HelocRepaymentDrawPeriods { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHelocRepaymentDrawPeriods() => !HelocRepaymentDrawPeriods.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> IndexCurrentValuePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexCurrentValuePercent() => !IndexCurrentValuePercent.Clean;
        public Value<string> IndexLookbackPeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexLookbackPeriod() => !IndexLookbackPeriod.Clean;
        public Value<decimal?> IndexMarginPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexMarginPercent() => !IndexMarginPercent.Clean;
        public Value<decimal?> InitialAdvanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialAdvanceAmount() => !InitialAdvanceAmount.Clean;
        public Value<decimal?> InitialApplicationAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialApplicationAmount() => !InitialApplicationAmount.Clean;
        public Value<bool?> InquiryOrPreQualificationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInquiryOrPreQualificationIndicator() => !InquiryOrPreQualificationIndicator.Clean;
        public Value<string> LienPriorityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienPriorityType() => !LienPriorityType.Clean;
        public Value<string> LoanDocumentationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDocumentationType() => !LoanDocumentationType.Clean;
        public Value<string> LoanRepaymentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanRepaymentType() => !LoanRepaymentType.Clean;
        public Value<DateTime?> LoanScheduledClosingDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanScheduledClosingDate() => !LoanScheduledClosingDate.Clean;
        public Value<decimal?> MaximumMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumMonthlyPayment() => !MaximumMonthlyPayment.Clean;
        public Value<decimal?> MaxLifeInterestCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxLifeInterestCapPercent() => !MaxLifeInterestCapPercent.Clean;
        public Value<decimal?> MiCoveragePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiCoveragePercent() => !MiCoveragePercent.Clean;
        public Value<decimal?> MinimumAdvanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumAdvanceAmount() => !MinimumAdvanceAmount.Clean;
        public Value<decimal?> MinimumAllowableApr { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumAllowableApr() => !MinimumAllowableApr.Clean;
        public Value<decimal?> MinimumDrawPeroidPaymentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumDrawPeroidPaymentPercent() => !MinimumDrawPeroidPaymentPercent.Clean;
        public Value<decimal?> MinimumPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumPaymentAmount() => !MinimumPaymentAmount.Clean;
        public Value<decimal?> MinimumPaymentLessThanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumPaymentLessThanAmount() => !MinimumPaymentLessThanAmount.Clean;
        public Value<decimal?> MinimumPaymentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumPaymentPercent() => !MinimumPaymentPercent.Clean;
        public Value<decimal?> MinimumPaymentUpbAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumPaymentUpbAmount() => !MinimumPaymentUpbAmount.Clean;
        public Value<decimal?> MinimumPaymentUpbPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumPaymentUpbPercent() => !MinimumPaymentUpbPercent.Clean;
        public Value<decimal?> MinimumRepayPeriodPaymentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumRepayPeriodPaymentPercent() => !MinimumRepayPeriodPaymentPercent.Clean;
        public Value<int?> MonthsAppliedToPrepaymentPenaltyFeeCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthsAppliedToPrepaymentPenaltyFeeCount() => !MonthsAppliedToPrepaymentPenaltyFeeCount.Clean;
        public Value<decimal?> NegativeAmortizationLimitPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNegativeAmortizationLimitPercent() => !NegativeAmortizationLimitPercent.Clean;
        public Value<decimal?> NetInitialAndFinal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNetInitialAndFinal() => !NetInitialAndFinal.Clean;
        public Value<string> NmlsDocumentationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsDocumentationType() => !NmlsDocumentationType.Clean;
        public Value<string> NmlsFirstMortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsFirstMortgageType() => !NmlsFirstMortgageType.Clean;
        public Value<string> NmlsLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsLoanType() => !NmlsLoanType.Clean;
        public Value<bool?> NmlsOptionARMIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsOptionARMIndicator() => !NmlsOptionARMIndicator.Clean;
        public Value<bool?> NmlsPiggyBackOrFundedHELOCIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsPiggyBackOrFundedHELOCIndicator() => !NmlsPiggyBackOrFundedHELOCIndicator.Clean;
        public Value<string> NmlsProductionSoldToType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsProductionSoldToType() => !NmlsProductionSoldToType.Clean;
        public Value<string> NmlsRefinancePurposeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsRefinancePurposeType() => !NmlsRefinancePurposeType.Clean;
        public Value<string> NmlsReverseMortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNmlsReverseMortgageType() => !NmlsReverseMortgageType.Clean;
        public Value<bool?> OralRequestForExtensionOfCreditIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOralRequestForExtensionOfCreditIndicator() => !OralRequestForExtensionOfCreditIndicator.Clean;
        public Value<decimal?> OverLimitCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOverLimitCharge() => !OverLimitCharge.Clean;
        public Value<decimal?> OverLimitReturnCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOverLimitReturnCharge() => !OverLimitReturnCharge.Clean;
        public Value<decimal?> ParticipationFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParticipationFees() => !ParticipationFees.Clean;
        public Value<int?> PaymentAdjustmentDurationMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentAdjustmentDurationMonthsCount() => !PaymentAdjustmentDurationMonthsCount.Clean;
        public Value<decimal?> PaymentAdjustmentPeriodicCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentAdjustmentPeriodicCapPercent() => !PaymentAdjustmentPeriodicCapPercent.Clean;
        public Value<string> PaymentFrequencyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentFrequencyType() => !PaymentFrequencyType.Clean;
        public Value<List<PrepaymentPenalty>> PrepaymentPenalties { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenalties() => !PrepaymentPenalties.Clean;
        public Value<string> PrepaymentPenaltyBasedOn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyBasedOn() => !PrepaymentPenaltyBasedOn.Clean;
        public Value<bool?> PrepaymentPenaltyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyIndicator() => !PrepaymentPenaltyIndicator.Clean;
        public Value<decimal?> PrepaymentPenaltyPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPercent() => !PrepaymentPenaltyPercent.Clean;
        public Value<int?> PrepaymentPenaltyTermMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyTermMonthsCount() => !PrepaymentPenaltyTermMonthsCount.Clean;
        public Value<string> PrepaymentPenaltyVerbiage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyVerbiage() => !PrepaymentPenaltyVerbiage.Clean;
        public Value<string> ProductName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProductName() => !ProductName.Clean;
        public Value<decimal?> QualifyingRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQualifyingRatePercent() => !QualifyingRatePercent.Clean;
        public Value<int?> RateAdjustmentDurationMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentDurationMonthsCount() => !RateAdjustmentDurationMonthsCount.Clean;
        public Value<decimal?> RateAdjustmentLifetimeCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentLifetimeCapPercent() => !RateAdjustmentLifetimeCapPercent.Clean;
        public Value<decimal?> RateAdjustmentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentPercent() => !RateAdjustmentPercent.Clean;
        public Value<decimal?> RateAdjustmentSubsequentCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentSubsequentCapPercent() => !RateAdjustmentSubsequentCapPercent.Clean;
        public Value<decimal?> ReleaseRecoringCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReleaseRecoringCharge() => !ReleaseRecoringCharge.Clean;
        public Value<decimal?> RemainingBuydownAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRemainingBuydownAmount() => !RemainingBuydownAmount.Clean;
        public Value<int?> RepayPeriodMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepayPeriodMonthsCount() => !RepayPeriodMonthsCount.Clean;
        public Value<decimal?> ReturnedCheckCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnedCheckCharge() => !ReturnedCheckCharge.Clean;
        public Value<decimal?> ReturnedCheckChargeRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnedCheckChargeRatePercent() => !ReturnedCheckChargeRatePercent.Clean;
        public Value<decimal?> ReturnedCheckMaxCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnedCheckMaxCharge() => !ReturnedCheckMaxCharge.Clean;
        public Value<decimal?> ReturnedCheckMinCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnedCheckMinCharge() => !ReturnedCheckMinCharge.Clean;
        public Value<decimal?> RoundPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundPercent() => !RoundPercent.Clean;
        public Value<string> RoundType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundType() => !RoundType.Clean;
        public Value<DateTime?> ScheduledFirstPaymentAdjustmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeScheduledFirstPaymentAdjustmentDate() => !ScheduledFirstPaymentAdjustmentDate.Clean;
        public Value<DateTime?> ScheduledFirstPaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeScheduledFirstPaymentDate() => !ScheduledFirstPaymentDate.Clean;
        public Value<decimal?> StopPaymentCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStopPaymentCharge() => !StopPaymentCharge.Clean;
        public Value<int?> SubsequentRateAdjustmentMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentRateAdjustmentMonthsCount() => !SubsequentRateAdjustmentMonthsCount.Clean;
        public Value<decimal?> TerminationFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTerminationFeeAmount() => !TerminationFeeAmount.Clean;
        public Value<int?> TerminationPeriodMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTerminationPeriodMonthsCount() => !TerminationPeriodMonthsCount.Clean;
        public Value<decimal?> ThirdPartyFeeFromAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyFeeFromAmount() => !ThirdPartyFeeFromAmount.Clean;
        public Value<decimal?> ThirdPartyFeeToAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyFeeToAmount() => !ThirdPartyFeeToAmount.Clean;
        public Value<decimal?> TimelyPaymentRateReductionPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimelyPaymentRateReductionPercent() => !TimelyPaymentRateReductionPercent.Clean;
        public Value<string> TimelyPaymentRewards { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimelyPaymentRewards() => !TimelyPaymentRewards.Clean;
        public Value<decimal?> TotalSubsidyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalSubsidyAmount() => !TotalSubsidyAmount.Clean;
        public Value<decimal?> TransactionFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionFees() => !TransactionFees.Clean;
        public Value<decimal?> WireFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWireFee() => !WireFee.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AnnualFeeNeededAmount.Clean
                    && ApplyLifeCapLowIndicator.Clean
                    && ArmDisclosureType.Clean
                    && ArmIndexType.Clean
                    && BalloonIndicator.Clean
                    && BalloonLoanMaturityTermMonthsCount.Clean
                    && BorrowerEstimatedClosingDate.Clean
                    && BranchLocationNmlsId.Clean
                    && BranchManagerNmlsId.Clean
                    && Buydowns.Clean
                    && ConvertibleIndicator.Clean
                    && Discounted.Clean
                    && DiscountedRate.Clean
                    && DrawPeriodMonthsCount.Clean
                    && EscrowWaiverIndicator.Clean
                    && ExcludeLoanFromNMLSReportIndicator.Clean
                    && FloorBasis.Clean
                    && FloorPercent.Clean
                    && FloorVerbiage.Clean
                    && FnmProductPlanIdentifier.Clean
                    && FreddieMacArmIndexType.Clean
                    && FreOfferingIdentifier.Clean
                    && FullPrepaymentPenaltyOptionType.Clean
                    && GseProjectClassificationType.Clean
                    && GsePropertyType.Clean
                    && HardPrepaymentPenaltyMonths.Clean
                    && HelocPeriodTemplateName.Clean
                    && HelocRepaymentDrawPeriods.Clean
                    && Id.Clean
                    && IndexCurrentValuePercent.Clean
                    && IndexLookbackPeriod.Clean
                    && IndexMarginPercent.Clean
                    && InitialAdvanceAmount.Clean
                    && InitialApplicationAmount.Clean
                    && InquiryOrPreQualificationIndicator.Clean
                    && LienPriorityType.Clean
                    && LoanDocumentationType.Clean
                    && LoanRepaymentType.Clean
                    && LoanScheduledClosingDate.Clean
                    && MaximumMonthlyPayment.Clean
                    && MaxLifeInterestCapPercent.Clean
                    && MiCoveragePercent.Clean
                    && MinimumAdvanceAmount.Clean
                    && MinimumAllowableApr.Clean
                    && MinimumDrawPeroidPaymentPercent.Clean
                    && MinimumPaymentAmount.Clean
                    && MinimumPaymentLessThanAmount.Clean
                    && MinimumPaymentPercent.Clean
                    && MinimumPaymentUpbAmount.Clean
                    && MinimumPaymentUpbPercent.Clean
                    && MinimumRepayPeriodPaymentPercent.Clean
                    && MonthsAppliedToPrepaymentPenaltyFeeCount.Clean
                    && NegativeAmortizationLimitPercent.Clean
                    && NetInitialAndFinal.Clean
                    && NmlsDocumentationType.Clean
                    && NmlsFirstMortgageType.Clean
                    && NmlsLoanType.Clean
                    && NmlsOptionARMIndicator.Clean
                    && NmlsPiggyBackOrFundedHELOCIndicator.Clean
                    && NmlsProductionSoldToType.Clean
                    && NmlsRefinancePurposeType.Clean
                    && NmlsReverseMortgageType.Clean
                    && OralRequestForExtensionOfCreditIndicator.Clean
                    && OverLimitCharge.Clean
                    && OverLimitReturnCharge.Clean
                    && ParticipationFees.Clean
                    && PaymentAdjustmentDurationMonthsCount.Clean
                    && PaymentAdjustmentPeriodicCapPercent.Clean
                    && PaymentFrequencyType.Clean
                    && PrepaymentPenalties.Clean
                    && PrepaymentPenaltyBasedOn.Clean
                    && PrepaymentPenaltyIndicator.Clean
                    && PrepaymentPenaltyPercent.Clean
                    && PrepaymentPenaltyTermMonthsCount.Clean
                    && PrepaymentPenaltyVerbiage.Clean
                    && ProductName.Clean
                    && QualifyingRatePercent.Clean
                    && RateAdjustmentDurationMonthsCount.Clean
                    && RateAdjustmentLifetimeCapPercent.Clean
                    && RateAdjustmentPercent.Clean
                    && RateAdjustmentSubsequentCapPercent.Clean
                    && ReleaseRecoringCharge.Clean
                    && RemainingBuydownAmount.Clean
                    && RepayPeriodMonthsCount.Clean
                    && ReturnedCheckCharge.Clean
                    && ReturnedCheckChargeRatePercent.Clean
                    && ReturnedCheckMaxCharge.Clean
                    && ReturnedCheckMinCharge.Clean
                    && RoundPercent.Clean
                    && RoundType.Clean
                    && ScheduledFirstPaymentAdjustmentDate.Clean
                    && ScheduledFirstPaymentDate.Clean
                    && StopPaymentCharge.Clean
                    && SubsequentRateAdjustmentMonthsCount.Clean
                    && TerminationFeeAmount.Clean
                    && TerminationPeriodMonthsCount.Clean
                    && ThirdPartyFeeFromAmount.Clean
                    && ThirdPartyFeeToAmount.Clean
                    && TimelyPaymentRateReductionPercent.Clean
                    && TimelyPaymentRewards.Clean
                    && TotalSubsidyAmount.Clean
                    && TransactionFees.Clean
                    && WireFee.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AnnualFeeNeededAmount; v0.Clean = value; AnnualFeeNeededAmount = v0;
                var v1 = ApplyLifeCapLowIndicator; v1.Clean = value; ApplyLifeCapLowIndicator = v1;
                var v2 = ArmDisclosureType; v2.Clean = value; ArmDisclosureType = v2;
                var v3 = ArmIndexType; v3.Clean = value; ArmIndexType = v3;
                var v4 = BalloonIndicator; v4.Clean = value; BalloonIndicator = v4;
                var v5 = BalloonLoanMaturityTermMonthsCount; v5.Clean = value; BalloonLoanMaturityTermMonthsCount = v5;
                var v6 = BorrowerEstimatedClosingDate; v6.Clean = value; BorrowerEstimatedClosingDate = v6;
                var v7 = BranchLocationNmlsId; v7.Clean = value; BranchLocationNmlsId = v7;
                var v8 = BranchManagerNmlsId; v8.Clean = value; BranchManagerNmlsId = v8;
                var v9 = Buydowns; v9.Clean = value; Buydowns = v9;
                var v10 = ConvertibleIndicator; v10.Clean = value; ConvertibleIndicator = v10;
                var v11 = Discounted; v11.Clean = value; Discounted = v11;
                var v12 = DiscountedRate; v12.Clean = value; DiscountedRate = v12;
                var v13 = DrawPeriodMonthsCount; v13.Clean = value; DrawPeriodMonthsCount = v13;
                var v14 = EscrowWaiverIndicator; v14.Clean = value; EscrowWaiverIndicator = v14;
                var v15 = ExcludeLoanFromNMLSReportIndicator; v15.Clean = value; ExcludeLoanFromNMLSReportIndicator = v15;
                var v16 = FloorBasis; v16.Clean = value; FloorBasis = v16;
                var v17 = FloorPercent; v17.Clean = value; FloorPercent = v17;
                var v18 = FloorVerbiage; v18.Clean = value; FloorVerbiage = v18;
                var v19 = FnmProductPlanIdentifier; v19.Clean = value; FnmProductPlanIdentifier = v19;
                var v20 = FreddieMacArmIndexType; v20.Clean = value; FreddieMacArmIndexType = v20;
                var v21 = FreOfferingIdentifier; v21.Clean = value; FreOfferingIdentifier = v21;
                var v22 = FullPrepaymentPenaltyOptionType; v22.Clean = value; FullPrepaymentPenaltyOptionType = v22;
                var v23 = GseProjectClassificationType; v23.Clean = value; GseProjectClassificationType = v23;
                var v24 = GsePropertyType; v24.Clean = value; GsePropertyType = v24;
                var v25 = HardPrepaymentPenaltyMonths; v25.Clean = value; HardPrepaymentPenaltyMonths = v25;
                var v26 = HelocPeriodTemplateName; v26.Clean = value; HelocPeriodTemplateName = v26;
                var v27 = HelocRepaymentDrawPeriods; v27.Clean = value; HelocRepaymentDrawPeriods = v27;
                var v28 = Id; v28.Clean = value; Id = v28;
                var v29 = IndexCurrentValuePercent; v29.Clean = value; IndexCurrentValuePercent = v29;
                var v30 = IndexLookbackPeriod; v30.Clean = value; IndexLookbackPeriod = v30;
                var v31 = IndexMarginPercent; v31.Clean = value; IndexMarginPercent = v31;
                var v32 = InitialAdvanceAmount; v32.Clean = value; InitialAdvanceAmount = v32;
                var v33 = InitialApplicationAmount; v33.Clean = value; InitialApplicationAmount = v33;
                var v34 = InquiryOrPreQualificationIndicator; v34.Clean = value; InquiryOrPreQualificationIndicator = v34;
                var v35 = LienPriorityType; v35.Clean = value; LienPriorityType = v35;
                var v36 = LoanDocumentationType; v36.Clean = value; LoanDocumentationType = v36;
                var v37 = LoanRepaymentType; v37.Clean = value; LoanRepaymentType = v37;
                var v38 = LoanScheduledClosingDate; v38.Clean = value; LoanScheduledClosingDate = v38;
                var v39 = MaximumMonthlyPayment; v39.Clean = value; MaximumMonthlyPayment = v39;
                var v40 = MaxLifeInterestCapPercent; v40.Clean = value; MaxLifeInterestCapPercent = v40;
                var v41 = MiCoveragePercent; v41.Clean = value; MiCoveragePercent = v41;
                var v42 = MinimumAdvanceAmount; v42.Clean = value; MinimumAdvanceAmount = v42;
                var v43 = MinimumAllowableApr; v43.Clean = value; MinimumAllowableApr = v43;
                var v44 = MinimumDrawPeroidPaymentPercent; v44.Clean = value; MinimumDrawPeroidPaymentPercent = v44;
                var v45 = MinimumPaymentAmount; v45.Clean = value; MinimumPaymentAmount = v45;
                var v46 = MinimumPaymentLessThanAmount; v46.Clean = value; MinimumPaymentLessThanAmount = v46;
                var v47 = MinimumPaymentPercent; v47.Clean = value; MinimumPaymentPercent = v47;
                var v48 = MinimumPaymentUpbAmount; v48.Clean = value; MinimumPaymentUpbAmount = v48;
                var v49 = MinimumPaymentUpbPercent; v49.Clean = value; MinimumPaymentUpbPercent = v49;
                var v50 = MinimumRepayPeriodPaymentPercent; v50.Clean = value; MinimumRepayPeriodPaymentPercent = v50;
                var v51 = MonthsAppliedToPrepaymentPenaltyFeeCount; v51.Clean = value; MonthsAppliedToPrepaymentPenaltyFeeCount = v51;
                var v52 = NegativeAmortizationLimitPercent; v52.Clean = value; NegativeAmortizationLimitPercent = v52;
                var v53 = NetInitialAndFinal; v53.Clean = value; NetInitialAndFinal = v53;
                var v54 = NmlsDocumentationType; v54.Clean = value; NmlsDocumentationType = v54;
                var v55 = NmlsFirstMortgageType; v55.Clean = value; NmlsFirstMortgageType = v55;
                var v56 = NmlsLoanType; v56.Clean = value; NmlsLoanType = v56;
                var v57 = NmlsOptionARMIndicator; v57.Clean = value; NmlsOptionARMIndicator = v57;
                var v58 = NmlsPiggyBackOrFundedHELOCIndicator; v58.Clean = value; NmlsPiggyBackOrFundedHELOCIndicator = v58;
                var v59 = NmlsProductionSoldToType; v59.Clean = value; NmlsProductionSoldToType = v59;
                var v60 = NmlsRefinancePurposeType; v60.Clean = value; NmlsRefinancePurposeType = v60;
                var v61 = NmlsReverseMortgageType; v61.Clean = value; NmlsReverseMortgageType = v61;
                var v62 = OralRequestForExtensionOfCreditIndicator; v62.Clean = value; OralRequestForExtensionOfCreditIndicator = v62;
                var v63 = OverLimitCharge; v63.Clean = value; OverLimitCharge = v63;
                var v64 = OverLimitReturnCharge; v64.Clean = value; OverLimitReturnCharge = v64;
                var v65 = ParticipationFees; v65.Clean = value; ParticipationFees = v65;
                var v66 = PaymentAdjustmentDurationMonthsCount; v66.Clean = value; PaymentAdjustmentDurationMonthsCount = v66;
                var v67 = PaymentAdjustmentPeriodicCapPercent; v67.Clean = value; PaymentAdjustmentPeriodicCapPercent = v67;
                var v68 = PaymentFrequencyType; v68.Clean = value; PaymentFrequencyType = v68;
                var v69 = PrepaymentPenalties; v69.Clean = value; PrepaymentPenalties = v69;
                var v70 = PrepaymentPenaltyBasedOn; v70.Clean = value; PrepaymentPenaltyBasedOn = v70;
                var v71 = PrepaymentPenaltyIndicator; v71.Clean = value; PrepaymentPenaltyIndicator = v71;
                var v72 = PrepaymentPenaltyPercent; v72.Clean = value; PrepaymentPenaltyPercent = v72;
                var v73 = PrepaymentPenaltyTermMonthsCount; v73.Clean = value; PrepaymentPenaltyTermMonthsCount = v73;
                var v74 = PrepaymentPenaltyVerbiage; v74.Clean = value; PrepaymentPenaltyVerbiage = v74;
                var v75 = ProductName; v75.Clean = value; ProductName = v75;
                var v76 = QualifyingRatePercent; v76.Clean = value; QualifyingRatePercent = v76;
                var v77 = RateAdjustmentDurationMonthsCount; v77.Clean = value; RateAdjustmentDurationMonthsCount = v77;
                var v78 = RateAdjustmentLifetimeCapPercent; v78.Clean = value; RateAdjustmentLifetimeCapPercent = v78;
                var v79 = RateAdjustmentPercent; v79.Clean = value; RateAdjustmentPercent = v79;
                var v80 = RateAdjustmentSubsequentCapPercent; v80.Clean = value; RateAdjustmentSubsequentCapPercent = v80;
                var v81 = ReleaseRecoringCharge; v81.Clean = value; ReleaseRecoringCharge = v81;
                var v82 = RemainingBuydownAmount; v82.Clean = value; RemainingBuydownAmount = v82;
                var v83 = RepayPeriodMonthsCount; v83.Clean = value; RepayPeriodMonthsCount = v83;
                var v84 = ReturnedCheckCharge; v84.Clean = value; ReturnedCheckCharge = v84;
                var v85 = ReturnedCheckChargeRatePercent; v85.Clean = value; ReturnedCheckChargeRatePercent = v85;
                var v86 = ReturnedCheckMaxCharge; v86.Clean = value; ReturnedCheckMaxCharge = v86;
                var v87 = ReturnedCheckMinCharge; v87.Clean = value; ReturnedCheckMinCharge = v87;
                var v88 = RoundPercent; v88.Clean = value; RoundPercent = v88;
                var v89 = RoundType; v89.Clean = value; RoundType = v89;
                var v90 = ScheduledFirstPaymentAdjustmentDate; v90.Clean = value; ScheduledFirstPaymentAdjustmentDate = v90;
                var v91 = ScheduledFirstPaymentDate; v91.Clean = value; ScheduledFirstPaymentDate = v91;
                var v92 = StopPaymentCharge; v92.Clean = value; StopPaymentCharge = v92;
                var v93 = SubsequentRateAdjustmentMonthsCount; v93.Clean = value; SubsequentRateAdjustmentMonthsCount = v93;
                var v94 = TerminationFeeAmount; v94.Clean = value; TerminationFeeAmount = v94;
                var v95 = TerminationPeriodMonthsCount; v95.Clean = value; TerminationPeriodMonthsCount = v95;
                var v96 = ThirdPartyFeeFromAmount; v96.Clean = value; ThirdPartyFeeFromAmount = v96;
                var v97 = ThirdPartyFeeToAmount; v97.Clean = value; ThirdPartyFeeToAmount = v97;
                var v98 = TimelyPaymentRateReductionPercent; v98.Clean = value; TimelyPaymentRateReductionPercent = v98;
                var v99 = TimelyPaymentRewards; v99.Clean = value; TimelyPaymentRewards = v99;
                var v100 = TotalSubsidyAmount; v100.Clean = value; TotalSubsidyAmount = v100;
                var v101 = TransactionFees; v101.Clean = value; TransactionFees = v101;
                var v102 = WireFee; v102.Clean = value; WireFee = v102;
                _settingClean = 0;
            }
        }
    }
}