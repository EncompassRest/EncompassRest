using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _annualFeeNeededAmount; v0.Clean = value; _annualFeeNeededAmount = v0;
                var v1 = _applyLifeCapLowIndicator; v1.Clean = value; _applyLifeCapLowIndicator = v1;
                var v2 = _armDisclosureType; v2.Clean = value; _armDisclosureType = v2;
                var v3 = _armIndexType; v3.Clean = value; _armIndexType = v3;
                var v4 = _balloonIndicator; v4.Clean = value; _balloonIndicator = v4;
                var v5 = _balloonLoanMaturityTermMonthsCount; v5.Clean = value; _balloonLoanMaturityTermMonthsCount = v5;
                var v6 = _borrowerEstimatedClosingDate; v6.Clean = value; _borrowerEstimatedClosingDate = v6;
                var v7 = _branchLocationNmlsId; v7.Clean = value; _branchLocationNmlsId = v7;
                var v8 = _branchManagerNmlsId; v8.Clean = value; _branchManagerNmlsId = v8;
                var v9 = _buydowns; v9.Clean = value; _buydowns = v9;
                var v10 = _convertibleIndicator; v10.Clean = value; _convertibleIndicator = v10;
                var v11 = _discounted; v11.Clean = value; _discounted = v11;
                var v12 = _discountedRate; v12.Clean = value; _discountedRate = v12;
                var v13 = _drawPeriodMonthsCount; v13.Clean = value; _drawPeriodMonthsCount = v13;
                var v14 = _escrowWaiverIndicator; v14.Clean = value; _escrowWaiverIndicator = v14;
                var v15 = _excludeLoanFromNMLSReportIndicator; v15.Clean = value; _excludeLoanFromNMLSReportIndicator = v15;
                var v16 = _floorBasis; v16.Clean = value; _floorBasis = v16;
                var v17 = _floorPercent; v17.Clean = value; _floorPercent = v17;
                var v18 = _floorVerbiage; v18.Clean = value; _floorVerbiage = v18;
                var v19 = _fnmProductPlanIdentifier; v19.Clean = value; _fnmProductPlanIdentifier = v19;
                var v20 = _freddieMacArmIndexType; v20.Clean = value; _freddieMacArmIndexType = v20;
                var v21 = _freOfferingIdentifier; v21.Clean = value; _freOfferingIdentifier = v21;
                var v22 = _fullPrepaymentPenaltyOptionType; v22.Clean = value; _fullPrepaymentPenaltyOptionType = v22;
                var v23 = _gseProjectClassificationType; v23.Clean = value; _gseProjectClassificationType = v23;
                var v24 = _gsePropertyType; v24.Clean = value; _gsePropertyType = v24;
                var v25 = _hardPrepaymentPenaltyMonths; v25.Clean = value; _hardPrepaymentPenaltyMonths = v25;
                var v26 = _helocPeriodTemplateName; v26.Clean = value; _helocPeriodTemplateName = v26;
                var v27 = _helocRepaymentDrawPeriods; v27.Clean = value; _helocRepaymentDrawPeriods = v27;
                var v28 = _id; v28.Clean = value; _id = v28;
                var v29 = _indexCurrentValuePercent; v29.Clean = value; _indexCurrentValuePercent = v29;
                var v30 = _indexLookbackPeriod; v30.Clean = value; _indexLookbackPeriod = v30;
                var v31 = _indexMarginPercent; v31.Clean = value; _indexMarginPercent = v31;
                var v32 = _initialAdvanceAmount; v32.Clean = value; _initialAdvanceAmount = v32;
                var v33 = _initialApplicationAmount; v33.Clean = value; _initialApplicationAmount = v33;
                var v34 = _inquiryOrPreQualificationIndicator; v34.Clean = value; _inquiryOrPreQualificationIndicator = v34;
                var v35 = _lienPriorityType; v35.Clean = value; _lienPriorityType = v35;
                var v36 = _loanDocumentationType; v36.Clean = value; _loanDocumentationType = v36;
                var v37 = _loanRepaymentType; v37.Clean = value; _loanRepaymentType = v37;
                var v38 = _loanScheduledClosingDate; v38.Clean = value; _loanScheduledClosingDate = v38;
                var v39 = _maximumMonthlyPayment; v39.Clean = value; _maximumMonthlyPayment = v39;
                var v40 = _maxLifeInterestCapPercent; v40.Clean = value; _maxLifeInterestCapPercent = v40;
                var v41 = _miCoveragePercent; v41.Clean = value; _miCoveragePercent = v41;
                var v42 = _minimumAdvanceAmount; v42.Clean = value; _minimumAdvanceAmount = v42;
                var v43 = _minimumAllowableApr; v43.Clean = value; _minimumAllowableApr = v43;
                var v44 = _minimumDrawPeroidPaymentPercent; v44.Clean = value; _minimumDrawPeroidPaymentPercent = v44;
                var v45 = _minimumPaymentAmount; v45.Clean = value; _minimumPaymentAmount = v45;
                var v46 = _minimumPaymentLessThanAmount; v46.Clean = value; _minimumPaymentLessThanAmount = v46;
                var v47 = _minimumPaymentPercent; v47.Clean = value; _minimumPaymentPercent = v47;
                var v48 = _minimumPaymentUpbAmount; v48.Clean = value; _minimumPaymentUpbAmount = v48;
                var v49 = _minimumPaymentUpbPercent; v49.Clean = value; _minimumPaymentUpbPercent = v49;
                var v50 = _minimumRepayPeriodPaymentPercent; v50.Clean = value; _minimumRepayPeriodPaymentPercent = v50;
                var v51 = _monthsAppliedToPrepaymentPenaltyFeeCount; v51.Clean = value; _monthsAppliedToPrepaymentPenaltyFeeCount = v51;
                var v52 = _negativeAmortizationLimitPercent; v52.Clean = value; _negativeAmortizationLimitPercent = v52;
                var v53 = _netInitialAndFinal; v53.Clean = value; _netInitialAndFinal = v53;
                var v54 = _nmlsDocumentationType; v54.Clean = value; _nmlsDocumentationType = v54;
                var v55 = _nmlsFirstMortgageType; v55.Clean = value; _nmlsFirstMortgageType = v55;
                var v56 = _nmlsLoanType; v56.Clean = value; _nmlsLoanType = v56;
                var v57 = _nmlsOptionARMIndicator; v57.Clean = value; _nmlsOptionARMIndicator = v57;
                var v58 = _nmlsPiggyBackOrFundedHELOCIndicator; v58.Clean = value; _nmlsPiggyBackOrFundedHELOCIndicator = v58;
                var v59 = _nmlsProductionSoldToType; v59.Clean = value; _nmlsProductionSoldToType = v59;
                var v60 = _nmlsRefinancePurposeType; v60.Clean = value; _nmlsRefinancePurposeType = v60;
                var v61 = _nmlsReverseMortgageType; v61.Clean = value; _nmlsReverseMortgageType = v61;
                var v62 = _oralRequestForExtensionOfCreditIndicator; v62.Clean = value; _oralRequestForExtensionOfCreditIndicator = v62;
                var v63 = _overLimitCharge; v63.Clean = value; _overLimitCharge = v63;
                var v64 = _overLimitReturnCharge; v64.Clean = value; _overLimitReturnCharge = v64;
                var v65 = _participationFees; v65.Clean = value; _participationFees = v65;
                var v66 = _paymentAdjustmentDurationMonthsCount; v66.Clean = value; _paymentAdjustmentDurationMonthsCount = v66;
                var v67 = _paymentAdjustmentPeriodicCapPercent; v67.Clean = value; _paymentAdjustmentPeriodicCapPercent = v67;
                var v68 = _paymentFrequencyType; v68.Clean = value; _paymentFrequencyType = v68;
                var v69 = _prepaymentPenalties; v69.Clean = value; _prepaymentPenalties = v69;
                var v70 = _prepaymentPenaltyBasedOn; v70.Clean = value; _prepaymentPenaltyBasedOn = v70;
                var v71 = _prepaymentPenaltyIndicator; v71.Clean = value; _prepaymentPenaltyIndicator = v71;
                var v72 = _prepaymentPenaltyPercent; v72.Clean = value; _prepaymentPenaltyPercent = v72;
                var v73 = _prepaymentPenaltyTermMonthsCount; v73.Clean = value; _prepaymentPenaltyTermMonthsCount = v73;
                var v74 = _prepaymentPenaltyVerbiage; v74.Clean = value; _prepaymentPenaltyVerbiage = v74;
                var v75 = _productName; v75.Clean = value; _productName = v75;
                var v76 = _qualifyingRatePercent; v76.Clean = value; _qualifyingRatePercent = v76;
                var v77 = _rateAdjustmentDurationMonthsCount; v77.Clean = value; _rateAdjustmentDurationMonthsCount = v77;
                var v78 = _rateAdjustmentLifetimeCapPercent; v78.Clean = value; _rateAdjustmentLifetimeCapPercent = v78;
                var v79 = _rateAdjustmentPercent; v79.Clean = value; _rateAdjustmentPercent = v79;
                var v80 = _rateAdjustmentSubsequentCapPercent; v80.Clean = value; _rateAdjustmentSubsequentCapPercent = v80;
                var v81 = _releaseRecoringCharge; v81.Clean = value; _releaseRecoringCharge = v81;
                var v82 = _remainingBuydownAmount; v82.Clean = value; _remainingBuydownAmount = v82;
                var v83 = _repayPeriodMonthsCount; v83.Clean = value; _repayPeriodMonthsCount = v83;
                var v84 = _returnedCheckCharge; v84.Clean = value; _returnedCheckCharge = v84;
                var v85 = _returnedCheckChargeRatePercent; v85.Clean = value; _returnedCheckChargeRatePercent = v85;
                var v86 = _returnedCheckMaxCharge; v86.Clean = value; _returnedCheckMaxCharge = v86;
                var v87 = _returnedCheckMinCharge; v87.Clean = value; _returnedCheckMinCharge = v87;
                var v88 = _roundPercent; v88.Clean = value; _roundPercent = v88;
                var v89 = _roundType; v89.Clean = value; _roundType = v89;
                var v90 = _scheduledFirstPaymentAdjustmentDate; v90.Clean = value; _scheduledFirstPaymentAdjustmentDate = v90;
                var v91 = _scheduledFirstPaymentDate; v91.Clean = value; _scheduledFirstPaymentDate = v91;
                var v92 = _stopPaymentCharge; v92.Clean = value; _stopPaymentCharge = v92;
                var v93 = _subsequentRateAdjustmentMonthsCount; v93.Clean = value; _subsequentRateAdjustmentMonthsCount = v93;
                var v94 = _terminationFeeAmount; v94.Clean = value; _terminationFeeAmount = v94;
                var v95 = _terminationPeriodMonthsCount; v95.Clean = value; _terminationPeriodMonthsCount = v95;
                var v96 = _thirdPartyFeeFromAmount; v96.Clean = value; _thirdPartyFeeFromAmount = v96;
                var v97 = _thirdPartyFeeToAmount; v97.Clean = value; _thirdPartyFeeToAmount = v97;
                var v98 = _timelyPaymentRateReductionPercent; v98.Clean = value; _timelyPaymentRateReductionPercent = v98;
                var v99 = _timelyPaymentRewards; v99.Clean = value; _timelyPaymentRewards = v99;
                var v100 = _totalSubsidyAmount; v100.Clean = value; _totalSubsidyAmount = v100;
                var v101 = _transactionFees; v101.Clean = value; _transactionFees = v101;
                var v102 = _wireFee; v102.Clean = value; _wireFee = v102;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}