using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ATRQMCommon : IClean
    {
        private Value<decimal?> _affiliatesFees;
        public decimal? AffiliatesFees { get { return _affiliatesFees; } set { _affiliatesFees = value; } }
        private Value<decimal?> _aPORMaxBonaFideDiscountPoint;
        public decimal? APORMaxBonaFideDiscountPoint { get { return _aPORMaxBonaFideDiscountPoint; } set { _aPORMaxBonaFideDiscountPoint = value; } }
        private Value<DateTime?> _aRMRecastDate;
        public DateTime? ARMRecastDate { get { return _aRMRecastDate; } set { _aRMRecastDate = value; } }
        private Value<decimal?> _aRMRecastMonthlyPayment;
        public decimal? ARMRecastMonthlyPayment { get { return _aRMRecastMonthlyPayment; } set { _aRMRecastMonthlyPayment = value; } }
        private Value<string> _aTRLoanType;
        public string ATRLoanType { get { return _aTRLoanType; } set { _aTRLoanType = value; } }
        private Value<string> _aUSDataDiscrepencyResolutionComments;
        public string AUSDataDiscrepencyResolutionComments { get { return _aUSDataDiscrepencyResolutionComments; } set { _aUSDataDiscrepencyResolutionComments = value; } }
        private Value<DateTime?> _aUSDataDiscrepencyResolutionDate;
        public DateTime? AUSDataDiscrepencyResolutionDate { get { return _aUSDataDiscrepencyResolutionDate; } set { _aUSDataDiscrepencyResolutionDate = value; } }
        private Value<string> _aUSDataDiscrepencyResolvedBy;
        public string AUSDataDiscrepencyResolvedBy { get { return _aUSDataDiscrepencyResolvedBy; } set { _aUSDataDiscrepencyResolvedBy = value; } }
        private Value<decimal?> _bonaFideDiscountPoint;
        public decimal? BonaFideDiscountPoint { get { return _bonaFideDiscountPoint; } set { _bonaFideDiscountPoint = value; } }
        private Value<decimal?> _bonaFideDiscountPointAmount;
        public decimal? BonaFideDiscountPointAmount { get { return _bonaFideDiscountPointAmount; } set { _bonaFideDiscountPointAmount = value; } }
        private Value<bool?> _brokerCompensationWhenRateSet;
        public bool? BrokerCompensationWhenRateSet { get { return _brokerCompensationWhenRateSet; } set { _brokerCompensationWhenRateSet = value; } }
        private Value<string> _collateralRepandWarrReliefEligibilityType;
        public string CollateralRepandWarrReliefEligibilityType { get { return _collateralRepandWarrReliefEligibilityType; } set { _collateralRepandWarrReliefEligibilityType = value; } }
        private Value<decimal?> _compensationPTBFees;
        public decimal? CompensationPTBFees { get { return _compensationPTBFees; } set { _compensationPTBFees = value; } }
        private Value<decimal?> _creditInsPremiumFees;
        public decimal? CreditInsPremiumFees { get { return _creditInsPremiumFees; } set { _creditInsPremiumFees = value; } }
        private Value<bool?> _creditorType;
        public bool? CreditorType { get { return _creditorType; } set { _creditorType = value; } }
        private Value<string> _creditorTypeDescription;
        public string CreditorTypeDescription { get { return _creditorTypeDescription; } set { _creditorTypeDescription = value; } }
        private Value<bool?> _creditType;
        public bool? CreditType { get { return _creditType; } set { _creditType = value; } }
        private Value<decimal?> _currentQMFeeThresholdAmt;
        public decimal? CurrentQMFeeThresholdAmt { get { return _currentQMFeeThresholdAmt; } set { _currentQMFeeThresholdAmt = value; } }
        private Value<decimal?> _currentQMFeeThresholdPercent;
        public decimal? CurrentQMFeeThresholdPercent { get { return _currentQMFeeThresholdPercent; } set { _currentQMFeeThresholdPercent = value; } }
        private Value<DateTime?> _dateOfLastMonthlyPayment;
        public DateTime? DateOfLastMonthlyPayment { get { return _dateOfLastMonthlyPayment; } set { _dateOfLastMonthlyPayment = value; } }
        private Value<decimal?> _discountPointAmount;
        public decimal? DiscountPointAmount { get { return _discountPointAmount; } set { _discountPointAmount = value; } }
        private Value<decimal?> _discountPointFees;
        public decimal? DiscountPointFees { get { return _discountPointFees; } set { _discountPointFees = value; } }
        private Value<decimal?> _discountPointPercentage;
        public decimal? DiscountPointPercentage { get { return _discountPointPercentage; } set { _discountPointPercentage = value; } }
        private Value<string> _documentationGuidelineMessages4V;
        public string DocumentationGuidelineMessages4V { get { return _documentationGuidelineMessages4V; } set { _documentationGuidelineMessages4V = value; } }
        private Value<string> _documentationGuidelineMessages5C;
        public string DocumentationGuidelineMessages5C { get { return _documentationGuidelineMessages5C; } set { _documentationGuidelineMessages5C = value; } }
        private Value<string> _documentationGuidelineMessages8Y;
        public string DocumentationGuidelineMessages8Y { get { return _documentationGuidelineMessages8Y; } set { _documentationGuidelineMessages8Y = value; } }
        private Value<string> _documentationGuidelineMessagesCN;
        public string DocumentationGuidelineMessagesCN { get { return _documentationGuidelineMessagesCN; } set { _documentationGuidelineMessagesCN = value; } }
        private Value<string> _documentationGuidelineMessagesCP;
        public string DocumentationGuidelineMessagesCP { get { return _documentationGuidelineMessagesCP; } set { _documentationGuidelineMessagesCP = value; } }
        private Value<string> _documentationGuidelineMessagesCV;
        public string DocumentationGuidelineMessagesCV { get { return _documentationGuidelineMessagesCV; } set { _documentationGuidelineMessagesCV = value; } }
        private Value<string> _documentationGuidelineMessagesCY;
        public string DocumentationGuidelineMessagesCY { get { return _documentationGuidelineMessagesCY; } set { _documentationGuidelineMessagesCY = value; } }
        private Value<string> _documentationGuidelineMessagesCZ;
        public string DocumentationGuidelineMessagesCZ { get { return _documentationGuidelineMessagesCZ; } set { _documentationGuidelineMessagesCZ = value; } }
        private Value<string> _documentationGuidelineMessagesDP;
        public string DocumentationGuidelineMessagesDP { get { return _documentationGuidelineMessagesDP; } set { _documentationGuidelineMessagesDP = value; } }
        private Value<string> _documentationGuidelineMessagesDZ;
        public string DocumentationGuidelineMessagesDZ { get { return _documentationGuidelineMessagesDZ; } set { _documentationGuidelineMessagesDZ = value; } }
        private Value<string> _documentationGuidelineMessagesE5;
        public string DocumentationGuidelineMessagesE5 { get { return _documentationGuidelineMessagesE5; } set { _documentationGuidelineMessagesE5 = value; } }
        private Value<string> _documentationGuidelineMessagesIM;
        public string DocumentationGuidelineMessagesIM { get { return _documentationGuidelineMessagesIM; } set { _documentationGuidelineMessagesIM = value; } }
        private Value<string> _documentationGuidelineMessagesIQ;
        public string DocumentationGuidelineMessagesIQ { get { return _documentationGuidelineMessagesIQ; } set { _documentationGuidelineMessagesIQ = value; } }
        private Value<string> _documentationGuidelineMessagesJF;
        public string DocumentationGuidelineMessagesJF { get { return _documentationGuidelineMessagesJF; } set { _documentationGuidelineMessagesJF = value; } }
        private Value<string> _documentationGuidelineMessagesQJ;
        public string DocumentationGuidelineMessagesQJ { get { return _documentationGuidelineMessagesQJ; } set { _documentationGuidelineMessagesQJ = value; } }
        private Value<string> _documentationGuidelineMessagesQN;
        public string DocumentationGuidelineMessagesQN { get { return _documentationGuidelineMessagesQN; } set { _documentationGuidelineMessagesQN = value; } }
        private Value<string> _documentationGuidelineMessagesQQ;
        public string DocumentationGuidelineMessagesQQ { get { return _documentationGuidelineMessagesQQ; } set { _documentationGuidelineMessagesQQ = value; } }
        private Value<string> _documentationGuidelineMessagesQS;
        public string DocumentationGuidelineMessagesQS { get { return _documentationGuidelineMessagesQS; } set { _documentationGuidelineMessagesQS = value; } }
        private Value<string> _documentationGuidelineMessagesU7;
        public string DocumentationGuidelineMessagesU7 { get { return _documentationGuidelineMessagesU7; } set { _documentationGuidelineMessagesU7 = value; } }
        private Value<string> _documentationGuidelineMessagesX1;
        public string DocumentationGuidelineMessagesX1 { get { return _documentationGuidelineMessagesX1; } set { _documentationGuidelineMessagesX1 = value; } }
        private Value<string> _documentationGuidelineMessagesX3;
        public string DocumentationGuidelineMessagesX3 { get { return _documentationGuidelineMessagesX3; } set { _documentationGuidelineMessagesX3 = value; } }
        private Value<string> _documentationGuidelineMessagesX5;
        public string DocumentationGuidelineMessagesX5 { get { return _documentationGuidelineMessagesX5; } set { _documentationGuidelineMessagesX5 = value; } }
        private Value<string> _documentationGuidelineMessagesX7;
        public string DocumentationGuidelineMessagesX7 { get { return _documentationGuidelineMessagesX7; } set { _documentationGuidelineMessagesX7 = value; } }
        private Value<string> _documentationGuidelineMessagesXA;
        public string DocumentationGuidelineMessagesXA { get { return _documentationGuidelineMessagesXA; } set { _documentationGuidelineMessagesXA = value; } }
        private Value<string> _documentationGuidelineMessagesXM;
        public string DocumentationGuidelineMessagesXM { get { return _documentationGuidelineMessagesXM; } set { _documentationGuidelineMessagesXM = value; } }
        private Value<string> _documentationGuidelineMessagesXP;
        public string DocumentationGuidelineMessagesXP { get { return _documentationGuidelineMessagesXP; } set { _documentationGuidelineMessagesXP = value; } }
        private Value<string> _documentationGuidelineMessagesXR;
        public string DocumentationGuidelineMessagesXR { get { return _documentationGuidelineMessagesXR; } set { _documentationGuidelineMessagesXR = value; } }
        private Value<string> _documentationGuidelineMessagesXT;
        public string DocumentationGuidelineMessagesXT { get { return _documentationGuidelineMessagesXT; } set { _documentationGuidelineMessagesXT = value; } }
        private Value<string> _documentationGuidelineMessagesY8;
        public string DocumentationGuidelineMessagesY8 { get { return _documentationGuidelineMessagesY8; } set { _documentationGuidelineMessagesY8 = value; } }
        private Value<string> _documentationGuidelineMessagesYG;
        public string DocumentationGuidelineMessagesYG { get { return _documentationGuidelineMessagesYG; } set { _documentationGuidelineMessagesYG = value; } }
        private Value<string> _documentationGuidelineMessagesYJ;
        public string DocumentationGuidelineMessagesYJ { get { return _documentationGuidelineMessagesYJ; } set { _documentationGuidelineMessagesYJ = value; } }
        private Value<string> _documentationGuidelineMessagesYY;
        public string DocumentationGuidelineMessagesYY { get { return _documentationGuidelineMessagesYY; } set { _documentationGuidelineMessagesYY = value; } }
        private Value<string> _documentationGuidelineMessagesYZ;
        public string DocumentationGuidelineMessagesYZ { get { return _documentationGuidelineMessagesYZ; } set { _documentationGuidelineMessagesYZ = value; } }
        private Value<string> _eligibleNonStandardToStandard;
        public string EligibleNonStandardToStandard { get { return _eligibleNonStandardToStandard; } set { _eligibleNonStandardToStandard = value; } }
        private Value<decimal?> _financeChargeFees;
        public decimal? FinanceChargeFees { get { return _financeChargeFees; } set { _financeChargeFees = value; } }
        private Value<int?> _firstChangeRecase;
        public int? FirstChangeRecase { get { return _firstChangeRecase; } set { _firstChangeRecase = value; } }
        private Value<DateTime?> _firstPmtDateAfterRecast;
        public DateTime? FirstPmtDateAfterRecast { get { return _firstPmtDateAfterRecast; } set { _firstPmtDateAfterRecast = value; } }
        private Value<decimal?> _fullPaymentAfterInterestOnly;
        public decimal? FullPaymentAfterInterestOnly { get { return _fullPaymentAfterInterestOnly; } set { _fullPaymentAfterInterestOnly = value; } }
        private Value<decimal?> _fullyARMPaymentAfterNegAm;
        public decimal? FullyARMPaymentAfterNegAm { get { return _fullyARMPaymentAfterNegAm; } set { _fullyARMPaymentAfterNegAm = value; } }
        private Value<decimal?> _fullyIndexRateHousingRatio;
        public decimal? FullyIndexRateHousingRatio { get { return _fullyIndexRateHousingRatio; } set { _fullyIndexRateHousingRatio = value; } }
        private Value<decimal?> _fullyIndexRateMaxTotalPayment;
        public decimal? FullyIndexRateMaxTotalPayment { get { return _fullyIndexRateMaxTotalPayment; } set { _fullyIndexRateMaxTotalPayment = value; } }
        private Value<decimal?> _fullyIndexRateMonthlyPayment;
        public decimal? FullyIndexRateMonthlyPayment { get { return _fullyIndexRateMonthlyPayment; } set { _fullyIndexRateMonthlyPayment = value; } }
        private Value<decimal?> _fullyIndexRateTotalDebtRatio;
        public decimal? FullyIndexRateTotalDebtRatio { get { return _fullyIndexRateTotalDebtRatio; } set { _fullyIndexRateTotalDebtRatio = value; } }
        private Value<string> _generalATR_Status_Alimony;
        public string GeneralATR_Status_Alimony { get { return _generalATR_Status_Alimony; } set { _generalATR_Status_Alimony = value; } }
        private Value<string> _generalATR_Status_Assets;
        public string GeneralATR_Status_Assets { get { return _generalATR_Status_Assets; } set { _generalATR_Status_Assets = value; } }
        private Value<string> _generalATR_Status_ChildSupport;
        public string GeneralATR_Status_ChildSupport { get { return _generalATR_Status_ChildSupport; } set { _generalATR_Status_ChildSupport = value; } }
        private Value<string> _generalATR_Status_CoveredLoan;
        public string GeneralATR_Status_CoveredLoan { get { return _generalATR_Status_CoveredLoan; } set { _generalATR_Status_CoveredLoan = value; } }
        private Value<string> _generalATR_Status_CreditHistory;
        public string GeneralATR_Status_CreditHistory { get { return _generalATR_Status_CreditHistory; } set { _generalATR_Status_CreditHistory = value; } }
        private Value<string> _generalATR_Status_DebtObligations;
        public string GeneralATR_Status_DebtObligations { get { return _generalATR_Status_DebtObligations; } set { _generalATR_Status_DebtObligations = value; } }
        private Value<string> _generalATR_Status_DTI;
        public string GeneralATR_Status_DTI { get { return _generalATR_Status_DTI; } set { _generalATR_Status_DTI = value; } }
        private Value<string> _generalATR_Status_Employment;
        public string GeneralATR_Status_Employment { get { return _generalATR_Status_Employment; } set { _generalATR_Status_Employment = value; } }
        private Value<string> _generalATR_Status_Income;
        public string GeneralATR_Status_Income { get { return _generalATR_Status_Income; } set { _generalATR_Status_Income = value; } }
        private Value<string> _generalATR_Status_MtgRelatedObligations;
        public string GeneralATR_Status_MtgRelatedObligations { get { return _generalATR_Status_MtgRelatedObligations; } set { _generalATR_Status_MtgRelatedObligations = value; } }
        private Value<string> _generalATR_Status_Overall;
        public string GeneralATR_Status_Overall { get { return _generalATR_Status_Overall; } set { _generalATR_Status_Overall = value; } }
        private Value<string> _generalATR_Status_ResidualIncome;
        public string GeneralATR_Status_ResidualIncome { get { return _generalATR_Status_ResidualIncome; } set { _generalATR_Status_ResidualIncome = value; } }
        private Value<string> _generalATR_Status_SimultaneousLoan;
        public string GeneralATR_Status_SimultaneousLoan { get { return _generalATR_Status_SimultaneousLoan; } set { _generalATR_Status_SimultaneousLoan = value; } }
        private Value<decimal?> _gSEAgencyQM_CalculatedThreshold;
        public decimal? GSEAgencyQM_CalculatedThreshold { get { return _gSEAgencyQM_CalculatedThreshold; } set { _gSEAgencyQM_CalculatedThreshold = value; } }
        private Value<string> _gSEAgencyQM_Status_Alimony;
        public string GSEAgencyQM_Status_Alimony { get { return _gSEAgencyQM_Status_Alimony; } set { _gSEAgencyQM_Status_Alimony = value; } }
        private Value<string> _gSEAgencyQM_Status_Assets;
        public string GSEAgencyQM_Status_Assets { get { return _gSEAgencyQM_Status_Assets; } set { _gSEAgencyQM_Status_Assets = value; } }
        private Value<string> _gSEAgencyQM_Status_BalloonPayment;
        public string GSEAgencyQM_Status_BalloonPayment { get { return _gSEAgencyQM_Status_BalloonPayment; } set { _gSEAgencyQM_Status_BalloonPayment = value; } }
        private Value<string> _gSEAgencyQM_Status_ChildSupport;
        public string GSEAgencyQM_Status_ChildSupport { get { return _gSEAgencyQM_Status_ChildSupport; } set { _gSEAgencyQM_Status_ChildSupport = value; } }
        private Value<string> _gSEAgencyQM_Status_CoveredLoan;
        public string GSEAgencyQM_Status_CoveredLoan { get { return _gSEAgencyQM_Status_CoveredLoan; } set { _gSEAgencyQM_Status_CoveredLoan = value; } }
        private Value<string> _gSEAgencyQM_Status_CreditHistory;
        public string GSEAgencyQM_Status_CreditHistory { get { return _gSEAgencyQM_Status_CreditHistory; } set { _gSEAgencyQM_Status_CreditHistory = value; } }
        private Value<string> _gSEAgencyQM_Status_DebtObligations;
        public string GSEAgencyQM_Status_DebtObligations { get { return _gSEAgencyQM_Status_DebtObligations; } set { _gSEAgencyQM_Status_DebtObligations = value; } }
        private Value<string> _gSEAgencyQM_Status_DTI;
        public string GSEAgencyQM_Status_DTI { get { return _gSEAgencyQM_Status_DTI; } set { _gSEAgencyQM_Status_DTI = value; } }
        private Value<string> _gSEAgencyQM_Status_Employment;
        public string GSEAgencyQM_Status_Employment { get { return _gSEAgencyQM_Status_Employment; } set { _gSEAgencyQM_Status_Employment = value; } }
        private Value<string> _gSEAgencyQM_Status_Income;
        public string GSEAgencyQM_Status_Income { get { return _gSEAgencyQM_Status_Income; } set { _gSEAgencyQM_Status_Income = value; } }
        private Value<string> _gSEAgencyQM_Status_InterestOnly;
        public string GSEAgencyQM_Status_InterestOnly { get { return _gSEAgencyQM_Status_InterestOnly; } set { _gSEAgencyQM_Status_InterestOnly = value; } }
        private Value<string> _gSEAgencyQM_Status_LoanTerm;
        public string GSEAgencyQM_Status_LoanTerm { get { return _gSEAgencyQM_Status_LoanTerm; } set { _gSEAgencyQM_Status_LoanTerm = value; } }
        private Value<string> _gSEAgencyQM_Status_MtgRelatedObligations;
        public string GSEAgencyQM_Status_MtgRelatedObligations { get { return _gSEAgencyQM_Status_MtgRelatedObligations; } set { _gSEAgencyQM_Status_MtgRelatedObligations = value; } }
        private Value<string> _gSEAgencyQM_Status_NegativeAmortization;
        public string GSEAgencyQM_Status_NegativeAmortization { get { return _gSEAgencyQM_Status_NegativeAmortization; } set { _gSEAgencyQM_Status_NegativeAmortization = value; } }
        private Value<string> _gSEAgencyQM_Status_Overall;
        public string GSEAgencyQM_Status_Overall { get { return _gSEAgencyQM_Status_Overall; } set { _gSEAgencyQM_Status_Overall = value; } }
        private Value<string> _gSEAgencyQM_Status_PointsFeesLimit;
        public string GSEAgencyQM_Status_PointsFeesLimit { get { return _gSEAgencyQM_Status_PointsFeesLimit; } set { _gSEAgencyQM_Status_PointsFeesLimit = value; } }
        private Value<string> _gSEAgencyQM_Status_PrepaymentPenalty;
        public string GSEAgencyQM_Status_PrepaymentPenalty { get { return _gSEAgencyQM_Status_PrepaymentPenalty; } set { _gSEAgencyQM_Status_PrepaymentPenalty = value; } }
        private Value<string> _gSEAgencyQM_Status_ResidualIncome;
        public string GSEAgencyQM_Status_ResidualIncome { get { return _gSEAgencyQM_Status_ResidualIncome; } set { _gSEAgencyQM_Status_ResidualIncome = value; } }
        private Value<string> _gSEAgencyQM_Status_SafeHarborEligibility;
        public string GSEAgencyQM_Status_SafeHarborEligibility { get { return _gSEAgencyQM_Status_SafeHarborEligibility; } set { _gSEAgencyQM_Status_SafeHarborEligibility = value; } }
        private Value<string> _gSEAgencyQM_Status_SimultaneousLoan;
        public string GSEAgencyQM_Status_SimultaneousLoan { get { return _gSEAgencyQM_Status_SimultaneousLoan; } set { _gSEAgencyQM_Status_SimultaneousLoan = value; } }
        private Value<bool?> _has30DayLatePayment;
        public bool? Has30DayLatePayment { get { return _has30DayLatePayment; } set { _has30DayLatePayment = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _initialMaxTotalPayment;
        public decimal? InitialMaxTotalPayment { get { return _initialMaxTotalPayment; } set { _initialMaxTotalPayment = value; } }
        private Value<decimal?> _initialRateHousingRatio;
        public decimal? InitialRateHousingRatio { get { return _initialRateHousingRatio; } set { _initialRateHousingRatio = value; } }
        private Value<decimal?> _initialRateMonthlyPayment;
        public decimal? InitialRateMonthlyPayment { get { return _initialRateMonthlyPayment; } set { _initialRateMonthlyPayment = value; } }
        private Value<decimal?> _initialRateTotalDebtRatio;
        public decimal? InitialRateTotalDebtRatio { get { return _initialRateTotalDebtRatio; } set { _initialRateTotalDebtRatio = value; } }
        private Value<int?> _interestOnlyMonths;
        public int? InterestOnlyMonths { get { return _interestOnlyMonths; } set { _interestOnlyMonths = value; } }
        private Value<DateTime?> _interestOnlyRecastDate;
        public DateTime? InterestOnlyRecastDate { get { return _interestOnlyRecastDate; } set { _interestOnlyRecastDate = value; } }
        private Value<bool?> _isConsumerLiklyDefault;
        public bool? IsConsumerLiklyDefault { get { return _isConsumerLiklyDefault; } set { _isConsumerLiklyDefault = value; } }
        private Value<string> _isEligibleForSafeHarbor;
        public string IsEligibleForSafeHarbor { get { return _isEligibleForSafeHarbor; } set { _isEligibleForSafeHarbor = value; } }
        private Value<bool?> _isEvaluatedAlimonyObligations;
        public bool? IsEvaluatedAlimonyObligations { get { return _isEvaluatedAlimonyObligations; } set { _isEvaluatedAlimonyObligations = value; } }
        private Value<bool?> _isEvaluatedChildSupportObligations;
        public bool? IsEvaluatedChildSupportObligations { get { return _isEvaluatedChildSupportObligations; } set { _isEvaluatedChildSupportObligations = value; } }
        private Value<bool?> _isEvaluatedCreditHistory;
        public bool? IsEvaluatedCreditHistory { get { return _isEvaluatedCreditHistory; } set { _isEvaluatedCreditHistory = value; } }
        private Value<bool?> _isEvaluatedCurrentEmploymentStatus;
        public bool? IsEvaluatedCurrentEmploymentStatus { get { return _isEvaluatedCurrentEmploymentStatus; } set { _isEvaluatedCurrentEmploymentStatus = value; } }
        private Value<bool?> _isEvaluatedCurrentExpectedAssets;
        public bool? IsEvaluatedCurrentExpectedAssets { get { return _isEvaluatedCurrentExpectedAssets; } set { _isEvaluatedCurrentExpectedAssets = value; } }
        private Value<bool?> _isEvaluatedCurrentExpectedIncome;
        public bool? IsEvaluatedCurrentExpectedIncome { get { return _isEvaluatedCurrentExpectedIncome; } set { _isEvaluatedCurrentExpectedIncome = value; } }
        private Value<bool?> _isEvaluatedDebtObligations;
        public bool? IsEvaluatedDebtObligations { get { return _isEvaluatedDebtObligations; } set { _isEvaluatedDebtObligations = value; } }
        private Value<bool?> _isEvaluatedDebtToIncomeRatio;
        public bool? IsEvaluatedDebtToIncomeRatio { get { return _isEvaluatedDebtToIncomeRatio; } set { _isEvaluatedDebtToIncomeRatio = value; } }
        private Value<bool?> _isEvaluatedMonthlyCoveredLoanPayment;
        public bool? IsEvaluatedMonthlyCoveredLoanPayment { get { return _isEvaluatedMonthlyCoveredLoanPayment; } set { _isEvaluatedMonthlyCoveredLoanPayment = value; } }
        private Value<bool?> _isEvaluatedMonthlyMortgageRelatedObligations;
        public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get { return _isEvaluatedMonthlyMortgageRelatedObligations; } set { _isEvaluatedMonthlyMortgageRelatedObligations = value; } }
        private Value<bool?> _isEvaluatedMonthlySimultaneousLoanPayment;
        public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get { return _isEvaluatedMonthlySimultaneousLoanPayment; } set { _isEvaluatedMonthlySimultaneousLoanPayment = value; } }
        private Value<bool?> _isEvaluatedResidualIncome;
        public bool? IsEvaluatedResidualIncome { get { return _isEvaluatedResidualIncome; } set { _isEvaluatedResidualIncome = value; } }
        private Value<string> _isHigherPricedLoan;
        public string IsHigherPricedLoan { get { return _isHigherPricedLoan; } set { _isHigherPricedLoan = value; } }
        private Value<string> _loanProcessingInformationD4;
        public string LoanProcessingInformationD4 { get { return _loanProcessingInformationD4; } set { _loanProcessingInformationD4 = value; } }
        private Value<string> _loanProcessingInformationGO;
        public string LoanProcessingInformationGO { get { return _loanProcessingInformationGO; } set { _loanProcessingInformationGO = value; } }
        private Value<string> _loanProcessingInformationHA;
        public string LoanProcessingInformationHA { get { return _loanProcessingInformationHA; } set { _loanProcessingInformationHA = value; } }
        private Value<string> _loanProcessingInformationLE;
        public string LoanProcessingInformationLE { get { return _loanProcessingInformationLE; } set { _loanProcessingInformationLE = value; } }
        private Value<string> _loanProcessingInformationLF;
        public string LoanProcessingInformationLF { get { return _loanProcessingInformationLF; } set { _loanProcessingInformationLF = value; } }
        private Value<string> _loanProcessingInformationMA;
        public string LoanProcessingInformationMA { get { return _loanProcessingInformationMA; } set { _loanProcessingInformationMA = value; } }
        private Value<bool?> _loanProgram;
        public bool? LoanProgram { get { return _loanProgram; } set { _loanProgram = value; } }
        private Value<string> _loanProgramDescription;
        public string LoanProgramDescription { get { return _loanProgramDescription; } set { _loanProgramDescription = value; } }
        private Value<bool?> _loanRateFixedin5Years;
        public bool? LoanRateFixedin5Years { get { return _loanRateFixedin5Years; } set { _loanRateFixedin5Years = value; } }
        private Value<decimal?> _lOBrokerCompensationAmount;
        public decimal? LOBrokerCompensationAmount { get { return _lOBrokerCompensationAmount; } set { _lOBrokerCompensationAmount = value; } }
        private Value<decimal?> _max5YrsHousingRatio;
        public decimal? Max5YrsHousingRatio { get { return _max5YrsHousingRatio; } set { _max5YrsHousingRatio = value; } }
        private Value<decimal?> _max5YrsPrincipleAndInterest;
        public decimal? Max5YrsPrincipleAndInterest { get { return _max5YrsPrincipleAndInterest; } set { _max5YrsPrincipleAndInterest = value; } }
        private Value<decimal?> _max5YrsTotalDebtRatio;
        public decimal? Max5YrsTotalDebtRatio { get { return _max5YrsTotalDebtRatio; } set { _max5YrsTotalDebtRatio = value; } }
        private Value<decimal?> _max5YrsTotalPayment;
        public decimal? Max5YrsTotalPayment { get { return _max5YrsTotalPayment; } set { _max5YrsTotalPayment = value; } }
        private Value<decimal?> _maxPrepaymentPenaltyFees;
        public decimal? MaxPrepaymentPenaltyFees { get { return _maxPrepaymentPenaltyFees; } set { _maxPrepaymentPenaltyFees = value; } }
        private Value<DateTime?> _negAmRecastDate;
        public DateTime? NegAmRecastDate { get { return _negAmRecastDate; } set { _negAmRecastDate = value; } }
        private Value<bool?> _paymentDecreasedBy10Percent;
        public bool? PaymentDecreasedBy10Percent { get { return _paymentDecreasedBy10Percent; } set { _paymentDecreasedBy10Percent = value; } }
        private Value<bool?> _pointsFeesThresholdMet;
        public bool? PointsFeesThresholdMet { get { return _pointsFeesThresholdMet; } set { _pointsFeesThresholdMet = value; } }
        private Value<decimal?> _prepaymentPenaltyPayoffFees;
        public decimal? PrepaymentPenaltyPayoffFees { get { return _prepaymentPenaltyPayoffFees; } set { _prepaymentPenaltyPayoffFees = value; } }
        private Value<decimal?> _prepayPenaltyPercentage;
        public decimal? PrepayPenaltyPercentage { get { return _prepayPenaltyPercentage; } set { _prepayPenaltyPercentage = value; } }
        private Value<bool?> _preventConsumersDefault;
        public bool? PreventConsumersDefault { get { return _preventConsumersDefault; } set { _preventConsumersDefault = value; } }
        private Value<bool?> _principalBalanceIncreased;
        public bool? PrincipalBalanceIncreased { get { return _principalBalanceIncreased; } set { _principalBalanceIncreased = value; } }
        private Value<bool?> _principalHasDeferred;
        public bool? PrincipalHasDeferred { get { return _principalHasDeferred; } set { _principalHasDeferred = value; } }
        private Value<string> _qMLoanType;
        public string QMLoanType { get { return _qMLoanType; } set { _qMLoanType = value; } }
        private Value<decimal?> _rateReductionBasisPoints;
        public decimal? RateReductionBasisPoints { get { return _rateReductionBasisPoints; } set { _rateReductionBasisPoints = value; } }
        private Value<decimal?> _rateReductionDiscountPoints;
        public decimal? RateReductionDiscountPoints { get { return _rateReductionDiscountPoints; } set { _rateReductionDiscountPoints = value; } }
        private Value<decimal?> _rateReductionMaxBonaFideDiscountPoint;
        public decimal? RateReductionMaxBonaFideDiscountPoint { get { return _rateReductionMaxBonaFideDiscountPoint; } set { _rateReductionMaxBonaFideDiscountPoint = value; } }
        private Value<decimal?> _realEstateFees;
        public decimal? RealEstateFees { get { return _realEstateFees; } set { _realEstateFees = value; } }
        private Value<decimal?> _recastDifferencePayment;
        public decimal? RecastDifferencePayment { get { return _recastDifferencePayment; } set { _recastDifferencePayment = value; } }
        private Value<decimal?> _regZTotalLoanAmount;
        public decimal? RegZTotalLoanAmount { get { return _regZTotalLoanAmount; } set { _regZTotalLoanAmount = value; } }
        private Value<decimal?> _requiredServicesLenderSelectedAmt;
        public decimal? RequiredServicesLenderSelectedAmt { get { return _requiredServicesLenderSelectedAmt; } set { _requiredServicesLenderSelectedAmt = value; } }
        private Value<decimal?> _smallCreditorQM_CalculatedThreshold;
        public decimal? SmallCreditorQM_CalculatedThreshold { get { return _smallCreditorQM_CalculatedThreshold; } set { _smallCreditorQM_CalculatedThreshold = value; } }
        private Value<string> _smallCreditorQM_Status_Alimony;
        public string SmallCreditorQM_Status_Alimony { get { return _smallCreditorQM_Status_Alimony; } set { _smallCreditorQM_Status_Alimony = value; } }
        private Value<string> _smallCreditorQM_Status_Assets;
        public string SmallCreditorQM_Status_Assets { get { return _smallCreditorQM_Status_Assets; } set { _smallCreditorQM_Status_Assets = value; } }
        private Value<string> _smallCreditorQM_Status_BalloonPayment;
        public string SmallCreditorQM_Status_BalloonPayment { get { return _smallCreditorQM_Status_BalloonPayment; } set { _smallCreditorQM_Status_BalloonPayment = value; } }
        private Value<string> _smallCreditorQM_Status_ChildSupport;
        public string SmallCreditorQM_Status_ChildSupport { get { return _smallCreditorQM_Status_ChildSupport; } set { _smallCreditorQM_Status_ChildSupport = value; } }
        private Value<string> _smallCreditorQM_Status_CoveredLoan;
        public string SmallCreditorQM_Status_CoveredLoan { get { return _smallCreditorQM_Status_CoveredLoan; } set { _smallCreditorQM_Status_CoveredLoan = value; } }
        private Value<string> _smallCreditorQM_Status_DebtObligations;
        public string SmallCreditorQM_Status_DebtObligations { get { return _smallCreditorQM_Status_DebtObligations; } set { _smallCreditorQM_Status_DebtObligations = value; } }
        private Value<string> _smallCreditorQM_Status_DTI;
        public string SmallCreditorQM_Status_DTI { get { return _smallCreditorQM_Status_DTI; } set { _smallCreditorQM_Status_DTI = value; } }
        private Value<string> _smallCreditorQM_Status_Income;
        public string SmallCreditorQM_Status_Income { get { return _smallCreditorQM_Status_Income; } set { _smallCreditorQM_Status_Income = value; } }
        private Value<string> _smallCreditorQM_Status_InterestOnly;
        public string SmallCreditorQM_Status_InterestOnly { get { return _smallCreditorQM_Status_InterestOnly; } set { _smallCreditorQM_Status_InterestOnly = value; } }
        private Value<string> _smallCreditorQM_Status_LoanTerm;
        public string SmallCreditorQM_Status_LoanTerm { get { return _smallCreditorQM_Status_LoanTerm; } set { _smallCreditorQM_Status_LoanTerm = value; } }
        private Value<string> _smallCreditorQM_Status_MtgRelatedObligations;
        public string SmallCreditorQM_Status_MtgRelatedObligations { get { return _smallCreditorQM_Status_MtgRelatedObligations; } set { _smallCreditorQM_Status_MtgRelatedObligations = value; } }
        private Value<string> _smallCreditorQM_Status_NegativeAmortization;
        public string SmallCreditorQM_Status_NegativeAmortization { get { return _smallCreditorQM_Status_NegativeAmortization; } set { _smallCreditorQM_Status_NegativeAmortization = value; } }
        private Value<string> _smallCreditorQM_Status_Overall;
        public string SmallCreditorQM_Status_Overall { get { return _smallCreditorQM_Status_Overall; } set { _smallCreditorQM_Status_Overall = value; } }
        private Value<string> _smallCreditorQM_Status_PointsFeesLimit;
        public string SmallCreditorQM_Status_PointsFeesLimit { get { return _smallCreditorQM_Status_PointsFeesLimit; } set { _smallCreditorQM_Status_PointsFeesLimit = value; } }
        private Value<string> _smallCreditorQM_Status_PrepaymentPenalty;
        public string SmallCreditorQM_Status_PrepaymentPenalty { get { return _smallCreditorQM_Status_PrepaymentPenalty; } set { _smallCreditorQM_Status_PrepaymentPenalty = value; } }
        private Value<string> _smallCreditorQM_Status_ResidualIncome;
        public string SmallCreditorQM_Status_ResidualIncome { get { return _smallCreditorQM_Status_ResidualIncome; } set { _smallCreditorQM_Status_ResidualIncome = value; } }
        private Value<string> _smallCreditorQM_Status_SafeHarborEligibility;
        public string SmallCreditorQM_Status_SafeHarborEligibility { get { return _smallCreditorQM_Status_SafeHarborEligibility; } set { _smallCreditorQM_Status_SafeHarborEligibility = value; } }
        private Value<decimal?> _standardQM_CalculatedThreshold;
        public decimal? StandardQM_CalculatedThreshold { get { return _standardQM_CalculatedThreshold; } set { _standardQM_CalculatedThreshold = value; } }
        private Value<string> _standardQM_Status_Alimony;
        public string StandardQM_Status_Alimony { get { return _standardQM_Status_Alimony; } set { _standardQM_Status_Alimony = value; } }
        private Value<string> _standardQM_Status_Assets;
        public string StandardQM_Status_Assets { get { return _standardQM_Status_Assets; } set { _standardQM_Status_Assets = value; } }
        private Value<string> _standardQM_Status_BalloonPayment;
        public string StandardQM_Status_BalloonPayment { get { return _standardQM_Status_BalloonPayment; } set { _standardQM_Status_BalloonPayment = value; } }
        private Value<string> _standardQM_Status_ChildSupport;
        public string StandardQM_Status_ChildSupport { get { return _standardQM_Status_ChildSupport; } set { _standardQM_Status_ChildSupport = value; } }
        private Value<string> _standardQM_Status_CoveredLoan;
        public string StandardQM_Status_CoveredLoan { get { return _standardQM_Status_CoveredLoan; } set { _standardQM_Status_CoveredLoan = value; } }
        private Value<string> _standardQM_Status_CreditHistory;
        public string StandardQM_Status_CreditHistory { get { return _standardQM_Status_CreditHistory; } set { _standardQM_Status_CreditHistory = value; } }
        private Value<string> _standardQM_Status_DebtObligations;
        public string StandardQM_Status_DebtObligations { get { return _standardQM_Status_DebtObligations; } set { _standardQM_Status_DebtObligations = value; } }
        private Value<string> _standardQM_Status_DTI;
        public string StandardQM_Status_DTI { get { return _standardQM_Status_DTI; } set { _standardQM_Status_DTI = value; } }
        private Value<string> _standardQM_Status_Employment;
        public string StandardQM_Status_Employment { get { return _standardQM_Status_Employment; } set { _standardQM_Status_Employment = value; } }
        private Value<string> _standardQM_Status_Income;
        public string StandardQM_Status_Income { get { return _standardQM_Status_Income; } set { _standardQM_Status_Income = value; } }
        private Value<string> _standardQM_Status_InterestOnly;
        public string StandardQM_Status_InterestOnly { get { return _standardQM_Status_InterestOnly; } set { _standardQM_Status_InterestOnly = value; } }
        private Value<string> _standardQM_Status_LoanTerm;
        public string StandardQM_Status_LoanTerm { get { return _standardQM_Status_LoanTerm; } set { _standardQM_Status_LoanTerm = value; } }
        private Value<string> _standardQM_Status_MtgRelatedObligations;
        public string StandardQM_Status_MtgRelatedObligations { get { return _standardQM_Status_MtgRelatedObligations; } set { _standardQM_Status_MtgRelatedObligations = value; } }
        private Value<string> _standardQM_Status_NegativeAmortization;
        public string StandardQM_Status_NegativeAmortization { get { return _standardQM_Status_NegativeAmortization; } set { _standardQM_Status_NegativeAmortization = value; } }
        private Value<string> _standardQM_Status_Overall;
        public string StandardQM_Status_Overall { get { return _standardQM_Status_Overall; } set { _standardQM_Status_Overall = value; } }
        private Value<string> _standardQM_Status_PointsFeesLimit;
        public string StandardQM_Status_PointsFeesLimit { get { return _standardQM_Status_PointsFeesLimit; } set { _standardQM_Status_PointsFeesLimit = value; } }
        private Value<string> _standardQM_Status_PrepaymentPenalty;
        public string StandardQM_Status_PrepaymentPenalty { get { return _standardQM_Status_PrepaymentPenalty; } set { _standardQM_Status_PrepaymentPenalty = value; } }
        private Value<string> _standardQM_Status_ResidualIncome;
        public string StandardQM_Status_ResidualIncome { get { return _standardQM_Status_ResidualIncome; } set { _standardQM_Status_ResidualIncome = value; } }
        private Value<string> _standardQM_Status_SafeHarborEligibility;
        public string StandardQM_Status_SafeHarborEligibility { get { return _standardQM_Status_SafeHarborEligibility; } set { _standardQM_Status_SafeHarborEligibility = value; } }
        private Value<string> _standardQM_Status_SimultaneousLoan;
        public string StandardQM_Status_SimultaneousLoan { get { return _standardQM_Status_SimultaneousLoan; } set { _standardQM_Status_SimultaneousLoan = value; } }
        private Value<decimal?> _startingAdjustedRateMaxBonaFideDiscountPoint;
        public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get { return _startingAdjustedRateMaxBonaFideDiscountPoint; } set { _startingAdjustedRateMaxBonaFideDiscountPoint = value; } }
        private Value<string> _status_CreditHistory;
        public string Status_CreditHistory { get { return _status_CreditHistory; } set { _status_CreditHistory = value; } }
        private Value<string> _status_SimultaneousLoan;
        public string Status_SimultaneousLoan { get { return _status_SimultaneousLoan; } set { _status_SimultaneousLoan = value; } }
        private Value<string> _thresholdExceedsQM;
        public string ThresholdExceedsQM { get { return _thresholdExceedsQM; } set { _thresholdExceedsQM = value; } }
        private Value<decimal?> _titleServicesLenderTitleinsuranceFee;
        public decimal? TitleServicesLenderTitleinsuranceFee { get { return _titleServicesLenderTitleinsuranceFee; } set { _titleServicesLenderTitleinsuranceFee = value; } }
        private Value<decimal?> _totalCoMortgagorIncome;
        public decimal? TotalCoMortgagorIncome { get { return _totalCoMortgagorIncome; } set { _totalCoMortgagorIncome = value; } }
        private Value<decimal?> _totalIncome;
        public decimal? TotalIncome { get { return _totalIncome; } set { _totalIncome = value; } }
        private Value<decimal?> _totalPointsFeesSec32Percent;
        public decimal? TotalPointsFeesSec32Percent { get { return _totalPointsFeesSec32Percent; } set { _totalPointsFeesSec32Percent = value; } }
        private Value<bool?> _transactionExemptFromRegZ;
        public bool? TransactionExemptFromRegZ { get { return _transactionExemptFromRegZ; } set { _transactionExemptFromRegZ = value; } }
        private Value<bool?> _unitCount;
        public bool? UnitCount { get { return _unitCount; } set { _unitCount = value; } }
        private Value<decimal?> _upfrontPMIFees;
        public decimal? UpfrontPMIFees { get { return _upfrontPMIFees; } set { _upfrontPMIFees = value; } }
        private Value<bool?> _withOriginalCreditor;
        public bool? WithOriginalCreditor { get { return _withOriginalCreditor; } set { _withOriginalCreditor = value; } }
        private Value<DateTime?> _writtenApplicationDate;
        public DateTime? WrittenApplicationDate { get { return _writtenApplicationDate; } set { _writtenApplicationDate = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _affiliatesFees.Clean
                    && _aPORMaxBonaFideDiscountPoint.Clean
                    && _aRMRecastDate.Clean
                    && _aRMRecastMonthlyPayment.Clean
                    && _aTRLoanType.Clean
                    && _aUSDataDiscrepencyResolutionComments.Clean
                    && _aUSDataDiscrepencyResolutionDate.Clean
                    && _aUSDataDiscrepencyResolvedBy.Clean
                    && _bonaFideDiscountPoint.Clean
                    && _bonaFideDiscountPointAmount.Clean
                    && _brokerCompensationWhenRateSet.Clean
                    && _collateralRepandWarrReliefEligibilityType.Clean
                    && _compensationPTBFees.Clean
                    && _creditInsPremiumFees.Clean
                    && _creditorType.Clean
                    && _creditorTypeDescription.Clean
                    && _creditType.Clean
                    && _currentQMFeeThresholdAmt.Clean
                    && _currentQMFeeThresholdPercent.Clean
                    && _dateOfLastMonthlyPayment.Clean
                    && _discountPointAmount.Clean
                    && _discountPointFees.Clean
                    && _discountPointPercentage.Clean
                    && _documentationGuidelineMessages4V.Clean
                    && _documentationGuidelineMessages5C.Clean
                    && _documentationGuidelineMessages8Y.Clean
                    && _documentationGuidelineMessagesCN.Clean
                    && _documentationGuidelineMessagesCP.Clean
                    && _documentationGuidelineMessagesCV.Clean
                    && _documentationGuidelineMessagesCY.Clean
                    && _documentationGuidelineMessagesCZ.Clean
                    && _documentationGuidelineMessagesDP.Clean
                    && _documentationGuidelineMessagesDZ.Clean
                    && _documentationGuidelineMessagesE5.Clean
                    && _documentationGuidelineMessagesIM.Clean
                    && _documentationGuidelineMessagesIQ.Clean
                    && _documentationGuidelineMessagesJF.Clean
                    && _documentationGuidelineMessagesQJ.Clean
                    && _documentationGuidelineMessagesQN.Clean
                    && _documentationGuidelineMessagesQQ.Clean
                    && _documentationGuidelineMessagesQS.Clean
                    && _documentationGuidelineMessagesU7.Clean
                    && _documentationGuidelineMessagesX1.Clean
                    && _documentationGuidelineMessagesX3.Clean
                    && _documentationGuidelineMessagesX5.Clean
                    && _documentationGuidelineMessagesX7.Clean
                    && _documentationGuidelineMessagesXA.Clean
                    && _documentationGuidelineMessagesXM.Clean
                    && _documentationGuidelineMessagesXP.Clean
                    && _documentationGuidelineMessagesXR.Clean
                    && _documentationGuidelineMessagesXT.Clean
                    && _documentationGuidelineMessagesY8.Clean
                    && _documentationGuidelineMessagesYG.Clean
                    && _documentationGuidelineMessagesYJ.Clean
                    && _documentationGuidelineMessagesYY.Clean
                    && _documentationGuidelineMessagesYZ.Clean
                    && _eligibleNonStandardToStandard.Clean
                    && _financeChargeFees.Clean
                    && _firstChangeRecase.Clean
                    && _firstPmtDateAfterRecast.Clean
                    && _fullPaymentAfterInterestOnly.Clean
                    && _fullyARMPaymentAfterNegAm.Clean
                    && _fullyIndexRateHousingRatio.Clean
                    && _fullyIndexRateMaxTotalPayment.Clean
                    && _fullyIndexRateMonthlyPayment.Clean
                    && _fullyIndexRateTotalDebtRatio.Clean
                    && _generalATR_Status_Alimony.Clean
                    && _generalATR_Status_Assets.Clean
                    && _generalATR_Status_ChildSupport.Clean
                    && _generalATR_Status_CoveredLoan.Clean
                    && _generalATR_Status_CreditHistory.Clean
                    && _generalATR_Status_DebtObligations.Clean
                    && _generalATR_Status_DTI.Clean
                    && _generalATR_Status_Employment.Clean
                    && _generalATR_Status_Income.Clean
                    && _generalATR_Status_MtgRelatedObligations.Clean
                    && _generalATR_Status_Overall.Clean
                    && _generalATR_Status_ResidualIncome.Clean
                    && _generalATR_Status_SimultaneousLoan.Clean
                    && _gSEAgencyQM_CalculatedThreshold.Clean
                    && _gSEAgencyQM_Status_Alimony.Clean
                    && _gSEAgencyQM_Status_Assets.Clean
                    && _gSEAgencyQM_Status_BalloonPayment.Clean
                    && _gSEAgencyQM_Status_ChildSupport.Clean
                    && _gSEAgencyQM_Status_CoveredLoan.Clean
                    && _gSEAgencyQM_Status_CreditHistory.Clean
                    && _gSEAgencyQM_Status_DebtObligations.Clean
                    && _gSEAgencyQM_Status_DTI.Clean
                    && _gSEAgencyQM_Status_Employment.Clean
                    && _gSEAgencyQM_Status_Income.Clean
                    && _gSEAgencyQM_Status_InterestOnly.Clean
                    && _gSEAgencyQM_Status_LoanTerm.Clean
                    && _gSEAgencyQM_Status_MtgRelatedObligations.Clean
                    && _gSEAgencyQM_Status_NegativeAmortization.Clean
                    && _gSEAgencyQM_Status_Overall.Clean
                    && _gSEAgencyQM_Status_PointsFeesLimit.Clean
                    && _gSEAgencyQM_Status_PrepaymentPenalty.Clean
                    && _gSEAgencyQM_Status_ResidualIncome.Clean
                    && _gSEAgencyQM_Status_SafeHarborEligibility.Clean
                    && _gSEAgencyQM_Status_SimultaneousLoan.Clean
                    && _has30DayLatePayment.Clean
                    && _id.Clean
                    && _initialMaxTotalPayment.Clean
                    && _initialRateHousingRatio.Clean
                    && _initialRateMonthlyPayment.Clean
                    && _initialRateTotalDebtRatio.Clean
                    && _interestOnlyMonths.Clean
                    && _interestOnlyRecastDate.Clean
                    && _isConsumerLiklyDefault.Clean
                    && _isEligibleForSafeHarbor.Clean
                    && _isEvaluatedAlimonyObligations.Clean
                    && _isEvaluatedChildSupportObligations.Clean
                    && _isEvaluatedCreditHistory.Clean
                    && _isEvaluatedCurrentEmploymentStatus.Clean
                    && _isEvaluatedCurrentExpectedAssets.Clean
                    && _isEvaluatedCurrentExpectedIncome.Clean
                    && _isEvaluatedDebtObligations.Clean
                    && _isEvaluatedDebtToIncomeRatio.Clean
                    && _isEvaluatedMonthlyCoveredLoanPayment.Clean
                    && _isEvaluatedMonthlyMortgageRelatedObligations.Clean
                    && _isEvaluatedMonthlySimultaneousLoanPayment.Clean
                    && _isEvaluatedResidualIncome.Clean
                    && _isHigherPricedLoan.Clean
                    && _loanProcessingInformationD4.Clean
                    && _loanProcessingInformationGO.Clean
                    && _loanProcessingInformationHA.Clean
                    && _loanProcessingInformationLE.Clean
                    && _loanProcessingInformationLF.Clean
                    && _loanProcessingInformationMA.Clean
                    && _loanProgram.Clean
                    && _loanProgramDescription.Clean
                    && _loanRateFixedin5Years.Clean
                    && _lOBrokerCompensationAmount.Clean
                    && _max5YrsHousingRatio.Clean
                    && _max5YrsPrincipleAndInterest.Clean
                    && _max5YrsTotalDebtRatio.Clean
                    && _max5YrsTotalPayment.Clean
                    && _maxPrepaymentPenaltyFees.Clean
                    && _negAmRecastDate.Clean
                    && _paymentDecreasedBy10Percent.Clean
                    && _pointsFeesThresholdMet.Clean
                    && _prepaymentPenaltyPayoffFees.Clean
                    && _prepayPenaltyPercentage.Clean
                    && _preventConsumersDefault.Clean
                    && _principalBalanceIncreased.Clean
                    && _principalHasDeferred.Clean
                    && _qMLoanType.Clean
                    && _rateReductionBasisPoints.Clean
                    && _rateReductionDiscountPoints.Clean
                    && _rateReductionMaxBonaFideDiscountPoint.Clean
                    && _realEstateFees.Clean
                    && _recastDifferencePayment.Clean
                    && _regZTotalLoanAmount.Clean
                    && _requiredServicesLenderSelectedAmt.Clean
                    && _smallCreditorQM_CalculatedThreshold.Clean
                    && _smallCreditorQM_Status_Alimony.Clean
                    && _smallCreditorQM_Status_Assets.Clean
                    && _smallCreditorQM_Status_BalloonPayment.Clean
                    && _smallCreditorQM_Status_ChildSupport.Clean
                    && _smallCreditorQM_Status_CoveredLoan.Clean
                    && _smallCreditorQM_Status_DebtObligations.Clean
                    && _smallCreditorQM_Status_DTI.Clean
                    && _smallCreditorQM_Status_Income.Clean
                    && _smallCreditorQM_Status_InterestOnly.Clean
                    && _smallCreditorQM_Status_LoanTerm.Clean
                    && _smallCreditorQM_Status_MtgRelatedObligations.Clean
                    && _smallCreditorQM_Status_NegativeAmortization.Clean
                    && _smallCreditorQM_Status_Overall.Clean
                    && _smallCreditorQM_Status_PointsFeesLimit.Clean
                    && _smallCreditorQM_Status_PrepaymentPenalty.Clean
                    && _smallCreditorQM_Status_ResidualIncome.Clean
                    && _smallCreditorQM_Status_SafeHarborEligibility.Clean
                    && _standardQM_CalculatedThreshold.Clean
                    && _standardQM_Status_Alimony.Clean
                    && _standardQM_Status_Assets.Clean
                    && _standardQM_Status_BalloonPayment.Clean
                    && _standardQM_Status_ChildSupport.Clean
                    && _standardQM_Status_CoveredLoan.Clean
                    && _standardQM_Status_CreditHistory.Clean
                    && _standardQM_Status_DebtObligations.Clean
                    && _standardQM_Status_DTI.Clean
                    && _standardQM_Status_Employment.Clean
                    && _standardQM_Status_Income.Clean
                    && _standardQM_Status_InterestOnly.Clean
                    && _standardQM_Status_LoanTerm.Clean
                    && _standardQM_Status_MtgRelatedObligations.Clean
                    && _standardQM_Status_NegativeAmortization.Clean
                    && _standardQM_Status_Overall.Clean
                    && _standardQM_Status_PointsFeesLimit.Clean
                    && _standardQM_Status_PrepaymentPenalty.Clean
                    && _standardQM_Status_ResidualIncome.Clean
                    && _standardQM_Status_SafeHarborEligibility.Clean
                    && _standardQM_Status_SimultaneousLoan.Clean
                    && _startingAdjustedRateMaxBonaFideDiscountPoint.Clean
                    && _status_CreditHistory.Clean
                    && _status_SimultaneousLoan.Clean
                    && _thresholdExceedsQM.Clean
                    && _titleServicesLenderTitleinsuranceFee.Clean
                    && _totalCoMortgagorIncome.Clean
                    && _totalIncome.Clean
                    && _totalPointsFeesSec32Percent.Clean
                    && _transactionExemptFromRegZ.Clean
                    && _unitCount.Clean
                    && _upfrontPMIFees.Clean
                    && _withOriginalCreditor.Clean
                    && _writtenApplicationDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var affiliatesFees = _affiliatesFees; affiliatesFees.Clean = value; _affiliatesFees = affiliatesFees;
                var aPORMaxBonaFideDiscountPoint = _aPORMaxBonaFideDiscountPoint; aPORMaxBonaFideDiscountPoint.Clean = value; _aPORMaxBonaFideDiscountPoint = aPORMaxBonaFideDiscountPoint;
                var aRMRecastDate = _aRMRecastDate; aRMRecastDate.Clean = value; _aRMRecastDate = aRMRecastDate;
                var aRMRecastMonthlyPayment = _aRMRecastMonthlyPayment; aRMRecastMonthlyPayment.Clean = value; _aRMRecastMonthlyPayment = aRMRecastMonthlyPayment;
                var aTRLoanType = _aTRLoanType; aTRLoanType.Clean = value; _aTRLoanType = aTRLoanType;
                var aUSDataDiscrepencyResolutionComments = _aUSDataDiscrepencyResolutionComments; aUSDataDiscrepencyResolutionComments.Clean = value; _aUSDataDiscrepencyResolutionComments = aUSDataDiscrepencyResolutionComments;
                var aUSDataDiscrepencyResolutionDate = _aUSDataDiscrepencyResolutionDate; aUSDataDiscrepencyResolutionDate.Clean = value; _aUSDataDiscrepencyResolutionDate = aUSDataDiscrepencyResolutionDate;
                var aUSDataDiscrepencyResolvedBy = _aUSDataDiscrepencyResolvedBy; aUSDataDiscrepencyResolvedBy.Clean = value; _aUSDataDiscrepencyResolvedBy = aUSDataDiscrepencyResolvedBy;
                var bonaFideDiscountPoint = _bonaFideDiscountPoint; bonaFideDiscountPoint.Clean = value; _bonaFideDiscountPoint = bonaFideDiscountPoint;
                var bonaFideDiscountPointAmount = _bonaFideDiscountPointAmount; bonaFideDiscountPointAmount.Clean = value; _bonaFideDiscountPointAmount = bonaFideDiscountPointAmount;
                var brokerCompensationWhenRateSet = _brokerCompensationWhenRateSet; brokerCompensationWhenRateSet.Clean = value; _brokerCompensationWhenRateSet = brokerCompensationWhenRateSet;
                var collateralRepandWarrReliefEligibilityType = _collateralRepandWarrReliefEligibilityType; collateralRepandWarrReliefEligibilityType.Clean = value; _collateralRepandWarrReliefEligibilityType = collateralRepandWarrReliefEligibilityType;
                var compensationPTBFees = _compensationPTBFees; compensationPTBFees.Clean = value; _compensationPTBFees = compensationPTBFees;
                var creditInsPremiumFees = _creditInsPremiumFees; creditInsPremiumFees.Clean = value; _creditInsPremiumFees = creditInsPremiumFees;
                var creditorType = _creditorType; creditorType.Clean = value; _creditorType = creditorType;
                var creditorTypeDescription = _creditorTypeDescription; creditorTypeDescription.Clean = value; _creditorTypeDescription = creditorTypeDescription;
                var creditType = _creditType; creditType.Clean = value; _creditType = creditType;
                var currentQMFeeThresholdAmt = _currentQMFeeThresholdAmt; currentQMFeeThresholdAmt.Clean = value; _currentQMFeeThresholdAmt = currentQMFeeThresholdAmt;
                var currentQMFeeThresholdPercent = _currentQMFeeThresholdPercent; currentQMFeeThresholdPercent.Clean = value; _currentQMFeeThresholdPercent = currentQMFeeThresholdPercent;
                var dateOfLastMonthlyPayment = _dateOfLastMonthlyPayment; dateOfLastMonthlyPayment.Clean = value; _dateOfLastMonthlyPayment = dateOfLastMonthlyPayment;
                var discountPointAmount = _discountPointAmount; discountPointAmount.Clean = value; _discountPointAmount = discountPointAmount;
                var discountPointFees = _discountPointFees; discountPointFees.Clean = value; _discountPointFees = discountPointFees;
                var discountPointPercentage = _discountPointPercentage; discountPointPercentage.Clean = value; _discountPointPercentage = discountPointPercentage;
                var documentationGuidelineMessages4V = _documentationGuidelineMessages4V; documentationGuidelineMessages4V.Clean = value; _documentationGuidelineMessages4V = documentationGuidelineMessages4V;
                var documentationGuidelineMessages5C = _documentationGuidelineMessages5C; documentationGuidelineMessages5C.Clean = value; _documentationGuidelineMessages5C = documentationGuidelineMessages5C;
                var documentationGuidelineMessages8Y = _documentationGuidelineMessages8Y; documentationGuidelineMessages8Y.Clean = value; _documentationGuidelineMessages8Y = documentationGuidelineMessages8Y;
                var documentationGuidelineMessagesCN = _documentationGuidelineMessagesCN; documentationGuidelineMessagesCN.Clean = value; _documentationGuidelineMessagesCN = documentationGuidelineMessagesCN;
                var documentationGuidelineMessagesCP = _documentationGuidelineMessagesCP; documentationGuidelineMessagesCP.Clean = value; _documentationGuidelineMessagesCP = documentationGuidelineMessagesCP;
                var documentationGuidelineMessagesCV = _documentationGuidelineMessagesCV; documentationGuidelineMessagesCV.Clean = value; _documentationGuidelineMessagesCV = documentationGuidelineMessagesCV;
                var documentationGuidelineMessagesCY = _documentationGuidelineMessagesCY; documentationGuidelineMessagesCY.Clean = value; _documentationGuidelineMessagesCY = documentationGuidelineMessagesCY;
                var documentationGuidelineMessagesCZ = _documentationGuidelineMessagesCZ; documentationGuidelineMessagesCZ.Clean = value; _documentationGuidelineMessagesCZ = documentationGuidelineMessagesCZ;
                var documentationGuidelineMessagesDP = _documentationGuidelineMessagesDP; documentationGuidelineMessagesDP.Clean = value; _documentationGuidelineMessagesDP = documentationGuidelineMessagesDP;
                var documentationGuidelineMessagesDZ = _documentationGuidelineMessagesDZ; documentationGuidelineMessagesDZ.Clean = value; _documentationGuidelineMessagesDZ = documentationGuidelineMessagesDZ;
                var documentationGuidelineMessagesE5 = _documentationGuidelineMessagesE5; documentationGuidelineMessagesE5.Clean = value; _documentationGuidelineMessagesE5 = documentationGuidelineMessagesE5;
                var documentationGuidelineMessagesIM = _documentationGuidelineMessagesIM; documentationGuidelineMessagesIM.Clean = value; _documentationGuidelineMessagesIM = documentationGuidelineMessagesIM;
                var documentationGuidelineMessagesIQ = _documentationGuidelineMessagesIQ; documentationGuidelineMessagesIQ.Clean = value; _documentationGuidelineMessagesIQ = documentationGuidelineMessagesIQ;
                var documentationGuidelineMessagesJF = _documentationGuidelineMessagesJF; documentationGuidelineMessagesJF.Clean = value; _documentationGuidelineMessagesJF = documentationGuidelineMessagesJF;
                var documentationGuidelineMessagesQJ = _documentationGuidelineMessagesQJ; documentationGuidelineMessagesQJ.Clean = value; _documentationGuidelineMessagesQJ = documentationGuidelineMessagesQJ;
                var documentationGuidelineMessagesQN = _documentationGuidelineMessagesQN; documentationGuidelineMessagesQN.Clean = value; _documentationGuidelineMessagesQN = documentationGuidelineMessagesQN;
                var documentationGuidelineMessagesQQ = _documentationGuidelineMessagesQQ; documentationGuidelineMessagesQQ.Clean = value; _documentationGuidelineMessagesQQ = documentationGuidelineMessagesQQ;
                var documentationGuidelineMessagesQS = _documentationGuidelineMessagesQS; documentationGuidelineMessagesQS.Clean = value; _documentationGuidelineMessagesQS = documentationGuidelineMessagesQS;
                var documentationGuidelineMessagesU7 = _documentationGuidelineMessagesU7; documentationGuidelineMessagesU7.Clean = value; _documentationGuidelineMessagesU7 = documentationGuidelineMessagesU7;
                var documentationGuidelineMessagesX1 = _documentationGuidelineMessagesX1; documentationGuidelineMessagesX1.Clean = value; _documentationGuidelineMessagesX1 = documentationGuidelineMessagesX1;
                var documentationGuidelineMessagesX3 = _documentationGuidelineMessagesX3; documentationGuidelineMessagesX3.Clean = value; _documentationGuidelineMessagesX3 = documentationGuidelineMessagesX3;
                var documentationGuidelineMessagesX5 = _documentationGuidelineMessagesX5; documentationGuidelineMessagesX5.Clean = value; _documentationGuidelineMessagesX5 = documentationGuidelineMessagesX5;
                var documentationGuidelineMessagesX7 = _documentationGuidelineMessagesX7; documentationGuidelineMessagesX7.Clean = value; _documentationGuidelineMessagesX7 = documentationGuidelineMessagesX7;
                var documentationGuidelineMessagesXA = _documentationGuidelineMessagesXA; documentationGuidelineMessagesXA.Clean = value; _documentationGuidelineMessagesXA = documentationGuidelineMessagesXA;
                var documentationGuidelineMessagesXM = _documentationGuidelineMessagesXM; documentationGuidelineMessagesXM.Clean = value; _documentationGuidelineMessagesXM = documentationGuidelineMessagesXM;
                var documentationGuidelineMessagesXP = _documentationGuidelineMessagesXP; documentationGuidelineMessagesXP.Clean = value; _documentationGuidelineMessagesXP = documentationGuidelineMessagesXP;
                var documentationGuidelineMessagesXR = _documentationGuidelineMessagesXR; documentationGuidelineMessagesXR.Clean = value; _documentationGuidelineMessagesXR = documentationGuidelineMessagesXR;
                var documentationGuidelineMessagesXT = _documentationGuidelineMessagesXT; documentationGuidelineMessagesXT.Clean = value; _documentationGuidelineMessagesXT = documentationGuidelineMessagesXT;
                var documentationGuidelineMessagesY8 = _documentationGuidelineMessagesY8; documentationGuidelineMessagesY8.Clean = value; _documentationGuidelineMessagesY8 = documentationGuidelineMessagesY8;
                var documentationGuidelineMessagesYG = _documentationGuidelineMessagesYG; documentationGuidelineMessagesYG.Clean = value; _documentationGuidelineMessagesYG = documentationGuidelineMessagesYG;
                var documentationGuidelineMessagesYJ = _documentationGuidelineMessagesYJ; documentationGuidelineMessagesYJ.Clean = value; _documentationGuidelineMessagesYJ = documentationGuidelineMessagesYJ;
                var documentationGuidelineMessagesYY = _documentationGuidelineMessagesYY; documentationGuidelineMessagesYY.Clean = value; _documentationGuidelineMessagesYY = documentationGuidelineMessagesYY;
                var documentationGuidelineMessagesYZ = _documentationGuidelineMessagesYZ; documentationGuidelineMessagesYZ.Clean = value; _documentationGuidelineMessagesYZ = documentationGuidelineMessagesYZ;
                var eligibleNonStandardToStandard = _eligibleNonStandardToStandard; eligibleNonStandardToStandard.Clean = value; _eligibleNonStandardToStandard = eligibleNonStandardToStandard;
                var financeChargeFees = _financeChargeFees; financeChargeFees.Clean = value; _financeChargeFees = financeChargeFees;
                var firstChangeRecase = _firstChangeRecase; firstChangeRecase.Clean = value; _firstChangeRecase = firstChangeRecase;
                var firstPmtDateAfterRecast = _firstPmtDateAfterRecast; firstPmtDateAfterRecast.Clean = value; _firstPmtDateAfterRecast = firstPmtDateAfterRecast;
                var fullPaymentAfterInterestOnly = _fullPaymentAfterInterestOnly; fullPaymentAfterInterestOnly.Clean = value; _fullPaymentAfterInterestOnly = fullPaymentAfterInterestOnly;
                var fullyARMPaymentAfterNegAm = _fullyARMPaymentAfterNegAm; fullyARMPaymentAfterNegAm.Clean = value; _fullyARMPaymentAfterNegAm = fullyARMPaymentAfterNegAm;
                var fullyIndexRateHousingRatio = _fullyIndexRateHousingRatio; fullyIndexRateHousingRatio.Clean = value; _fullyIndexRateHousingRatio = fullyIndexRateHousingRatio;
                var fullyIndexRateMaxTotalPayment = _fullyIndexRateMaxTotalPayment; fullyIndexRateMaxTotalPayment.Clean = value; _fullyIndexRateMaxTotalPayment = fullyIndexRateMaxTotalPayment;
                var fullyIndexRateMonthlyPayment = _fullyIndexRateMonthlyPayment; fullyIndexRateMonthlyPayment.Clean = value; _fullyIndexRateMonthlyPayment = fullyIndexRateMonthlyPayment;
                var fullyIndexRateTotalDebtRatio = _fullyIndexRateTotalDebtRatio; fullyIndexRateTotalDebtRatio.Clean = value; _fullyIndexRateTotalDebtRatio = fullyIndexRateTotalDebtRatio;
                var generalATR_Status_Alimony = _generalATR_Status_Alimony; generalATR_Status_Alimony.Clean = value; _generalATR_Status_Alimony = generalATR_Status_Alimony;
                var generalATR_Status_Assets = _generalATR_Status_Assets; generalATR_Status_Assets.Clean = value; _generalATR_Status_Assets = generalATR_Status_Assets;
                var generalATR_Status_ChildSupport = _generalATR_Status_ChildSupport; generalATR_Status_ChildSupport.Clean = value; _generalATR_Status_ChildSupport = generalATR_Status_ChildSupport;
                var generalATR_Status_CoveredLoan = _generalATR_Status_CoveredLoan; generalATR_Status_CoveredLoan.Clean = value; _generalATR_Status_CoveredLoan = generalATR_Status_CoveredLoan;
                var generalATR_Status_CreditHistory = _generalATR_Status_CreditHistory; generalATR_Status_CreditHistory.Clean = value; _generalATR_Status_CreditHistory = generalATR_Status_CreditHistory;
                var generalATR_Status_DebtObligations = _generalATR_Status_DebtObligations; generalATR_Status_DebtObligations.Clean = value; _generalATR_Status_DebtObligations = generalATR_Status_DebtObligations;
                var generalATR_Status_DTI = _generalATR_Status_DTI; generalATR_Status_DTI.Clean = value; _generalATR_Status_DTI = generalATR_Status_DTI;
                var generalATR_Status_Employment = _generalATR_Status_Employment; generalATR_Status_Employment.Clean = value; _generalATR_Status_Employment = generalATR_Status_Employment;
                var generalATR_Status_Income = _generalATR_Status_Income; generalATR_Status_Income.Clean = value; _generalATR_Status_Income = generalATR_Status_Income;
                var generalATR_Status_MtgRelatedObligations = _generalATR_Status_MtgRelatedObligations; generalATR_Status_MtgRelatedObligations.Clean = value; _generalATR_Status_MtgRelatedObligations = generalATR_Status_MtgRelatedObligations;
                var generalATR_Status_Overall = _generalATR_Status_Overall; generalATR_Status_Overall.Clean = value; _generalATR_Status_Overall = generalATR_Status_Overall;
                var generalATR_Status_ResidualIncome = _generalATR_Status_ResidualIncome; generalATR_Status_ResidualIncome.Clean = value; _generalATR_Status_ResidualIncome = generalATR_Status_ResidualIncome;
                var generalATR_Status_SimultaneousLoan = _generalATR_Status_SimultaneousLoan; generalATR_Status_SimultaneousLoan.Clean = value; _generalATR_Status_SimultaneousLoan = generalATR_Status_SimultaneousLoan;
                var gSEAgencyQM_CalculatedThreshold = _gSEAgencyQM_CalculatedThreshold; gSEAgencyQM_CalculatedThreshold.Clean = value; _gSEAgencyQM_CalculatedThreshold = gSEAgencyQM_CalculatedThreshold;
                var gSEAgencyQM_Status_Alimony = _gSEAgencyQM_Status_Alimony; gSEAgencyQM_Status_Alimony.Clean = value; _gSEAgencyQM_Status_Alimony = gSEAgencyQM_Status_Alimony;
                var gSEAgencyQM_Status_Assets = _gSEAgencyQM_Status_Assets; gSEAgencyQM_Status_Assets.Clean = value; _gSEAgencyQM_Status_Assets = gSEAgencyQM_Status_Assets;
                var gSEAgencyQM_Status_BalloonPayment = _gSEAgencyQM_Status_BalloonPayment; gSEAgencyQM_Status_BalloonPayment.Clean = value; _gSEAgencyQM_Status_BalloonPayment = gSEAgencyQM_Status_BalloonPayment;
                var gSEAgencyQM_Status_ChildSupport = _gSEAgencyQM_Status_ChildSupport; gSEAgencyQM_Status_ChildSupport.Clean = value; _gSEAgencyQM_Status_ChildSupport = gSEAgencyQM_Status_ChildSupport;
                var gSEAgencyQM_Status_CoveredLoan = _gSEAgencyQM_Status_CoveredLoan; gSEAgencyQM_Status_CoveredLoan.Clean = value; _gSEAgencyQM_Status_CoveredLoan = gSEAgencyQM_Status_CoveredLoan;
                var gSEAgencyQM_Status_CreditHistory = _gSEAgencyQM_Status_CreditHistory; gSEAgencyQM_Status_CreditHistory.Clean = value; _gSEAgencyQM_Status_CreditHistory = gSEAgencyQM_Status_CreditHistory;
                var gSEAgencyQM_Status_DebtObligations = _gSEAgencyQM_Status_DebtObligations; gSEAgencyQM_Status_DebtObligations.Clean = value; _gSEAgencyQM_Status_DebtObligations = gSEAgencyQM_Status_DebtObligations;
                var gSEAgencyQM_Status_DTI = _gSEAgencyQM_Status_DTI; gSEAgencyQM_Status_DTI.Clean = value; _gSEAgencyQM_Status_DTI = gSEAgencyQM_Status_DTI;
                var gSEAgencyQM_Status_Employment = _gSEAgencyQM_Status_Employment; gSEAgencyQM_Status_Employment.Clean = value; _gSEAgencyQM_Status_Employment = gSEAgencyQM_Status_Employment;
                var gSEAgencyQM_Status_Income = _gSEAgencyQM_Status_Income; gSEAgencyQM_Status_Income.Clean = value; _gSEAgencyQM_Status_Income = gSEAgencyQM_Status_Income;
                var gSEAgencyQM_Status_InterestOnly = _gSEAgencyQM_Status_InterestOnly; gSEAgencyQM_Status_InterestOnly.Clean = value; _gSEAgencyQM_Status_InterestOnly = gSEAgencyQM_Status_InterestOnly;
                var gSEAgencyQM_Status_LoanTerm = _gSEAgencyQM_Status_LoanTerm; gSEAgencyQM_Status_LoanTerm.Clean = value; _gSEAgencyQM_Status_LoanTerm = gSEAgencyQM_Status_LoanTerm;
                var gSEAgencyQM_Status_MtgRelatedObligations = _gSEAgencyQM_Status_MtgRelatedObligations; gSEAgencyQM_Status_MtgRelatedObligations.Clean = value; _gSEAgencyQM_Status_MtgRelatedObligations = gSEAgencyQM_Status_MtgRelatedObligations;
                var gSEAgencyQM_Status_NegativeAmortization = _gSEAgencyQM_Status_NegativeAmortization; gSEAgencyQM_Status_NegativeAmortization.Clean = value; _gSEAgencyQM_Status_NegativeAmortization = gSEAgencyQM_Status_NegativeAmortization;
                var gSEAgencyQM_Status_Overall = _gSEAgencyQM_Status_Overall; gSEAgencyQM_Status_Overall.Clean = value; _gSEAgencyQM_Status_Overall = gSEAgencyQM_Status_Overall;
                var gSEAgencyQM_Status_PointsFeesLimit = _gSEAgencyQM_Status_PointsFeesLimit; gSEAgencyQM_Status_PointsFeesLimit.Clean = value; _gSEAgencyQM_Status_PointsFeesLimit = gSEAgencyQM_Status_PointsFeesLimit;
                var gSEAgencyQM_Status_PrepaymentPenalty = _gSEAgencyQM_Status_PrepaymentPenalty; gSEAgencyQM_Status_PrepaymentPenalty.Clean = value; _gSEAgencyQM_Status_PrepaymentPenalty = gSEAgencyQM_Status_PrepaymentPenalty;
                var gSEAgencyQM_Status_ResidualIncome = _gSEAgencyQM_Status_ResidualIncome; gSEAgencyQM_Status_ResidualIncome.Clean = value; _gSEAgencyQM_Status_ResidualIncome = gSEAgencyQM_Status_ResidualIncome;
                var gSEAgencyQM_Status_SafeHarborEligibility = _gSEAgencyQM_Status_SafeHarborEligibility; gSEAgencyQM_Status_SafeHarborEligibility.Clean = value; _gSEAgencyQM_Status_SafeHarborEligibility = gSEAgencyQM_Status_SafeHarborEligibility;
                var gSEAgencyQM_Status_SimultaneousLoan = _gSEAgencyQM_Status_SimultaneousLoan; gSEAgencyQM_Status_SimultaneousLoan.Clean = value; _gSEAgencyQM_Status_SimultaneousLoan = gSEAgencyQM_Status_SimultaneousLoan;
                var has30DayLatePayment = _has30DayLatePayment; has30DayLatePayment.Clean = value; _has30DayLatePayment = has30DayLatePayment;
                var id = _id; id.Clean = value; _id = id;
                var initialMaxTotalPayment = _initialMaxTotalPayment; initialMaxTotalPayment.Clean = value; _initialMaxTotalPayment = initialMaxTotalPayment;
                var initialRateHousingRatio = _initialRateHousingRatio; initialRateHousingRatio.Clean = value; _initialRateHousingRatio = initialRateHousingRatio;
                var initialRateMonthlyPayment = _initialRateMonthlyPayment; initialRateMonthlyPayment.Clean = value; _initialRateMonthlyPayment = initialRateMonthlyPayment;
                var initialRateTotalDebtRatio = _initialRateTotalDebtRatio; initialRateTotalDebtRatio.Clean = value; _initialRateTotalDebtRatio = initialRateTotalDebtRatio;
                var interestOnlyMonths = _interestOnlyMonths; interestOnlyMonths.Clean = value; _interestOnlyMonths = interestOnlyMonths;
                var interestOnlyRecastDate = _interestOnlyRecastDate; interestOnlyRecastDate.Clean = value; _interestOnlyRecastDate = interestOnlyRecastDate;
                var isConsumerLiklyDefault = _isConsumerLiklyDefault; isConsumerLiklyDefault.Clean = value; _isConsumerLiklyDefault = isConsumerLiklyDefault;
                var isEligibleForSafeHarbor = _isEligibleForSafeHarbor; isEligibleForSafeHarbor.Clean = value; _isEligibleForSafeHarbor = isEligibleForSafeHarbor;
                var isEvaluatedAlimonyObligations = _isEvaluatedAlimonyObligations; isEvaluatedAlimonyObligations.Clean = value; _isEvaluatedAlimonyObligations = isEvaluatedAlimonyObligations;
                var isEvaluatedChildSupportObligations = _isEvaluatedChildSupportObligations; isEvaluatedChildSupportObligations.Clean = value; _isEvaluatedChildSupportObligations = isEvaluatedChildSupportObligations;
                var isEvaluatedCreditHistory = _isEvaluatedCreditHistory; isEvaluatedCreditHistory.Clean = value; _isEvaluatedCreditHistory = isEvaluatedCreditHistory;
                var isEvaluatedCurrentEmploymentStatus = _isEvaluatedCurrentEmploymentStatus; isEvaluatedCurrentEmploymentStatus.Clean = value; _isEvaluatedCurrentEmploymentStatus = isEvaluatedCurrentEmploymentStatus;
                var isEvaluatedCurrentExpectedAssets = _isEvaluatedCurrentExpectedAssets; isEvaluatedCurrentExpectedAssets.Clean = value; _isEvaluatedCurrentExpectedAssets = isEvaluatedCurrentExpectedAssets;
                var isEvaluatedCurrentExpectedIncome = _isEvaluatedCurrentExpectedIncome; isEvaluatedCurrentExpectedIncome.Clean = value; _isEvaluatedCurrentExpectedIncome = isEvaluatedCurrentExpectedIncome;
                var isEvaluatedDebtObligations = _isEvaluatedDebtObligations; isEvaluatedDebtObligations.Clean = value; _isEvaluatedDebtObligations = isEvaluatedDebtObligations;
                var isEvaluatedDebtToIncomeRatio = _isEvaluatedDebtToIncomeRatio; isEvaluatedDebtToIncomeRatio.Clean = value; _isEvaluatedDebtToIncomeRatio = isEvaluatedDebtToIncomeRatio;
                var isEvaluatedMonthlyCoveredLoanPayment = _isEvaluatedMonthlyCoveredLoanPayment; isEvaluatedMonthlyCoveredLoanPayment.Clean = value; _isEvaluatedMonthlyCoveredLoanPayment = isEvaluatedMonthlyCoveredLoanPayment;
                var isEvaluatedMonthlyMortgageRelatedObligations = _isEvaluatedMonthlyMortgageRelatedObligations; isEvaluatedMonthlyMortgageRelatedObligations.Clean = value; _isEvaluatedMonthlyMortgageRelatedObligations = isEvaluatedMonthlyMortgageRelatedObligations;
                var isEvaluatedMonthlySimultaneousLoanPayment = _isEvaluatedMonthlySimultaneousLoanPayment; isEvaluatedMonthlySimultaneousLoanPayment.Clean = value; _isEvaluatedMonthlySimultaneousLoanPayment = isEvaluatedMonthlySimultaneousLoanPayment;
                var isEvaluatedResidualIncome = _isEvaluatedResidualIncome; isEvaluatedResidualIncome.Clean = value; _isEvaluatedResidualIncome = isEvaluatedResidualIncome;
                var isHigherPricedLoan = _isHigherPricedLoan; isHigherPricedLoan.Clean = value; _isHigherPricedLoan = isHigherPricedLoan;
                var loanProcessingInformationD4 = _loanProcessingInformationD4; loanProcessingInformationD4.Clean = value; _loanProcessingInformationD4 = loanProcessingInformationD4;
                var loanProcessingInformationGO = _loanProcessingInformationGO; loanProcessingInformationGO.Clean = value; _loanProcessingInformationGO = loanProcessingInformationGO;
                var loanProcessingInformationHA = _loanProcessingInformationHA; loanProcessingInformationHA.Clean = value; _loanProcessingInformationHA = loanProcessingInformationHA;
                var loanProcessingInformationLE = _loanProcessingInformationLE; loanProcessingInformationLE.Clean = value; _loanProcessingInformationLE = loanProcessingInformationLE;
                var loanProcessingInformationLF = _loanProcessingInformationLF; loanProcessingInformationLF.Clean = value; _loanProcessingInformationLF = loanProcessingInformationLF;
                var loanProcessingInformationMA = _loanProcessingInformationMA; loanProcessingInformationMA.Clean = value; _loanProcessingInformationMA = loanProcessingInformationMA;
                var loanProgram = _loanProgram; loanProgram.Clean = value; _loanProgram = loanProgram;
                var loanProgramDescription = _loanProgramDescription; loanProgramDescription.Clean = value; _loanProgramDescription = loanProgramDescription;
                var loanRateFixedin5Years = _loanRateFixedin5Years; loanRateFixedin5Years.Clean = value; _loanRateFixedin5Years = loanRateFixedin5Years;
                var lOBrokerCompensationAmount = _lOBrokerCompensationAmount; lOBrokerCompensationAmount.Clean = value; _lOBrokerCompensationAmount = lOBrokerCompensationAmount;
                var max5YrsHousingRatio = _max5YrsHousingRatio; max5YrsHousingRatio.Clean = value; _max5YrsHousingRatio = max5YrsHousingRatio;
                var max5YrsPrincipleAndInterest = _max5YrsPrincipleAndInterest; max5YrsPrincipleAndInterest.Clean = value; _max5YrsPrincipleAndInterest = max5YrsPrincipleAndInterest;
                var max5YrsTotalDebtRatio = _max5YrsTotalDebtRatio; max5YrsTotalDebtRatio.Clean = value; _max5YrsTotalDebtRatio = max5YrsTotalDebtRatio;
                var max5YrsTotalPayment = _max5YrsTotalPayment; max5YrsTotalPayment.Clean = value; _max5YrsTotalPayment = max5YrsTotalPayment;
                var maxPrepaymentPenaltyFees = _maxPrepaymentPenaltyFees; maxPrepaymentPenaltyFees.Clean = value; _maxPrepaymentPenaltyFees = maxPrepaymentPenaltyFees;
                var negAmRecastDate = _negAmRecastDate; negAmRecastDate.Clean = value; _negAmRecastDate = negAmRecastDate;
                var paymentDecreasedBy10Percent = _paymentDecreasedBy10Percent; paymentDecreasedBy10Percent.Clean = value; _paymentDecreasedBy10Percent = paymentDecreasedBy10Percent;
                var pointsFeesThresholdMet = _pointsFeesThresholdMet; pointsFeesThresholdMet.Clean = value; _pointsFeesThresholdMet = pointsFeesThresholdMet;
                var prepaymentPenaltyPayoffFees = _prepaymentPenaltyPayoffFees; prepaymentPenaltyPayoffFees.Clean = value; _prepaymentPenaltyPayoffFees = prepaymentPenaltyPayoffFees;
                var prepayPenaltyPercentage = _prepayPenaltyPercentage; prepayPenaltyPercentage.Clean = value; _prepayPenaltyPercentage = prepayPenaltyPercentage;
                var preventConsumersDefault = _preventConsumersDefault; preventConsumersDefault.Clean = value; _preventConsumersDefault = preventConsumersDefault;
                var principalBalanceIncreased = _principalBalanceIncreased; principalBalanceIncreased.Clean = value; _principalBalanceIncreased = principalBalanceIncreased;
                var principalHasDeferred = _principalHasDeferred; principalHasDeferred.Clean = value; _principalHasDeferred = principalHasDeferred;
                var qMLoanType = _qMLoanType; qMLoanType.Clean = value; _qMLoanType = qMLoanType;
                var rateReductionBasisPoints = _rateReductionBasisPoints; rateReductionBasisPoints.Clean = value; _rateReductionBasisPoints = rateReductionBasisPoints;
                var rateReductionDiscountPoints = _rateReductionDiscountPoints; rateReductionDiscountPoints.Clean = value; _rateReductionDiscountPoints = rateReductionDiscountPoints;
                var rateReductionMaxBonaFideDiscountPoint = _rateReductionMaxBonaFideDiscountPoint; rateReductionMaxBonaFideDiscountPoint.Clean = value; _rateReductionMaxBonaFideDiscountPoint = rateReductionMaxBonaFideDiscountPoint;
                var realEstateFees = _realEstateFees; realEstateFees.Clean = value; _realEstateFees = realEstateFees;
                var recastDifferencePayment = _recastDifferencePayment; recastDifferencePayment.Clean = value; _recastDifferencePayment = recastDifferencePayment;
                var regZTotalLoanAmount = _regZTotalLoanAmount; regZTotalLoanAmount.Clean = value; _regZTotalLoanAmount = regZTotalLoanAmount;
                var requiredServicesLenderSelectedAmt = _requiredServicesLenderSelectedAmt; requiredServicesLenderSelectedAmt.Clean = value; _requiredServicesLenderSelectedAmt = requiredServicesLenderSelectedAmt;
                var smallCreditorQM_CalculatedThreshold = _smallCreditorQM_CalculatedThreshold; smallCreditorQM_CalculatedThreshold.Clean = value; _smallCreditorQM_CalculatedThreshold = smallCreditorQM_CalculatedThreshold;
                var smallCreditorQM_Status_Alimony = _smallCreditorQM_Status_Alimony; smallCreditorQM_Status_Alimony.Clean = value; _smallCreditorQM_Status_Alimony = smallCreditorQM_Status_Alimony;
                var smallCreditorQM_Status_Assets = _smallCreditorQM_Status_Assets; smallCreditorQM_Status_Assets.Clean = value; _smallCreditorQM_Status_Assets = smallCreditorQM_Status_Assets;
                var smallCreditorQM_Status_BalloonPayment = _smallCreditorQM_Status_BalloonPayment; smallCreditorQM_Status_BalloonPayment.Clean = value; _smallCreditorQM_Status_BalloonPayment = smallCreditorQM_Status_BalloonPayment;
                var smallCreditorQM_Status_ChildSupport = _smallCreditorQM_Status_ChildSupport; smallCreditorQM_Status_ChildSupport.Clean = value; _smallCreditorQM_Status_ChildSupport = smallCreditorQM_Status_ChildSupport;
                var smallCreditorQM_Status_CoveredLoan = _smallCreditorQM_Status_CoveredLoan; smallCreditorQM_Status_CoveredLoan.Clean = value; _smallCreditorQM_Status_CoveredLoan = smallCreditorQM_Status_CoveredLoan;
                var smallCreditorQM_Status_DebtObligations = _smallCreditorQM_Status_DebtObligations; smallCreditorQM_Status_DebtObligations.Clean = value; _smallCreditorQM_Status_DebtObligations = smallCreditorQM_Status_DebtObligations;
                var smallCreditorQM_Status_DTI = _smallCreditorQM_Status_DTI; smallCreditorQM_Status_DTI.Clean = value; _smallCreditorQM_Status_DTI = smallCreditorQM_Status_DTI;
                var smallCreditorQM_Status_Income = _smallCreditorQM_Status_Income; smallCreditorQM_Status_Income.Clean = value; _smallCreditorQM_Status_Income = smallCreditorQM_Status_Income;
                var smallCreditorQM_Status_InterestOnly = _smallCreditorQM_Status_InterestOnly; smallCreditorQM_Status_InterestOnly.Clean = value; _smallCreditorQM_Status_InterestOnly = smallCreditorQM_Status_InterestOnly;
                var smallCreditorQM_Status_LoanTerm = _smallCreditorQM_Status_LoanTerm; smallCreditorQM_Status_LoanTerm.Clean = value; _smallCreditorQM_Status_LoanTerm = smallCreditorQM_Status_LoanTerm;
                var smallCreditorQM_Status_MtgRelatedObligations = _smallCreditorQM_Status_MtgRelatedObligations; smallCreditorQM_Status_MtgRelatedObligations.Clean = value; _smallCreditorQM_Status_MtgRelatedObligations = smallCreditorQM_Status_MtgRelatedObligations;
                var smallCreditorQM_Status_NegativeAmortization = _smallCreditorQM_Status_NegativeAmortization; smallCreditorQM_Status_NegativeAmortization.Clean = value; _smallCreditorQM_Status_NegativeAmortization = smallCreditorQM_Status_NegativeAmortization;
                var smallCreditorQM_Status_Overall = _smallCreditorQM_Status_Overall; smallCreditorQM_Status_Overall.Clean = value; _smallCreditorQM_Status_Overall = smallCreditorQM_Status_Overall;
                var smallCreditorQM_Status_PointsFeesLimit = _smallCreditorQM_Status_PointsFeesLimit; smallCreditorQM_Status_PointsFeesLimit.Clean = value; _smallCreditorQM_Status_PointsFeesLimit = smallCreditorQM_Status_PointsFeesLimit;
                var smallCreditorQM_Status_PrepaymentPenalty = _smallCreditorQM_Status_PrepaymentPenalty; smallCreditorQM_Status_PrepaymentPenalty.Clean = value; _smallCreditorQM_Status_PrepaymentPenalty = smallCreditorQM_Status_PrepaymentPenalty;
                var smallCreditorQM_Status_ResidualIncome = _smallCreditorQM_Status_ResidualIncome; smallCreditorQM_Status_ResidualIncome.Clean = value; _smallCreditorQM_Status_ResidualIncome = smallCreditorQM_Status_ResidualIncome;
                var smallCreditorQM_Status_SafeHarborEligibility = _smallCreditorQM_Status_SafeHarborEligibility; smallCreditorQM_Status_SafeHarborEligibility.Clean = value; _smallCreditorQM_Status_SafeHarborEligibility = smallCreditorQM_Status_SafeHarborEligibility;
                var standardQM_CalculatedThreshold = _standardQM_CalculatedThreshold; standardQM_CalculatedThreshold.Clean = value; _standardQM_CalculatedThreshold = standardQM_CalculatedThreshold;
                var standardQM_Status_Alimony = _standardQM_Status_Alimony; standardQM_Status_Alimony.Clean = value; _standardQM_Status_Alimony = standardQM_Status_Alimony;
                var standardQM_Status_Assets = _standardQM_Status_Assets; standardQM_Status_Assets.Clean = value; _standardQM_Status_Assets = standardQM_Status_Assets;
                var standardQM_Status_BalloonPayment = _standardQM_Status_BalloonPayment; standardQM_Status_BalloonPayment.Clean = value; _standardQM_Status_BalloonPayment = standardQM_Status_BalloonPayment;
                var standardQM_Status_ChildSupport = _standardQM_Status_ChildSupport; standardQM_Status_ChildSupport.Clean = value; _standardQM_Status_ChildSupport = standardQM_Status_ChildSupport;
                var standardQM_Status_CoveredLoan = _standardQM_Status_CoveredLoan; standardQM_Status_CoveredLoan.Clean = value; _standardQM_Status_CoveredLoan = standardQM_Status_CoveredLoan;
                var standardQM_Status_CreditHistory = _standardQM_Status_CreditHistory; standardQM_Status_CreditHistory.Clean = value; _standardQM_Status_CreditHistory = standardQM_Status_CreditHistory;
                var standardQM_Status_DebtObligations = _standardQM_Status_DebtObligations; standardQM_Status_DebtObligations.Clean = value; _standardQM_Status_DebtObligations = standardQM_Status_DebtObligations;
                var standardQM_Status_DTI = _standardQM_Status_DTI; standardQM_Status_DTI.Clean = value; _standardQM_Status_DTI = standardQM_Status_DTI;
                var standardQM_Status_Employment = _standardQM_Status_Employment; standardQM_Status_Employment.Clean = value; _standardQM_Status_Employment = standardQM_Status_Employment;
                var standardQM_Status_Income = _standardQM_Status_Income; standardQM_Status_Income.Clean = value; _standardQM_Status_Income = standardQM_Status_Income;
                var standardQM_Status_InterestOnly = _standardQM_Status_InterestOnly; standardQM_Status_InterestOnly.Clean = value; _standardQM_Status_InterestOnly = standardQM_Status_InterestOnly;
                var standardQM_Status_LoanTerm = _standardQM_Status_LoanTerm; standardQM_Status_LoanTerm.Clean = value; _standardQM_Status_LoanTerm = standardQM_Status_LoanTerm;
                var standardQM_Status_MtgRelatedObligations = _standardQM_Status_MtgRelatedObligations; standardQM_Status_MtgRelatedObligations.Clean = value; _standardQM_Status_MtgRelatedObligations = standardQM_Status_MtgRelatedObligations;
                var standardQM_Status_NegativeAmortization = _standardQM_Status_NegativeAmortization; standardQM_Status_NegativeAmortization.Clean = value; _standardQM_Status_NegativeAmortization = standardQM_Status_NegativeAmortization;
                var standardQM_Status_Overall = _standardQM_Status_Overall; standardQM_Status_Overall.Clean = value; _standardQM_Status_Overall = standardQM_Status_Overall;
                var standardQM_Status_PointsFeesLimit = _standardQM_Status_PointsFeesLimit; standardQM_Status_PointsFeesLimit.Clean = value; _standardQM_Status_PointsFeesLimit = standardQM_Status_PointsFeesLimit;
                var standardQM_Status_PrepaymentPenalty = _standardQM_Status_PrepaymentPenalty; standardQM_Status_PrepaymentPenalty.Clean = value; _standardQM_Status_PrepaymentPenalty = standardQM_Status_PrepaymentPenalty;
                var standardQM_Status_ResidualIncome = _standardQM_Status_ResidualIncome; standardQM_Status_ResidualIncome.Clean = value; _standardQM_Status_ResidualIncome = standardQM_Status_ResidualIncome;
                var standardQM_Status_SafeHarborEligibility = _standardQM_Status_SafeHarborEligibility; standardQM_Status_SafeHarborEligibility.Clean = value; _standardQM_Status_SafeHarborEligibility = standardQM_Status_SafeHarborEligibility;
                var standardQM_Status_SimultaneousLoan = _standardQM_Status_SimultaneousLoan; standardQM_Status_SimultaneousLoan.Clean = value; _standardQM_Status_SimultaneousLoan = standardQM_Status_SimultaneousLoan;
                var startingAdjustedRateMaxBonaFideDiscountPoint = _startingAdjustedRateMaxBonaFideDiscountPoint; startingAdjustedRateMaxBonaFideDiscountPoint.Clean = value; _startingAdjustedRateMaxBonaFideDiscountPoint = startingAdjustedRateMaxBonaFideDiscountPoint;
                var status_CreditHistory = _status_CreditHistory; status_CreditHistory.Clean = value; _status_CreditHistory = status_CreditHistory;
                var status_SimultaneousLoan = _status_SimultaneousLoan; status_SimultaneousLoan.Clean = value; _status_SimultaneousLoan = status_SimultaneousLoan;
                var thresholdExceedsQM = _thresholdExceedsQM; thresholdExceedsQM.Clean = value; _thresholdExceedsQM = thresholdExceedsQM;
                var titleServicesLenderTitleinsuranceFee = _titleServicesLenderTitleinsuranceFee; titleServicesLenderTitleinsuranceFee.Clean = value; _titleServicesLenderTitleinsuranceFee = titleServicesLenderTitleinsuranceFee;
                var totalCoMortgagorIncome = _totalCoMortgagorIncome; totalCoMortgagorIncome.Clean = value; _totalCoMortgagorIncome = totalCoMortgagorIncome;
                var totalIncome = _totalIncome; totalIncome.Clean = value; _totalIncome = totalIncome;
                var totalPointsFeesSec32Percent = _totalPointsFeesSec32Percent; totalPointsFeesSec32Percent.Clean = value; _totalPointsFeesSec32Percent = totalPointsFeesSec32Percent;
                var transactionExemptFromRegZ = _transactionExemptFromRegZ; transactionExemptFromRegZ.Clean = value; _transactionExemptFromRegZ = transactionExemptFromRegZ;
                var unitCount = _unitCount; unitCount.Clean = value; _unitCount = unitCount;
                var upfrontPMIFees = _upfrontPMIFees; upfrontPMIFees.Clean = value; _upfrontPMIFees = upfrontPMIFees;
                var withOriginalCreditor = _withOriginalCreditor; withOriginalCreditor.Clean = value; _withOriginalCreditor = withOriginalCreditor;
                var writtenApplicationDate = _writtenApplicationDate; writtenApplicationDate.Clean = value; _writtenApplicationDate = writtenApplicationDate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ATRQMCommon()
        {
            Clean = true;
        }
    }
}