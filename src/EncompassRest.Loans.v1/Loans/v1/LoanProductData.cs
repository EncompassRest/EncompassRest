using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanProductData
/// </summary>
public sealed partial class LoanProductData : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _agreementAmmendsRestatesIndicator;
    private DirtyValue<decimal?>? _amountApplyToDownPayment;
    private DirtyValue<decimal?>? _annualFeeNeededAmount;
    private DirtyValue<bool?>? _applyLifeCapLowIndicator;
    private DirtyValue<StringEnumValue<IndexMargin>>? _armDisclosureType;
    private DirtyValue<StringEnumValue<ArmIndexType>>? _armIndexType;
    private DirtyValue<bool?>? _balloonIndicator;
    private DirtyValue<int?>? _balloonLoanMaturityTermMonthsCount;
    private DirtyValue<DateTime?>? _borrowerEstimatedClosingDate;
    private DirtyValue<string?>? _branchLocationNmlsId;
    private DirtyValue<string?>? _branchManagerNmlsId;
    private DirtyList<Buydown>? _buydowns;
    private DirtyValue<bool?>? _convertibleIndicator;
    private DirtyValue<StringEnumValue<IsOrIsNot>>? _discounted;
    private DirtyValue<decimal?>? _discountedRate;
    private DirtyValue<int?>? _drawPeriodMonthsCount;
    private DirtyValue<bool?>? _escrowWaiverIndicator;
    private DirtyValue<bool?>? _excludeLoanFromNMLSReportIndicator;
    private DirtyValue<StringEnumValue<FloorBasis>>? _floorBasis;
    private DirtyValue<decimal?>? _floorPercent;
    private DirtyValue<string?>? _floorPercentUI;
    private DirtyValue<StringEnumValue<FloorVerbiage>>? _floorVerbiage;
    private DirtyValue<string?>? _fnmProductPlanIdentifier;
    private DirtyValue<StringEnumValue<FreddieMacArmIndexType>>? _freddieMacArmIndexType;
    private DirtyValue<StringEnumValue<FreOfferingIdentifier>>? _freOfferingIdentifier;
    private DirtyValue<StringEnumValue<FullPrepaymentPenaltyOptionType>>? _fullPrepaymentPenaltyOptionType;
    private DirtyValue<StringEnumValue<ProjectType>>? _gseProjectClassificationType;
    private DirtyValue<StringEnumValue<PropertyType>>? _gsePropertyType;
    private DirtyValue<int?>? _hardPrepaymentPenaltyMonths;
    private DirtyValue<decimal?>? _helocAutoDebitDiscount;
    private DirtyValue<bool?>? _helocAutoDebitFeature;
    private DirtyValue<StringEnumValue<HelocCalcSign>>? _helocCalcSign;
    private DirtyValue<bool?>? _helocCollectInterimInterestIndicator;
    private DirtyValue<decimal?>? _helocDailyPeriodicRate;
    private DirtyValue<int?>? _helocDrawExtensionMonths;
    private DirtyValue<int?>? _helocDrawFractionBalancedividend;
    private DirtyValue<int?>? _helocDrawFractionBalancedivisor;
    private DirtyValue<bool?>? _helocDrawPaymentBasis;
    private DirtyValue<StringEnumValue<PaymentBasisType>>? _helocDrawPaymentBasisType;
    private DirtyValue<bool?>? _helocEscrowAccountIndicator;
    private DirtyValue<bool?>? _helocForceMinimumPayment;
    private DirtyValue<int?>? _helocFractionBalancedividend;
    private DirtyValue<int?>? _helocFractionBalancedivisor;
    private DirtyList<HelocHistoricalIndexYearSetting>? _helocHistoricalIndexYearSettings;
    private DirtyValue<int?>? _helocHistoricalTableDayIndex;
    private DirtyValue<decimal?>? _helocHistoricalTableDefaultMargin;
    private DirtyValue<int?>? _helocHistoricalTableMonthIndex;
    private DirtyValue<string?>? _helocHistoricalTableName;
    private DirtyValue<StringEnumValue<HelocBalance>>? _helocInitialBalanceUsed;
    private DirtyValue<StringEnumValue<HelocCalcSign>>? _helocInitialCalcSign;
    private DirtyValue<bool?>? _helocInitialForceMinimumPayment;
    private DirtyValue<int?>? _helocInitialFractionBalancedividend;
    private DirtyValue<int?>? _helocInitialFractionBalancedivisor;
    private DirtyValue<StringEnumValue<HelocPaymentBasis>>? _helocInitialPaymentBasis;
    private DirtyValue<StringEnumValue<PaymentBasisType>>? _helocInitialPaymentBasisType;
    private DirtyValue<decimal?>? _helocInitialPercent;
    private DirtyValue<decimal?>? _helocInitialPercentageofBalance;
    private DirtyValue<bool?>? _helocInitialPI;
    private DirtyValue<StringEnumValue<HelocInitialRate>>? _helocInitialRate;
    private DirtyValue<int?>? _helocInitialTerm;
    private DirtyValue<StringEnumValue<PerDiemCalculationMethodType>>? _helocInitPerDiemCalculationMethodType;
    private DirtyValue<decimal?>? _helocInstallmentLoanAPR;
    private DirtyValue<decimal?>? _helocInstallmentLoanFinanceCharge;
    private DirtyValue<decimal?>? _helocInstallmentLoanMargin;
    private DirtyValue<decimal?>? _helocInstallmentLoanMaxAPR;
    private DirtyValue<decimal?>? _helocInstallmentLoanMinAPR;
    private DirtyValue<bool?>? _helocInstallmentLoanOptionIndicator;
    private DirtyValue<int?>? _helocInstallmentLoanTermYearFrom;
    private DirtyValue<int?>? _helocInstallmentLoanTermYearTo;
    private DirtyValue<bool?>? _helocInterestOnly;
    private DirtyValue<StringEnumValue<LienPosition>>? _hELOCLienPosition;
    private DirtyValue<int?>? _helocMaxOpenInstallmentLoans;
    private DirtyValue<decimal?>? _helocMinimumInitialAdvancePercent;
    private DirtyValue<bool?>? _helocMinimumInitialAdvanceRequiredIndicator;
    private DirtyValue<decimal?>? _helocMinimumSubsequentAdvanceAmount;
    private DirtyValue<decimal?>? _helocMinimumSubsequentAdvancePercent;
    private DirtyValue<decimal?>? _helocMinInstallmentLoanAmount;
    private DirtyValue<decimal?>? _helocMonthlyPeriodicRate;
    private DirtyValue<decimal?>? _helocNewFinancingNotLinkedCreditLimit;
    private DirtyValue<decimal?>? _helocNewFinancingNotLinkedDrawAmount;
    private DirtyValue<decimal?>? _helocPaperBillingFee;
    private DirtyValue<StringEnumValue<HelocPaymentBasis>>? _helocPaymentBasis;
    private DirtyValue<StringEnumValue<PaymentBasisType>>? _helocPaymentBasisType;
    private DirtyValue<decimal?>? _helocPercent;
    private DirtyValue<decimal?>? _helocPercentageofBalance;
    private DirtyValue<StringEnumValue<HelocPeriodicRateIndicator>>? _helocPeriodicRateIndicator;
    private DirtyValue<string?>? _helocPeriodTemplateName;
    private DirtyValue<decimal?>? _helocPhotocopyFee;
    private DirtyValue<bool?>? _helocPropertyInsuranceIndicator;
    private DirtyValue<StringEnumValue<HelocBalance>>? _helocQualifyingBalance;
    private DirtyValue<int?>? _helocQualifyingTerm;
    private DirtyValue<StringEnumValue<HelocRate>>? _helocRate;
    private DirtyValue<string?>? _helocRefundableFee;
    private DirtyValue<bool?>? _helocRepaymentBasis;
    private DirtyValue<StringEnumValue<PaymentBasisType>>? _helocRepaymentBasisType;
    private DirtyList<HelocRepaymentDrawPeriod>? _helocRepaymentDrawPeriods;
    private DirtyValue<int?>? _helocRepaymentFractionBalancedividend;
    private DirtyValue<int?>? _helocRepaymentFractionBalancedivisor;
    private DirtyValue<bool?>? _helocRepaymentInterestOnlyIndicator;
    private DirtyValue<decimal?>? _helocRepaymentMinPayment;
    private DirtyValue<decimal?>? _helocResearchFee;
    private DirtyValue<bool?>? _helocStandardHistoricalTableIndicator;
    private DirtyValue<bool?>? _helocTAALNonDepositoryIndicator;
    private DirtyValue<StringEnumValue<HelocTAAPPChangeOption>>? _helocTAAPPChangeOption;
    private DirtyValue<StringEnumValue<HelocTAAPPRoundingOption>>? _helocTAAPPRoundingOption;
    private DirtyValue<decimal?>? _helocTAAPRCharged;
    private DirtyValue<bool?>? _helocTACreditCardIndicator;
    private DirtyValue<string?>? _helocTACreditCardMisuseNotificationAddr;
    private DirtyValue<string?>? _helocTACreditCardMisuseNotificationEmailAddr;
    private DirtyValue<string?>? _helocTACreditCardMisuseNotificationPhoneNumber;
    private DirtyValue<string?>? _helocTACreditCardMisuseNotificationWebAddr;
    private DirtyValue<StringEnumValue<HelocTADailyBalanceType>>? _helocTADailyBalanceType;
    private DirtyValue<StringEnumValue<HelocTADailyRateRoundingOption>>? _helocTADailyRateRoundingOption;
    private DirtyValue<StringEnumValue<HelocTADrawCheckIndicator>>? _helocTADrawCheckIndicator;
    private DirtyValue<string?>? _helocTAFeesCharged;
    private DirtyValue<StringEnumValue<HelocTAIndexRefDateOption>>? _helocTAIndexRefDateOption;
    private DirtyValue<StringEnumValue<HelocTAInstallmentIndexRefDateOption>>? _helocTAInstallmentIndexRefDateOption;
    private DirtyValue<bool?>? _helocTAInstallmentLoanDiscountedAPRIndicator;
    private DirtyValue<string?>? _helocTAInstallmentLoanDiscountWord;
    private DirtyValue<string?>? _helocTAInstallmentLoanPaymentAppliedMethod;
    private DirtyValue<decimal?>? _helocTAInstallmentLoanPeriodicRateRoundingPercent;
    private DirtyValue<string?>? _helocTAInstallmentLoanTerminationMethod;
    private DirtyValue<StringEnumValue<HelocTAIntroRateAppliedOn>>? _helocTAIntroRateAppliedOn;
    private DirtyValue<string?>? _helocTALenderToPay3rdPartyCost;
    private DirtyValue<bool?>? _helocTAOverdraftProtectionIndicator;
    private DirtyValue<StringEnumValue<HelocTAOverLimitChargeOption>>? _helocTAOverLimitChargeOption;
    private DirtyValue<bool?>? _helocTAPeriodicCapAppliedToAdvancePeriod;
    private DirtyValue<bool?>? _helocTAPeriodicCapAppliedToRepaymentPeriod;
    private DirtyValue<StringEnumValue<HelocTAPeriodicRateAdjDayOption>>? _helocTAPeriodicRateAdjDayOption;
    private DirtyValue<StringEnumValue<HelocTARepaymentTermEndBy>>? _helocTARepaymentTermEndBy;
    private DirtyValue<bool?>? _helocTARequestAdvanceInPersonIndicator;
    private DirtyValue<string?>? _helocTARequestAdvanceInPersonLocation;
    private DirtyValue<bool?>? _helocTARequestAdvanceViaInternetIndicator;
    private DirtyValue<string?>? _helocTARequestAdvanceViaInternetURL;
    private DirtyValue<bool?>? _helocTARequestByPhoneIndicator;
    private DirtyValue<bool?>? _helocTARequireRepayIndicator;
    private DirtyValue<bool?>? _helocTARightToSetoffIndicator;
    private DirtyValue<bool?>? _helocTAWrittenAuthorizationIndicator;
    private DirtyValue<string?>? _id;
    private DirtyValue<decimal?>? _indexCurrentValuePercent;
    private DirtyValue<StringEnumValue<IndexLookbackPeriod>>? _indexLookbackPeriod;
    private DirtyValue<decimal?>? _indexMarginPercent;
    private DirtyValue<string?>? _indexMarginPercentUI;
    private DirtyValue<decimal?>? _initialAdvanceAmount;
    private DirtyValue<decimal?>? _initialApplicationAmount;
    private DirtyValue<bool?>? _inquiryOrPreQualificationIndicator;
    private DirtyValue<string?>? _lenderRepresentative;
    private DirtyValue<string?>? _lenderRepresentativeCellPhone;
    private DirtyValue<string?>? _lenderRepresentativeEmailAddress;
    private DirtyValue<string?>? _lenderRepresentativeFirstLastName;
    private DirtyValue<string?>? _lenderRepresentativeJobTitle;
    private DirtyValue<string?>? _lenderRepresentativeRoleId;
    private DirtyValue<string?>? _lenderRepresentativeUserId;
    private DirtyValue<string?>? _lenderRepresentativeUserType;
    private DirtyValue<string?>? _lenderRepresentativeWorkPhone;
    private DirtyValue<StringEnumValue<LienType>>? _lienPriorityType;
    private DirtyValue<StringEnumValue<LoanDocumentationType>>? _loanDocumentationType;
    private DirtyValue<StringEnumValue<LoanRepaymentType>>? _loanRepaymentType;
    private DirtyValue<DateTime?>? _loanScheduledClosingDate;
    private DirtyValue<decimal?>? _maximumMonthlyPayment;
    private DirtyValue<decimal?>? _maxLifeInterestCapPercent;
    private DirtyValue<string?>? _maxLifeInterestCapPercentUI;
    private DirtyValue<decimal?>? _miCoveragePercent;
    private DirtyValue<decimal?>? _minimumAdvanceAmount;
    private DirtyValue<decimal?>? _minimumAllowableApr;
    private DirtyValue<decimal?>? _minimumDrawPeroidPaymentPercent;
    private DirtyValue<decimal?>? _minimumPaymentAmount;
    private DirtyValue<decimal?>? _minimumPaymentLessThanAmount;
    private DirtyValue<decimal?>? _minimumPaymentPercent;
    private DirtyValue<decimal?>? _minimumPaymentUpbAmount;
    private DirtyValue<decimal?>? _minimumPaymentUpbPercent;
    private DirtyValue<decimal?>? _minimumRepayPeriodPaymentPercent;
    private DirtyValue<int?>? _monthsAppliedToPrepaymentPenaltyFeeCount;
    private DirtyValue<decimal?>? _negativeAmortizationLimitPercent;
    private DirtyValue<decimal?>? _netInitialAndFinal;
    private DirtyValue<StringEnumValue<NmlsDocumentationType>>? _nmlsDocumentationType;
    private DirtyValue<StringEnumValue<NmlsFirstMortgageType>>? _nmlsFirstMortgageType;
    private DirtyValue<StringEnumValue<LienStatus>>? _nmlsLienStatus;
    private DirtyValue<StringEnumValue<NmlsLoanType>>? _nmlsLoanType;
    private DirtyValue<bool?>? _nmlsOptionARMIndicator;
    private DirtyValue<bool?>? _nmlsPiggyBackOrFundedHELOCIndicator;
    private DirtyValue<StringEnumValue<NmlsProductionSoldToType>>? _nmlsProductionSoldToType;
    private DirtyValue<StringEnumValue<HmdaPropertyType>>? _nmlsPropertyType;
    private DirtyValue<StringEnumValue<NmlsRefinancePurposeType>>? _nmlsRefinancePurposeType;
    private DirtyValue<StringEnumValue<NmlsReverseMortgageType>>? _nmlsReverseMortgageType;
    private DirtyValue<bool?>? _oralRequestForExtensionOfCreditIndicator;
    private DirtyValue<decimal?>? _overLimitCharge;
    private DirtyValue<decimal?>? _overLimitReturnCharge;
    private DirtyValue<decimal?>? _participationFees;
    private DirtyValue<int?>? _paymentAdjustmentDurationMonthsCount;
    private DirtyValue<decimal?>? _paymentAdjustmentPeriodicCapPercent;
    private DirtyValue<StringEnumValue<PaymentFrequencyType>>? _paymentFrequencyType;
    private DirtyList<PrepaymentPenalty>? _prepaymentPenalties;
    private DirtyValue<StringEnumValue<PrepaymentPenaltyBasedOn>>? _prepaymentPenaltyBasedOn;
    private DirtyValue<bool?>? _prepaymentPenaltyIndicator;
    private DirtyValue<decimal?>? _prepaymentPenaltyPercent;
    private DirtyValue<int?>? _prepaymentPenaltyTermMonthsCount;
    private DirtyValue<StringEnumValue<PrepaymentPenaltyVerbiage>>? _prepaymentPenaltyVerbiage;
    private DirtyValue<string?>? _productName;
    private DirtyValue<decimal?>? _qualifyingRatePercent;
    private DirtyValue<int?>? _rateAdjustmentDurationMonthsCount;
    private DirtyValue<decimal?>? _rateAdjustmentLifetimeCapPercent;
    private DirtyValue<decimal?>? _rateAdjustmentPercent;
    private DirtyValue<string?>? _rateAdjustmentPercentUI;
    private DirtyValue<decimal?>? _rateAdjustmentSubsequentCapPercent;
    private DirtyValue<string?>? _rateAdjustmentSubsequentCapPercentUI;
    private DirtyValue<decimal?>? _releaseRecoringCharge;
    private DirtyValue<decimal?>? _remainingBuydownAmount;
    private DirtyValue<int?>? _repayPeriodMonthsCount;
    private DirtyValue<decimal?>? _returnedCheckCharge;
    private DirtyValue<decimal?>? _returnedCheckChargeRatePercent;
    private DirtyValue<decimal?>? _returnedCheckMaxCharge;
    private DirtyValue<decimal?>? _returnedCheckMinCharge;
    private DirtyValue<decimal?>? _roundPercent;
    private DirtyValue<StringEnumValue<RoundType>>? _roundType;
    private DirtyValue<DateTime?>? _scheduledFirstPaymentAdjustmentDate;
    private DirtyValue<DateTime?>? _scheduledFirstPaymentDate;
    private DirtyValue<decimal?>? _stopPaymentCharge;
    private DirtyValue<int?>? _subsequentRateAdjustmentMonthsCount;
    private DirtyValue<decimal?>? _terminationFeeAmount;
    private DirtyValue<int?>? _terminationPeriodMonthsCount;
    private DirtyValue<decimal?>? _thirdPartyFeeFromAmount;
    private DirtyValue<decimal?>? _thirdPartyFeeToAmount;
    private DirtyValue<decimal?>? _timelyPaymentRateReductionPercent;
    private DirtyValue<StringEnumValue<TimelyPaymentRewards>>? _timelyPaymentRewards;
    private DirtyValue<decimal?>? _totalSubsidyAmount;
    private DirtyValue<decimal?>? _transactionFees;
    private DirtyValue<decimal?>? _wireFee;

    /// <summary>
    /// HELOC Agreement Amends and Restates Indicator [4671]
    /// </summary>
    public bool? AgreementAmmendsRestatesIndicator { get => _agreementAmmendsRestatesIndicator; set => SetField(ref _agreementAmmendsRestatesIndicator, value); }

    /// <summary>
    /// HELOC Amount Apply To Down Payment [4493]
    /// </summary>
    public decimal? AmountApplyToDownPayment { get => _amountApplyToDownPayment; set => SetField(ref _amountApplyToDownPayment, value); }

    /// <summary>
    /// HELOC Annual Fee [1891]
    /// </summary>
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
    public string? BranchLocationNmlsId { get => _branchLocationNmlsId; set => SetField(ref _branchLocationNmlsId, value); }

    /// <summary>
    /// NMLS Branch Manager NMLS ID [NMLS.X8]
    /// </summary>
    public string? BranchManagerNmlsId { get => _branchManagerNmlsId; set => SetField(ref _branchManagerNmlsId, value); }

    /// <summary>
    /// LoanProductData Buydowns
    /// </summary>
    [AllowNull]
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
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Escrow will be waived\"}")]
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
    public string? FloorPercentUI { get => _floorPercentUI; set => SetField(ref _floorPercentUI, value); }

    /// <summary>
    /// ARM Floor Verbiage Type [ARM.FlrVerbgTyp]
    /// </summary>
    public StringEnumValue<FloorVerbiage> FloorVerbiage { get => _floorVerbiage; set => SetField(ref _floorVerbiage, value); }

    /// <summary>
    /// Trans Details Amort Type ARM Descr [995]
    /// </summary>
    public string? FnmProductPlanIdentifier { get => _fnmProductPlanIdentifier; set => SetField(ref _fnmProductPlanIdentifier, value); }

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
    [LoanFieldProperty(OptionsJson = "{\"A_IIICondominium\":\"Freddie Mac: Streamlined Review\",\"B_IICondominium\":\"Freddie Mac: Established Project\",\"C_ICondominium\":\"Freddie Mac: New Project\",\"DetachedProject\":\"Freddie Mac: Detached Project\",\"2To4UnitProject\":\"Freddie Mac: 2-To-4-Unit Project\",\"ReciprocalReview\":\"Freddie Mac: Reciprocal Review\",\"E_PUD\":\"Fannie Mae: E Established PUD Project\",\"F_PUD\":\"Fannie Mae: F New PUD Project\",\"P_LimitedReviewNew\":\"Fannie Mae: P Limited Review - New Condo Project\",\"Q_LimitedReviewEst\":\"Fannie Mae: Q Limited Review - Established Condo Project\",\"R_ExpeditedNew\":\"Fannie Mae: R Full Review - New Condo Project\",\"S_ExpeditedEst\":\"Fannie Mae: S Full Review - Established Condo Project\",\"T_FannieMaeReview\":\"Fannie Mae: T Fannie Mae Review through PERS - Condo Project\",\"U_FHAapproved\":\"Fannie Mae: U FHA-approved Condo Project\",\"V_NoReviewSiteCondo\":\"Fannie Mae: V Condo Project Review Waived\",\"OneCooperative\":\"Other: One Cooperative\",\"TwoCooperative\":\"Other: Two Cooperative\",\"TCooperative\":\"Other: T Cooperative\",\"T_PUD\":\"Other: T/PUD\",\"III PUD\":\"Other: PUD\",\"V_RefiPlus\":\"Other: V/Refi Plus\",\"Approved FHA/VA Condominium Project Or Spot Loan\":\"Other: Approved FHA/VA Condominium Project Or Spot Loan\",\"G_NotInAProjectOrDevelopment\":\"Other: G/Not in a Project or Development\"}")]
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
    /// HELOC Auto Debit Discount Percent [4587]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocAutoDebitDiscount { get => _helocAutoDebitDiscount; set => SetField(ref _helocAutoDebitDiscount, value); }

    /// <summary>
    /// HELOC Auto Debit Feature [4586]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Auto Debit Feature\"}")]
    public bool? HelocAutoDebitFeature { get => _helocAutoDebitFeature; set => SetField(ref _helocAutoDebitFeature, value); }

    /// <summary>
    /// HELOC Calculation Sign [4466]
    /// </summary>
    public StringEnumValue<HelocCalcSign> HelocCalcSign { get => _helocCalcSign; set => SetField(ref _helocCalcSign, value); }

    /// <summary>
    /// Heloc Collect Interim Interest Indicator [4665]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Collect Interim Interest\"}")]
    public bool? HelocCollectInterimInterestIndicator { get => _helocCollectInterimInterestIndicator; set => SetField(ref _helocCollectInterimInterestIndicator, value); }

    /// <summary>
    /// Daily Periodic Rate Percent [4549]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? HelocDailyPeriodicRate { get => _helocDailyPeriodicRate; set => SetField(ref _helocDailyPeriodicRate, value); }

    /// <summary>
    /// HELOC Draw Extension Months [4567]
    /// </summary>
    public int? HelocDrawExtensionMonths { get => _helocDrawExtensionMonths; set => SetField(ref _helocDrawExtensionMonths, value); }

    /// <summary>
    /// HELOC Draw Fraction Balance Dividend [4564]
    /// </summary>
    public int? HelocDrawFractionBalancedividend { get => _helocDrawFractionBalancedividend; set => SetField(ref _helocDrawFractionBalancedividend, value); }

    /// <summary>
    /// HELOC Draw Fraction Balance Divisor [4565]
    /// </summary>
    public int? HelocDrawFractionBalancedivisor { get => _helocDrawFractionBalancedivisor; set => SetField(ref _helocDrawFractionBalancedivisor, value); }

    /// <summary>
    /// HELOC Draw Payment Basis [4559]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Rate\"}")]
    public bool? HelocDrawPaymentBasis { get => _helocDrawPaymentBasis; set => SetField(ref _helocDrawPaymentBasis, value); }

    /// <summary>
    /// HELOC Draw Payment Basis Type [4560]
    /// </summary>
    public StringEnumValue<PaymentBasisType> HelocDrawPaymentBasisType { get => _helocDrawPaymentBasisType; set => SetField(ref _helocDrawPaymentBasisType, value); }

    /// <summary>
    /// Heloc Escrow Account Indicator [4556]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Escrow Account\"}")]
    public bool? HelocEscrowAccountIndicator { get => _helocEscrowAccountIndicator; set => SetField(ref _helocEscrowAccountIndicator, value); }

    /// <summary>
    /// HELOC Force Minimum Payment [4472]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Force Minimum Payment\"}")]
    public bool? HelocForceMinimumPayment { get => _helocForceMinimumPayment; set => SetField(ref _helocForceMinimumPayment, value); }

    /// <summary>
    /// HELOC Fraction Balance Dividend [4469]
    /// </summary>
    public int? HelocFractionBalancedividend { get => _helocFractionBalancedividend; set => SetField(ref _helocFractionBalancedividend, value); }

    /// <summary>
    /// HELOC Fraction Balance Divisor [4470]
    /// </summary>
    public int? HelocFractionBalancedivisor { get => _helocFractionBalancedivisor; set => SetField(ref _helocFractionBalancedivisor, value); }

    /// <summary>
    /// LoanProductData HelocHistoricalIndexYearSettings
    /// </summary>
    [AllowNull]
    public IList<HelocHistoricalIndexYearSetting> HelocHistoricalIndexYearSettings { get => GetField(ref _helocHistoricalIndexYearSettings); set => SetField(ref _helocHistoricalIndexYearSettings, value); }

    /// <summary>
    /// HELOC Historical Table Day Index [HHI.X1]
    /// </summary>
    public int? HelocHistoricalTableDayIndex { get => _helocHistoricalTableDayIndex; set => SetField(ref _helocHistoricalTableDayIndex, value); }

    /// <summary>
    /// HELOC Historical Table Default Margin [HHI.X3]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocHistoricalTableDefaultMargin { get => _helocHistoricalTableDefaultMargin; set => SetField(ref _helocHistoricalTableDefaultMargin, value); }

    /// <summary>
    /// HELOC Historical Table Month Index [HHI.X2]
    /// </summary>
    public int? HelocHistoricalTableMonthIndex { get => _helocHistoricalTableMonthIndex; set => SetField(ref _helocHistoricalTableMonthIndex, value); }

    /// <summary>
    /// HELOC Historical Table Name [4629]
    /// </summary>
    public string? HelocHistoricalTableName { get => _helocHistoricalTableName; set => SetField(ref _helocHistoricalTableName, value); }

    /// <summary>
    /// Heloc Initial Balance Used [4484]
    /// </summary>
    public StringEnumValue<HelocBalance> HelocInitialBalanceUsed { get => _helocInitialBalanceUsed; set => SetField(ref _helocInitialBalanceUsed, value); }

    /// <summary>
    /// HELOC Initial Calculation Sign [4477]
    /// </summary>
    public StringEnumValue<HelocCalcSign> HelocInitialCalcSign { get => _helocInitialCalcSign; set => SetField(ref _helocInitialCalcSign, value); }

    /// <summary>
    /// HELOC Initial Force Minimum Payment [4483]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Force Minimum Payment\"}")]
    public bool? HelocInitialForceMinimumPayment { get => _helocInitialForceMinimumPayment; set => SetField(ref _helocInitialForceMinimumPayment, value); }

    /// <summary>
    /// HELOC Initial Fraction Balance Dividend [4480]
    /// </summary>
    public int? HelocInitialFractionBalancedividend { get => _helocInitialFractionBalancedividend; set => SetField(ref _helocInitialFractionBalancedividend, value); }

    /// <summary>
    /// HELOC Initial Fraction Balance Divisor [4481]
    /// </summary>
    public int? HelocInitialFractionBalancedivisor { get => _helocInitialFractionBalancedivisor; set => SetField(ref _helocInitialFractionBalancedivisor, value); }

    /// <summary>
    /// HELOC Initial Payment Basis [4475]
    /// </summary>
    public StringEnumValue<HelocPaymentBasis> HelocInitialPaymentBasis { get => _helocInitialPaymentBasis; set => SetField(ref _helocInitialPaymentBasis, value); }

    /// <summary>
    /// HELOC Initial Payment Basis Type [4530]
    /// </summary>
    public StringEnumValue<PaymentBasisType> HelocInitialPaymentBasisType { get => _helocInitialPaymentBasisType; set => SetField(ref _helocInitialPaymentBasisType, value); }

    /// <summary>
    /// HELOC Initial Percent [4478]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInitialPercent { get => _helocInitialPercent; set => SetField(ref _helocInitialPercent, value); }

    /// <summary>
    /// HELOC Initial Percentage of Balance [4482]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInitialPercentageofBalance { get => _helocInitialPercentageofBalance; set => SetField(ref _helocInitialPercentageofBalance, value); }

    /// <summary>
    /// Heloc initial P &amp; I [4479]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"P & I\"}")]
    public bool? HelocInitialPI { get => _helocInitialPI; set => SetField(ref _helocInitialPI, value); }

    /// <summary>
    /// HELOC Initial Rate [4476]
    /// </summary>
    public StringEnumValue<HelocInitialRate> HelocInitialRate { get => _helocInitialRate; set => SetField(ref _helocInitialRate, value); }

    /// <summary>
    /// Heloc Initial Term [4485]
    /// </summary>
    public int? HelocInitialTerm { get => _helocInitialTerm; set => SetField(ref _helocInitialTerm, value); }

    /// <summary>
    /// HELOC Initial Mortgage Number of Days [4491]
    /// </summary>
    public StringEnumValue<PerDiemCalculationMethodType> HelocInitPerDiemCalculationMethodType { get => _helocInitPerDiemCalculationMethodType; set => SetField(ref _helocInitPerDiemCalculationMethodType, value); }

    /// <summary>
    /// HELOC Installment Loan APR [4585]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInstallmentLoanAPR { get => _helocInstallmentLoanAPR; set => SetField(ref _helocInstallmentLoanAPR, value); }

    /// <summary>
    /// HELOC Installment Loan Fincance Charge [4581]
    /// </summary>
    public decimal? HelocInstallmentLoanFinanceCharge { get => _helocInstallmentLoanFinanceCharge; set => SetField(ref _helocInstallmentLoanFinanceCharge, value); }

    /// <summary>
    /// HELOC Installment Loan Margin [4582]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInstallmentLoanMargin { get => _helocInstallmentLoanMargin; set => SetField(ref _helocInstallmentLoanMargin, value); }

    /// <summary>
    /// HELOC Installment Loan Max APR [4583]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInstallmentLoanMaxAPR { get => _helocInstallmentLoanMaxAPR; set => SetField(ref _helocInstallmentLoanMaxAPR, value); }

    /// <summary>
    /// HELOC Installment Loan Min APR [4584]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocInstallmentLoanMinAPR { get => _helocInstallmentLoanMinAPR; set => SetField(ref _helocInstallmentLoanMinAPR, value); }

    /// <summary>
    /// Heloc Installment Loan Option Indicator [4557]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Installment Loan Option\"}")]
    public bool? HelocInstallmentLoanOptionIndicator { get => _helocInstallmentLoanOptionIndicator; set => SetField(ref _helocInstallmentLoanOptionIndicator, value); }

    /// <summary>
    /// HELOC Installment Loan Term Year From [4579]
    /// </summary>
    public int? HelocInstallmentLoanTermYearFrom { get => _helocInstallmentLoanTermYearFrom; set => SetField(ref _helocInstallmentLoanTermYearFrom, value); }

    /// <summary>
    /// HELOC Installment Loan Term Year To [4580]
    /// </summary>
    public int? HelocInstallmentLoanTermYearTo { get => _helocInstallmentLoanTermYearTo; set => SetField(ref _helocInstallmentLoanTermYearTo, value); }

    /// <summary>
    /// Heloc Interest Only [4468]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Interest Only\"}")]
    public bool? HelocInterestOnly { get => _helocInterestOnly; set => SetField(ref _helocInterestOnly, value); }

    /// <summary>
    /// HELOC Lien Position [4494]
    /// </summary>
    public StringEnumValue<LienPosition> HELOCLienPosition { get => _hELOCLienPosition; set => SetField(ref _hELOCLienPosition, value); }

    /// <summary>
    /// HELOC Maximum Open Installment Loans [4578]
    /// </summary>
    public int? HelocMaxOpenInstallmentLoans { get => _helocMaxOpenInstallmentLoans; set => SetField(ref _helocMaxOpenInstallmentLoans, value); }

    /// <summary>
    /// HELOC Minimum Initial Advance Percent [4553]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocMinimumInitialAdvancePercent { get => _helocMinimumInitialAdvancePercent; set => SetField(ref _helocMinimumInitialAdvancePercent, value); }

    /// <summary>
    /// Heloc Minimum Initial Advance Required Indicator [4552]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Minimum Initial Advance Required\"}")]
    public bool? HelocMinimumInitialAdvanceRequiredIndicator { get => _helocMinimumInitialAdvanceRequiredIndicator; set => SetField(ref _helocMinimumInitialAdvanceRequiredIndicator, value); }

    /// <summary>
    /// HELOC Minimum Subsequent Advance Amount [4554]
    /// </summary>
    public decimal? HelocMinimumSubsequentAdvanceAmount { get => _helocMinimumSubsequentAdvanceAmount; set => SetField(ref _helocMinimumSubsequentAdvanceAmount, value); }

    /// <summary>
    /// HELOC Minimum Subsequent Advance Percent [4555]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocMinimumSubsequentAdvancePercent { get => _helocMinimumSubsequentAdvancePercent; set => SetField(ref _helocMinimumSubsequentAdvancePercent, value); }

    /// <summary>
    /// HELOC Minimum Installment Loan Amount [4577]
    /// </summary>
    public decimal? HelocMinInstallmentLoanAmount { get => _helocMinInstallmentLoanAmount; set => SetField(ref _helocMinInstallmentLoanAmount, value); }

    /// <summary>
    /// Monthly Periodic Rate Percent [4550]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_10)]
    public decimal? HelocMonthlyPeriodicRate { get => _helocMonthlyPeriodicRate; set => SetField(ref _helocMonthlyPeriodicRate, value); }

    /// <summary>
    /// Heloc New Financing Not Linked Credit Limit  [4490]
    /// </summary>
    public decimal? HelocNewFinancingNotLinkedCreditLimit { get => _helocNewFinancingNotLinkedCreditLimit; set => SetField(ref _helocNewFinancingNotLinkedCreditLimit, value); }

    /// <summary>
    /// Heloc New Financing Not Linked Draw Amount [4489]
    /// </summary>
    public decimal? HelocNewFinancingNotLinkedDrawAmount { get => _helocNewFinancingNotLinkedDrawAmount; set => SetField(ref _helocNewFinancingNotLinkedDrawAmount, value); }

    /// <summary>
    /// HELOC Paper Billing Fee [4588]
    /// </summary>
    public decimal? HelocPaperBillingFee { get => _helocPaperBillingFee; set => SetField(ref _helocPaperBillingFee, value); }

    /// <summary>
    /// HELOC Payment Basis [4464]
    /// </summary>
    public StringEnumValue<HelocPaymentBasis> HelocPaymentBasis { get => _helocPaymentBasis; set => SetField(ref _helocPaymentBasis, value); }

    /// <summary>
    /// HELOC Payment Basis Type [4531]
    /// </summary>
    public StringEnumValue<PaymentBasisType> HelocPaymentBasisType { get => _helocPaymentBasisType; set => SetField(ref _helocPaymentBasisType, value); }

    /// <summary>
    /// HELOC Percent [4467]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocPercent { get => _helocPercent; set => SetField(ref _helocPercent, value); }

    /// <summary>
    /// HELOC Percentage of Balance [4471]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocPercentageofBalance { get => _helocPercentageofBalance; set => SetField(ref _helocPercentageofBalance, value); }

    /// <summary>
    /// HELOC Periodic Rate Indicator [4551]
    /// </summary>
    public StringEnumValue<HelocPeriodicRateIndicator> HelocPeriodicRateIndicator { get => _helocPeriodicRateIndicator; set => SetField(ref _helocPeriodicRateIndicator, value); }

    /// <summary>
    /// HELOC Period Template Name [1985]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HelocPeriodTemplateName { get => _helocPeriodTemplateName; set => SetField(ref _helocPeriodTemplateName, value); }

    /// <summary>
    /// HELOC Photocopy Fee [4589]
    /// </summary>
    public decimal? HelocPhotocopyFee { get => _helocPhotocopyFee; set => SetField(ref _helocPhotocopyFee, value); }

    /// <summary>
    /// HELOC Heloc Property Insurance Indicator [4661]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Borrower can obtain property insurance from or through Lender\"}")]
    public bool? HelocPropertyInsuranceIndicator { get => _helocPropertyInsuranceIndicator; set => SetField(ref _helocPropertyInsuranceIndicator, value); }

    /// <summary>
    /// HELOC Qualifying Balance [4473]
    /// </summary>
    public StringEnumValue<HelocBalance> HelocQualifyingBalance { get => _helocQualifyingBalance; set => SetField(ref _helocQualifyingBalance, value); }

    /// <summary>
    /// HELOC Qualifying Term [4474]
    /// </summary>
    public int? HelocQualifyingTerm { get => _helocQualifyingTerm; set => SetField(ref _helocQualifyingTerm, value); }

    /// <summary>
    /// HELOC Rate [4465]
    /// </summary>
    public StringEnumValue<HelocRate> HelocRate { get => _helocRate; set => SetField(ref _helocRate, value); }

    /// <summary>
    /// HELOC Refundable Fee [4591]
    /// </summary>
    public string? HelocRefundableFee { get => _helocRefundableFee; set => SetField(ref _helocRefundableFee, value); }

    /// <summary>
    /// HELOC Repayment Basis [4568]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Rate\"}")]
    public bool? HelocRepaymentBasis { get => _helocRepaymentBasis; set => SetField(ref _helocRepaymentBasis, value); }

    /// <summary>
    /// HELOC Repayment Basis Type [4569]
    /// </summary>
    public StringEnumValue<PaymentBasisType> HelocRepaymentBasisType { get => _helocRepaymentBasisType; set => SetField(ref _helocRepaymentBasisType, value); }

    /// <summary>
    /// LoanProductData HelocRepaymentDrawPeriods
    /// </summary>
    [AllowNull]
    public IList<HelocRepaymentDrawPeriod> HelocRepaymentDrawPeriods { get => GetField(ref _helocRepaymentDrawPeriods); set => SetField(ref _helocRepaymentDrawPeriods, value); }

    /// <summary>
    /// HELOC Repayment Fraction Balance Dividend [4574]
    /// </summary>
    public int? HelocRepaymentFractionBalancedividend { get => _helocRepaymentFractionBalancedividend; set => SetField(ref _helocRepaymentFractionBalancedividend, value); }

    /// <summary>
    /// HELOC Repayment Fraction Balance Divisor [4575]
    /// </summary>
    public int? HelocRepaymentFractionBalancedivisor { get => _helocRepaymentFractionBalancedivisor; set => SetField(ref _helocRepaymentFractionBalancedivisor, value); }

    /// <summary>
    /// HELOC Repayment Interest Only Indicator [4573]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I/O\"}")]
    public bool? HelocRepaymentInterestOnlyIndicator { get => _helocRepaymentInterestOnlyIndicator; set => SetField(ref _helocRepaymentInterestOnlyIndicator, value); }

    /// <summary>
    /// HELOC Repayment Minimum Payment Amount [4576]
    /// </summary>
    public decimal? HelocRepaymentMinPayment { get => _helocRepaymentMinPayment; set => SetField(ref _helocRepaymentMinPayment, value); }

    /// <summary>
    /// HELOC Research Fee [4590]
    /// </summary>
    public decimal? HelocResearchFee { get => _helocResearchFee; set => SetField(ref _helocResearchFee, value); }

    /// <summary>
    /// HELOC Standard Historical Table Indicator [4630]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Standard Historical Table\"}")]
    public bool? HelocStandardHistoricalTableIndicator { get => _helocStandardHistoricalTableIndicator; set => SetField(ref _helocStandardHistoricalTableIndicator, value); }

    /// <summary>
    /// AL Non-Depository Institution [4624]
    /// </summary>
    public bool? HelocTAALNonDepositoryIndicator { get => _helocTAALNonDepositoryIndicator; set => SetField(ref _helocTAALNonDepositoryIndicator, value); }

    /// <summary>
    /// APR cannot [4611]
    /// </summary>
    public StringEnumValue<HelocTAAPPChangeOption> HelocTAAPPChangeOption { get => _helocTAAPPChangeOption; set => SetField(ref _helocTAAPPChangeOption, value); }

    /// <summary>
    /// Advance Period Payment Rounding options [4607]
    /// </summary>
    public StringEnumValue<HelocTAAPPRoundingOption> HelocTAAPPRoundingOption { get => _helocTAAPPRoundingOption; set => SetField(ref _helocTAAPPRoundingOption, value); }

    /// <summary>
    /// Recent APR lender has charged [4593]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocTAAPRCharged { get => _helocTAAPRCharged; set => SetField(ref _helocTAAPRCharged, value); }

    /// <summary>
    /// HELOC Draw Option: Credit Card [4601]
    /// </summary>
    public bool? HelocTACreditCardIndicator { get => _helocTACreditCardIndicator; set => SetField(ref _helocTACreditCardIndicator, value); }

    /// <summary>
    /// Unauthorized Use of Credit Card notification address [4625]
    /// </summary>
    public string? HelocTACreditCardMisuseNotificationAddr { get => _helocTACreditCardMisuseNotificationAddr; set => SetField(ref _helocTACreditCardMisuseNotificationAddr, value); }

    /// <summary>
    /// Unauthorized Use of Credit Card email address [4628]
    /// </summary>
    public string? HelocTACreditCardMisuseNotificationEmailAddr { get => _helocTACreditCardMisuseNotificationEmailAddr; set => SetField(ref _helocTACreditCardMisuseNotificationEmailAddr, value); }

    /// <summary>
    /// Unauthorized Use of Credit Card notification toll free phone number [4626]
    /// </summary>
    public string? HelocTACreditCardMisuseNotificationPhoneNumber { get => _helocTACreditCardMisuseNotificationPhoneNumber; set => SetField(ref _helocTACreditCardMisuseNotificationPhoneNumber, value); }

    /// <summary>
    /// Unauthorized Use of Credit Card web address [4627]
    /// </summary>
    public string? HelocTACreditCardMisuseNotificationWebAddr { get => _helocTACreditCardMisuseNotificationWebAddr; set => SetField(ref _helocTACreditCardMisuseNotificationWebAddr, value); }

    /// <summary>
    /// Finance charges on your Credit Account determined by applying [4608]
    /// </summary>
    public StringEnumValue<HelocTADailyBalanceType> HelocTADailyBalanceType { get => _helocTADailyBalanceType; set => SetField(ref _helocTADailyBalanceType, value); }

    /// <summary>
    /// Fixed daily periodic rate for Installment Loan rounding [4614]
    /// </summary>
    public StringEnumValue<HelocTADailyRateRoundingOption> HelocTADailyRateRoundingOption { get => _helocTADailyRateRoundingOption; set => SetField(ref _helocTADailyRateRoundingOption, value); }

    /// <summary>
    /// HELOC Draw Option: Draw Check or Draw Draft [4597]
    /// </summary>
    public StringEnumValue<HelocTADrawCheckIndicator> HelocTADrawCheckIndicator { get => _helocTADrawCheckIndicator; set => SetField(ref _helocTADrawCheckIndicator, value); }

    /// <summary>
    /// Fees charged to borrower to use the HELOC account (what and when) [4594]
    /// </summary>
    public string? HelocTAFeesCharged { get => _helocTAFeesCharged; set => SetField(ref _helocTAFeesCharged, value); }

    /// <summary>
    /// Index Reference date options [4609]
    /// </summary>
    public StringEnumValue<HelocTAIndexRefDateOption> HelocTAIndexRefDateOption { get => _helocTAIndexRefDateOption; set => SetField(ref _helocTAIndexRefDateOption, value); }

    /// <summary>
    /// Installment Loan Index Reference Date [4618]
    /// </summary>
    public StringEnumValue<HelocTAInstallmentIndexRefDateOption> HelocTAInstallmentIndexRefDateOption { get => _helocTAInstallmentIndexRefDateOption; set => SetField(ref _helocTAInstallmentIndexRefDateOption, value); }

    /// <summary>
    /// Installment loan discounted APR [4616]
    /// </summary>
    public bool? HelocTAInstallmentLoanDiscountedAPRIndicator { get => _helocTAInstallmentLoanDiscountedAPRIndicator; set => SetField(ref _helocTAInstallmentLoanDiscountedAPRIndicator, value); }

    /// <summary>
    /// Installment Loan - word to use to replace "discount" [4617]
    /// </summary>
    public string? HelocTAInstallmentLoanDiscountWord { get => _helocTAInstallmentLoanDiscountWord; set => SetField(ref _helocTAInstallmentLoanDiscountWord, value); }

    /// <summary>
    /// Installment loan payments applied method [4620]
    /// </summary>
    public string? HelocTAInstallmentLoanPaymentAppliedMethod { get => _helocTAInstallmentLoanPaymentAppliedMethod; set => SetField(ref _helocTAInstallmentLoanPaymentAppliedMethod, value); }

    /// <summary>
    /// Installment Loan Periodic Rate Rounding Percentage [4615]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HelocTAInstallmentLoanPeriodicRateRoundingPercent { get => _helocTAInstallmentLoanPeriodicRateRoundingPercent; set => SetField(ref _helocTAInstallmentLoanPeriodicRateRoundingPercent, value); }

    /// <summary>
    /// Installment Loan Termination Method [4619]
    /// </summary>
    public string? HelocTAInstallmentLoanTerminationMethod { get => _helocTAInstallmentLoanTerminationMethod; set => SetField(ref _helocTAInstallmentLoanTerminationMethod, value); }

    /// <summary>
    /// Intro Rate applied if monthly periodic rate is used [4595]
    /// </summary>
    public StringEnumValue<HelocTAIntroRateAppliedOn> HelocTAIntroRateAppliedOn { get => _helocTAIntroRateAppliedOn; set => SetField(ref _helocTAIntroRateAppliedOn, value); }

    /// <summary>
    /// Lender will pay the following third-party closing costs at closing [4622]
    /// </summary>
    public string? HelocTALenderToPay3rdPartyCost { get => _helocTALenderToPay3rdPartyCost; set => SetField(ref _helocTALenderToPay3rdPartyCost, value); }

    /// <summary>
    /// HELOC Draw Option: Overdraft Protection [4602]
    /// </summary>
    public bool? HelocTAOverdraftProtectionIndicator { get => _helocTAOverdraftProtectionIndicator; set => SetField(ref _helocTAOverdraftProtectionIndicator, value); }

    /// <summary>
    /// If charging an Over Limit charge choose an Over Limit Charge Imposed option [4596]
    /// </summary>
    public StringEnumValue<HelocTAOverLimitChargeOption> HelocTAOverLimitChargeOption { get => _helocTAOverLimitChargeOption; set => SetField(ref _helocTAOverLimitChargeOption, value); }

    /// <summary>
    /// Periodic Cap Applied to Advance Period [4612]
    /// </summary>
    public bool? HelocTAPeriodicCapAppliedToAdvancePeriod { get => _helocTAPeriodicCapAppliedToAdvancePeriod; set => SetField(ref _helocTAPeriodicCapAppliedToAdvancePeriod, value); }

    /// <summary>
    /// Periodic Cap Applied to Repayment Period [4613]
    /// </summary>
    public bool? HelocTAPeriodicCapAppliedToRepaymentPeriod { get => _helocTAPeriodicCapAppliedToRepaymentPeriod; set => SetField(ref _helocTAPeriodicCapAppliedToRepaymentPeriod, value); }

    /// <summary>
    /// Periodic Rate and APR Adjustments [4610]
    /// </summary>
    public StringEnumValue<HelocTAPeriodicRateAdjDayOption> HelocTAPeriodicRateAdjDayOption { get => _helocTAPeriodicRateAdjDayOption; set => SetField(ref _helocTAPeriodicRateAdjDayOption, value); }

    /// <summary>
    /// The fixed repayment term must be in one-year (12-month) increments, and may not end later than [4592]
    /// </summary>
    public StringEnumValue<HelocTARepaymentTermEndBy> HelocTARepaymentTermEndBy { get => _helocTARepaymentTermEndBy; set => SetField(ref _helocTARepaymentTermEndBy, value); }

    /// <summary>
    /// Request an Advance by Written Authorization: In Person [4603]
    /// </summary>
    public bool? HelocTARequestAdvanceInPersonIndicator { get => _helocTARequestAdvanceInPersonIndicator; set => SetField(ref _helocTARequestAdvanceInPersonIndicator, value); }

    /// <summary>
    /// Request an Advance by Written Authorization: In Person location [4605]
    /// </summary>
    public string? HelocTARequestAdvanceInPersonLocation { get => _helocTARequestAdvanceInPersonLocation; set => SetField(ref _helocTARequestAdvanceInPersonLocation, value); }

    /// <summary>
    /// Request an Advance by Written Authorization: Via the Internet [4604]
    /// </summary>
    public bool? HelocTARequestAdvanceViaInternetIndicator { get => _helocTARequestAdvanceViaInternetIndicator; set => SetField(ref _helocTARequestAdvanceViaInternetIndicator, value); }

    /// <summary>
    /// Request an Advance by Written Authorization: Written Authoirzation web address [4606]
    /// </summary>
    public string? HelocTARequestAdvanceViaInternetURL { get => _helocTARequestAdvanceViaInternetURL; set => SetField(ref _helocTARequestAdvanceViaInternetURL, value); }

    /// <summary>
    /// HELOC Draw Option: Request by Phone [4599]
    /// </summary>
    public bool? HelocTARequestByPhoneIndicator { get => _helocTARequestByPhoneIndicator; set => SetField(ref _helocTARequestByPhoneIndicator, value); }

    /// <summary>
    /// Lender intends to require repay of some/all third-party closing costs at closing [4621]
    /// </summary>
    public bool? HelocTARequireRepayIndicator { get => _helocTARequireRepayIndicator; set => SetField(ref _helocTARequireRepayIndicator, value); }

    /// <summary>
    /// Right to Setoff [4623]
    /// </summary>
    public bool? HelocTARightToSetoffIndicator { get => _helocTARightToSetoffIndicator; set => SetField(ref _helocTARightToSetoffIndicator, value); }

    /// <summary>
    /// HELOC Draw Option: Written Authorization [4600]
    /// </summary>
    public bool? HelocTAWrittenAuthorizationIndicator { get => _helocTAWrittenAuthorizationIndicator; set => SetField(ref _helocTAWrittenAuthorizationIndicator, value); }

    /// <summary>
    /// LoanProductData Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

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
    public string? IndexMarginPercentUI { get => _indexMarginPercentUI; set => SetField(ref _indexMarginPercentUI, value); }

    /// <summary>
    /// HELOC Initial Advance [1888]
    /// </summary>
    public decimal? InitialAdvanceAmount { get => _initialAdvanceAmount; set => SetField(ref _initialAdvanceAmount, value); }

    /// <summary>
    /// NMLS Initial Application Amount [NMLS.X11]
    /// </summary>
    public decimal? InitialApplicationAmount { get => _initialApplicationAmount; set => SetField(ref _initialApplicationAmount, value); }

    /// <summary>
    /// NMLS Inquiry Or Pre-Qualification [NMLS.X13]
    /// </summary>
    public bool? InquiryOrPreQualificationIndicator { get => _inquiryOrPreQualificationIndicator; set => SetField(ref _inquiryOrPreQualificationIndicator, value); }

    /// <summary>
    /// Lender Representative [4672]
    /// </summary>
    public string? LenderRepresentative { get => _lenderRepresentative; set => SetField(ref _lenderRepresentative, value); }

    /// <summary>
    /// Lender Representative Cell Phone [4677]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderRepresentativeCellPhone { get => _lenderRepresentativeCellPhone; set => SetField(ref _lenderRepresentativeCellPhone, value); }

    /// <summary>
    /// Lender Representative Email address [4674]
    /// </summary>
    public string? LenderRepresentativeEmailAddress { get => _lenderRepresentativeEmailAddress; set => SetField(ref _lenderRepresentativeEmailAddress, value); }

    /// <summary>
    /// Lender Representative First/ Last Name [4673]
    /// </summary>
    public string? LenderRepresentativeFirstLastName { get => _lenderRepresentativeFirstLastName; set => SetField(ref _lenderRepresentativeFirstLastName, value); }

    /// <summary>
    /// Lender Representative Job Title [4683]
    /// </summary>
    public string? LenderRepresentativeJobTitle { get => _lenderRepresentativeJobTitle; set => SetField(ref _lenderRepresentativeJobTitle, value); }

    /// <summary>
    /// Lender Representative Role ID [4675]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LenderRepresentativeRoleId { get => _lenderRepresentativeRoleId; set => SetField(ref _lenderRepresentativeRoleId, value); }

    /// <summary>
    /// Lender Representative User ID [4682]
    /// </summary>
    public string? LenderRepresentativeUserId { get => _lenderRepresentativeUserId; set => SetField(ref _lenderRepresentativeUserId, value); }

    /// <summary>
    /// Lender Representative User Type [4684]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LenderRepresentativeUserType { get => _lenderRepresentativeUserType; set => SetField(ref _lenderRepresentativeUserType, value); }

    /// <summary>
    /// Lender Representative Work Phone [4676]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderRepresentativeWorkPhone { get => _lenderRepresentativeWorkPhone; set => SetField(ref _lenderRepresentativeWorkPhone, value); }

    /// <summary>
    /// Trans Details Lien Position [420]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"SecondLien\":\"Subordinate\"}")]
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
    public string? MaxLifeInterestCapPercentUI { get => _maxLifeInterestCapPercentUI; set => SetField(ref _maxLifeInterestCapPercentUI, value); }

    /// <summary>
    /// Insurance Mtg Ins Coverage Factor [430]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MiCoveragePercent { get => _miCoveragePercent; set => SetField(ref _miCoveragePercent, value); }

    /// <summary>
    /// HELOC Min Advance Amt [1892]
    /// </summary>
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
    public decimal? MinimumPaymentAmount { get => _minimumPaymentAmount; set => SetField(ref _minimumPaymentAmount, value); }

    /// <summary>
    /// HELOC Minimum Payment Less Than Amt [HELOC.MinPmtLessThanAmt]
    /// </summary>
    public decimal? MinimumPaymentLessThanAmount { get => _minimumPaymentLessThanAmount; set => SetField(ref _minimumPaymentLessThanAmount, value); }

    /// <summary>
    /// HELOC Pymt Factor [1413]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MinimumPaymentPercent { get => _minimumPaymentPercent; set => SetField(ref _minimumPaymentPercent, value); }

    /// <summary>
    /// HELOC Minimum Payment UPB Amt [HELOC.MinPmtUnpdBalAmt]
    /// </summary>
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
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\"]")]
    public StringEnumValue<LienStatus> NmlsLienStatus { get => _nmlsLienStatus; set => SetField(ref _nmlsLienStatus, value); }

    /// <summary>
    /// NMLS Loan Type [NMLS.X1]
    /// </summary>
    public StringEnumValue<NmlsLoanType> NmlsLoanType { get => _nmlsLoanType; set => SetField(ref _nmlsLoanType, value); }

    /// <summary>
    /// NMLS Option ARM Indicator [NMLS.X4]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Option ARM\",\"N\":\"Not Option ARM\"}")]
    public bool? NmlsOptionARMIndicator { get => _nmlsOptionARMIndicator; set => SetField(ref _nmlsOptionARMIndicator, value); }

    /// <summary>
    /// NMLS Piggyback or Funded HELOC Indicator [NMLS.X5]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Includes piggyback second or funded HELOC\",\"N\":\"Does not include piggyback second or funded HELOC\"}")]
    public bool? NmlsPiggyBackOrFundedHELOCIndicator { get => _nmlsPiggyBackOrFundedHELOCIndicator; set => SetField(ref _nmlsPiggyBackOrFundedHELOCIndicator, value); }

    /// <summary>
    /// NMLS Production Sold To [NMLS.X7]
    /// </summary>
    public StringEnumValue<NmlsProductionSoldToType> NmlsProductionSoldToType { get => _nmlsProductionSoldToType; set => SetField(ref _nmlsProductionSoldToType, value); }

    /// <summary>
    /// NMLS Subject Property Type [NMLS.X16]
    /// </summary>
    public StringEnumValue<HmdaPropertyType> NmlsPropertyType { get => _nmlsPropertyType; set => SetField(ref _nmlsPropertyType, value); }

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
    public decimal? OverLimitCharge { get => _overLimitCharge; set => SetField(ref _overLimitCharge, value); }

    /// <summary>
    /// HELOC Over Limit Return Charge [HELOC.OvrLmtRtnChg]
    /// </summary>
    public decimal? OverLimitReturnCharge { get => _overLimitReturnCharge; set => SetField(ref _overLimitReturnCharge, value); }

    /// <summary>
    /// HELOC Participation Fees: The total amount(s) payable at or before account opening for participation in an open-end credit plan. [HELOC.ParticipationFees]
    /// </summary>
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
    [AllowNull]
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
    public string? ProductName { get => _productName; set => SetField(ref _productName, value); }

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
    public string? RateAdjustmentPercentUI { get => _rateAdjustmentPercentUI; set => SetField(ref _rateAdjustmentPercentUI, value); }

    /// <summary>
    /// Loan Info ARM Rate Cap [695]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateAdjustmentSubsequentCapPercent { get => _rateAdjustmentSubsequentCapPercent; set => SetField(ref _rateAdjustmentSubsequentCapPercent, value); }

    /// <summary>
    /// Loan Info ARM Rate Cap - Display fields with KBYO rounding rules [KBYO.XD695]
    /// </summary>
    public string? RateAdjustmentSubsequentCapPercentUI { get => _rateAdjustmentSubsequentCapPercentUI; set => SetField(ref _rateAdjustmentSubsequentCapPercentUI, value); }

    /// <summary>
    /// HELOC Release Recording Charge [HELOC.RlsRecgChg]
    /// </summary>
    public decimal? ReleaseRecoringCharge { get => _releaseRecoringCharge; set => SetField(ref _releaseRecoringCharge, value); }

    /// <summary>
    /// Buydown Dsbmt Sum Total Subsidy Bal [3120]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? RemainingBuydownAmount { get => _remainingBuydownAmount; set => SetField(ref _remainingBuydownAmount, value); }

    /// <summary>
    /// HELOC Repay Period Mos [1890]
    /// </summary>
    public int? RepayPeriodMonthsCount { get => _repayPeriodMonthsCount; set => SetField(ref _repayPeriodMonthsCount, value); }

    /// <summary>
    /// HELOC Returned Check Charge Amt. [HELOC.RtdChkChgAmt]
    /// </summary>
    public decimal? ReturnedCheckCharge { get => _returnedCheckCharge; set => SetField(ref _returnedCheckCharge, value); }

    /// <summary>
    /// HELOC Returned Check Charge Rate [HELOC.RtdChkChgRat]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ReturnedCheckChargeRatePercent { get => _returnedCheckChargeRatePercent; set => SetField(ref _returnedCheckChargeRatePercent, value); }

    /// <summary>
    /// HELOC Returned Check Charge Max. [HELOC.RtdChkChgMax]
    /// </summary>
    public decimal? ReturnedCheckMaxCharge { get => _returnedCheckMaxCharge; set => SetField(ref _returnedCheckMaxCharge, value); }

    /// <summary>
    /// HELOC Returned Check Charge Min. [HELOC.RtdChkChgMin]
    /// </summary>
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
    public decimal? StopPaymentCharge { get => _stopPaymentCharge; set => SetField(ref _stopPaymentCharge, value); }

    /// <summary>
    /// Loan Info ARM First Period Change [696]
    /// </summary>
    public int? SubsequentRateAdjustmentMonthsCount { get => _subsequentRateAdjustmentMonthsCount; set => SetField(ref _subsequentRateAdjustmentMonthsCount, value); }

    /// <summary>
    /// HELOC Termination Fee [1986]
    /// </summary>
    public decimal? TerminationFeeAmount { get => _terminationFeeAmount; set => SetField(ref _terminationFeeAmount, value); }

    /// <summary>
    /// HELOC Termination Fee Mos [1987]
    /// </summary>
    public int? TerminationPeriodMonthsCount { get => _terminationPeriodMonthsCount; set => SetField(ref _terminationPeriodMonthsCount, value); }

    /// <summary>
    /// HELOC Third Party Fees Range - From [1965]
    /// </summary>
    public decimal? ThirdPartyFeeFromAmount { get => _thirdPartyFeeFromAmount; set => SetField(ref _thirdPartyFeeFromAmount, value); }

    /// <summary>
    /// HELOC Third Party Fees Range - To [1966]
    /// </summary>
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
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalSubsidyAmount { get => _totalSubsidyAmount; set => SetField(ref _totalSubsidyAmount, value); }

    /// <summary>
    /// HELOC Transaction Fees: The total amount of fees charged each time a withdrawal or other specified transaction is made on a line of credit, such as a balance transfer fee or a cash advance fee. [HELOC.TransactionFees]
    /// </summary>
    public decimal? TransactionFees { get => _transactionFees; set => SetField(ref _transactionFees, value); }

    /// <summary>
    /// HELOC Wire Fee [HELOC.WireFee]
    /// </summary>
    public decimal? WireFee { get => _wireFee; set => SetField(ref _wireFee, value); }
}