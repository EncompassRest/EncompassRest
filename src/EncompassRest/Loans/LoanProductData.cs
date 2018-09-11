using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanProductData
    /// </summary>
    public sealed partial class LoanProductData : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _annualFeeNeededAmount;
        /// <summary>
        /// HELOC Annual Fee [1891]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Annual Fee")]
        public decimal? AnnualFeeNeededAmount { get => _annualFeeNeededAmount; set => SetField(ref _annualFeeNeededAmount, value); }
        private DirtyValue<bool?> _applyLifeCapLowIndicator;
        /// <summary>
        /// ARM Apply Life Cap Low [ARM.ApplyLfCpLow]
        /// </summary>
        [LoanFieldProperty(Description = "ARM Apply Life Cap Low")]
        public bool? ApplyLifeCapLowIndicator { get => _applyLifeCapLowIndicator; set => SetField(ref _applyLifeCapLowIndicator, value); }
        private DirtyValue<StringEnumValue<IndexMargin>> _armDisclosureType;
        /// <summary>
        /// Loan Info ARM Disclosure Type [1959]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Disclosure Type", OptionsJson = "{\"UST1YW\":\"1 Year UST CM (weekly)\",\"UST3YW\":\"3 Year UST CM (weekly)\",\"UST5YW\":\"5 Year UST CM (weekly)\",\"UST7YW\":\"7 Year UST CM (weekly)\",\"UST10YW\":\"10 Year UST CM (weekly)\",\"UST20YW\":\"20 Year UST CM (weekly)\",\"UST30YW\":\"30 Year UST CM (weekly)\",\"UST1Y\":\"1 Year US Treasury CM (daily)\",\"UST3Y\":\"3 Year US Treasury CM (daily)\",\"UST5Y\":\"5 Year US Treasury CM (daily)\",\"UST7Y\":\"7 Year US Treasury CM (daily)\",\"UST10Y\":\"10 Year US Treasury CM (daily)\",\"UST20Y\":\"20 Year US Treasury CM (daily)\",\"UST30Y\":\"30 Year US Treasury CM (daily)\",\"3MoCD(12MoAvg)\":\"3-MonthCD (12-Month Avg)\",\"6MCDW\":\"6 Month CD (Secondary Market) weekly\",\"UST6M\":\"6 Month US Treasury CM (daily)\",\"FRBCommercial3M\":\"90 Day AA Commercial Paper Rates (Nonfinancial)\",\"WSJPrime\":\"WSJ Prime Rate (daily)\",\"WSJPrimeWkly\":\"WSJ Prime Rate (weekly)\"}")]
        public StringEnumValue<IndexMargin> ArmDisclosureType { get => _armDisclosureType; set => SetField(ref _armDisclosureType, value); }
        private DirtyValue<StringEnumValue<ArmIndexType>> _armIndexType;
        /// <summary>
        /// Fannie Mae ARM Index Type [MORNET.X70]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae ARM Index Type")]
        public StringEnumValue<ArmIndexType> ArmIndexType { get => _armIndexType; set => SetField(ref _armIndexType, value); }
        private DirtyValue<bool?> _balloonIndicator;
        /// <summary>
        /// Trans Details Amort Type Balloon [1659]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Amort Type Balloon")]
        public bool? BalloonIndicator { get => _balloonIndicator; set => SetField(ref _balloonIndicator, value); }
        private DirtyValue<int?> _balloonLoanMaturityTermMonthsCount;
        /// <summary>
        /// Trans Details Term Due In [325]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Term Due In")]
        public int? BalloonLoanMaturityTermMonthsCount { get => _balloonLoanMaturityTermMonthsCount; set => SetField(ref _balloonLoanMaturityTermMonthsCount, value); }
        private DirtyValue<DateTime?> _borrowerEstimatedClosingDate;
        /// <summary>
        /// Borrower Est Closing Date [4114]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Est Closing Date")]
        public DateTime? BorrowerEstimatedClosingDate { get => _borrowerEstimatedClosingDate; set => SetField(ref _borrowerEstimatedClosingDate, value); }
        private DirtyValue<string> _branchLocationNmlsId;
        /// <summary>
        /// NMLS Branch Location NMLS ID [NMLS.X9]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Branch Location NMLS ID")]
        public string BranchLocationNmlsId { get => _branchLocationNmlsId; set => SetField(ref _branchLocationNmlsId, value); }
        private DirtyValue<string> _branchManagerNmlsId;
        /// <summary>
        /// NMLS Branch Manager NMLS ID [NMLS.X8]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Branch Manager NMLS ID")]
        public string BranchManagerNmlsId { get => _branchManagerNmlsId; set => SetField(ref _branchManagerNmlsId, value); }
        private DirtyList<Buydown> _buydowns;
        /// <summary>
        /// LoanProductData Buydowns
        /// </summary>
        public IList<Buydown> Buydowns { get => GetField(ref _buydowns); set => SetField(ref _buydowns, value); }
        private DirtyValue<bool?> _convertibleIndicator;
        /// <summary>
        /// Freddie Mac Lender Rate Adj Convertible [1290]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender Rate Adj Convertible")]
        public bool? ConvertibleIndicator { get => _convertibleIndicator; set => SetField(ref _convertibleIndicator, value); }
        private DirtyValue<StringEnumValue<IsOrIsNot>> _discounted;
        /// <summary>
        /// HELOC Discounted [1967]
        /// </summary>
        [LoanFieldProperty(Description = "HELOC Discounted", OptionsJson = "{\"is\":\"Yes\",\"is not\":\"No\"}")]
        public StringEnumValue<IsOrIsNot> Discounted { get => _discounted; set => SetField(ref _discounted, value); }
        private DirtyValue<decimal?> _discountedRate;
        /// <summary>
        /// HELOC Discounted Rate [1968]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HELOC Discounted Rate")]
        public decimal? DiscountedRate { get => _discountedRate; set => SetField(ref _discountedRate, value); }
        private DirtyValue<int?> _drawPeriodMonthsCount;
        /// <summary>
        /// HELOC Draw Period Mos [1889]
        /// </summary>
        [LoanFieldProperty(Description = "HELOC Draw Period Mos")]
        public int? DrawPeriodMonthsCount { get => _drawPeriodMonthsCount; set => SetField(ref _drawPeriodMonthsCount, value); }
        private DirtyValue<bool?> _escrowWaiverIndicator;
        /// <summary>
        /// Fannie Mae Escrow Waived [MORNET.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Escrow Waived", OptionsJson = "{\"true\":\"Escrow will be waived\"}")]
        public bool? EscrowWaiverIndicator { get => _escrowWaiverIndicator; set => SetField(ref _escrowWaiverIndicator, value); }
        private DirtyValue<bool?> _excludeLoanFromNMLSReportIndicator;
        /// <summary>
        /// NMLS Exclude this Loan from the NMLS Report [NMLS.X15]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Exclude this Loan from the NMLS Report")]
        public bool? ExcludeLoanFromNMLSReportIndicator { get => _excludeLoanFromNMLSReportIndicator; set => SetField(ref _excludeLoanFromNMLSReportIndicator, value); }
        private DirtyValue<StringEnumValue<FloorBasis>> _floorBasis;
        /// <summary>
        /// ARM Floor Basis [ARM.FlrBasis]
        /// </summary>
        [LoanFieldProperty(Description = "ARM Floor Basis")]
        public StringEnumValue<FloorBasis> FloorBasis { get => _floorBasis; set => SetField(ref _floorBasis, value); }
        private DirtyValue<decimal?> _floorPercent;
        /// <summary>
        /// Loan Info ARM Floor Rate [1699]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Floor Rate")]
        public decimal? FloorPercent { get => _floorPercent; set => SetField(ref _floorPercent, value); }
        private DirtyValue<string> _floorPercentUI;
        /// <summary>
        /// Loan Info ARM Floor Rate - Display field with KBYO rounding rules [KBYO.XD1699]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Floor Rate - Display field with KBYO rounding rules")]
        public string FloorPercentUI { get => _floorPercentUI; set => SetField(ref _floorPercentUI, value); }
        private DirtyValue<StringEnumValue<FloorVerbiage>> _floorVerbiage;
        /// <summary>
        /// ARM Floor Verbiage Type [ARM.FlrVerbgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "ARM Floor Verbiage Type")]
        public StringEnumValue<FloorVerbiage> FloorVerbiage { get => _floorVerbiage; set => SetField(ref _floorVerbiage, value); }
        private DirtyValue<string> _fnmProductPlanIdentifier;
        /// <summary>
        /// Trans Details Amort Type ARM Descr [995]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Amort Type ARM Descr")]
        public string FnmProductPlanIdentifier { get => _fnmProductPlanIdentifier; set => SetField(ref _fnmProductPlanIdentifier, value); }
        private DirtyValue<StringEnumValue<FreddieMacArmIndexType>> _freddieMacArmIndexType;
        /// <summary>
        /// Freddie Mac Lender ARM Index [CASASRN.X135]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Lender ARM Index")]
        public StringEnumValue<FreddieMacArmIndexType> FreddieMacArmIndexType { get => _freddieMacArmIndexType; set => SetField(ref _freddieMacArmIndexType, value); }
        private DirtyValue<StringEnumValue<FreOfferingIdentifier>> _freOfferingIdentifier;
        /// <summary>
        /// Freddie Mac Offering Identifier [CASASRN.X163]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Mac Offering Identifier")]
        public StringEnumValue<FreOfferingIdentifier> FreOfferingIdentifier { get => _freOfferingIdentifier; set => SetField(ref _freOfferingIdentifier, value); }
        private DirtyValue<StringEnumValue<FullPrepaymentPenaltyOptionType>> _fullPrepaymentPenaltyOptionType;
        /// <summary>
        /// REGZ Prepymt Penalty Type of Prepay 1 [1946]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Prepymt Penalty Type of Prepay 1")]
        public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => _fullPrepaymentPenaltyOptionType; set => SetField(ref _fullPrepaymentPenaltyOptionType, value); }
        private DirtyValue<StringEnumValue<ProjectType>> _gseProjectClassificationType;
        /// <summary>
        /// Subject Property Project Classification [1012]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Project Classification", OptionsJson = "{\"A_IIICondominium\":\"Streamlined Review\",\"B_IICondominium\":\"Established Project\",\"C_ICondominium\":\"New Project\"}")]
        public StringEnumValue<ProjectType> GseProjectClassificationType { get => _gseProjectClassificationType; set => SetField(ref _gseProjectClassificationType, value); }
        private DirtyValue<StringEnumValue<PropertyType>> _gsePropertyType;
        /// <summary>
        /// Subject Property Type Fannie Mae [1041]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Type Fannie Mae")]
        public StringEnumValue<PropertyType> GsePropertyType { get => _gsePropertyType; set => SetField(ref _gsePropertyType, value); }
        private DirtyValue<int?> _hardPrepaymentPenaltyMonths;
        /// <summary>
        /// REGZ Prepay Penalty Mths Hard Prepayment Period [3536]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Prepay Penalty Mths Hard Prepayment Period")]
        public int? HardPrepaymentPenaltyMonths { get => _hardPrepaymentPenaltyMonths; set => SetField(ref _hardPrepaymentPenaltyMonths, value); }
        private DirtyValue<string> _helocPeriodTemplateName;
        /// <summary>
        /// HELOC Period Template Name [1985]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HELOC Period Template Name")]
        public string HelocPeriodTemplateName { get => _helocPeriodTemplateName; set => SetField(ref _helocPeriodTemplateName, value); }
        private DirtyList<HelocRepaymentDrawPeriod> _helocRepaymentDrawPeriods;
        /// <summary>
        /// LoanProductData HelocRepaymentDrawPeriods
        /// </summary>
        public IList<HelocRepaymentDrawPeriod> HelocRepaymentDrawPeriods { get => GetField(ref _helocRepaymentDrawPeriods); set => SetField(ref _helocRepaymentDrawPeriods, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanProductData Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _indexCurrentValuePercent;
        /// <summary>
        /// Loan Info ARM Index [688]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Index")]
        public decimal? IndexCurrentValuePercent { get => _indexCurrentValuePercent; set => SetField(ref _indexCurrentValuePercent, value); }
        private DirtyValue<StringEnumValue<IndexLookbackPeriod>> _indexLookbackPeriod;
        /// <summary>
        /// ARM Index Lookback Period [ARM.IdxLkbckPrd]
        /// </summary>
        [LoanFieldProperty(Description = "ARM Index Lookback Period")]
        public StringEnumValue<IndexLookbackPeriod> IndexLookbackPeriod { get => _indexLookbackPeriod; set => SetField(ref _indexLookbackPeriod, value); }
        private DirtyValue<decimal?> _indexMarginPercent;
        /// <summary>
        /// Loan Info ARM Margin [689]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Margin")]
        public decimal? IndexMarginPercent { get => _indexMarginPercent; set => SetField(ref _indexMarginPercent, value); }
        private DirtyValue<string> _indexMarginPercentUI;
        /// <summary>
        /// Loan Info ARM Margin - Display field with KBYO rounding rules [KBYO.XD689]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Margin - Display field with KBYO rounding rules")]
        public string IndexMarginPercentUI { get => _indexMarginPercentUI; set => SetField(ref _indexMarginPercentUI, value); }
        private DirtyValue<decimal?> _initialAdvanceAmount;
        /// <summary>
        /// HELOC Initial Advance [1888]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Initial Advance")]
        public decimal? InitialAdvanceAmount { get => _initialAdvanceAmount; set => SetField(ref _initialAdvanceAmount, value); }
        private DirtyValue<decimal?> _initialApplicationAmount;
        /// <summary>
        /// NMLS Initial Application Amount [NMLS.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "NMLS Initial Application Amount")]
        public decimal? InitialApplicationAmount { get => _initialApplicationAmount; set => SetField(ref _initialApplicationAmount, value); }
        private DirtyValue<bool?> _inquiryOrPreQualificationIndicator;
        /// <summary>
        /// NMLS Inquiry Or Pre-Qualification [NMLS.X13]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Inquiry Or Pre-Qualification")]
        public bool? InquiryOrPreQualificationIndicator { get => _inquiryOrPreQualificationIndicator; set => SetField(ref _inquiryOrPreQualificationIndicator, value); }
        private DirtyValue<StringEnumValue<LienType>> _lienPriorityType;
        /// <summary>
        /// Trans Details Lien Position [420]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Lien Position")]
        public StringEnumValue<LienType> LienPriorityType { get => _lienPriorityType; set => SetField(ref _lienPriorityType, value); }
        private DirtyValue<StringEnumValue<LoanDocumentationType>> _loanDocumentationType;
        /// <summary>
        /// Fannie Mae Loan Doc Type Code [MORNET.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Loan Doc Type Code")]
        public StringEnumValue<LoanDocumentationType> LoanDocumentationType { get => _loanDocumentationType; set => SetField(ref _loanDocumentationType, value); }
        private DirtyValue<StringEnumValue<LoanRepaymentType>> _loanRepaymentType;
        /// <summary>
        /// Fannie Mae Repymt Type Code [424]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Mae Repymt Type Code")]
        public StringEnumValue<LoanRepaymentType> LoanRepaymentType { get => _loanRepaymentType; set => SetField(ref _loanRepaymentType, value); }
        private DirtyValue<DateTime?> _loanScheduledClosingDate;
        /// <summary>
        /// Trans Details Est Closing Date [763]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Est Closing Date")]
        public DateTime? LoanScheduledClosingDate { get => _loanScheduledClosingDate; set => SetField(ref _loanScheduledClosingDate, value); }
        private DirtyValue<decimal?> _maximumMonthlyPayment;
        /// <summary>
        /// Maximum Monthly Payment [NEWHUD.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Maximum Monthly Payment")]
        public decimal? MaximumMonthlyPayment { get => _maximumMonthlyPayment; set => SetField(ref _maximumMonthlyPayment, value); }
        private DirtyValue<decimal?> _maxLifeInterestCapPercent;
        /// <summary>
        /// Loan Info ARM Max Life Interest Cap [2625]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Loan Info ARM Max Life Interest Cap")]
        public decimal? MaxLifeInterestCapPercent { get => _maxLifeInterestCapPercent; set => SetField(ref _maxLifeInterestCapPercent, value); }
        private DirtyValue<string> _maxLifeInterestCapPercentUI;
        /// <summary>
        /// Loan Info ARM Max Life Interest Cap - Display field with KBYO rounding rules [KBYO.XD2625]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Info ARM Max Life Interest Cap - Display field with KBYO rounding rules")]
        public string MaxLifeInterestCapPercentUI { get => _maxLifeInterestCapPercentUI; set => SetField(ref _maxLifeInterestCapPercentUI, value); }
        private DirtyValue<decimal?> _miCoveragePercent;
        /// <summary>
        /// Insurance Mtg Ins Coverage Factor [430]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Insurance Mtg Ins Coverage Factor")]
        public decimal? MiCoveragePercent { get => _miCoveragePercent; set => SetField(ref _miCoveragePercent, value); }
        private DirtyValue<decimal?> _minimumAdvanceAmount;
        /// <summary>
        /// HELOC Min Advance Amt [1892]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Min Advance Amt")]
        public decimal? MinimumAdvanceAmount { get => _minimumAdvanceAmount; set => SetField(ref _minimumAdvanceAmount, value); }
        private DirtyValue<decimal?> _minimumAllowableApr;
        /// <summary>
        /// HELOC Max Allowable APR [1893]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HELOC Max Allowable APR")]
        public decimal? MinimumAllowableApr { get => _minimumAllowableApr; set => SetField(ref _minimumAllowableApr, value); }
        private DirtyValue<decimal?> _minimumDrawPeroidPaymentPercent;
        /// <summary>
        /// HELOC Minimum Draw Period Payment [HELOC.MinAdvPct]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HELOC Minimum Draw Period Payment")]
        public decimal? MinimumDrawPeroidPaymentPercent { get => _minimumDrawPeroidPaymentPercent; set => SetField(ref _minimumDrawPeroidPaymentPercent, value); }
        private DirtyValue<decimal?> _minimumPaymentAmount;
        /// <summary>
        /// HELOC Minimum Payment [1483]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Minimum Payment")]
        public decimal? MinimumPaymentAmount { get => _minimumPaymentAmount; set => SetField(ref _minimumPaymentAmount, value); }
        private DirtyValue<decimal?> _minimumPaymentLessThanAmount;
        /// <summary>
        /// HELOC Minimum Payment Less Than Amt [HELOC.MinPmtLessThanAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Minimum Payment Less Than Amt")]
        public decimal? MinimumPaymentLessThanAmount { get => _minimumPaymentLessThanAmount; set => SetField(ref _minimumPaymentLessThanAmount, value); }
        private DirtyValue<decimal?> _minimumPaymentPercent;
        /// <summary>
        /// HELOC Pymt Factor [1413]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HELOC Pymt Factor")]
        public decimal? MinimumPaymentPercent { get => _minimumPaymentPercent; set => SetField(ref _minimumPaymentPercent, value); }
        private DirtyValue<decimal?> _minimumPaymentUpbAmount;
        /// <summary>
        /// HELOC Minimum Payment UPB Amt [HELOC.MinPmtUnpdBalAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Minimum Payment UPB Amt")]
        public decimal? MinimumPaymentUpbAmount { get => _minimumPaymentUpbAmount; set => SetField(ref _minimumPaymentUpbAmount, value); }
        private DirtyValue<decimal?> _minimumPaymentUpbPercent;
        /// <summary>
        /// HELOC Min. Payment UPB [HELOC.MinPmtUPB]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HELOC Min. Payment UPB")]
        public decimal? MinimumPaymentUpbPercent { get => _minimumPaymentUpbPercent; set => SetField(ref _minimumPaymentUpbPercent, value); }
        private DirtyValue<decimal?> _minimumRepayPeriodPaymentPercent;
        /// <summary>
        /// HELOC Minimum Repay Period Payment [HELOC.MinRepmtPct]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HELOC Minimum Repay Period Payment")]
        public decimal? MinimumRepayPeriodPaymentPercent { get => _minimumRepayPeriodPaymentPercent; set => SetField(ref _minimumRepayPeriodPaymentPercent, value); }
        private DirtyValue<int?> _monthsAppliedToPrepaymentPenaltyFeeCount;
        /// <summary>
        /// REGZ Prepay Penalty Mths Applied To Prpymt Pnlty Fee [2829]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Prepay Penalty Mths Applied To Prpymt Pnlty Fee")]
        public int? MonthsAppliedToPrepaymentPenaltyFeeCount { get => _monthsAppliedToPrepaymentPenaltyFeeCount; set => SetField(ref _monthsAppliedToPrepaymentPenaltyFeeCount, value); }
        private DirtyValue<decimal?> _negativeAmortizationLimitPercent;
        /// <summary>
        /// Loan Info ARM Max Bal % [698]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Max Bal %")]
        public decimal? NegativeAmortizationLimitPercent { get => _negativeAmortizationLimitPercent; set => SetField(ref _negativeAmortizationLimitPercent, value); }
        private DirtyValue<decimal?> _netInitialAndFinal;
        /// <summary>
        /// NMLS Net (Initial and Final) [NMLS.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "NMLS Net (Initial and Final)")]
        public decimal? NetInitialAndFinal { get => _netInitialAndFinal; set => SetField(ref _netInitialAndFinal, value); }
        private DirtyValue<StringEnumValue<NmlsDocumentationType>> _nmlsDocumentationType;
        /// <summary>
        /// NMLS Documentation Type [NMLS.X3]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Documentation Type")]
        public StringEnumValue<NmlsDocumentationType> NmlsDocumentationType { get => _nmlsDocumentationType; set => SetField(ref _nmlsDocumentationType, value); }
        private DirtyValue<StringEnumValue<NmlsFirstMortgageType>> _nmlsFirstMortgageType;
        /// <summary>
        /// NMLS Residential First Mortgage Type [NMLS.X2]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Residential First Mortgage Type")]
        public StringEnumValue<NmlsFirstMortgageType> NmlsFirstMortgageType { get => _nmlsFirstMortgageType; set => SetField(ref _nmlsFirstMortgageType, value); }
        private DirtyValue<StringEnumValue<NmlsLienStatus>> _nmlsLienStatus;
        /// <summary>
        /// NMLS Trans Details Lien Status [NMLS.X17]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Trans Details Lien Status")]
        public StringEnumValue<NmlsLienStatus> NmlsLienStatus { get => _nmlsLienStatus; set => SetField(ref _nmlsLienStatus, value); }
        private DirtyValue<StringEnumValue<NmlsLoanType>> _nmlsLoanType;
        /// <summary>
        /// NMLS Loan Type [NMLS.X1]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Loan Type")]
        public StringEnumValue<NmlsLoanType> NmlsLoanType { get => _nmlsLoanType; set => SetField(ref _nmlsLoanType, value); }
        private DirtyValue<bool?> _nmlsOptionARMIndicator;
        /// <summary>
        /// NMLS Option ARM Indicator [NMLS.X4]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Option ARM Indicator", OptionsJson = "{\"true\":\"Option ARM\",\"false\":\"Not Option ARM\"}")]
        public bool? NmlsOptionARMIndicator { get => _nmlsOptionARMIndicator; set => SetField(ref _nmlsOptionARMIndicator, value); }
        private DirtyValue<bool?> _nmlsPiggyBackOrFundedHELOCIndicator;
        /// <summary>
        /// NMLS Piggyback or Funded HELOC Indicator [NMLS.X5]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Piggyback or Funded HELOC Indicator", OptionsJson = "{\"true\":\"Includes piggyback second or funded HELOC\",\"false\":\"Does not include piggyback second or funded HELOC\"}")]
        public bool? NmlsPiggyBackOrFundedHELOCIndicator { get => _nmlsPiggyBackOrFundedHELOCIndicator; set => SetField(ref _nmlsPiggyBackOrFundedHELOCIndicator, value); }
        private DirtyValue<StringEnumValue<NmlsProductionSoldToType>> _nmlsProductionSoldToType;
        /// <summary>
        /// NMLS Production Sold To [NMLS.X7]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Production Sold To")]
        public StringEnumValue<NmlsProductionSoldToType> NmlsProductionSoldToType { get => _nmlsProductionSoldToType; set => SetField(ref _nmlsProductionSoldToType, value); }
        private DirtyValue<StringEnumValue<NmlsPropertyType>> _nmlsPropertyType;
        /// <summary>
        /// NMLS Subject Property Type [NMLS.X16]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Subject Property Type")]
        public StringEnumValue<NmlsPropertyType> NmlsPropertyType { get => _nmlsPropertyType; set => SetField(ref _nmlsPropertyType, value); }
        private DirtyValue<StringEnumValue<NmlsRefinancePurposeType>> _nmlsRefinancePurposeType;
        /// <summary>
        /// NMLS Refinance Purpose [NMLS.X6]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Refinance Purpose")]
        public StringEnumValue<NmlsRefinancePurposeType> NmlsRefinancePurposeType { get => _nmlsRefinancePurposeType; set => SetField(ref _nmlsRefinancePurposeType, value); }
        private DirtyValue<StringEnumValue<NmlsReverseMortgageType>> _nmlsReverseMortgageType;
        /// <summary>
        /// NMLS Reverse Mortgage Type [NMLS.X10]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Reverse Mortgage Type")]
        public StringEnumValue<NmlsReverseMortgageType> NmlsReverseMortgageType { get => _nmlsReverseMortgageType; set => SetField(ref _nmlsReverseMortgageType, value); }
        private DirtyValue<bool?> _oralRequestForExtensionOfCreditIndicator;
        /// <summary>
        /// NMLS Oral Request for Extension of Credit [NMLS.X14]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Oral Request for Extension of Credit")]
        public bool? OralRequestForExtensionOfCreditIndicator { get => _oralRequestForExtensionOfCreditIndicator; set => SetField(ref _oralRequestForExtensionOfCreditIndicator, value); }
        private DirtyValue<decimal?> _overLimitCharge;
        /// <summary>
        /// HELOC Over Limit Charge [HELOC.OvrLmtChg]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Over Limit Charge")]
        public decimal? OverLimitCharge { get => _overLimitCharge; set => SetField(ref _overLimitCharge, value); }
        private DirtyValue<decimal?> _overLimitReturnCharge;
        /// <summary>
        /// HELOC Over Limit Return Charge [HELOC.OvrLmtRtnChg]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Over Limit Return Charge")]
        public decimal? OverLimitReturnCharge { get => _overLimitReturnCharge; set => SetField(ref _overLimitReturnCharge, value); }
        private DirtyValue<decimal?> _participationFees;
        /// <summary>
        /// HELOC Participation Fees: The total amount(s) payable at or before account opening for participation in an open-end credit plan. [HELOC.ParticipationFees]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Participation Fees: The total amount(s) payable at or before account opening for participation in an open-end credit plan.")]
        public decimal? ParticipationFees { get => _participationFees; set => SetField(ref _participationFees, value); }
        private DirtyValue<int?> _paymentAdjustmentDurationMonthsCount;
        /// <summary>
        /// Loan Info ARM Pymt Adj Period [690]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Pymt Adj Period")]
        public int? PaymentAdjustmentDurationMonthsCount { get => _paymentAdjustmentDurationMonthsCount; set => SetField(ref _paymentAdjustmentDurationMonthsCount, value); }
        private DirtyValue<decimal?> _paymentAdjustmentPeriodicCapPercent;
        /// <summary>
        /// Loan Info ARM Pymt Adj Cap [691]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Pymt Adj Cap")]
        public decimal? PaymentAdjustmentPeriodicCapPercent { get => _paymentAdjustmentPeriodicCapPercent; set => SetField(ref _paymentAdjustmentPeriodicCapPercent, value); }
        private DirtyValue<StringEnumValue<PaymentFrequencyType>> _paymentFrequencyType;
        /// <summary>
        /// Trans Details Amort Type Biweekly [423]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Amort Type Biweekly")]
        public StringEnumValue<PaymentFrequencyType> PaymentFrequencyType { get => _paymentFrequencyType; set => SetField(ref _paymentFrequencyType, value); }
        private DirtyList<PrepaymentPenalty> _prepaymentPenalties;
        /// <summary>
        /// LoanProductData PrepaymentPenalties
        /// </summary>
        public IList<PrepaymentPenalty> PrepaymentPenalties { get => GetField(ref _prepaymentPenalties); set => SetField(ref _prepaymentPenalties, value); }
        private DirtyValue<StringEnumValue<PrepaymentPenaltyBasedOn>> _prepaymentPenaltyBasedOn;
        /// <summary>
        /// Amount REGZ Prepayment Penalty Based On [2830]
        /// </summary>
        [LoanFieldProperty(Description = "Amount REGZ Prepayment Penalty Based On")]
        public StringEnumValue<PrepaymentPenaltyBasedOn> PrepaymentPenaltyBasedOn { get => _prepaymentPenaltyBasedOn; set => SetField(ref _prepaymentPenaltyBasedOn, value); }
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        /// <summary>
        /// Prepayment Penalty [675]
        /// </summary>
        [LoanFieldProperty(Description = "Prepayment Penalty")]
        public bool? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        /// <summary>
        /// REGZ Prepymt Penalty Prepymt as a % 1 [1948]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "REGZ Prepymt Penalty Prepymt as a % 1")]
        public decimal? PrepaymentPenaltyPercent { get => _prepaymentPenaltyPercent; set => SetField(ref _prepaymentPenaltyPercent, value); }
        private DirtyValue<int?> _prepaymentPenaltyTermMonthsCount;
        /// <summary>
        /// REGZ Prepymt Penalty Prepymt Period 1 [1947]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Prepymt Penalty Prepymt Period 1")]
        public int? PrepaymentPenaltyTermMonthsCount { get => _prepaymentPenaltyTermMonthsCount; set => SetField(ref _prepaymentPenaltyTermMonthsCount, value); }
        private DirtyValue<StringEnumValue<PrepaymentPenaltyVerbiage>> _prepaymentPenaltyVerbiage;
        /// <summary>
        /// Prepay Verbiage Type [Terms.PrepyVrbgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Prepay Verbiage Type")]
        public StringEnumValue<PrepaymentPenaltyVerbiage> PrepaymentPenaltyVerbiage { get => _prepaymentPenaltyVerbiage; set => SetField(ref _prepaymentPenaltyVerbiage, value); }
        private DirtyValue<string> _productName;
        /// <summary>
        /// Fannie Mae Product Name [MORNET.X66]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Fannie Mae Product Name")]
        public string ProductName { get => _productName; set => SetField(ref _productName, value); }
        private DirtyValue<decimal?> _qualifyingRatePercent;
        /// <summary>
        /// Trans Details Qual Rate [1014]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Qual Rate")]
        public decimal? QualifyingRatePercent { get => _qualifyingRatePercent; set => SetField(ref _qualifyingRatePercent, value); }
        private DirtyValue<int?> _rateAdjustmentDurationMonthsCount;
        /// <summary>
        /// Loan Info ARM Rate Adj Period [694]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Rate Adj Period")]
        public int? RateAdjustmentDurationMonthsCount { get => _rateAdjustmentDurationMonthsCount; set => SetField(ref _rateAdjustmentDurationMonthsCount, value); }
        private DirtyValue<decimal?> _rateAdjustmentLifetimeCapPercent;
        /// <summary>
        /// Loan Info ARM Life Cap [247]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Life Cap")]
        public decimal? RateAdjustmentLifetimeCapPercent { get => _rateAdjustmentLifetimeCapPercent; set => SetField(ref _rateAdjustmentLifetimeCapPercent, value); }
        private DirtyValue<decimal?> _rateAdjustmentPercent;
        /// <summary>
        /// Loan Info ARM First Rate Adj Cap [697]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM First Rate Adj Cap")]
        public decimal? RateAdjustmentPercent { get => _rateAdjustmentPercent; set => SetField(ref _rateAdjustmentPercent, value); }
        private DirtyValue<string> _rateAdjustmentPercentUI;
        /// <summary>
        /// Loan Info ARM First Rate Adj Cap - Display fields with KBYO rounding rules [KBYO.XD697]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM First Rate Adj Cap - Display fields with KBYO rounding rules")]
        public string RateAdjustmentPercentUI { get => _rateAdjustmentPercentUI; set => SetField(ref _rateAdjustmentPercentUI, value); }
        private DirtyValue<decimal?> _rateAdjustmentSubsequentCapPercent;
        /// <summary>
        /// Loan Info ARM Rate Cap [695]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Rate Cap")]
        public decimal? RateAdjustmentSubsequentCapPercent { get => _rateAdjustmentSubsequentCapPercent; set => SetField(ref _rateAdjustmentSubsequentCapPercent, value); }
        private DirtyValue<string> _rateAdjustmentSubsequentCapPercentUI;
        /// <summary>
        /// Loan Info ARM Rate Cap - Display fields with KBYO rounding rules [KBYO.XD695]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Rate Cap - Display fields with KBYO rounding rules")]
        public string RateAdjustmentSubsequentCapPercentUI { get => _rateAdjustmentSubsequentCapPercentUI; set => SetField(ref _rateAdjustmentSubsequentCapPercentUI, value); }
        private DirtyValue<decimal?> _releaseRecoringCharge;
        /// <summary>
        /// HELOC Release Recording Charge [HELOC.RlsRecgChg]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Release Recording Charge")]
        public decimal? ReleaseRecoringCharge { get => _releaseRecoringCharge; set => SetField(ref _releaseRecoringCharge, value); }
        private DirtyValue<decimal?> _remainingBuydownAmount;
        /// <summary>
        /// Buydown Dsbmt Sum Total Subsidy Bal [3120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Buydown Dsbmt Sum Total Subsidy Bal")]
        public decimal? RemainingBuydownAmount { get => _remainingBuydownAmount; set => SetField(ref _remainingBuydownAmount, value); }
        private DirtyValue<int?> _repayPeriodMonthsCount;
        /// <summary>
        /// HELOC Repay Period Mos [1890]
        /// </summary>
        [LoanFieldProperty(Description = "HELOC Repay Period Mos")]
        public int? RepayPeriodMonthsCount { get => _repayPeriodMonthsCount; set => SetField(ref _repayPeriodMonthsCount, value); }
        private DirtyValue<decimal?> _returnedCheckCharge;
        /// <summary>
        /// HELOC Returned Check Charge Amt. [HELOC.RtdChkChgAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Returned Check Charge Amt.")]
        public decimal? ReturnedCheckCharge { get => _returnedCheckCharge; set => SetField(ref _returnedCheckCharge, value); }
        private DirtyValue<decimal?> _returnedCheckChargeRatePercent;
        /// <summary>
        /// HELOC Returned Check Charge Rate [HELOC.RtdChkChgRat]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HELOC Returned Check Charge Rate")]
        public decimal? ReturnedCheckChargeRatePercent { get => _returnedCheckChargeRatePercent; set => SetField(ref _returnedCheckChargeRatePercent, value); }
        private DirtyValue<decimal?> _returnedCheckMaxCharge;
        /// <summary>
        /// HELOC Returned Check Charge Max. [HELOC.RtdChkChgMax]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Returned Check Charge Max.")]
        public decimal? ReturnedCheckMaxCharge { get => _returnedCheckMaxCharge; set => SetField(ref _returnedCheckMaxCharge, value); }
        private DirtyValue<decimal?> _returnedCheckMinCharge;
        /// <summary>
        /// HELOC Returned Check Charge Min. [HELOC.RtdChkChgMin]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Returned Check Charge Min.")]
        public decimal? ReturnedCheckMinCharge { get => _returnedCheckMinCharge; set => SetField(ref _returnedCheckMinCharge, value); }
        private DirtyValue<decimal?> _roundPercent;
        /// <summary>
        /// Loan Info ARM Round Index To % [1700]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Round Index To %")]
        public decimal? RoundPercent { get => _roundPercent; set => SetField(ref _roundPercent, value); }
        private DirtyValue<StringEnumValue<RoundType>> _roundType;
        /// <summary>
        /// Loan Info ARM Round Index Up/Down [SYS.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Round Index Up/Down")]
        public StringEnumValue<RoundType> RoundType { get => _roundType; set => SetField(ref _roundType, value); }
        private DirtyValue<DateTime?> _scheduledFirstPaymentAdjustmentDate;
        /// <summary>
        /// Trans Details First Pymt Adj Date [3054]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details First Pymt Adj Date")]
        public DateTime? ScheduledFirstPaymentAdjustmentDate { get => _scheduledFirstPaymentAdjustmentDate; set => SetField(ref _scheduledFirstPaymentAdjustmentDate, value); }
        private DirtyValue<DateTime?> _scheduledFirstPaymentDate;
        /// <summary>
        /// Trans Details First Pymt Date [682]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details First Pymt Date")]
        public DateTime? ScheduledFirstPaymentDate { get => _scheduledFirstPaymentDate; set => SetField(ref _scheduledFirstPaymentDate, value); }
        private DirtyValue<decimal?> _stopPaymentCharge;
        /// <summary>
        /// HELOC Stop Payment Charge [HELOC.StopPmtChrg]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Stop Payment Charge")]
        public decimal? StopPaymentCharge { get => _stopPaymentCharge; set => SetField(ref _stopPaymentCharge, value); }
        private DirtyValue<int?> _subsequentRateAdjustmentMonthsCount;
        /// <summary>
        /// Loan Info ARM First Period Change [696]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM First Period Change")]
        public int? SubsequentRateAdjustmentMonthsCount { get => _subsequentRateAdjustmentMonthsCount; set => SetField(ref _subsequentRateAdjustmentMonthsCount, value); }
        private DirtyValue<decimal?> _terminationFeeAmount;
        /// <summary>
        /// HELOC Termination Fee [1986]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Termination Fee")]
        public decimal? TerminationFeeAmount { get => _terminationFeeAmount; set => SetField(ref _terminationFeeAmount, value); }
        private DirtyValue<int?> _terminationPeriodMonthsCount;
        /// <summary>
        /// HELOC Termination Fee Mos [1987]
        /// </summary>
        [LoanFieldProperty(Description = "HELOC Termination Fee Mos")]
        public int? TerminationPeriodMonthsCount { get => _terminationPeriodMonthsCount; set => SetField(ref _terminationPeriodMonthsCount, value); }
        private DirtyValue<decimal?> _thirdPartyFeeFromAmount;
        /// <summary>
        /// HELOC Third Party Fees Range - From [1965]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Third Party Fees Range - From")]
        public decimal? ThirdPartyFeeFromAmount { get => _thirdPartyFeeFromAmount; set => SetField(ref _thirdPartyFeeFromAmount, value); }
        private DirtyValue<decimal?> _thirdPartyFeeToAmount;
        /// <summary>
        /// HELOC Third Party Fees Range - To [1966]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Third Party Fees Range - To")]
        public decimal? ThirdPartyFeeToAmount { get => _thirdPartyFeeToAmount; set => SetField(ref _thirdPartyFeeToAmount, value); }
        private DirtyValue<decimal?> _timelyPaymentRateReductionPercent;
        /// <summary>
        /// Loan Info Timely Payment Reduction Percent [2634]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info Timely Payment Reduction Percent")]
        public decimal? TimelyPaymentRateReductionPercent { get => _timelyPaymentRateReductionPercent; set => SetField(ref _timelyPaymentRateReductionPercent, value); }
        private DirtyValue<StringEnumValue<TimelyPaymentRewards>> _timelyPaymentRewards;
        /// <summary>
        /// Loan Info Timely Payment Rewards [2633]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Timely Payment Rewards")]
        public StringEnumValue<TimelyPaymentRewards> TimelyPaymentRewards { get => _timelyPaymentRewards; set => SetField(ref _timelyPaymentRewards, value); }
        private DirtyValue<decimal?> _totalSubsidyAmount;
        /// <summary>
        /// Buydown Dsbmt Sum Tot. Subsidy Amt [3119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Buydown Dsbmt Sum Tot. Subsidy Amt")]
        public decimal? TotalSubsidyAmount { get => _totalSubsidyAmount; set => SetField(ref _totalSubsidyAmount, value); }
        private DirtyValue<decimal?> _transactionFees;
        /// <summary>
        /// HELOC Transaction Fees: The total amount of fees charged each time a withdrawal or other specified transaction is made on a line of credit, such as a balance transfer fee or a cash advance fee. [HELOC.TransactionFees]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Transaction Fees: The total amount of fees charged each time a withdrawal or other specified transaction is made on a line of credit, such as a balance transfer fee or a cash advance fee.")]
        public decimal? TransactionFees { get => _transactionFees; set => SetField(ref _transactionFees, value); }
        private DirtyValue<decimal?> _wireFee;
        /// <summary>
        /// HELOC Wire Fee [HELOC.WireFee]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HELOC Wire Fee")]
        public decimal? WireFee { get => _wireFee; set => SetField(ref _wireFee, value); }
    }
}