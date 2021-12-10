using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ATRQMCommon
/// </summary>
public sealed partial class ATRQMCommon : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _affiliatesFees;
    private DirtyValue<decimal?>? _aporMaxBonaFideDiscountPoint;
    private DirtyValue<DateTime?>? _armRecastDate;
    private DirtyValue<decimal?>? _armRecastMonthlyPayment;
    private DirtyValue<string?>? _assetRepresentationAndWarrantyReliefEligibilityType;
    private DirtyValue<StringEnumValue<ATRLoanType>>? _atrLoanType;
    private DirtyValue<string?>? _ausDataDiscrepancyResolutionComments;
    private DirtyValue<DateTime?>? _ausDataDiscrepancyResolutionDate;
    private DirtyValue<string?>? _ausDataDiscrepancyResolvedBy;
    private DirtyValue<decimal?>? _bonaFideDiscountPoint;
    private DirtyValue<decimal?>? _bonaFideDiscountPointAmount;
    private DirtyValue<bool?>? _brokerCompensationWhenRateSet;
    private DirtyValue<decimal?>? _buydownSellerPaidSec32PointsFees;
    private DirtyValue<StringEnumValue<CollateralRepandWarrReliefEligibilityType>>? _collateralRepandWarrReliefEligibilityType;
    private DirtyValue<decimal?>? _compensationPtbFees;
    private DirtyValue<decimal?>? _creditInsPremiumFees;
    private DirtyValue<bool?>? _creditorType;
    private DirtyValue<StringEnumValue<CreditorTypeDescription>>? _creditorTypeDescription;
    private DirtyValue<bool?>? _creditType;
    private DirtyValue<decimal?>? _currentQmFeeThresholdAmt;
    private DirtyValue<decimal?>? _currentQmFeeThresholdPercent;
    private DirtyValue<decimal?>? _discountPointAmount;
    private DirtyValue<decimal?>? _discountPointFees;
    private DirtyValue<decimal?>? _discountPointPercentage;
    private DirtyValue<string?>? _documentationGuidelineMessages4V;
    private DirtyValue<string?>? _documentationGuidelineMessages5C;
    private DirtyValue<string?>? _documentationGuidelineMessages8Y;
    private DirtyValue<string?>? _documentationGuidelineMessagesCn;
    private DirtyValue<string?>? _documentationGuidelineMessagesCp;
    private DirtyValue<string?>? _documentationGuidelineMessagesCv;
    private DirtyValue<string?>? _documentationGuidelineMessagesCy;
    private DirtyValue<string?>? _documentationGuidelineMessagesCz;
    private DirtyValue<string?>? _documentationGuidelineMessagesDp;
    private DirtyValue<string?>? _documentationGuidelineMessagesDz;
    private DirtyValue<string?>? _documentationGuidelineMessagesE5;
    private DirtyValue<string?>? _documentationGuidelineMessagesIm;
    private DirtyValue<string?>? _documentationGuidelineMessagesIq;
    private DirtyValue<string?>? _documentationGuidelineMessagesJf;
    private DirtyValue<string?>? _documentationGuidelineMessagesQj;
    private DirtyValue<string?>? _documentationGuidelineMessagesQn;
    private DirtyValue<string?>? _documentationGuidelineMessagesQq;
    private DirtyValue<string?>? _documentationGuidelineMessagesQs;
    private DirtyValue<string?>? _documentationGuidelineMessagesU7;
    private DirtyValue<string?>? _documentationGuidelineMessagesX1;
    private DirtyValue<string?>? _documentationGuidelineMessagesX3;
    private DirtyValue<string?>? _documentationGuidelineMessagesX5;
    private DirtyValue<string?>? _documentationGuidelineMessagesX7;
    private DirtyValue<string?>? _documentationGuidelineMessagesXa;
    private DirtyValue<string?>? _documentationGuidelineMessagesXm;
    private DirtyValue<string?>? _documentationGuidelineMessagesXp;
    private DirtyValue<string?>? _documentationGuidelineMessagesXr;
    private DirtyValue<string?>? _documentationGuidelineMessagesXt;
    private DirtyValue<string?>? _documentationGuidelineMessagesY8;
    private DirtyValue<string?>? _documentationGuidelineMessagesYg;
    private DirtyValue<string?>? _documentationGuidelineMessagesYj;
    private DirtyValue<string?>? _documentationGuidelineMessagesYy;
    private DirtyValue<string?>? _documentationGuidelineMessagesYz;
    private DirtyValue<StringEnumValue<EligibleNonStandardToStandard>>? _eligibleNonStandardToStandard;
    private DirtyValue<decimal?>? _financeChargeFees;
    private DirtyValue<int?>? _firstChangeRecase;
    private DirtyValue<DateTime?>? _firstPmtDateAfterRecast;
    private DirtyValue<decimal?>? _fullPaymentAfterInterestOnly;
    private DirtyValue<decimal?>? _fullyArmPaymentAfterNegAm;
    private DirtyValue<decimal?>? _fullyIndexRateHousingRatio;
    private DirtyValue<decimal?>? _fullyIndexRateMaxTotalPayment;
    private DirtyValue<decimal?>? _fullyIndexRateMonthlyPayment;
    private DirtyValue<decimal?>? _fullyIndexRateTotalDebtRatio;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusAlimony;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusAssets;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusChildSupport;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusCoveredLoan;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusCreditHistory;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusDebtObligations;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusDti;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusEmployment;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusIncome;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusMtgRelatedObligations;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusOverall;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusResidualIncome;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _generalAtrStatusSimultaneousLoan;
    private DirtyValue<decimal?>? _gseagencyQmCalculatedThreshold;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusAlimony;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusAssets;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusBalloonPayment;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusChildSupport;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusCoveredLoan;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusCreditHistory;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusDebtObligations;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusDti;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusEmployment;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusIncome;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusInterestOnly;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusLoanTerm;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusMtgRelatedObligations;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusNegativeAmortization;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusOverall;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusPointsFeesLimit;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusPrepaymentPenalty;
    private DirtyValue<StringEnumValue<GSEAgencyQMStatusQMAvailable>>? _gseagencyQmStatusQmAvailable;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusResidualIncome;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusSafeHarborEligibility;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _gseagencyQmStatusSimultaneousLoan;
    private DirtyValue<bool?>? _has30DayLatePayment;
    private DirtyValue<decimal?>? _initialMaxTotalPayment;
    private DirtyValue<decimal?>? _initialRateHousingRatio;
    private DirtyValue<decimal?>? _initialRateMonthlyPayment;
    private DirtyValue<decimal?>? _initialRateTotalDebtRatio;
    private DirtyValue<int?>? _interestOnlyMonths;
    private DirtyValue<DateTime?>? _interestOnlyRecastDate;
    private DirtyValue<bool?>? _isConsumerLikelyDefault;
    private DirtyValue<bool?>? _isCurrentHolderOrServicer;
    private DirtyValue<StringEnumValue<YesNoOrNA>>? _isEligibleForSafeHarbor;
    private DirtyValue<bool?>? _isEvaluatedAlimonyObligations;
    private DirtyValue<bool?>? _isEvaluatedChildSupportObligations;
    private DirtyValue<bool?>? _isEvaluatedCreditHistory;
    private DirtyValue<bool?>? _isEvaluatedCurrentEmploymentStatus;
    private DirtyValue<bool?>? _isEvaluatedCurrentExpectedAssets;
    private DirtyValue<bool?>? _isEvaluatedCurrentExpectedIncome;
    private DirtyValue<bool?>? _isEvaluatedDebtObligations;
    private DirtyValue<bool?>? _isEvaluatedDebtToIncomeRatio;
    private DirtyValue<bool?>? _isEvaluatedMonthlyCoveredLoanPayment;
    private DirtyValue<bool?>? _isEvaluatedMonthlyMortgageRelatedObligations;
    private DirtyValue<bool?>? _isEvaluatedMonthlySimultaneousLoanPayment;
    private DirtyValue<bool?>? _isEvaluatedResidualIncome;
    private DirtyValue<StringEnumValue<IsOrIsNot>>? _isHigherPricedLoan;
    private DirtyValue<StringEnumValue<IsOrIsNot>>? _isQmHigherPricedLoan;
    private DirtyValue<DateTime?>? _lastMonthlyPaymentDate;
    private DirtyValue<string?>? _loanProcessingInformationCode24;
    private DirtyValue<string?>? _loanProcessingInformationCode31;
    private DirtyValue<string?>? _loanProcessingInformationCode32;
    private DirtyValue<string?>? _loanProcessingInformationCode33;
    private DirtyValue<string?>? _loanProcessingInformationCode97;
    private DirtyValue<string?>? _loanProcessingInformationCodeJr;
    private DirtyValue<string?>? _loanProcessingInformationCodeJt;
    private DirtyValue<string?>? _loanProcessingInformationD4;
    private DirtyValue<string?>? _loanProcessingInformationGo;
    private DirtyValue<string?>? _loanProcessingInformationHa;
    private DirtyValue<string?>? _loanProcessingInformationLe;
    private DirtyValue<string?>? _loanProcessingInformationLf;
    private DirtyValue<string?>? _loanProcessingInformationMa;
    private DirtyValue<bool?>? _loanProgram;
    private DirtyValue<StringEnumValue<LoanProgramDescription>>? _loanProgramDescription;
    private DirtyValue<bool?>? _loanRateFixedin5Years;
    private DirtyValue<decimal?>? _loBrokerCompensationAmount;
    private DirtyValue<decimal?>? _max5YrsHousingRatio;
    private DirtyValue<decimal?>? _max5YrsPrincipleAndInterest;
    private DirtyValue<decimal?>? _max5YrsTotalDebtRatio;
    private DirtyValue<decimal?>? _max5YrsTotalPayment;
    private DirtyValue<decimal?>? _maxPrepaymentPenaltyFees;
    private DirtyValue<DateTime?>? _negAmRecastDate;
    private DirtyValue<bool?>? _paymentDecreasedBy10Percent;
    private DirtyValue<bool?>? _pointsFeesThresholdMet;
    private DirtyValue<decimal?>? _prepaymentPenaltyPayoffFees;
    private DirtyValue<decimal?>? _prepayPenaltyPercentage;
    private DirtyValue<bool?>? _preventConsumersDefault;
    private DirtyValue<string?>? _primaryAusId;
    private DirtyValue<bool?>? _principalBalanceIncreased;
    private DirtyValue<bool?>? _principalHasDeferred;
    private DirtyValue<decimal?>? _qmAprPercentage;
    private DirtyValue<StringEnumValue<QMLoanType>>? _qmLoanType;
    private DirtyValue<decimal?>? _rateReductionBasisPoints;
    private DirtyValue<decimal?>? _rateReductionDiscountPoints;
    private DirtyValue<decimal?>? _rateReductionMaxBonaFideDiscountPoint;
    private DirtyValue<decimal?>? _realEstateFees;
    private DirtyValue<decimal?>? _recastDifferencePayment;
    private DirtyValue<decimal?>? _regZTotalLoanAmount;
    private DirtyValue<decimal?>? _requiredServicesLenderSelectedAmt;
    private DirtyValue<decimal?>? _smallCreditorQmCalculatedThreshold;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusAlimony;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusAssets;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusBalloonPayment;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusChildSupport;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusCoveredLoan;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusDebtObligations;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusDti;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusIncome;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusInterestOnly;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusLoanTerm;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusMtgRelatedObligations;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusNegativeAmortization;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusOverall;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusPointsFeesLimit;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusPrepaymentPenalty;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusResidualIncome;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _smallCreditorQmStatusSafeHarborEligibility;
    private DirtyValue<decimal?>? _standardQmCalculatedThreshold;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusAlimony;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusAssets;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusBalloonPayment;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusChildSupport;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusCoveredLoan;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusCreditHistory;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusDebtObligations;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusDti;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusEmployment;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusIncome;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusInterestOnly;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusLoanTerm;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusMtgRelatedObligations;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusNegativeAmortization;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusOverall;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusPointsFeesLimit;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusPrepaymentPenalty;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusPriceLimit;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusResidualIncome;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusSafeHarborEligibility;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _standardQmStatusSimultaneousLoan;
    private DirtyValue<decimal?>? _startingAdjustedRateMaxBonaFideDiscountPoint;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _statusCreditHistory;
    private DirtyValue<StringEnumValue<ATRQMStatus>>? _statusSimultaneousLoan;
    private DirtyValue<StringEnumValue<DoesOrDoesNot2>>? _thresholdExceedsQm;
    private DirtyValue<decimal?>? _titleServicesLenderTitleinsuranceFee;
    private DirtyValue<decimal?>? _totalCoMortgagorIncome;
    private DirtyValue<decimal?>? _totalIncome;
    private DirtyValue<decimal?>? _totalPointsFeesSec32Percent;
    private DirtyValue<bool?>? _transactionExemptFromRegZ;
    private DirtyValue<string?>? _ucdRequirement;
    private DirtyValue<bool?>? _unitCount;
    private DirtyValue<decimal?>? _upfrontPmiFees;
    private DirtyValue<bool?>? _usePriceBasedLimitTest;
    private DirtyValue<bool?>? _withOriginalCreditor;
    private DirtyValue<DateTime?>? _writtenApplicationDate;

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Fees Paid to Affiliates [QM.X134]
    /// </summary>
    public decimal? AffiliatesFees { get => _affiliatesFees; set => SetField(ref _affiliatesFees, value); }

    /// <summary>
    /// ATR QM - Qualification - APOR Max Bona Fide Discount Point % [QM.X364]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? AporMaxBonaFideDiscountPoint { get => _aporMaxBonaFideDiscountPoint; set => SetField(ref _aporMaxBonaFideDiscountPoint, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Date [QM.X8]
    /// </summary>
    public DateTime? ArmRecastDate { get => _armRecastDate; set => SetField(ref _armRecastDate, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Monthly Payment [QM.X9]
    /// </summary>
    public decimal? ArmRecastMonthlyPayment { get => _armRecastMonthlyPayment; set => SetField(ref _armRecastMonthlyPayment, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Asset Representation And Warranty Relief Eligibility Type [AUSF.X62]
    /// </summary>
    public string? AssetRepresentationAndWarrantyReliefEligibilityType { get => _assetRepresentationAndWarrantyReliefEligibilityType; set => SetField(ref _assetRepresentationAndWarrantyReliefEligibilityType, value); }

    /// <summary>
    /// ATR QM - Eligibility - Ability-to-Repay Loan Type [QM.X23]
    /// </summary>
    public StringEnumValue<ATRLoanType> AtrLoanType { get => _atrLoanType; set => SetField(ref _atrLoanType, value); }

    /// <summary>
    /// AUS Data Discrepency Resolution Comments [AUSF.X20]
    /// </summary>
    public string? AusDataDiscrepancyResolutionComments { get => _ausDataDiscrepancyResolutionComments; set => SetField(ref _ausDataDiscrepancyResolutionComments, value); }

    /// <summary>
    /// AUS Data Discrepency Resolution Date [AUSF.X19]
    /// </summary>
    public DateTime? AusDataDiscrepancyResolutionDate { get => _ausDataDiscrepancyResolutionDate; set => SetField(ref _ausDataDiscrepancyResolutionDate, value); }

    /// <summary>
    /// AUS Data Discrepency Resolution User [AUSF.X21]
    /// </summary>
    public string? AusDataDiscrepancyResolvedBy { get => _ausDataDiscrepancyResolvedBy; set => SetField(ref _ausDataDiscrepancyResolvedBy, value); }

    /// <summary>
    /// ATR QM - Qualification - Bona Fide Discount Point % [QM.X369]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BonaFideDiscountPoint { get => _bonaFideDiscountPoint; set => SetField(ref _bonaFideDiscountPoint, value); }

    /// <summary>
    /// ATR QM - Qualification - Bona Fide Discount Point Amount [QM.X370]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BonaFideDiscountPointAmount { get => _bonaFideDiscountPointAmount; set => SetField(ref _bonaFideDiscountPointAmount, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees from 2010 Itemization - Broker Compensation when rate was set [QM.X372]
    /// </summary>
    public bool? BrokerCompensationWhenRateSet { get => _brokerCompensationWhenRateSet; set => SetField(ref _brokerCompensationWhenRateSet, value); }

    /// <summary>
    /// ATR QM - Qualification - Buydown Seller Paid Sec 32 Points and Fees [QM.X378]
    /// </summary>
    public decimal? BuydownSellerPaidSec32PointsFees { get => _buydownSellerPaidSec32PointsFees; set => SetField(ref _buydownSellerPaidSec32PointsFees, value); }

    /// <summary>
    /// Collateral Rep and Warranty Relief Eligibility Type [AUSF.X61]
    /// </summary>
    public StringEnumValue<CollateralRepandWarrReliefEligibilityType> CollateralRepandWarrReliefEligibilityType { get => _collateralRepandWarrReliefEligibilityType; set => SetField(ref _collateralRepandWarrReliefEligibilityType, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Compensation Paid to Brokers [QM.X133]
    /// </summary>
    public decimal? CompensationPtbFees { get => _compensationPtbFees; set => SetField(ref _compensationPtbFees, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Credit Related Insurance Premium [QM.X132]
    /// </summary>
    public decimal? CreditInsPremiumFees { get => _creditInsPremiumFees; set => SetField(ref _creditInsPremiumFees, value); }

    /// <summary>
    /// ATR QM - Eligibility - Creditor Type [QM.X104]
    /// </summary>
    public bool? CreditorType { get => _creditorType; set => SetField(ref _creditorType, value); }

    /// <summary>
    /// ATR QM - Eligibility - Creditor Type Description [QM.X105]
    /// </summary>
    public StringEnumValue<CreditorTypeDescription> CreditorTypeDescription { get => _creditorTypeDescription; set => SetField(ref _creditorTypeDescription, value); }

    /// <summary>
    /// ATR QM - Eligibility - Credit Type [QM.X110]
    /// </summary>
    public bool? CreditType { get => _creditType; set => SetField(ref _creditType, value); }

    /// <summary>
    /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Amount [QM.X121]
    /// </summary>
    public decimal? CurrentQmFeeThresholdAmt { get => _currentQmFeeThresholdAmt; set => SetField(ref _currentQmFeeThresholdAmt, value); }

    /// <summary>
    /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Percentage [QM.X122]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CurrentQmFeeThresholdPercent { get => _currentQmFeeThresholdPercent; set => SetField(ref _currentQmFeeThresholdPercent, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points Amount [QM.X111]
    /// </summary>
    public decimal? DiscountPointAmount { get => _discountPointAmount; set => SetField(ref _discountPointAmount, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Discount Point Fees [QM.X128]
    /// </summary>
    public decimal? DiscountPointFees { get => _discountPointFees; set => SetField(ref _discountPointFees, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points % [QM.X136]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountPointPercentage { get => _discountPointPercentage; set => SetField(ref _discountPointPercentage, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (4V) [AUSF.X55]
    /// </summary>
    public string? DocumentationGuidelineMessages4V { get => _documentationGuidelineMessages4V; set => SetField(ref _documentationGuidelineMessages4V, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (5C) [AUSF.X56]
    /// </summary>
    public string? DocumentationGuidelineMessages5C { get => _documentationGuidelineMessages5C; set => SetField(ref _documentationGuidelineMessages5C, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (8Y) [AUSF.X25]
    /// </summary>
    public string? DocumentationGuidelineMessages8Y { get => _documentationGuidelineMessages8Y; set => SetField(ref _documentationGuidelineMessages8Y, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CN) [AUSF.X26]
    /// </summary>
    public string? DocumentationGuidelineMessagesCn { get => _documentationGuidelineMessagesCn; set => SetField(ref _documentationGuidelineMessagesCn, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CP) [AUSF.X27]
    /// </summary>
    public string? DocumentationGuidelineMessagesCp { get => _documentationGuidelineMessagesCp; set => SetField(ref _documentationGuidelineMessagesCp, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CV) [AUSF.X28]
    /// </summary>
    public string? DocumentationGuidelineMessagesCv { get => _documentationGuidelineMessagesCv; set => SetField(ref _documentationGuidelineMessagesCv, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CY) [AUSF.X57]
    /// </summary>
    public string? DocumentationGuidelineMessagesCy { get => _documentationGuidelineMessagesCy; set => SetField(ref _documentationGuidelineMessagesCy, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CZ) [AUSF.X29]
    /// </summary>
    public string? DocumentationGuidelineMessagesCz { get => _documentationGuidelineMessagesCz; set => SetField(ref _documentationGuidelineMessagesCz, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DP) [AUSF.X58]
    /// </summary>
    public string? DocumentationGuidelineMessagesDp { get => _documentationGuidelineMessagesDp; set => SetField(ref _documentationGuidelineMessagesDp, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DZ) [AUSF.X45]
    /// </summary>
    public string? DocumentationGuidelineMessagesDz { get => _documentationGuidelineMessagesDz; set => SetField(ref _documentationGuidelineMessagesDz, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (E5) [AUSF.X51]
    /// </summary>
    public string? DocumentationGuidelineMessagesE5 { get => _documentationGuidelineMessagesE5; set => SetField(ref _documentationGuidelineMessagesE5, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IM) [AUSF.X53]
    /// </summary>
    public string? DocumentationGuidelineMessagesIm { get => _documentationGuidelineMessagesIm; set => SetField(ref _documentationGuidelineMessagesIm, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IQ) [AUSF.X54]
    /// </summary>
    public string? DocumentationGuidelineMessagesIq { get => _documentationGuidelineMessagesIq; set => SetField(ref _documentationGuidelineMessagesIq, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (JF) [AUSF.X47]
    /// </summary>
    public string? DocumentationGuidelineMessagesJf { get => _documentationGuidelineMessagesJf; set => SetField(ref _documentationGuidelineMessagesJf, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QJ) [AUSF.X46]
    /// </summary>
    public string? DocumentationGuidelineMessagesQj { get => _documentationGuidelineMessagesQj; set => SetField(ref _documentationGuidelineMessagesQj, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QN) [AUSF.X48]
    /// </summary>
    public string? DocumentationGuidelineMessagesQn { get => _documentationGuidelineMessagesQn; set => SetField(ref _documentationGuidelineMessagesQn, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QQ) [AUSF.X50]
    /// </summary>
    public string? DocumentationGuidelineMessagesQq { get => _documentationGuidelineMessagesQq; set => SetField(ref _documentationGuidelineMessagesQq, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QS) [AUSF.X52]
    /// </summary>
    public string? DocumentationGuidelineMessagesQs { get => _documentationGuidelineMessagesQs; set => SetField(ref _documentationGuidelineMessagesQs, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (U7) [AUSF.X49]
    /// </summary>
    public string? DocumentationGuidelineMessagesU7 { get => _documentationGuidelineMessagesU7; set => SetField(ref _documentationGuidelineMessagesU7, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X1) [AUSF.X30]
    /// </summary>
    public string? DocumentationGuidelineMessagesX1 { get => _documentationGuidelineMessagesX1; set => SetField(ref _documentationGuidelineMessagesX1, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X3) [AUSF.X31]
    /// </summary>
    public string? DocumentationGuidelineMessagesX3 { get => _documentationGuidelineMessagesX3; set => SetField(ref _documentationGuidelineMessagesX3, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X5) [AUSF.X32]
    /// </summary>
    public string? DocumentationGuidelineMessagesX5 { get => _documentationGuidelineMessagesX5; set => SetField(ref _documentationGuidelineMessagesX5, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X7) [AUSF.X33]
    /// </summary>
    public string? DocumentationGuidelineMessagesX7 { get => _documentationGuidelineMessagesX7; set => SetField(ref _documentationGuidelineMessagesX7, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XA) [AUSF.X34]
    /// </summary>
    public string? DocumentationGuidelineMessagesXa { get => _documentationGuidelineMessagesXa; set => SetField(ref _documentationGuidelineMessagesXa, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XM) [AUSF.X35]
    /// </summary>
    public string? DocumentationGuidelineMessagesXm { get => _documentationGuidelineMessagesXm; set => SetField(ref _documentationGuidelineMessagesXm, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XP) [AUSF.X36]
    /// </summary>
    public string? DocumentationGuidelineMessagesXp { get => _documentationGuidelineMessagesXp; set => SetField(ref _documentationGuidelineMessagesXp, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XR) [AUSF.X37]
    /// </summary>
    public string? DocumentationGuidelineMessagesXr { get => _documentationGuidelineMessagesXr; set => SetField(ref _documentationGuidelineMessagesXr, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XT) [AUSF.X38]
    /// </summary>
    public string? DocumentationGuidelineMessagesXt { get => _documentationGuidelineMessagesXt; set => SetField(ref _documentationGuidelineMessagesXt, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (Y8) [AUSF.X39]
    /// </summary>
    public string? DocumentationGuidelineMessagesY8 { get => _documentationGuidelineMessagesY8; set => SetField(ref _documentationGuidelineMessagesY8, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YG) [AUSF.X40]
    /// </summary>
    public string? DocumentationGuidelineMessagesYg { get => _documentationGuidelineMessagesYg; set => SetField(ref _documentationGuidelineMessagesYg, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YJ) [AUSF.X41]
    /// </summary>
    public string? DocumentationGuidelineMessagesYj { get => _documentationGuidelineMessagesYj; set => SetField(ref _documentationGuidelineMessagesYj, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YY) [AUSF.X59]
    /// </summary>
    public string? DocumentationGuidelineMessagesYy { get => _documentationGuidelineMessagesYy; set => SetField(ref _documentationGuidelineMessagesYy, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YZ) [AUSF.X60]
    /// </summary>
    public string? DocumentationGuidelineMessagesYz { get => _documentationGuidelineMessagesYz; set => SetField(ref _documentationGuidelineMessagesYz, value); }

    /// <summary>
    /// ATR/QM - Non-Stardard to Standard Refinance Eligibility - This Loan may or may not be eligible for the Non-Standard to Standard Refinance exception to ATR QM [QM.X1]
    /// </summary>
    public StringEnumValue<EligibleNonStandardToStandard> EligibleNonStandardToStandard { get => _eligibleNonStandardToStandard; set => SetField(ref _eligibleNonStandardToStandard, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Finance Charge Fees [QM.X126]
    /// </summary>
    public decimal? FinanceChargeFees { get => _financeChargeFees; set => SetField(ref _financeChargeFees, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Change/Recast [QM.X7]
    /// </summary>
    public int? FirstChangeRecase { get => _firstChangeRecase; set => SetField(ref _firstChangeRecase, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Pmt Due Date after recast [QM.X15]
    /// </summary>
    public DateTime? FirstPmtDateAfterRecast { get => _firstPmtDateAfterRecast; set => SetField(ref _firstPmtDateAfterRecast, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Interest Only Recast [QM.X12]
    /// </summary>
    public decimal? FullPaymentAfterInterestOnly { get => _fullPaymentAfterInterestOnly; set => SetField(ref _fullPaymentAfterInterestOnly, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Neg. Am Recast [QM.X14]
    /// </summary>
    public decimal? FullyArmPaymentAfterNegAm { get => _fullyArmPaymentAfterNegAm; set => SetField(ref _fullyArmPaymentAfterNegAm, value); }

    /// <summary>
    /// ATR QM - Qualification - Fully Index Rate Housing Ratio [QM.X115]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FullyIndexRateHousingRatio { get => _fullyIndexRateHousingRatio; set => SetField(ref _fullyIndexRateHousingRatio, value); }

    /// <summary>
    /// ATR QM - Qualification - Fully Index Rate Max Total Payment [QM.X114]
    /// </summary>
    public decimal? FullyIndexRateMaxTotalPayment { get => _fullyIndexRateMaxTotalPayment; set => SetField(ref _fullyIndexRateMaxTotalPayment, value); }

    /// <summary>
    /// ATR QM - Qualification - Fully Index Rate Monthly Payment [QM.X373]
    /// </summary>
    public decimal? FullyIndexRateMonthlyPayment { get => _fullyIndexRateMonthlyPayment; set => SetField(ref _fullyIndexRateMonthlyPayment, value); }

    /// <summary>
    /// ATR QM - Qualification - Fully Index Rate Total Debt Ratio [QM.X116]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FullyIndexRateTotalDebtRatio { get => _fullyIndexRateTotalDebtRatio; set => SetField(ref _fullyIndexRateTotalDebtRatio, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Alimony [QM.X37]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusAlimony { get => _generalAtrStatusAlimony; set => SetField(ref _generalAtrStatusAlimony, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Assets [QM.X35]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusAssets { get => _generalAtrStatusAssets; set => SetField(ref _generalAtrStatusAssets, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Child Support [QM.X38]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusChildSupport { get => _generalAtrStatusChildSupport; set => SetField(ref _generalAtrStatusChildSupport, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Covered Loan [QM.X29]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusCoveredLoan { get => _generalAtrStatusCoveredLoan; set => SetField(ref _generalAtrStatusCoveredLoan, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Credit History [QM.X39]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusCreditHistory { get => _generalAtrStatusCreditHistory; set => SetField(ref _generalAtrStatusCreditHistory, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Debt Obligations [QM.X36]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusDebtObligations { get => _generalAtrStatusDebtObligations; set => SetField(ref _generalAtrStatusDebtObligations, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Debt to Income Ratio [QM.X27]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusDti { get => _generalAtrStatusDti; set => SetField(ref _generalAtrStatusDti, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Employment [QM.X33]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusEmployment { get => _generalAtrStatusEmployment; set => SetField(ref _generalAtrStatusEmployment, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Income [QM.X34]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusIncome { get => _generalAtrStatusIncome; set => SetField(ref _generalAtrStatusIncome, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Mtg. Related Obligations [QM.X31]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusMtgRelatedObligations { get => _generalAtrStatusMtgRelatedObligations; set => SetField(ref _generalAtrStatusMtgRelatedObligations, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Status of Eligibility [QM.X26]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusOverall { get => _generalAtrStatusOverall; set => SetField(ref _generalAtrStatusOverall, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Residual Income [QM.X28]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusResidualIncome { get => _generalAtrStatusResidualIncome; set => SetField(ref _generalAtrStatusResidualIncome, value); }

    /// <summary>
    /// ATR QM - Eligibility - General Ability-to-Repay - Simultaneous Loan [QM.X30]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GeneralAtrStatusSimultaneousLoan { get => _generalAtrStatusSimultaneousLoan; set => SetField(ref _generalAtrStatusSimultaneousLoan, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Calculated Threshold [QM.X83]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? GseagencyQmCalculatedThreshold { get => _gseagencyQmCalculatedThreshold; set => SetField(ref _gseagencyQmCalculatedThreshold, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Alimony [QM.X79]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusAlimony { get => _gseagencyQmStatusAlimony; set => SetField(ref _gseagencyQmStatusAlimony, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Assets [QM.X77]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusAssets { get => _gseagencyQmStatusAssets; set => SetField(ref _gseagencyQmStatusAssets, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Balloon Payment [QM.X66]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusBalloonPayment { get => _gseagencyQmStatusBalloonPayment; set => SetField(ref _gseagencyQmStatusBalloonPayment, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Child Support [QM.X80]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusChildSupport { get => _gseagencyQmStatusChildSupport; set => SetField(ref _gseagencyQmStatusChildSupport, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Covered Loan [QM.X71]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusCoveredLoan { get => _gseagencyQmStatusCoveredLoan; set => SetField(ref _gseagencyQmStatusCoveredLoan, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Credit History [QM.X81]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusCreditHistory { get => _gseagencyQmStatusCreditHistory; set => SetField(ref _gseagencyQmStatusCreditHistory, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt Obligations [QM.X78]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusDebtObligations { get => _gseagencyQmStatusDebtObligations; set => SetField(ref _gseagencyQmStatusDebtObligations, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt to Income Ratio [QM.X69]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusDti { get => _gseagencyQmStatusDti; set => SetField(ref _gseagencyQmStatusDti, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Employment [QM.X75]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusEmployment { get => _gseagencyQmStatusEmployment; set => SetField(ref _gseagencyQmStatusEmployment, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Income [QM.X76]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusIncome { get => _gseagencyQmStatusIncome; set => SetField(ref _gseagencyQmStatusIncome, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Interest Only [QM.X64]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusInterestOnly { get => _gseagencyQmStatusInterestOnly; set => SetField(ref _gseagencyQmStatusInterestOnly, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Loan Term [QM.X63]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusLoanTerm { get => _gseagencyQmStatusLoanTerm; set => SetField(ref _gseagencyQmStatusLoanTerm, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Mtg. Related Obligations [QM.X73]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusMtgRelatedObligations { get => _gseagencyQmStatusMtgRelatedObligations; set => SetField(ref _gseagencyQmStatusMtgRelatedObligations, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Negative Amortization [QM.X65]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusNegativeAmortization { get => _gseagencyQmStatusNegativeAmortization; set => SetField(ref _gseagencyQmStatusNegativeAmortization, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Status of Eligibility [QM.X62]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusOverall { get => _gseagencyQmStatusOverall; set => SetField(ref _gseagencyQmStatusOverall, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Points and Fees Limit [QM.X68]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusPointsFeesLimit { get => _gseagencyQmStatusPointsFeesLimit; set => SetField(ref _gseagencyQmStatusPointsFeesLimit, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Prepayment Penalty [QM.X67]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusPrepaymentPenalty { get => _gseagencyQmStatusPrepaymentPenalty; set => SetField(ref _gseagencyQmStatusPrepaymentPenalty, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - QM Available [QM.X380]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<GSEAgencyQMStatusQMAvailable> GseagencyQmStatusQmAvailable { get => _gseagencyQmStatusQmAvailable; set => SetField(ref _gseagencyQmStatusQmAvailable, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Residual Income [QM.X70]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusResidualIncome { get => _gseagencyQmStatusResidualIncome; set => SetField(ref _gseagencyQmStatusResidualIncome, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Safe Harbor Eligibility [QM.X82]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusSafeHarborEligibility { get => _gseagencyQmStatusSafeHarborEligibility; set => SetField(ref _gseagencyQmStatusSafeHarborEligibility, value); }

    /// <summary>
    /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Simultaneous Loan [QM.X72]
    /// </summary>
    public StringEnumValue<ATRQMStatus> GseagencyQmStatusSimultaneousLoan { get => _gseagencyQmStatusSimultaneousLoan; set => SetField(ref _gseagencyQmStatusSimultaneousLoan, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Has the Consumer had more than one 30-day Late Mortgage Payment in the last 12 Months? [QM.X3]
    /// </summary>
    public bool? Has30DayLatePayment { get => _has30DayLatePayment; set => SetField(ref _has30DayLatePayment, value); }

    /// <summary>
    /// ATR QM - Qualification - Initial Max Total Payment [QM.X113]
    /// </summary>
    public decimal? InitialMaxTotalPayment { get => _initialMaxTotalPayment; set => SetField(ref _initialMaxTotalPayment, value); }

    /// <summary>
    /// ATR QM - Qualification - Initial Rate Housing Ratio [QM.X375]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InitialRateHousingRatio { get => _initialRateHousingRatio; set => SetField(ref _initialRateHousingRatio, value); }

    /// <summary>
    /// ATR QM - Qualification - Initial Rate Monthly Payment [QM.X374]
    /// </summary>
    public decimal? InitialRateMonthlyPayment { get => _initialRateMonthlyPayment; set => SetField(ref _initialRateMonthlyPayment, value); }

    /// <summary>
    /// ATR QM - Qualification - Initial Rate Total Debt Ratio [QM.X376]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InitialRateTotalDebtRatio { get => _initialRateTotalDebtRatio; set => SetField(ref _initialRateTotalDebtRatio, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Months [QM.X10]
    /// </summary>
    public int? InterestOnlyMonths { get => _interestOnlyMonths; set => SetField(ref _interestOnlyMonths, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Recast Date [QM.X11]
    /// </summary>
    public DateTime? InterestOnlyRecastDate { get => _interestOnlyRecastDate; set => SetField(ref _interestOnlyRecastDate, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Is the Consumer likely to Default at the Recast Payment Amount? [QM.X16]
    /// </summary>
    public bool? IsConsumerLikelyDefault { get => _isConsumerLikelyDefault; set => SetField(ref _isConsumerLikelyDefault, value); }

    /// <summary>
    /// ATR QM - Non-Standard to Standard Refinance Eligibility - Creditor is current holder or servicer  [QM.X379]
    /// </summary>
    public bool? IsCurrentHolderOrServicer { get => _isCurrentHolderOrServicer; set => SetField(ref _isCurrentHolderOrServicer, value); }

    /// <summary>
    /// ATR QM - Eligibility - Is Loan Eligible for Safe Harbor? [QM.X25]
    /// </summary>
    public StringEnumValue<YesNoOrNA> IsEligibleForSafeHarbor { get => _isEligibleForSafeHarbor; set => SetField(ref _isEligibleForSafeHarbor, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Alimony Obligations [QM.X343]
    /// </summary>
    public bool? IsEvaluatedAlimonyObligations { get => _isEvaluatedAlimonyObligations; set => SetField(ref _isEvaluatedAlimonyObligations, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Child Support Obligations [QM.X342]
    /// </summary>
    public bool? IsEvaluatedChildSupportObligations { get => _isEvaluatedChildSupportObligations; set => SetField(ref _isEvaluatedChildSupportObligations, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Credit History [QM.X347]
    /// </summary>
    public bool? IsEvaluatedCreditHistory { get => _isEvaluatedCreditHistory; set => SetField(ref _isEvaluatedCreditHistory, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current Employment Status [QM.X344]
    /// </summary>
    public bool? IsEvaluatedCurrentEmploymentStatus { get => _isEvaluatedCurrentEmploymentStatus; set => SetField(ref _isEvaluatedCurrentEmploymentStatus, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Assets [QM.X346]
    /// </summary>
    public bool? IsEvaluatedCurrentExpectedAssets { get => _isEvaluatedCurrentExpectedAssets; set => SetField(ref _isEvaluatedCurrentExpectedAssets, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Income [QM.X345]
    /// </summary>
    public bool? IsEvaluatedCurrentExpectedIncome { get => _isEvaluatedCurrentExpectedIncome; set => SetField(ref _isEvaluatedCurrentExpectedIncome, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt Obligations [QM.X341]
    /// </summary>
    public bool? IsEvaluatedDebtObligations { get => _isEvaluatedDebtObligations; set => SetField(ref _isEvaluatedDebtObligations, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt to Income Ratio [QM.X348]
    /// </summary>
    public bool? IsEvaluatedDebtToIncomeRatio { get => _isEvaluatedDebtToIncomeRatio; set => SetField(ref _isEvaluatedDebtToIncomeRatio, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Covered Loan Payment [QM.X338]
    /// </summary>
    public bool? IsEvaluatedMonthlyCoveredLoanPayment { get => _isEvaluatedMonthlyCoveredLoanPayment; set => SetField(ref _isEvaluatedMonthlyCoveredLoanPayment, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Mortgage Related Obligations [QM.X340]
    /// </summary>
    public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get => _isEvaluatedMonthlyMortgageRelatedObligations; set => SetField(ref _isEvaluatedMonthlyMortgageRelatedObligations, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Simultaneous Loan Payment [QM.X339]
    /// </summary>
    public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get => _isEvaluatedMonthlySimultaneousLoanPayment; set => SetField(ref _isEvaluatedMonthlySimultaneousLoanPayment, value); }

    /// <summary>
    /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Residual Income [QM.X349]
    /// </summary>
    public bool? IsEvaluatedResidualIncome { get => _isEvaluatedResidualIncome; set => SetField(ref _isEvaluatedResidualIncome, value); }

    /// <summary>
    /// ATR QM - Qualification - This Loan is a Higher-Priced Covered Transaction [QM.X135]
    /// </summary>
    public StringEnumValue<IsOrIsNot> IsHigherPricedLoan { get => _isHigherPricedLoan; set => SetField(ref _isHigherPricedLoan, value); }

    /// <summary>
    /// ATR QM - Qualification - QM HPCT Test [QM.X382]
    /// </summary>
    public StringEnumValue<IsOrIsNot> IsQmHigherPricedLoan { get => _isQmHigherPricedLoan; set => SetField(ref _isQmHigherPricedLoan, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Date of last monthly payment [QM.X4]
    /// </summary>
    public DateTime? LastMonthlyPaymentDate { get => _lastMonthlyPaymentDate; set => SetField(ref _lastMonthlyPaymentDate, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 24 [AUSF.X63]
    /// </summary>
    public string? LoanProcessingInformationCode24 { get => _loanProcessingInformationCode24; set => SetField(ref _loanProcessingInformationCode24, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 31 [AUSF.X64]
    /// </summary>
    public string? LoanProcessingInformationCode31 { get => _loanProcessingInformationCode31; set => SetField(ref _loanProcessingInformationCode31, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 32 [AUSF.X65]
    /// </summary>
    public string? LoanProcessingInformationCode32 { get => _loanProcessingInformationCode32; set => SetField(ref _loanProcessingInformationCode32, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 33 [AUSF.X66]
    /// </summary>
    public string? LoanProcessingInformationCode33 { get => _loanProcessingInformationCode33; set => SetField(ref _loanProcessingInformationCode33, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 97 [AUSF.X67]
    /// </summary>
    public string? LoanProcessingInformationCode97 { get => _loanProcessingInformationCode97; set => SetField(ref _loanProcessingInformationCode97, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JR [AUSF.X68]
    /// </summary>
    public string? LoanProcessingInformationCodeJr { get => _loanProcessingInformationCodeJr; set => SetField(ref _loanProcessingInformationCodeJr, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JT [AUSF.X69]
    /// </summary>
    public string? LoanProcessingInformationCodeJt { get => _loanProcessingInformationCodeJt; set => SetField(ref _loanProcessingInformationCodeJt, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (D4) [AUSF.X24]
    /// </summary>
    public string? LoanProcessingInformationD4 { get => _loanProcessingInformationD4; set => SetField(ref _loanProcessingInformationD4, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (GO) [AUSF.X23]
    /// </summary>
    public string? LoanProcessingInformationGo { get => _loanProcessingInformationGo; set => SetField(ref _loanProcessingInformationGo, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (HA) [AUSF.X22]
    /// </summary>
    public string? LoanProcessingInformationHa { get => _loanProcessingInformationHa; set => SetField(ref _loanProcessingInformationHa, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LE) [AUSF.X43]
    /// </summary>
    public string? LoanProcessingInformationLe { get => _loanProcessingInformationLe; set => SetField(ref _loanProcessingInformationLe, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LF) [AUSF.X44]
    /// </summary>
    public string? LoanProcessingInformationLf { get => _loanProcessingInformationLf; set => SetField(ref _loanProcessingInformationLf, value); }

    /// <summary>
    /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (MA) [AUSF.X42]
    /// </summary>
    public string? LoanProcessingInformationMa { get => _loanProcessingInformationMa; set => SetField(ref _loanProcessingInformationMa, value); }

    /// <summary>
    /// ATR QM - Eligibility - Loan Program [QM.X106]
    /// </summary>
    public bool? LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }

    /// <summary>
    /// ATR QM - Eligibility - Loan Program Description [QM.X107]
    /// </summary>
    public StringEnumValue<LoanProgramDescription> LoanProgramDescription { get => _loanProgramDescription; set => SetField(ref _loanProgramDescription, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the Interest Rate fixed for at least 5 years? [QM.X17]
    /// </summary>
    public bool? LoanRateFixedin5Years { get => _loanRateFixedin5Years; set => SetField(ref _loanRateFixedin5Years, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees from 2010 Itemization - LO (Broker) Compensation [QM.X371]
    /// </summary>
    public decimal? LoBrokerCompensationAmount { get => _loBrokerCompensationAmount; set => SetField(ref _loBrokerCompensationAmount, value); }

    /// <summary>
    /// ATR QM - Qualification - Max Rate During First 5 Years - Housing Ratio [QM.X118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Max5YrsHousingRatio { get => _max5YrsHousingRatio; set => SetField(ref _max5YrsHousingRatio, value); }

    /// <summary>
    /// ATR QM - Qualification - Max Rate During First 5 Years - Max P &amp; I [QM.X337]
    /// </summary>
    public decimal? Max5YrsPrincipleAndInterest { get => _max5YrsPrincipleAndInterest; set => SetField(ref _max5YrsPrincipleAndInterest, value); }

    /// <summary>
    /// ATR QM - Qualification - Max Rate During First 5 Years - Total Debt Ratio [QM.X119]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Max5YrsTotalDebtRatio { get => _max5YrsTotalDebtRatio; set => SetField(ref _max5YrsTotalDebtRatio, value); }

    /// <summary>
    /// ATR QM - Qualification - Max Rate During First 5 Years - Max Total Payment [QM.X117]
    /// </summary>
    public decimal? Max5YrsTotalPayment { get => _max5YrsTotalPayment; set => SetField(ref _max5YrsTotalPayment, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Max Prepayment Penalty [QM.X130]
    /// </summary>
    public decimal? MaxPrepaymentPenaltyFees { get => _maxPrepaymentPenaltyFees; set => SetField(ref _maxPrepaymentPenaltyFees, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Neg. Am Recast Date [QM.X13]
    /// </summary>
    public DateTime? NegAmRecastDate { get => _negAmRecastDate; set => SetField(ref _negAmRecastDate, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Monthly payment decrease by 10% or more? [QM.X18]
    /// </summary>
    public bool? PaymentDecreasedBy10Percent { get => _paymentDecreasedBy10Percent; set => SetField(ref _paymentDecreasedBy10Percent, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Points and Fees Threshold met? [QM.X21]
    /// </summary>
    public bool? PointsFeesThresholdMet { get => _pointsFeesThresholdMet; set => SetField(ref _pointsFeesThresholdMet, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Prepayment Penalty Payoff [QM.X131]
    /// </summary>
    public decimal? PrepaymentPenaltyPayoffFees { get => _prepaymentPenaltyPayoffFees; set => SetField(ref _prepaymentPenaltyPayoffFees, value); }

    /// <summary>
    /// ATR QM - Qualification - Prepay Penalty Percentage [QM.X112]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PrepayPenaltyPercentage { get => _prepayPenaltyPercentage; set => SetField(ref _prepayPenaltyPercentage, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the New loan likely to prevent the Consumers default? [QM.X22]
    /// </summary>
    public bool? PreventConsumersDefault { get => _preventConsumersDefault; set => SetField(ref _preventConsumersDefault, value); }

    /// <summary>
    /// AUS Tracking - Primary Aus Id [AUSF.X71]
    /// </summary>
    public string? PrimaryAusId { get => _primaryAusId; set => SetField(ref _primaryAusId, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Will this refinance cause the Principal Balance to increase? [QM.X6]
    /// </summary>
    public bool? PrincipalBalanceIncreased { get => _principalBalanceIncreased; set => SetField(ref _principalBalanceIncreased, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Loan have deferred Principal payments? [QM.X20]
    /// </summary>
    public bool? PrincipalHasDeferred { get => _principalHasDeferred; set => SetField(ref _principalHasDeferred, value); }

    /// <summary>
    /// ATR QM - Qualification - QM APR % [QM.X381]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? QmAprPercentage { get => _qmAprPercentage; set => SetField(ref _qmAprPercentage, value); }

    /// <summary>
    /// ATR QM - Eligibility - Qualified Mortgage Loan Type [QM.X24]
    /// </summary>
    public StringEnumValue<QMLoanType> QmLoanType { get => _qmLoanType; set => SetField(ref _qmLoanType, value); }

    /// <summary>
    /// ATR QM - Qualification - Rate Reduction Basis Points % [QM.X365]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateReductionBasisPoints { get => _rateReductionBasisPoints; set => SetField(ref _rateReductionBasisPoints, value); }

    /// <summary>
    /// ATR QM - Qualification - Rate Reduction Discount Points % [QM.X366]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RateReductionDiscountPoints { get => _rateReductionDiscountPoints; set => SetField(ref _rateReductionDiscountPoints, value); }

    /// <summary>
    /// ATR QM - Qualification - Rate Reduction Max Bona Fide Discount Point % [QM.X367]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RateReductionMaxBonaFideDiscountPoint { get => _rateReductionMaxBonaFideDiscountPoint; set => SetField(ref _rateReductionMaxBonaFideDiscountPoint, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Real Estate Related Fees [QM.X127]
    /// </summary>
    public decimal? RealEstateFees { get => _realEstateFees; set => SetField(ref _realEstateFees, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Difference between recast monthly payment and new payment [QM.X19]
    /// </summary>
    public decimal? RecastDifferencePayment { get => _recastDifferencePayment; set => SetField(ref _recastDifferencePayment, value); }

    /// <summary>
    /// ATR QM - Qualification - Reg-Z Total Loan Amount [QM.X120]
    /// </summary>
    public decimal? RegZTotalLoanAmount { get => _regZTotalLoanAmount; set => SetField(ref _regZTotalLoanAmount, value); }

    /// <summary>
    /// ATR QM - Qualification - Required Services - Lender Selected Amount [QM.X125]
    /// </summary>
    public decimal? RequiredServicesLenderSelectedAmt { get => _requiredServicesLenderSelectedAmt; set => SetField(ref _requiredServicesLenderSelectedAmt, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Calculated Threshold [QM.X102]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? SmallCreditorQmCalculatedThreshold { get => _smallCreditorQmCalculatedThreshold; set => SetField(ref _smallCreditorQmCalculatedThreshold, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Alimony [QM.X99]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusAlimony { get => _smallCreditorQmStatusAlimony; set => SetField(ref _smallCreditorQmStatusAlimony, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Assets [QM.X97]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusAssets { get => _smallCreditorQmStatusAssets; set => SetField(ref _smallCreditorQmStatusAssets, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Balloon Payment [QM.X88]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusBalloonPayment { get => _smallCreditorQmStatusBalloonPayment; set => SetField(ref _smallCreditorQmStatusBalloonPayment, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Child Support [QM.X100]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusChildSupport { get => _smallCreditorQmStatusChildSupport; set => SetField(ref _smallCreditorQmStatusChildSupport, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Covered Loan [QM.X93]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusCoveredLoan { get => _smallCreditorQmStatusCoveredLoan; set => SetField(ref _smallCreditorQmStatusCoveredLoan, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt Obligations [QM.X98]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusDebtObligations { get => _smallCreditorQmStatusDebtObligations; set => SetField(ref _smallCreditorQmStatusDebtObligations, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt to Income Ratio [QM.X91]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusDti { get => _smallCreditorQmStatusDti; set => SetField(ref _smallCreditorQmStatusDti, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Income [QM.X96]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusIncome { get => _smallCreditorQmStatusIncome; set => SetField(ref _smallCreditorQmStatusIncome, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Interest Only [QM.X86]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusInterestOnly { get => _smallCreditorQmStatusInterestOnly; set => SetField(ref _smallCreditorQmStatusInterestOnly, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Loan Term [QM.X85]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusLoanTerm { get => _smallCreditorQmStatusLoanTerm; set => SetField(ref _smallCreditorQmStatusLoanTerm, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Mtg. Related Obligations [QM.X94]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusMtgRelatedObligations { get => _smallCreditorQmStatusMtgRelatedObligations; set => SetField(ref _smallCreditorQmStatusMtgRelatedObligations, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Negative Amortization [QM.X87]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusNegativeAmortization { get => _smallCreditorQmStatusNegativeAmortization; set => SetField(ref _smallCreditorQmStatusNegativeAmortization, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Status of Eligibility [QM.X84]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusOverall { get => _smallCreditorQmStatusOverall; set => SetField(ref _smallCreditorQmStatusOverall, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Points and Fees Limit [QM.X90]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusPointsFeesLimit { get => _smallCreditorQmStatusPointsFeesLimit; set => SetField(ref _smallCreditorQmStatusPointsFeesLimit, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Prepayment Penalty [QM.X89]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusPrepaymentPenalty { get => _smallCreditorQmStatusPrepaymentPenalty; set => SetField(ref _smallCreditorQmStatusPrepaymentPenalty, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Residual Income [QM.X92]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusResidualIncome { get => _smallCreditorQmStatusResidualIncome; set => SetField(ref _smallCreditorQmStatusResidualIncome, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Safe Harbor Eligibility [QM.X101]
    /// </summary>
    public StringEnumValue<ATRQMStatus> SmallCreditorQmStatusSafeHarborEligibility { get => _smallCreditorQmStatusSafeHarborEligibility; set => SetField(ref _smallCreditorQmStatusSafeHarborEligibility, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Calculated Threshold [QM.X61]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? StandardQmCalculatedThreshold { get => _standardQmCalculatedThreshold; set => SetField(ref _standardQmCalculatedThreshold, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Alimony [QM.X57]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusAlimony { get => _standardQmStatusAlimony; set => SetField(ref _standardQmStatusAlimony, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Assets [QM.X55]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusAssets { get => _standardQmStatusAssets; set => SetField(ref _standardQmStatusAssets, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Balloon Payment [QM.X44]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusBalloonPayment { get => _standardQmStatusBalloonPayment; set => SetField(ref _standardQmStatusBalloonPayment, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Child Support [QM.X58]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusChildSupport { get => _standardQmStatusChildSupport; set => SetField(ref _standardQmStatusChildSupport, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Covered Loan [QM.X49]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusCoveredLoan { get => _standardQmStatusCoveredLoan; set => SetField(ref _standardQmStatusCoveredLoan, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Credit History [QM.X59]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusCreditHistory { get => _standardQmStatusCreditHistory; set => SetField(ref _standardQmStatusCreditHistory, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt Obligations [QM.X56]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusDebtObligations { get => _standardQmStatusDebtObligations; set => SetField(ref _standardQmStatusDebtObligations, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt to Income Ratio [QM.X47]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusDti { get => _standardQmStatusDti; set => SetField(ref _standardQmStatusDti, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Employment [QM.X53]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusEmployment { get => _standardQmStatusEmployment; set => SetField(ref _standardQmStatusEmployment, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Income [QM.X54]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusIncome { get => _standardQmStatusIncome; set => SetField(ref _standardQmStatusIncome, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Interest Only [QM.X42]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusInterestOnly { get => _standardQmStatusInterestOnly; set => SetField(ref _standardQmStatusInterestOnly, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Loan Term [QM.X41]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusLoanTerm { get => _standardQmStatusLoanTerm; set => SetField(ref _standardQmStatusLoanTerm, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Mtg. Related Obligations [QM.X51]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusMtgRelatedObligations { get => _standardQmStatusMtgRelatedObligations; set => SetField(ref _standardQmStatusMtgRelatedObligations, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Negative Amortization [QM.X43]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusNegativeAmortization { get => _standardQmStatusNegativeAmortization; set => SetField(ref _standardQmStatusNegativeAmortization, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Status of Eligibility [QM.X40]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusOverall { get => _standardQmStatusOverall; set => SetField(ref _standardQmStatusOverall, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Points and Fees Limit [QM.X46]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusPointsFeesLimit { get => _standardQmStatusPointsFeesLimit; set => SetField(ref _standardQmStatusPointsFeesLimit, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Prepayment Penalty [QM.X45]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusPrepaymentPenalty { get => _standardQmStatusPrepaymentPenalty; set => SetField(ref _standardQmStatusPrepaymentPenalty, value); }

    /// <summary>
    /// ATR QM - Eligibility - Results of the QM APR to APOR Test [QM.X384]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusPriceLimit { get => _standardQmStatusPriceLimit; set => SetField(ref _standardQmStatusPriceLimit, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Residual Income [QM.X48]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusResidualIncome { get => _standardQmStatusResidualIncome; set => SetField(ref _standardQmStatusResidualIncome, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Safe Harbor Eligibility [QM.X60]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusSafeHarborEligibility { get => _standardQmStatusSafeHarborEligibility; set => SetField(ref _standardQmStatusSafeHarborEligibility, value); }

    /// <summary>
    /// ATR QM - Eligibility - Standard Qualified Mortgage - Simultaneous Loan [QM.X50]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StandardQmStatusSimultaneousLoan { get => _standardQmStatusSimultaneousLoan; set => SetField(ref _standardQmStatusSimultaneousLoan, value); }

    /// <summary>
    /// ATR QM - Qualification - Starting Adjusted Rate Max Bona Fide Discount Point % [QM.X368]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get => _startingAdjustedRateMaxBonaFideDiscountPoint; set => SetField(ref _startingAdjustedRateMaxBonaFideDiscountPoint, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Credit History [QM.X351]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StatusCreditHistory { get => _statusCreditHistory; set => SetField(ref _statusCreditHistory, value); }

    /// <summary>
    /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Simultaneous Loan [QM.X350]
    /// </summary>
    public StringEnumValue<ATRQMStatus> StatusSimultaneousLoan { get => _statusSimultaneousLoan; set => SetField(ref _statusSimultaneousLoan, value); }

    /// <summary>
    /// ATR QM - Qualification - This Loan exceed the threshold for Qualified Mortgages [QM.X124]
    /// </summary>
    public StringEnumValue<DoesOrDoesNot2> ThresholdExceedsQm { get => _thresholdExceedsQm; set => SetField(ref _thresholdExceedsQm, value); }

    /// <summary>
    /// ATR QM - Qualification - Title Services and Lender's Title Ins [QM.X377]
    /// </summary>
    public decimal? TitleServicesLenderTitleinsuranceFee { get => _titleServicesLenderTitleinsuranceFee; set => SetField(ref _titleServicesLenderTitleinsuranceFee, value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Total Co-Mortgagor Income [QM.X153]
    /// </summary>
    public decimal? TotalCoMortgagorIncome { get => _totalCoMortgagorIncome; set => SetField(ref _totalCoMortgagorIncome, value); }

    /// <summary>
    /// ATR/QM Management - Appendix Q - Income - Total Income [QM.X154]
    /// </summary>
    public decimal? TotalIncome { get => _totalIncome; set => SetField(ref _totalIncome, value); }

    /// <summary>
    /// ATR QM - Qualification - Total Points and Fees Percentage Applicable Under Section 32 [QM.X123]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalPointsFeesSec32Percent { get => _totalPointsFeesSec32Percent; set => SetField(ref _totalPointsFeesSec32Percent, value); }

    /// <summary>
    /// ATR QM - Eligibility - Transaction is exempt from Reg. Z Ability-to-Repay requirements [QM.X103]
    /// </summary>
    public bool? TransactionExemptFromRegZ { get => _transactionExemptFromRegZ; set => SetField(ref _transactionExemptFromRegZ, value); }

    /// <summary>
    /// AUS Tracking - Freddie Mac LCLA - UCD Requirement [AUSF.X70]
    /// </summary>
    public string? UcdRequirement { get => _ucdRequirement; set => SetField(ref _ucdRequirement, value); }

    /// <summary>
    /// ATR QM - Eligibility - Unit Count [QM.X108]
    /// </summary>
    public bool? UnitCount { get => _unitCount; set => SetField(ref _unitCount, value); }

    /// <summary>
    /// ATR QM - Qualification - Fees Included in Points and Fees Test - Upfront PMI [QM.X129]
    /// </summary>
    public decimal? UpfrontPmiFees { get => _upfrontPmiFees; set => SetField(ref _upfrontPmiFees, value); }

    /// <summary>
    /// ATR QM - Qualification - Use Price-Based Limit for General QM [QM.X383]
    /// </summary>
    public bool? UsePriceBasedLimitTest { get => _usePriceBasedLimitTest; set => SetField(ref _usePriceBasedLimitTest, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Refinance with Original Creditor  [QM.X2]
    /// </summary>
    public bool? WithOriginalCreditor { get => _withOriginalCreditor; set => SetField(ref _withOriginalCreditor, value); }

    /// <summary>
    /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Written Application Date [QM.X5]
    /// </summary>
    public DateTime? WrittenApplicationDate { get => _writtenApplicationDate; set => SetField(ref _writtenApplicationDate, value); }
}