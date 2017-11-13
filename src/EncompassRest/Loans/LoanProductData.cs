using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class LoanProductData : IDirty
    {
        private DirtyValue<decimal?> _annualFeeNeededAmount;
        public decimal? AnnualFeeNeededAmount { get => _annualFeeNeededAmount; set => _annualFeeNeededAmount = value; }
        private DirtyValue<bool?> _applyLifeCapLowIndicator;
        public bool? ApplyLifeCapLowIndicator { get => _applyLifeCapLowIndicator; set => _applyLifeCapLowIndicator = value; }
        private StringEnumValue<IndexMargin> _armDisclosureType;
        public StringEnumValue<IndexMargin> ArmDisclosureType { get => _armDisclosureType; set => _armDisclosureType = value; }
        private StringEnumValue<ArmIndexType> _armIndexType;
        public StringEnumValue<ArmIndexType> ArmIndexType { get => _armIndexType; set => _armIndexType = value; }
        private DirtyValue<bool?> _balloonIndicator;
        public bool? BalloonIndicator { get => _balloonIndicator; set => _balloonIndicator = value; }
        private DirtyValue<int?> _balloonLoanMaturityTermMonthsCount;
        public int? BalloonLoanMaturityTermMonthsCount { get => _balloonLoanMaturityTermMonthsCount; set => _balloonLoanMaturityTermMonthsCount = value; }
        private DirtyValue<DateTime?> _borrowerEstimatedClosingDate;
        public DateTime? BorrowerEstimatedClosingDate { get => _borrowerEstimatedClosingDate; set => _borrowerEstimatedClosingDate = value; }
        private DirtyValue<string> _branchLocationNmlsId;
        public string BranchLocationNmlsId { get => _branchLocationNmlsId; set => _branchLocationNmlsId = value; }
        private DirtyValue<string> _branchManagerNmlsId;
        public string BranchManagerNmlsId { get => _branchManagerNmlsId; set => _branchManagerNmlsId = value; }
        private DirtyList<Buydown> _buydowns;
        public IList<Buydown> Buydowns { get => _buydowns ?? (_buydowns = new DirtyList<Buydown>()); set => _buydowns = new DirtyList<Buydown>(value); }
        private DirtyValue<bool?> _convertibleIndicator;
        public bool? ConvertibleIndicator { get => _convertibleIndicator; set => _convertibleIndicator = value; }
        private StringEnumValue<IsOrIsNot> _discounted;
        public StringEnumValue<IsOrIsNot> Discounted { get => _discounted; set => _discounted = value; }
        private DirtyValue<decimal?> _discountedRate;
        public decimal? DiscountedRate { get => _discountedRate; set => _discountedRate = value; }
        private DirtyValue<int?> _drawPeriodMonthsCount;
        public int? DrawPeriodMonthsCount { get => _drawPeriodMonthsCount; set => _drawPeriodMonthsCount = value; }
        private DirtyValue<bool?> _escrowWaiverIndicator;
        public bool? EscrowWaiverIndicator { get => _escrowWaiverIndicator; set => _escrowWaiverIndicator = value; }
        private DirtyValue<bool?> _excludeLoanFromNMLSReportIndicator;
        public bool? ExcludeLoanFromNMLSReportIndicator { get => _excludeLoanFromNMLSReportIndicator; set => _excludeLoanFromNMLSReportIndicator = value; }
        private StringEnumValue<FloorBasis> _floorBasis;
        public StringEnumValue<FloorBasis> FloorBasis { get => _floorBasis; set => _floorBasis = value; }
        private DirtyValue<decimal?> _floorPercent;
        public decimal? FloorPercent { get => _floorPercent; set => _floorPercent = value; }
        private StringEnumValue<FloorVerbiage> _floorVerbiage;
        public StringEnumValue<FloorVerbiage> FloorVerbiage { get => _floorVerbiage; set => _floorVerbiage = value; }
        private DirtyValue<string> _fnmProductPlanIdentifier;
        public string FnmProductPlanIdentifier { get => _fnmProductPlanIdentifier; set => _fnmProductPlanIdentifier = value; }
        private StringEnumValue<FreddieMacArmIndexType> _freddieMacArmIndexType;
        public StringEnumValue<FreddieMacArmIndexType> FreddieMacArmIndexType { get => _freddieMacArmIndexType; set => _freddieMacArmIndexType = value; }
        private StringEnumValue<FreOfferingIdentifier> _freOfferingIdentifier;
        public StringEnumValue<FreOfferingIdentifier> FreOfferingIdentifier { get => _freOfferingIdentifier; set => _freOfferingIdentifier = value; }
        private StringEnumValue<FullPrepaymentPenaltyOptionType> _fullPrepaymentPenaltyOptionType;
        public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => _fullPrepaymentPenaltyOptionType; set => _fullPrepaymentPenaltyOptionType = value; }
        private StringEnumValue<ProjectType> _gseProjectClassificationType;
        public StringEnumValue<ProjectType> GseProjectClassificationType { get => _gseProjectClassificationType; set => _gseProjectClassificationType = value; }
        private StringEnumValue<PropertyType> _gsePropertyType;
        public StringEnumValue<PropertyType> GsePropertyType { get => _gsePropertyType; set => _gsePropertyType = value; }
        private DirtyValue<int?> _hardPrepaymentPenaltyMonths;
        public int? HardPrepaymentPenaltyMonths { get => _hardPrepaymentPenaltyMonths; set => _hardPrepaymentPenaltyMonths = value; }
        private DirtyValue<string> _helocPeriodTemplateName;
        public string HelocPeriodTemplateName { get => _helocPeriodTemplateName; set => _helocPeriodTemplateName = value; }
        private DirtyList<HelocRepaymentDrawPeriod> _helocRepaymentDrawPeriods;
        public IList<HelocRepaymentDrawPeriod> HelocRepaymentDrawPeriods { get => _helocRepaymentDrawPeriods ?? (_helocRepaymentDrawPeriods = new DirtyList<HelocRepaymentDrawPeriod>()); set => _helocRepaymentDrawPeriods = new DirtyList<HelocRepaymentDrawPeriod>(value); }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _indexCurrentValuePercent;
        public decimal? IndexCurrentValuePercent { get => _indexCurrentValuePercent; set => _indexCurrentValuePercent = value; }
        private StringEnumValue<IndexLookbackPeriod> _indexLookbackPeriod;
        public StringEnumValue<IndexLookbackPeriod> IndexLookbackPeriod { get => _indexLookbackPeriod; set => _indexLookbackPeriod = value; }
        private DirtyValue<decimal?> _indexMarginPercent;
        public decimal? IndexMarginPercent { get => _indexMarginPercent; set => _indexMarginPercent = value; }
        private DirtyValue<decimal?> _initialAdvanceAmount;
        public decimal? InitialAdvanceAmount { get => _initialAdvanceAmount; set => _initialAdvanceAmount = value; }
        private DirtyValue<decimal?> _initialApplicationAmount;
        public decimal? InitialApplicationAmount { get => _initialApplicationAmount; set => _initialApplicationAmount = value; }
        private DirtyValue<bool?> _inquiryOrPreQualificationIndicator;
        public bool? InquiryOrPreQualificationIndicator { get => _inquiryOrPreQualificationIndicator; set => _inquiryOrPreQualificationIndicator = value; }
        private StringEnumValue<LienType> _lienPriorityType;
        public StringEnumValue<LienType> LienPriorityType { get => _lienPriorityType; set => _lienPriorityType = value; }
        private StringEnumValue<LoanDocumentationType> _loanDocumentationType;
        public StringEnumValue<LoanDocumentationType> LoanDocumentationType { get => _loanDocumentationType; set => _loanDocumentationType = value; }
        private StringEnumValue<LoanRepaymentType> _loanRepaymentType;
        public StringEnumValue<LoanRepaymentType> LoanRepaymentType { get => _loanRepaymentType; set => _loanRepaymentType = value; }
        private DirtyValue<DateTime?> _loanScheduledClosingDate;
        public DateTime? LoanScheduledClosingDate { get => _loanScheduledClosingDate; set => _loanScheduledClosingDate = value; }
        private DirtyValue<decimal?> _maximumMonthlyPayment;
        public decimal? MaximumMonthlyPayment { get => _maximumMonthlyPayment; set => _maximumMonthlyPayment = value; }
        private DirtyValue<decimal?> _maxLifeInterestCapPercent;
        public decimal? MaxLifeInterestCapPercent { get => _maxLifeInterestCapPercent; set => _maxLifeInterestCapPercent = value; }
        private DirtyValue<decimal?> _miCoveragePercent;
        public decimal? MiCoveragePercent { get => _miCoveragePercent; set => _miCoveragePercent = value; }
        private DirtyValue<decimal?> _minimumAdvanceAmount;
        public decimal? MinimumAdvanceAmount { get => _minimumAdvanceAmount; set => _minimumAdvanceAmount = value; }
        private DirtyValue<decimal?> _minimumAllowableApr;
        public decimal? MinimumAllowableApr { get => _minimumAllowableApr; set => _minimumAllowableApr = value; }
        private DirtyValue<decimal?> _minimumDrawPeroidPaymentPercent;
        public decimal? MinimumDrawPeroidPaymentPercent { get => _minimumDrawPeroidPaymentPercent; set => _minimumDrawPeroidPaymentPercent = value; }
        private DirtyValue<decimal?> _minimumPaymentAmount;
        public decimal? MinimumPaymentAmount { get => _minimumPaymentAmount; set => _minimumPaymentAmount = value; }
        private DirtyValue<decimal?> _minimumPaymentLessThanAmount;
        public decimal? MinimumPaymentLessThanAmount { get => _minimumPaymentLessThanAmount; set => _minimumPaymentLessThanAmount = value; }
        private DirtyValue<decimal?> _minimumPaymentPercent;
        public decimal? MinimumPaymentPercent { get => _minimumPaymentPercent; set => _minimumPaymentPercent = value; }
        private DirtyValue<decimal?> _minimumPaymentUpbAmount;
        public decimal? MinimumPaymentUpbAmount { get => _minimumPaymentUpbAmount; set => _minimumPaymentUpbAmount = value; }
        private DirtyValue<decimal?> _minimumPaymentUpbPercent;
        public decimal? MinimumPaymentUpbPercent { get => _minimumPaymentUpbPercent; set => _minimumPaymentUpbPercent = value; }
        private DirtyValue<decimal?> _minimumRepayPeriodPaymentPercent;
        public decimal? MinimumRepayPeriodPaymentPercent { get => _minimumRepayPeriodPaymentPercent; set => _minimumRepayPeriodPaymentPercent = value; }
        private DirtyValue<int?> _monthsAppliedToPrepaymentPenaltyFeeCount;
        public int? MonthsAppliedToPrepaymentPenaltyFeeCount { get => _monthsAppliedToPrepaymentPenaltyFeeCount; set => _monthsAppliedToPrepaymentPenaltyFeeCount = value; }
        private DirtyValue<decimal?> _negativeAmortizationLimitPercent;
        public decimal? NegativeAmortizationLimitPercent { get => _negativeAmortizationLimitPercent; set => _negativeAmortizationLimitPercent = value; }
        private DirtyValue<decimal?> _netInitialAndFinal;
        public decimal? NetInitialAndFinal { get => _netInitialAndFinal; set => _netInitialAndFinal = value; }
        private StringEnumValue<NmlsDocumentationType> _nmlsDocumentationType;
        public StringEnumValue<NmlsDocumentationType> NmlsDocumentationType { get => _nmlsDocumentationType; set => _nmlsDocumentationType = value; }
        private StringEnumValue<NmlsFirstMortgageType> _nmlsFirstMortgageType;
        public StringEnumValue<NmlsFirstMortgageType> NmlsFirstMortgageType { get => _nmlsFirstMortgageType; set => _nmlsFirstMortgageType = value; }
        private StringEnumValue<NmlsLoanType> _nmlsLoanType;
        public StringEnumValue<NmlsLoanType> NmlsLoanType { get => _nmlsLoanType; set => _nmlsLoanType = value; }
        private DirtyValue<bool?> _nmlsOptionARMIndicator;
        public bool? NmlsOptionARMIndicator { get => _nmlsOptionARMIndicator; set => _nmlsOptionARMIndicator = value; }
        private DirtyValue<bool?> _nmlsPiggyBackOrFundedHELOCIndicator;
        public bool? NmlsPiggyBackOrFundedHELOCIndicator { get => _nmlsPiggyBackOrFundedHELOCIndicator; set => _nmlsPiggyBackOrFundedHELOCIndicator = value; }
        private StringEnumValue<NmlsProductionSoldToType> _nmlsProductionSoldToType;
        public StringEnumValue<NmlsProductionSoldToType> NmlsProductionSoldToType { get => _nmlsProductionSoldToType; set => _nmlsProductionSoldToType = value; }
        private StringEnumValue<NmlsRefinancePurposeType> _nmlsRefinancePurposeType;
        public StringEnumValue<NmlsRefinancePurposeType> NmlsRefinancePurposeType { get => _nmlsRefinancePurposeType; set => _nmlsRefinancePurposeType = value; }
        private StringEnumValue<NmlsReverseMortgageType> _nmlsReverseMortgageType;
        public StringEnumValue<NmlsReverseMortgageType> NmlsReverseMortgageType { get => _nmlsReverseMortgageType; set => _nmlsReverseMortgageType = value; }
        private DirtyValue<bool?> _oralRequestForExtensionOfCreditIndicator;
        public bool? OralRequestForExtensionOfCreditIndicator { get => _oralRequestForExtensionOfCreditIndicator; set => _oralRequestForExtensionOfCreditIndicator = value; }
        private DirtyValue<decimal?> _overLimitCharge;
        public decimal? OverLimitCharge { get => _overLimitCharge; set => _overLimitCharge = value; }
        private DirtyValue<decimal?> _overLimitReturnCharge;
        public decimal? OverLimitReturnCharge { get => _overLimitReturnCharge; set => _overLimitReturnCharge = value; }
        private DirtyValue<decimal?> _participationFees;
        public decimal? ParticipationFees { get => _participationFees; set => _participationFees = value; }
        private DirtyValue<int?> _paymentAdjustmentDurationMonthsCount;
        public int? PaymentAdjustmentDurationMonthsCount { get => _paymentAdjustmentDurationMonthsCount; set => _paymentAdjustmentDurationMonthsCount = value; }
        private DirtyValue<decimal?> _paymentAdjustmentPeriodicCapPercent;
        public decimal? PaymentAdjustmentPeriodicCapPercent { get => _paymentAdjustmentPeriodicCapPercent; set => _paymentAdjustmentPeriodicCapPercent = value; }
        private StringEnumValue<PaymentFrequencyType> _paymentFrequencyType;
        public StringEnumValue<PaymentFrequencyType> PaymentFrequencyType { get => _paymentFrequencyType; set => _paymentFrequencyType = value; }
        private DirtyList<PrepaymentPenalty> _prepaymentPenalties;
        public IList<PrepaymentPenalty> PrepaymentPenalties { get => _prepaymentPenalties ?? (_prepaymentPenalties = new DirtyList<PrepaymentPenalty>()); set => _prepaymentPenalties = new DirtyList<PrepaymentPenalty>(value); }
        private StringEnumValue<PrepaymentPenaltyBasedOn> _prepaymentPenaltyBasedOn;
        public StringEnumValue<PrepaymentPenaltyBasedOn> PrepaymentPenaltyBasedOn { get => _prepaymentPenaltyBasedOn; set => _prepaymentPenaltyBasedOn = value; }
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        public bool? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => _prepaymentPenaltyIndicator = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        public decimal? PrepaymentPenaltyPercent { get => _prepaymentPenaltyPercent; set => _prepaymentPenaltyPercent = value; }
        private DirtyValue<int?> _prepaymentPenaltyTermMonthsCount;
        public int? PrepaymentPenaltyTermMonthsCount { get => _prepaymentPenaltyTermMonthsCount; set => _prepaymentPenaltyTermMonthsCount = value; }
        private StringEnumValue<PrepaymentPenaltyVerbiage> _prepaymentPenaltyVerbiage;
        public StringEnumValue<PrepaymentPenaltyVerbiage> PrepaymentPenaltyVerbiage { get => _prepaymentPenaltyVerbiage; set => _prepaymentPenaltyVerbiage = value; }
        private DirtyValue<string> _productName;
        public string ProductName { get => _productName; set => _productName = value; }
        private DirtyValue<decimal?> _qualifyingRatePercent;
        public decimal? QualifyingRatePercent { get => _qualifyingRatePercent; set => _qualifyingRatePercent = value; }
        private DirtyValue<int?> _rateAdjustmentDurationMonthsCount;
        public int? RateAdjustmentDurationMonthsCount { get => _rateAdjustmentDurationMonthsCount; set => _rateAdjustmentDurationMonthsCount = value; }
        private DirtyValue<decimal?> _rateAdjustmentLifetimeCapPercent;
        public decimal? RateAdjustmentLifetimeCapPercent { get => _rateAdjustmentLifetimeCapPercent; set => _rateAdjustmentLifetimeCapPercent = value; }
        private DirtyValue<decimal?> _rateAdjustmentPercent;
        public decimal? RateAdjustmentPercent { get => _rateAdjustmentPercent; set => _rateAdjustmentPercent = value; }
        private DirtyValue<decimal?> _rateAdjustmentSubsequentCapPercent;
        public decimal? RateAdjustmentSubsequentCapPercent { get => _rateAdjustmentSubsequentCapPercent; set => _rateAdjustmentSubsequentCapPercent = value; }
        private DirtyValue<decimal?> _releaseRecoringCharge;
        public decimal? ReleaseRecoringCharge { get => _releaseRecoringCharge; set => _releaseRecoringCharge = value; }
        private DirtyValue<decimal?> _remainingBuydownAmount;
        public decimal? RemainingBuydownAmount { get => _remainingBuydownAmount; set => _remainingBuydownAmount = value; }
        private DirtyValue<int?> _repayPeriodMonthsCount;
        public int? RepayPeriodMonthsCount { get => _repayPeriodMonthsCount; set => _repayPeriodMonthsCount = value; }
        private DirtyValue<decimal?> _returnedCheckCharge;
        public decimal? ReturnedCheckCharge { get => _returnedCheckCharge; set => _returnedCheckCharge = value; }
        private DirtyValue<decimal?> _returnedCheckChargeRatePercent;
        public decimal? ReturnedCheckChargeRatePercent { get => _returnedCheckChargeRatePercent; set => _returnedCheckChargeRatePercent = value; }
        private DirtyValue<decimal?> _returnedCheckMaxCharge;
        public decimal? ReturnedCheckMaxCharge { get => _returnedCheckMaxCharge; set => _returnedCheckMaxCharge = value; }
        private DirtyValue<decimal?> _returnedCheckMinCharge;
        public decimal? ReturnedCheckMinCharge { get => _returnedCheckMinCharge; set => _returnedCheckMinCharge = value; }
        private DirtyValue<decimal?> _roundPercent;
        public decimal? RoundPercent { get => _roundPercent; set => _roundPercent = value; }
        private StringEnumValue<RoundType> _roundType;
        public StringEnumValue<RoundType> RoundType { get => _roundType; set => _roundType = value; }
        private DirtyValue<DateTime?> _scheduledFirstPaymentAdjustmentDate;
        public DateTime? ScheduledFirstPaymentAdjustmentDate { get => _scheduledFirstPaymentAdjustmentDate; set => _scheduledFirstPaymentAdjustmentDate = value; }
        private DirtyValue<DateTime?> _scheduledFirstPaymentDate;
        public DateTime? ScheduledFirstPaymentDate { get => _scheduledFirstPaymentDate; set => _scheduledFirstPaymentDate = value; }
        private DirtyValue<decimal?> _stopPaymentCharge;
        public decimal? StopPaymentCharge { get => _stopPaymentCharge; set => _stopPaymentCharge = value; }
        private DirtyValue<int?> _subsequentRateAdjustmentMonthsCount;
        public int? SubsequentRateAdjustmentMonthsCount { get => _subsequentRateAdjustmentMonthsCount; set => _subsequentRateAdjustmentMonthsCount = value; }
        private DirtyValue<decimal?> _terminationFeeAmount;
        public decimal? TerminationFeeAmount { get => _terminationFeeAmount; set => _terminationFeeAmount = value; }
        private DirtyValue<int?> _terminationPeriodMonthsCount;
        public int? TerminationPeriodMonthsCount { get => _terminationPeriodMonthsCount; set => _terminationPeriodMonthsCount = value; }
        private DirtyValue<decimal?> _thirdPartyFeeFromAmount;
        public decimal? ThirdPartyFeeFromAmount { get => _thirdPartyFeeFromAmount; set => _thirdPartyFeeFromAmount = value; }
        private DirtyValue<decimal?> _thirdPartyFeeToAmount;
        public decimal? ThirdPartyFeeToAmount { get => _thirdPartyFeeToAmount; set => _thirdPartyFeeToAmount = value; }
        private DirtyValue<decimal?> _timelyPaymentRateReductionPercent;
        public decimal? TimelyPaymentRateReductionPercent { get => _timelyPaymentRateReductionPercent; set => _timelyPaymentRateReductionPercent = value; }
        private StringEnumValue<TimelyPaymentRewards> _timelyPaymentRewards;
        public StringEnumValue<TimelyPaymentRewards> TimelyPaymentRewards { get => _timelyPaymentRewards; set => _timelyPaymentRewards = value; }
        private DirtyValue<decimal?> _totalSubsidyAmount;
        public decimal? TotalSubsidyAmount { get => _totalSubsidyAmount; set => _totalSubsidyAmount = value; }
        private DirtyValue<decimal?> _transactionFees;
        public decimal? TransactionFees { get => _transactionFees; set => _transactionFees = value; }
        private DirtyValue<decimal?> _wireFee;
        public decimal? WireFee { get => _wireFee; set => _wireFee = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
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
                    || _prepaymentPenalties?.Dirty == true
                    || _extensionData?.Dirty == true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}