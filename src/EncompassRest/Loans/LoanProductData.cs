using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanProductData : IDirty
    {
        private DirtyValue<decimal?> _annualFeeNeededAmount;
        public decimal? AnnualFeeNeededAmount { get { return _annualFeeNeededAmount; } set { _annualFeeNeededAmount = value; } }
        private DirtyValue<bool?> _applyLifeCapLowIndicator;
        public bool? ApplyLifeCapLowIndicator { get { return _applyLifeCapLowIndicator; } set { _applyLifeCapLowIndicator = value; } }
        private DirtyValue<string> _armDisclosureType;
        public string ArmDisclosureType { get { return _armDisclosureType; } set { _armDisclosureType = value; } }
        private DirtyValue<string> _armIndexType;
        public string ArmIndexType { get { return _armIndexType; } set { _armIndexType = value; } }
        private DirtyValue<bool?> _balloonIndicator;
        public bool? BalloonIndicator { get { return _balloonIndicator; } set { _balloonIndicator = value; } }
        private DirtyValue<int?> _balloonLoanMaturityTermMonthsCount;
        public int? BalloonLoanMaturityTermMonthsCount { get { return _balloonLoanMaturityTermMonthsCount; } set { _balloonLoanMaturityTermMonthsCount = value; } }
        private DirtyValue<DateTime?> _borrowerEstimatedClosingDate;
        public DateTime? BorrowerEstimatedClosingDate { get { return _borrowerEstimatedClosingDate; } set { _borrowerEstimatedClosingDate = value; } }
        private DirtyValue<string> _branchLocationNmlsId;
        public string BranchLocationNmlsId { get { return _branchLocationNmlsId; } set { _branchLocationNmlsId = value; } }
        private DirtyValue<string> _branchManagerNmlsId;
        public string BranchManagerNmlsId { get { return _branchManagerNmlsId; } set { _branchManagerNmlsId = value; } }
        private DirtyList<Buydown> _buydowns;
        public IList<Buydown> Buydowns { get { return _buydowns ?? (_buydowns = new DirtyList<Buydown>()); } set { _buydowns = new DirtyList<Buydown>(value); } }
        private DirtyValue<bool?> _convertibleIndicator;
        public bool? ConvertibleIndicator { get { return _convertibleIndicator; } set { _convertibleIndicator = value; } }
        private DirtyValue<string> _discounted;
        public string Discounted { get { return _discounted; } set { _discounted = value; } }
        private DirtyValue<decimal?> _discountedRate;
        public decimal? DiscountedRate { get { return _discountedRate; } set { _discountedRate = value; } }
        private DirtyValue<int?> _drawPeriodMonthsCount;
        public int? DrawPeriodMonthsCount { get { return _drawPeriodMonthsCount; } set { _drawPeriodMonthsCount = value; } }
        private DirtyValue<bool?> _escrowWaiverIndicator;
        public bool? EscrowWaiverIndicator { get { return _escrowWaiverIndicator; } set { _escrowWaiverIndicator = value; } }
        private DirtyValue<bool?> _excludeLoanFromNMLSReportIndicator;
        public bool? ExcludeLoanFromNMLSReportIndicator { get { return _excludeLoanFromNMLSReportIndicator; } set { _excludeLoanFromNMLSReportIndicator = value; } }
        private DirtyValue<string> _floorBasis;
        public string FloorBasis { get { return _floorBasis; } set { _floorBasis = value; } }
        private DirtyValue<decimal?> _floorPercent;
        public decimal? FloorPercent { get { return _floorPercent; } set { _floorPercent = value; } }
        private DirtyValue<string> _floorVerbiage;
        public string FloorVerbiage { get { return _floorVerbiage; } set { _floorVerbiage = value; } }
        private DirtyValue<string> _fnmProductPlanIdentifier;
        public string FnmProductPlanIdentifier { get { return _fnmProductPlanIdentifier; } set { _fnmProductPlanIdentifier = value; } }
        private DirtyValue<string> _freddieMacArmIndexType;
        public string FreddieMacArmIndexType { get { return _freddieMacArmIndexType; } set { _freddieMacArmIndexType = value; } }
        private DirtyValue<string> _freOfferingIdentifier;
        public string FreOfferingIdentifier { get { return _freOfferingIdentifier; } set { _freOfferingIdentifier = value; } }
        private DirtyValue<string> _fullPrepaymentPenaltyOptionType;
        public string FullPrepaymentPenaltyOptionType { get { return _fullPrepaymentPenaltyOptionType; } set { _fullPrepaymentPenaltyOptionType = value; } }
        private DirtyValue<string> _gseProjectClassificationType;
        public string GseProjectClassificationType { get { return _gseProjectClassificationType; } set { _gseProjectClassificationType = value; } }
        private DirtyValue<string> _gsePropertyType;
        public string GsePropertyType { get { return _gsePropertyType; } set { _gsePropertyType = value; } }
        private DirtyValue<int?> _hardPrepaymentPenaltyMonths;
        public int? HardPrepaymentPenaltyMonths { get { return _hardPrepaymentPenaltyMonths; } set { _hardPrepaymentPenaltyMonths = value; } }
        private DirtyValue<string> _helocPeriodTemplateName;
        public string HelocPeriodTemplateName { get { return _helocPeriodTemplateName; } set { _helocPeriodTemplateName = value; } }
        private DirtyList<HelocRepaymentDrawPeriod> _helocRepaymentDrawPeriods;
        public IList<HelocRepaymentDrawPeriod> HelocRepaymentDrawPeriods { get { return _helocRepaymentDrawPeriods ?? (_helocRepaymentDrawPeriods = new DirtyList<HelocRepaymentDrawPeriod>()); } set { _helocRepaymentDrawPeriods = new DirtyList<HelocRepaymentDrawPeriod>(value); } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _indexCurrentValuePercent;
        public decimal? IndexCurrentValuePercent { get { return _indexCurrentValuePercent; } set { _indexCurrentValuePercent = value; } }
        private DirtyValue<string> _indexLookbackPeriod;
        public string IndexLookbackPeriod { get { return _indexLookbackPeriod; } set { _indexLookbackPeriod = value; } }
        private DirtyValue<decimal?> _indexMarginPercent;
        public decimal? IndexMarginPercent { get { return _indexMarginPercent; } set { _indexMarginPercent = value; } }
        private DirtyValue<decimal?> _initialAdvanceAmount;
        public decimal? InitialAdvanceAmount { get { return _initialAdvanceAmount; } set { _initialAdvanceAmount = value; } }
        private DirtyValue<decimal?> _initialApplicationAmount;
        public decimal? InitialApplicationAmount { get { return _initialApplicationAmount; } set { _initialApplicationAmount = value; } }
        private DirtyValue<bool?> _inquiryOrPreQualificationIndicator;
        public bool? InquiryOrPreQualificationIndicator { get { return _inquiryOrPreQualificationIndicator; } set { _inquiryOrPreQualificationIndicator = value; } }
        private DirtyValue<string> _lienPriorityType;
        public string LienPriorityType { get { return _lienPriorityType; } set { _lienPriorityType = value; } }
        private DirtyValue<string> _loanDocumentationType;
        public string LoanDocumentationType { get { return _loanDocumentationType; } set { _loanDocumentationType = value; } }
        private DirtyValue<string> _loanRepaymentType;
        public string LoanRepaymentType { get { return _loanRepaymentType; } set { _loanRepaymentType = value; } }
        private DirtyValue<DateTime?> _loanScheduledClosingDate;
        public DateTime? LoanScheduledClosingDate { get { return _loanScheduledClosingDate; } set { _loanScheduledClosingDate = value; } }
        private DirtyValue<decimal?> _maximumMonthlyPayment;
        public decimal? MaximumMonthlyPayment { get { return _maximumMonthlyPayment; } set { _maximumMonthlyPayment = value; } }
        private DirtyValue<decimal?> _maxLifeInterestCapPercent;
        public decimal? MaxLifeInterestCapPercent { get { return _maxLifeInterestCapPercent; } set { _maxLifeInterestCapPercent = value; } }
        private DirtyValue<decimal?> _miCoveragePercent;
        public decimal? MiCoveragePercent { get { return _miCoveragePercent; } set { _miCoveragePercent = value; } }
        private DirtyValue<decimal?> _minimumAdvanceAmount;
        public decimal? MinimumAdvanceAmount { get { return _minimumAdvanceAmount; } set { _minimumAdvanceAmount = value; } }
        private DirtyValue<decimal?> _minimumAllowableApr;
        public decimal? MinimumAllowableApr { get { return _minimumAllowableApr; } set { _minimumAllowableApr = value; } }
        private DirtyValue<decimal?> _minimumDrawPeroidPaymentPercent;
        public decimal? MinimumDrawPeroidPaymentPercent { get { return _minimumDrawPeroidPaymentPercent; } set { _minimumDrawPeroidPaymentPercent = value; } }
        private DirtyValue<decimal?> _minimumPaymentAmount;
        public decimal? MinimumPaymentAmount { get { return _minimumPaymentAmount; } set { _minimumPaymentAmount = value; } }
        private DirtyValue<decimal?> _minimumPaymentLessThanAmount;
        public decimal? MinimumPaymentLessThanAmount { get { return _minimumPaymentLessThanAmount; } set { _minimumPaymentLessThanAmount = value; } }
        private DirtyValue<decimal?> _minimumPaymentPercent;
        public decimal? MinimumPaymentPercent { get { return _minimumPaymentPercent; } set { _minimumPaymentPercent = value; } }
        private DirtyValue<decimal?> _minimumPaymentUpbAmount;
        public decimal? MinimumPaymentUpbAmount { get { return _minimumPaymentUpbAmount; } set { _minimumPaymentUpbAmount = value; } }
        private DirtyValue<decimal?> _minimumPaymentUpbPercent;
        public decimal? MinimumPaymentUpbPercent { get { return _minimumPaymentUpbPercent; } set { _minimumPaymentUpbPercent = value; } }
        private DirtyValue<decimal?> _minimumRepayPeriodPaymentPercent;
        public decimal? MinimumRepayPeriodPaymentPercent { get { return _minimumRepayPeriodPaymentPercent; } set { _minimumRepayPeriodPaymentPercent = value; } }
        private DirtyValue<int?> _monthsAppliedToPrepaymentPenaltyFeeCount;
        public int? MonthsAppliedToPrepaymentPenaltyFeeCount { get { return _monthsAppliedToPrepaymentPenaltyFeeCount; } set { _monthsAppliedToPrepaymentPenaltyFeeCount = value; } }
        private DirtyValue<decimal?> _negativeAmortizationLimitPercent;
        public decimal? NegativeAmortizationLimitPercent { get { return _negativeAmortizationLimitPercent; } set { _negativeAmortizationLimitPercent = value; } }
        private DirtyValue<decimal?> _netInitialAndFinal;
        public decimal? NetInitialAndFinal { get { return _netInitialAndFinal; } set { _netInitialAndFinal = value; } }
        private DirtyValue<string> _nmlsDocumentationType;
        public string NmlsDocumentationType { get { return _nmlsDocumentationType; } set { _nmlsDocumentationType = value; } }
        private DirtyValue<string> _nmlsFirstMortgageType;
        public string NmlsFirstMortgageType { get { return _nmlsFirstMortgageType; } set { _nmlsFirstMortgageType = value; } }
        private DirtyValue<string> _nmlsLoanType;
        public string NmlsLoanType { get { return _nmlsLoanType; } set { _nmlsLoanType = value; } }
        private DirtyValue<bool?> _nmlsOptionARMIndicator;
        public bool? NmlsOptionARMIndicator { get { return _nmlsOptionARMIndicator; } set { _nmlsOptionARMIndicator = value; } }
        private DirtyValue<bool?> _nmlsPiggyBackOrFundedHELOCIndicator;
        public bool? NmlsPiggyBackOrFundedHELOCIndicator { get { return _nmlsPiggyBackOrFundedHELOCIndicator; } set { _nmlsPiggyBackOrFundedHELOCIndicator = value; } }
        private DirtyValue<string> _nmlsProductionSoldToType;
        public string NmlsProductionSoldToType { get { return _nmlsProductionSoldToType; } set { _nmlsProductionSoldToType = value; } }
        private DirtyValue<string> _nmlsRefinancePurposeType;
        public string NmlsRefinancePurposeType { get { return _nmlsRefinancePurposeType; } set { _nmlsRefinancePurposeType = value; } }
        private DirtyValue<string> _nmlsReverseMortgageType;
        public string NmlsReverseMortgageType { get { return _nmlsReverseMortgageType; } set { _nmlsReverseMortgageType = value; } }
        private DirtyValue<bool?> _oralRequestForExtensionOfCreditIndicator;
        public bool? OralRequestForExtensionOfCreditIndicator { get { return _oralRequestForExtensionOfCreditIndicator; } set { _oralRequestForExtensionOfCreditIndicator = value; } }
        private DirtyValue<decimal?> _overLimitCharge;
        public decimal? OverLimitCharge { get { return _overLimitCharge; } set { _overLimitCharge = value; } }
        private DirtyValue<decimal?> _overLimitReturnCharge;
        public decimal? OverLimitReturnCharge { get { return _overLimitReturnCharge; } set { _overLimitReturnCharge = value; } }
        private DirtyValue<decimal?> _participationFees;
        public decimal? ParticipationFees { get { return _participationFees; } set { _participationFees = value; } }
        private DirtyValue<int?> _paymentAdjustmentDurationMonthsCount;
        public int? PaymentAdjustmentDurationMonthsCount { get { return _paymentAdjustmentDurationMonthsCount; } set { _paymentAdjustmentDurationMonthsCount = value; } }
        private DirtyValue<decimal?> _paymentAdjustmentPeriodicCapPercent;
        public decimal? PaymentAdjustmentPeriodicCapPercent { get { return _paymentAdjustmentPeriodicCapPercent; } set { _paymentAdjustmentPeriodicCapPercent = value; } }
        private DirtyValue<string> _paymentFrequencyType;
        public string PaymentFrequencyType { get { return _paymentFrequencyType; } set { _paymentFrequencyType = value; } }
        private DirtyList<PrepaymentPenalty> _prepaymentPenalties;
        public IList<PrepaymentPenalty> PrepaymentPenalties { get { return _prepaymentPenalties ?? (_prepaymentPenalties = new DirtyList<PrepaymentPenalty>()); } set { _prepaymentPenalties = new DirtyList<PrepaymentPenalty>(value); } }
        private DirtyValue<string> _prepaymentPenaltyBasedOn;
        public string PrepaymentPenaltyBasedOn { get { return _prepaymentPenaltyBasedOn; } set { _prepaymentPenaltyBasedOn = value; } }
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        public bool? PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        public decimal? PrepaymentPenaltyPercent { get { return _prepaymentPenaltyPercent; } set { _prepaymentPenaltyPercent = value; } }
        private DirtyValue<int?> _prepaymentPenaltyTermMonthsCount;
        public int? PrepaymentPenaltyTermMonthsCount { get { return _prepaymentPenaltyTermMonthsCount; } set { _prepaymentPenaltyTermMonthsCount = value; } }
        private DirtyValue<string> _prepaymentPenaltyVerbiage;
        public string PrepaymentPenaltyVerbiage { get { return _prepaymentPenaltyVerbiage; } set { _prepaymentPenaltyVerbiage = value; } }
        private DirtyValue<string> _productName;
        public string ProductName { get { return _productName; } set { _productName = value; } }
        private DirtyValue<decimal?> _qualifyingRatePercent;
        public decimal? QualifyingRatePercent { get { return _qualifyingRatePercent; } set { _qualifyingRatePercent = value; } }
        private DirtyValue<int?> _rateAdjustmentDurationMonthsCount;
        public int? RateAdjustmentDurationMonthsCount { get { return _rateAdjustmentDurationMonthsCount; } set { _rateAdjustmentDurationMonthsCount = value; } }
        private DirtyValue<decimal?> _rateAdjustmentLifetimeCapPercent;
        public decimal? RateAdjustmentLifetimeCapPercent { get { return _rateAdjustmentLifetimeCapPercent; } set { _rateAdjustmentLifetimeCapPercent = value; } }
        private DirtyValue<decimal?> _rateAdjustmentPercent;
        public decimal? RateAdjustmentPercent { get { return _rateAdjustmentPercent; } set { _rateAdjustmentPercent = value; } }
        private DirtyValue<decimal?> _rateAdjustmentSubsequentCapPercent;
        public decimal? RateAdjustmentSubsequentCapPercent { get { return _rateAdjustmentSubsequentCapPercent; } set { _rateAdjustmentSubsequentCapPercent = value; } }
        private DirtyValue<decimal?> _releaseRecoringCharge;
        public decimal? ReleaseRecoringCharge { get { return _releaseRecoringCharge; } set { _releaseRecoringCharge = value; } }
        private DirtyValue<decimal?> _remainingBuydownAmount;
        public decimal? RemainingBuydownAmount { get { return _remainingBuydownAmount; } set { _remainingBuydownAmount = value; } }
        private DirtyValue<int?> _repayPeriodMonthsCount;
        public int? RepayPeriodMonthsCount { get { return _repayPeriodMonthsCount; } set { _repayPeriodMonthsCount = value; } }
        private DirtyValue<decimal?> _returnedCheckCharge;
        public decimal? ReturnedCheckCharge { get { return _returnedCheckCharge; } set { _returnedCheckCharge = value; } }
        private DirtyValue<decimal?> _returnedCheckChargeRatePercent;
        public decimal? ReturnedCheckChargeRatePercent { get { return _returnedCheckChargeRatePercent; } set { _returnedCheckChargeRatePercent = value; } }
        private DirtyValue<decimal?> _returnedCheckMaxCharge;
        public decimal? ReturnedCheckMaxCharge { get { return _returnedCheckMaxCharge; } set { _returnedCheckMaxCharge = value; } }
        private DirtyValue<decimal?> _returnedCheckMinCharge;
        public decimal? ReturnedCheckMinCharge { get { return _returnedCheckMinCharge; } set { _returnedCheckMinCharge = value; } }
        private DirtyValue<decimal?> _roundPercent;
        public decimal? RoundPercent { get { return _roundPercent; } set { _roundPercent = value; } }
        private DirtyValue<string> _roundType;
        public string RoundType { get { return _roundType; } set { _roundType = value; } }
        private DirtyValue<DateTime?> _scheduledFirstPaymentAdjustmentDate;
        public DateTime? ScheduledFirstPaymentAdjustmentDate { get { return _scheduledFirstPaymentAdjustmentDate; } set { _scheduledFirstPaymentAdjustmentDate = value; } }
        private DirtyValue<DateTime?> _scheduledFirstPaymentDate;
        public DateTime? ScheduledFirstPaymentDate { get { return _scheduledFirstPaymentDate; } set { _scheduledFirstPaymentDate = value; } }
        private DirtyValue<decimal?> _stopPaymentCharge;
        public decimal? StopPaymentCharge { get { return _stopPaymentCharge; } set { _stopPaymentCharge = value; } }
        private DirtyValue<int?> _subsequentRateAdjustmentMonthsCount;
        public int? SubsequentRateAdjustmentMonthsCount { get { return _subsequentRateAdjustmentMonthsCount; } set { _subsequentRateAdjustmentMonthsCount = value; } }
        private DirtyValue<decimal?> _terminationFeeAmount;
        public decimal? TerminationFeeAmount { get { return _terminationFeeAmount; } set { _terminationFeeAmount = value; } }
        private DirtyValue<int?> _terminationPeriodMonthsCount;
        public int? TerminationPeriodMonthsCount { get { return _terminationPeriodMonthsCount; } set { _terminationPeriodMonthsCount = value; } }
        private DirtyValue<decimal?> _thirdPartyFeeFromAmount;
        public decimal? ThirdPartyFeeFromAmount { get { return _thirdPartyFeeFromAmount; } set { _thirdPartyFeeFromAmount = value; } }
        private DirtyValue<decimal?> _thirdPartyFeeToAmount;
        public decimal? ThirdPartyFeeToAmount { get { return _thirdPartyFeeToAmount; } set { _thirdPartyFeeToAmount = value; } }
        private DirtyValue<decimal?> _timelyPaymentRateReductionPercent;
        public decimal? TimelyPaymentRateReductionPercent { get { return _timelyPaymentRateReductionPercent; } set { _timelyPaymentRateReductionPercent = value; } }
        private DirtyValue<string> _timelyPaymentRewards;
        public string TimelyPaymentRewards { get { return _timelyPaymentRewards; } set { _timelyPaymentRewards = value; } }
        private DirtyValue<decimal?> _totalSubsidyAmount;
        public decimal? TotalSubsidyAmount { get { return _totalSubsidyAmount; } set { _totalSubsidyAmount = value; } }
        private DirtyValue<decimal?> _transactionFees;
        public decimal? TransactionFees { get { return _transactionFees; } set { _transactionFees = value; } }
        private DirtyValue<decimal?> _wireFee;
        public decimal? WireFee { get { return _wireFee; } set { _wireFee = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _annualFeeNeededAmount.Dirty
                    || _applyLifeCapLowIndicator.Dirty
                    || _armDisclosureType.Dirty
                    || _armIndexType.Dirty
                    || _balloonIndicator.Dirty
                    || _balloonLoanMaturityTermMonthsCount.Dirty
                    || _borrowerEstimatedClosingDate.Dirty
                    || _branchLocationNmlsId.Dirty
                    || _branchManagerNmlsId.Dirty
                    || _convertibleIndicator.Dirty
                    || _discounted.Dirty
                    || _discountedRate.Dirty
                    || _drawPeriodMonthsCount.Dirty
                    || _escrowWaiverIndicator.Dirty
                    || _excludeLoanFromNMLSReportIndicator.Dirty
                    || _floorBasis.Dirty
                    || _floorPercent.Dirty
                    || _floorVerbiage.Dirty
                    || _fnmProductPlanIdentifier.Dirty
                    || _freddieMacArmIndexType.Dirty
                    || _freOfferingIdentifier.Dirty
                    || _fullPrepaymentPenaltyOptionType.Dirty
                    || _gseProjectClassificationType.Dirty
                    || _gsePropertyType.Dirty
                    || _hardPrepaymentPenaltyMonths.Dirty
                    || _helocPeriodTemplateName.Dirty
                    || _id.Dirty
                    || _indexCurrentValuePercent.Dirty
                    || _indexLookbackPeriod.Dirty
                    || _indexMarginPercent.Dirty
                    || _initialAdvanceAmount.Dirty
                    || _initialApplicationAmount.Dirty
                    || _inquiryOrPreQualificationIndicator.Dirty
                    || _lienPriorityType.Dirty
                    || _loanDocumentationType.Dirty
                    || _loanRepaymentType.Dirty
                    || _loanScheduledClosingDate.Dirty
                    || _maximumMonthlyPayment.Dirty
                    || _maxLifeInterestCapPercent.Dirty
                    || _miCoveragePercent.Dirty
                    || _minimumAdvanceAmount.Dirty
                    || _minimumAllowableApr.Dirty
                    || _minimumDrawPeroidPaymentPercent.Dirty
                    || _minimumPaymentAmount.Dirty
                    || _minimumPaymentLessThanAmount.Dirty
                    || _minimumPaymentPercent.Dirty
                    || _minimumPaymentUpbAmount.Dirty
                    || _minimumPaymentUpbPercent.Dirty
                    || _minimumRepayPeriodPaymentPercent.Dirty
                    || _monthsAppliedToPrepaymentPenaltyFeeCount.Dirty
                    || _negativeAmortizationLimitPercent.Dirty
                    || _netInitialAndFinal.Dirty
                    || _nmlsDocumentationType.Dirty
                    || _nmlsFirstMortgageType.Dirty
                    || _nmlsLoanType.Dirty
                    || _nmlsOptionARMIndicator.Dirty
                    || _nmlsPiggyBackOrFundedHELOCIndicator.Dirty
                    || _nmlsProductionSoldToType.Dirty
                    || _nmlsRefinancePurposeType.Dirty
                    || _nmlsReverseMortgageType.Dirty
                    || _oralRequestForExtensionOfCreditIndicator.Dirty
                    || _overLimitCharge.Dirty
                    || _overLimitReturnCharge.Dirty
                    || _participationFees.Dirty
                    || _paymentAdjustmentDurationMonthsCount.Dirty
                    || _paymentAdjustmentPeriodicCapPercent.Dirty
                    || _paymentFrequencyType.Dirty
                    || _prepaymentPenaltyBasedOn.Dirty
                    || _prepaymentPenaltyIndicator.Dirty
                    || _prepaymentPenaltyPercent.Dirty
                    || _prepaymentPenaltyTermMonthsCount.Dirty
                    || _prepaymentPenaltyVerbiage.Dirty
                    || _productName.Dirty
                    || _qualifyingRatePercent.Dirty
                    || _rateAdjustmentDurationMonthsCount.Dirty
                    || _rateAdjustmentLifetimeCapPercent.Dirty
                    || _rateAdjustmentPercent.Dirty
                    || _rateAdjustmentSubsequentCapPercent.Dirty
                    || _releaseRecoringCharge.Dirty
                    || _remainingBuydownAmount.Dirty
                    || _repayPeriodMonthsCount.Dirty
                    || _returnedCheckCharge.Dirty
                    || _returnedCheckChargeRatePercent.Dirty
                    || _returnedCheckMaxCharge.Dirty
                    || _returnedCheckMinCharge.Dirty
                    || _roundPercent.Dirty
                    || _roundType.Dirty
                    || _scheduledFirstPaymentAdjustmentDate.Dirty
                    || _scheduledFirstPaymentDate.Dirty
                    || _stopPaymentCharge.Dirty
                    || _subsequentRateAdjustmentMonthsCount.Dirty
                    || _terminationFeeAmount.Dirty
                    || _terminationPeriodMonthsCount.Dirty
                    || _thirdPartyFeeFromAmount.Dirty
                    || _thirdPartyFeeToAmount.Dirty
                    || _timelyPaymentRateReductionPercent.Dirty
                    || _timelyPaymentRewards.Dirty
                    || _totalSubsidyAmount.Dirty
                    || _transactionFees.Dirty
                    || _wireFee.Dirty
                    || _buydowns?.Dirty == true
                    || _helocRepaymentDrawPeriods?.Dirty == true
                    || _prepaymentPenalties?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _annualFeeNeededAmount.Dirty = value;
                _applyLifeCapLowIndicator.Dirty = value;
                _armDisclosureType.Dirty = value;
                _armIndexType.Dirty = value;
                _balloonIndicator.Dirty = value;
                _balloonLoanMaturityTermMonthsCount.Dirty = value;
                _borrowerEstimatedClosingDate.Dirty = value;
                _branchLocationNmlsId.Dirty = value;
                _branchManagerNmlsId.Dirty = value;
                _convertibleIndicator.Dirty = value;
                _discounted.Dirty = value;
                _discountedRate.Dirty = value;
                _drawPeriodMonthsCount.Dirty = value;
                _escrowWaiverIndicator.Dirty = value;
                _excludeLoanFromNMLSReportIndicator.Dirty = value;
                _floorBasis.Dirty = value;
                _floorPercent.Dirty = value;
                _floorVerbiage.Dirty = value;
                _fnmProductPlanIdentifier.Dirty = value;
                _freddieMacArmIndexType.Dirty = value;
                _freOfferingIdentifier.Dirty = value;
                _fullPrepaymentPenaltyOptionType.Dirty = value;
                _gseProjectClassificationType.Dirty = value;
                _gsePropertyType.Dirty = value;
                _hardPrepaymentPenaltyMonths.Dirty = value;
                _helocPeriodTemplateName.Dirty = value;
                _id.Dirty = value;
                _indexCurrentValuePercent.Dirty = value;
                _indexLookbackPeriod.Dirty = value;
                _indexMarginPercent.Dirty = value;
                _initialAdvanceAmount.Dirty = value;
                _initialApplicationAmount.Dirty = value;
                _inquiryOrPreQualificationIndicator.Dirty = value;
                _lienPriorityType.Dirty = value;
                _loanDocumentationType.Dirty = value;
                _loanRepaymentType.Dirty = value;
                _loanScheduledClosingDate.Dirty = value;
                _maximumMonthlyPayment.Dirty = value;
                _maxLifeInterestCapPercent.Dirty = value;
                _miCoveragePercent.Dirty = value;
                _minimumAdvanceAmount.Dirty = value;
                _minimumAllowableApr.Dirty = value;
                _minimumDrawPeroidPaymentPercent.Dirty = value;
                _minimumPaymentAmount.Dirty = value;
                _minimumPaymentLessThanAmount.Dirty = value;
                _minimumPaymentPercent.Dirty = value;
                _minimumPaymentUpbAmount.Dirty = value;
                _minimumPaymentUpbPercent.Dirty = value;
                _minimumRepayPeriodPaymentPercent.Dirty = value;
                _monthsAppliedToPrepaymentPenaltyFeeCount.Dirty = value;
                _negativeAmortizationLimitPercent.Dirty = value;
                _netInitialAndFinal.Dirty = value;
                _nmlsDocumentationType.Dirty = value;
                _nmlsFirstMortgageType.Dirty = value;
                _nmlsLoanType.Dirty = value;
                _nmlsOptionARMIndicator.Dirty = value;
                _nmlsPiggyBackOrFundedHELOCIndicator.Dirty = value;
                _nmlsProductionSoldToType.Dirty = value;
                _nmlsRefinancePurposeType.Dirty = value;
                _nmlsReverseMortgageType.Dirty = value;
                _oralRequestForExtensionOfCreditIndicator.Dirty = value;
                _overLimitCharge.Dirty = value;
                _overLimitReturnCharge.Dirty = value;
                _participationFees.Dirty = value;
                _paymentAdjustmentDurationMonthsCount.Dirty = value;
                _paymentAdjustmentPeriodicCapPercent.Dirty = value;
                _paymentFrequencyType.Dirty = value;
                _prepaymentPenaltyBasedOn.Dirty = value;
                _prepaymentPenaltyIndicator.Dirty = value;
                _prepaymentPenaltyPercent.Dirty = value;
                _prepaymentPenaltyTermMonthsCount.Dirty = value;
                _prepaymentPenaltyVerbiage.Dirty = value;
                _productName.Dirty = value;
                _qualifyingRatePercent.Dirty = value;
                _rateAdjustmentDurationMonthsCount.Dirty = value;
                _rateAdjustmentLifetimeCapPercent.Dirty = value;
                _rateAdjustmentPercent.Dirty = value;
                _rateAdjustmentSubsequentCapPercent.Dirty = value;
                _releaseRecoringCharge.Dirty = value;
                _remainingBuydownAmount.Dirty = value;
                _repayPeriodMonthsCount.Dirty = value;
                _returnedCheckCharge.Dirty = value;
                _returnedCheckChargeRatePercent.Dirty = value;
                _returnedCheckMaxCharge.Dirty = value;
                _returnedCheckMinCharge.Dirty = value;
                _roundPercent.Dirty = value;
                _roundType.Dirty = value;
                _scheduledFirstPaymentAdjustmentDate.Dirty = value;
                _scheduledFirstPaymentDate.Dirty = value;
                _stopPaymentCharge.Dirty = value;
                _subsequentRateAdjustmentMonthsCount.Dirty = value;
                _terminationFeeAmount.Dirty = value;
                _terminationPeriodMonthsCount.Dirty = value;
                _thirdPartyFeeFromAmount.Dirty = value;
                _thirdPartyFeeToAmount.Dirty = value;
                _timelyPaymentRateReductionPercent.Dirty = value;
                _timelyPaymentRewards.Dirty = value;
                _totalSubsidyAmount.Dirty = value;
                _transactionFees.Dirty = value;
                _wireFee.Dirty = value;
                if (_buydowns != null) _buydowns.Dirty = value;
                if (_helocRepaymentDrawPeriods != null) _helocRepaymentDrawPeriods.Dirty = value;
                if (_prepaymentPenalties != null) _prepaymentPenalties.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}