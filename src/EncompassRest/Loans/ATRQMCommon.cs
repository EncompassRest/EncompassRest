#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ATRQMCommon : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _affiliatesFees;
        public decimal? AffiliatesFees { get => _affiliatesFees; set => _affiliatesFees = value; }
        private DirtyValue<decimal?> _aPORMaxBonaFideDiscountPoint;
        public decimal? APORMaxBonaFideDiscountPoint { get => _aPORMaxBonaFideDiscountPoint; set => _aPORMaxBonaFideDiscountPoint = value; }
        private DirtyValue<DateTime?> _aRMRecastDate;
        public DateTime? ARMRecastDate { get => _aRMRecastDate; set => _aRMRecastDate = value; }
        private DirtyValue<decimal?> _aRMRecastMonthlyPayment;
        public decimal? ARMRecastMonthlyPayment { get => _aRMRecastMonthlyPayment; set => _aRMRecastMonthlyPayment = value; }
        private DirtyValue<string> _assetRepresentationAndWarrantyReliefEligibilityType;
        public string AssetRepresentationAndWarrantyReliefEligibilityType { get => _assetRepresentationAndWarrantyReliefEligibilityType; set => _assetRepresentationAndWarrantyReliefEligibilityType = value; }
        private DirtyValue<StringEnumValue<ATRLoanType>> _aTRLoanType;
        public StringEnumValue<ATRLoanType> ATRLoanType { get => _aTRLoanType; set => _aTRLoanType = value; }
        private DirtyValue<string> _aUSDataDiscrepencyResolutionComments;
        public string AUSDataDiscrepencyResolutionComments { get => _aUSDataDiscrepencyResolutionComments; set => _aUSDataDiscrepencyResolutionComments = value; }
        private DirtyValue<DateTime?> _aUSDataDiscrepencyResolutionDate;
        public DateTime? AUSDataDiscrepencyResolutionDate { get => _aUSDataDiscrepencyResolutionDate; set => _aUSDataDiscrepencyResolutionDate = value; }
        private DirtyValue<string> _aUSDataDiscrepencyResolvedBy;
        public string AUSDataDiscrepencyResolvedBy { get => _aUSDataDiscrepencyResolvedBy; set => _aUSDataDiscrepencyResolvedBy = value; }
        private DirtyValue<decimal?> _bonaFideDiscountPoint;
        public decimal? BonaFideDiscountPoint { get => _bonaFideDiscountPoint; set => _bonaFideDiscountPoint = value; }
        private DirtyValue<decimal?> _bonaFideDiscountPointAmount;
        public decimal? BonaFideDiscountPointAmount { get => _bonaFideDiscountPointAmount; set => _bonaFideDiscountPointAmount = value; }
        private DirtyValue<bool?> _brokerCompensationWhenRateSet;
        public bool? BrokerCompensationWhenRateSet { get => _brokerCompensationWhenRateSet; set => _brokerCompensationWhenRateSet = value; }
        private DirtyValue<StringEnumValue<CollateralRepandWarrReliefEligibilityType>> _collateralRepandWarrReliefEligibilityType;
        public StringEnumValue<CollateralRepandWarrReliefEligibilityType> CollateralRepandWarrReliefEligibilityType { get => _collateralRepandWarrReliefEligibilityType; set => _collateralRepandWarrReliefEligibilityType = value; }
        private DirtyValue<decimal?> _compensationPTBFees;
        public decimal? CompensationPTBFees { get => _compensationPTBFees; set => _compensationPTBFees = value; }
        private DirtyValue<decimal?> _creditInsPremiumFees;
        public decimal? CreditInsPremiumFees { get => _creditInsPremiumFees; set => _creditInsPremiumFees = value; }
        private DirtyValue<bool?> _creditorType;
        public bool? CreditorType { get => _creditorType; set => _creditorType = value; }
        private DirtyValue<StringEnumValue<CreditorTypeDescription>> _creditorTypeDescription;
        public StringEnumValue<CreditorTypeDescription> CreditorTypeDescription { get => _creditorTypeDescription; set => _creditorTypeDescription = value; }
        private DirtyValue<bool?> _creditType;
        public bool? CreditType { get => _creditType; set => _creditType = value; }
        private DirtyValue<decimal?> _currentQMFeeThresholdAmt;
        public decimal? CurrentQMFeeThresholdAmt { get => _currentQMFeeThresholdAmt; set => _currentQMFeeThresholdAmt = value; }
        private DirtyValue<decimal?> _currentQMFeeThresholdPercent;
        public decimal? CurrentQMFeeThresholdPercent { get => _currentQMFeeThresholdPercent; set => _currentQMFeeThresholdPercent = value; }
        private DirtyValue<DateTime?> _dateOfLastMonthlyPayment;
        public DateTime? DateOfLastMonthlyPayment { get => _dateOfLastMonthlyPayment; set => _dateOfLastMonthlyPayment = value; }
        private DirtyValue<decimal?> _discountPointAmount;
        public decimal? DiscountPointAmount { get => _discountPointAmount; set => _discountPointAmount = value; }
        private DirtyValue<decimal?> _discountPointFees;
        public decimal? DiscountPointFees { get => _discountPointFees; set => _discountPointFees = value; }
        private DirtyValue<decimal?> _discountPointPercentage;
        public decimal? DiscountPointPercentage { get => _discountPointPercentage; set => _discountPointPercentage = value; }
        private DirtyValue<string> _documentationGuidelineMessages4V;
        public string DocumentationGuidelineMessages4V { get => _documentationGuidelineMessages4V; set => _documentationGuidelineMessages4V = value; }
        private DirtyValue<string> _documentationGuidelineMessages5C;
        public string DocumentationGuidelineMessages5C { get => _documentationGuidelineMessages5C; set => _documentationGuidelineMessages5C = value; }
        private DirtyValue<string> _documentationGuidelineMessages8Y;
        public string DocumentationGuidelineMessages8Y { get => _documentationGuidelineMessages8Y; set => _documentationGuidelineMessages8Y = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCN;
        public string DocumentationGuidelineMessagesCN { get => _documentationGuidelineMessagesCN; set => _documentationGuidelineMessagesCN = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCP;
        public string DocumentationGuidelineMessagesCP { get => _documentationGuidelineMessagesCP; set => _documentationGuidelineMessagesCP = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCV;
        public string DocumentationGuidelineMessagesCV { get => _documentationGuidelineMessagesCV; set => _documentationGuidelineMessagesCV = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCY;
        public string DocumentationGuidelineMessagesCY { get => _documentationGuidelineMessagesCY; set => _documentationGuidelineMessagesCY = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCZ;
        public string DocumentationGuidelineMessagesCZ { get => _documentationGuidelineMessagesCZ; set => _documentationGuidelineMessagesCZ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesDP;
        public string DocumentationGuidelineMessagesDP { get => _documentationGuidelineMessagesDP; set => _documentationGuidelineMessagesDP = value; }
        private DirtyValue<string> _documentationGuidelineMessagesDZ;
        public string DocumentationGuidelineMessagesDZ { get => _documentationGuidelineMessagesDZ; set => _documentationGuidelineMessagesDZ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesE5;
        public string DocumentationGuidelineMessagesE5 { get => _documentationGuidelineMessagesE5; set => _documentationGuidelineMessagesE5 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesIM;
        public string DocumentationGuidelineMessagesIM { get => _documentationGuidelineMessagesIM; set => _documentationGuidelineMessagesIM = value; }
        private DirtyValue<string> _documentationGuidelineMessagesIQ;
        public string DocumentationGuidelineMessagesIQ { get => _documentationGuidelineMessagesIQ; set => _documentationGuidelineMessagesIQ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesJF;
        public string DocumentationGuidelineMessagesJF { get => _documentationGuidelineMessagesJF; set => _documentationGuidelineMessagesJF = value; }
        private DirtyValue<string> _documentationGuidelineMessagesQJ;
        public string DocumentationGuidelineMessagesQJ { get => _documentationGuidelineMessagesQJ; set => _documentationGuidelineMessagesQJ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesQN;
        public string DocumentationGuidelineMessagesQN { get => _documentationGuidelineMessagesQN; set => _documentationGuidelineMessagesQN = value; }
        private DirtyValue<string> _documentationGuidelineMessagesQQ;
        public string DocumentationGuidelineMessagesQQ { get => _documentationGuidelineMessagesQQ; set => _documentationGuidelineMessagesQQ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesQS;
        public string DocumentationGuidelineMessagesQS { get => _documentationGuidelineMessagesQS; set => _documentationGuidelineMessagesQS = value; }
        private DirtyValue<string> _documentationGuidelineMessagesU7;
        public string DocumentationGuidelineMessagesU7 { get => _documentationGuidelineMessagesU7; set => _documentationGuidelineMessagesU7 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesX1;
        public string DocumentationGuidelineMessagesX1 { get => _documentationGuidelineMessagesX1; set => _documentationGuidelineMessagesX1 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesX3;
        public string DocumentationGuidelineMessagesX3 { get => _documentationGuidelineMessagesX3; set => _documentationGuidelineMessagesX3 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesX5;
        public string DocumentationGuidelineMessagesX5 { get => _documentationGuidelineMessagesX5; set => _documentationGuidelineMessagesX5 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesX7;
        public string DocumentationGuidelineMessagesX7 { get => _documentationGuidelineMessagesX7; set => _documentationGuidelineMessagesX7 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXA;
        public string DocumentationGuidelineMessagesXA { get => _documentationGuidelineMessagesXA; set => _documentationGuidelineMessagesXA = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXM;
        public string DocumentationGuidelineMessagesXM { get => _documentationGuidelineMessagesXM; set => _documentationGuidelineMessagesXM = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXP;
        public string DocumentationGuidelineMessagesXP { get => _documentationGuidelineMessagesXP; set => _documentationGuidelineMessagesXP = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXR;
        public string DocumentationGuidelineMessagesXR { get => _documentationGuidelineMessagesXR; set => _documentationGuidelineMessagesXR = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXT;
        public string DocumentationGuidelineMessagesXT { get => _documentationGuidelineMessagesXT; set => _documentationGuidelineMessagesXT = value; }
        private DirtyValue<string> _documentationGuidelineMessagesY8;
        public string DocumentationGuidelineMessagesY8 { get => _documentationGuidelineMessagesY8; set => _documentationGuidelineMessagesY8 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesYG;
        public string DocumentationGuidelineMessagesYG { get => _documentationGuidelineMessagesYG; set => _documentationGuidelineMessagesYG = value; }
        private DirtyValue<string> _documentationGuidelineMessagesYJ;
        public string DocumentationGuidelineMessagesYJ { get => _documentationGuidelineMessagesYJ; set => _documentationGuidelineMessagesYJ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesYY;
        public string DocumentationGuidelineMessagesYY { get => _documentationGuidelineMessagesYY; set => _documentationGuidelineMessagesYY = value; }
        private DirtyValue<string> _documentationGuidelineMessagesYZ;
        public string DocumentationGuidelineMessagesYZ { get => _documentationGuidelineMessagesYZ; set => _documentationGuidelineMessagesYZ = value; }
        private DirtyValue<StringEnumValue<EligibleNonStandardToStandard>> _eligibleNonStandardToStandard;
        public StringEnumValue<EligibleNonStandardToStandard> EligibleNonStandardToStandard { get => _eligibleNonStandardToStandard; set => _eligibleNonStandardToStandard = value; }
        private DirtyValue<decimal?> _financeChargeFees;
        public decimal? FinanceChargeFees { get => _financeChargeFees; set => _financeChargeFees = value; }
        private DirtyValue<int?> _firstChangeRecase;
        public int? FirstChangeRecase { get => _firstChangeRecase; set => _firstChangeRecase = value; }
        private DirtyValue<DateTime?> _firstPmtDateAfterRecast;
        public DateTime? FirstPmtDateAfterRecast { get => _firstPmtDateAfterRecast; set => _firstPmtDateAfterRecast = value; }
        private DirtyValue<decimal?> _fullPaymentAfterInterestOnly;
        public decimal? FullPaymentAfterInterestOnly { get => _fullPaymentAfterInterestOnly; set => _fullPaymentAfterInterestOnly = value; }
        private DirtyValue<decimal?> _fullyARMPaymentAfterNegAm;
        public decimal? FullyARMPaymentAfterNegAm { get => _fullyARMPaymentAfterNegAm; set => _fullyARMPaymentAfterNegAm = value; }
        private DirtyValue<decimal?> _fullyIndexRateHousingRatio;
        public decimal? FullyIndexRateHousingRatio { get => _fullyIndexRateHousingRatio; set => _fullyIndexRateHousingRatio = value; }
        private DirtyValue<decimal?> _fullyIndexRateMaxTotalPayment;
        public decimal? FullyIndexRateMaxTotalPayment { get => _fullyIndexRateMaxTotalPayment; set => _fullyIndexRateMaxTotalPayment = value; }
        private DirtyValue<decimal?> _fullyIndexRateMonthlyPayment;
        public decimal? FullyIndexRateMonthlyPayment { get => _fullyIndexRateMonthlyPayment; set => _fullyIndexRateMonthlyPayment = value; }
        private DirtyValue<decimal?> _fullyIndexRateTotalDebtRatio;
        public decimal? FullyIndexRateTotalDebtRatio { get => _fullyIndexRateTotalDebtRatio; set => _fullyIndexRateTotalDebtRatio = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusAlimony;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusAlimony { get => _generalATRStatusAlimony; set => _generalATRStatusAlimony = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusAssets;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusAssets { get => _generalATRStatusAssets; set => _generalATRStatusAssets = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusChildSupport;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusChildSupport { get => _generalATRStatusChildSupport; set => _generalATRStatusChildSupport = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusCoveredLoan;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusCoveredLoan { get => _generalATRStatusCoveredLoan; set => _generalATRStatusCoveredLoan = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusCreditHistory;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusCreditHistory { get => _generalATRStatusCreditHistory; set => _generalATRStatusCreditHistory = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusDebtObligations;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusDebtObligations { get => _generalATRStatusDebtObligations; set => _generalATRStatusDebtObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusDTI;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusDTI { get => _generalATRStatusDTI; set => _generalATRStatusDTI = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusEmployment;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusEmployment { get => _generalATRStatusEmployment; set => _generalATRStatusEmployment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusIncome;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusIncome { get => _generalATRStatusIncome; set => _generalATRStatusIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusMtgRelatedObligations;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusMtgRelatedObligations { get => _generalATRStatusMtgRelatedObligations; set => _generalATRStatusMtgRelatedObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusOverall;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusOverall { get => _generalATRStatusOverall; set => _generalATRStatusOverall = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusResidualIncome;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusResidualIncome { get => _generalATRStatusResidualIncome; set => _generalATRStatusResidualIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusSimultaneousLoan;
        public StringEnumValue<ATRQMStatus> GeneralATRStatusSimultaneousLoan { get => _generalATRStatusSimultaneousLoan; set => _generalATRStatusSimultaneousLoan = value; }
        private DirtyValue<decimal?> _gSEAgencyQMCalculatedThreshold;
        public decimal? GSEAgencyQMCalculatedThreshold { get => _gSEAgencyQMCalculatedThreshold; set => _gSEAgencyQMCalculatedThreshold = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusAlimony;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAlimony { get => _gSEAgencyQMStatusAlimony; set => _gSEAgencyQMStatusAlimony = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusAssets;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAssets { get => _gSEAgencyQMStatusAssets; set => _gSEAgencyQMStatusAssets = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusBalloonPayment;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusBalloonPayment { get => _gSEAgencyQMStatusBalloonPayment; set => _gSEAgencyQMStatusBalloonPayment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusChildSupport;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusChildSupport { get => _gSEAgencyQMStatusChildSupport; set => _gSEAgencyQMStatusChildSupport = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusCoveredLoan;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCoveredLoan { get => _gSEAgencyQMStatusCoveredLoan; set => _gSEAgencyQMStatusCoveredLoan = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusCreditHistory;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCreditHistory { get => _gSEAgencyQMStatusCreditHistory; set => _gSEAgencyQMStatusCreditHistory = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusDebtObligations;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDebtObligations { get => _gSEAgencyQMStatusDebtObligations; set => _gSEAgencyQMStatusDebtObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusDTI;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDTI { get => _gSEAgencyQMStatusDTI; set => _gSEAgencyQMStatusDTI = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusEmployment;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusEmployment { get => _gSEAgencyQMStatusEmployment; set => _gSEAgencyQMStatusEmployment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusIncome;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusIncome { get => _gSEAgencyQMStatusIncome; set => _gSEAgencyQMStatusIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusInterestOnly;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusInterestOnly { get => _gSEAgencyQMStatusInterestOnly; set => _gSEAgencyQMStatusInterestOnly = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusLoanTerm;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusLoanTerm { get => _gSEAgencyQMStatusLoanTerm; set => _gSEAgencyQMStatusLoanTerm = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusMtgRelatedObligations;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusMtgRelatedObligations { get => _gSEAgencyQMStatusMtgRelatedObligations; set => _gSEAgencyQMStatusMtgRelatedObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusNegativeAmortization;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusNegativeAmortization { get => _gSEAgencyQMStatusNegativeAmortization; set => _gSEAgencyQMStatusNegativeAmortization = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusOverall;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusOverall { get => _gSEAgencyQMStatusOverall; set => _gSEAgencyQMStatusOverall = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusPointsFeesLimit;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPointsFeesLimit { get => _gSEAgencyQMStatusPointsFeesLimit; set => _gSEAgencyQMStatusPointsFeesLimit = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusPrepaymentPenalty;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPrepaymentPenalty { get => _gSEAgencyQMStatusPrepaymentPenalty; set => _gSEAgencyQMStatusPrepaymentPenalty = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusResidualIncome;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusResidualIncome { get => _gSEAgencyQMStatusResidualIncome; set => _gSEAgencyQMStatusResidualIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusSafeHarborEligibility;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSafeHarborEligibility { get => _gSEAgencyQMStatusSafeHarborEligibility; set => _gSEAgencyQMStatusSafeHarborEligibility = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusSimultaneousLoan;
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSimultaneousLoan { get => _gSEAgencyQMStatusSimultaneousLoan; set => _gSEAgencyQMStatusSimultaneousLoan = value; }
        private DirtyValue<bool?> _has30DayLatePayment;
        public bool? Has30DayLatePayment { get => _has30DayLatePayment; set => _has30DayLatePayment = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _initialMaxTotalPayment;
        public decimal? InitialMaxTotalPayment { get => _initialMaxTotalPayment; set => _initialMaxTotalPayment = value; }
        private DirtyValue<decimal?> _initialRateHousingRatio;
        public decimal? InitialRateHousingRatio { get => _initialRateHousingRatio; set => _initialRateHousingRatio = value; }
        private DirtyValue<decimal?> _initialRateMonthlyPayment;
        public decimal? InitialRateMonthlyPayment { get => _initialRateMonthlyPayment; set => _initialRateMonthlyPayment = value; }
        private DirtyValue<decimal?> _initialRateTotalDebtRatio;
        public decimal? InitialRateTotalDebtRatio { get => _initialRateTotalDebtRatio; set => _initialRateTotalDebtRatio = value; }
        private DirtyValue<int?> _interestOnlyMonths;
        public int? InterestOnlyMonths { get => _interestOnlyMonths; set => _interestOnlyMonths = value; }
        private DirtyValue<DateTime?> _interestOnlyRecastDate;
        public DateTime? InterestOnlyRecastDate { get => _interestOnlyRecastDate; set => _interestOnlyRecastDate = value; }
        private DirtyValue<bool?> _isConsumerLiklyDefault;
        public bool? IsConsumerLiklyDefault { get => _isConsumerLiklyDefault; set => _isConsumerLiklyDefault = value; }
        private DirtyValue<StringEnumValue<YesNoOrNA>> _isEligibleForSafeHarbor;
        public StringEnumValue<YesNoOrNA> IsEligibleForSafeHarbor { get => _isEligibleForSafeHarbor; set => _isEligibleForSafeHarbor = value; }
        private DirtyValue<bool?> _isEvaluatedAlimonyObligations;
        public bool? IsEvaluatedAlimonyObligations { get => _isEvaluatedAlimonyObligations; set => _isEvaluatedAlimonyObligations = value; }
        private DirtyValue<bool?> _isEvaluatedChildSupportObligations;
        public bool? IsEvaluatedChildSupportObligations { get => _isEvaluatedChildSupportObligations; set => _isEvaluatedChildSupportObligations = value; }
        private DirtyValue<bool?> _isEvaluatedCreditHistory;
        public bool? IsEvaluatedCreditHistory { get => _isEvaluatedCreditHistory; set => _isEvaluatedCreditHistory = value; }
        private DirtyValue<bool?> _isEvaluatedCurrentEmploymentStatus;
        public bool? IsEvaluatedCurrentEmploymentStatus { get => _isEvaluatedCurrentEmploymentStatus; set => _isEvaluatedCurrentEmploymentStatus = value; }
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedAssets;
        public bool? IsEvaluatedCurrentExpectedAssets { get => _isEvaluatedCurrentExpectedAssets; set => _isEvaluatedCurrentExpectedAssets = value; }
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedIncome;
        public bool? IsEvaluatedCurrentExpectedIncome { get => _isEvaluatedCurrentExpectedIncome; set => _isEvaluatedCurrentExpectedIncome = value; }
        private DirtyValue<bool?> _isEvaluatedDebtObligations;
        public bool? IsEvaluatedDebtObligations { get => _isEvaluatedDebtObligations; set => _isEvaluatedDebtObligations = value; }
        private DirtyValue<bool?> _isEvaluatedDebtToIncomeRatio;
        public bool? IsEvaluatedDebtToIncomeRatio { get => _isEvaluatedDebtToIncomeRatio; set => _isEvaluatedDebtToIncomeRatio = value; }
        private DirtyValue<bool?> _isEvaluatedMonthlyCoveredLoanPayment;
        public bool? IsEvaluatedMonthlyCoveredLoanPayment { get => _isEvaluatedMonthlyCoveredLoanPayment; set => _isEvaluatedMonthlyCoveredLoanPayment = value; }
        private DirtyValue<bool?> _isEvaluatedMonthlyMortgageRelatedObligations;
        public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get => _isEvaluatedMonthlyMortgageRelatedObligations; set => _isEvaluatedMonthlyMortgageRelatedObligations = value; }
        private DirtyValue<bool?> _isEvaluatedMonthlySimultaneousLoanPayment;
        public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get => _isEvaluatedMonthlySimultaneousLoanPayment; set => _isEvaluatedMonthlySimultaneousLoanPayment = value; }
        private DirtyValue<bool?> _isEvaluatedResidualIncome;
        public bool? IsEvaluatedResidualIncome { get => _isEvaluatedResidualIncome; set => _isEvaluatedResidualIncome = value; }
        private DirtyValue<StringEnumValue<IsOrIsNot>> _isHigherPricedLoan;
        public StringEnumValue<IsOrIsNot> IsHigherPricedLoan { get => _isHigherPricedLoan; set => _isHigherPricedLoan = value; }
        private DirtyValue<string> _loanProcessingInformationCode24;
        public string LoanProcessingInformationCode24 { get => _loanProcessingInformationCode24; set => _loanProcessingInformationCode24 = value; }
        private DirtyValue<string> _loanProcessingInformationCode31;
        public string LoanProcessingInformationCode31 { get => _loanProcessingInformationCode31; set => _loanProcessingInformationCode31 = value; }
        private DirtyValue<string> _loanProcessingInformationCode32;
        public string LoanProcessingInformationCode32 { get => _loanProcessingInformationCode32; set => _loanProcessingInformationCode32 = value; }
        private DirtyValue<string> _loanProcessingInformationCode33;
        public string LoanProcessingInformationCode33 { get => _loanProcessingInformationCode33; set => _loanProcessingInformationCode33 = value; }
        private DirtyValue<string> _loanProcessingInformationCode97;
        public string LoanProcessingInformationCode97 { get => _loanProcessingInformationCode97; set => _loanProcessingInformationCode97 = value; }
        private DirtyValue<string> _loanProcessingInformationCodeJr;
        public string LoanProcessingInformationCodeJr { get => _loanProcessingInformationCodeJr; set => _loanProcessingInformationCodeJr = value; }
        private DirtyValue<string> _loanProcessingInformationCodeJt;
        public string LoanProcessingInformationCodeJt { get => _loanProcessingInformationCodeJt; set => _loanProcessingInformationCodeJt = value; }
        private DirtyValue<string> _loanProcessingInformationD4;
        public string LoanProcessingInformationD4 { get => _loanProcessingInformationD4; set => _loanProcessingInformationD4 = value; }
        private DirtyValue<string> _loanProcessingInformationGO;
        public string LoanProcessingInformationGO { get => _loanProcessingInformationGO; set => _loanProcessingInformationGO = value; }
        private DirtyValue<string> _loanProcessingInformationHA;
        public string LoanProcessingInformationHA { get => _loanProcessingInformationHA; set => _loanProcessingInformationHA = value; }
        private DirtyValue<string> _loanProcessingInformationLE;
        public string LoanProcessingInformationLE { get => _loanProcessingInformationLE; set => _loanProcessingInformationLE = value; }
        private DirtyValue<string> _loanProcessingInformationLF;
        public string LoanProcessingInformationLF { get => _loanProcessingInformationLF; set => _loanProcessingInformationLF = value; }
        private DirtyValue<string> _loanProcessingInformationMA;
        public string LoanProcessingInformationMA { get => _loanProcessingInformationMA; set => _loanProcessingInformationMA = value; }
        private DirtyValue<bool?> _loanProgram;
        public bool? LoanProgram { get => _loanProgram; set => _loanProgram = value; }
        private DirtyValue<StringEnumValue<LoanProgramDescription>> _loanProgramDescription;
        public StringEnumValue<LoanProgramDescription> LoanProgramDescription { get => _loanProgramDescription; set => _loanProgramDescription = value; }
        private DirtyValue<bool?> _loanRateFixedin5Years;
        public bool? LoanRateFixedin5Years { get => _loanRateFixedin5Years; set => _loanRateFixedin5Years = value; }
        private DirtyValue<decimal?> _lOBrokerCompensationAmount;
        public decimal? LOBrokerCompensationAmount { get => _lOBrokerCompensationAmount; set => _lOBrokerCompensationAmount = value; }
        private DirtyValue<decimal?> _max5YrsHousingRatio;
        public decimal? Max5YrsHousingRatio { get => _max5YrsHousingRatio; set => _max5YrsHousingRatio = value; }
        private DirtyValue<decimal?> _max5YrsPrincipleAndInterest;
        public decimal? Max5YrsPrincipleAndInterest { get => _max5YrsPrincipleAndInterest; set => _max5YrsPrincipleAndInterest = value; }
        private DirtyValue<decimal?> _max5YrsTotalDebtRatio;
        public decimal? Max5YrsTotalDebtRatio { get => _max5YrsTotalDebtRatio; set => _max5YrsTotalDebtRatio = value; }
        private DirtyValue<decimal?> _max5YrsTotalPayment;
        public decimal? Max5YrsTotalPayment { get => _max5YrsTotalPayment; set => _max5YrsTotalPayment = value; }
        private DirtyValue<decimal?> _maxPrepaymentPenaltyFees;
        public decimal? MaxPrepaymentPenaltyFees { get => _maxPrepaymentPenaltyFees; set => _maxPrepaymentPenaltyFees = value; }
        private DirtyValue<DateTime?> _negAmRecastDate;
        public DateTime? NegAmRecastDate { get => _negAmRecastDate; set => _negAmRecastDate = value; }
        private DirtyValue<bool?> _paymentDecreasedBy10Percent;
        public bool? PaymentDecreasedBy10Percent { get => _paymentDecreasedBy10Percent; set => _paymentDecreasedBy10Percent = value; }
        private DirtyValue<bool?> _pointsFeesThresholdMet;
        public bool? PointsFeesThresholdMet { get => _pointsFeesThresholdMet; set => _pointsFeesThresholdMet = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyPayoffFees;
        public decimal? PrepaymentPenaltyPayoffFees { get => _prepaymentPenaltyPayoffFees; set => _prepaymentPenaltyPayoffFees = value; }
        private DirtyValue<decimal?> _prepayPenaltyPercentage;
        public decimal? PrepayPenaltyPercentage { get => _prepayPenaltyPercentage; set => _prepayPenaltyPercentage = value; }
        private DirtyValue<bool?> _preventConsumersDefault;
        public bool? PreventConsumersDefault { get => _preventConsumersDefault; set => _preventConsumersDefault = value; }
        private DirtyValue<bool?> _principalBalanceIncreased;
        public bool? PrincipalBalanceIncreased { get => _principalBalanceIncreased; set => _principalBalanceIncreased = value; }
        private DirtyValue<bool?> _principalHasDeferred;
        public bool? PrincipalHasDeferred { get => _principalHasDeferred; set => _principalHasDeferred = value; }
        private DirtyValue<StringEnumValue<QMLoanType>> _qMLoanType;
        public StringEnumValue<QMLoanType> QMLoanType { get => _qMLoanType; set => _qMLoanType = value; }
        private DirtyValue<decimal?> _rateReductionBasisPoints;
        public decimal? RateReductionBasisPoints { get => _rateReductionBasisPoints; set => _rateReductionBasisPoints = value; }
        private DirtyValue<decimal?> _rateReductionDiscountPoints;
        public decimal? RateReductionDiscountPoints { get => _rateReductionDiscountPoints; set => _rateReductionDiscountPoints = value; }
        private DirtyValue<decimal?> _rateReductionMaxBonaFideDiscountPoint;
        public decimal? RateReductionMaxBonaFideDiscountPoint { get => _rateReductionMaxBonaFideDiscountPoint; set => _rateReductionMaxBonaFideDiscountPoint = value; }
        private DirtyValue<decimal?> _realEstateFees;
        public decimal? RealEstateFees { get => _realEstateFees; set => _realEstateFees = value; }
        private DirtyValue<decimal?> _recastDifferencePayment;
        public decimal? RecastDifferencePayment { get => _recastDifferencePayment; set => _recastDifferencePayment = value; }
        private DirtyValue<decimal?> _regZTotalLoanAmount;
        public decimal? RegZTotalLoanAmount { get => _regZTotalLoanAmount; set => _regZTotalLoanAmount = value; }
        private DirtyValue<decimal?> _requiredServicesLenderSelectedAmt;
        public decimal? RequiredServicesLenderSelectedAmt { get => _requiredServicesLenderSelectedAmt; set => _requiredServicesLenderSelectedAmt = value; }
        private DirtyValue<decimal?> _smallCreditorQMCalculatedThreshold;
        public decimal? SmallCreditorQMCalculatedThreshold { get => _smallCreditorQMCalculatedThreshold; set => _smallCreditorQMCalculatedThreshold = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusAlimony;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAlimony { get => _smallCreditorQMStatusAlimony; set => _smallCreditorQMStatusAlimony = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusAssets;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAssets { get => _smallCreditorQMStatusAssets; set => _smallCreditorQMStatusAssets = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusBalloonPayment;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusBalloonPayment { get => _smallCreditorQMStatusBalloonPayment; set => _smallCreditorQMStatusBalloonPayment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusChildSupport;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusChildSupport { get => _smallCreditorQMStatusChildSupport; set => _smallCreditorQMStatusChildSupport = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusCoveredLoan;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusCoveredLoan { get => _smallCreditorQMStatusCoveredLoan; set => _smallCreditorQMStatusCoveredLoan = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusDebtObligations;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDebtObligations { get => _smallCreditorQMStatusDebtObligations; set => _smallCreditorQMStatusDebtObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusDTI;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDTI { get => _smallCreditorQMStatusDTI; set => _smallCreditorQMStatusDTI = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusIncome;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusIncome { get => _smallCreditorQMStatusIncome; set => _smallCreditorQMStatusIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusInterestOnly;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusInterestOnly { get => _smallCreditorQMStatusInterestOnly; set => _smallCreditorQMStatusInterestOnly = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusLoanTerm;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusLoanTerm { get => _smallCreditorQMStatusLoanTerm; set => _smallCreditorQMStatusLoanTerm = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusMtgRelatedObligations;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusMtgRelatedObligations { get => _smallCreditorQMStatusMtgRelatedObligations; set => _smallCreditorQMStatusMtgRelatedObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusNegativeAmortization;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusNegativeAmortization { get => _smallCreditorQMStatusNegativeAmortization; set => _smallCreditorQMStatusNegativeAmortization = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusOverall;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusOverall { get => _smallCreditorQMStatusOverall; set => _smallCreditorQMStatusOverall = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusPointsFeesLimit;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPointsFeesLimit { get => _smallCreditorQMStatusPointsFeesLimit; set => _smallCreditorQMStatusPointsFeesLimit = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusPrepaymentPenalty;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPrepaymentPenalty { get => _smallCreditorQMStatusPrepaymentPenalty; set => _smallCreditorQMStatusPrepaymentPenalty = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusResidualIncome;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusResidualIncome { get => _smallCreditorQMStatusResidualIncome; set => _smallCreditorQMStatusResidualIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusSafeHarborEligibility;
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusSafeHarborEligibility { get => _smallCreditorQMStatusSafeHarborEligibility; set => _smallCreditorQMStatusSafeHarborEligibility = value; }
        private DirtyValue<decimal?> _standardQMCalculatedThreshold;
        public decimal? StandardQMCalculatedThreshold { get => _standardQMCalculatedThreshold; set => _standardQMCalculatedThreshold = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusAlimony;
        public StringEnumValue<ATRQMStatus> StandardQMStatusAlimony { get => _standardQMStatusAlimony; set => _standardQMStatusAlimony = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusAssets;
        public StringEnumValue<ATRQMStatus> StandardQMStatusAssets { get => _standardQMStatusAssets; set => _standardQMStatusAssets = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusBalloonPayment;
        public StringEnumValue<ATRQMStatus> StandardQMStatusBalloonPayment { get => _standardQMStatusBalloonPayment; set => _standardQMStatusBalloonPayment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusChildSupport;
        public StringEnumValue<ATRQMStatus> StandardQMStatusChildSupport { get => _standardQMStatusChildSupport; set => _standardQMStatusChildSupport = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusCoveredLoan;
        public StringEnumValue<ATRQMStatus> StandardQMStatusCoveredLoan { get => _standardQMStatusCoveredLoan; set => _standardQMStatusCoveredLoan = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusCreditHistory;
        public StringEnumValue<ATRQMStatus> StandardQMStatusCreditHistory { get => _standardQMStatusCreditHistory; set => _standardQMStatusCreditHistory = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusDebtObligations;
        public StringEnumValue<ATRQMStatus> StandardQMStatusDebtObligations { get => _standardQMStatusDebtObligations; set => _standardQMStatusDebtObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusDTI;
        public StringEnumValue<ATRQMStatus> StandardQMStatusDTI { get => _standardQMStatusDTI; set => _standardQMStatusDTI = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusEmployment;
        public StringEnumValue<ATRQMStatus> StandardQMStatusEmployment { get => _standardQMStatusEmployment; set => _standardQMStatusEmployment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusIncome;
        public StringEnumValue<ATRQMStatus> StandardQMStatusIncome { get => _standardQMStatusIncome; set => _standardQMStatusIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusInterestOnly;
        public StringEnumValue<ATRQMStatus> StandardQMStatusInterestOnly { get => _standardQMStatusInterestOnly; set => _standardQMStatusInterestOnly = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusLoanTerm;
        public StringEnumValue<ATRQMStatus> StandardQMStatusLoanTerm { get => _standardQMStatusLoanTerm; set => _standardQMStatusLoanTerm = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusMtgRelatedObligations;
        public StringEnumValue<ATRQMStatus> StandardQMStatusMtgRelatedObligations { get => _standardQMStatusMtgRelatedObligations; set => _standardQMStatusMtgRelatedObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusNegativeAmortization;
        public StringEnumValue<ATRQMStatus> StandardQMStatusNegativeAmortization { get => _standardQMStatusNegativeAmortization; set => _standardQMStatusNegativeAmortization = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusOverall;
        public StringEnumValue<ATRQMStatus> StandardQMStatusOverall { get => _standardQMStatusOverall; set => _standardQMStatusOverall = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusPointsFeesLimit;
        public StringEnumValue<ATRQMStatus> StandardQMStatusPointsFeesLimit { get => _standardQMStatusPointsFeesLimit; set => _standardQMStatusPointsFeesLimit = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusPrepaymentPenalty;
        public StringEnumValue<ATRQMStatus> StandardQMStatusPrepaymentPenalty { get => _standardQMStatusPrepaymentPenalty; set => _standardQMStatusPrepaymentPenalty = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusResidualIncome;
        public StringEnumValue<ATRQMStatus> StandardQMStatusResidualIncome { get => _standardQMStatusResidualIncome; set => _standardQMStatusResidualIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusSafeHarborEligibility;
        public StringEnumValue<ATRQMStatus> StandardQMStatusSafeHarborEligibility { get => _standardQMStatusSafeHarborEligibility; set => _standardQMStatusSafeHarborEligibility = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusSimultaneousLoan;
        public StringEnumValue<ATRQMStatus> StandardQMStatusSimultaneousLoan { get => _standardQMStatusSimultaneousLoan; set => _standardQMStatusSimultaneousLoan = value; }
        private DirtyValue<decimal?> _startingAdjustedRateMaxBonaFideDiscountPoint;
        public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get => _startingAdjustedRateMaxBonaFideDiscountPoint; set => _startingAdjustedRateMaxBonaFideDiscountPoint = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _statusCreditHistory;
        public StringEnumValue<ATRQMStatus> StatusCreditHistory { get => _statusCreditHistory; set => _statusCreditHistory = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _statusSimultaneousLoan;
        public StringEnumValue<ATRQMStatus> StatusSimultaneousLoan { get => _statusSimultaneousLoan; set => _statusSimultaneousLoan = value; }
        private DirtyValue<StringEnumValue<DoesOrDoesNot2>> _thresholdExceedsQM;
        public StringEnumValue<DoesOrDoesNot2> ThresholdExceedsQM { get => _thresholdExceedsQM; set => _thresholdExceedsQM = value; }
        private DirtyValue<decimal?> _titleServicesLenderTitleinsuranceFee;
        public decimal? TitleServicesLenderTitleinsuranceFee { get => _titleServicesLenderTitleinsuranceFee; set => _titleServicesLenderTitleinsuranceFee = value; }
        private DirtyValue<decimal?> _totalCoMortgagorIncome;
        public decimal? TotalCoMortgagorIncome { get => _totalCoMortgagorIncome; set => _totalCoMortgagorIncome = value; }
        private DirtyValue<decimal?> _totalIncome;
        public decimal? TotalIncome { get => _totalIncome; set => _totalIncome = value; }
        private DirtyValue<decimal?> _totalPointsFeesSec32Percent;
        public decimal? TotalPointsFeesSec32Percent { get => _totalPointsFeesSec32Percent; set => _totalPointsFeesSec32Percent = value; }
        private DirtyValue<bool?> _transactionExemptFromRegZ;
        public bool? TransactionExemptFromRegZ { get => _transactionExemptFromRegZ; set => _transactionExemptFromRegZ = value; }
        private DirtyValue<string> _ucdRequirement;
        public string UcdRequirement { get => _ucdRequirement; set => _ucdRequirement = value; }
        private DirtyValue<bool?> _unitCount;
        public bool? UnitCount { get => _unitCount; set => _unitCount = value; }
        private DirtyValue<decimal?> _upfrontPMIFees;
        public decimal? UpfrontPMIFees { get => _upfrontPMIFees; set => _upfrontPMIFees = value; }
        private DirtyValue<bool?> _withOriginalCreditor;
        public bool? WithOriginalCreditor { get => _withOriginalCreditor; set => _withOriginalCreditor = value; }
        private DirtyValue<DateTime?> _writtenApplicationDate;
        public DateTime? WrittenApplicationDate { get => _writtenApplicationDate; set => _writtenApplicationDate = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _affiliatesFees.Dirty
                    || _aPORMaxBonaFideDiscountPoint.Dirty
                    || _aRMRecastDate.Dirty
                    || _aRMRecastMonthlyPayment.Dirty
                    || _assetRepresentationAndWarrantyReliefEligibilityType.Dirty
                    || _aTRLoanType.Dirty
                    || _aUSDataDiscrepencyResolutionComments.Dirty
                    || _aUSDataDiscrepencyResolutionDate.Dirty
                    || _aUSDataDiscrepencyResolvedBy.Dirty
                    || _bonaFideDiscountPoint.Dirty
                    || _bonaFideDiscountPointAmount.Dirty
                    || _brokerCompensationWhenRateSet.Dirty
                    || _collateralRepandWarrReliefEligibilityType.Dirty
                    || _compensationPTBFees.Dirty
                    || _creditInsPremiumFees.Dirty
                    || _creditorType.Dirty
                    || _creditorTypeDescription.Dirty
                    || _creditType.Dirty
                    || _currentQMFeeThresholdAmt.Dirty
                    || _currentQMFeeThresholdPercent.Dirty
                    || _dateOfLastMonthlyPayment.Dirty
                    || _discountPointAmount.Dirty
                    || _discountPointFees.Dirty
                    || _discountPointPercentage.Dirty
                    || _documentationGuidelineMessages4V.Dirty
                    || _documentationGuidelineMessages5C.Dirty
                    || _documentationGuidelineMessages8Y.Dirty
                    || _documentationGuidelineMessagesCN.Dirty
                    || _documentationGuidelineMessagesCP.Dirty
                    || _documentationGuidelineMessagesCV.Dirty
                    || _documentationGuidelineMessagesCY.Dirty
                    || _documentationGuidelineMessagesCZ.Dirty
                    || _documentationGuidelineMessagesDP.Dirty
                    || _documentationGuidelineMessagesDZ.Dirty
                    || _documentationGuidelineMessagesE5.Dirty
                    || _documentationGuidelineMessagesIM.Dirty
                    || _documentationGuidelineMessagesIQ.Dirty
                    || _documentationGuidelineMessagesJF.Dirty
                    || _documentationGuidelineMessagesQJ.Dirty
                    || _documentationGuidelineMessagesQN.Dirty
                    || _documentationGuidelineMessagesQQ.Dirty
                    || _documentationGuidelineMessagesQS.Dirty
                    || _documentationGuidelineMessagesU7.Dirty
                    || _documentationGuidelineMessagesX1.Dirty
                    || _documentationGuidelineMessagesX3.Dirty
                    || _documentationGuidelineMessagesX5.Dirty
                    || _documentationGuidelineMessagesX7.Dirty
                    || _documentationGuidelineMessagesXA.Dirty
                    || _documentationGuidelineMessagesXM.Dirty
                    || _documentationGuidelineMessagesXP.Dirty
                    || _documentationGuidelineMessagesXR.Dirty
                    || _documentationGuidelineMessagesXT.Dirty
                    || _documentationGuidelineMessagesY8.Dirty
                    || _documentationGuidelineMessagesYG.Dirty
                    || _documentationGuidelineMessagesYJ.Dirty
                    || _documentationGuidelineMessagesYY.Dirty
                    || _documentationGuidelineMessagesYZ.Dirty
                    || _eligibleNonStandardToStandard.Dirty
                    || _financeChargeFees.Dirty
                    || _firstChangeRecase.Dirty
                    || _firstPmtDateAfterRecast.Dirty
                    || _fullPaymentAfterInterestOnly.Dirty
                    || _fullyARMPaymentAfterNegAm.Dirty
                    || _fullyIndexRateHousingRatio.Dirty
                    || _fullyIndexRateMaxTotalPayment.Dirty
                    || _fullyIndexRateMonthlyPayment.Dirty
                    || _fullyIndexRateTotalDebtRatio.Dirty
                    || _generalATRStatusAlimony.Dirty
                    || _generalATRStatusAssets.Dirty
                    || _generalATRStatusChildSupport.Dirty
                    || _generalATRStatusCoveredLoan.Dirty
                    || _generalATRStatusCreditHistory.Dirty
                    || _generalATRStatusDebtObligations.Dirty
                    || _generalATRStatusDTI.Dirty
                    || _generalATRStatusEmployment.Dirty
                    || _generalATRStatusIncome.Dirty
                    || _generalATRStatusMtgRelatedObligations.Dirty
                    || _generalATRStatusOverall.Dirty
                    || _generalATRStatusResidualIncome.Dirty
                    || _generalATRStatusSimultaneousLoan.Dirty
                    || _gSEAgencyQMCalculatedThreshold.Dirty
                    || _gSEAgencyQMStatusAlimony.Dirty
                    || _gSEAgencyQMStatusAssets.Dirty
                    || _gSEAgencyQMStatusBalloonPayment.Dirty
                    || _gSEAgencyQMStatusChildSupport.Dirty
                    || _gSEAgencyQMStatusCoveredLoan.Dirty
                    || _gSEAgencyQMStatusCreditHistory.Dirty
                    || _gSEAgencyQMStatusDebtObligations.Dirty
                    || _gSEAgencyQMStatusDTI.Dirty
                    || _gSEAgencyQMStatusEmployment.Dirty
                    || _gSEAgencyQMStatusIncome.Dirty
                    || _gSEAgencyQMStatusInterestOnly.Dirty
                    || _gSEAgencyQMStatusLoanTerm.Dirty
                    || _gSEAgencyQMStatusMtgRelatedObligations.Dirty
                    || _gSEAgencyQMStatusNegativeAmortization.Dirty
                    || _gSEAgencyQMStatusOverall.Dirty
                    || _gSEAgencyQMStatusPointsFeesLimit.Dirty
                    || _gSEAgencyQMStatusPrepaymentPenalty.Dirty
                    || _gSEAgencyQMStatusResidualIncome.Dirty
                    || _gSEAgencyQMStatusSafeHarborEligibility.Dirty
                    || _gSEAgencyQMStatusSimultaneousLoan.Dirty
                    || _has30DayLatePayment.Dirty
                    || _id.Dirty
                    || _initialMaxTotalPayment.Dirty
                    || _initialRateHousingRatio.Dirty
                    || _initialRateMonthlyPayment.Dirty
                    || _initialRateTotalDebtRatio.Dirty
                    || _interestOnlyMonths.Dirty
                    || _interestOnlyRecastDate.Dirty
                    || _isConsumerLiklyDefault.Dirty
                    || _isEligibleForSafeHarbor.Dirty
                    || _isEvaluatedAlimonyObligations.Dirty
                    || _isEvaluatedChildSupportObligations.Dirty
                    || _isEvaluatedCreditHistory.Dirty
                    || _isEvaluatedCurrentEmploymentStatus.Dirty
                    || _isEvaluatedCurrentExpectedAssets.Dirty
                    || _isEvaluatedCurrentExpectedIncome.Dirty
                    || _isEvaluatedDebtObligations.Dirty
                    || _isEvaluatedDebtToIncomeRatio.Dirty
                    || _isEvaluatedMonthlyCoveredLoanPayment.Dirty
                    || _isEvaluatedMonthlyMortgageRelatedObligations.Dirty
                    || _isEvaluatedMonthlySimultaneousLoanPayment.Dirty
                    || _isEvaluatedResidualIncome.Dirty
                    || _isHigherPricedLoan.Dirty
                    || _loanProcessingInformationCode24.Dirty
                    || _loanProcessingInformationCode31.Dirty
                    || _loanProcessingInformationCode32.Dirty
                    || _loanProcessingInformationCode33.Dirty
                    || _loanProcessingInformationCode97.Dirty
                    || _loanProcessingInformationCodeJr.Dirty
                    || _loanProcessingInformationCodeJt.Dirty
                    || _loanProcessingInformationD4.Dirty
                    || _loanProcessingInformationGO.Dirty
                    || _loanProcessingInformationHA.Dirty
                    || _loanProcessingInformationLE.Dirty
                    || _loanProcessingInformationLF.Dirty
                    || _loanProcessingInformationMA.Dirty
                    || _loanProgram.Dirty
                    || _loanProgramDescription.Dirty
                    || _loanRateFixedin5Years.Dirty
                    || _lOBrokerCompensationAmount.Dirty
                    || _max5YrsHousingRatio.Dirty
                    || _max5YrsPrincipleAndInterest.Dirty
                    || _max5YrsTotalDebtRatio.Dirty
                    || _max5YrsTotalPayment.Dirty
                    || _maxPrepaymentPenaltyFees.Dirty
                    || _negAmRecastDate.Dirty
                    || _paymentDecreasedBy10Percent.Dirty
                    || _pointsFeesThresholdMet.Dirty
                    || _prepaymentPenaltyPayoffFees.Dirty
                    || _prepayPenaltyPercentage.Dirty
                    || _preventConsumersDefault.Dirty
                    || _principalBalanceIncreased.Dirty
                    || _principalHasDeferred.Dirty
                    || _qMLoanType.Dirty
                    || _rateReductionBasisPoints.Dirty
                    || _rateReductionDiscountPoints.Dirty
                    || _rateReductionMaxBonaFideDiscountPoint.Dirty
                    || _realEstateFees.Dirty
                    || _recastDifferencePayment.Dirty
                    || _regZTotalLoanAmount.Dirty
                    || _requiredServicesLenderSelectedAmt.Dirty
                    || _smallCreditorQMCalculatedThreshold.Dirty
                    || _smallCreditorQMStatusAlimony.Dirty
                    || _smallCreditorQMStatusAssets.Dirty
                    || _smallCreditorQMStatusBalloonPayment.Dirty
                    || _smallCreditorQMStatusChildSupport.Dirty
                    || _smallCreditorQMStatusCoveredLoan.Dirty
                    || _smallCreditorQMStatusDebtObligations.Dirty
                    || _smallCreditorQMStatusDTI.Dirty
                    || _smallCreditorQMStatusIncome.Dirty
                    || _smallCreditorQMStatusInterestOnly.Dirty
                    || _smallCreditorQMStatusLoanTerm.Dirty
                    || _smallCreditorQMStatusMtgRelatedObligations.Dirty
                    || _smallCreditorQMStatusNegativeAmortization.Dirty
                    || _smallCreditorQMStatusOverall.Dirty
                    || _smallCreditorQMStatusPointsFeesLimit.Dirty
                    || _smallCreditorQMStatusPrepaymentPenalty.Dirty
                    || _smallCreditorQMStatusResidualIncome.Dirty
                    || _smallCreditorQMStatusSafeHarborEligibility.Dirty
                    || _standardQMCalculatedThreshold.Dirty
                    || _standardQMStatusAlimony.Dirty
                    || _standardQMStatusAssets.Dirty
                    || _standardQMStatusBalloonPayment.Dirty
                    || _standardQMStatusChildSupport.Dirty
                    || _standardQMStatusCoveredLoan.Dirty
                    || _standardQMStatusCreditHistory.Dirty
                    || _standardQMStatusDebtObligations.Dirty
                    || _standardQMStatusDTI.Dirty
                    || _standardQMStatusEmployment.Dirty
                    || _standardQMStatusIncome.Dirty
                    || _standardQMStatusInterestOnly.Dirty
                    || _standardQMStatusLoanTerm.Dirty
                    || _standardQMStatusMtgRelatedObligations.Dirty
                    || _standardQMStatusNegativeAmortization.Dirty
                    || _standardQMStatusOverall.Dirty
                    || _standardQMStatusPointsFeesLimit.Dirty
                    || _standardQMStatusPrepaymentPenalty.Dirty
                    || _standardQMStatusResidualIncome.Dirty
                    || _standardQMStatusSafeHarborEligibility.Dirty
                    || _standardQMStatusSimultaneousLoan.Dirty
                    || _startingAdjustedRateMaxBonaFideDiscountPoint.Dirty
                    || _statusCreditHistory.Dirty
                    || _statusSimultaneousLoan.Dirty
                    || _thresholdExceedsQM.Dirty
                    || _titleServicesLenderTitleinsuranceFee.Dirty
                    || _totalCoMortgagorIncome.Dirty
                    || _totalIncome.Dirty
                    || _totalPointsFeesSec32Percent.Dirty
                    || _transactionExemptFromRegZ.Dirty
                    || _ucdRequirement.Dirty
                    || _unitCount.Dirty
                    || _upfrontPMIFees.Dirty
                    || _withOriginalCreditor.Dirty
                    || _writtenApplicationDate.Dirty;
            }
            set
            {
                _affiliatesFees.Dirty = value;
                _aPORMaxBonaFideDiscountPoint.Dirty = value;
                _aRMRecastDate.Dirty = value;
                _aRMRecastMonthlyPayment.Dirty = value;
                _assetRepresentationAndWarrantyReliefEligibilityType.Dirty = value;
                _aTRLoanType.Dirty = value;
                _aUSDataDiscrepencyResolutionComments.Dirty = value;
                _aUSDataDiscrepencyResolutionDate.Dirty = value;
                _aUSDataDiscrepencyResolvedBy.Dirty = value;
                _bonaFideDiscountPoint.Dirty = value;
                _bonaFideDiscountPointAmount.Dirty = value;
                _brokerCompensationWhenRateSet.Dirty = value;
                _collateralRepandWarrReliefEligibilityType.Dirty = value;
                _compensationPTBFees.Dirty = value;
                _creditInsPremiumFees.Dirty = value;
                _creditorType.Dirty = value;
                _creditorTypeDescription.Dirty = value;
                _creditType.Dirty = value;
                _currentQMFeeThresholdAmt.Dirty = value;
                _currentQMFeeThresholdPercent.Dirty = value;
                _dateOfLastMonthlyPayment.Dirty = value;
                _discountPointAmount.Dirty = value;
                _discountPointFees.Dirty = value;
                _discountPointPercentage.Dirty = value;
                _documentationGuidelineMessages4V.Dirty = value;
                _documentationGuidelineMessages5C.Dirty = value;
                _documentationGuidelineMessages8Y.Dirty = value;
                _documentationGuidelineMessagesCN.Dirty = value;
                _documentationGuidelineMessagesCP.Dirty = value;
                _documentationGuidelineMessagesCV.Dirty = value;
                _documentationGuidelineMessagesCY.Dirty = value;
                _documentationGuidelineMessagesCZ.Dirty = value;
                _documentationGuidelineMessagesDP.Dirty = value;
                _documentationGuidelineMessagesDZ.Dirty = value;
                _documentationGuidelineMessagesE5.Dirty = value;
                _documentationGuidelineMessagesIM.Dirty = value;
                _documentationGuidelineMessagesIQ.Dirty = value;
                _documentationGuidelineMessagesJF.Dirty = value;
                _documentationGuidelineMessagesQJ.Dirty = value;
                _documentationGuidelineMessagesQN.Dirty = value;
                _documentationGuidelineMessagesQQ.Dirty = value;
                _documentationGuidelineMessagesQS.Dirty = value;
                _documentationGuidelineMessagesU7.Dirty = value;
                _documentationGuidelineMessagesX1.Dirty = value;
                _documentationGuidelineMessagesX3.Dirty = value;
                _documentationGuidelineMessagesX5.Dirty = value;
                _documentationGuidelineMessagesX7.Dirty = value;
                _documentationGuidelineMessagesXA.Dirty = value;
                _documentationGuidelineMessagesXM.Dirty = value;
                _documentationGuidelineMessagesXP.Dirty = value;
                _documentationGuidelineMessagesXR.Dirty = value;
                _documentationGuidelineMessagesXT.Dirty = value;
                _documentationGuidelineMessagesY8.Dirty = value;
                _documentationGuidelineMessagesYG.Dirty = value;
                _documentationGuidelineMessagesYJ.Dirty = value;
                _documentationGuidelineMessagesYY.Dirty = value;
                _documentationGuidelineMessagesYZ.Dirty = value;
                _eligibleNonStandardToStandard.Dirty = value;
                _financeChargeFees.Dirty = value;
                _firstChangeRecase.Dirty = value;
                _firstPmtDateAfterRecast.Dirty = value;
                _fullPaymentAfterInterestOnly.Dirty = value;
                _fullyARMPaymentAfterNegAm.Dirty = value;
                _fullyIndexRateHousingRatio.Dirty = value;
                _fullyIndexRateMaxTotalPayment.Dirty = value;
                _fullyIndexRateMonthlyPayment.Dirty = value;
                _fullyIndexRateTotalDebtRatio.Dirty = value;
                _generalATRStatusAlimony.Dirty = value;
                _generalATRStatusAssets.Dirty = value;
                _generalATRStatusChildSupport.Dirty = value;
                _generalATRStatusCoveredLoan.Dirty = value;
                _generalATRStatusCreditHistory.Dirty = value;
                _generalATRStatusDebtObligations.Dirty = value;
                _generalATRStatusDTI.Dirty = value;
                _generalATRStatusEmployment.Dirty = value;
                _generalATRStatusIncome.Dirty = value;
                _generalATRStatusMtgRelatedObligations.Dirty = value;
                _generalATRStatusOverall.Dirty = value;
                _generalATRStatusResidualIncome.Dirty = value;
                _generalATRStatusSimultaneousLoan.Dirty = value;
                _gSEAgencyQMCalculatedThreshold.Dirty = value;
                _gSEAgencyQMStatusAlimony.Dirty = value;
                _gSEAgencyQMStatusAssets.Dirty = value;
                _gSEAgencyQMStatusBalloonPayment.Dirty = value;
                _gSEAgencyQMStatusChildSupport.Dirty = value;
                _gSEAgencyQMStatusCoveredLoan.Dirty = value;
                _gSEAgencyQMStatusCreditHistory.Dirty = value;
                _gSEAgencyQMStatusDebtObligations.Dirty = value;
                _gSEAgencyQMStatusDTI.Dirty = value;
                _gSEAgencyQMStatusEmployment.Dirty = value;
                _gSEAgencyQMStatusIncome.Dirty = value;
                _gSEAgencyQMStatusInterestOnly.Dirty = value;
                _gSEAgencyQMStatusLoanTerm.Dirty = value;
                _gSEAgencyQMStatusMtgRelatedObligations.Dirty = value;
                _gSEAgencyQMStatusNegativeAmortization.Dirty = value;
                _gSEAgencyQMStatusOverall.Dirty = value;
                _gSEAgencyQMStatusPointsFeesLimit.Dirty = value;
                _gSEAgencyQMStatusPrepaymentPenalty.Dirty = value;
                _gSEAgencyQMStatusResidualIncome.Dirty = value;
                _gSEAgencyQMStatusSafeHarborEligibility.Dirty = value;
                _gSEAgencyQMStatusSimultaneousLoan.Dirty = value;
                _has30DayLatePayment.Dirty = value;
                _id.Dirty = value;
                _initialMaxTotalPayment.Dirty = value;
                _initialRateHousingRatio.Dirty = value;
                _initialRateMonthlyPayment.Dirty = value;
                _initialRateTotalDebtRatio.Dirty = value;
                _interestOnlyMonths.Dirty = value;
                _interestOnlyRecastDate.Dirty = value;
                _isConsumerLiklyDefault.Dirty = value;
                _isEligibleForSafeHarbor.Dirty = value;
                _isEvaluatedAlimonyObligations.Dirty = value;
                _isEvaluatedChildSupportObligations.Dirty = value;
                _isEvaluatedCreditHistory.Dirty = value;
                _isEvaluatedCurrentEmploymentStatus.Dirty = value;
                _isEvaluatedCurrentExpectedAssets.Dirty = value;
                _isEvaluatedCurrentExpectedIncome.Dirty = value;
                _isEvaluatedDebtObligations.Dirty = value;
                _isEvaluatedDebtToIncomeRatio.Dirty = value;
                _isEvaluatedMonthlyCoveredLoanPayment.Dirty = value;
                _isEvaluatedMonthlyMortgageRelatedObligations.Dirty = value;
                _isEvaluatedMonthlySimultaneousLoanPayment.Dirty = value;
                _isEvaluatedResidualIncome.Dirty = value;
                _isHigherPricedLoan.Dirty = value;
                _loanProcessingInformationCode24.Dirty = value;
                _loanProcessingInformationCode31.Dirty = value;
                _loanProcessingInformationCode32.Dirty = value;
                _loanProcessingInformationCode33.Dirty = value;
                _loanProcessingInformationCode97.Dirty = value;
                _loanProcessingInformationCodeJr.Dirty = value;
                _loanProcessingInformationCodeJt.Dirty = value;
                _loanProcessingInformationD4.Dirty = value;
                _loanProcessingInformationGO.Dirty = value;
                _loanProcessingInformationHA.Dirty = value;
                _loanProcessingInformationLE.Dirty = value;
                _loanProcessingInformationLF.Dirty = value;
                _loanProcessingInformationMA.Dirty = value;
                _loanProgram.Dirty = value;
                _loanProgramDescription.Dirty = value;
                _loanRateFixedin5Years.Dirty = value;
                _lOBrokerCompensationAmount.Dirty = value;
                _max5YrsHousingRatio.Dirty = value;
                _max5YrsPrincipleAndInterest.Dirty = value;
                _max5YrsTotalDebtRatio.Dirty = value;
                _max5YrsTotalPayment.Dirty = value;
                _maxPrepaymentPenaltyFees.Dirty = value;
                _negAmRecastDate.Dirty = value;
                _paymentDecreasedBy10Percent.Dirty = value;
                _pointsFeesThresholdMet.Dirty = value;
                _prepaymentPenaltyPayoffFees.Dirty = value;
                _prepayPenaltyPercentage.Dirty = value;
                _preventConsumersDefault.Dirty = value;
                _principalBalanceIncreased.Dirty = value;
                _principalHasDeferred.Dirty = value;
                _qMLoanType.Dirty = value;
                _rateReductionBasisPoints.Dirty = value;
                _rateReductionDiscountPoints.Dirty = value;
                _rateReductionMaxBonaFideDiscountPoint.Dirty = value;
                _realEstateFees.Dirty = value;
                _recastDifferencePayment.Dirty = value;
                _regZTotalLoanAmount.Dirty = value;
                _requiredServicesLenderSelectedAmt.Dirty = value;
                _smallCreditorQMCalculatedThreshold.Dirty = value;
                _smallCreditorQMStatusAlimony.Dirty = value;
                _smallCreditorQMStatusAssets.Dirty = value;
                _smallCreditorQMStatusBalloonPayment.Dirty = value;
                _smallCreditorQMStatusChildSupport.Dirty = value;
                _smallCreditorQMStatusCoveredLoan.Dirty = value;
                _smallCreditorQMStatusDebtObligations.Dirty = value;
                _smallCreditorQMStatusDTI.Dirty = value;
                _smallCreditorQMStatusIncome.Dirty = value;
                _smallCreditorQMStatusInterestOnly.Dirty = value;
                _smallCreditorQMStatusLoanTerm.Dirty = value;
                _smallCreditorQMStatusMtgRelatedObligations.Dirty = value;
                _smallCreditorQMStatusNegativeAmortization.Dirty = value;
                _smallCreditorQMStatusOverall.Dirty = value;
                _smallCreditorQMStatusPointsFeesLimit.Dirty = value;
                _smallCreditorQMStatusPrepaymentPenalty.Dirty = value;
                _smallCreditorQMStatusResidualIncome.Dirty = value;
                _smallCreditorQMStatusSafeHarborEligibility.Dirty = value;
                _standardQMCalculatedThreshold.Dirty = value;
                _standardQMStatusAlimony.Dirty = value;
                _standardQMStatusAssets.Dirty = value;
                _standardQMStatusBalloonPayment.Dirty = value;
                _standardQMStatusChildSupport.Dirty = value;
                _standardQMStatusCoveredLoan.Dirty = value;
                _standardQMStatusCreditHistory.Dirty = value;
                _standardQMStatusDebtObligations.Dirty = value;
                _standardQMStatusDTI.Dirty = value;
                _standardQMStatusEmployment.Dirty = value;
                _standardQMStatusIncome.Dirty = value;
                _standardQMStatusInterestOnly.Dirty = value;
                _standardQMStatusLoanTerm.Dirty = value;
                _standardQMStatusMtgRelatedObligations.Dirty = value;
                _standardQMStatusNegativeAmortization.Dirty = value;
                _standardQMStatusOverall.Dirty = value;
                _standardQMStatusPointsFeesLimit.Dirty = value;
                _standardQMStatusPrepaymentPenalty.Dirty = value;
                _standardQMStatusResidualIncome.Dirty = value;
                _standardQMStatusSafeHarborEligibility.Dirty = value;
                _standardQMStatusSimultaneousLoan.Dirty = value;
                _startingAdjustedRateMaxBonaFideDiscountPoint.Dirty = value;
                _statusCreditHistory.Dirty = value;
                _statusSimultaneousLoan.Dirty = value;
                _thresholdExceedsQM.Dirty = value;
                _titleServicesLenderTitleinsuranceFee.Dirty = value;
                _totalCoMortgagorIncome.Dirty = value;
                _totalIncome.Dirty = value;
                _totalPointsFeesSec32Percent.Dirty = value;
                _transactionExemptFromRegZ.Dirty = value;
                _ucdRequirement.Dirty = value;
                _unitCount.Dirty = value;
                _upfrontPMIFees.Dirty = value;
                _withOriginalCreditor.Dirty = value;
                _writtenApplicationDate.Dirty = value;
            }
        }
    }
}