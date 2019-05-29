using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ATRQMCommon
    /// </summary>
    public sealed partial class ATRQMCommon : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _affiliatesFees;
        private DirtyValue<decimal?> _aPORMaxBonaFideDiscountPoint;
        private DirtyValue<DateTime?> _aRMRecastDate;
        private DirtyValue<decimal?> _aRMRecastMonthlyPayment;
        private DirtyValue<string> _assetRepresentationAndWarrantyReliefEligibilityType;
        private DirtyValue<StringEnumValue<ATRLoanType>> _aTRLoanType;
        private DirtyValue<string> _aUSDataDiscrepencyResolutionComments;
        private DirtyValue<DateTime?> _aUSDataDiscrepencyResolutionDate;
        private DirtyValue<string> _aUSDataDiscrepencyResolvedBy;
        private DirtyValue<decimal?> _bonaFideDiscountPoint;
        private DirtyValue<decimal?> _bonaFideDiscountPointAmount;
        private DirtyValue<bool?> _brokerCompensationWhenRateSet;
        private DirtyValue<decimal?> _buydownSellerPaidSec32PointsFees;
        private DirtyValue<StringEnumValue<CollateralRepandWarrReliefEligibilityType>> _collateralRepandWarrReliefEligibilityType;
        private DirtyValue<decimal?> _compensationPTBFees;
        private DirtyValue<decimal?> _creditInsPremiumFees;
        private DirtyValue<bool?> _creditorType;
        private DirtyValue<StringEnumValue<CreditorTypeDescription>> _creditorTypeDescription;
        private DirtyValue<bool?> _creditType;
        private DirtyValue<decimal?> _currentQMFeeThresholdAmt;
        private DirtyValue<decimal?> _currentQMFeeThresholdPercent;
        private DirtyValue<DateTime?> _dateOfLastMonthlyPayment;
        private DirtyValue<decimal?> _discountPointAmount;
        private DirtyValue<decimal?> _discountPointFees;
        private DirtyValue<decimal?> _discountPointPercentage;
        private DirtyValue<string> _documentationGuidelineMessages4V;
        private DirtyValue<string> _documentationGuidelineMessages5C;
        private DirtyValue<string> _documentationGuidelineMessages8Y;
        private DirtyValue<string> _documentationGuidelineMessagesCN;
        private DirtyValue<string> _documentationGuidelineMessagesCP;
        private DirtyValue<string> _documentationGuidelineMessagesCV;
        private DirtyValue<string> _documentationGuidelineMessagesCY;
        private DirtyValue<string> _documentationGuidelineMessagesCZ;
        private DirtyValue<string> _documentationGuidelineMessagesDP;
        private DirtyValue<string> _documentationGuidelineMessagesDZ;
        private DirtyValue<string> _documentationGuidelineMessagesE5;
        private DirtyValue<string> _documentationGuidelineMessagesIM;
        private DirtyValue<string> _documentationGuidelineMessagesIQ;
        private DirtyValue<string> _documentationGuidelineMessagesJF;
        private DirtyValue<string> _documentationGuidelineMessagesQJ;
        private DirtyValue<string> _documentationGuidelineMessagesQN;
        private DirtyValue<string> _documentationGuidelineMessagesQQ;
        private DirtyValue<string> _documentationGuidelineMessagesQS;
        private DirtyValue<string> _documentationGuidelineMessagesU7;
        private DirtyValue<string> _documentationGuidelineMessagesX1;
        private DirtyValue<string> _documentationGuidelineMessagesX3;
        private DirtyValue<string> _documentationGuidelineMessagesX5;
        private DirtyValue<string> _documentationGuidelineMessagesX7;
        private DirtyValue<string> _documentationGuidelineMessagesXA;
        private DirtyValue<string> _documentationGuidelineMessagesXM;
        private DirtyValue<string> _documentationGuidelineMessagesXP;
        private DirtyValue<string> _documentationGuidelineMessagesXR;
        private DirtyValue<string> _documentationGuidelineMessagesXT;
        private DirtyValue<string> _documentationGuidelineMessagesY8;
        private DirtyValue<string> _documentationGuidelineMessagesYG;
        private DirtyValue<string> _documentationGuidelineMessagesYJ;
        private DirtyValue<string> _documentationGuidelineMessagesYY;
        private DirtyValue<string> _documentationGuidelineMessagesYZ;
        private DirtyValue<StringEnumValue<EligibleNonStandardToStandard>> _eligibleNonStandardToStandard;
        private DirtyValue<decimal?> _financeChargeFees;
        private DirtyValue<int?> _firstChangeRecase;
        private DirtyValue<DateTime?> _firstPmtDateAfterRecast;
        private DirtyValue<decimal?> _fullPaymentAfterInterestOnly;
        private DirtyValue<decimal?> _fullyARMPaymentAfterNegAm;
        private DirtyValue<decimal?> _fullyIndexRateHousingRatio;
        private DirtyValue<decimal?> _fullyIndexRateMaxTotalPayment;
        private DirtyValue<decimal?> _fullyIndexRateMonthlyPayment;
        private DirtyValue<decimal?> _fullyIndexRateTotalDebtRatio;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusAlimony;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusAssets;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusChildSupport;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusCoveredLoan;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusCreditHistory;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusDebtObligations;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusDTI;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusEmployment;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusIncome;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusMtgRelatedObligations;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusOverall;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusResidualIncome;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusSimultaneousLoan;
        private DirtyValue<decimal?> _gSEAgencyQMCalculatedThreshold;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusAlimony;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusAssets;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusBalloonPayment;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusChildSupport;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusCoveredLoan;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusCreditHistory;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusDebtObligations;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusDTI;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusEmployment;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusIncome;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusInterestOnly;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusLoanTerm;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusMtgRelatedObligations;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusNegativeAmortization;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusOverall;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusPointsFeesLimit;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusPrepaymentPenalty;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusResidualIncome;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusSafeHarborEligibility;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusSimultaneousLoan;
        private DirtyValue<bool?> _has30DayLatePayment;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _initialMaxTotalPayment;
        private DirtyValue<decimal?> _initialRateHousingRatio;
        private DirtyValue<decimal?> _initialRateMonthlyPayment;
        private DirtyValue<decimal?> _initialRateTotalDebtRatio;
        private DirtyValue<int?> _interestOnlyMonths;
        private DirtyValue<DateTime?> _interestOnlyRecastDate;
        private DirtyValue<bool?> _isConsumerLiklyDefault;
        private DirtyValue<StringEnumValue<YesNoOrNA>> _isEligibleForSafeHarbor;
        private DirtyValue<bool?> _isEvaluatedAlimonyObligations;
        private DirtyValue<bool?> _isEvaluatedChildSupportObligations;
        private DirtyValue<bool?> _isEvaluatedCreditHistory;
        private DirtyValue<bool?> _isEvaluatedCurrentEmploymentStatus;
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedAssets;
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedIncome;
        private DirtyValue<bool?> _isEvaluatedDebtObligations;
        private DirtyValue<bool?> _isEvaluatedDebtToIncomeRatio;
        private DirtyValue<bool?> _isEvaluatedMonthlyCoveredLoanPayment;
        private DirtyValue<bool?> _isEvaluatedMonthlyMortgageRelatedObligations;
        private DirtyValue<bool?> _isEvaluatedMonthlySimultaneousLoanPayment;
        private DirtyValue<bool?> _isEvaluatedResidualIncome;
        private DirtyValue<StringEnumValue<IsOrIsNot>> _isHigherPricedLoan;
        private DirtyValue<string> _loanProcessingInformationCode24;
        private DirtyValue<string> _loanProcessingInformationCode31;
        private DirtyValue<string> _loanProcessingInformationCode32;
        private DirtyValue<string> _loanProcessingInformationCode33;
        private DirtyValue<string> _loanProcessingInformationCode97;
        private DirtyValue<string> _loanProcessingInformationCodeJr;
        private DirtyValue<string> _loanProcessingInformationCodeJt;
        private DirtyValue<string> _loanProcessingInformationD4;
        private DirtyValue<string> _loanProcessingInformationGO;
        private DirtyValue<string> _loanProcessingInformationHA;
        private DirtyValue<string> _loanProcessingInformationLE;
        private DirtyValue<string> _loanProcessingInformationLF;
        private DirtyValue<string> _loanProcessingInformationMA;
        private DirtyValue<bool?> _loanProgram;
        private DirtyValue<StringEnumValue<LoanProgramDescription>> _loanProgramDescription;
        private DirtyValue<bool?> _loanRateFixedin5Years;
        private DirtyValue<decimal?> _lOBrokerCompensationAmount;
        private DirtyValue<decimal?> _max5YrsHousingRatio;
        private DirtyValue<decimal?> _max5YrsPrincipleAndInterest;
        private DirtyValue<decimal?> _max5YrsTotalDebtRatio;
        private DirtyValue<decimal?> _max5YrsTotalPayment;
        private DirtyValue<decimal?> _maxPrepaymentPenaltyFees;
        private DirtyValue<DateTime?> _negAmRecastDate;
        private DirtyValue<bool?> _paymentDecreasedBy10Percent;
        private DirtyValue<bool?> _pointsFeesThresholdMet;
        private DirtyValue<decimal?> _prepaymentPenaltyPayoffFees;
        private DirtyValue<decimal?> _prepayPenaltyPercentage;
        private DirtyValue<bool?> _preventConsumersDefault;
        private DirtyValue<bool?> _principalBalanceIncreased;
        private DirtyValue<bool?> _principalHasDeferred;
        private DirtyValue<StringEnumValue<QMLoanType>> _qMLoanType;
        private DirtyValue<decimal?> _rateReductionBasisPoints;
        private DirtyValue<decimal?> _rateReductionDiscountPoints;
        private DirtyValue<decimal?> _rateReductionMaxBonaFideDiscountPoint;
        private DirtyValue<decimal?> _realEstateFees;
        private DirtyValue<decimal?> _recastDifferencePayment;
        private DirtyValue<decimal?> _regZTotalLoanAmount;
        private DirtyValue<decimal?> _requiredServicesLenderSelectedAmt;
        private DirtyValue<decimal?> _smallCreditorQMCalculatedThreshold;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusAlimony;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusAssets;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusBalloonPayment;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusChildSupport;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusCoveredLoan;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusDebtObligations;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusDTI;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusIncome;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusInterestOnly;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusLoanTerm;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusMtgRelatedObligations;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusNegativeAmortization;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusOverall;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusPointsFeesLimit;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusPrepaymentPenalty;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusResidualIncome;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusSafeHarborEligibility;
        private DirtyValue<decimal?> _standardQMCalculatedThreshold;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusAlimony;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusAssets;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusBalloonPayment;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusChildSupport;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusCoveredLoan;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusCreditHistory;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusDebtObligations;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusDTI;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusEmployment;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusIncome;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusInterestOnly;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusLoanTerm;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusMtgRelatedObligations;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusNegativeAmortization;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusOverall;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusPointsFeesLimit;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusPrepaymentPenalty;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusResidualIncome;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusSafeHarborEligibility;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusSimultaneousLoan;
        private DirtyValue<decimal?> _startingAdjustedRateMaxBonaFideDiscountPoint;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _statusCreditHistory;
        private DirtyValue<StringEnumValue<ATRQMStatus>> _statusSimultaneousLoan;
        private DirtyValue<StringEnumValue<DoesOrDoesNot2>> _thresholdExceedsQM;
        private DirtyValue<decimal?> _titleServicesLenderTitleinsuranceFee;
        private DirtyValue<decimal?> _totalCoMortgagorIncome;
        private DirtyValue<decimal?> _totalIncome;
        private DirtyValue<decimal?> _totalPointsFeesSec32Percent;
        private DirtyValue<bool?> _transactionExemptFromRegZ;
        private DirtyValue<string> _ucdRequirement;
        private DirtyValue<bool?> _unitCount;
        private DirtyValue<decimal?> _upfrontPMIFees;
        private DirtyValue<bool?> _withOriginalCreditor;
        private DirtyValue<DateTime?> _writtenApplicationDate;

        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Fees Paid to Affiliates [QM.X134]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AffiliatesFees { get => _affiliatesFees; set => SetField(ref _affiliatesFees, value); }

        /// <summary>
        /// ATR QM - Qualification - APOR Max Bona Fide Discount Point % [QM.X364]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? APORMaxBonaFideDiscountPoint { get => _aPORMaxBonaFideDiscountPoint; set => SetField(ref _aPORMaxBonaFideDiscountPoint, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Date [QM.X8]
        /// </summary>
        public DateTime? ARMRecastDate { get => _aRMRecastDate; set => SetField(ref _aRMRecastDate, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Monthly Payment [QM.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ARMRecastMonthlyPayment { get => _aRMRecastMonthlyPayment; set => SetField(ref _aRMRecastMonthlyPayment, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Asset Representation And Warranty Relief Eligibility Type [AUSF.X62]
        /// </summary>
        public string AssetRepresentationAndWarrantyReliefEligibilityType { get => _assetRepresentationAndWarrantyReliefEligibilityType; set => SetField(ref _assetRepresentationAndWarrantyReliefEligibilityType, value); }

        /// <summary>
        /// ATR QM - Eligibility - Ability-to-Repay Loan Type [QM.X23]
        /// </summary>
        public StringEnumValue<ATRLoanType> ATRLoanType { get => _aTRLoanType; set => SetField(ref _aTRLoanType, value); }

        /// <summary>
        /// AUS Data Discrepency Resolution Comments [AUSF.X20]
        /// </summary>
        public string AUSDataDiscrepencyResolutionComments { get => _aUSDataDiscrepencyResolutionComments; set => SetField(ref _aUSDataDiscrepencyResolutionComments, value); }

        /// <summary>
        /// AUS Data Discrepency Resolution Date [AUSF.X19]
        /// </summary>
        public DateTime? AUSDataDiscrepencyResolutionDate { get => _aUSDataDiscrepencyResolutionDate; set => SetField(ref _aUSDataDiscrepencyResolutionDate, value); }

        /// <summary>
        /// AUS Data Discrepency Resolution User [AUSF.X21]
        /// </summary>
        public string AUSDataDiscrepencyResolvedBy { get => _aUSDataDiscrepencyResolvedBy; set => SetField(ref _aUSDataDiscrepencyResolvedBy, value); }

        /// <summary>
        /// ATR QM - Qualification - Bona Fide Discount Point % [QM.X369]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? BonaFideDiscountPoint { get => _bonaFideDiscountPoint; set => SetField(ref _bonaFideDiscountPoint, value); }

        /// <summary>
        /// ATR QM - Qualification - Bona Fide Discount Point Amount [QM.X370]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? BonaFideDiscountPointAmount { get => _bonaFideDiscountPointAmount; set => SetField(ref _bonaFideDiscountPointAmount, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Broker Compensation when rate was set [QM.X372]
        /// </summary>
        public bool? BrokerCompensationWhenRateSet { get => _brokerCompensationWhenRateSet; set => SetField(ref _brokerCompensationWhenRateSet, value); }

        /// <summary>
        /// ATR QM - Qualification - Buydown Seller Paid Sec 32 Points and Fees [QM.X378]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BuydownSellerPaidSec32PointsFees { get => _buydownSellerPaidSec32PointsFees; set => SetField(ref _buydownSellerPaidSec32PointsFees, value); }

        /// <summary>
        /// Collateral Rep and Warranty Relief Eligibility Type [AUSF.X61]
        /// </summary>
        public StringEnumValue<CollateralRepandWarrReliefEligibilityType> CollateralRepandWarrReliefEligibilityType { get => _collateralRepandWarrReliefEligibilityType; set => SetField(ref _collateralRepandWarrReliefEligibilityType, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Compensation Paid to Brokers [QM.X133]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CompensationPTBFees { get => _compensationPTBFees; set => SetField(ref _compensationPTBFees, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Credit Related Insurance Premium [QM.X132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
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
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CurrentQMFeeThresholdAmt { get => _currentQMFeeThresholdAmt; set => SetField(ref _currentQMFeeThresholdAmt, value); }

        /// <summary>
        /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Percentage [QM.X122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? CurrentQMFeeThresholdPercent { get => _currentQMFeeThresholdPercent; set => SetField(ref _currentQMFeeThresholdPercent, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Date of last monthly payment [QM.X4]
        /// </summary>
        public DateTime? DateOfLastMonthlyPayment { get => _dateOfLastMonthlyPayment; set => SetField(ref _dateOfLastMonthlyPayment, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points Amount [QM.X111]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountPointAmount { get => _discountPointAmount; set => SetField(ref _discountPointAmount, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Discount Point Fees [QM.X128]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DiscountPointFees { get => _discountPointFees; set => SetField(ref _discountPointFees, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points % [QM.X136]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? DiscountPointPercentage { get => _discountPointPercentage; set => SetField(ref _discountPointPercentage, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (4V) [AUSF.X55]
        /// </summary>
        public string DocumentationGuidelineMessages4V { get => _documentationGuidelineMessages4V; set => SetField(ref _documentationGuidelineMessages4V, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (5C) [AUSF.X56]
        /// </summary>
        public string DocumentationGuidelineMessages5C { get => _documentationGuidelineMessages5C; set => SetField(ref _documentationGuidelineMessages5C, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (8Y) [AUSF.X25]
        /// </summary>
        public string DocumentationGuidelineMessages8Y { get => _documentationGuidelineMessages8Y; set => SetField(ref _documentationGuidelineMessages8Y, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CN) [AUSF.X26]
        /// </summary>
        public string DocumentationGuidelineMessagesCN { get => _documentationGuidelineMessagesCN; set => SetField(ref _documentationGuidelineMessagesCN, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CP) [AUSF.X27]
        /// </summary>
        public string DocumentationGuidelineMessagesCP { get => _documentationGuidelineMessagesCP; set => SetField(ref _documentationGuidelineMessagesCP, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CV) [AUSF.X28]
        /// </summary>
        public string DocumentationGuidelineMessagesCV { get => _documentationGuidelineMessagesCV; set => SetField(ref _documentationGuidelineMessagesCV, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CY) [AUSF.X57]
        /// </summary>
        public string DocumentationGuidelineMessagesCY { get => _documentationGuidelineMessagesCY; set => SetField(ref _documentationGuidelineMessagesCY, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CZ) [AUSF.X29]
        /// </summary>
        public string DocumentationGuidelineMessagesCZ { get => _documentationGuidelineMessagesCZ; set => SetField(ref _documentationGuidelineMessagesCZ, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DP) [AUSF.X58]
        /// </summary>
        public string DocumentationGuidelineMessagesDP { get => _documentationGuidelineMessagesDP; set => SetField(ref _documentationGuidelineMessagesDP, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DZ) [AUSF.X45]
        /// </summary>
        public string DocumentationGuidelineMessagesDZ { get => _documentationGuidelineMessagesDZ; set => SetField(ref _documentationGuidelineMessagesDZ, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (E5) [AUSF.X51]
        /// </summary>
        public string DocumentationGuidelineMessagesE5 { get => _documentationGuidelineMessagesE5; set => SetField(ref _documentationGuidelineMessagesE5, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IM) [AUSF.X53]
        /// </summary>
        public string DocumentationGuidelineMessagesIM { get => _documentationGuidelineMessagesIM; set => SetField(ref _documentationGuidelineMessagesIM, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IQ) [AUSF.X54]
        /// </summary>
        public string DocumentationGuidelineMessagesIQ { get => _documentationGuidelineMessagesIQ; set => SetField(ref _documentationGuidelineMessagesIQ, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (JF) [AUSF.X47]
        /// </summary>
        public string DocumentationGuidelineMessagesJF { get => _documentationGuidelineMessagesJF; set => SetField(ref _documentationGuidelineMessagesJF, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QJ) [AUSF.X46]
        /// </summary>
        public string DocumentationGuidelineMessagesQJ { get => _documentationGuidelineMessagesQJ; set => SetField(ref _documentationGuidelineMessagesQJ, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QN) [AUSF.X48]
        /// </summary>
        public string DocumentationGuidelineMessagesQN { get => _documentationGuidelineMessagesQN; set => SetField(ref _documentationGuidelineMessagesQN, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QQ) [AUSF.X50]
        /// </summary>
        public string DocumentationGuidelineMessagesQQ { get => _documentationGuidelineMessagesQQ; set => SetField(ref _documentationGuidelineMessagesQQ, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QS) [AUSF.X52]
        /// </summary>
        public string DocumentationGuidelineMessagesQS { get => _documentationGuidelineMessagesQS; set => SetField(ref _documentationGuidelineMessagesQS, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (U7) [AUSF.X49]
        /// </summary>
        public string DocumentationGuidelineMessagesU7 { get => _documentationGuidelineMessagesU7; set => SetField(ref _documentationGuidelineMessagesU7, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X1) [AUSF.X30]
        /// </summary>
        public string DocumentationGuidelineMessagesX1 { get => _documentationGuidelineMessagesX1; set => SetField(ref _documentationGuidelineMessagesX1, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X3) [AUSF.X31]
        /// </summary>
        public string DocumentationGuidelineMessagesX3 { get => _documentationGuidelineMessagesX3; set => SetField(ref _documentationGuidelineMessagesX3, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X5) [AUSF.X32]
        /// </summary>
        public string DocumentationGuidelineMessagesX5 { get => _documentationGuidelineMessagesX5; set => SetField(ref _documentationGuidelineMessagesX5, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X7) [AUSF.X33]
        /// </summary>
        public string DocumentationGuidelineMessagesX7 { get => _documentationGuidelineMessagesX7; set => SetField(ref _documentationGuidelineMessagesX7, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XA) [AUSF.X34]
        /// </summary>
        public string DocumentationGuidelineMessagesXA { get => _documentationGuidelineMessagesXA; set => SetField(ref _documentationGuidelineMessagesXA, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XM) [AUSF.X35]
        /// </summary>
        public string DocumentationGuidelineMessagesXM { get => _documentationGuidelineMessagesXM; set => SetField(ref _documentationGuidelineMessagesXM, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XP) [AUSF.X36]
        /// </summary>
        public string DocumentationGuidelineMessagesXP { get => _documentationGuidelineMessagesXP; set => SetField(ref _documentationGuidelineMessagesXP, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XR) [AUSF.X37]
        /// </summary>
        public string DocumentationGuidelineMessagesXR { get => _documentationGuidelineMessagesXR; set => SetField(ref _documentationGuidelineMessagesXR, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XT) [AUSF.X38]
        /// </summary>
        public string DocumentationGuidelineMessagesXT { get => _documentationGuidelineMessagesXT; set => SetField(ref _documentationGuidelineMessagesXT, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (Y8) [AUSF.X39]
        /// </summary>
        public string DocumentationGuidelineMessagesY8 { get => _documentationGuidelineMessagesY8; set => SetField(ref _documentationGuidelineMessagesY8, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YG) [AUSF.X40]
        /// </summary>
        public string DocumentationGuidelineMessagesYG { get => _documentationGuidelineMessagesYG; set => SetField(ref _documentationGuidelineMessagesYG, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YJ) [AUSF.X41]
        /// </summary>
        public string DocumentationGuidelineMessagesYJ { get => _documentationGuidelineMessagesYJ; set => SetField(ref _documentationGuidelineMessagesYJ, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YY) [AUSF.X59]
        /// </summary>
        public string DocumentationGuidelineMessagesYY { get => _documentationGuidelineMessagesYY; set => SetField(ref _documentationGuidelineMessagesYY, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YZ) [AUSF.X60]
        /// </summary>
        public string DocumentationGuidelineMessagesYZ { get => _documentationGuidelineMessagesYZ; set => SetField(ref _documentationGuidelineMessagesYZ, value); }

        /// <summary>
        /// ATR/QM - Non-Stardard to Standard Refinance Eligibility - This Loan may or may not be eligible for the Non-Standard to Standard Refinance exception to ATR QM [QM.X1]
        /// </summary>
        public StringEnumValue<EligibleNonStandardToStandard> EligibleNonStandardToStandard { get => _eligibleNonStandardToStandard; set => SetField(ref _eligibleNonStandardToStandard, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Finance Charge Fees [QM.X126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
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
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FullPaymentAfterInterestOnly { get => _fullPaymentAfterInterestOnly; set => SetField(ref _fullPaymentAfterInterestOnly, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Neg. Am Recast [QM.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FullyARMPaymentAfterNegAm { get => _fullyARMPaymentAfterNegAm; set => SetField(ref _fullyARMPaymentAfterNegAm, value); }

        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Housing Ratio [QM.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FullyIndexRateHousingRatio { get => _fullyIndexRateHousingRatio; set => SetField(ref _fullyIndexRateHousingRatio, value); }

        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Max Total Payment [QM.X114]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FullyIndexRateMaxTotalPayment { get => _fullyIndexRateMaxTotalPayment; set => SetField(ref _fullyIndexRateMaxTotalPayment, value); }

        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Monthly Payment [QM.X373]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FullyIndexRateMonthlyPayment { get => _fullyIndexRateMonthlyPayment; set => SetField(ref _fullyIndexRateMonthlyPayment, value); }

        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Total Debt Ratio [QM.X116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FullyIndexRateTotalDebtRatio { get => _fullyIndexRateTotalDebtRatio; set => SetField(ref _fullyIndexRateTotalDebtRatio, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Alimony [QM.X37]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusAlimony { get => _generalATRStatusAlimony; set => SetField(ref _generalATRStatusAlimony, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Assets [QM.X35]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusAssets { get => _generalATRStatusAssets; set => SetField(ref _generalATRStatusAssets, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Child Support [QM.X38]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusChildSupport { get => _generalATRStatusChildSupport; set => SetField(ref _generalATRStatusChildSupport, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Covered Loan [QM.X29]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusCoveredLoan { get => _generalATRStatusCoveredLoan; set => SetField(ref _generalATRStatusCoveredLoan, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Credit History [QM.X39]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusCreditHistory { get => _generalATRStatusCreditHistory; set => SetField(ref _generalATRStatusCreditHistory, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Debt Obligations [QM.X36]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusDebtObligations { get => _generalATRStatusDebtObligations; set => SetField(ref _generalATRStatusDebtObligations, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Debt to Income Ratio [QM.X27]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusDTI { get => _generalATRStatusDTI; set => SetField(ref _generalATRStatusDTI, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Employment [QM.X33]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusEmployment { get => _generalATRStatusEmployment; set => SetField(ref _generalATRStatusEmployment, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Income [QM.X34]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusIncome { get => _generalATRStatusIncome; set => SetField(ref _generalATRStatusIncome, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Mtg. Related Obligations [QM.X31]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusMtgRelatedObligations { get => _generalATRStatusMtgRelatedObligations; set => SetField(ref _generalATRStatusMtgRelatedObligations, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Status of Eligibility [QM.X26]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusOverall { get => _generalATRStatusOverall; set => SetField(ref _generalATRStatusOverall, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Residual Income [QM.X28]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusResidualIncome { get => _generalATRStatusResidualIncome; set => SetField(ref _generalATRStatusResidualIncome, value); }

        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Simultaneous Loan [QM.X30]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GeneralATRStatusSimultaneousLoan { get => _generalATRStatusSimultaneousLoan; set => SetField(ref _generalATRStatusSimultaneousLoan, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Calculated Threshold [QM.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? GSEAgencyQMCalculatedThreshold { get => _gSEAgencyQMCalculatedThreshold; set => SetField(ref _gSEAgencyQMCalculatedThreshold, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Alimony [QM.X79]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAlimony { get => _gSEAgencyQMStatusAlimony; set => SetField(ref _gSEAgencyQMStatusAlimony, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Assets [QM.X77]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAssets { get => _gSEAgencyQMStatusAssets; set => SetField(ref _gSEAgencyQMStatusAssets, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Balloon Payment [QM.X66]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusBalloonPayment { get => _gSEAgencyQMStatusBalloonPayment; set => SetField(ref _gSEAgencyQMStatusBalloonPayment, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Child Support [QM.X80]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusChildSupport { get => _gSEAgencyQMStatusChildSupport; set => SetField(ref _gSEAgencyQMStatusChildSupport, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Covered Loan [QM.X71]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCoveredLoan { get => _gSEAgencyQMStatusCoveredLoan; set => SetField(ref _gSEAgencyQMStatusCoveredLoan, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Credit History [QM.X81]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCreditHistory { get => _gSEAgencyQMStatusCreditHistory; set => SetField(ref _gSEAgencyQMStatusCreditHistory, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt Obligations [QM.X78]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDebtObligations { get => _gSEAgencyQMStatusDebtObligations; set => SetField(ref _gSEAgencyQMStatusDebtObligations, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt to Income Ratio [QM.X69]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDTI { get => _gSEAgencyQMStatusDTI; set => SetField(ref _gSEAgencyQMStatusDTI, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Employment [QM.X75]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusEmployment { get => _gSEAgencyQMStatusEmployment; set => SetField(ref _gSEAgencyQMStatusEmployment, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Income [QM.X76]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusIncome { get => _gSEAgencyQMStatusIncome; set => SetField(ref _gSEAgencyQMStatusIncome, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Interest Only [QM.X64]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusInterestOnly { get => _gSEAgencyQMStatusInterestOnly; set => SetField(ref _gSEAgencyQMStatusInterestOnly, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Loan Term [QM.X63]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusLoanTerm { get => _gSEAgencyQMStatusLoanTerm; set => SetField(ref _gSEAgencyQMStatusLoanTerm, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Mtg. Related Obligations [QM.X73]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusMtgRelatedObligations { get => _gSEAgencyQMStatusMtgRelatedObligations; set => SetField(ref _gSEAgencyQMStatusMtgRelatedObligations, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Negative Amortization [QM.X65]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusNegativeAmortization { get => _gSEAgencyQMStatusNegativeAmortization; set => SetField(ref _gSEAgencyQMStatusNegativeAmortization, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Status of Eligibility [QM.X62]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusOverall { get => _gSEAgencyQMStatusOverall; set => SetField(ref _gSEAgencyQMStatusOverall, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Points and Fees Limit [QM.X68]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPointsFeesLimit { get => _gSEAgencyQMStatusPointsFeesLimit; set => SetField(ref _gSEAgencyQMStatusPointsFeesLimit, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Prepayment Penalty [QM.X67]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPrepaymentPenalty { get => _gSEAgencyQMStatusPrepaymentPenalty; set => SetField(ref _gSEAgencyQMStatusPrepaymentPenalty, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Residual Income [QM.X70]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusResidualIncome { get => _gSEAgencyQMStatusResidualIncome; set => SetField(ref _gSEAgencyQMStatusResidualIncome, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Safe Harbor Eligibility [QM.X82]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSafeHarborEligibility { get => _gSEAgencyQMStatusSafeHarborEligibility; set => SetField(ref _gSEAgencyQMStatusSafeHarborEligibility, value); }

        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Simultaneous Loan [QM.X72]
        /// </summary>
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSimultaneousLoan { get => _gSEAgencyQMStatusSimultaneousLoan; set => SetField(ref _gSEAgencyQMStatusSimultaneousLoan, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Has the Consumer had more than one 30-day Late Mortgage Payment in the last 12 Months? [QM.X3]
        /// </summary>
        public bool? Has30DayLatePayment { get => _has30DayLatePayment; set => SetField(ref _has30DayLatePayment, value); }

        /// <summary>
        /// ATRQMCommon Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// ATR QM - Qualification - Initial Max Total Payment [QM.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialMaxTotalPayment { get => _initialMaxTotalPayment; set => SetField(ref _initialMaxTotalPayment, value); }

        /// <summary>
        /// ATR QM - Qualification - Initial Rate Housing Ratio [QM.X375]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InitialRateHousingRatio { get => _initialRateHousingRatio; set => SetField(ref _initialRateHousingRatio, value); }

        /// <summary>
        /// ATR QM - Qualification - Initial Rate Monthly Payment [QM.X374]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
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
        public bool? IsConsumerLiklyDefault { get => _isConsumerLiklyDefault; set => SetField(ref _isConsumerLiklyDefault, value); }

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
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 24 [AUSF.X63]
        /// </summary>
        public string LoanProcessingInformationCode24 { get => _loanProcessingInformationCode24; set => SetField(ref _loanProcessingInformationCode24, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 31 [AUSF.X64]
        /// </summary>
        public string LoanProcessingInformationCode31 { get => _loanProcessingInformationCode31; set => SetField(ref _loanProcessingInformationCode31, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 32 [AUSF.X65]
        /// </summary>
        public string LoanProcessingInformationCode32 { get => _loanProcessingInformationCode32; set => SetField(ref _loanProcessingInformationCode32, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 33 [AUSF.X66]
        /// </summary>
        public string LoanProcessingInformationCode33 { get => _loanProcessingInformationCode33; set => SetField(ref _loanProcessingInformationCode33, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 97 [AUSF.X67]
        /// </summary>
        public string LoanProcessingInformationCode97 { get => _loanProcessingInformationCode97; set => SetField(ref _loanProcessingInformationCode97, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JR [AUSF.X68]
        /// </summary>
        public string LoanProcessingInformationCodeJr { get => _loanProcessingInformationCodeJr; set => SetField(ref _loanProcessingInformationCodeJr, value); }

        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JT [AUSF.X69]
        /// </summary>
        public string LoanProcessingInformationCodeJt { get => _loanProcessingInformationCodeJt; set => SetField(ref _loanProcessingInformationCodeJt, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (D4) [AUSF.X24]
        /// </summary>
        public string LoanProcessingInformationD4 { get => _loanProcessingInformationD4; set => SetField(ref _loanProcessingInformationD4, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (GO) [AUSF.X23]
        /// </summary>
        public string LoanProcessingInformationGO { get => _loanProcessingInformationGO; set => SetField(ref _loanProcessingInformationGO, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (HA) [AUSF.X22]
        /// </summary>
        public string LoanProcessingInformationHA { get => _loanProcessingInformationHA; set => SetField(ref _loanProcessingInformationHA, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LE) [AUSF.X43]
        /// </summary>
        public string LoanProcessingInformationLE { get => _loanProcessingInformationLE; set => SetField(ref _loanProcessingInformationLE, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LF) [AUSF.X44]
        /// </summary>
        public string LoanProcessingInformationLF { get => _loanProcessingInformationLF; set => SetField(ref _loanProcessingInformationLF, value); }

        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (MA) [AUSF.X42]
        /// </summary>
        public string LoanProcessingInformationMA { get => _loanProcessingInformationMA; set => SetField(ref _loanProcessingInformationMA, value); }

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
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LOBrokerCompensationAmount { get => _lOBrokerCompensationAmount; set => SetField(ref _lOBrokerCompensationAmount, value); }

        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Housing Ratio [QM.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Max5YrsHousingRatio { get => _max5YrsHousingRatio; set => SetField(ref _max5YrsHousingRatio, value); }

        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Max P &amp; I [QM.X337]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Max5YrsPrincipleAndInterest { get => _max5YrsPrincipleAndInterest; set => SetField(ref _max5YrsPrincipleAndInterest, value); }

        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Total Debt Ratio [QM.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Max5YrsTotalDebtRatio { get => _max5YrsTotalDebtRatio; set => SetField(ref _max5YrsTotalDebtRatio, value); }

        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Max Total Payment [QM.X117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Max5YrsTotalPayment { get => _max5YrsTotalPayment; set => SetField(ref _max5YrsTotalPayment, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Max Prepayment Penalty [QM.X130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
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
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
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
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Will this refinance cause the Principal Balance to increase? [QM.X6]
        /// </summary>
        public bool? PrincipalBalanceIncreased { get => _principalBalanceIncreased; set => SetField(ref _principalBalanceIncreased, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Loan have deferred Principal payments? [QM.X20]
        /// </summary>
        public bool? PrincipalHasDeferred { get => _principalHasDeferred; set => SetField(ref _principalHasDeferred, value); }

        /// <summary>
        /// ATR QM - Eligibility - Qualified Mortgage Loan Type [QM.X24]
        /// </summary>
        public StringEnumValue<QMLoanType> QMLoanType { get => _qMLoanType; set => SetField(ref _qMLoanType, value); }

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
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RealEstateFees { get => _realEstateFees; set => SetField(ref _realEstateFees, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Difference between recast monthly payment and new payment [QM.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RecastDifferencePayment { get => _recastDifferencePayment; set => SetField(ref _recastDifferencePayment, value); }

        /// <summary>
        /// ATR QM - Qualification - Reg-Z Total Loan Amount [QM.X120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RegZTotalLoanAmount { get => _regZTotalLoanAmount; set => SetField(ref _regZTotalLoanAmount, value); }

        /// <summary>
        /// ATR QM - Qualification - Required Services - Lender Selected Amount [QM.X125]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? RequiredServicesLenderSelectedAmt { get => _requiredServicesLenderSelectedAmt; set => SetField(ref _requiredServicesLenderSelectedAmt, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Calculated Threshold [QM.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? SmallCreditorQMCalculatedThreshold { get => _smallCreditorQMCalculatedThreshold; set => SetField(ref _smallCreditorQMCalculatedThreshold, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Alimony [QM.X99]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAlimony { get => _smallCreditorQMStatusAlimony; set => SetField(ref _smallCreditorQMStatusAlimony, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Assets [QM.X97]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAssets { get => _smallCreditorQMStatusAssets; set => SetField(ref _smallCreditorQMStatusAssets, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Balloon Payment [QM.X88]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusBalloonPayment { get => _smallCreditorQMStatusBalloonPayment; set => SetField(ref _smallCreditorQMStatusBalloonPayment, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Child Support [QM.X100]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusChildSupport { get => _smallCreditorQMStatusChildSupport; set => SetField(ref _smallCreditorQMStatusChildSupport, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Covered Loan [QM.X93]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusCoveredLoan { get => _smallCreditorQMStatusCoveredLoan; set => SetField(ref _smallCreditorQMStatusCoveredLoan, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt Obligations [QM.X98]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDebtObligations { get => _smallCreditorQMStatusDebtObligations; set => SetField(ref _smallCreditorQMStatusDebtObligations, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt to Income Ratio [QM.X91]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDTI { get => _smallCreditorQMStatusDTI; set => SetField(ref _smallCreditorQMStatusDTI, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Income [QM.X96]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusIncome { get => _smallCreditorQMStatusIncome; set => SetField(ref _smallCreditorQMStatusIncome, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Interest Only [QM.X86]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusInterestOnly { get => _smallCreditorQMStatusInterestOnly; set => SetField(ref _smallCreditorQMStatusInterestOnly, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Loan Term [QM.X85]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusLoanTerm { get => _smallCreditorQMStatusLoanTerm; set => SetField(ref _smallCreditorQMStatusLoanTerm, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Mtg. Related Obligations [QM.X94]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusMtgRelatedObligations { get => _smallCreditorQMStatusMtgRelatedObligations; set => SetField(ref _smallCreditorQMStatusMtgRelatedObligations, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Negative Amortization [QM.X87]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusNegativeAmortization { get => _smallCreditorQMStatusNegativeAmortization; set => SetField(ref _smallCreditorQMStatusNegativeAmortization, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Status of Eligibility [QM.X84]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusOverall { get => _smallCreditorQMStatusOverall; set => SetField(ref _smallCreditorQMStatusOverall, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Points and Fees Limit [QM.X90]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPointsFeesLimit { get => _smallCreditorQMStatusPointsFeesLimit; set => SetField(ref _smallCreditorQMStatusPointsFeesLimit, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Prepayment Penalty [QM.X89]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPrepaymentPenalty { get => _smallCreditorQMStatusPrepaymentPenalty; set => SetField(ref _smallCreditorQMStatusPrepaymentPenalty, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Residual Income [QM.X92]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusResidualIncome { get => _smallCreditorQMStatusResidualIncome; set => SetField(ref _smallCreditorQMStatusResidualIncome, value); }

        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Safe Harbor Eligibility [QM.X101]
        /// </summary>
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusSafeHarborEligibility { get => _smallCreditorQMStatusSafeHarborEligibility; set => SetField(ref _smallCreditorQMStatusSafeHarborEligibility, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Calculated Threshold [QM.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? StandardQMCalculatedThreshold { get => _standardQMCalculatedThreshold; set => SetField(ref _standardQMCalculatedThreshold, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Alimony [QM.X57]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusAlimony { get => _standardQMStatusAlimony; set => SetField(ref _standardQMStatusAlimony, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Assets [QM.X55]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusAssets { get => _standardQMStatusAssets; set => SetField(ref _standardQMStatusAssets, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Balloon Payment [QM.X44]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusBalloonPayment { get => _standardQMStatusBalloonPayment; set => SetField(ref _standardQMStatusBalloonPayment, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Child Support [QM.X58]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusChildSupport { get => _standardQMStatusChildSupport; set => SetField(ref _standardQMStatusChildSupport, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Covered Loan [QM.X49]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusCoveredLoan { get => _standardQMStatusCoveredLoan; set => SetField(ref _standardQMStatusCoveredLoan, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Credit History [QM.X59]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusCreditHistory { get => _standardQMStatusCreditHistory; set => SetField(ref _standardQMStatusCreditHistory, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt Obligations [QM.X56]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusDebtObligations { get => _standardQMStatusDebtObligations; set => SetField(ref _standardQMStatusDebtObligations, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt to Income Ratio [QM.X47]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusDTI { get => _standardQMStatusDTI; set => SetField(ref _standardQMStatusDTI, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Employment [QM.X53]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusEmployment { get => _standardQMStatusEmployment; set => SetField(ref _standardQMStatusEmployment, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Income [QM.X54]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusIncome { get => _standardQMStatusIncome; set => SetField(ref _standardQMStatusIncome, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Interest Only [QM.X42]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusInterestOnly { get => _standardQMStatusInterestOnly; set => SetField(ref _standardQMStatusInterestOnly, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Loan Term [QM.X41]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusLoanTerm { get => _standardQMStatusLoanTerm; set => SetField(ref _standardQMStatusLoanTerm, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Mtg. Related Obligations [QM.X51]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusMtgRelatedObligations { get => _standardQMStatusMtgRelatedObligations; set => SetField(ref _standardQMStatusMtgRelatedObligations, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Negative Amortization [QM.X43]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusNegativeAmortization { get => _standardQMStatusNegativeAmortization; set => SetField(ref _standardQMStatusNegativeAmortization, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Status of Eligibility [QM.X40]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusOverall { get => _standardQMStatusOverall; set => SetField(ref _standardQMStatusOverall, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Points and Fees Limit [QM.X46]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusPointsFeesLimit { get => _standardQMStatusPointsFeesLimit; set => SetField(ref _standardQMStatusPointsFeesLimit, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Prepayment Penalty [QM.X45]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusPrepaymentPenalty { get => _standardQMStatusPrepaymentPenalty; set => SetField(ref _standardQMStatusPrepaymentPenalty, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Residual Income [QM.X48]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusResidualIncome { get => _standardQMStatusResidualIncome; set => SetField(ref _standardQMStatusResidualIncome, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Safe Harbor Eligibility [QM.X60]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusSafeHarborEligibility { get => _standardQMStatusSafeHarborEligibility; set => SetField(ref _standardQMStatusSafeHarborEligibility, value); }

        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Simultaneous Loan [QM.X50]
        /// </summary>
        public StringEnumValue<ATRQMStatus> StandardQMStatusSimultaneousLoan { get => _standardQMStatusSimultaneousLoan; set => SetField(ref _standardQMStatusSimultaneousLoan, value); }

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
        public StringEnumValue<DoesOrDoesNot2> ThresholdExceedsQM { get => _thresholdExceedsQM; set => SetField(ref _thresholdExceedsQM, value); }

        /// <summary>
        /// ATR QM - Qualification - Title Services and Lender's Title Ins [QM.X377]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TitleServicesLenderTitleinsuranceFee { get => _titleServicesLenderTitleinsuranceFee; set => SetField(ref _titleServicesLenderTitleinsuranceFee, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Total Co-Mortgagor Income [QM.X153]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalCoMortgagorIncome { get => _totalCoMortgagorIncome; set => SetField(ref _totalCoMortgagorIncome, value); }

        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Total Income [QM.X154]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
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
        public string UcdRequirement { get => _ucdRequirement; set => SetField(ref _ucdRequirement, value); }

        /// <summary>
        /// ATR QM - Eligibility - Unit Count [QM.X108]
        /// </summary>
        public bool? UnitCount { get => _unitCount; set => SetField(ref _unitCount, value); }

        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Upfront PMI [QM.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UpfrontPMIFees { get => _upfrontPMIFees; set => SetField(ref _upfrontPMIFees, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Refinance with Original Creditor  [QM.X2]
        /// </summary>
        public bool? WithOriginalCreditor { get => _withOriginalCreditor; set => SetField(ref _withOriginalCreditor, value); }

        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Written Application Date [QM.X5]
        /// </summary>
        public DateTime? WrittenApplicationDate { get => _writtenApplicationDate; set => SetField(ref _writtenApplicationDate, value); }
    }
}