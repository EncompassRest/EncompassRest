using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class ATRQMCommon : IDirty
    {
        private DirtyValue<decimal?> _affiliatesFees;
        public decimal? AffiliatesFees { get => _affiliatesFees; set => _affiliatesFees = value; }
        private DirtyValue<decimal?> _aPORMaxBonaFideDiscountPoint;
        public decimal? APORMaxBonaFideDiscountPoint { get => _aPORMaxBonaFideDiscountPoint; set => _aPORMaxBonaFideDiscountPoint = value; }
        private DirtyValue<DateTime?> _aRMRecastDate;
        public DateTime? ARMRecastDate { get => _aRMRecastDate; set => _aRMRecastDate = value; }
        private DirtyValue<decimal?> _aRMRecastMonthlyPayment;
        public decimal? ARMRecastMonthlyPayment { get => _aRMRecastMonthlyPayment; set => _aRMRecastMonthlyPayment = value; }
        private StringEnumValue<ATRLoanType> _aTRLoanType;
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
        private StringEnumValue<CollateralRepandWarrReliefEligibilityType> _collateralRepandWarrReliefEligibilityType;
        public StringEnumValue<CollateralRepandWarrReliefEligibilityType> CollateralRepandWarrReliefEligibilityType { get => _collateralRepandWarrReliefEligibilityType; set => _collateralRepandWarrReliefEligibilityType = value; }
        private DirtyValue<decimal?> _compensationPTBFees;
        public decimal? CompensationPTBFees { get => _compensationPTBFees; set => _compensationPTBFees = value; }
        private DirtyValue<decimal?> _creditInsPremiumFees;
        public decimal? CreditInsPremiumFees { get => _creditInsPremiumFees; set => _creditInsPremiumFees = value; }
        private DirtyValue<bool?> _creditorType;
        public bool? CreditorType { get => _creditorType; set => _creditorType = value; }
        private StringEnumValue<CreditorTypeDescription> _creditorTypeDescription;
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
        private StringEnumValue<EligibleNonStandardToStandard> _eligibleNonStandardToStandard;
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
        private StringEnumValue<ATRQMStatus> _generalATR_Status_Alimony;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_Alimony { get => _generalATR_Status_Alimony; set => _generalATR_Status_Alimony = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_Assets;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_Assets { get => _generalATR_Status_Assets; set => _generalATR_Status_Assets = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_ChildSupport;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_ChildSupport { get => _generalATR_Status_ChildSupport; set => _generalATR_Status_ChildSupport = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_CoveredLoan;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_CoveredLoan { get => _generalATR_Status_CoveredLoan; set => _generalATR_Status_CoveredLoan = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_CreditHistory;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_CreditHistory { get => _generalATR_Status_CreditHistory; set => _generalATR_Status_CreditHistory = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_DebtObligations;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_DebtObligations { get => _generalATR_Status_DebtObligations; set => _generalATR_Status_DebtObligations = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_DTI;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_DTI { get => _generalATR_Status_DTI; set => _generalATR_Status_DTI = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_Employment;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_Employment { get => _generalATR_Status_Employment; set => _generalATR_Status_Employment = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_Income;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_Income { get => _generalATR_Status_Income; set => _generalATR_Status_Income = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_MtgRelatedObligations;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_MtgRelatedObligations { get => _generalATR_Status_MtgRelatedObligations; set => _generalATR_Status_MtgRelatedObligations = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_Overall;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_Overall { get => _generalATR_Status_Overall; set => _generalATR_Status_Overall = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_ResidualIncome;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_ResidualIncome { get => _generalATR_Status_ResidualIncome; set => _generalATR_Status_ResidualIncome = value; }
        private StringEnumValue<ATRQMStatus> _generalATR_Status_SimultaneousLoan;
        public StringEnumValue<ATRQMStatus> GeneralATR_Status_SimultaneousLoan { get => _generalATR_Status_SimultaneousLoan; set => _generalATR_Status_SimultaneousLoan = value; }
        private DirtyValue<decimal?> _gSEAgencyQM_CalculatedThreshold;
        public decimal? GSEAgencyQM_CalculatedThreshold { get => _gSEAgencyQM_CalculatedThreshold; set => _gSEAgencyQM_CalculatedThreshold = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_Alimony;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_Alimony { get => _gSEAgencyQM_Status_Alimony; set => _gSEAgencyQM_Status_Alimony = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_Assets;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_Assets { get => _gSEAgencyQM_Status_Assets; set => _gSEAgencyQM_Status_Assets = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_BalloonPayment;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_BalloonPayment { get => _gSEAgencyQM_Status_BalloonPayment; set => _gSEAgencyQM_Status_BalloonPayment = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_ChildSupport;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_ChildSupport { get => _gSEAgencyQM_Status_ChildSupport; set => _gSEAgencyQM_Status_ChildSupport = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_CoveredLoan;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_CoveredLoan { get => _gSEAgencyQM_Status_CoveredLoan; set => _gSEAgencyQM_Status_CoveredLoan = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_CreditHistory;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_CreditHistory { get => _gSEAgencyQM_Status_CreditHistory; set => _gSEAgencyQM_Status_CreditHistory = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_DebtObligations;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_DebtObligations { get => _gSEAgencyQM_Status_DebtObligations; set => _gSEAgencyQM_Status_DebtObligations = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_DTI;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_DTI { get => _gSEAgencyQM_Status_DTI; set => _gSEAgencyQM_Status_DTI = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_Employment;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_Employment { get => _gSEAgencyQM_Status_Employment; set => _gSEAgencyQM_Status_Employment = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_Income;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_Income { get => _gSEAgencyQM_Status_Income; set => _gSEAgencyQM_Status_Income = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_InterestOnly;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_InterestOnly { get => _gSEAgencyQM_Status_InterestOnly; set => _gSEAgencyQM_Status_InterestOnly = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_LoanTerm;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_LoanTerm { get => _gSEAgencyQM_Status_LoanTerm; set => _gSEAgencyQM_Status_LoanTerm = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_MtgRelatedObligations;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_MtgRelatedObligations { get => _gSEAgencyQM_Status_MtgRelatedObligations; set => _gSEAgencyQM_Status_MtgRelatedObligations = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_NegativeAmortization;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_NegativeAmortization { get => _gSEAgencyQM_Status_NegativeAmortization; set => _gSEAgencyQM_Status_NegativeAmortization = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_Overall;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_Overall { get => _gSEAgencyQM_Status_Overall; set => _gSEAgencyQM_Status_Overall = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_PointsFeesLimit;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_PointsFeesLimit { get => _gSEAgencyQM_Status_PointsFeesLimit; set => _gSEAgencyQM_Status_PointsFeesLimit = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_PrepaymentPenalty;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_PrepaymentPenalty { get => _gSEAgencyQM_Status_PrepaymentPenalty; set => _gSEAgencyQM_Status_PrepaymentPenalty = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_ResidualIncome;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_ResidualIncome { get => _gSEAgencyQM_Status_ResidualIncome; set => _gSEAgencyQM_Status_ResidualIncome = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_SafeHarborEligibility;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_SafeHarborEligibility { get => _gSEAgencyQM_Status_SafeHarborEligibility; set => _gSEAgencyQM_Status_SafeHarborEligibility = value; }
        private StringEnumValue<ATRQMStatus> _gSEAgencyQM_Status_SimultaneousLoan;
        public StringEnumValue<ATRQMStatus> GSEAgencyQM_Status_SimultaneousLoan { get => _gSEAgencyQM_Status_SimultaneousLoan; set => _gSEAgencyQM_Status_SimultaneousLoan = value; }
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
        private StringEnumValue<YesNoOrNA> _isEligibleForSafeHarbor;
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
        private StringEnumValue<IsOrIsNot> _isHigherPricedLoan;
        public StringEnumValue<IsOrIsNot> IsHigherPricedLoan { get => _isHigherPricedLoan; set => _isHigherPricedLoan = value; }
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
        private StringEnumValue<LoanProgramDescription> _loanProgramDescription;
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
        private StringEnumValue<QMLoanType> _qMLoanType;
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
        private DirtyValue<decimal?> _smallCreditorQM_CalculatedThreshold;
        public decimal? SmallCreditorQM_CalculatedThreshold { get => _smallCreditorQM_CalculatedThreshold; set => _smallCreditorQM_CalculatedThreshold = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_Alimony;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_Alimony { get => _smallCreditorQM_Status_Alimony; set => _smallCreditorQM_Status_Alimony = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_Assets;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_Assets { get => _smallCreditorQM_Status_Assets; set => _smallCreditorQM_Status_Assets = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_BalloonPayment;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_BalloonPayment { get => _smallCreditorQM_Status_BalloonPayment; set => _smallCreditorQM_Status_BalloonPayment = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_ChildSupport;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_ChildSupport { get => _smallCreditorQM_Status_ChildSupport; set => _smallCreditorQM_Status_ChildSupport = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_CoveredLoan;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_CoveredLoan { get => _smallCreditorQM_Status_CoveredLoan; set => _smallCreditorQM_Status_CoveredLoan = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_DebtObligations;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_DebtObligations { get => _smallCreditorQM_Status_DebtObligations; set => _smallCreditorQM_Status_DebtObligations = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_DTI;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_DTI { get => _smallCreditorQM_Status_DTI; set => _smallCreditorQM_Status_DTI = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_Income;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_Income { get => _smallCreditorQM_Status_Income; set => _smallCreditorQM_Status_Income = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_InterestOnly;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_InterestOnly { get => _smallCreditorQM_Status_InterestOnly; set => _smallCreditorQM_Status_InterestOnly = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_LoanTerm;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_LoanTerm { get => _smallCreditorQM_Status_LoanTerm; set => _smallCreditorQM_Status_LoanTerm = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_MtgRelatedObligations;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_MtgRelatedObligations { get => _smallCreditorQM_Status_MtgRelatedObligations; set => _smallCreditorQM_Status_MtgRelatedObligations = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_NegativeAmortization;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_NegativeAmortization { get => _smallCreditorQM_Status_NegativeAmortization; set => _smallCreditorQM_Status_NegativeAmortization = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_Overall;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_Overall { get => _smallCreditorQM_Status_Overall; set => _smallCreditorQM_Status_Overall = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_PointsFeesLimit;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_PointsFeesLimit { get => _smallCreditorQM_Status_PointsFeesLimit; set => _smallCreditorQM_Status_PointsFeesLimit = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_PrepaymentPenalty;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_PrepaymentPenalty { get => _smallCreditorQM_Status_PrepaymentPenalty; set => _smallCreditorQM_Status_PrepaymentPenalty = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_ResidualIncome;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_ResidualIncome { get => _smallCreditorQM_Status_ResidualIncome; set => _smallCreditorQM_Status_ResidualIncome = value; }
        private StringEnumValue<ATRQMStatus> _smallCreditorQM_Status_SafeHarborEligibility;
        public StringEnumValue<ATRQMStatus> SmallCreditorQM_Status_SafeHarborEligibility { get => _smallCreditorQM_Status_SafeHarborEligibility; set => _smallCreditorQM_Status_SafeHarborEligibility = value; }
        private DirtyValue<decimal?> _standardQM_CalculatedThreshold;
        public decimal? StandardQM_CalculatedThreshold { get => _standardQM_CalculatedThreshold; set => _standardQM_CalculatedThreshold = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_Alimony;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_Alimony { get => _standardQM_Status_Alimony; set => _standardQM_Status_Alimony = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_Assets;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_Assets { get => _standardQM_Status_Assets; set => _standardQM_Status_Assets = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_BalloonPayment;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_BalloonPayment { get => _standardQM_Status_BalloonPayment; set => _standardQM_Status_BalloonPayment = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_ChildSupport;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_ChildSupport { get => _standardQM_Status_ChildSupport; set => _standardQM_Status_ChildSupport = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_CoveredLoan;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_CoveredLoan { get => _standardQM_Status_CoveredLoan; set => _standardQM_Status_CoveredLoan = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_CreditHistory;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_CreditHistory { get => _standardQM_Status_CreditHistory; set => _standardQM_Status_CreditHistory = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_DebtObligations;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_DebtObligations { get => _standardQM_Status_DebtObligations; set => _standardQM_Status_DebtObligations = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_DTI;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_DTI { get => _standardQM_Status_DTI; set => _standardQM_Status_DTI = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_Employment;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_Employment { get => _standardQM_Status_Employment; set => _standardQM_Status_Employment = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_Income;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_Income { get => _standardQM_Status_Income; set => _standardQM_Status_Income = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_InterestOnly;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_InterestOnly { get => _standardQM_Status_InterestOnly; set => _standardQM_Status_InterestOnly = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_LoanTerm;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_LoanTerm { get => _standardQM_Status_LoanTerm; set => _standardQM_Status_LoanTerm = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_MtgRelatedObligations;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_MtgRelatedObligations { get => _standardQM_Status_MtgRelatedObligations; set => _standardQM_Status_MtgRelatedObligations = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_NegativeAmortization;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_NegativeAmortization { get => _standardQM_Status_NegativeAmortization; set => _standardQM_Status_NegativeAmortization = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_Overall;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_Overall { get => _standardQM_Status_Overall; set => _standardQM_Status_Overall = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_PointsFeesLimit;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_PointsFeesLimit { get => _standardQM_Status_PointsFeesLimit; set => _standardQM_Status_PointsFeesLimit = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_PrepaymentPenalty;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_PrepaymentPenalty { get => _standardQM_Status_PrepaymentPenalty; set => _standardQM_Status_PrepaymentPenalty = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_ResidualIncome;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_ResidualIncome { get => _standardQM_Status_ResidualIncome; set => _standardQM_Status_ResidualIncome = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_SafeHarborEligibility;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_SafeHarborEligibility { get => _standardQM_Status_SafeHarborEligibility; set => _standardQM_Status_SafeHarborEligibility = value; }
        private StringEnumValue<ATRQMStatus> _standardQM_Status_SimultaneousLoan;
        public StringEnumValue<ATRQMStatus> StandardQM_Status_SimultaneousLoan { get => _standardQM_Status_SimultaneousLoan; set => _standardQM_Status_SimultaneousLoan = value; }
        private DirtyValue<decimal?> _startingAdjustedRateMaxBonaFideDiscountPoint;
        public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get => _startingAdjustedRateMaxBonaFideDiscountPoint; set => _startingAdjustedRateMaxBonaFideDiscountPoint = value; }
        private StringEnumValue<ATRQMStatus> _status_CreditHistory;
        public StringEnumValue<ATRQMStatus> Status_CreditHistory { get => _status_CreditHistory; set => _status_CreditHistory = value; }
        private StringEnumValue<ATRQMStatus> _status_SimultaneousLoan;
        public StringEnumValue<ATRQMStatus> Status_SimultaneousLoan { get => _status_SimultaneousLoan; set => _status_SimultaneousLoan = value; }
        private StringEnumValue<DoesOrDoesNot2> _thresholdExceedsQM;
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
        private DirtyValue<bool?> _unitCount;
        public bool? UnitCount { get => _unitCount; set => _unitCount = value; }
        private DirtyValue<decimal?> _upfrontPMIFees;
        public decimal? UpfrontPMIFees { get => _upfrontPMIFees; set => _upfrontPMIFees = value; }
        private DirtyValue<bool?> _withOriginalCreditor;
        public bool? WithOriginalCreditor { get => _withOriginalCreditor; set => _withOriginalCreditor = value; }
        private DirtyValue<DateTime?> _writtenApplicationDate;
        public DateTime? WrittenApplicationDate { get => _writtenApplicationDate; set => _writtenApplicationDate = value; }
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
                    || _writtenApplicationDate.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}