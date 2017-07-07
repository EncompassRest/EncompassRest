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
                var v0 = _affiliatesFees; v0.Clean = value; _affiliatesFees = v0;
                var v1 = _aPORMaxBonaFideDiscountPoint; v1.Clean = value; _aPORMaxBonaFideDiscountPoint = v1;
                var v2 = _aRMRecastDate; v2.Clean = value; _aRMRecastDate = v2;
                var v3 = _aRMRecastMonthlyPayment; v3.Clean = value; _aRMRecastMonthlyPayment = v3;
                var v4 = _aTRLoanType; v4.Clean = value; _aTRLoanType = v4;
                var v5 = _aUSDataDiscrepencyResolutionComments; v5.Clean = value; _aUSDataDiscrepencyResolutionComments = v5;
                var v6 = _aUSDataDiscrepencyResolutionDate; v6.Clean = value; _aUSDataDiscrepencyResolutionDate = v6;
                var v7 = _aUSDataDiscrepencyResolvedBy; v7.Clean = value; _aUSDataDiscrepencyResolvedBy = v7;
                var v8 = _bonaFideDiscountPoint; v8.Clean = value; _bonaFideDiscountPoint = v8;
                var v9 = _bonaFideDiscountPointAmount; v9.Clean = value; _bonaFideDiscountPointAmount = v9;
                var v10 = _brokerCompensationWhenRateSet; v10.Clean = value; _brokerCompensationWhenRateSet = v10;
                var v11 = _collateralRepandWarrReliefEligibilityType; v11.Clean = value; _collateralRepandWarrReliefEligibilityType = v11;
                var v12 = _compensationPTBFees; v12.Clean = value; _compensationPTBFees = v12;
                var v13 = _creditInsPremiumFees; v13.Clean = value; _creditInsPremiumFees = v13;
                var v14 = _creditorType; v14.Clean = value; _creditorType = v14;
                var v15 = _creditorTypeDescription; v15.Clean = value; _creditorTypeDescription = v15;
                var v16 = _creditType; v16.Clean = value; _creditType = v16;
                var v17 = _currentQMFeeThresholdAmt; v17.Clean = value; _currentQMFeeThresholdAmt = v17;
                var v18 = _currentQMFeeThresholdPercent; v18.Clean = value; _currentQMFeeThresholdPercent = v18;
                var v19 = _dateOfLastMonthlyPayment; v19.Clean = value; _dateOfLastMonthlyPayment = v19;
                var v20 = _discountPointAmount; v20.Clean = value; _discountPointAmount = v20;
                var v21 = _discountPointFees; v21.Clean = value; _discountPointFees = v21;
                var v22 = _discountPointPercentage; v22.Clean = value; _discountPointPercentage = v22;
                var v23 = _documentationGuidelineMessages4V; v23.Clean = value; _documentationGuidelineMessages4V = v23;
                var v24 = _documentationGuidelineMessages5C; v24.Clean = value; _documentationGuidelineMessages5C = v24;
                var v25 = _documentationGuidelineMessages8Y; v25.Clean = value; _documentationGuidelineMessages8Y = v25;
                var v26 = _documentationGuidelineMessagesCN; v26.Clean = value; _documentationGuidelineMessagesCN = v26;
                var v27 = _documentationGuidelineMessagesCP; v27.Clean = value; _documentationGuidelineMessagesCP = v27;
                var v28 = _documentationGuidelineMessagesCV; v28.Clean = value; _documentationGuidelineMessagesCV = v28;
                var v29 = _documentationGuidelineMessagesCY; v29.Clean = value; _documentationGuidelineMessagesCY = v29;
                var v30 = _documentationGuidelineMessagesCZ; v30.Clean = value; _documentationGuidelineMessagesCZ = v30;
                var v31 = _documentationGuidelineMessagesDP; v31.Clean = value; _documentationGuidelineMessagesDP = v31;
                var v32 = _documentationGuidelineMessagesDZ; v32.Clean = value; _documentationGuidelineMessagesDZ = v32;
                var v33 = _documentationGuidelineMessagesE5; v33.Clean = value; _documentationGuidelineMessagesE5 = v33;
                var v34 = _documentationGuidelineMessagesIM; v34.Clean = value; _documentationGuidelineMessagesIM = v34;
                var v35 = _documentationGuidelineMessagesIQ; v35.Clean = value; _documentationGuidelineMessagesIQ = v35;
                var v36 = _documentationGuidelineMessagesJF; v36.Clean = value; _documentationGuidelineMessagesJF = v36;
                var v37 = _documentationGuidelineMessagesQJ; v37.Clean = value; _documentationGuidelineMessagesQJ = v37;
                var v38 = _documentationGuidelineMessagesQN; v38.Clean = value; _documentationGuidelineMessagesQN = v38;
                var v39 = _documentationGuidelineMessagesQQ; v39.Clean = value; _documentationGuidelineMessagesQQ = v39;
                var v40 = _documentationGuidelineMessagesQS; v40.Clean = value; _documentationGuidelineMessagesQS = v40;
                var v41 = _documentationGuidelineMessagesU7; v41.Clean = value; _documentationGuidelineMessagesU7 = v41;
                var v42 = _documentationGuidelineMessagesX1; v42.Clean = value; _documentationGuidelineMessagesX1 = v42;
                var v43 = _documentationGuidelineMessagesX3; v43.Clean = value; _documentationGuidelineMessagesX3 = v43;
                var v44 = _documentationGuidelineMessagesX5; v44.Clean = value; _documentationGuidelineMessagesX5 = v44;
                var v45 = _documentationGuidelineMessagesX7; v45.Clean = value; _documentationGuidelineMessagesX7 = v45;
                var v46 = _documentationGuidelineMessagesXA; v46.Clean = value; _documentationGuidelineMessagesXA = v46;
                var v47 = _documentationGuidelineMessagesXM; v47.Clean = value; _documentationGuidelineMessagesXM = v47;
                var v48 = _documentationGuidelineMessagesXP; v48.Clean = value; _documentationGuidelineMessagesXP = v48;
                var v49 = _documentationGuidelineMessagesXR; v49.Clean = value; _documentationGuidelineMessagesXR = v49;
                var v50 = _documentationGuidelineMessagesXT; v50.Clean = value; _documentationGuidelineMessagesXT = v50;
                var v51 = _documentationGuidelineMessagesY8; v51.Clean = value; _documentationGuidelineMessagesY8 = v51;
                var v52 = _documentationGuidelineMessagesYG; v52.Clean = value; _documentationGuidelineMessagesYG = v52;
                var v53 = _documentationGuidelineMessagesYJ; v53.Clean = value; _documentationGuidelineMessagesYJ = v53;
                var v54 = _documentationGuidelineMessagesYY; v54.Clean = value; _documentationGuidelineMessagesYY = v54;
                var v55 = _documentationGuidelineMessagesYZ; v55.Clean = value; _documentationGuidelineMessagesYZ = v55;
                var v56 = _eligibleNonStandardToStandard; v56.Clean = value; _eligibleNonStandardToStandard = v56;
                var v57 = _financeChargeFees; v57.Clean = value; _financeChargeFees = v57;
                var v58 = _firstChangeRecase; v58.Clean = value; _firstChangeRecase = v58;
                var v59 = _firstPmtDateAfterRecast; v59.Clean = value; _firstPmtDateAfterRecast = v59;
                var v60 = _fullPaymentAfterInterestOnly; v60.Clean = value; _fullPaymentAfterInterestOnly = v60;
                var v61 = _fullyARMPaymentAfterNegAm; v61.Clean = value; _fullyARMPaymentAfterNegAm = v61;
                var v62 = _fullyIndexRateHousingRatio; v62.Clean = value; _fullyIndexRateHousingRatio = v62;
                var v63 = _fullyIndexRateMaxTotalPayment; v63.Clean = value; _fullyIndexRateMaxTotalPayment = v63;
                var v64 = _fullyIndexRateMonthlyPayment; v64.Clean = value; _fullyIndexRateMonthlyPayment = v64;
                var v65 = _fullyIndexRateTotalDebtRatio; v65.Clean = value; _fullyIndexRateTotalDebtRatio = v65;
                var v66 = _generalATR_Status_Alimony; v66.Clean = value; _generalATR_Status_Alimony = v66;
                var v67 = _generalATR_Status_Assets; v67.Clean = value; _generalATR_Status_Assets = v67;
                var v68 = _generalATR_Status_ChildSupport; v68.Clean = value; _generalATR_Status_ChildSupport = v68;
                var v69 = _generalATR_Status_CoveredLoan; v69.Clean = value; _generalATR_Status_CoveredLoan = v69;
                var v70 = _generalATR_Status_CreditHistory; v70.Clean = value; _generalATR_Status_CreditHistory = v70;
                var v71 = _generalATR_Status_DebtObligations; v71.Clean = value; _generalATR_Status_DebtObligations = v71;
                var v72 = _generalATR_Status_DTI; v72.Clean = value; _generalATR_Status_DTI = v72;
                var v73 = _generalATR_Status_Employment; v73.Clean = value; _generalATR_Status_Employment = v73;
                var v74 = _generalATR_Status_Income; v74.Clean = value; _generalATR_Status_Income = v74;
                var v75 = _generalATR_Status_MtgRelatedObligations; v75.Clean = value; _generalATR_Status_MtgRelatedObligations = v75;
                var v76 = _generalATR_Status_Overall; v76.Clean = value; _generalATR_Status_Overall = v76;
                var v77 = _generalATR_Status_ResidualIncome; v77.Clean = value; _generalATR_Status_ResidualIncome = v77;
                var v78 = _generalATR_Status_SimultaneousLoan; v78.Clean = value; _generalATR_Status_SimultaneousLoan = v78;
                var v79 = _gSEAgencyQM_CalculatedThreshold; v79.Clean = value; _gSEAgencyQM_CalculatedThreshold = v79;
                var v80 = _gSEAgencyQM_Status_Alimony; v80.Clean = value; _gSEAgencyQM_Status_Alimony = v80;
                var v81 = _gSEAgencyQM_Status_Assets; v81.Clean = value; _gSEAgencyQM_Status_Assets = v81;
                var v82 = _gSEAgencyQM_Status_BalloonPayment; v82.Clean = value; _gSEAgencyQM_Status_BalloonPayment = v82;
                var v83 = _gSEAgencyQM_Status_ChildSupport; v83.Clean = value; _gSEAgencyQM_Status_ChildSupport = v83;
                var v84 = _gSEAgencyQM_Status_CoveredLoan; v84.Clean = value; _gSEAgencyQM_Status_CoveredLoan = v84;
                var v85 = _gSEAgencyQM_Status_CreditHistory; v85.Clean = value; _gSEAgencyQM_Status_CreditHistory = v85;
                var v86 = _gSEAgencyQM_Status_DebtObligations; v86.Clean = value; _gSEAgencyQM_Status_DebtObligations = v86;
                var v87 = _gSEAgencyQM_Status_DTI; v87.Clean = value; _gSEAgencyQM_Status_DTI = v87;
                var v88 = _gSEAgencyQM_Status_Employment; v88.Clean = value; _gSEAgencyQM_Status_Employment = v88;
                var v89 = _gSEAgencyQM_Status_Income; v89.Clean = value; _gSEAgencyQM_Status_Income = v89;
                var v90 = _gSEAgencyQM_Status_InterestOnly; v90.Clean = value; _gSEAgencyQM_Status_InterestOnly = v90;
                var v91 = _gSEAgencyQM_Status_LoanTerm; v91.Clean = value; _gSEAgencyQM_Status_LoanTerm = v91;
                var v92 = _gSEAgencyQM_Status_MtgRelatedObligations; v92.Clean = value; _gSEAgencyQM_Status_MtgRelatedObligations = v92;
                var v93 = _gSEAgencyQM_Status_NegativeAmortization; v93.Clean = value; _gSEAgencyQM_Status_NegativeAmortization = v93;
                var v94 = _gSEAgencyQM_Status_Overall; v94.Clean = value; _gSEAgencyQM_Status_Overall = v94;
                var v95 = _gSEAgencyQM_Status_PointsFeesLimit; v95.Clean = value; _gSEAgencyQM_Status_PointsFeesLimit = v95;
                var v96 = _gSEAgencyQM_Status_PrepaymentPenalty; v96.Clean = value; _gSEAgencyQM_Status_PrepaymentPenalty = v96;
                var v97 = _gSEAgencyQM_Status_ResidualIncome; v97.Clean = value; _gSEAgencyQM_Status_ResidualIncome = v97;
                var v98 = _gSEAgencyQM_Status_SafeHarborEligibility; v98.Clean = value; _gSEAgencyQM_Status_SafeHarborEligibility = v98;
                var v99 = _gSEAgencyQM_Status_SimultaneousLoan; v99.Clean = value; _gSEAgencyQM_Status_SimultaneousLoan = v99;
                var v100 = _has30DayLatePayment; v100.Clean = value; _has30DayLatePayment = v100;
                var v101 = _id; v101.Clean = value; _id = v101;
                var v102 = _initialMaxTotalPayment; v102.Clean = value; _initialMaxTotalPayment = v102;
                var v103 = _initialRateHousingRatio; v103.Clean = value; _initialRateHousingRatio = v103;
                var v104 = _initialRateMonthlyPayment; v104.Clean = value; _initialRateMonthlyPayment = v104;
                var v105 = _initialRateTotalDebtRatio; v105.Clean = value; _initialRateTotalDebtRatio = v105;
                var v106 = _interestOnlyMonths; v106.Clean = value; _interestOnlyMonths = v106;
                var v107 = _interestOnlyRecastDate; v107.Clean = value; _interestOnlyRecastDate = v107;
                var v108 = _isConsumerLiklyDefault; v108.Clean = value; _isConsumerLiklyDefault = v108;
                var v109 = _isEligibleForSafeHarbor; v109.Clean = value; _isEligibleForSafeHarbor = v109;
                var v110 = _isEvaluatedAlimonyObligations; v110.Clean = value; _isEvaluatedAlimonyObligations = v110;
                var v111 = _isEvaluatedChildSupportObligations; v111.Clean = value; _isEvaluatedChildSupportObligations = v111;
                var v112 = _isEvaluatedCreditHistory; v112.Clean = value; _isEvaluatedCreditHistory = v112;
                var v113 = _isEvaluatedCurrentEmploymentStatus; v113.Clean = value; _isEvaluatedCurrentEmploymentStatus = v113;
                var v114 = _isEvaluatedCurrentExpectedAssets; v114.Clean = value; _isEvaluatedCurrentExpectedAssets = v114;
                var v115 = _isEvaluatedCurrentExpectedIncome; v115.Clean = value; _isEvaluatedCurrentExpectedIncome = v115;
                var v116 = _isEvaluatedDebtObligations; v116.Clean = value; _isEvaluatedDebtObligations = v116;
                var v117 = _isEvaluatedDebtToIncomeRatio; v117.Clean = value; _isEvaluatedDebtToIncomeRatio = v117;
                var v118 = _isEvaluatedMonthlyCoveredLoanPayment; v118.Clean = value; _isEvaluatedMonthlyCoveredLoanPayment = v118;
                var v119 = _isEvaluatedMonthlyMortgageRelatedObligations; v119.Clean = value; _isEvaluatedMonthlyMortgageRelatedObligations = v119;
                var v120 = _isEvaluatedMonthlySimultaneousLoanPayment; v120.Clean = value; _isEvaluatedMonthlySimultaneousLoanPayment = v120;
                var v121 = _isEvaluatedResidualIncome; v121.Clean = value; _isEvaluatedResidualIncome = v121;
                var v122 = _isHigherPricedLoan; v122.Clean = value; _isHigherPricedLoan = v122;
                var v123 = _loanProcessingInformationD4; v123.Clean = value; _loanProcessingInformationD4 = v123;
                var v124 = _loanProcessingInformationGO; v124.Clean = value; _loanProcessingInformationGO = v124;
                var v125 = _loanProcessingInformationHA; v125.Clean = value; _loanProcessingInformationHA = v125;
                var v126 = _loanProcessingInformationLE; v126.Clean = value; _loanProcessingInformationLE = v126;
                var v127 = _loanProcessingInformationLF; v127.Clean = value; _loanProcessingInformationLF = v127;
                var v128 = _loanProcessingInformationMA; v128.Clean = value; _loanProcessingInformationMA = v128;
                var v129 = _loanProgram; v129.Clean = value; _loanProgram = v129;
                var v130 = _loanProgramDescription; v130.Clean = value; _loanProgramDescription = v130;
                var v131 = _loanRateFixedin5Years; v131.Clean = value; _loanRateFixedin5Years = v131;
                var v132 = _lOBrokerCompensationAmount; v132.Clean = value; _lOBrokerCompensationAmount = v132;
                var v133 = _max5YrsHousingRatio; v133.Clean = value; _max5YrsHousingRatio = v133;
                var v134 = _max5YrsPrincipleAndInterest; v134.Clean = value; _max5YrsPrincipleAndInterest = v134;
                var v135 = _max5YrsTotalDebtRatio; v135.Clean = value; _max5YrsTotalDebtRatio = v135;
                var v136 = _max5YrsTotalPayment; v136.Clean = value; _max5YrsTotalPayment = v136;
                var v137 = _maxPrepaymentPenaltyFees; v137.Clean = value; _maxPrepaymentPenaltyFees = v137;
                var v138 = _negAmRecastDate; v138.Clean = value; _negAmRecastDate = v138;
                var v139 = _paymentDecreasedBy10Percent; v139.Clean = value; _paymentDecreasedBy10Percent = v139;
                var v140 = _pointsFeesThresholdMet; v140.Clean = value; _pointsFeesThresholdMet = v140;
                var v141 = _prepaymentPenaltyPayoffFees; v141.Clean = value; _prepaymentPenaltyPayoffFees = v141;
                var v142 = _prepayPenaltyPercentage; v142.Clean = value; _prepayPenaltyPercentage = v142;
                var v143 = _preventConsumersDefault; v143.Clean = value; _preventConsumersDefault = v143;
                var v144 = _principalBalanceIncreased; v144.Clean = value; _principalBalanceIncreased = v144;
                var v145 = _principalHasDeferred; v145.Clean = value; _principalHasDeferred = v145;
                var v146 = _qMLoanType; v146.Clean = value; _qMLoanType = v146;
                var v147 = _rateReductionBasisPoints; v147.Clean = value; _rateReductionBasisPoints = v147;
                var v148 = _rateReductionDiscountPoints; v148.Clean = value; _rateReductionDiscountPoints = v148;
                var v149 = _rateReductionMaxBonaFideDiscountPoint; v149.Clean = value; _rateReductionMaxBonaFideDiscountPoint = v149;
                var v150 = _realEstateFees; v150.Clean = value; _realEstateFees = v150;
                var v151 = _recastDifferencePayment; v151.Clean = value; _recastDifferencePayment = v151;
                var v152 = _regZTotalLoanAmount; v152.Clean = value; _regZTotalLoanAmount = v152;
                var v153 = _requiredServicesLenderSelectedAmt; v153.Clean = value; _requiredServicesLenderSelectedAmt = v153;
                var v154 = _smallCreditorQM_CalculatedThreshold; v154.Clean = value; _smallCreditorQM_CalculatedThreshold = v154;
                var v155 = _smallCreditorQM_Status_Alimony; v155.Clean = value; _smallCreditorQM_Status_Alimony = v155;
                var v156 = _smallCreditorQM_Status_Assets; v156.Clean = value; _smallCreditorQM_Status_Assets = v156;
                var v157 = _smallCreditorQM_Status_BalloonPayment; v157.Clean = value; _smallCreditorQM_Status_BalloonPayment = v157;
                var v158 = _smallCreditorQM_Status_ChildSupport; v158.Clean = value; _smallCreditorQM_Status_ChildSupport = v158;
                var v159 = _smallCreditorQM_Status_CoveredLoan; v159.Clean = value; _smallCreditorQM_Status_CoveredLoan = v159;
                var v160 = _smallCreditorQM_Status_DebtObligations; v160.Clean = value; _smallCreditorQM_Status_DebtObligations = v160;
                var v161 = _smallCreditorQM_Status_DTI; v161.Clean = value; _smallCreditorQM_Status_DTI = v161;
                var v162 = _smallCreditorQM_Status_Income; v162.Clean = value; _smallCreditorQM_Status_Income = v162;
                var v163 = _smallCreditorQM_Status_InterestOnly; v163.Clean = value; _smallCreditorQM_Status_InterestOnly = v163;
                var v164 = _smallCreditorQM_Status_LoanTerm; v164.Clean = value; _smallCreditorQM_Status_LoanTerm = v164;
                var v165 = _smallCreditorQM_Status_MtgRelatedObligations; v165.Clean = value; _smallCreditorQM_Status_MtgRelatedObligations = v165;
                var v166 = _smallCreditorQM_Status_NegativeAmortization; v166.Clean = value; _smallCreditorQM_Status_NegativeAmortization = v166;
                var v167 = _smallCreditorQM_Status_Overall; v167.Clean = value; _smallCreditorQM_Status_Overall = v167;
                var v168 = _smallCreditorQM_Status_PointsFeesLimit; v168.Clean = value; _smallCreditorQM_Status_PointsFeesLimit = v168;
                var v169 = _smallCreditorQM_Status_PrepaymentPenalty; v169.Clean = value; _smallCreditorQM_Status_PrepaymentPenalty = v169;
                var v170 = _smallCreditorQM_Status_ResidualIncome; v170.Clean = value; _smallCreditorQM_Status_ResidualIncome = v170;
                var v171 = _smallCreditorQM_Status_SafeHarborEligibility; v171.Clean = value; _smallCreditorQM_Status_SafeHarborEligibility = v171;
                var v172 = _standardQM_CalculatedThreshold; v172.Clean = value; _standardQM_CalculatedThreshold = v172;
                var v173 = _standardQM_Status_Alimony; v173.Clean = value; _standardQM_Status_Alimony = v173;
                var v174 = _standardQM_Status_Assets; v174.Clean = value; _standardQM_Status_Assets = v174;
                var v175 = _standardQM_Status_BalloonPayment; v175.Clean = value; _standardQM_Status_BalloonPayment = v175;
                var v176 = _standardQM_Status_ChildSupport; v176.Clean = value; _standardQM_Status_ChildSupport = v176;
                var v177 = _standardQM_Status_CoveredLoan; v177.Clean = value; _standardQM_Status_CoveredLoan = v177;
                var v178 = _standardQM_Status_CreditHistory; v178.Clean = value; _standardQM_Status_CreditHistory = v178;
                var v179 = _standardQM_Status_DebtObligations; v179.Clean = value; _standardQM_Status_DebtObligations = v179;
                var v180 = _standardQM_Status_DTI; v180.Clean = value; _standardQM_Status_DTI = v180;
                var v181 = _standardQM_Status_Employment; v181.Clean = value; _standardQM_Status_Employment = v181;
                var v182 = _standardQM_Status_Income; v182.Clean = value; _standardQM_Status_Income = v182;
                var v183 = _standardQM_Status_InterestOnly; v183.Clean = value; _standardQM_Status_InterestOnly = v183;
                var v184 = _standardQM_Status_LoanTerm; v184.Clean = value; _standardQM_Status_LoanTerm = v184;
                var v185 = _standardQM_Status_MtgRelatedObligations; v185.Clean = value; _standardQM_Status_MtgRelatedObligations = v185;
                var v186 = _standardQM_Status_NegativeAmortization; v186.Clean = value; _standardQM_Status_NegativeAmortization = v186;
                var v187 = _standardQM_Status_Overall; v187.Clean = value; _standardQM_Status_Overall = v187;
                var v188 = _standardQM_Status_PointsFeesLimit; v188.Clean = value; _standardQM_Status_PointsFeesLimit = v188;
                var v189 = _standardQM_Status_PrepaymentPenalty; v189.Clean = value; _standardQM_Status_PrepaymentPenalty = v189;
                var v190 = _standardQM_Status_ResidualIncome; v190.Clean = value; _standardQM_Status_ResidualIncome = v190;
                var v191 = _standardQM_Status_SafeHarborEligibility; v191.Clean = value; _standardQM_Status_SafeHarborEligibility = v191;
                var v192 = _standardQM_Status_SimultaneousLoan; v192.Clean = value; _standardQM_Status_SimultaneousLoan = v192;
                var v193 = _startingAdjustedRateMaxBonaFideDiscountPoint; v193.Clean = value; _startingAdjustedRateMaxBonaFideDiscountPoint = v193;
                var v194 = _status_CreditHistory; v194.Clean = value; _status_CreditHistory = v194;
                var v195 = _status_SimultaneousLoan; v195.Clean = value; _status_SimultaneousLoan = v195;
                var v196 = _thresholdExceedsQM; v196.Clean = value; _thresholdExceedsQM = v196;
                var v197 = _titleServicesLenderTitleinsuranceFee; v197.Clean = value; _titleServicesLenderTitleinsuranceFee = v197;
                var v198 = _totalCoMortgagorIncome; v198.Clean = value; _totalCoMortgagorIncome = v198;
                var v199 = _totalIncome; v199.Clean = value; _totalIncome = v199;
                var v200 = _totalPointsFeesSec32Percent; v200.Clean = value; _totalPointsFeesSec32Percent = v200;
                var v201 = _transactionExemptFromRegZ; v201.Clean = value; _transactionExemptFromRegZ = v201;
                var v202 = _unitCount; v202.Clean = value; _unitCount = v202;
                var v203 = _upfrontPMIFees; v203.Clean = value; _upfrontPMIFees = v203;
                var v204 = _withOriginalCreditor; v204.Clean = value; _withOriginalCreditor = v204;
                var v205 = _writtenApplicationDate; v205.Clean = value; _writtenApplicationDate = v205;
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