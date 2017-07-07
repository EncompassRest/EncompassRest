using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanProductData : IClean
    {
        private Value<decimal?> _annualFeeNeededAmount;
        public decimal? AnnualFeeNeededAmount { get { return _annualFeeNeededAmount; } set { _annualFeeNeededAmount = value; } }
        private Value<bool?> _applyLifeCapLowIndicator;
        public bool? ApplyLifeCapLowIndicator { get { return _applyLifeCapLowIndicator; } set { _applyLifeCapLowIndicator = value; } }
        private Value<string> _armDisclosureType;
        public string ArmDisclosureType { get { return _armDisclosureType; } set { _armDisclosureType = value; } }
        private Value<string> _armIndexType;
        public string ArmIndexType { get { return _armIndexType; } set { _armIndexType = value; } }
        private Value<bool?> _balloonIndicator;
        public bool? BalloonIndicator { get { return _balloonIndicator; } set { _balloonIndicator = value; } }
        private Value<int?> _balloonLoanMaturityTermMonthsCount;
        public int? BalloonLoanMaturityTermMonthsCount { get { return _balloonLoanMaturityTermMonthsCount; } set { _balloonLoanMaturityTermMonthsCount = value; } }
        private Value<DateTime?> _borrowerEstimatedClosingDate;
        public DateTime? BorrowerEstimatedClosingDate { get { return _borrowerEstimatedClosingDate; } set { _borrowerEstimatedClosingDate = value; } }
        private Value<string> _branchLocationNmlsId;
        public string BranchLocationNmlsId { get { return _branchLocationNmlsId; } set { _branchLocationNmlsId = value; } }
        private Value<string> _branchManagerNmlsId;
        public string BranchManagerNmlsId { get { return _branchManagerNmlsId; } set { _branchManagerNmlsId = value; } }
        private Value<List<Buydown>> _buydowns;
        public List<Buydown> Buydowns { get { return _buydowns; } set { _buydowns = value; } }
        private Value<bool?> _convertibleIndicator;
        public bool? ConvertibleIndicator { get { return _convertibleIndicator; } set { _convertibleIndicator = value; } }
        private Value<string> _discounted;
        public string Discounted { get { return _discounted; } set { _discounted = value; } }
        private Value<decimal?> _discountedRate;
        public decimal? DiscountedRate { get { return _discountedRate; } set { _discountedRate = value; } }
        private Value<int?> _drawPeriodMonthsCount;
        public int? DrawPeriodMonthsCount { get { return _drawPeriodMonthsCount; } set { _drawPeriodMonthsCount = value; } }
        private Value<bool?> _escrowWaiverIndicator;
        public bool? EscrowWaiverIndicator { get { return _escrowWaiverIndicator; } set { _escrowWaiverIndicator = value; } }
        private Value<bool?> _excludeLoanFromNMLSReportIndicator;
        public bool? ExcludeLoanFromNMLSReportIndicator { get { return _excludeLoanFromNMLSReportIndicator; } set { _excludeLoanFromNMLSReportIndicator = value; } }
        private Value<string> _floorBasis;
        public string FloorBasis { get { return _floorBasis; } set { _floorBasis = value; } }
        private Value<decimal?> _floorPercent;
        public decimal? FloorPercent { get { return _floorPercent; } set { _floorPercent = value; } }
        private Value<string> _floorVerbiage;
        public string FloorVerbiage { get { return _floorVerbiage; } set { _floorVerbiage = value; } }
        private Value<string> _fnmProductPlanIdentifier;
        public string FnmProductPlanIdentifier { get { return _fnmProductPlanIdentifier; } set { _fnmProductPlanIdentifier = value; } }
        private Value<string> _freddieMacArmIndexType;
        public string FreddieMacArmIndexType { get { return _freddieMacArmIndexType; } set { _freddieMacArmIndexType = value; } }
        private Value<string> _freOfferingIdentifier;
        public string FreOfferingIdentifier { get { return _freOfferingIdentifier; } set { _freOfferingIdentifier = value; } }
        private Value<string> _fullPrepaymentPenaltyOptionType;
        public string FullPrepaymentPenaltyOptionType { get { return _fullPrepaymentPenaltyOptionType; } set { _fullPrepaymentPenaltyOptionType = value; } }
        private Value<string> _gseProjectClassificationType;
        public string GseProjectClassificationType { get { return _gseProjectClassificationType; } set { _gseProjectClassificationType = value; } }
        private Value<string> _gsePropertyType;
        public string GsePropertyType { get { return _gsePropertyType; } set { _gsePropertyType = value; } }
        private Value<int?> _hardPrepaymentPenaltyMonths;
        public int? HardPrepaymentPenaltyMonths { get { return _hardPrepaymentPenaltyMonths; } set { _hardPrepaymentPenaltyMonths = value; } }
        private Value<string> _helocPeriodTemplateName;
        public string HelocPeriodTemplateName { get { return _helocPeriodTemplateName; } set { _helocPeriodTemplateName = value; } }
        private Value<List<HelocRepaymentDrawPeriod>> _helocRepaymentDrawPeriods;
        public List<HelocRepaymentDrawPeriod> HelocRepaymentDrawPeriods { get { return _helocRepaymentDrawPeriods; } set { _helocRepaymentDrawPeriods = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _indexCurrentValuePercent;
        public decimal? IndexCurrentValuePercent { get { return _indexCurrentValuePercent; } set { _indexCurrentValuePercent = value; } }
        private Value<string> _indexLookbackPeriod;
        public string IndexLookbackPeriod { get { return _indexLookbackPeriod; } set { _indexLookbackPeriod = value; } }
        private Value<decimal?> _indexMarginPercent;
        public decimal? IndexMarginPercent { get { return _indexMarginPercent; } set { _indexMarginPercent = value; } }
        private Value<decimal?> _initialAdvanceAmount;
        public decimal? InitialAdvanceAmount { get { return _initialAdvanceAmount; } set { _initialAdvanceAmount = value; } }
        private Value<decimal?> _initialApplicationAmount;
        public decimal? InitialApplicationAmount { get { return _initialApplicationAmount; } set { _initialApplicationAmount = value; } }
        private Value<bool?> _inquiryOrPreQualificationIndicator;
        public bool? InquiryOrPreQualificationIndicator { get { return _inquiryOrPreQualificationIndicator; } set { _inquiryOrPreQualificationIndicator = value; } }
        private Value<string> _lienPriorityType;
        public string LienPriorityType { get { return _lienPriorityType; } set { _lienPriorityType = value; } }
        private Value<string> _loanDocumentationType;
        public string LoanDocumentationType { get { return _loanDocumentationType; } set { _loanDocumentationType = value; } }
        private Value<string> _loanRepaymentType;
        public string LoanRepaymentType { get { return _loanRepaymentType; } set { _loanRepaymentType = value; } }
        private Value<DateTime?> _loanScheduledClosingDate;
        public DateTime? LoanScheduledClosingDate { get { return _loanScheduledClosingDate; } set { _loanScheduledClosingDate = value; } }
        private Value<decimal?> _maximumMonthlyPayment;
        public decimal? MaximumMonthlyPayment { get { return _maximumMonthlyPayment; } set { _maximumMonthlyPayment = value; } }
        private Value<decimal?> _maxLifeInterestCapPercent;
        public decimal? MaxLifeInterestCapPercent { get { return _maxLifeInterestCapPercent; } set { _maxLifeInterestCapPercent = value; } }
        private Value<decimal?> _miCoveragePercent;
        public decimal? MiCoveragePercent { get { return _miCoveragePercent; } set { _miCoveragePercent = value; } }
        private Value<decimal?> _minimumAdvanceAmount;
        public decimal? MinimumAdvanceAmount { get { return _minimumAdvanceAmount; } set { _minimumAdvanceAmount = value; } }
        private Value<decimal?> _minimumAllowableApr;
        public decimal? MinimumAllowableApr { get { return _minimumAllowableApr; } set { _minimumAllowableApr = value; } }
        private Value<decimal?> _minimumDrawPeroidPaymentPercent;
        public decimal? MinimumDrawPeroidPaymentPercent { get { return _minimumDrawPeroidPaymentPercent; } set { _minimumDrawPeroidPaymentPercent = value; } }
        private Value<decimal?> _minimumPaymentAmount;
        public decimal? MinimumPaymentAmount { get { return _minimumPaymentAmount; } set { _minimumPaymentAmount = value; } }
        private Value<decimal?> _minimumPaymentLessThanAmount;
        public decimal? MinimumPaymentLessThanAmount { get { return _minimumPaymentLessThanAmount; } set { _minimumPaymentLessThanAmount = value; } }
        private Value<decimal?> _minimumPaymentPercent;
        public decimal? MinimumPaymentPercent { get { return _minimumPaymentPercent; } set { _minimumPaymentPercent = value; } }
        private Value<decimal?> _minimumPaymentUpbAmount;
        public decimal? MinimumPaymentUpbAmount { get { return _minimumPaymentUpbAmount; } set { _minimumPaymentUpbAmount = value; } }
        private Value<decimal?> _minimumPaymentUpbPercent;
        public decimal? MinimumPaymentUpbPercent { get { return _minimumPaymentUpbPercent; } set { _minimumPaymentUpbPercent = value; } }
        private Value<decimal?> _minimumRepayPeriodPaymentPercent;
        public decimal? MinimumRepayPeriodPaymentPercent { get { return _minimumRepayPeriodPaymentPercent; } set { _minimumRepayPeriodPaymentPercent = value; } }
        private Value<int?> _monthsAppliedToPrepaymentPenaltyFeeCount;
        public int? MonthsAppliedToPrepaymentPenaltyFeeCount { get { return _monthsAppliedToPrepaymentPenaltyFeeCount; } set { _monthsAppliedToPrepaymentPenaltyFeeCount = value; } }
        private Value<decimal?> _negativeAmortizationLimitPercent;
        public decimal? NegativeAmortizationLimitPercent { get { return _negativeAmortizationLimitPercent; } set { _negativeAmortizationLimitPercent = value; } }
        private Value<decimal?> _netInitialAndFinal;
        public decimal? NetInitialAndFinal { get { return _netInitialAndFinal; } set { _netInitialAndFinal = value; } }
        private Value<string> _nmlsDocumentationType;
        public string NmlsDocumentationType { get { return _nmlsDocumentationType; } set { _nmlsDocumentationType = value; } }
        private Value<string> _nmlsFirstMortgageType;
        public string NmlsFirstMortgageType { get { return _nmlsFirstMortgageType; } set { _nmlsFirstMortgageType = value; } }
        private Value<string> _nmlsLoanType;
        public string NmlsLoanType { get { return _nmlsLoanType; } set { _nmlsLoanType = value; } }
        private Value<bool?> _nmlsOptionARMIndicator;
        public bool? NmlsOptionARMIndicator { get { return _nmlsOptionARMIndicator; } set { _nmlsOptionARMIndicator = value; } }
        private Value<bool?> _nmlsPiggyBackOrFundedHELOCIndicator;
        public bool? NmlsPiggyBackOrFundedHELOCIndicator { get { return _nmlsPiggyBackOrFundedHELOCIndicator; } set { _nmlsPiggyBackOrFundedHELOCIndicator = value; } }
        private Value<string> _nmlsProductionSoldToType;
        public string NmlsProductionSoldToType { get { return _nmlsProductionSoldToType; } set { _nmlsProductionSoldToType = value; } }
        private Value<string> _nmlsRefinancePurposeType;
        public string NmlsRefinancePurposeType { get { return _nmlsRefinancePurposeType; } set { _nmlsRefinancePurposeType = value; } }
        private Value<string> _nmlsReverseMortgageType;
        public string NmlsReverseMortgageType { get { return _nmlsReverseMortgageType; } set { _nmlsReverseMortgageType = value; } }
        private Value<bool?> _oralRequestForExtensionOfCreditIndicator;
        public bool? OralRequestForExtensionOfCreditIndicator { get { return _oralRequestForExtensionOfCreditIndicator; } set { _oralRequestForExtensionOfCreditIndicator = value; } }
        private Value<decimal?> _overLimitCharge;
        public decimal? OverLimitCharge { get { return _overLimitCharge; } set { _overLimitCharge = value; } }
        private Value<decimal?> _overLimitReturnCharge;
        public decimal? OverLimitReturnCharge { get { return _overLimitReturnCharge; } set { _overLimitReturnCharge = value; } }
        private Value<decimal?> _participationFees;
        public decimal? ParticipationFees { get { return _participationFees; } set { _participationFees = value; } }
        private Value<int?> _paymentAdjustmentDurationMonthsCount;
        public int? PaymentAdjustmentDurationMonthsCount { get { return _paymentAdjustmentDurationMonthsCount; } set { _paymentAdjustmentDurationMonthsCount = value; } }
        private Value<decimal?> _paymentAdjustmentPeriodicCapPercent;
        public decimal? PaymentAdjustmentPeriodicCapPercent { get { return _paymentAdjustmentPeriodicCapPercent; } set { _paymentAdjustmentPeriodicCapPercent = value; } }
        private Value<string> _paymentFrequencyType;
        public string PaymentFrequencyType { get { return _paymentFrequencyType; } set { _paymentFrequencyType = value; } }
        private Value<List<PrepaymentPenalty>> _prepaymentPenalties;
        public List<PrepaymentPenalty> PrepaymentPenalties { get { return _prepaymentPenalties; } set { _prepaymentPenalties = value; } }
        private Value<string> _prepaymentPenaltyBasedOn;
        public string PrepaymentPenaltyBasedOn { get { return _prepaymentPenaltyBasedOn; } set { _prepaymentPenaltyBasedOn = value; } }
        private Value<bool?> _prepaymentPenaltyIndicator;
        public bool? PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        private Value<decimal?> _prepaymentPenaltyPercent;
        public decimal? PrepaymentPenaltyPercent { get { return _prepaymentPenaltyPercent; } set { _prepaymentPenaltyPercent = value; } }
        private Value<int?> _prepaymentPenaltyTermMonthsCount;
        public int? PrepaymentPenaltyTermMonthsCount { get { return _prepaymentPenaltyTermMonthsCount; } set { _prepaymentPenaltyTermMonthsCount = value; } }
        private Value<string> _prepaymentPenaltyVerbiage;
        public string PrepaymentPenaltyVerbiage { get { return _prepaymentPenaltyVerbiage; } set { _prepaymentPenaltyVerbiage = value; } }
        private Value<string> _productName;
        public string ProductName { get { return _productName; } set { _productName = value; } }
        private Value<decimal?> _qualifyingRatePercent;
        public decimal? QualifyingRatePercent { get { return _qualifyingRatePercent; } set { _qualifyingRatePercent = value; } }
        private Value<int?> _rateAdjustmentDurationMonthsCount;
        public int? RateAdjustmentDurationMonthsCount { get { return _rateAdjustmentDurationMonthsCount; } set { _rateAdjustmentDurationMonthsCount = value; } }
        private Value<decimal?> _rateAdjustmentLifetimeCapPercent;
        public decimal? RateAdjustmentLifetimeCapPercent { get { return _rateAdjustmentLifetimeCapPercent; } set { _rateAdjustmentLifetimeCapPercent = value; } }
        private Value<decimal?> _rateAdjustmentPercent;
        public decimal? RateAdjustmentPercent { get { return _rateAdjustmentPercent; } set { _rateAdjustmentPercent = value; } }
        private Value<decimal?> _rateAdjustmentSubsequentCapPercent;
        public decimal? RateAdjustmentSubsequentCapPercent { get { return _rateAdjustmentSubsequentCapPercent; } set { _rateAdjustmentSubsequentCapPercent = value; } }
        private Value<decimal?> _releaseRecoringCharge;
        public decimal? ReleaseRecoringCharge { get { return _releaseRecoringCharge; } set { _releaseRecoringCharge = value; } }
        private Value<decimal?> _remainingBuydownAmount;
        public decimal? RemainingBuydownAmount { get { return _remainingBuydownAmount; } set { _remainingBuydownAmount = value; } }
        private Value<int?> _repayPeriodMonthsCount;
        public int? RepayPeriodMonthsCount { get { return _repayPeriodMonthsCount; } set { _repayPeriodMonthsCount = value; } }
        private Value<decimal?> _returnedCheckCharge;
        public decimal? ReturnedCheckCharge { get { return _returnedCheckCharge; } set { _returnedCheckCharge = value; } }
        private Value<decimal?> _returnedCheckChargeRatePercent;
        public decimal? ReturnedCheckChargeRatePercent { get { return _returnedCheckChargeRatePercent; } set { _returnedCheckChargeRatePercent = value; } }
        private Value<decimal?> _returnedCheckMaxCharge;
        public decimal? ReturnedCheckMaxCharge { get { return _returnedCheckMaxCharge; } set { _returnedCheckMaxCharge = value; } }
        private Value<decimal?> _returnedCheckMinCharge;
        public decimal? ReturnedCheckMinCharge { get { return _returnedCheckMinCharge; } set { _returnedCheckMinCharge = value; } }
        private Value<decimal?> _roundPercent;
        public decimal? RoundPercent { get { return _roundPercent; } set { _roundPercent = value; } }
        private Value<string> _roundType;
        public string RoundType { get { return _roundType; } set { _roundType = value; } }
        private Value<DateTime?> _scheduledFirstPaymentAdjustmentDate;
        public DateTime? ScheduledFirstPaymentAdjustmentDate { get { return _scheduledFirstPaymentAdjustmentDate; } set { _scheduledFirstPaymentAdjustmentDate = value; } }
        private Value<DateTime?> _scheduledFirstPaymentDate;
        public DateTime? ScheduledFirstPaymentDate { get { return _scheduledFirstPaymentDate; } set { _scheduledFirstPaymentDate = value; } }
        private Value<decimal?> _stopPaymentCharge;
        public decimal? StopPaymentCharge { get { return _stopPaymentCharge; } set { _stopPaymentCharge = value; } }
        private Value<int?> _subsequentRateAdjustmentMonthsCount;
        public int? SubsequentRateAdjustmentMonthsCount { get { return _subsequentRateAdjustmentMonthsCount; } set { _subsequentRateAdjustmentMonthsCount = value; } }
        private Value<decimal?> _terminationFeeAmount;
        public decimal? TerminationFeeAmount { get { return _terminationFeeAmount; } set { _terminationFeeAmount = value; } }
        private Value<int?> _terminationPeriodMonthsCount;
        public int? TerminationPeriodMonthsCount { get { return _terminationPeriodMonthsCount; } set { _terminationPeriodMonthsCount = value; } }
        private Value<decimal?> _thirdPartyFeeFromAmount;
        public decimal? ThirdPartyFeeFromAmount { get { return _thirdPartyFeeFromAmount; } set { _thirdPartyFeeFromAmount = value; } }
        private Value<decimal?> _thirdPartyFeeToAmount;
        public decimal? ThirdPartyFeeToAmount { get { return _thirdPartyFeeToAmount; } set { _thirdPartyFeeToAmount = value; } }
        private Value<decimal?> _timelyPaymentRateReductionPercent;
        public decimal? TimelyPaymentRateReductionPercent { get { return _timelyPaymentRateReductionPercent; } set { _timelyPaymentRateReductionPercent = value; } }
        private Value<string> _timelyPaymentRewards;
        public string TimelyPaymentRewards { get { return _timelyPaymentRewards; } set { _timelyPaymentRewards = value; } }
        private Value<decimal?> _totalSubsidyAmount;
        public decimal? TotalSubsidyAmount { get { return _totalSubsidyAmount; } set { _totalSubsidyAmount = value; } }
        private Value<decimal?> _transactionFees;
        public decimal? TransactionFees { get { return _transactionFees; } set { _transactionFees = value; } }
        private Value<decimal?> _wireFee;
        public decimal? WireFee { get { return _wireFee; } set { _wireFee = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _annualFeeNeededAmount.Clean
                    && _applyLifeCapLowIndicator.Clean
                    && _armDisclosureType.Clean
                    && _armIndexType.Clean
                    && _balloonIndicator.Clean
                    && _balloonLoanMaturityTermMonthsCount.Clean
                    && _borrowerEstimatedClosingDate.Clean
                    && _branchLocationNmlsId.Clean
                    && _branchManagerNmlsId.Clean
                    && _buydowns.Clean
                    && _convertibleIndicator.Clean
                    && _discounted.Clean
                    && _discountedRate.Clean
                    && _drawPeriodMonthsCount.Clean
                    && _escrowWaiverIndicator.Clean
                    && _excludeLoanFromNMLSReportIndicator.Clean
                    && _floorBasis.Clean
                    && _floorPercent.Clean
                    && _floorVerbiage.Clean
                    && _fnmProductPlanIdentifier.Clean
                    && _freddieMacArmIndexType.Clean
                    && _freOfferingIdentifier.Clean
                    && _fullPrepaymentPenaltyOptionType.Clean
                    && _gseProjectClassificationType.Clean
                    && _gsePropertyType.Clean
                    && _hardPrepaymentPenaltyMonths.Clean
                    && _helocPeriodTemplateName.Clean
                    && _helocRepaymentDrawPeriods.Clean
                    && _id.Clean
                    && _indexCurrentValuePercent.Clean
                    && _indexLookbackPeriod.Clean
                    && _indexMarginPercent.Clean
                    && _initialAdvanceAmount.Clean
                    && _initialApplicationAmount.Clean
                    && _inquiryOrPreQualificationIndicator.Clean
                    && _lienPriorityType.Clean
                    && _loanDocumentationType.Clean
                    && _loanRepaymentType.Clean
                    && _loanScheduledClosingDate.Clean
                    && _maximumMonthlyPayment.Clean
                    && _maxLifeInterestCapPercent.Clean
                    && _miCoveragePercent.Clean
                    && _minimumAdvanceAmount.Clean
                    && _minimumAllowableApr.Clean
                    && _minimumDrawPeroidPaymentPercent.Clean
                    && _minimumPaymentAmount.Clean
                    && _minimumPaymentLessThanAmount.Clean
                    && _minimumPaymentPercent.Clean
                    && _minimumPaymentUpbAmount.Clean
                    && _minimumPaymentUpbPercent.Clean
                    && _minimumRepayPeriodPaymentPercent.Clean
                    && _monthsAppliedToPrepaymentPenaltyFeeCount.Clean
                    && _negativeAmortizationLimitPercent.Clean
                    && _netInitialAndFinal.Clean
                    && _nmlsDocumentationType.Clean
                    && _nmlsFirstMortgageType.Clean
                    && _nmlsLoanType.Clean
                    && _nmlsOptionARMIndicator.Clean
                    && _nmlsPiggyBackOrFundedHELOCIndicator.Clean
                    && _nmlsProductionSoldToType.Clean
                    && _nmlsRefinancePurposeType.Clean
                    && _nmlsReverseMortgageType.Clean
                    && _oralRequestForExtensionOfCreditIndicator.Clean
                    && _overLimitCharge.Clean
                    && _overLimitReturnCharge.Clean
                    && _participationFees.Clean
                    && _paymentAdjustmentDurationMonthsCount.Clean
                    && _paymentAdjustmentPeriodicCapPercent.Clean
                    && _paymentFrequencyType.Clean
                    && _prepaymentPenalties.Clean
                    && _prepaymentPenaltyBasedOn.Clean
                    && _prepaymentPenaltyIndicator.Clean
                    && _prepaymentPenaltyPercent.Clean
                    && _prepaymentPenaltyTermMonthsCount.Clean
                    && _prepaymentPenaltyVerbiage.Clean
                    && _productName.Clean
                    && _qualifyingRatePercent.Clean
                    && _rateAdjustmentDurationMonthsCount.Clean
                    && _rateAdjustmentLifetimeCapPercent.Clean
                    && _rateAdjustmentPercent.Clean
                    && _rateAdjustmentSubsequentCapPercent.Clean
                    && _releaseRecoringCharge.Clean
                    && _remainingBuydownAmount.Clean
                    && _repayPeriodMonthsCount.Clean
                    && _returnedCheckCharge.Clean
                    && _returnedCheckChargeRatePercent.Clean
                    && _returnedCheckMaxCharge.Clean
                    && _returnedCheckMinCharge.Clean
                    && _roundPercent.Clean
                    && _roundType.Clean
                    && _scheduledFirstPaymentAdjustmentDate.Clean
                    && _scheduledFirstPaymentDate.Clean
                    && _stopPaymentCharge.Clean
                    && _subsequentRateAdjustmentMonthsCount.Clean
                    && _terminationFeeAmount.Clean
                    && _terminationPeriodMonthsCount.Clean
                    && _thirdPartyFeeFromAmount.Clean
                    && _thirdPartyFeeToAmount.Clean
                    && _timelyPaymentRateReductionPercent.Clean
                    && _timelyPaymentRewards.Clean
                    && _totalSubsidyAmount.Clean
                    && _transactionFees.Clean
                    && _wireFee.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var annualFeeNeededAmount = _annualFeeNeededAmount; annualFeeNeededAmount.Clean = value; _annualFeeNeededAmount = annualFeeNeededAmount;
                var applyLifeCapLowIndicator = _applyLifeCapLowIndicator; applyLifeCapLowIndicator.Clean = value; _applyLifeCapLowIndicator = applyLifeCapLowIndicator;
                var armDisclosureType = _armDisclosureType; armDisclosureType.Clean = value; _armDisclosureType = armDisclosureType;
                var armIndexType = _armIndexType; armIndexType.Clean = value; _armIndexType = armIndexType;
                var balloonIndicator = _balloonIndicator; balloonIndicator.Clean = value; _balloonIndicator = balloonIndicator;
                var balloonLoanMaturityTermMonthsCount = _balloonLoanMaturityTermMonthsCount; balloonLoanMaturityTermMonthsCount.Clean = value; _balloonLoanMaturityTermMonthsCount = balloonLoanMaturityTermMonthsCount;
                var borrowerEstimatedClosingDate = _borrowerEstimatedClosingDate; borrowerEstimatedClosingDate.Clean = value; _borrowerEstimatedClosingDate = borrowerEstimatedClosingDate;
                var branchLocationNmlsId = _branchLocationNmlsId; branchLocationNmlsId.Clean = value; _branchLocationNmlsId = branchLocationNmlsId;
                var branchManagerNmlsId = _branchManagerNmlsId; branchManagerNmlsId.Clean = value; _branchManagerNmlsId = branchManagerNmlsId;
                var buydowns = _buydowns; buydowns.Clean = value; _buydowns = buydowns;
                var convertibleIndicator = _convertibleIndicator; convertibleIndicator.Clean = value; _convertibleIndicator = convertibleIndicator;
                var discounted = _discounted; discounted.Clean = value; _discounted = discounted;
                var discountedRate = _discountedRate; discountedRate.Clean = value; _discountedRate = discountedRate;
                var drawPeriodMonthsCount = _drawPeriodMonthsCount; drawPeriodMonthsCount.Clean = value; _drawPeriodMonthsCount = drawPeriodMonthsCount;
                var escrowWaiverIndicator = _escrowWaiverIndicator; escrowWaiverIndicator.Clean = value; _escrowWaiverIndicator = escrowWaiverIndicator;
                var excludeLoanFromNMLSReportIndicator = _excludeLoanFromNMLSReportIndicator; excludeLoanFromNMLSReportIndicator.Clean = value; _excludeLoanFromNMLSReportIndicator = excludeLoanFromNMLSReportIndicator;
                var floorBasis = _floorBasis; floorBasis.Clean = value; _floorBasis = floorBasis;
                var floorPercent = _floorPercent; floorPercent.Clean = value; _floorPercent = floorPercent;
                var floorVerbiage = _floorVerbiage; floorVerbiage.Clean = value; _floorVerbiage = floorVerbiage;
                var fnmProductPlanIdentifier = _fnmProductPlanIdentifier; fnmProductPlanIdentifier.Clean = value; _fnmProductPlanIdentifier = fnmProductPlanIdentifier;
                var freddieMacArmIndexType = _freddieMacArmIndexType; freddieMacArmIndexType.Clean = value; _freddieMacArmIndexType = freddieMacArmIndexType;
                var freOfferingIdentifier = _freOfferingIdentifier; freOfferingIdentifier.Clean = value; _freOfferingIdentifier = freOfferingIdentifier;
                var fullPrepaymentPenaltyOptionType = _fullPrepaymentPenaltyOptionType; fullPrepaymentPenaltyOptionType.Clean = value; _fullPrepaymentPenaltyOptionType = fullPrepaymentPenaltyOptionType;
                var gseProjectClassificationType = _gseProjectClassificationType; gseProjectClassificationType.Clean = value; _gseProjectClassificationType = gseProjectClassificationType;
                var gsePropertyType = _gsePropertyType; gsePropertyType.Clean = value; _gsePropertyType = gsePropertyType;
                var hardPrepaymentPenaltyMonths = _hardPrepaymentPenaltyMonths; hardPrepaymentPenaltyMonths.Clean = value; _hardPrepaymentPenaltyMonths = hardPrepaymentPenaltyMonths;
                var helocPeriodTemplateName = _helocPeriodTemplateName; helocPeriodTemplateName.Clean = value; _helocPeriodTemplateName = helocPeriodTemplateName;
                var helocRepaymentDrawPeriods = _helocRepaymentDrawPeriods; helocRepaymentDrawPeriods.Clean = value; _helocRepaymentDrawPeriods = helocRepaymentDrawPeriods;
                var id = _id; id.Clean = value; _id = id;
                var indexCurrentValuePercent = _indexCurrentValuePercent; indexCurrentValuePercent.Clean = value; _indexCurrentValuePercent = indexCurrentValuePercent;
                var indexLookbackPeriod = _indexLookbackPeriod; indexLookbackPeriod.Clean = value; _indexLookbackPeriod = indexLookbackPeriod;
                var indexMarginPercent = _indexMarginPercent; indexMarginPercent.Clean = value; _indexMarginPercent = indexMarginPercent;
                var initialAdvanceAmount = _initialAdvanceAmount; initialAdvanceAmount.Clean = value; _initialAdvanceAmount = initialAdvanceAmount;
                var initialApplicationAmount = _initialApplicationAmount; initialApplicationAmount.Clean = value; _initialApplicationAmount = initialApplicationAmount;
                var inquiryOrPreQualificationIndicator = _inquiryOrPreQualificationIndicator; inquiryOrPreQualificationIndicator.Clean = value; _inquiryOrPreQualificationIndicator = inquiryOrPreQualificationIndicator;
                var lienPriorityType = _lienPriorityType; lienPriorityType.Clean = value; _lienPriorityType = lienPriorityType;
                var loanDocumentationType = _loanDocumentationType; loanDocumentationType.Clean = value; _loanDocumentationType = loanDocumentationType;
                var loanRepaymentType = _loanRepaymentType; loanRepaymentType.Clean = value; _loanRepaymentType = loanRepaymentType;
                var loanScheduledClosingDate = _loanScheduledClosingDate; loanScheduledClosingDate.Clean = value; _loanScheduledClosingDate = loanScheduledClosingDate;
                var maximumMonthlyPayment = _maximumMonthlyPayment; maximumMonthlyPayment.Clean = value; _maximumMonthlyPayment = maximumMonthlyPayment;
                var maxLifeInterestCapPercent = _maxLifeInterestCapPercent; maxLifeInterestCapPercent.Clean = value; _maxLifeInterestCapPercent = maxLifeInterestCapPercent;
                var miCoveragePercent = _miCoveragePercent; miCoveragePercent.Clean = value; _miCoveragePercent = miCoveragePercent;
                var minimumAdvanceAmount = _minimumAdvanceAmount; minimumAdvanceAmount.Clean = value; _minimumAdvanceAmount = minimumAdvanceAmount;
                var minimumAllowableApr = _minimumAllowableApr; minimumAllowableApr.Clean = value; _minimumAllowableApr = minimumAllowableApr;
                var minimumDrawPeroidPaymentPercent = _minimumDrawPeroidPaymentPercent; minimumDrawPeroidPaymentPercent.Clean = value; _minimumDrawPeroidPaymentPercent = minimumDrawPeroidPaymentPercent;
                var minimumPaymentAmount = _minimumPaymentAmount; minimumPaymentAmount.Clean = value; _minimumPaymentAmount = minimumPaymentAmount;
                var minimumPaymentLessThanAmount = _minimumPaymentLessThanAmount; minimumPaymentLessThanAmount.Clean = value; _minimumPaymentLessThanAmount = minimumPaymentLessThanAmount;
                var minimumPaymentPercent = _minimumPaymentPercent; minimumPaymentPercent.Clean = value; _minimumPaymentPercent = minimumPaymentPercent;
                var minimumPaymentUpbAmount = _minimumPaymentUpbAmount; minimumPaymentUpbAmount.Clean = value; _minimumPaymentUpbAmount = minimumPaymentUpbAmount;
                var minimumPaymentUpbPercent = _minimumPaymentUpbPercent; minimumPaymentUpbPercent.Clean = value; _minimumPaymentUpbPercent = minimumPaymentUpbPercent;
                var minimumRepayPeriodPaymentPercent = _minimumRepayPeriodPaymentPercent; minimumRepayPeriodPaymentPercent.Clean = value; _minimumRepayPeriodPaymentPercent = minimumRepayPeriodPaymentPercent;
                var monthsAppliedToPrepaymentPenaltyFeeCount = _monthsAppliedToPrepaymentPenaltyFeeCount; monthsAppliedToPrepaymentPenaltyFeeCount.Clean = value; _monthsAppliedToPrepaymentPenaltyFeeCount = monthsAppliedToPrepaymentPenaltyFeeCount;
                var negativeAmortizationLimitPercent = _negativeAmortizationLimitPercent; negativeAmortizationLimitPercent.Clean = value; _negativeAmortizationLimitPercent = negativeAmortizationLimitPercent;
                var netInitialAndFinal = _netInitialAndFinal; netInitialAndFinal.Clean = value; _netInitialAndFinal = netInitialAndFinal;
                var nmlsDocumentationType = _nmlsDocumentationType; nmlsDocumentationType.Clean = value; _nmlsDocumentationType = nmlsDocumentationType;
                var nmlsFirstMortgageType = _nmlsFirstMortgageType; nmlsFirstMortgageType.Clean = value; _nmlsFirstMortgageType = nmlsFirstMortgageType;
                var nmlsLoanType = _nmlsLoanType; nmlsLoanType.Clean = value; _nmlsLoanType = nmlsLoanType;
                var nmlsOptionARMIndicator = _nmlsOptionARMIndicator; nmlsOptionARMIndicator.Clean = value; _nmlsOptionARMIndicator = nmlsOptionARMIndicator;
                var nmlsPiggyBackOrFundedHELOCIndicator = _nmlsPiggyBackOrFundedHELOCIndicator; nmlsPiggyBackOrFundedHELOCIndicator.Clean = value; _nmlsPiggyBackOrFundedHELOCIndicator = nmlsPiggyBackOrFundedHELOCIndicator;
                var nmlsProductionSoldToType = _nmlsProductionSoldToType; nmlsProductionSoldToType.Clean = value; _nmlsProductionSoldToType = nmlsProductionSoldToType;
                var nmlsRefinancePurposeType = _nmlsRefinancePurposeType; nmlsRefinancePurposeType.Clean = value; _nmlsRefinancePurposeType = nmlsRefinancePurposeType;
                var nmlsReverseMortgageType = _nmlsReverseMortgageType; nmlsReverseMortgageType.Clean = value; _nmlsReverseMortgageType = nmlsReverseMortgageType;
                var oralRequestForExtensionOfCreditIndicator = _oralRequestForExtensionOfCreditIndicator; oralRequestForExtensionOfCreditIndicator.Clean = value; _oralRequestForExtensionOfCreditIndicator = oralRequestForExtensionOfCreditIndicator;
                var overLimitCharge = _overLimitCharge; overLimitCharge.Clean = value; _overLimitCharge = overLimitCharge;
                var overLimitReturnCharge = _overLimitReturnCharge; overLimitReturnCharge.Clean = value; _overLimitReturnCharge = overLimitReturnCharge;
                var participationFees = _participationFees; participationFees.Clean = value; _participationFees = participationFees;
                var paymentAdjustmentDurationMonthsCount = _paymentAdjustmentDurationMonthsCount; paymentAdjustmentDurationMonthsCount.Clean = value; _paymentAdjustmentDurationMonthsCount = paymentAdjustmentDurationMonthsCount;
                var paymentAdjustmentPeriodicCapPercent = _paymentAdjustmentPeriodicCapPercent; paymentAdjustmentPeriodicCapPercent.Clean = value; _paymentAdjustmentPeriodicCapPercent = paymentAdjustmentPeriodicCapPercent;
                var paymentFrequencyType = _paymentFrequencyType; paymentFrequencyType.Clean = value; _paymentFrequencyType = paymentFrequencyType;
                var prepaymentPenalties = _prepaymentPenalties; prepaymentPenalties.Clean = value; _prepaymentPenalties = prepaymentPenalties;
                var prepaymentPenaltyBasedOn = _prepaymentPenaltyBasedOn; prepaymentPenaltyBasedOn.Clean = value; _prepaymentPenaltyBasedOn = prepaymentPenaltyBasedOn;
                var prepaymentPenaltyIndicator = _prepaymentPenaltyIndicator; prepaymentPenaltyIndicator.Clean = value; _prepaymentPenaltyIndicator = prepaymentPenaltyIndicator;
                var prepaymentPenaltyPercent = _prepaymentPenaltyPercent; prepaymentPenaltyPercent.Clean = value; _prepaymentPenaltyPercent = prepaymentPenaltyPercent;
                var prepaymentPenaltyTermMonthsCount = _prepaymentPenaltyTermMonthsCount; prepaymentPenaltyTermMonthsCount.Clean = value; _prepaymentPenaltyTermMonthsCount = prepaymentPenaltyTermMonthsCount;
                var prepaymentPenaltyVerbiage = _prepaymentPenaltyVerbiage; prepaymentPenaltyVerbiage.Clean = value; _prepaymentPenaltyVerbiage = prepaymentPenaltyVerbiage;
                var productName = _productName; productName.Clean = value; _productName = productName;
                var qualifyingRatePercent = _qualifyingRatePercent; qualifyingRatePercent.Clean = value; _qualifyingRatePercent = qualifyingRatePercent;
                var rateAdjustmentDurationMonthsCount = _rateAdjustmentDurationMonthsCount; rateAdjustmentDurationMonthsCount.Clean = value; _rateAdjustmentDurationMonthsCount = rateAdjustmentDurationMonthsCount;
                var rateAdjustmentLifetimeCapPercent = _rateAdjustmentLifetimeCapPercent; rateAdjustmentLifetimeCapPercent.Clean = value; _rateAdjustmentLifetimeCapPercent = rateAdjustmentLifetimeCapPercent;
                var rateAdjustmentPercent = _rateAdjustmentPercent; rateAdjustmentPercent.Clean = value; _rateAdjustmentPercent = rateAdjustmentPercent;
                var rateAdjustmentSubsequentCapPercent = _rateAdjustmentSubsequentCapPercent; rateAdjustmentSubsequentCapPercent.Clean = value; _rateAdjustmentSubsequentCapPercent = rateAdjustmentSubsequentCapPercent;
                var releaseRecoringCharge = _releaseRecoringCharge; releaseRecoringCharge.Clean = value; _releaseRecoringCharge = releaseRecoringCharge;
                var remainingBuydownAmount = _remainingBuydownAmount; remainingBuydownAmount.Clean = value; _remainingBuydownAmount = remainingBuydownAmount;
                var repayPeriodMonthsCount = _repayPeriodMonthsCount; repayPeriodMonthsCount.Clean = value; _repayPeriodMonthsCount = repayPeriodMonthsCount;
                var returnedCheckCharge = _returnedCheckCharge; returnedCheckCharge.Clean = value; _returnedCheckCharge = returnedCheckCharge;
                var returnedCheckChargeRatePercent = _returnedCheckChargeRatePercent; returnedCheckChargeRatePercent.Clean = value; _returnedCheckChargeRatePercent = returnedCheckChargeRatePercent;
                var returnedCheckMaxCharge = _returnedCheckMaxCharge; returnedCheckMaxCharge.Clean = value; _returnedCheckMaxCharge = returnedCheckMaxCharge;
                var returnedCheckMinCharge = _returnedCheckMinCharge; returnedCheckMinCharge.Clean = value; _returnedCheckMinCharge = returnedCheckMinCharge;
                var roundPercent = _roundPercent; roundPercent.Clean = value; _roundPercent = roundPercent;
                var roundType = _roundType; roundType.Clean = value; _roundType = roundType;
                var scheduledFirstPaymentAdjustmentDate = _scheduledFirstPaymentAdjustmentDate; scheduledFirstPaymentAdjustmentDate.Clean = value; _scheduledFirstPaymentAdjustmentDate = scheduledFirstPaymentAdjustmentDate;
                var scheduledFirstPaymentDate = _scheduledFirstPaymentDate; scheduledFirstPaymentDate.Clean = value; _scheduledFirstPaymentDate = scheduledFirstPaymentDate;
                var stopPaymentCharge = _stopPaymentCharge; stopPaymentCharge.Clean = value; _stopPaymentCharge = stopPaymentCharge;
                var subsequentRateAdjustmentMonthsCount = _subsequentRateAdjustmentMonthsCount; subsequentRateAdjustmentMonthsCount.Clean = value; _subsequentRateAdjustmentMonthsCount = subsequentRateAdjustmentMonthsCount;
                var terminationFeeAmount = _terminationFeeAmount; terminationFeeAmount.Clean = value; _terminationFeeAmount = terminationFeeAmount;
                var terminationPeriodMonthsCount = _terminationPeriodMonthsCount; terminationPeriodMonthsCount.Clean = value; _terminationPeriodMonthsCount = terminationPeriodMonthsCount;
                var thirdPartyFeeFromAmount = _thirdPartyFeeFromAmount; thirdPartyFeeFromAmount.Clean = value; _thirdPartyFeeFromAmount = thirdPartyFeeFromAmount;
                var thirdPartyFeeToAmount = _thirdPartyFeeToAmount; thirdPartyFeeToAmount.Clean = value; _thirdPartyFeeToAmount = thirdPartyFeeToAmount;
                var timelyPaymentRateReductionPercent = _timelyPaymentRateReductionPercent; timelyPaymentRateReductionPercent.Clean = value; _timelyPaymentRateReductionPercent = timelyPaymentRateReductionPercent;
                var timelyPaymentRewards = _timelyPaymentRewards; timelyPaymentRewards.Clean = value; _timelyPaymentRewards = timelyPaymentRewards;
                var totalSubsidyAmount = _totalSubsidyAmount; totalSubsidyAmount.Clean = value; _totalSubsidyAmount = totalSubsidyAmount;
                var transactionFees = _transactionFees; transactionFees.Clean = value; _transactionFees = transactionFees;
                var wireFee = _wireFee; wireFee.Clean = value; _wireFee = wireFee;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanProductData()
        {
            Clean = true;
        }
    }
}