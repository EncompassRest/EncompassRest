using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanProductData
    /// </summary>
    public sealed partial class LoanProductData : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _annualFeeNeededAmount;
        private DirtyValue<bool?> _applyLifeCapLowIndicator;
        private DirtyValue<StringEnumValue<IndexMargin>> _armDisclosureType;
        private DirtyValue<StringEnumValue<ArmIndexType>> _armIndexType;
        private DirtyValue<bool?> _balloonIndicator;
        private DirtyValue<int?> _balloonLoanMaturityTermMonthsCount;
        private DirtyValue<DateTime?> _borrowerEstimatedClosingDate;
        private DirtyValue<string> _branchLocationNmlsId;
        private DirtyValue<string> _branchManagerNmlsId;
        private DirtyList<Buydown> _buydowns;
        private DirtyValue<bool?> _convertibleIndicator;
        private DirtyValue<StringEnumValue<IsOrIsNot>> _discounted;
        private DirtyValue<decimal?> _discountedRate;
        private DirtyValue<int?> _drawPeriodMonthsCount;
        private DirtyValue<bool?> _escrowWaiverIndicator;
        private DirtyValue<bool?> _excludeLoanFromNMLSReportIndicator;
        private DirtyValue<StringEnumValue<FloorBasis>> _floorBasis;
        private DirtyValue<decimal?> _floorPercent;
        private DirtyValue<string> _floorPercentUI;
        private DirtyValue<StringEnumValue<FloorVerbiage>> _floorVerbiage;
        private DirtyValue<string> _fnmProductPlanIdentifier;
        private DirtyValue<StringEnumValue<FreddieMacArmIndexType>> _freddieMacArmIndexType;
        private DirtyValue<StringEnumValue<FreOfferingIdentifier>> _freOfferingIdentifier;
        private DirtyValue<StringEnumValue<FullPrepaymentPenaltyOptionType>> _fullPrepaymentPenaltyOptionType;
        private DirtyValue<StringEnumValue<ProjectType>> _gseProjectClassificationType;
        private DirtyValue<StringEnumValue<PropertyType>> _gsePropertyType;
        private DirtyValue<int?> _hardPrepaymentPenaltyMonths;
        private DirtyValue<string> _helocPeriodTemplateName;
        private DirtyList<HelocRepaymentDrawPeriod> _helocRepaymentDrawPeriods;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _indexCurrentValuePercent;
        private DirtyValue<StringEnumValue<IndexLookbackPeriod>> _indexLookbackPeriod;
        private DirtyValue<decimal?> _indexMarginPercent;
        private DirtyValue<string> _indexMarginPercentUI;
        private DirtyValue<decimal?> _initialAdvanceAmount;
        private DirtyValue<decimal?> _initialApplicationAmount;
        private DirtyValue<bool?> _inquiryOrPreQualificationIndicator;
        private DirtyValue<StringEnumValue<LienType>> _lienPriorityType;
        private DirtyValue<StringEnumValue<LoanDocumentationType>> _loanDocumentationType;
        private DirtyValue<StringEnumValue<LoanRepaymentType>> _loanRepaymentType;
        private DirtyValue<DateTime?> _loanScheduledClosingDate;
        private DirtyValue<decimal?> _maximumMonthlyPayment;
        private DirtyValue<decimal?> _maxLifeInterestCapPercent;
        private DirtyValue<string> _maxLifeInterestCapPercentUI;
        private DirtyValue<decimal?> _miCoveragePercent;
        private DirtyValue<decimal?> _minimumAdvanceAmount;
        private DirtyValue<decimal?> _minimumAllowableApr;
        private DirtyValue<decimal?> _minimumDrawPeroidPaymentPercent;
        private DirtyValue<decimal?> _minimumPaymentAmount;
        private DirtyValue<decimal?> _minimumPaymentLessThanAmount;
        private DirtyValue<decimal?> _minimumPaymentPercent;
        private DirtyValue<decimal?> _minimumPaymentUpbAmount;
        private DirtyValue<decimal?> _minimumPaymentUpbPercent;
        private DirtyValue<decimal?> _minimumRepayPeriodPaymentPercent;
        private DirtyValue<int?> _monthsAppliedToPrepaymentPenaltyFeeCount;
        private DirtyValue<decimal?> _negativeAmortizationLimitPercent;
        private DirtyValue<decimal?> _netInitialAndFinal;
        private DirtyValue<StringEnumValue<NmlsDocumentationType>> _nmlsDocumentationType;
        private DirtyValue<StringEnumValue<NmlsFirstMortgageType>> _nmlsFirstMortgageType;
        private DirtyValue<StringEnumValue<NmlsLienStatus>> _nmlsLienStatus;
        private DirtyValue<StringEnumValue<NmlsLoanType>> _nmlsLoanType;
        private DirtyValue<bool?> _nmlsOptionARMIndicator;
        private DirtyValue<bool?> _nmlsPiggyBackOrFundedHELOCIndicator;
        private DirtyValue<StringEnumValue<NmlsProductionSoldToType>> _nmlsProductionSoldToType;
        private DirtyValue<StringEnumValue<NmlsPropertyType>> _nmlsPropertyType;
        private DirtyValue<StringEnumValue<NmlsRefinancePurposeType>> _nmlsRefinancePurposeType;
        private DirtyValue<StringEnumValue<NmlsReverseMortgageType>> _nmlsReverseMortgageType;
        private DirtyValue<bool?> _oralRequestForExtensionOfCreditIndicator;
        private DirtyValue<decimal?> _overLimitCharge;
        private DirtyValue<decimal?> _overLimitReturnCharge;
        private DirtyValue<decimal?> _participationFees;
        private DirtyValue<int?> _paymentAdjustmentDurationMonthsCount;
        private DirtyValue<decimal?> _paymentAdjustmentPeriodicCapPercent;
        private DirtyValue<StringEnumValue<PaymentFrequencyType>> _paymentFrequencyType;
        private DirtyList<PrepaymentPenalty> _prepaymentPenalties;
        private DirtyValue<StringEnumValue<PrepaymentPenaltyBasedOn>> _prepaymentPenaltyBasedOn;
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        private DirtyValue<int?> _prepaymentPenaltyTermMonthsCount;
        private DirtyValue<StringEnumValue<PrepaymentPenaltyVerbiage>> _prepaymentPenaltyVerbiage;
        private DirtyValue<string> _productName;
        private DirtyValue<decimal?> _qualifyingRatePercent;
        private DirtyValue<int?> _rateAdjustmentDurationMonthsCount;
        private DirtyValue<decimal?> _rateAdjustmentLifetimeCapPercent;
        private DirtyValue<decimal?> _rateAdjustmentPercent;
        private DirtyValue<string> _rateAdjustmentPercentUI;
        private DirtyValue<decimal?> _rateAdjustmentSubsequentCapPercent;
        private DirtyValue<string> _rateAdjustmentSubsequentCapPercentUI;
        private DirtyValue<decimal?> _releaseRecoringCharge;
        private DirtyValue<decimal?> _remainingBuydownAmount;
        private DirtyValue<int?> _repayPeriodMonthsCount;
        private DirtyValue<decimal?> _returnedCheckCharge;
        private DirtyValue<decimal?> _returnedCheckChargeRatePercent;
        private DirtyValue<decimal?> _returnedCheckMaxCharge;
        private DirtyValue<decimal?> _returnedCheckMinCharge;
        private DirtyValue<decimal?> _roundPercent;
        private DirtyValue<StringEnumValue<RoundType>> _roundType;
        private DirtyValue<DateTime?> _scheduledFirstPaymentAdjustmentDate;
        private DirtyValue<DateTime?> _scheduledFirstPaymentDate;
        private DirtyValue<decimal?> _stopPaymentCharge;
        private DirtyValue<int?> _subsequentRateAdjustmentMonthsCount;
        private DirtyValue<decimal?> _terminationFeeAmount;
        private DirtyValue<int?> _terminationPeriodMonthsCount;
        private DirtyValue<decimal?> _thirdPartyFeeFromAmount;
        private DirtyValue<decimal?> _thirdPartyFeeToAmount;
        private DirtyValue<decimal?> _timelyPaymentRateReductionPercent;
        private DirtyValue<StringEnumValue<TimelyPaymentRewards>> _timelyPaymentRewards;
        private DirtyValue<decimal?> _totalSubsidyAmount;
        private DirtyValue<decimal?> _transactionFees;
        private DirtyValue<decimal?> _wireFee;

        /// <summary>
        /// HELOC Annual Fee [1891]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AnnualFeeNeededAmount { get => _annualFeeNeededAmount; set => SetField(ref _annualFeeNeededAmount, value); }

        /// <summary>
        /// ARM Apply Life Cap Low [ARM.ApplyLfCpLow]
        /// </summary>
        public bool? ApplyLifeCapLowIndicator { get => _applyLifeCapLowIndicator; set => SetField(ref _applyLifeCapLowIndicator, value); }

        /// <summary>
        /// Loan Info ARM Disclosure Type [1959]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"UST1YW\":\"1 Year UST CM (weekly)\",\"UST3YW\":\"3 Year UST CM (weekly)\",\"UST5YW\":\"5 Year UST CM (weekly)\",\"UST7YW\":\"7 Year UST CM (weekly)\",\"UST10YW\":\"10 Year UST CM (weekly)\",\"UST20YW\":\"20 Year UST CM (weekly)\",\"UST30YW\":\"30 Year UST CM (weekly)\",\"UST1Y\":\"1 Year US Treasury CM (daily)\",\"UST3Y\":\"3 Year US Treasury CM (daily)\",\"UST5Y\":\"5 Year US Treasury CM (daily)\",\"UST7Y\":\"7 Year US Treasury CM (daily)\",\"UST10Y\":\"10 Year US Treasury CM (daily)\",\"UST20Y\":\"20 Year US Treasury CM (daily)\",\"UST30Y\":\"30 Year US Treasury CM (daily)\",\"3MoCD(12MoAvg)\":\"3-MonthCD (12-Month Avg)\",\"6MCDW\":\"6 Month CD (Secondary Market) weekly\",\"UST6M\":\"6 Month US Treasury CM (daily)\",\"FRBCommercial3M\":\"90 Day AA Commercial Paper Rates (Nonfinancial)\",\"WSJPrime\":\"WSJ Prime Rate (daily)\",\"WSJPrimeWkly\":\"WSJ Prime Rate (weekly)\"}")]
        public StringEnumValue<IndexMargin> ArmDisclosureType { get => _armDisclosureType; set => SetField(ref _armDisclosureType, value); }

        /// <summary>
        /// Fannie Mae ARM Index Type [MORNET.X70]
        /// </summary>
        public StringEnumValue<ArmIndexType> ArmIndexType { get => _armIndexType; set => SetField(ref _armIndexType, value); }

        /// <summary>
        /// Trans Details Amort Type Balloon [1659]
        /// </summary>
        public bool? BalloonIndicator { get => _balloonIndicator; set => SetField(ref _balloonIndicator, value); }

        /// <summary>
        /// Trans Details Term Due In [325]
        /// </summary>
        public int? BalloonLoanMaturityTermMonthsCount { get => _balloonLoanMaturityTermMonthsCount; set => SetField(ref _balloonLoanMaturityTermMonthsCount, value); }

        /// <summary>
        /// Borrower Est Closing Date [4114]
        /// </summary>
        public DateTime? BorrowerEstimatedClosingDate { get => _borrowerEstimatedClosingDate; set => SetField(ref _borrowerEstimatedClosingDate, value); }

        /// <summary>
        /// NMLS Branch Location NMLS ID [NMLS.X9]
        /// </summary>
        public string BranchLocationNmlsId { get => _branchLocationNmlsId; set => SetField(ref _branchLocationNmlsId, value); }

        /// <summary>
        /// NMLS Branch Manager NMLS ID [NMLS.X8]
        /// </summary>
        public string BranchManagerNmlsId { get => _branchManagerNmlsId; set => SetField(ref _branchManagerNmlsId, value); }

        /// <summary>
        /// LoanProductData Buydowns
        /// </summary>
        public IList<Buydown> Buydowns { get => GetField(ref _buydowns); set => SetField(ref _buydowns, value); }

        /// <summary>
        /// Freddie Mac Lender Rate Adj Convertible [1290]
        /// </summary>
        public bool? ConvertibleIndicator { get => _convertibleIndicator; set => SetField(ref _convertibleIndicator, value); }

        /// <summary>
        /// HELOC Discounted [1967]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"is\":\"Yes\",\"is not\":\"No\"}")]
        public StringEnumValue<IsOrIsNot> Discounted { get => _discounted; set => SetField(ref _discounted, value); }

        /// <summary>
        /// HELOC Discounted Rate [1968]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? DiscountedRate { get => _discountedRate; set => SetField(ref _discountedRate, value); }

        /// <summary>
        /// HELOC Draw Period Mos [1889]
        /// </summary>
        public int? DrawPeriodMonthsCount { get => _drawPeriodMonthsCount; set => SetField(ref _drawPeriodMonthsCount, value); }

        /// <summary>
        /// Fannie Mae Escrow Waived [MORNET.X15]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Escrow will be waived\"}")]
        public bool? EscrowWaiverIndicator { get => _escrowWaiverIndicator; set => SetField(ref _escrowWaiverIndicator, value); }

        /// <summary>
        /// NMLS Exclude this Loan from the NMLS Report [NMLS.X15]
        /// </summary>
        public bool? ExcludeLoanFromNMLSReportIndicator { get => _excludeLoanFromNMLSReportIndicator; set => SetField(ref _excludeLoanFromNMLSReportIndicator, value); }

        /// <summary>
        /// ARM Floor Basis [ARM.FlrBasis]
        /// </summary>
        public StringEnumValue<FloorBasis> FloorBasis { get => _floorBasis; set => SetField(ref _floorBasis, value); }

        /// <summary>
        /// Loan Info ARM Floor Rate [1699]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FloorPercent { get => _floorPercent; set => SetField(ref _floorPercent, value); }

        /// <summary>
        /// Loan Info ARM Floor Rate - Display field with KBYO rounding rules [KBYO.XD1699]
        /// </summary>
        public string FloorPercentUI { get => _floorPercentUI; set => SetField(ref _floorPercentUI, value); }

        /// <summary>
        /// ARM Floor Verbiage Type [ARM.FlrVerbgTyp]
        /// </summary>
        public StringEnumValue<FloorVerbiage> FloorVerbiage { get => _floorVerbiage; set => SetField(ref _floorVerbiage, value); }

        /// <summary>
        /// Trans Details Amort Type ARM Descr [995]
        /// </summary>
        public string FnmProductPlanIdentifier { get => _fnmProductPlanIdentifier; set => SetField(ref _fnmProductPlanIdentifier, value); }

        /// <summary>
        /// Freddie Mac Lender ARM Index [CASASRN.X135]
        /// </summary>
        public StringEnumValue<FreddieMacArmIndexType> FreddieMacArmIndexType { get => _freddieMacArmIndexType; set => SetField(ref _freddieMacArmIndexType, value); }

        /// <summary>
        /// Freddie Mac Offering Identifier [CASASRN.X163]
        /// </summary>
        public StringEnumValue<FreOfferingIdentifier> FreOfferingIdentifier { get => _freOfferingIdentifier; set => SetField(ref _freOfferingIdentifier, value); }

        /// <summary>
        /// REGZ Prepymt Penalty Type of Prepay 1 [1946]
        /// </summary>
        public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => _fullPrepaymentPenaltyOptionType; set => SetField(ref _fullPrepaymentPenaltyOptionType, value); }

        /// <summary>
        /// Subject Property Project Classification [1012]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"A_IIICondominium\":\"Streamlined Review\",\"B_IICondominium\":\"Established Project\",\"C_ICondominium\":\"New Project\"}")]
        public StringEnumValue<ProjectType> GseProjectClassificationType { get => _gseProjectClassificationType; set => SetField(ref _gseProjectClassificationType, value); }

        /// <summary>
        /// Subject Property Type Fannie Mae [1041]
        /// </summary>
        public StringEnumValue<PropertyType> GsePropertyType { get => _gsePropertyType; set => SetField(ref _gsePropertyType, value); }

        /// <summary>
        /// REGZ Prepay Penalty Mths Hard Prepayment Period [3536]
        /// </summary>
        public int? HardPrepaymentPenaltyMonths { get => _hardPrepaymentPenaltyMonths; set => SetField(ref _hardPrepaymentPenaltyMonths, value); }

        /// <summary>
        /// HELOC Period Template Name [1985]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string HelocPeriodTemplateName { get => _helocPeriodTemplateName; set => SetField(ref _helocPeriodTemplateName, value); }

        /// <summary>
        /// LoanProductData HelocRepaymentDrawPeriods
        /// </summary>
        public IList<HelocRepaymentDrawPeriod> HelocRepaymentDrawPeriods { get => GetField(ref _helocRepaymentDrawPeriods); set => SetField(ref _helocRepaymentDrawPeriods, value); }

        /// <summary>
        /// LoanProductData Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Loan Info ARM Index [688]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? IndexCurrentValuePercent { get => _indexCurrentValuePercent; set => SetField(ref _indexCurrentValuePercent, value); }

        /// <summary>
        /// ARM Index Lookback Period [ARM.IdxLkbckPrd]
        /// </summary>
        public StringEnumValue<IndexLookbackPeriod> IndexLookbackPeriod { get => _indexLookbackPeriod; set => SetField(ref _indexLookbackPeriod, value); }

        /// <summary>
        /// Loan Info ARM Margin [689]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? IndexMarginPercent { get => _indexMarginPercent; set => SetField(ref _indexMarginPercent, value); }

        /// <summary>
        /// Loan Info ARM Margin - Display field with KBYO rounding rules [KBYO.XD689]
        /// </summary>
        public string IndexMarginPercentUI { get => _indexMarginPercentUI; set => SetField(ref _indexMarginPercentUI, value); }

        /// <summary>
        /// HELOC Initial Advance [1888]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialAdvanceAmount { get => _initialAdvanceAmount; set => SetField(ref _initialAdvanceAmount, value); }

        /// <summary>
        /// NMLS Initial Application Amount [NMLS.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialApplicationAmount { get => _initialApplicationAmount; set => SetField(ref _initialApplicationAmount, value); }

        /// <summary>
        /// NMLS Inquiry Or Pre-Qualification [NMLS.X13]
        /// </summary>
        public bool? InquiryOrPreQualificationIndicator { get => _inquiryOrPreQualificationIndicator; set => SetField(ref _inquiryOrPreQualificationIndicator, value); }

        /// <summary>
        /// Trans Details Lien Position [420]
        /// </summary>
        public StringEnumValue<LienType> LienPriorityType { get => _lienPriorityType; set => SetField(ref _lienPriorityType, value); }

        /// <summary>
        /// Fannie Mae Loan Doc Type Code [MORNET.X67]
        /// </summary>
        public StringEnumValue<LoanDocumentationType> LoanDocumentationType { get => _loanDocumentationType; set => SetField(ref _loanDocumentationType, value); }

        /// <summary>
        /// Fannie Mae Repymt Type Code [424]
        /// </summary>
        public StringEnumValue<LoanRepaymentType> LoanRepaymentType { get => _loanRepaymentType; set => SetField(ref _loanRepaymentType, value); }

        /// <summary>
        /// Trans Details Est Closing Date [763]
        /// </summary>
        public DateTime? LoanScheduledClosingDate { get => _loanScheduledClosingDate; set => SetField(ref _loanScheduledClosingDate, value); }

        /// <summary>
        /// Maximum Monthly Payment [NEWHUD.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaximumMonthlyPayment { get => _maximumMonthlyPayment; set => SetField(ref _maximumMonthlyPayment, value); }

        /// <summary>
        /// Loan Info ARM Max Life Interest Cap [2625]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MaxLifeInterestCapPercent { get => _maxLifeInterestCapPercent; set => SetField(ref _maxLifeInterestCapPercent, value); }

        /// <summary>
        /// Loan Info ARM Max Life Interest Cap - Display field with KBYO rounding rules [KBYO.XD2625]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string MaxLifeInterestCapPercentUI { get => _maxLifeInterestCapPercentUI; set => SetField(ref _maxLifeInterestCapPercentUI, value); }

        /// <summary>
        /// Insurance Mtg Ins Coverage Factor [430]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MiCoveragePercent { get => _miCoveragePercent; set => SetField(ref _miCoveragePercent, value); }

        /// <summary>
        /// HELOC Min Advance Amt [1892]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MinimumAdvanceAmount { get => _minimumAdvanceAmount; set => SetField(ref _minimumAdvanceAmount, value); }

        /// <summary>
        /// HELOC Max Allowable APR [1893]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MinimumAllowableApr { get => _minimumAllowableApr; set => SetField(ref _minimumAllowableApr, value); }

        /// <summary>
        /// HELOC Minimum Draw Period Payment [HELOC.MinAdvPct]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MinimumDrawPeroidPaymentPercent { get => _minimumDrawPeroidPaymentPercent; set => SetField(ref _minimumDrawPeroidPaymentPercent, value); }

        /// <summary>
        /// HELOC Minimum Payment [1483]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MinimumPaymentAmount { get => _minimumPaymentAmount; set => SetField(ref _minimumPaymentAmount, value); }

        /// <summary>
        /// HELOC Minimum Payment Less Than Amt [HELOC.MinPmtLessThanAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MinimumPaymentLessThanAmount { get => _minimumPaymentLessThanAmount; set => SetField(ref _minimumPaymentLessThanAmount, value); }

        /// <summary>
        /// HELOC Pymt Factor [1413]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MinimumPaymentPercent { get => _minimumPaymentPercent; set => SetField(ref _minimumPaymentPercent, value); }

        /// <summary>
        /// HELOC Minimum Payment UPB Amt [HELOC.MinPmtUnpdBalAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MinimumPaymentUpbAmount { get => _minimumPaymentUpbAmount; set => SetField(ref _minimumPaymentUpbAmount, value); }

        /// <summary>
        /// HELOC Min. Payment UPB [HELOC.MinPmtUPB]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MinimumPaymentUpbPercent { get => _minimumPaymentUpbPercent; set => SetField(ref _minimumPaymentUpbPercent, value); }

        /// <summary>
        /// HELOC Minimum Repay Period Payment [HELOC.MinRepmtPct]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MinimumRepayPeriodPaymentPercent { get => _minimumRepayPeriodPaymentPercent; set => SetField(ref _minimumRepayPeriodPaymentPercent, value); }

        /// <summary>
        /// REGZ Prepay Penalty Mths Applied To Prpymt Pnlty Fee [2829]
        /// </summary>
        public int? MonthsAppliedToPrepaymentPenaltyFeeCount { get => _monthsAppliedToPrepaymentPenaltyFeeCount; set => SetField(ref _monthsAppliedToPrepaymentPenaltyFeeCount, value); }

        /// <summary>
        /// Loan Info ARM Max Bal % [698]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? NegativeAmortizationLimitPercent { get => _negativeAmortizationLimitPercent; set => SetField(ref _negativeAmortizationLimitPercent, value); }

        /// <summary>
        /// NMLS Net (Initial and Final) [NMLS.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? NetInitialAndFinal { get => _netInitialAndFinal; set => SetField(ref _netInitialAndFinal, value); }

        /// <summary>
        /// NMLS Documentation Type [NMLS.X3]
        /// </summary>
        public StringEnumValue<NmlsDocumentationType> NmlsDocumentationType { get => _nmlsDocumentationType; set => SetField(ref _nmlsDocumentationType, value); }

        /// <summary>
        /// NMLS Residential First Mortgage Type [NMLS.X2]
        /// </summary>
        public StringEnumValue<NmlsFirstMortgageType> NmlsFirstMortgageType { get => _nmlsFirstMortgageType; set => SetField(ref _nmlsFirstMortgageType, value); }

        /// <summary>
        /// NMLS Trans Details Lien Status [NMLS.X17]
        /// </summary>
        public StringEnumValue<NmlsLienStatus> NmlsLienStatus { get => _nmlsLienStatus; set => SetField(ref _nmlsLienStatus, value); }

        /// <summary>
        /// NMLS Loan Type [NMLS.X1]
        /// </summary>
        public StringEnumValue<NmlsLoanType> NmlsLoanType { get => _nmlsLoanType; set => SetField(ref _nmlsLoanType, value); }

        /// <summary>
        /// NMLS Option ARM Indicator [NMLS.X4]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Option ARM\",\"false\":\"Not Option ARM\"}")]
        public bool? NmlsOptionARMIndicator { get => _nmlsOptionARMIndicator; set => SetField(ref _nmlsOptionARMIndicator, value); }

        /// <summary>
        /// NMLS Piggyback or Funded HELOC Indicator [NMLS.X5]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Includes piggyback second or funded HELOC\",\"false\":\"Does not include piggyback second or funded HELOC\"}")]
        public bool? NmlsPiggyBackOrFundedHELOCIndicator { get => _nmlsPiggyBackOrFundedHELOCIndicator; set => SetField(ref _nmlsPiggyBackOrFundedHELOCIndicator, value); }

        /// <summary>
        /// NMLS Production Sold To [NMLS.X7]
        /// </summary>
        public StringEnumValue<NmlsProductionSoldToType> NmlsProductionSoldToType { get => _nmlsProductionSoldToType; set => SetField(ref _nmlsProductionSoldToType, value); }

        /// <summary>
        /// NMLS Subject Property Type [NMLS.X16]
        /// </summary>
        public StringEnumValue<NmlsPropertyType> NmlsPropertyType { get => _nmlsPropertyType; set => SetField(ref _nmlsPropertyType, value); }

        /// <summary>
        /// NMLS Refinance Purpose [NMLS.X6]
        /// </summary>
        public StringEnumValue<NmlsRefinancePurposeType> NmlsRefinancePurposeType { get => _nmlsRefinancePurposeType; set => SetField(ref _nmlsRefinancePurposeType, value); }

        /// <summary>
        /// NMLS Reverse Mortgage Type [NMLS.X10]
        /// </summary>
        public StringEnumValue<NmlsReverseMortgageType> NmlsReverseMortgageType { get => _nmlsReverseMortgageType; set => SetField(ref _nmlsReverseMortgageType, value); }

        /// <summary>
        /// NMLS Oral Request for Extension of Credit [NMLS.X14]
        /// </summary>
        public bool? OralRequestForExtensionOfCreditIndicator { get => _oralRequestForExtensionOfCreditIndicator; set => SetField(ref _oralRequestForExtensionOfCreditIndicator, value); }

        /// <summary>
        /// HELOC Over Limit Charge [HELOC.OvrLmtChg]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OverLimitCharge { get => _overLimitCharge; set => SetField(ref _overLimitCharge, value); }

        /// <summary>
        /// HELOC Over Limit Return Charge [HELOC.OvrLmtRtnChg]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OverLimitReturnCharge { get => _overLimitReturnCharge; set => SetField(ref _overLimitReturnCharge, value); }

        /// <summary>
        /// HELOC Participation Fees: The total amount(s) payable at or before account opening for participation in an open-end credit plan. [HELOC.ParticipationFees]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ParticipationFees { get => _participationFees; set => SetField(ref _participationFees, value); }

        /// <summary>
        /// Loan Info ARM Pymt Adj Period [690]
        /// </summary>
        public int? PaymentAdjustmentDurationMonthsCount { get => _paymentAdjustmentDurationMonthsCount; set => SetField(ref _paymentAdjustmentDurationMonthsCount, value); }

        /// <summary>
        /// Loan Info ARM Pymt Adj Cap [691]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PaymentAdjustmentPeriodicCapPercent { get => _paymentAdjustmentPeriodicCapPercent; set => SetField(ref _paymentAdjustmentPeriodicCapPercent, value); }

        /// <summary>
        /// Trans Details Amort Type Biweekly [423]
        /// </summary>
        public StringEnumValue<PaymentFrequencyType> PaymentFrequencyType { get => _paymentFrequencyType; set => SetField(ref _paymentFrequencyType, value); }

        /// <summary>
        /// LoanProductData PrepaymentPenalties
        /// </summary>
        public IList<PrepaymentPenalty> PrepaymentPenalties { get => GetField(ref _prepaymentPenalties); set => SetField(ref _prepaymentPenalties, value); }

        /// <summary>
        /// Amount REGZ Prepayment Penalty Based On [2830]
        /// </summary>
        public StringEnumValue<PrepaymentPenaltyBasedOn> PrepaymentPenaltyBasedOn { get => _prepaymentPenaltyBasedOn; set => SetField(ref _prepaymentPenaltyBasedOn, value); }

        /// <summary>
        /// Prepayment Penalty [675]
        /// </summary>
        public bool? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }

        /// <summary>
        /// REGZ Prepymt Penalty Prepymt as a % 1 [1948]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PrepaymentPenaltyPercent { get => _prepaymentPenaltyPercent; set => SetField(ref _prepaymentPenaltyPercent, value); }

        /// <summary>
        /// REGZ Prepymt Penalty Prepymt Period 1 [1947]
        /// </summary>
        public int? PrepaymentPenaltyTermMonthsCount { get => _prepaymentPenaltyTermMonthsCount; set => SetField(ref _prepaymentPenaltyTermMonthsCount, value); }

        /// <summary>
        /// Prepay Verbiage Type [Terms.PrepyVrbgTyp]
        /// </summary>
        public StringEnumValue<PrepaymentPenaltyVerbiage> PrepaymentPenaltyVerbiage { get => _prepaymentPenaltyVerbiage; set => SetField(ref _prepaymentPenaltyVerbiage, value); }

        /// <summary>
        /// Fannie Mae Product Name [MORNET.X66]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string ProductName { get => _productName; set => SetField(ref _productName, value); }

        /// <summary>
        /// Trans Details Qual Rate [1014]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? QualifyingRatePercent { get => _qualifyingRatePercent; set => SetField(ref _qualifyingRatePercent, value); }

        /// <summary>
        /// Loan Info ARM Rate Adj Period [694]
        /// </summary>
        public int? RateAdjustmentDurationMonthsCount { get => _rateAdjustmentDurationMonthsCount; set => SetField(ref _rateAdjustmentDurationMonthsCount, value); }

        /// <summary>
        /// Loan Info ARM Life Cap [247]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? RateAdjustmentLifetimeCapPercent { get => _rateAdjustmentLifetimeCapPercent; set => SetField(ref _rateAdjustmentLifetimeCapPercent, value); }

        /// <summary>
        /// Loan Info ARM First Rate Adj Cap [697]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? RateAdjustmentPercent { get => _rateAdjustmentPercent; set => SetField(ref _rateAdjustmentPercent, value); }

        /// <summary>
        /// Loan Info ARM First Rate Adj Cap - Display fields with KBYO rounding rules [KBYO.XD697]
        /// </summary>
        public string RateAdjustmentPercentUI { get => _rateAdjustmentPercentUI; set => SetField(ref _rateAdjustmentPercentUI, value); }

        /// <summary>
        /// Loan Info ARM Rate Cap [695]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? RateAdjustmentSubsequentCapPercent { get => _rateAdjustmentSubsequentCapPercent; set => SetField(ref _rateAdjustmentSubsequentCapPercent, value); }

        /// <summary>
        /// Loan Info ARM Rate Cap - Display fields with KBYO rounding rules [KBYO.XD695]
        /// </summary>
        public string RateAdjustmentSubsequentCapPercentUI { get => _rateAdjustmentSubsequentCapPercentUI; set => SetField(ref _rateAdjustmentSubsequentCapPercentUI, value); }

        /// <summary>
        /// HELOC Release Recording Charge [HELOC.RlsRecgChg]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ReleaseRecoringCharge { get => _releaseRecoringCharge; set => SetField(ref _releaseRecoringCharge, value); }

        /// <summary>
        /// Buydown Dsbmt Sum Total Subsidy Bal [3120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? RemainingBuydownAmount { get => _remainingBuydownAmount; set => SetField(ref _remainingBuydownAmount, value); }

        /// <summary>
        /// HELOC Repay Period Mos [1890]
        /// </summary>
        public int? RepayPeriodMonthsCount { get => _repayPeriodMonthsCount; set => SetField(ref _repayPeriodMonthsCount, value); }

        /// <summary>
        /// HELOC Returned Check Charge Amt. [HELOC.RtdChkChgAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ReturnedCheckCharge { get => _returnedCheckCharge; set => SetField(ref _returnedCheckCharge, value); }

        /// <summary>
        /// HELOC Returned Check Charge Rate [HELOC.RtdChkChgRat]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ReturnedCheckChargeRatePercent { get => _returnedCheckChargeRatePercent; set => SetField(ref _returnedCheckChargeRatePercent, value); }

        /// <summary>
        /// HELOC Returned Check Charge Max. [HELOC.RtdChkChgMax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ReturnedCheckMaxCharge { get => _returnedCheckMaxCharge; set => SetField(ref _returnedCheckMaxCharge, value); }

        /// <summary>
        /// HELOC Returned Check Charge Min. [HELOC.RtdChkChgMin]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ReturnedCheckMinCharge { get => _returnedCheckMinCharge; set => SetField(ref _returnedCheckMinCharge, value); }

        /// <summary>
        /// Loan Info ARM Round Index To % [1700]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? RoundPercent { get => _roundPercent; set => SetField(ref _roundPercent, value); }

        /// <summary>
        /// Loan Info ARM Round Index Up/Down [SYS.X1]
        /// </summary>
        public StringEnumValue<RoundType> RoundType { get => _roundType; set => SetField(ref _roundType, value); }

        /// <summary>
        /// Trans Details First Pymt Adj Date [3054]
        /// </summary>
        public DateTime? ScheduledFirstPaymentAdjustmentDate { get => _scheduledFirstPaymentAdjustmentDate; set => SetField(ref _scheduledFirstPaymentAdjustmentDate, value); }

        /// <summary>
        /// Trans Details First Pymt Date [682]
        /// </summary>
        public DateTime? ScheduledFirstPaymentDate { get => _scheduledFirstPaymentDate; set => SetField(ref _scheduledFirstPaymentDate, value); }

        /// <summary>
        /// HELOC Stop Payment Charge [HELOC.StopPmtChrg]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? StopPaymentCharge { get => _stopPaymentCharge; set => SetField(ref _stopPaymentCharge, value); }

        /// <summary>
        /// Loan Info ARM First Period Change [696]
        /// </summary>
        public int? SubsequentRateAdjustmentMonthsCount { get => _subsequentRateAdjustmentMonthsCount; set => SetField(ref _subsequentRateAdjustmentMonthsCount, value); }

        /// <summary>
        /// HELOC Termination Fee [1986]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TerminationFeeAmount { get => _terminationFeeAmount; set => SetField(ref _terminationFeeAmount, value); }

        /// <summary>
        /// HELOC Termination Fee Mos [1987]
        /// </summary>
        public int? TerminationPeriodMonthsCount { get => _terminationPeriodMonthsCount; set => SetField(ref _terminationPeriodMonthsCount, value); }

        /// <summary>
        /// HELOC Third Party Fees Range - From [1965]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ThirdPartyFeeFromAmount { get => _thirdPartyFeeFromAmount; set => SetField(ref _thirdPartyFeeFromAmount, value); }

        /// <summary>
        /// HELOC Third Party Fees Range - To [1966]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ThirdPartyFeeToAmount { get => _thirdPartyFeeToAmount; set => SetField(ref _thirdPartyFeeToAmount, value); }

        /// <summary>
        /// Loan Info Timely Payment Reduction Percent [2634]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? TimelyPaymentRateReductionPercent { get => _timelyPaymentRateReductionPercent; set => SetField(ref _timelyPaymentRateReductionPercent, value); }

        /// <summary>
        /// Loan Info Timely Payment Rewards [2633]
        /// </summary>
        public StringEnumValue<TimelyPaymentRewards> TimelyPaymentRewards { get => _timelyPaymentRewards; set => SetField(ref _timelyPaymentRewards, value); }

        /// <summary>
        /// Buydown Dsbmt Sum Tot. Subsidy Amt [3119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalSubsidyAmount { get => _totalSubsidyAmount; set => SetField(ref _totalSubsidyAmount, value); }

        /// <summary>
        /// HELOC Transaction Fees: The total amount of fees charged each time a withdrawal or other specified transaction is made on a line of credit, such as a balance transfer fee or a cash advance fee. [HELOC.TransactionFees]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TransactionFees { get => _transactionFees; set => SetField(ref _transactionFees, value); }

        /// <summary>
        /// HELOC Wire Fee [HELOC.WireFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? WireFee { get => _wireFee; set => SetField(ref _wireFee, value); }
    }
}