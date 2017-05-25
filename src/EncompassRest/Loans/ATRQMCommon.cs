using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v11 = _compensationPTBFees; v11.Clean = value; _compensationPTBFees = v11;
                var v12 = _creditInsPremiumFees; v12.Clean = value; _creditInsPremiumFees = v12;
                var v13 = _creditorType; v13.Clean = value; _creditorType = v13;
                var v14 = _creditorTypeDescription; v14.Clean = value; _creditorTypeDescription = v14;
                var v15 = _creditType; v15.Clean = value; _creditType = v15;
                var v16 = _currentQMFeeThresholdAmt; v16.Clean = value; _currentQMFeeThresholdAmt = v16;
                var v17 = _currentQMFeeThresholdPercent; v17.Clean = value; _currentQMFeeThresholdPercent = v17;
                var v18 = _dateOfLastMonthlyPayment; v18.Clean = value; _dateOfLastMonthlyPayment = v18;
                var v19 = _discountPointAmount; v19.Clean = value; _discountPointAmount = v19;
                var v20 = _discountPointFees; v20.Clean = value; _discountPointFees = v20;
                var v21 = _discountPointPercentage; v21.Clean = value; _discountPointPercentage = v21;
                var v22 = _eligibleNonStandardToStandard; v22.Clean = value; _eligibleNonStandardToStandard = v22;
                var v23 = _financeChargeFees; v23.Clean = value; _financeChargeFees = v23;
                var v24 = _firstChangeRecase; v24.Clean = value; _firstChangeRecase = v24;
                var v25 = _firstPmtDateAfterRecast; v25.Clean = value; _firstPmtDateAfterRecast = v25;
                var v26 = _fullPaymentAfterInterestOnly; v26.Clean = value; _fullPaymentAfterInterestOnly = v26;
                var v27 = _fullyARMPaymentAfterNegAm; v27.Clean = value; _fullyARMPaymentAfterNegAm = v27;
                var v28 = _fullyIndexRateHousingRatio; v28.Clean = value; _fullyIndexRateHousingRatio = v28;
                var v29 = _fullyIndexRateMaxTotalPayment; v29.Clean = value; _fullyIndexRateMaxTotalPayment = v29;
                var v30 = _fullyIndexRateMonthlyPayment; v30.Clean = value; _fullyIndexRateMonthlyPayment = v30;
                var v31 = _fullyIndexRateTotalDebtRatio; v31.Clean = value; _fullyIndexRateTotalDebtRatio = v31;
                var v32 = _generalATR_Status_Alimony; v32.Clean = value; _generalATR_Status_Alimony = v32;
                var v33 = _generalATR_Status_Assets; v33.Clean = value; _generalATR_Status_Assets = v33;
                var v34 = _generalATR_Status_ChildSupport; v34.Clean = value; _generalATR_Status_ChildSupport = v34;
                var v35 = _generalATR_Status_CoveredLoan; v35.Clean = value; _generalATR_Status_CoveredLoan = v35;
                var v36 = _generalATR_Status_CreditHistory; v36.Clean = value; _generalATR_Status_CreditHistory = v36;
                var v37 = _generalATR_Status_DebtObligations; v37.Clean = value; _generalATR_Status_DebtObligations = v37;
                var v38 = _generalATR_Status_DTI; v38.Clean = value; _generalATR_Status_DTI = v38;
                var v39 = _generalATR_Status_Employment; v39.Clean = value; _generalATR_Status_Employment = v39;
                var v40 = _generalATR_Status_Income; v40.Clean = value; _generalATR_Status_Income = v40;
                var v41 = _generalATR_Status_MtgRelatedObligations; v41.Clean = value; _generalATR_Status_MtgRelatedObligations = v41;
                var v42 = _generalATR_Status_Overall; v42.Clean = value; _generalATR_Status_Overall = v42;
                var v43 = _generalATR_Status_ResidualIncome; v43.Clean = value; _generalATR_Status_ResidualIncome = v43;
                var v44 = _generalATR_Status_SimultaneousLoan; v44.Clean = value; _generalATR_Status_SimultaneousLoan = v44;
                var v45 = _gSEAgencyQM_CalculatedThreshold; v45.Clean = value; _gSEAgencyQM_CalculatedThreshold = v45;
                var v46 = _gSEAgencyQM_Status_Alimony; v46.Clean = value; _gSEAgencyQM_Status_Alimony = v46;
                var v47 = _gSEAgencyQM_Status_Assets; v47.Clean = value; _gSEAgencyQM_Status_Assets = v47;
                var v48 = _gSEAgencyQM_Status_BalloonPayment; v48.Clean = value; _gSEAgencyQM_Status_BalloonPayment = v48;
                var v49 = _gSEAgencyQM_Status_ChildSupport; v49.Clean = value; _gSEAgencyQM_Status_ChildSupport = v49;
                var v50 = _gSEAgencyQM_Status_CoveredLoan; v50.Clean = value; _gSEAgencyQM_Status_CoveredLoan = v50;
                var v51 = _gSEAgencyQM_Status_CreditHistory; v51.Clean = value; _gSEAgencyQM_Status_CreditHistory = v51;
                var v52 = _gSEAgencyQM_Status_DebtObligations; v52.Clean = value; _gSEAgencyQM_Status_DebtObligations = v52;
                var v53 = _gSEAgencyQM_Status_DTI; v53.Clean = value; _gSEAgencyQM_Status_DTI = v53;
                var v54 = _gSEAgencyQM_Status_Employment; v54.Clean = value; _gSEAgencyQM_Status_Employment = v54;
                var v55 = _gSEAgencyQM_Status_Income; v55.Clean = value; _gSEAgencyQM_Status_Income = v55;
                var v56 = _gSEAgencyQM_Status_InterestOnly; v56.Clean = value; _gSEAgencyQM_Status_InterestOnly = v56;
                var v57 = _gSEAgencyQM_Status_LoanTerm; v57.Clean = value; _gSEAgencyQM_Status_LoanTerm = v57;
                var v58 = _gSEAgencyQM_Status_MtgRelatedObligations; v58.Clean = value; _gSEAgencyQM_Status_MtgRelatedObligations = v58;
                var v59 = _gSEAgencyQM_Status_NegativeAmortization; v59.Clean = value; _gSEAgencyQM_Status_NegativeAmortization = v59;
                var v60 = _gSEAgencyQM_Status_Overall; v60.Clean = value; _gSEAgencyQM_Status_Overall = v60;
                var v61 = _gSEAgencyQM_Status_PointsFeesLimit; v61.Clean = value; _gSEAgencyQM_Status_PointsFeesLimit = v61;
                var v62 = _gSEAgencyQM_Status_PrepaymentPenalty; v62.Clean = value; _gSEAgencyQM_Status_PrepaymentPenalty = v62;
                var v63 = _gSEAgencyQM_Status_ResidualIncome; v63.Clean = value; _gSEAgencyQM_Status_ResidualIncome = v63;
                var v64 = _gSEAgencyQM_Status_SafeHarborEligibility; v64.Clean = value; _gSEAgencyQM_Status_SafeHarborEligibility = v64;
                var v65 = _gSEAgencyQM_Status_SimultaneousLoan; v65.Clean = value; _gSEAgencyQM_Status_SimultaneousLoan = v65;
                var v66 = _has30DayLatePayment; v66.Clean = value; _has30DayLatePayment = v66;
                var v67 = _id; v67.Clean = value; _id = v67;
                var v68 = _initialMaxTotalPayment; v68.Clean = value; _initialMaxTotalPayment = v68;
                var v69 = _initialRateHousingRatio; v69.Clean = value; _initialRateHousingRatio = v69;
                var v70 = _initialRateMonthlyPayment; v70.Clean = value; _initialRateMonthlyPayment = v70;
                var v71 = _initialRateTotalDebtRatio; v71.Clean = value; _initialRateTotalDebtRatio = v71;
                var v72 = _interestOnlyMonths; v72.Clean = value; _interestOnlyMonths = v72;
                var v73 = _interestOnlyRecastDate; v73.Clean = value; _interestOnlyRecastDate = v73;
                var v74 = _isConsumerLiklyDefault; v74.Clean = value; _isConsumerLiklyDefault = v74;
                var v75 = _isEligibleForSafeHarbor; v75.Clean = value; _isEligibleForSafeHarbor = v75;
                var v76 = _isEvaluatedAlimonyObligations; v76.Clean = value; _isEvaluatedAlimonyObligations = v76;
                var v77 = _isEvaluatedChildSupportObligations; v77.Clean = value; _isEvaluatedChildSupportObligations = v77;
                var v78 = _isEvaluatedCreditHistory; v78.Clean = value; _isEvaluatedCreditHistory = v78;
                var v79 = _isEvaluatedCurrentEmploymentStatus; v79.Clean = value; _isEvaluatedCurrentEmploymentStatus = v79;
                var v80 = _isEvaluatedCurrentExpectedAssets; v80.Clean = value; _isEvaluatedCurrentExpectedAssets = v80;
                var v81 = _isEvaluatedCurrentExpectedIncome; v81.Clean = value; _isEvaluatedCurrentExpectedIncome = v81;
                var v82 = _isEvaluatedDebtObligations; v82.Clean = value; _isEvaluatedDebtObligations = v82;
                var v83 = _isEvaluatedDebtToIncomeRatio; v83.Clean = value; _isEvaluatedDebtToIncomeRatio = v83;
                var v84 = _isEvaluatedMonthlyCoveredLoanPayment; v84.Clean = value; _isEvaluatedMonthlyCoveredLoanPayment = v84;
                var v85 = _isEvaluatedMonthlyMortgageRelatedObligations; v85.Clean = value; _isEvaluatedMonthlyMortgageRelatedObligations = v85;
                var v86 = _isEvaluatedMonthlySimultaneousLoanPayment; v86.Clean = value; _isEvaluatedMonthlySimultaneousLoanPayment = v86;
                var v87 = _isEvaluatedResidualIncome; v87.Clean = value; _isEvaluatedResidualIncome = v87;
                var v88 = _isHigherPricedLoan; v88.Clean = value; _isHigherPricedLoan = v88;
                var v89 = _loanProgram; v89.Clean = value; _loanProgram = v89;
                var v90 = _loanProgramDescription; v90.Clean = value; _loanProgramDescription = v90;
                var v91 = _loanRateFixedin5Years; v91.Clean = value; _loanRateFixedin5Years = v91;
                var v92 = _lOBrokerCompensationAmount; v92.Clean = value; _lOBrokerCompensationAmount = v92;
                var v93 = _max5YrsHousingRatio; v93.Clean = value; _max5YrsHousingRatio = v93;
                var v94 = _max5YrsPrincipleAndInterest; v94.Clean = value; _max5YrsPrincipleAndInterest = v94;
                var v95 = _max5YrsTotalDebtRatio; v95.Clean = value; _max5YrsTotalDebtRatio = v95;
                var v96 = _max5YrsTotalPayment; v96.Clean = value; _max5YrsTotalPayment = v96;
                var v97 = _maxPrepaymentPenaltyFees; v97.Clean = value; _maxPrepaymentPenaltyFees = v97;
                var v98 = _negAmRecastDate; v98.Clean = value; _negAmRecastDate = v98;
                var v99 = _paymentDecreasedBy10Percent; v99.Clean = value; _paymentDecreasedBy10Percent = v99;
                var v100 = _pointsFeesThresholdMet; v100.Clean = value; _pointsFeesThresholdMet = v100;
                var v101 = _prepaymentPenaltyPayoffFees; v101.Clean = value; _prepaymentPenaltyPayoffFees = v101;
                var v102 = _prepayPenaltyPercentage; v102.Clean = value; _prepayPenaltyPercentage = v102;
                var v103 = _preventConsumersDefault; v103.Clean = value; _preventConsumersDefault = v103;
                var v104 = _principalBalanceIncreased; v104.Clean = value; _principalBalanceIncreased = v104;
                var v105 = _principalHasDeferred; v105.Clean = value; _principalHasDeferred = v105;
                var v106 = _qMLoanType; v106.Clean = value; _qMLoanType = v106;
                var v107 = _rateReductionBasisPoints; v107.Clean = value; _rateReductionBasisPoints = v107;
                var v108 = _rateReductionDiscountPoints; v108.Clean = value; _rateReductionDiscountPoints = v108;
                var v109 = _rateReductionMaxBonaFideDiscountPoint; v109.Clean = value; _rateReductionMaxBonaFideDiscountPoint = v109;
                var v110 = _realEstateFees; v110.Clean = value; _realEstateFees = v110;
                var v111 = _recastDifferencePayment; v111.Clean = value; _recastDifferencePayment = v111;
                var v112 = _regZTotalLoanAmount; v112.Clean = value; _regZTotalLoanAmount = v112;
                var v113 = _requiredServicesLenderSelectedAmt; v113.Clean = value; _requiredServicesLenderSelectedAmt = v113;
                var v114 = _smallCreditorQM_CalculatedThreshold; v114.Clean = value; _smallCreditorQM_CalculatedThreshold = v114;
                var v115 = _smallCreditorQM_Status_Alimony; v115.Clean = value; _smallCreditorQM_Status_Alimony = v115;
                var v116 = _smallCreditorQM_Status_Assets; v116.Clean = value; _smallCreditorQM_Status_Assets = v116;
                var v117 = _smallCreditorQM_Status_BalloonPayment; v117.Clean = value; _smallCreditorQM_Status_BalloonPayment = v117;
                var v118 = _smallCreditorQM_Status_ChildSupport; v118.Clean = value; _smallCreditorQM_Status_ChildSupport = v118;
                var v119 = _smallCreditorQM_Status_CoveredLoan; v119.Clean = value; _smallCreditorQM_Status_CoveredLoan = v119;
                var v120 = _smallCreditorQM_Status_DebtObligations; v120.Clean = value; _smallCreditorQM_Status_DebtObligations = v120;
                var v121 = _smallCreditorQM_Status_DTI; v121.Clean = value; _smallCreditorQM_Status_DTI = v121;
                var v122 = _smallCreditorQM_Status_Income; v122.Clean = value; _smallCreditorQM_Status_Income = v122;
                var v123 = _smallCreditorQM_Status_InterestOnly; v123.Clean = value; _smallCreditorQM_Status_InterestOnly = v123;
                var v124 = _smallCreditorQM_Status_LoanTerm; v124.Clean = value; _smallCreditorQM_Status_LoanTerm = v124;
                var v125 = _smallCreditorQM_Status_MtgRelatedObligations; v125.Clean = value; _smallCreditorQM_Status_MtgRelatedObligations = v125;
                var v126 = _smallCreditorQM_Status_NegativeAmortization; v126.Clean = value; _smallCreditorQM_Status_NegativeAmortization = v126;
                var v127 = _smallCreditorQM_Status_Overall; v127.Clean = value; _smallCreditorQM_Status_Overall = v127;
                var v128 = _smallCreditorQM_Status_PointsFeesLimit; v128.Clean = value; _smallCreditorQM_Status_PointsFeesLimit = v128;
                var v129 = _smallCreditorQM_Status_PrepaymentPenalty; v129.Clean = value; _smallCreditorQM_Status_PrepaymentPenalty = v129;
                var v130 = _smallCreditorQM_Status_ResidualIncome; v130.Clean = value; _smallCreditorQM_Status_ResidualIncome = v130;
                var v131 = _smallCreditorQM_Status_SafeHarborEligibility; v131.Clean = value; _smallCreditorQM_Status_SafeHarborEligibility = v131;
                var v132 = _standardQM_CalculatedThreshold; v132.Clean = value; _standardQM_CalculatedThreshold = v132;
                var v133 = _standardQM_Status_Alimony; v133.Clean = value; _standardQM_Status_Alimony = v133;
                var v134 = _standardQM_Status_Assets; v134.Clean = value; _standardQM_Status_Assets = v134;
                var v135 = _standardQM_Status_BalloonPayment; v135.Clean = value; _standardQM_Status_BalloonPayment = v135;
                var v136 = _standardQM_Status_ChildSupport; v136.Clean = value; _standardQM_Status_ChildSupport = v136;
                var v137 = _standardQM_Status_CoveredLoan; v137.Clean = value; _standardQM_Status_CoveredLoan = v137;
                var v138 = _standardQM_Status_CreditHistory; v138.Clean = value; _standardQM_Status_CreditHistory = v138;
                var v139 = _standardQM_Status_DebtObligations; v139.Clean = value; _standardQM_Status_DebtObligations = v139;
                var v140 = _standardQM_Status_DTI; v140.Clean = value; _standardQM_Status_DTI = v140;
                var v141 = _standardQM_Status_Employment; v141.Clean = value; _standardQM_Status_Employment = v141;
                var v142 = _standardQM_Status_Income; v142.Clean = value; _standardQM_Status_Income = v142;
                var v143 = _standardQM_Status_InterestOnly; v143.Clean = value; _standardQM_Status_InterestOnly = v143;
                var v144 = _standardQM_Status_LoanTerm; v144.Clean = value; _standardQM_Status_LoanTerm = v144;
                var v145 = _standardQM_Status_MtgRelatedObligations; v145.Clean = value; _standardQM_Status_MtgRelatedObligations = v145;
                var v146 = _standardQM_Status_NegativeAmortization; v146.Clean = value; _standardQM_Status_NegativeAmortization = v146;
                var v147 = _standardQM_Status_Overall; v147.Clean = value; _standardQM_Status_Overall = v147;
                var v148 = _standardQM_Status_PointsFeesLimit; v148.Clean = value; _standardQM_Status_PointsFeesLimit = v148;
                var v149 = _standardQM_Status_PrepaymentPenalty; v149.Clean = value; _standardQM_Status_PrepaymentPenalty = v149;
                var v150 = _standardQM_Status_ResidualIncome; v150.Clean = value; _standardQM_Status_ResidualIncome = v150;
                var v151 = _standardQM_Status_SafeHarborEligibility; v151.Clean = value; _standardQM_Status_SafeHarborEligibility = v151;
                var v152 = _standardQM_Status_SimultaneousLoan; v152.Clean = value; _standardQM_Status_SimultaneousLoan = v152;
                var v153 = _startingAdjustedRateMaxBonaFideDiscountPoint; v153.Clean = value; _startingAdjustedRateMaxBonaFideDiscountPoint = v153;
                var v154 = _status_CreditHistory; v154.Clean = value; _status_CreditHistory = v154;
                var v155 = _status_SimultaneousLoan; v155.Clean = value; _status_SimultaneousLoan = v155;
                var v156 = _thresholdExceedsQM; v156.Clean = value; _thresholdExceedsQM = v156;
                var v157 = _titleServicesLenderTitleinsuranceFee; v157.Clean = value; _titleServicesLenderTitleinsuranceFee = v157;
                var v158 = _totalCoMortgagorIncome; v158.Clean = value; _totalCoMortgagorIncome = v158;
                var v159 = _totalIncome; v159.Clean = value; _totalIncome = v159;
                var v160 = _totalPointsFeesSec32Percent; v160.Clean = value; _totalPointsFeesSec32Percent = v160;
                var v161 = _transactionExemptFromRegZ; v161.Clean = value; _transactionExemptFromRegZ = v161;
                var v162 = _unitCount; v162.Clean = value; _unitCount = v162;
                var v163 = _upfrontPMIFees; v163.Clean = value; _upfrontPMIFees = v163;
                var v164 = _withOriginalCreditor; v164.Clean = value; _withOriginalCreditor = v164;
                var v165 = _writtenApplicationDate; v165.Clean = value; _writtenApplicationDate = v165;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}