using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ATRQMCommon : IDirty
    {
        private DirtyValue<decimal?> _affiliatesFees;
        public decimal? AffiliatesFees { get { return _affiliatesFees; } set { _affiliatesFees = value; } }
        private DirtyValue<decimal?> _aPORMaxBonaFideDiscountPoint;
        public decimal? APORMaxBonaFideDiscountPoint { get { return _aPORMaxBonaFideDiscountPoint; } set { _aPORMaxBonaFideDiscountPoint = value; } }
        private DirtyValue<DateTime?> _aRMRecastDate;
        public DateTime? ARMRecastDate { get { return _aRMRecastDate; } set { _aRMRecastDate = value; } }
        private DirtyValue<decimal?> _aRMRecastMonthlyPayment;
        public decimal? ARMRecastMonthlyPayment { get { return _aRMRecastMonthlyPayment; } set { _aRMRecastMonthlyPayment = value; } }
        private DirtyValue<string> _aTRLoanType;
        public string ATRLoanType { get { return _aTRLoanType; } set { _aTRLoanType = value; } }
        private DirtyValue<string> _aUSDataDiscrepencyResolutionComments;
        public string AUSDataDiscrepencyResolutionComments { get { return _aUSDataDiscrepencyResolutionComments; } set { _aUSDataDiscrepencyResolutionComments = value; } }
        private DirtyValue<DateTime?> _aUSDataDiscrepencyResolutionDate;
        public DateTime? AUSDataDiscrepencyResolutionDate { get { return _aUSDataDiscrepencyResolutionDate; } set { _aUSDataDiscrepencyResolutionDate = value; } }
        private DirtyValue<string> _aUSDataDiscrepencyResolvedBy;
        public string AUSDataDiscrepencyResolvedBy { get { return _aUSDataDiscrepencyResolvedBy; } set { _aUSDataDiscrepencyResolvedBy = value; } }
        private DirtyValue<decimal?> _bonaFideDiscountPoint;
        public decimal? BonaFideDiscountPoint { get { return _bonaFideDiscountPoint; } set { _bonaFideDiscountPoint = value; } }
        private DirtyValue<decimal?> _bonaFideDiscountPointAmount;
        public decimal? BonaFideDiscountPointAmount { get { return _bonaFideDiscountPointAmount; } set { _bonaFideDiscountPointAmount = value; } }
        private DirtyValue<bool?> _brokerCompensationWhenRateSet;
        public bool? BrokerCompensationWhenRateSet { get { return _brokerCompensationWhenRateSet; } set { _brokerCompensationWhenRateSet = value; } }
        private DirtyValue<string> _collateralRepandWarrReliefEligibilityType;
        public string CollateralRepandWarrReliefEligibilityType { get { return _collateralRepandWarrReliefEligibilityType; } set { _collateralRepandWarrReliefEligibilityType = value; } }
        private DirtyValue<decimal?> _compensationPTBFees;
        public decimal? CompensationPTBFees { get { return _compensationPTBFees; } set { _compensationPTBFees = value; } }
        private DirtyValue<decimal?> _creditInsPremiumFees;
        public decimal? CreditInsPremiumFees { get { return _creditInsPremiumFees; } set { _creditInsPremiumFees = value; } }
        private DirtyValue<bool?> _creditorType;
        public bool? CreditorType { get { return _creditorType; } set { _creditorType = value; } }
        private DirtyValue<string> _creditorTypeDescription;
        public string CreditorTypeDescription { get { return _creditorTypeDescription; } set { _creditorTypeDescription = value; } }
        private DirtyValue<bool?> _creditType;
        public bool? CreditType { get { return _creditType; } set { _creditType = value; } }
        private DirtyValue<decimal?> _currentQMFeeThresholdAmt;
        public decimal? CurrentQMFeeThresholdAmt { get { return _currentQMFeeThresholdAmt; } set { _currentQMFeeThresholdAmt = value; } }
        private DirtyValue<decimal?> _currentQMFeeThresholdPercent;
        public decimal? CurrentQMFeeThresholdPercent { get { return _currentQMFeeThresholdPercent; } set { _currentQMFeeThresholdPercent = value; } }
        private DirtyValue<DateTime?> _dateOfLastMonthlyPayment;
        public DateTime? DateOfLastMonthlyPayment { get { return _dateOfLastMonthlyPayment; } set { _dateOfLastMonthlyPayment = value; } }
        private DirtyValue<decimal?> _discountPointAmount;
        public decimal? DiscountPointAmount { get { return _discountPointAmount; } set { _discountPointAmount = value; } }
        private DirtyValue<decimal?> _discountPointFees;
        public decimal? DiscountPointFees { get { return _discountPointFees; } set { _discountPointFees = value; } }
        private DirtyValue<decimal?> _discountPointPercentage;
        public decimal? DiscountPointPercentage { get { return _discountPointPercentage; } set { _discountPointPercentage = value; } }
        private DirtyValue<string> _documentationGuidelineMessages4V;
        public string DocumentationGuidelineMessages4V { get { return _documentationGuidelineMessages4V; } set { _documentationGuidelineMessages4V = value; } }
        private DirtyValue<string> _documentationGuidelineMessages5C;
        public string DocumentationGuidelineMessages5C { get { return _documentationGuidelineMessages5C; } set { _documentationGuidelineMessages5C = value; } }
        private DirtyValue<string> _documentationGuidelineMessages8Y;
        public string DocumentationGuidelineMessages8Y { get { return _documentationGuidelineMessages8Y; } set { _documentationGuidelineMessages8Y = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesCN;
        public string DocumentationGuidelineMessagesCN { get { return _documentationGuidelineMessagesCN; } set { _documentationGuidelineMessagesCN = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesCP;
        public string DocumentationGuidelineMessagesCP { get { return _documentationGuidelineMessagesCP; } set { _documentationGuidelineMessagesCP = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesCV;
        public string DocumentationGuidelineMessagesCV { get { return _documentationGuidelineMessagesCV; } set { _documentationGuidelineMessagesCV = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesCY;
        public string DocumentationGuidelineMessagesCY { get { return _documentationGuidelineMessagesCY; } set { _documentationGuidelineMessagesCY = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesCZ;
        public string DocumentationGuidelineMessagesCZ { get { return _documentationGuidelineMessagesCZ; } set { _documentationGuidelineMessagesCZ = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesDP;
        public string DocumentationGuidelineMessagesDP { get { return _documentationGuidelineMessagesDP; } set { _documentationGuidelineMessagesDP = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesDZ;
        public string DocumentationGuidelineMessagesDZ { get { return _documentationGuidelineMessagesDZ; } set { _documentationGuidelineMessagesDZ = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesE5;
        public string DocumentationGuidelineMessagesE5 { get { return _documentationGuidelineMessagesE5; } set { _documentationGuidelineMessagesE5 = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesIM;
        public string DocumentationGuidelineMessagesIM { get { return _documentationGuidelineMessagesIM; } set { _documentationGuidelineMessagesIM = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesIQ;
        public string DocumentationGuidelineMessagesIQ { get { return _documentationGuidelineMessagesIQ; } set { _documentationGuidelineMessagesIQ = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesJF;
        public string DocumentationGuidelineMessagesJF { get { return _documentationGuidelineMessagesJF; } set { _documentationGuidelineMessagesJF = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesQJ;
        public string DocumentationGuidelineMessagesQJ { get { return _documentationGuidelineMessagesQJ; } set { _documentationGuidelineMessagesQJ = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesQN;
        public string DocumentationGuidelineMessagesQN { get { return _documentationGuidelineMessagesQN; } set { _documentationGuidelineMessagesQN = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesQQ;
        public string DocumentationGuidelineMessagesQQ { get { return _documentationGuidelineMessagesQQ; } set { _documentationGuidelineMessagesQQ = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesQS;
        public string DocumentationGuidelineMessagesQS { get { return _documentationGuidelineMessagesQS; } set { _documentationGuidelineMessagesQS = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesU7;
        public string DocumentationGuidelineMessagesU7 { get { return _documentationGuidelineMessagesU7; } set { _documentationGuidelineMessagesU7 = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesX1;
        public string DocumentationGuidelineMessagesX1 { get { return _documentationGuidelineMessagesX1; } set { _documentationGuidelineMessagesX1 = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesX3;
        public string DocumentationGuidelineMessagesX3 { get { return _documentationGuidelineMessagesX3; } set { _documentationGuidelineMessagesX3 = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesX5;
        public string DocumentationGuidelineMessagesX5 { get { return _documentationGuidelineMessagesX5; } set { _documentationGuidelineMessagesX5 = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesX7;
        public string DocumentationGuidelineMessagesX7 { get { return _documentationGuidelineMessagesX7; } set { _documentationGuidelineMessagesX7 = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesXA;
        public string DocumentationGuidelineMessagesXA { get { return _documentationGuidelineMessagesXA; } set { _documentationGuidelineMessagesXA = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesXM;
        public string DocumentationGuidelineMessagesXM { get { return _documentationGuidelineMessagesXM; } set { _documentationGuidelineMessagesXM = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesXP;
        public string DocumentationGuidelineMessagesXP { get { return _documentationGuidelineMessagesXP; } set { _documentationGuidelineMessagesXP = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesXR;
        public string DocumentationGuidelineMessagesXR { get { return _documentationGuidelineMessagesXR; } set { _documentationGuidelineMessagesXR = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesXT;
        public string DocumentationGuidelineMessagesXT { get { return _documentationGuidelineMessagesXT; } set { _documentationGuidelineMessagesXT = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesY8;
        public string DocumentationGuidelineMessagesY8 { get { return _documentationGuidelineMessagesY8; } set { _documentationGuidelineMessagesY8 = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesYG;
        public string DocumentationGuidelineMessagesYG { get { return _documentationGuidelineMessagesYG; } set { _documentationGuidelineMessagesYG = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesYJ;
        public string DocumentationGuidelineMessagesYJ { get { return _documentationGuidelineMessagesYJ; } set { _documentationGuidelineMessagesYJ = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesYY;
        public string DocumentationGuidelineMessagesYY { get { return _documentationGuidelineMessagesYY; } set { _documentationGuidelineMessagesYY = value; } }
        private DirtyValue<string> _documentationGuidelineMessagesYZ;
        public string DocumentationGuidelineMessagesYZ { get { return _documentationGuidelineMessagesYZ; } set { _documentationGuidelineMessagesYZ = value; } }
        private DirtyValue<string> _eligibleNonStandardToStandard;
        public string EligibleNonStandardToStandard { get { return _eligibleNonStandardToStandard; } set { _eligibleNonStandardToStandard = value; } }
        private DirtyValue<decimal?> _financeChargeFees;
        public decimal? FinanceChargeFees { get { return _financeChargeFees; } set { _financeChargeFees = value; } }
        private DirtyValue<int?> _firstChangeRecase;
        public int? FirstChangeRecase { get { return _firstChangeRecase; } set { _firstChangeRecase = value; } }
        private DirtyValue<DateTime?> _firstPmtDateAfterRecast;
        public DateTime? FirstPmtDateAfterRecast { get { return _firstPmtDateAfterRecast; } set { _firstPmtDateAfterRecast = value; } }
        private DirtyValue<decimal?> _fullPaymentAfterInterestOnly;
        public decimal? FullPaymentAfterInterestOnly { get { return _fullPaymentAfterInterestOnly; } set { _fullPaymentAfterInterestOnly = value; } }
        private DirtyValue<decimal?> _fullyARMPaymentAfterNegAm;
        public decimal? FullyARMPaymentAfterNegAm { get { return _fullyARMPaymentAfterNegAm; } set { _fullyARMPaymentAfterNegAm = value; } }
        private DirtyValue<decimal?> _fullyIndexRateHousingRatio;
        public decimal? FullyIndexRateHousingRatio { get { return _fullyIndexRateHousingRatio; } set { _fullyIndexRateHousingRatio = value; } }
        private DirtyValue<decimal?> _fullyIndexRateMaxTotalPayment;
        public decimal? FullyIndexRateMaxTotalPayment { get { return _fullyIndexRateMaxTotalPayment; } set { _fullyIndexRateMaxTotalPayment = value; } }
        private DirtyValue<decimal?> _fullyIndexRateMonthlyPayment;
        public decimal? FullyIndexRateMonthlyPayment { get { return _fullyIndexRateMonthlyPayment; } set { _fullyIndexRateMonthlyPayment = value; } }
        private DirtyValue<decimal?> _fullyIndexRateTotalDebtRatio;
        public decimal? FullyIndexRateTotalDebtRatio { get { return _fullyIndexRateTotalDebtRatio; } set { _fullyIndexRateTotalDebtRatio = value; } }
        private DirtyValue<string> _generalATR_Status_Alimony;
        public string GeneralATR_Status_Alimony { get { return _generalATR_Status_Alimony; } set { _generalATR_Status_Alimony = value; } }
        private DirtyValue<string> _generalATR_Status_Assets;
        public string GeneralATR_Status_Assets { get { return _generalATR_Status_Assets; } set { _generalATR_Status_Assets = value; } }
        private DirtyValue<string> _generalATR_Status_ChildSupport;
        public string GeneralATR_Status_ChildSupport { get { return _generalATR_Status_ChildSupport; } set { _generalATR_Status_ChildSupport = value; } }
        private DirtyValue<string> _generalATR_Status_CoveredLoan;
        public string GeneralATR_Status_CoveredLoan { get { return _generalATR_Status_CoveredLoan; } set { _generalATR_Status_CoveredLoan = value; } }
        private DirtyValue<string> _generalATR_Status_CreditHistory;
        public string GeneralATR_Status_CreditHistory { get { return _generalATR_Status_CreditHistory; } set { _generalATR_Status_CreditHistory = value; } }
        private DirtyValue<string> _generalATR_Status_DebtObligations;
        public string GeneralATR_Status_DebtObligations { get { return _generalATR_Status_DebtObligations; } set { _generalATR_Status_DebtObligations = value; } }
        private DirtyValue<string> _generalATR_Status_DTI;
        public string GeneralATR_Status_DTI { get { return _generalATR_Status_DTI; } set { _generalATR_Status_DTI = value; } }
        private DirtyValue<string> _generalATR_Status_Employment;
        public string GeneralATR_Status_Employment { get { return _generalATR_Status_Employment; } set { _generalATR_Status_Employment = value; } }
        private DirtyValue<string> _generalATR_Status_Income;
        public string GeneralATR_Status_Income { get { return _generalATR_Status_Income; } set { _generalATR_Status_Income = value; } }
        private DirtyValue<string> _generalATR_Status_MtgRelatedObligations;
        public string GeneralATR_Status_MtgRelatedObligations { get { return _generalATR_Status_MtgRelatedObligations; } set { _generalATR_Status_MtgRelatedObligations = value; } }
        private DirtyValue<string> _generalATR_Status_Overall;
        public string GeneralATR_Status_Overall { get { return _generalATR_Status_Overall; } set { _generalATR_Status_Overall = value; } }
        private DirtyValue<string> _generalATR_Status_ResidualIncome;
        public string GeneralATR_Status_ResidualIncome { get { return _generalATR_Status_ResidualIncome; } set { _generalATR_Status_ResidualIncome = value; } }
        private DirtyValue<string> _generalATR_Status_SimultaneousLoan;
        public string GeneralATR_Status_SimultaneousLoan { get { return _generalATR_Status_SimultaneousLoan; } set { _generalATR_Status_SimultaneousLoan = value; } }
        private DirtyValue<decimal?> _gSEAgencyQM_CalculatedThreshold;
        public decimal? GSEAgencyQM_CalculatedThreshold { get { return _gSEAgencyQM_CalculatedThreshold; } set { _gSEAgencyQM_CalculatedThreshold = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_Alimony;
        public string GSEAgencyQM_Status_Alimony { get { return _gSEAgencyQM_Status_Alimony; } set { _gSEAgencyQM_Status_Alimony = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_Assets;
        public string GSEAgencyQM_Status_Assets { get { return _gSEAgencyQM_Status_Assets; } set { _gSEAgencyQM_Status_Assets = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_BalloonPayment;
        public string GSEAgencyQM_Status_BalloonPayment { get { return _gSEAgencyQM_Status_BalloonPayment; } set { _gSEAgencyQM_Status_BalloonPayment = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_ChildSupport;
        public string GSEAgencyQM_Status_ChildSupport { get { return _gSEAgencyQM_Status_ChildSupport; } set { _gSEAgencyQM_Status_ChildSupport = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_CoveredLoan;
        public string GSEAgencyQM_Status_CoveredLoan { get { return _gSEAgencyQM_Status_CoveredLoan; } set { _gSEAgencyQM_Status_CoveredLoan = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_CreditHistory;
        public string GSEAgencyQM_Status_CreditHistory { get { return _gSEAgencyQM_Status_CreditHistory; } set { _gSEAgencyQM_Status_CreditHistory = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_DebtObligations;
        public string GSEAgencyQM_Status_DebtObligations { get { return _gSEAgencyQM_Status_DebtObligations; } set { _gSEAgencyQM_Status_DebtObligations = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_DTI;
        public string GSEAgencyQM_Status_DTI { get { return _gSEAgencyQM_Status_DTI; } set { _gSEAgencyQM_Status_DTI = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_Employment;
        public string GSEAgencyQM_Status_Employment { get { return _gSEAgencyQM_Status_Employment; } set { _gSEAgencyQM_Status_Employment = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_Income;
        public string GSEAgencyQM_Status_Income { get { return _gSEAgencyQM_Status_Income; } set { _gSEAgencyQM_Status_Income = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_InterestOnly;
        public string GSEAgencyQM_Status_InterestOnly { get { return _gSEAgencyQM_Status_InterestOnly; } set { _gSEAgencyQM_Status_InterestOnly = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_LoanTerm;
        public string GSEAgencyQM_Status_LoanTerm { get { return _gSEAgencyQM_Status_LoanTerm; } set { _gSEAgencyQM_Status_LoanTerm = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_MtgRelatedObligations;
        public string GSEAgencyQM_Status_MtgRelatedObligations { get { return _gSEAgencyQM_Status_MtgRelatedObligations; } set { _gSEAgencyQM_Status_MtgRelatedObligations = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_NegativeAmortization;
        public string GSEAgencyQM_Status_NegativeAmortization { get { return _gSEAgencyQM_Status_NegativeAmortization; } set { _gSEAgencyQM_Status_NegativeAmortization = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_Overall;
        public string GSEAgencyQM_Status_Overall { get { return _gSEAgencyQM_Status_Overall; } set { _gSEAgencyQM_Status_Overall = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_PointsFeesLimit;
        public string GSEAgencyQM_Status_PointsFeesLimit { get { return _gSEAgencyQM_Status_PointsFeesLimit; } set { _gSEAgencyQM_Status_PointsFeesLimit = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_PrepaymentPenalty;
        public string GSEAgencyQM_Status_PrepaymentPenalty { get { return _gSEAgencyQM_Status_PrepaymentPenalty; } set { _gSEAgencyQM_Status_PrepaymentPenalty = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_ResidualIncome;
        public string GSEAgencyQM_Status_ResidualIncome { get { return _gSEAgencyQM_Status_ResidualIncome; } set { _gSEAgencyQM_Status_ResidualIncome = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_SafeHarborEligibility;
        public string GSEAgencyQM_Status_SafeHarborEligibility { get { return _gSEAgencyQM_Status_SafeHarborEligibility; } set { _gSEAgencyQM_Status_SafeHarborEligibility = value; } }
        private DirtyValue<string> _gSEAgencyQM_Status_SimultaneousLoan;
        public string GSEAgencyQM_Status_SimultaneousLoan { get { return _gSEAgencyQM_Status_SimultaneousLoan; } set { _gSEAgencyQM_Status_SimultaneousLoan = value; } }
        private DirtyValue<bool?> _has30DayLatePayment;
        public bool? Has30DayLatePayment { get { return _has30DayLatePayment; } set { _has30DayLatePayment = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _initialMaxTotalPayment;
        public decimal? InitialMaxTotalPayment { get { return _initialMaxTotalPayment; } set { _initialMaxTotalPayment = value; } }
        private DirtyValue<decimal?> _initialRateHousingRatio;
        public decimal? InitialRateHousingRatio { get { return _initialRateHousingRatio; } set { _initialRateHousingRatio = value; } }
        private DirtyValue<decimal?> _initialRateMonthlyPayment;
        public decimal? InitialRateMonthlyPayment { get { return _initialRateMonthlyPayment; } set { _initialRateMonthlyPayment = value; } }
        private DirtyValue<decimal?> _initialRateTotalDebtRatio;
        public decimal? InitialRateTotalDebtRatio { get { return _initialRateTotalDebtRatio; } set { _initialRateTotalDebtRatio = value; } }
        private DirtyValue<int?> _interestOnlyMonths;
        public int? InterestOnlyMonths { get { return _interestOnlyMonths; } set { _interestOnlyMonths = value; } }
        private DirtyValue<DateTime?> _interestOnlyRecastDate;
        public DateTime? InterestOnlyRecastDate { get { return _interestOnlyRecastDate; } set { _interestOnlyRecastDate = value; } }
        private DirtyValue<bool?> _isConsumerLiklyDefault;
        public bool? IsConsumerLiklyDefault { get { return _isConsumerLiklyDefault; } set { _isConsumerLiklyDefault = value; } }
        private DirtyValue<string> _isEligibleForSafeHarbor;
        public string IsEligibleForSafeHarbor { get { return _isEligibleForSafeHarbor; } set { _isEligibleForSafeHarbor = value; } }
        private DirtyValue<bool?> _isEvaluatedAlimonyObligations;
        public bool? IsEvaluatedAlimonyObligations { get { return _isEvaluatedAlimonyObligations; } set { _isEvaluatedAlimonyObligations = value; } }
        private DirtyValue<bool?> _isEvaluatedChildSupportObligations;
        public bool? IsEvaluatedChildSupportObligations { get { return _isEvaluatedChildSupportObligations; } set { _isEvaluatedChildSupportObligations = value; } }
        private DirtyValue<bool?> _isEvaluatedCreditHistory;
        public bool? IsEvaluatedCreditHistory { get { return _isEvaluatedCreditHistory; } set { _isEvaluatedCreditHistory = value; } }
        private DirtyValue<bool?> _isEvaluatedCurrentEmploymentStatus;
        public bool? IsEvaluatedCurrentEmploymentStatus { get { return _isEvaluatedCurrentEmploymentStatus; } set { _isEvaluatedCurrentEmploymentStatus = value; } }
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedAssets;
        public bool? IsEvaluatedCurrentExpectedAssets { get { return _isEvaluatedCurrentExpectedAssets; } set { _isEvaluatedCurrentExpectedAssets = value; } }
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedIncome;
        public bool? IsEvaluatedCurrentExpectedIncome { get { return _isEvaluatedCurrentExpectedIncome; } set { _isEvaluatedCurrentExpectedIncome = value; } }
        private DirtyValue<bool?> _isEvaluatedDebtObligations;
        public bool? IsEvaluatedDebtObligations { get { return _isEvaluatedDebtObligations; } set { _isEvaluatedDebtObligations = value; } }
        private DirtyValue<bool?> _isEvaluatedDebtToIncomeRatio;
        public bool? IsEvaluatedDebtToIncomeRatio { get { return _isEvaluatedDebtToIncomeRatio; } set { _isEvaluatedDebtToIncomeRatio = value; } }
        private DirtyValue<bool?> _isEvaluatedMonthlyCoveredLoanPayment;
        public bool? IsEvaluatedMonthlyCoveredLoanPayment { get { return _isEvaluatedMonthlyCoveredLoanPayment; } set { _isEvaluatedMonthlyCoveredLoanPayment = value; } }
        private DirtyValue<bool?> _isEvaluatedMonthlyMortgageRelatedObligations;
        public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get { return _isEvaluatedMonthlyMortgageRelatedObligations; } set { _isEvaluatedMonthlyMortgageRelatedObligations = value; } }
        private DirtyValue<bool?> _isEvaluatedMonthlySimultaneousLoanPayment;
        public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get { return _isEvaluatedMonthlySimultaneousLoanPayment; } set { _isEvaluatedMonthlySimultaneousLoanPayment = value; } }
        private DirtyValue<bool?> _isEvaluatedResidualIncome;
        public bool? IsEvaluatedResidualIncome { get { return _isEvaluatedResidualIncome; } set { _isEvaluatedResidualIncome = value; } }
        private DirtyValue<string> _isHigherPricedLoan;
        public string IsHigherPricedLoan { get { return _isHigherPricedLoan; } set { _isHigherPricedLoan = value; } }
        private DirtyValue<string> _loanProcessingInformationD4;
        public string LoanProcessingInformationD4 { get { return _loanProcessingInformationD4; } set { _loanProcessingInformationD4 = value; } }
        private DirtyValue<string> _loanProcessingInformationGO;
        public string LoanProcessingInformationGO { get { return _loanProcessingInformationGO; } set { _loanProcessingInformationGO = value; } }
        private DirtyValue<string> _loanProcessingInformationHA;
        public string LoanProcessingInformationHA { get { return _loanProcessingInformationHA; } set { _loanProcessingInformationHA = value; } }
        private DirtyValue<string> _loanProcessingInformationLE;
        public string LoanProcessingInformationLE { get { return _loanProcessingInformationLE; } set { _loanProcessingInformationLE = value; } }
        private DirtyValue<string> _loanProcessingInformationLF;
        public string LoanProcessingInformationLF { get { return _loanProcessingInformationLF; } set { _loanProcessingInformationLF = value; } }
        private DirtyValue<string> _loanProcessingInformationMA;
        public string LoanProcessingInformationMA { get { return _loanProcessingInformationMA; } set { _loanProcessingInformationMA = value; } }
        private DirtyValue<bool?> _loanProgram;
        public bool? LoanProgram { get { return _loanProgram; } set { _loanProgram = value; } }
        private DirtyValue<string> _loanProgramDescription;
        public string LoanProgramDescription { get { return _loanProgramDescription; } set { _loanProgramDescription = value; } }
        private DirtyValue<bool?> _loanRateFixedin5Years;
        public bool? LoanRateFixedin5Years { get { return _loanRateFixedin5Years; } set { _loanRateFixedin5Years = value; } }
        private DirtyValue<decimal?> _lOBrokerCompensationAmount;
        public decimal? LOBrokerCompensationAmount { get { return _lOBrokerCompensationAmount; } set { _lOBrokerCompensationAmount = value; } }
        private DirtyValue<decimal?> _max5YrsHousingRatio;
        public decimal? Max5YrsHousingRatio { get { return _max5YrsHousingRatio; } set { _max5YrsHousingRatio = value; } }
        private DirtyValue<decimal?> _max5YrsPrincipleAndInterest;
        public decimal? Max5YrsPrincipleAndInterest { get { return _max5YrsPrincipleAndInterest; } set { _max5YrsPrincipleAndInterest = value; } }
        private DirtyValue<decimal?> _max5YrsTotalDebtRatio;
        public decimal? Max5YrsTotalDebtRatio { get { return _max5YrsTotalDebtRatio; } set { _max5YrsTotalDebtRatio = value; } }
        private DirtyValue<decimal?> _max5YrsTotalPayment;
        public decimal? Max5YrsTotalPayment { get { return _max5YrsTotalPayment; } set { _max5YrsTotalPayment = value; } }
        private DirtyValue<decimal?> _maxPrepaymentPenaltyFees;
        public decimal? MaxPrepaymentPenaltyFees { get { return _maxPrepaymentPenaltyFees; } set { _maxPrepaymentPenaltyFees = value; } }
        private DirtyValue<DateTime?> _negAmRecastDate;
        public DateTime? NegAmRecastDate { get { return _negAmRecastDate; } set { _negAmRecastDate = value; } }
        private DirtyValue<bool?> _paymentDecreasedBy10Percent;
        public bool? PaymentDecreasedBy10Percent { get { return _paymentDecreasedBy10Percent; } set { _paymentDecreasedBy10Percent = value; } }
        private DirtyValue<bool?> _pointsFeesThresholdMet;
        public bool? PointsFeesThresholdMet { get { return _pointsFeesThresholdMet; } set { _pointsFeesThresholdMet = value; } }
        private DirtyValue<decimal?> _prepaymentPenaltyPayoffFees;
        public decimal? PrepaymentPenaltyPayoffFees { get { return _prepaymentPenaltyPayoffFees; } set { _prepaymentPenaltyPayoffFees = value; } }
        private DirtyValue<decimal?> _prepayPenaltyPercentage;
        public decimal? PrepayPenaltyPercentage { get { return _prepayPenaltyPercentage; } set { _prepayPenaltyPercentage = value; } }
        private DirtyValue<bool?> _preventConsumersDefault;
        public bool? PreventConsumersDefault { get { return _preventConsumersDefault; } set { _preventConsumersDefault = value; } }
        private DirtyValue<bool?> _principalBalanceIncreased;
        public bool? PrincipalBalanceIncreased { get { return _principalBalanceIncreased; } set { _principalBalanceIncreased = value; } }
        private DirtyValue<bool?> _principalHasDeferred;
        public bool? PrincipalHasDeferred { get { return _principalHasDeferred; } set { _principalHasDeferred = value; } }
        private DirtyValue<string> _qMLoanType;
        public string QMLoanType { get { return _qMLoanType; } set { _qMLoanType = value; } }
        private DirtyValue<decimal?> _rateReductionBasisPoints;
        public decimal? RateReductionBasisPoints { get { return _rateReductionBasisPoints; } set { _rateReductionBasisPoints = value; } }
        private DirtyValue<decimal?> _rateReductionDiscountPoints;
        public decimal? RateReductionDiscountPoints { get { return _rateReductionDiscountPoints; } set { _rateReductionDiscountPoints = value; } }
        private DirtyValue<decimal?> _rateReductionMaxBonaFideDiscountPoint;
        public decimal? RateReductionMaxBonaFideDiscountPoint { get { return _rateReductionMaxBonaFideDiscountPoint; } set { _rateReductionMaxBonaFideDiscountPoint = value; } }
        private DirtyValue<decimal?> _realEstateFees;
        public decimal? RealEstateFees { get { return _realEstateFees; } set { _realEstateFees = value; } }
        private DirtyValue<decimal?> _recastDifferencePayment;
        public decimal? RecastDifferencePayment { get { return _recastDifferencePayment; } set { _recastDifferencePayment = value; } }
        private DirtyValue<decimal?> _regZTotalLoanAmount;
        public decimal? RegZTotalLoanAmount { get { return _regZTotalLoanAmount; } set { _regZTotalLoanAmount = value; } }
        private DirtyValue<decimal?> _requiredServicesLenderSelectedAmt;
        public decimal? RequiredServicesLenderSelectedAmt { get { return _requiredServicesLenderSelectedAmt; } set { _requiredServicesLenderSelectedAmt = value; } }
        private DirtyValue<decimal?> _smallCreditorQM_CalculatedThreshold;
        public decimal? SmallCreditorQM_CalculatedThreshold { get { return _smallCreditorQM_CalculatedThreshold; } set { _smallCreditorQM_CalculatedThreshold = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_Alimony;
        public string SmallCreditorQM_Status_Alimony { get { return _smallCreditorQM_Status_Alimony; } set { _smallCreditorQM_Status_Alimony = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_Assets;
        public string SmallCreditorQM_Status_Assets { get { return _smallCreditorQM_Status_Assets; } set { _smallCreditorQM_Status_Assets = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_BalloonPayment;
        public string SmallCreditorQM_Status_BalloonPayment { get { return _smallCreditorQM_Status_BalloonPayment; } set { _smallCreditorQM_Status_BalloonPayment = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_ChildSupport;
        public string SmallCreditorQM_Status_ChildSupport { get { return _smallCreditorQM_Status_ChildSupport; } set { _smallCreditorQM_Status_ChildSupport = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_CoveredLoan;
        public string SmallCreditorQM_Status_CoveredLoan { get { return _smallCreditorQM_Status_CoveredLoan; } set { _smallCreditorQM_Status_CoveredLoan = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_DebtObligations;
        public string SmallCreditorQM_Status_DebtObligations { get { return _smallCreditorQM_Status_DebtObligations; } set { _smallCreditorQM_Status_DebtObligations = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_DTI;
        public string SmallCreditorQM_Status_DTI { get { return _smallCreditorQM_Status_DTI; } set { _smallCreditorQM_Status_DTI = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_Income;
        public string SmallCreditorQM_Status_Income { get { return _smallCreditorQM_Status_Income; } set { _smallCreditorQM_Status_Income = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_InterestOnly;
        public string SmallCreditorQM_Status_InterestOnly { get { return _smallCreditorQM_Status_InterestOnly; } set { _smallCreditorQM_Status_InterestOnly = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_LoanTerm;
        public string SmallCreditorQM_Status_LoanTerm { get { return _smallCreditorQM_Status_LoanTerm; } set { _smallCreditorQM_Status_LoanTerm = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_MtgRelatedObligations;
        public string SmallCreditorQM_Status_MtgRelatedObligations { get { return _smallCreditorQM_Status_MtgRelatedObligations; } set { _smallCreditorQM_Status_MtgRelatedObligations = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_NegativeAmortization;
        public string SmallCreditorQM_Status_NegativeAmortization { get { return _smallCreditorQM_Status_NegativeAmortization; } set { _smallCreditorQM_Status_NegativeAmortization = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_Overall;
        public string SmallCreditorQM_Status_Overall { get { return _smallCreditorQM_Status_Overall; } set { _smallCreditorQM_Status_Overall = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_PointsFeesLimit;
        public string SmallCreditorQM_Status_PointsFeesLimit { get { return _smallCreditorQM_Status_PointsFeesLimit; } set { _smallCreditorQM_Status_PointsFeesLimit = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_PrepaymentPenalty;
        public string SmallCreditorQM_Status_PrepaymentPenalty { get { return _smallCreditorQM_Status_PrepaymentPenalty; } set { _smallCreditorQM_Status_PrepaymentPenalty = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_ResidualIncome;
        public string SmallCreditorQM_Status_ResidualIncome { get { return _smallCreditorQM_Status_ResidualIncome; } set { _smallCreditorQM_Status_ResidualIncome = value; } }
        private DirtyValue<string> _smallCreditorQM_Status_SafeHarborEligibility;
        public string SmallCreditorQM_Status_SafeHarborEligibility { get { return _smallCreditorQM_Status_SafeHarborEligibility; } set { _smallCreditorQM_Status_SafeHarborEligibility = value; } }
        private DirtyValue<decimal?> _standardQM_CalculatedThreshold;
        public decimal? StandardQM_CalculatedThreshold { get { return _standardQM_CalculatedThreshold; } set { _standardQM_CalculatedThreshold = value; } }
        private DirtyValue<string> _standardQM_Status_Alimony;
        public string StandardQM_Status_Alimony { get { return _standardQM_Status_Alimony; } set { _standardQM_Status_Alimony = value; } }
        private DirtyValue<string> _standardQM_Status_Assets;
        public string StandardQM_Status_Assets { get { return _standardQM_Status_Assets; } set { _standardQM_Status_Assets = value; } }
        private DirtyValue<string> _standardQM_Status_BalloonPayment;
        public string StandardQM_Status_BalloonPayment { get { return _standardQM_Status_BalloonPayment; } set { _standardQM_Status_BalloonPayment = value; } }
        private DirtyValue<string> _standardQM_Status_ChildSupport;
        public string StandardQM_Status_ChildSupport { get { return _standardQM_Status_ChildSupport; } set { _standardQM_Status_ChildSupport = value; } }
        private DirtyValue<string> _standardQM_Status_CoveredLoan;
        public string StandardQM_Status_CoveredLoan { get { return _standardQM_Status_CoveredLoan; } set { _standardQM_Status_CoveredLoan = value; } }
        private DirtyValue<string> _standardQM_Status_CreditHistory;
        public string StandardQM_Status_CreditHistory { get { return _standardQM_Status_CreditHistory; } set { _standardQM_Status_CreditHistory = value; } }
        private DirtyValue<string> _standardQM_Status_DebtObligations;
        public string StandardQM_Status_DebtObligations { get { return _standardQM_Status_DebtObligations; } set { _standardQM_Status_DebtObligations = value; } }
        private DirtyValue<string> _standardQM_Status_DTI;
        public string StandardQM_Status_DTI { get { return _standardQM_Status_DTI; } set { _standardQM_Status_DTI = value; } }
        private DirtyValue<string> _standardQM_Status_Employment;
        public string StandardQM_Status_Employment { get { return _standardQM_Status_Employment; } set { _standardQM_Status_Employment = value; } }
        private DirtyValue<string> _standardQM_Status_Income;
        public string StandardQM_Status_Income { get { return _standardQM_Status_Income; } set { _standardQM_Status_Income = value; } }
        private DirtyValue<string> _standardQM_Status_InterestOnly;
        public string StandardQM_Status_InterestOnly { get { return _standardQM_Status_InterestOnly; } set { _standardQM_Status_InterestOnly = value; } }
        private DirtyValue<string> _standardQM_Status_LoanTerm;
        public string StandardQM_Status_LoanTerm { get { return _standardQM_Status_LoanTerm; } set { _standardQM_Status_LoanTerm = value; } }
        private DirtyValue<string> _standardQM_Status_MtgRelatedObligations;
        public string StandardQM_Status_MtgRelatedObligations { get { return _standardQM_Status_MtgRelatedObligations; } set { _standardQM_Status_MtgRelatedObligations = value; } }
        private DirtyValue<string> _standardQM_Status_NegativeAmortization;
        public string StandardQM_Status_NegativeAmortization { get { return _standardQM_Status_NegativeAmortization; } set { _standardQM_Status_NegativeAmortization = value; } }
        private DirtyValue<string> _standardQM_Status_Overall;
        public string StandardQM_Status_Overall { get { return _standardQM_Status_Overall; } set { _standardQM_Status_Overall = value; } }
        private DirtyValue<string> _standardQM_Status_PointsFeesLimit;
        public string StandardQM_Status_PointsFeesLimit { get { return _standardQM_Status_PointsFeesLimit; } set { _standardQM_Status_PointsFeesLimit = value; } }
        private DirtyValue<string> _standardQM_Status_PrepaymentPenalty;
        public string StandardQM_Status_PrepaymentPenalty { get { return _standardQM_Status_PrepaymentPenalty; } set { _standardQM_Status_PrepaymentPenalty = value; } }
        private DirtyValue<string> _standardQM_Status_ResidualIncome;
        public string StandardQM_Status_ResidualIncome { get { return _standardQM_Status_ResidualIncome; } set { _standardQM_Status_ResidualIncome = value; } }
        private DirtyValue<string> _standardQM_Status_SafeHarborEligibility;
        public string StandardQM_Status_SafeHarborEligibility { get { return _standardQM_Status_SafeHarborEligibility; } set { _standardQM_Status_SafeHarborEligibility = value; } }
        private DirtyValue<string> _standardQM_Status_SimultaneousLoan;
        public string StandardQM_Status_SimultaneousLoan { get { return _standardQM_Status_SimultaneousLoan; } set { _standardQM_Status_SimultaneousLoan = value; } }
        private DirtyValue<decimal?> _startingAdjustedRateMaxBonaFideDiscountPoint;
        public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get { return _startingAdjustedRateMaxBonaFideDiscountPoint; } set { _startingAdjustedRateMaxBonaFideDiscountPoint = value; } }
        private DirtyValue<string> _status_CreditHistory;
        public string Status_CreditHistory { get { return _status_CreditHistory; } set { _status_CreditHistory = value; } }
        private DirtyValue<string> _status_SimultaneousLoan;
        public string Status_SimultaneousLoan { get { return _status_SimultaneousLoan; } set { _status_SimultaneousLoan = value; } }
        private DirtyValue<string> _thresholdExceedsQM;
        public string ThresholdExceedsQM { get { return _thresholdExceedsQM; } set { _thresholdExceedsQM = value; } }
        private DirtyValue<decimal?> _titleServicesLenderTitleinsuranceFee;
        public decimal? TitleServicesLenderTitleinsuranceFee { get { return _titleServicesLenderTitleinsuranceFee; } set { _titleServicesLenderTitleinsuranceFee = value; } }
        private DirtyValue<decimal?> _totalCoMortgagorIncome;
        public decimal? TotalCoMortgagorIncome { get { return _totalCoMortgagorIncome; } set { _totalCoMortgagorIncome = value; } }
        private DirtyValue<decimal?> _totalIncome;
        public decimal? TotalIncome { get { return _totalIncome; } set { _totalIncome = value; } }
        private DirtyValue<decimal?> _totalPointsFeesSec32Percent;
        public decimal? TotalPointsFeesSec32Percent { get { return _totalPointsFeesSec32Percent; } set { _totalPointsFeesSec32Percent = value; } }
        private DirtyValue<bool?> _transactionExemptFromRegZ;
        public bool? TransactionExemptFromRegZ { get { return _transactionExemptFromRegZ; } set { _transactionExemptFromRegZ = value; } }
        private DirtyValue<bool?> _unitCount;
        public bool? UnitCount { get { return _unitCount; } set { _unitCount = value; } }
        private DirtyValue<decimal?> _upfrontPMIFees;
        public decimal? UpfrontPMIFees { get { return _upfrontPMIFees; } set { _upfrontPMIFees = value; } }
        private DirtyValue<bool?> _withOriginalCreditor;
        public bool? WithOriginalCreditor { get { return _withOriginalCreditor; } set { _withOriginalCreditor = value; } }
        private DirtyValue<DateTime?> _writtenApplicationDate;
        public DateTime? WrittenApplicationDate { get { return _writtenApplicationDate; } set { _writtenApplicationDate = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _affiliatesFees.Dirty
                    || _aPORMaxBonaFideDiscountPoint.Dirty
                    || _aRMRecastDate.Dirty
                    || _aRMRecastMonthlyPayment.Dirty
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
                    || _generalATR_Status_Alimony.Dirty
                    || _generalATR_Status_Assets.Dirty
                    || _generalATR_Status_ChildSupport.Dirty
                    || _generalATR_Status_CoveredLoan.Dirty
                    || _generalATR_Status_CreditHistory.Dirty
                    || _generalATR_Status_DebtObligations.Dirty
                    || _generalATR_Status_DTI.Dirty
                    || _generalATR_Status_Employment.Dirty
                    || _generalATR_Status_Income.Dirty
                    || _generalATR_Status_MtgRelatedObligations.Dirty
                    || _generalATR_Status_Overall.Dirty
                    || _generalATR_Status_ResidualIncome.Dirty
                    || _generalATR_Status_SimultaneousLoan.Dirty
                    || _gSEAgencyQM_CalculatedThreshold.Dirty
                    || _gSEAgencyQM_Status_Alimony.Dirty
                    || _gSEAgencyQM_Status_Assets.Dirty
                    || _gSEAgencyQM_Status_BalloonPayment.Dirty
                    || _gSEAgencyQM_Status_ChildSupport.Dirty
                    || _gSEAgencyQM_Status_CoveredLoan.Dirty
                    || _gSEAgencyQM_Status_CreditHistory.Dirty
                    || _gSEAgencyQM_Status_DebtObligations.Dirty
                    || _gSEAgencyQM_Status_DTI.Dirty
                    || _gSEAgencyQM_Status_Employment.Dirty
                    || _gSEAgencyQM_Status_Income.Dirty
                    || _gSEAgencyQM_Status_InterestOnly.Dirty
                    || _gSEAgencyQM_Status_LoanTerm.Dirty
                    || _gSEAgencyQM_Status_MtgRelatedObligations.Dirty
                    || _gSEAgencyQM_Status_NegativeAmortization.Dirty
                    || _gSEAgencyQM_Status_Overall.Dirty
                    || _gSEAgencyQM_Status_PointsFeesLimit.Dirty
                    || _gSEAgencyQM_Status_PrepaymentPenalty.Dirty
                    || _gSEAgencyQM_Status_ResidualIncome.Dirty
                    || _gSEAgencyQM_Status_SafeHarborEligibility.Dirty
                    || _gSEAgencyQM_Status_SimultaneousLoan.Dirty
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
                    || _smallCreditorQM_CalculatedThreshold.Dirty
                    || _smallCreditorQM_Status_Alimony.Dirty
                    || _smallCreditorQM_Status_Assets.Dirty
                    || _smallCreditorQM_Status_BalloonPayment.Dirty
                    || _smallCreditorQM_Status_ChildSupport.Dirty
                    || _smallCreditorQM_Status_CoveredLoan.Dirty
                    || _smallCreditorQM_Status_DebtObligations.Dirty
                    || _smallCreditorQM_Status_DTI.Dirty
                    || _smallCreditorQM_Status_Income.Dirty
                    || _smallCreditorQM_Status_InterestOnly.Dirty
                    || _smallCreditorQM_Status_LoanTerm.Dirty
                    || _smallCreditorQM_Status_MtgRelatedObligations.Dirty
                    || _smallCreditorQM_Status_NegativeAmortization.Dirty
                    || _smallCreditorQM_Status_Overall.Dirty
                    || _smallCreditorQM_Status_PointsFeesLimit.Dirty
                    || _smallCreditorQM_Status_PrepaymentPenalty.Dirty
                    || _smallCreditorQM_Status_ResidualIncome.Dirty
                    || _smallCreditorQM_Status_SafeHarborEligibility.Dirty
                    || _standardQM_CalculatedThreshold.Dirty
                    || _standardQM_Status_Alimony.Dirty
                    || _standardQM_Status_Assets.Dirty
                    || _standardQM_Status_BalloonPayment.Dirty
                    || _standardQM_Status_ChildSupport.Dirty
                    || _standardQM_Status_CoveredLoan.Dirty
                    || _standardQM_Status_CreditHistory.Dirty
                    || _standardQM_Status_DebtObligations.Dirty
                    || _standardQM_Status_DTI.Dirty
                    || _standardQM_Status_Employment.Dirty
                    || _standardQM_Status_Income.Dirty
                    || _standardQM_Status_InterestOnly.Dirty
                    || _standardQM_Status_LoanTerm.Dirty
                    || _standardQM_Status_MtgRelatedObligations.Dirty
                    || _standardQM_Status_NegativeAmortization.Dirty
                    || _standardQM_Status_Overall.Dirty
                    || _standardQM_Status_PointsFeesLimit.Dirty
                    || _standardQM_Status_PrepaymentPenalty.Dirty
                    || _standardQM_Status_ResidualIncome.Dirty
                    || _standardQM_Status_SafeHarborEligibility.Dirty
                    || _standardQM_Status_SimultaneousLoan.Dirty
                    || _startingAdjustedRateMaxBonaFideDiscountPoint.Dirty
                    || _status_CreditHistory.Dirty
                    || _status_SimultaneousLoan.Dirty
                    || _thresholdExceedsQM.Dirty
                    || _titleServicesLenderTitleinsuranceFee.Dirty
                    || _totalCoMortgagorIncome.Dirty
                    || _totalIncome.Dirty
                    || _totalPointsFeesSec32Percent.Dirty
                    || _transactionExemptFromRegZ.Dirty
                    || _unitCount.Dirty
                    || _upfrontPMIFees.Dirty
                    || _withOriginalCreditor.Dirty
                    || _writtenApplicationDate.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _affiliatesFees.Dirty = value;
                _aPORMaxBonaFideDiscountPoint.Dirty = value;
                _aRMRecastDate.Dirty = value;
                _aRMRecastMonthlyPayment.Dirty = value;
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
                _generalATR_Status_Alimony.Dirty = value;
                _generalATR_Status_Assets.Dirty = value;
                _generalATR_Status_ChildSupport.Dirty = value;
                _generalATR_Status_CoveredLoan.Dirty = value;
                _generalATR_Status_CreditHistory.Dirty = value;
                _generalATR_Status_DebtObligations.Dirty = value;
                _generalATR_Status_DTI.Dirty = value;
                _generalATR_Status_Employment.Dirty = value;
                _generalATR_Status_Income.Dirty = value;
                _generalATR_Status_MtgRelatedObligations.Dirty = value;
                _generalATR_Status_Overall.Dirty = value;
                _generalATR_Status_ResidualIncome.Dirty = value;
                _generalATR_Status_SimultaneousLoan.Dirty = value;
                _gSEAgencyQM_CalculatedThreshold.Dirty = value;
                _gSEAgencyQM_Status_Alimony.Dirty = value;
                _gSEAgencyQM_Status_Assets.Dirty = value;
                _gSEAgencyQM_Status_BalloonPayment.Dirty = value;
                _gSEAgencyQM_Status_ChildSupport.Dirty = value;
                _gSEAgencyQM_Status_CoveredLoan.Dirty = value;
                _gSEAgencyQM_Status_CreditHistory.Dirty = value;
                _gSEAgencyQM_Status_DebtObligations.Dirty = value;
                _gSEAgencyQM_Status_DTI.Dirty = value;
                _gSEAgencyQM_Status_Employment.Dirty = value;
                _gSEAgencyQM_Status_Income.Dirty = value;
                _gSEAgencyQM_Status_InterestOnly.Dirty = value;
                _gSEAgencyQM_Status_LoanTerm.Dirty = value;
                _gSEAgencyQM_Status_MtgRelatedObligations.Dirty = value;
                _gSEAgencyQM_Status_NegativeAmortization.Dirty = value;
                _gSEAgencyQM_Status_Overall.Dirty = value;
                _gSEAgencyQM_Status_PointsFeesLimit.Dirty = value;
                _gSEAgencyQM_Status_PrepaymentPenalty.Dirty = value;
                _gSEAgencyQM_Status_ResidualIncome.Dirty = value;
                _gSEAgencyQM_Status_SafeHarborEligibility.Dirty = value;
                _gSEAgencyQM_Status_SimultaneousLoan.Dirty = value;
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
                _smallCreditorQM_CalculatedThreshold.Dirty = value;
                _smallCreditorQM_Status_Alimony.Dirty = value;
                _smallCreditorQM_Status_Assets.Dirty = value;
                _smallCreditorQM_Status_BalloonPayment.Dirty = value;
                _smallCreditorQM_Status_ChildSupport.Dirty = value;
                _smallCreditorQM_Status_CoveredLoan.Dirty = value;
                _smallCreditorQM_Status_DebtObligations.Dirty = value;
                _smallCreditorQM_Status_DTI.Dirty = value;
                _smallCreditorQM_Status_Income.Dirty = value;
                _smallCreditorQM_Status_InterestOnly.Dirty = value;
                _smallCreditorQM_Status_LoanTerm.Dirty = value;
                _smallCreditorQM_Status_MtgRelatedObligations.Dirty = value;
                _smallCreditorQM_Status_NegativeAmortization.Dirty = value;
                _smallCreditorQM_Status_Overall.Dirty = value;
                _smallCreditorQM_Status_PointsFeesLimit.Dirty = value;
                _smallCreditorQM_Status_PrepaymentPenalty.Dirty = value;
                _smallCreditorQM_Status_ResidualIncome.Dirty = value;
                _smallCreditorQM_Status_SafeHarborEligibility.Dirty = value;
                _standardQM_CalculatedThreshold.Dirty = value;
                _standardQM_Status_Alimony.Dirty = value;
                _standardQM_Status_Assets.Dirty = value;
                _standardQM_Status_BalloonPayment.Dirty = value;
                _standardQM_Status_ChildSupport.Dirty = value;
                _standardQM_Status_CoveredLoan.Dirty = value;
                _standardQM_Status_CreditHistory.Dirty = value;
                _standardQM_Status_DebtObligations.Dirty = value;
                _standardQM_Status_DTI.Dirty = value;
                _standardQM_Status_Employment.Dirty = value;
                _standardQM_Status_Income.Dirty = value;
                _standardQM_Status_InterestOnly.Dirty = value;
                _standardQM_Status_LoanTerm.Dirty = value;
                _standardQM_Status_MtgRelatedObligations.Dirty = value;
                _standardQM_Status_NegativeAmortization.Dirty = value;
                _standardQM_Status_Overall.Dirty = value;
                _standardQM_Status_PointsFeesLimit.Dirty = value;
                _standardQM_Status_PrepaymentPenalty.Dirty = value;
                _standardQM_Status_ResidualIncome.Dirty = value;
                _standardQM_Status_SafeHarborEligibility.Dirty = value;
                _standardQM_Status_SimultaneousLoan.Dirty = value;
                _startingAdjustedRateMaxBonaFideDiscountPoint.Dirty = value;
                _status_CreditHistory.Dirty = value;
                _status_SimultaneousLoan.Dirty = value;
                _thresholdExceedsQM.Dirty = value;
                _titleServicesLenderTitleinsuranceFee.Dirty = value;
                _totalCoMortgagorIncome.Dirty = value;
                _totalIncome.Dirty = value;
                _totalPointsFeesSec32Percent.Dirty = value;
                _transactionExemptFromRegZ.Dirty = value;
                _unitCount.Dirty = value;
                _upfrontPMIFees.Dirty = value;
                _withOriginalCreditor.Dirty = value;
                _writtenApplicationDate.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}