using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ATRQMCommon
    {
        public Value<decimal?> AffiliatesFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliatesFees() => !AffiliatesFees.Clean;
        public Value<decimal?> APORMaxBonaFideDiscountPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAPORMaxBonaFideDiscountPoint() => !APORMaxBonaFideDiscountPoint.Clean;
        public Value<DateTime?> ARMRecastDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeARMRecastDate() => !ARMRecastDate.Clean;
        public Value<decimal?> ARMRecastMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeARMRecastMonthlyPayment() => !ARMRecastMonthlyPayment.Clean;
        public Value<string> ATRLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeATRLoanType() => !ATRLoanType.Clean;
        public Value<string> AUSDataDiscrepencyResolutionComments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSDataDiscrepencyResolutionComments() => !AUSDataDiscrepencyResolutionComments.Clean;
        public Value<DateTime?> AUSDataDiscrepencyResolutionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSDataDiscrepencyResolutionDate() => !AUSDataDiscrepencyResolutionDate.Clean;
        public Value<string> AUSDataDiscrepencyResolvedBy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSDataDiscrepencyResolvedBy() => !AUSDataDiscrepencyResolvedBy.Clean;
        public Value<decimal?> BonaFideDiscountPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonaFideDiscountPoint() => !BonaFideDiscountPoint.Clean;
        public Value<decimal?> BonaFideDiscountPointAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonaFideDiscountPointAmount() => !BonaFideDiscountPointAmount.Clean;
        public Value<bool?> BrokerCompensationWhenRateSet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationWhenRateSet() => !BrokerCompensationWhenRateSet.Clean;
        public Value<decimal?> CompensationPTBFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationPTBFees() => !CompensationPTBFees.Clean;
        public Value<decimal?> CreditInsPremiumFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditInsPremiumFees() => !CreditInsPremiumFees.Clean;
        public Value<bool?> CreditorType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditorType() => !CreditorType.Clean;
        public Value<string> CreditorTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditorTypeDescription() => !CreditorTypeDescription.Clean;
        public Value<bool?> CreditType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditType() => !CreditType.Clean;
        public Value<decimal?> CurrentQMFeeThresholdAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentQMFeeThresholdAmt() => !CurrentQMFeeThresholdAmt.Clean;
        public Value<decimal?> CurrentQMFeeThresholdPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentQMFeeThresholdPercent() => !CurrentQMFeeThresholdPercent.Clean;
        public Value<DateTime?> DateOfLastMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateOfLastMonthlyPayment() => !DateOfLastMonthlyPayment.Clean;
        public Value<decimal?> DiscountPointAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPointAmount() => !DiscountPointAmount.Clean;
        public Value<decimal?> DiscountPointFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPointFees() => !DiscountPointFees.Clean;
        public Value<decimal?> DiscountPointPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPointPercentage() => !DiscountPointPercentage.Clean;
        public Value<string> EligibleNonStandardToStandard { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEligibleNonStandardToStandard() => !EligibleNonStandardToStandard.Clean;
        public Value<decimal?> FinanceChargeFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinanceChargeFees() => !FinanceChargeFees.Clean;
        public Value<int?> FirstChangeRecase { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangeRecase() => !FirstChangeRecase.Clean;
        public Value<DateTime?> FirstPmtDateAfterRecast { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstPmtDateAfterRecast() => !FirstPmtDateAfterRecast.Clean;
        public Value<decimal?> FullPaymentAfterInterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullPaymentAfterInterestOnly() => !FullPaymentAfterInterestOnly.Clean;
        public Value<decimal?> FullyARMPaymentAfterNegAm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullyARMPaymentAfterNegAm() => !FullyARMPaymentAfterNegAm.Clean;
        public Value<decimal?> FullyIndexRateHousingRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullyIndexRateHousingRatio() => !FullyIndexRateHousingRatio.Clean;
        public Value<decimal?> FullyIndexRateMaxTotalPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullyIndexRateMaxTotalPayment() => !FullyIndexRateMaxTotalPayment.Clean;
        public Value<decimal?> FullyIndexRateMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullyIndexRateMonthlyPayment() => !FullyIndexRateMonthlyPayment.Clean;
        public Value<decimal?> FullyIndexRateTotalDebtRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullyIndexRateTotalDebtRatio() => !FullyIndexRateTotalDebtRatio.Clean;
        public Value<string> GeneralATR_Status_Alimony { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_Alimony() => !GeneralATR_Status_Alimony.Clean;
        public Value<string> GeneralATR_Status_Assets { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_Assets() => !GeneralATR_Status_Assets.Clean;
        public Value<string> GeneralATR_Status_ChildSupport { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_ChildSupport() => !GeneralATR_Status_ChildSupport.Clean;
        public Value<string> GeneralATR_Status_CoveredLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_CoveredLoan() => !GeneralATR_Status_CoveredLoan.Clean;
        public Value<string> GeneralATR_Status_CreditHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_CreditHistory() => !GeneralATR_Status_CreditHistory.Clean;
        public Value<string> GeneralATR_Status_DebtObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_DebtObligations() => !GeneralATR_Status_DebtObligations.Clean;
        public Value<string> GeneralATR_Status_DTI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_DTI() => !GeneralATR_Status_DTI.Clean;
        public Value<string> GeneralATR_Status_Employment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_Employment() => !GeneralATR_Status_Employment.Clean;
        public Value<string> GeneralATR_Status_Income { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_Income() => !GeneralATR_Status_Income.Clean;
        public Value<string> GeneralATR_Status_MtgRelatedObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_MtgRelatedObligations() => !GeneralATR_Status_MtgRelatedObligations.Clean;
        public Value<string> GeneralATR_Status_Overall { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_Overall() => !GeneralATR_Status_Overall.Clean;
        public Value<string> GeneralATR_Status_ResidualIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_ResidualIncome() => !GeneralATR_Status_ResidualIncome.Clean;
        public Value<string> GeneralATR_Status_SimultaneousLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGeneralATR_Status_SimultaneousLoan() => !GeneralATR_Status_SimultaneousLoan.Clean;
        public Value<decimal?> GSEAgencyQM_CalculatedThreshold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_CalculatedThreshold() => !GSEAgencyQM_CalculatedThreshold.Clean;
        public Value<string> GSEAgencyQM_Status_Alimony { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_Alimony() => !GSEAgencyQM_Status_Alimony.Clean;
        public Value<string> GSEAgencyQM_Status_Assets { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_Assets() => !GSEAgencyQM_Status_Assets.Clean;
        public Value<string> GSEAgencyQM_Status_BalloonPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_BalloonPayment() => !GSEAgencyQM_Status_BalloonPayment.Clean;
        public Value<string> GSEAgencyQM_Status_ChildSupport { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_ChildSupport() => !GSEAgencyQM_Status_ChildSupport.Clean;
        public Value<string> GSEAgencyQM_Status_CoveredLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_CoveredLoan() => !GSEAgencyQM_Status_CoveredLoan.Clean;
        public Value<string> GSEAgencyQM_Status_CreditHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_CreditHistory() => !GSEAgencyQM_Status_CreditHistory.Clean;
        public Value<string> GSEAgencyQM_Status_DebtObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_DebtObligations() => !GSEAgencyQM_Status_DebtObligations.Clean;
        public Value<string> GSEAgencyQM_Status_DTI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_DTI() => !GSEAgencyQM_Status_DTI.Clean;
        public Value<string> GSEAgencyQM_Status_Employment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_Employment() => !GSEAgencyQM_Status_Employment.Clean;
        public Value<string> GSEAgencyQM_Status_Income { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_Income() => !GSEAgencyQM_Status_Income.Clean;
        public Value<string> GSEAgencyQM_Status_InterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_InterestOnly() => !GSEAgencyQM_Status_InterestOnly.Clean;
        public Value<string> GSEAgencyQM_Status_LoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_LoanTerm() => !GSEAgencyQM_Status_LoanTerm.Clean;
        public Value<string> GSEAgencyQM_Status_MtgRelatedObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_MtgRelatedObligations() => !GSEAgencyQM_Status_MtgRelatedObligations.Clean;
        public Value<string> GSEAgencyQM_Status_NegativeAmortization { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_NegativeAmortization() => !GSEAgencyQM_Status_NegativeAmortization.Clean;
        public Value<string> GSEAgencyQM_Status_Overall { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_Overall() => !GSEAgencyQM_Status_Overall.Clean;
        public Value<string> GSEAgencyQM_Status_PointsFeesLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_PointsFeesLimit() => !GSEAgencyQM_Status_PointsFeesLimit.Clean;
        public Value<string> GSEAgencyQM_Status_PrepaymentPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_PrepaymentPenalty() => !GSEAgencyQM_Status_PrepaymentPenalty.Clean;
        public Value<string> GSEAgencyQM_Status_ResidualIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_ResidualIncome() => !GSEAgencyQM_Status_ResidualIncome.Clean;
        public Value<string> GSEAgencyQM_Status_SafeHarborEligibility { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_SafeHarborEligibility() => !GSEAgencyQM_Status_SafeHarborEligibility.Clean;
        public Value<string> GSEAgencyQM_Status_SimultaneousLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGSEAgencyQM_Status_SimultaneousLoan() => !GSEAgencyQM_Status_SimultaneousLoan.Clean;
        public Value<bool?> Has30DayLatePayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHas30DayLatePayment() => !Has30DayLatePayment.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> InitialMaxTotalPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialMaxTotalPayment() => !InitialMaxTotalPayment.Clean;
        public Value<decimal?> InitialRateHousingRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialRateHousingRatio() => !InitialRateHousingRatio.Clean;
        public Value<decimal?> InitialRateMonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialRateMonthlyPayment() => !InitialRateMonthlyPayment.Clean;
        public Value<decimal?> InitialRateTotalDebtRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialRateTotalDebtRatio() => !InitialRateTotalDebtRatio.Clean;
        public Value<int?> InterestOnlyMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyMonths() => !InterestOnlyMonths.Clean;
        public Value<DateTime?> InterestOnlyRecastDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyRecastDate() => !InterestOnlyRecastDate.Clean;
        public Value<bool?> IsConsumerLiklyDefault { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsConsumerLiklyDefault() => !IsConsumerLiklyDefault.Clean;
        public Value<string> IsEligibleForSafeHarbor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEligibleForSafeHarbor() => !IsEligibleForSafeHarbor.Clean;
        public Value<bool?> IsEvaluatedAlimonyObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedAlimonyObligations() => !IsEvaluatedAlimonyObligations.Clean;
        public Value<bool?> IsEvaluatedChildSupportObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedChildSupportObligations() => !IsEvaluatedChildSupportObligations.Clean;
        public Value<bool?> IsEvaluatedCreditHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedCreditHistory() => !IsEvaluatedCreditHistory.Clean;
        public Value<bool?> IsEvaluatedCurrentEmploymentStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedCurrentEmploymentStatus() => !IsEvaluatedCurrentEmploymentStatus.Clean;
        public Value<bool?> IsEvaluatedCurrentExpectedAssets { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedCurrentExpectedAssets() => !IsEvaluatedCurrentExpectedAssets.Clean;
        public Value<bool?> IsEvaluatedCurrentExpectedIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedCurrentExpectedIncome() => !IsEvaluatedCurrentExpectedIncome.Clean;
        public Value<bool?> IsEvaluatedDebtObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedDebtObligations() => !IsEvaluatedDebtObligations.Clean;
        public Value<bool?> IsEvaluatedDebtToIncomeRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedDebtToIncomeRatio() => !IsEvaluatedDebtToIncomeRatio.Clean;
        public Value<bool?> IsEvaluatedMonthlyCoveredLoanPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedMonthlyCoveredLoanPayment() => !IsEvaluatedMonthlyCoveredLoanPayment.Clean;
        public Value<bool?> IsEvaluatedMonthlyMortgageRelatedObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedMonthlyMortgageRelatedObligations() => !IsEvaluatedMonthlyMortgageRelatedObligations.Clean;
        public Value<bool?> IsEvaluatedMonthlySimultaneousLoanPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedMonthlySimultaneousLoanPayment() => !IsEvaluatedMonthlySimultaneousLoanPayment.Clean;
        public Value<bool?> IsEvaluatedResidualIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEvaluatedResidualIncome() => !IsEvaluatedResidualIncome.Clean;
        public Value<string> IsHigherPricedLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsHigherPricedLoan() => !IsHigherPricedLoan.Clean;
        public Value<bool?> LoanProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgram() => !LoanProgram.Clean;
        public Value<string> LoanProgramDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgramDescription() => !LoanProgramDescription.Clean;
        public Value<bool?> LoanRateFixedin5Years { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanRateFixedin5Years() => !LoanRateFixedin5Years.Clean;
        public Value<decimal?> LOBrokerCompensationAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLOBrokerCompensationAmount() => !LOBrokerCompensationAmount.Clean;
        public Value<decimal?> Max5YrsHousingRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMax5YrsHousingRatio() => !Max5YrsHousingRatio.Clean;
        public Value<decimal?> Max5YrsPrincipleAndInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMax5YrsPrincipleAndInterest() => !Max5YrsPrincipleAndInterest.Clean;
        public Value<decimal?> Max5YrsTotalDebtRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMax5YrsTotalDebtRatio() => !Max5YrsTotalDebtRatio.Clean;
        public Value<decimal?> Max5YrsTotalPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMax5YrsTotalPayment() => !Max5YrsTotalPayment.Clean;
        public Value<decimal?> MaxPrepaymentPenaltyFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxPrepaymentPenaltyFees() => !MaxPrepaymentPenaltyFees.Clean;
        public Value<DateTime?> NegAmRecastDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNegAmRecastDate() => !NegAmRecastDate.Clean;
        public Value<bool?> PaymentDecreasedBy10Percent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentDecreasedBy10Percent() => !PaymentDecreasedBy10Percent.Clean;
        public Value<bool?> PointsFeesThresholdMet { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePointsFeesThresholdMet() => !PointsFeesThresholdMet.Clean;
        public Value<decimal?> PrepaymentPenaltyPayoffFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPayoffFees() => !PrepaymentPenaltyPayoffFees.Clean;
        public Value<decimal?> PrepayPenaltyPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepayPenaltyPercentage() => !PrepayPenaltyPercentage.Clean;
        public Value<bool?> PreventConsumersDefault { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreventConsumersDefault() => !PreventConsumersDefault.Clean;
        public Value<bool?> PrincipalBalanceIncreased { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalBalanceIncreased() => !PrincipalBalanceIncreased.Clean;
        public Value<bool?> PrincipalHasDeferred { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalHasDeferred() => !PrincipalHasDeferred.Clean;
        public Value<string> QMLoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQMLoanType() => !QMLoanType.Clean;
        public Value<decimal?> RateReductionBasisPoints { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateReductionBasisPoints() => !RateReductionBasisPoints.Clean;
        public Value<decimal?> RateReductionDiscountPoints { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateReductionDiscountPoints() => !RateReductionDiscountPoints.Clean;
        public Value<decimal?> RateReductionMaxBonaFideDiscountPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateReductionMaxBonaFideDiscountPoint() => !RateReductionMaxBonaFideDiscountPoint.Clean;
        public Value<decimal?> RealEstateFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRealEstateFees() => !RealEstateFees.Clean;
        public Value<decimal?> RecastDifferencePayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecastDifferencePayment() => !RecastDifferencePayment.Clean;
        public Value<decimal?> RegZTotalLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRegZTotalLoanAmount() => !RegZTotalLoanAmount.Clean;
        public Value<decimal?> RequiredServicesLenderSelectedAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredServicesLenderSelectedAmt() => !RequiredServicesLenderSelectedAmt.Clean;
        public Value<decimal?> SmallCreditorQM_CalculatedThreshold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_CalculatedThreshold() => !SmallCreditorQM_CalculatedThreshold.Clean;
        public Value<string> SmallCreditorQM_Status_Alimony { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_Alimony() => !SmallCreditorQM_Status_Alimony.Clean;
        public Value<string> SmallCreditorQM_Status_Assets { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_Assets() => !SmallCreditorQM_Status_Assets.Clean;
        public Value<string> SmallCreditorQM_Status_BalloonPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_BalloonPayment() => !SmallCreditorQM_Status_BalloonPayment.Clean;
        public Value<string> SmallCreditorQM_Status_ChildSupport { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_ChildSupport() => !SmallCreditorQM_Status_ChildSupport.Clean;
        public Value<string> SmallCreditorQM_Status_CoveredLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_CoveredLoan() => !SmallCreditorQM_Status_CoveredLoan.Clean;
        public Value<string> SmallCreditorQM_Status_DebtObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_DebtObligations() => !SmallCreditorQM_Status_DebtObligations.Clean;
        public Value<string> SmallCreditorQM_Status_DTI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_DTI() => !SmallCreditorQM_Status_DTI.Clean;
        public Value<string> SmallCreditorQM_Status_Income { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_Income() => !SmallCreditorQM_Status_Income.Clean;
        public Value<string> SmallCreditorQM_Status_InterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_InterestOnly() => !SmallCreditorQM_Status_InterestOnly.Clean;
        public Value<string> SmallCreditorQM_Status_LoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_LoanTerm() => !SmallCreditorQM_Status_LoanTerm.Clean;
        public Value<string> SmallCreditorQM_Status_MtgRelatedObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_MtgRelatedObligations() => !SmallCreditorQM_Status_MtgRelatedObligations.Clean;
        public Value<string> SmallCreditorQM_Status_NegativeAmortization { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_NegativeAmortization() => !SmallCreditorQM_Status_NegativeAmortization.Clean;
        public Value<string> SmallCreditorQM_Status_Overall { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_Overall() => !SmallCreditorQM_Status_Overall.Clean;
        public Value<string> SmallCreditorQM_Status_PointsFeesLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_PointsFeesLimit() => !SmallCreditorQM_Status_PointsFeesLimit.Clean;
        public Value<string> SmallCreditorQM_Status_PrepaymentPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_PrepaymentPenalty() => !SmallCreditorQM_Status_PrepaymentPenalty.Clean;
        public Value<string> SmallCreditorQM_Status_ResidualIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_ResidualIncome() => !SmallCreditorQM_Status_ResidualIncome.Clean;
        public Value<string> SmallCreditorQM_Status_SafeHarborEligibility { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSmallCreditorQM_Status_SafeHarborEligibility() => !SmallCreditorQM_Status_SafeHarborEligibility.Clean;
        public Value<decimal?> StandardQM_CalculatedThreshold { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_CalculatedThreshold() => !StandardQM_CalculatedThreshold.Clean;
        public Value<string> StandardQM_Status_Alimony { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_Alimony() => !StandardQM_Status_Alimony.Clean;
        public Value<string> StandardQM_Status_Assets { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_Assets() => !StandardQM_Status_Assets.Clean;
        public Value<string> StandardQM_Status_BalloonPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_BalloonPayment() => !StandardQM_Status_BalloonPayment.Clean;
        public Value<string> StandardQM_Status_ChildSupport { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_ChildSupport() => !StandardQM_Status_ChildSupport.Clean;
        public Value<string> StandardQM_Status_CoveredLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_CoveredLoan() => !StandardQM_Status_CoveredLoan.Clean;
        public Value<string> StandardQM_Status_CreditHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_CreditHistory() => !StandardQM_Status_CreditHistory.Clean;
        public Value<string> StandardQM_Status_DebtObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_DebtObligations() => !StandardQM_Status_DebtObligations.Clean;
        public Value<string> StandardQM_Status_DTI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_DTI() => !StandardQM_Status_DTI.Clean;
        public Value<string> StandardQM_Status_Employment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_Employment() => !StandardQM_Status_Employment.Clean;
        public Value<string> StandardQM_Status_Income { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_Income() => !StandardQM_Status_Income.Clean;
        public Value<string> StandardQM_Status_InterestOnly { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_InterestOnly() => !StandardQM_Status_InterestOnly.Clean;
        public Value<string> StandardQM_Status_LoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_LoanTerm() => !StandardQM_Status_LoanTerm.Clean;
        public Value<string> StandardQM_Status_MtgRelatedObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_MtgRelatedObligations() => !StandardQM_Status_MtgRelatedObligations.Clean;
        public Value<string> StandardQM_Status_NegativeAmortization { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_NegativeAmortization() => !StandardQM_Status_NegativeAmortization.Clean;
        public Value<string> StandardQM_Status_Overall { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_Overall() => !StandardQM_Status_Overall.Clean;
        public Value<string> StandardQM_Status_PointsFeesLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_PointsFeesLimit() => !StandardQM_Status_PointsFeesLimit.Clean;
        public Value<string> StandardQM_Status_PrepaymentPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_PrepaymentPenalty() => !StandardQM_Status_PrepaymentPenalty.Clean;
        public Value<string> StandardQM_Status_ResidualIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_ResidualIncome() => !StandardQM_Status_ResidualIncome.Clean;
        public Value<string> StandardQM_Status_SafeHarborEligibility { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_SafeHarborEligibility() => !StandardQM_Status_SafeHarborEligibility.Clean;
        public Value<string> StandardQM_Status_SimultaneousLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStandardQM_Status_SimultaneousLoan() => !StandardQM_Status_SimultaneousLoan.Clean;
        public Value<decimal?> StartingAdjustedRateMaxBonaFideDiscountPoint { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartingAdjustedRateMaxBonaFideDiscountPoint() => !StartingAdjustedRateMaxBonaFideDiscountPoint.Clean;
        public Value<string> Status_CreditHistory { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatus_CreditHistory() => !Status_CreditHistory.Clean;
        public Value<string> Status_SimultaneousLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatus_SimultaneousLoan() => !Status_SimultaneousLoan.Clean;
        public Value<string> ThresholdExceedsQM { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThresholdExceedsQM() => !ThresholdExceedsQM.Clean;
        public Value<decimal?> TitleServicesLenderTitleinsuranceFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleServicesLenderTitleinsuranceFee() => !TitleServicesLenderTitleinsuranceFee.Clean;
        public Value<decimal?> TotalCoMortgagorIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCoMortgagorIncome() => !TotalCoMortgagorIncome.Clean;
        public Value<decimal?> TotalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalIncome() => !TotalIncome.Clean;
        public Value<decimal?> TotalPointsFeesSec32Percent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPointsFeesSec32Percent() => !TotalPointsFeesSec32Percent.Clean;
        public Value<bool?> TransactionExemptFromRegZ { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionExemptFromRegZ() => !TransactionExemptFromRegZ.Clean;
        public Value<bool?> UnitCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnitCount() => !UnitCount.Clean;
        public Value<decimal?> UpfrontPMIFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUpfrontPMIFees() => !UpfrontPMIFees.Clean;
        public Value<bool?> WithOriginalCreditor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWithOriginalCreditor() => !WithOriginalCreditor.Clean;
        public Value<DateTime?> WrittenApplicationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWrittenApplicationDate() => !WrittenApplicationDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AffiliatesFees.Clean
                    && APORMaxBonaFideDiscountPoint.Clean
                    && ARMRecastDate.Clean
                    && ARMRecastMonthlyPayment.Clean
                    && ATRLoanType.Clean
                    && AUSDataDiscrepencyResolutionComments.Clean
                    && AUSDataDiscrepencyResolutionDate.Clean
                    && AUSDataDiscrepencyResolvedBy.Clean
                    && BonaFideDiscountPoint.Clean
                    && BonaFideDiscountPointAmount.Clean
                    && BrokerCompensationWhenRateSet.Clean
                    && CompensationPTBFees.Clean
                    && CreditInsPremiumFees.Clean
                    && CreditorType.Clean
                    && CreditorTypeDescription.Clean
                    && CreditType.Clean
                    && CurrentQMFeeThresholdAmt.Clean
                    && CurrentQMFeeThresholdPercent.Clean
                    && DateOfLastMonthlyPayment.Clean
                    && DiscountPointAmount.Clean
                    && DiscountPointFees.Clean
                    && DiscountPointPercentage.Clean
                    && EligibleNonStandardToStandard.Clean
                    && FinanceChargeFees.Clean
                    && FirstChangeRecase.Clean
                    && FirstPmtDateAfterRecast.Clean
                    && FullPaymentAfterInterestOnly.Clean
                    && FullyARMPaymentAfterNegAm.Clean
                    && FullyIndexRateHousingRatio.Clean
                    && FullyIndexRateMaxTotalPayment.Clean
                    && FullyIndexRateMonthlyPayment.Clean
                    && FullyIndexRateTotalDebtRatio.Clean
                    && GeneralATR_Status_Alimony.Clean
                    && GeneralATR_Status_Assets.Clean
                    && GeneralATR_Status_ChildSupport.Clean
                    && GeneralATR_Status_CoveredLoan.Clean
                    && GeneralATR_Status_CreditHistory.Clean
                    && GeneralATR_Status_DebtObligations.Clean
                    && GeneralATR_Status_DTI.Clean
                    && GeneralATR_Status_Employment.Clean
                    && GeneralATR_Status_Income.Clean
                    && GeneralATR_Status_MtgRelatedObligations.Clean
                    && GeneralATR_Status_Overall.Clean
                    && GeneralATR_Status_ResidualIncome.Clean
                    && GeneralATR_Status_SimultaneousLoan.Clean
                    && GSEAgencyQM_CalculatedThreshold.Clean
                    && GSEAgencyQM_Status_Alimony.Clean
                    && GSEAgencyQM_Status_Assets.Clean
                    && GSEAgencyQM_Status_BalloonPayment.Clean
                    && GSEAgencyQM_Status_ChildSupport.Clean
                    && GSEAgencyQM_Status_CoveredLoan.Clean
                    && GSEAgencyQM_Status_CreditHistory.Clean
                    && GSEAgencyQM_Status_DebtObligations.Clean
                    && GSEAgencyQM_Status_DTI.Clean
                    && GSEAgencyQM_Status_Employment.Clean
                    && GSEAgencyQM_Status_Income.Clean
                    && GSEAgencyQM_Status_InterestOnly.Clean
                    && GSEAgencyQM_Status_LoanTerm.Clean
                    && GSEAgencyQM_Status_MtgRelatedObligations.Clean
                    && GSEAgencyQM_Status_NegativeAmortization.Clean
                    && GSEAgencyQM_Status_Overall.Clean
                    && GSEAgencyQM_Status_PointsFeesLimit.Clean
                    && GSEAgencyQM_Status_PrepaymentPenalty.Clean
                    && GSEAgencyQM_Status_ResidualIncome.Clean
                    && GSEAgencyQM_Status_SafeHarborEligibility.Clean
                    && GSEAgencyQM_Status_SimultaneousLoan.Clean
                    && Has30DayLatePayment.Clean
                    && Id.Clean
                    && InitialMaxTotalPayment.Clean
                    && InitialRateHousingRatio.Clean
                    && InitialRateMonthlyPayment.Clean
                    && InitialRateTotalDebtRatio.Clean
                    && InterestOnlyMonths.Clean
                    && InterestOnlyRecastDate.Clean
                    && IsConsumerLiklyDefault.Clean
                    && IsEligibleForSafeHarbor.Clean
                    && IsEvaluatedAlimonyObligations.Clean
                    && IsEvaluatedChildSupportObligations.Clean
                    && IsEvaluatedCreditHistory.Clean
                    && IsEvaluatedCurrentEmploymentStatus.Clean
                    && IsEvaluatedCurrentExpectedAssets.Clean
                    && IsEvaluatedCurrentExpectedIncome.Clean
                    && IsEvaluatedDebtObligations.Clean
                    && IsEvaluatedDebtToIncomeRatio.Clean
                    && IsEvaluatedMonthlyCoveredLoanPayment.Clean
                    && IsEvaluatedMonthlyMortgageRelatedObligations.Clean
                    && IsEvaluatedMonthlySimultaneousLoanPayment.Clean
                    && IsEvaluatedResidualIncome.Clean
                    && IsHigherPricedLoan.Clean
                    && LoanProgram.Clean
                    && LoanProgramDescription.Clean
                    && LoanRateFixedin5Years.Clean
                    && LOBrokerCompensationAmount.Clean
                    && Max5YrsHousingRatio.Clean
                    && Max5YrsPrincipleAndInterest.Clean
                    && Max5YrsTotalDebtRatio.Clean
                    && Max5YrsTotalPayment.Clean
                    && MaxPrepaymentPenaltyFees.Clean
                    && NegAmRecastDate.Clean
                    && PaymentDecreasedBy10Percent.Clean
                    && PointsFeesThresholdMet.Clean
                    && PrepaymentPenaltyPayoffFees.Clean
                    && PrepayPenaltyPercentage.Clean
                    && PreventConsumersDefault.Clean
                    && PrincipalBalanceIncreased.Clean
                    && PrincipalHasDeferred.Clean
                    && QMLoanType.Clean
                    && RateReductionBasisPoints.Clean
                    && RateReductionDiscountPoints.Clean
                    && RateReductionMaxBonaFideDiscountPoint.Clean
                    && RealEstateFees.Clean
                    && RecastDifferencePayment.Clean
                    && RegZTotalLoanAmount.Clean
                    && RequiredServicesLenderSelectedAmt.Clean
                    && SmallCreditorQM_CalculatedThreshold.Clean
                    && SmallCreditorQM_Status_Alimony.Clean
                    && SmallCreditorQM_Status_Assets.Clean
                    && SmallCreditorQM_Status_BalloonPayment.Clean
                    && SmallCreditorQM_Status_ChildSupport.Clean
                    && SmallCreditorQM_Status_CoveredLoan.Clean
                    && SmallCreditorQM_Status_DebtObligations.Clean
                    && SmallCreditorQM_Status_DTI.Clean
                    && SmallCreditorQM_Status_Income.Clean
                    && SmallCreditorQM_Status_InterestOnly.Clean
                    && SmallCreditorQM_Status_LoanTerm.Clean
                    && SmallCreditorQM_Status_MtgRelatedObligations.Clean
                    && SmallCreditorQM_Status_NegativeAmortization.Clean
                    && SmallCreditorQM_Status_Overall.Clean
                    && SmallCreditorQM_Status_PointsFeesLimit.Clean
                    && SmallCreditorQM_Status_PrepaymentPenalty.Clean
                    && SmallCreditorQM_Status_ResidualIncome.Clean
                    && SmallCreditorQM_Status_SafeHarborEligibility.Clean
                    && StandardQM_CalculatedThreshold.Clean
                    && StandardQM_Status_Alimony.Clean
                    && StandardQM_Status_Assets.Clean
                    && StandardQM_Status_BalloonPayment.Clean
                    && StandardQM_Status_ChildSupport.Clean
                    && StandardQM_Status_CoveredLoan.Clean
                    && StandardQM_Status_CreditHistory.Clean
                    && StandardQM_Status_DebtObligations.Clean
                    && StandardQM_Status_DTI.Clean
                    && StandardQM_Status_Employment.Clean
                    && StandardQM_Status_Income.Clean
                    && StandardQM_Status_InterestOnly.Clean
                    && StandardQM_Status_LoanTerm.Clean
                    && StandardQM_Status_MtgRelatedObligations.Clean
                    && StandardQM_Status_NegativeAmortization.Clean
                    && StandardQM_Status_Overall.Clean
                    && StandardQM_Status_PointsFeesLimit.Clean
                    && StandardQM_Status_PrepaymentPenalty.Clean
                    && StandardQM_Status_ResidualIncome.Clean
                    && StandardQM_Status_SafeHarborEligibility.Clean
                    && StandardQM_Status_SimultaneousLoan.Clean
                    && StartingAdjustedRateMaxBonaFideDiscountPoint.Clean
                    && Status_CreditHistory.Clean
                    && Status_SimultaneousLoan.Clean
                    && ThresholdExceedsQM.Clean
                    && TitleServicesLenderTitleinsuranceFee.Clean
                    && TotalCoMortgagorIncome.Clean
                    && TotalIncome.Clean
                    && TotalPointsFeesSec32Percent.Clean
                    && TransactionExemptFromRegZ.Clean
                    && UnitCount.Clean
                    && UpfrontPMIFees.Clean
                    && WithOriginalCreditor.Clean
                    && WrittenApplicationDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AffiliatesFees; v0.Clean = value; AffiliatesFees = v0;
                var v1 = APORMaxBonaFideDiscountPoint; v1.Clean = value; APORMaxBonaFideDiscountPoint = v1;
                var v2 = ARMRecastDate; v2.Clean = value; ARMRecastDate = v2;
                var v3 = ARMRecastMonthlyPayment; v3.Clean = value; ARMRecastMonthlyPayment = v3;
                var v4 = ATRLoanType; v4.Clean = value; ATRLoanType = v4;
                var v5 = AUSDataDiscrepencyResolutionComments; v5.Clean = value; AUSDataDiscrepencyResolutionComments = v5;
                var v6 = AUSDataDiscrepencyResolutionDate; v6.Clean = value; AUSDataDiscrepencyResolutionDate = v6;
                var v7 = AUSDataDiscrepencyResolvedBy; v7.Clean = value; AUSDataDiscrepencyResolvedBy = v7;
                var v8 = BonaFideDiscountPoint; v8.Clean = value; BonaFideDiscountPoint = v8;
                var v9 = BonaFideDiscountPointAmount; v9.Clean = value; BonaFideDiscountPointAmount = v9;
                var v10 = BrokerCompensationWhenRateSet; v10.Clean = value; BrokerCompensationWhenRateSet = v10;
                var v11 = CompensationPTBFees; v11.Clean = value; CompensationPTBFees = v11;
                var v12 = CreditInsPremiumFees; v12.Clean = value; CreditInsPremiumFees = v12;
                var v13 = CreditorType; v13.Clean = value; CreditorType = v13;
                var v14 = CreditorTypeDescription; v14.Clean = value; CreditorTypeDescription = v14;
                var v15 = CreditType; v15.Clean = value; CreditType = v15;
                var v16 = CurrentQMFeeThresholdAmt; v16.Clean = value; CurrentQMFeeThresholdAmt = v16;
                var v17 = CurrentQMFeeThresholdPercent; v17.Clean = value; CurrentQMFeeThresholdPercent = v17;
                var v18 = DateOfLastMonthlyPayment; v18.Clean = value; DateOfLastMonthlyPayment = v18;
                var v19 = DiscountPointAmount; v19.Clean = value; DiscountPointAmount = v19;
                var v20 = DiscountPointFees; v20.Clean = value; DiscountPointFees = v20;
                var v21 = DiscountPointPercentage; v21.Clean = value; DiscountPointPercentage = v21;
                var v22 = EligibleNonStandardToStandard; v22.Clean = value; EligibleNonStandardToStandard = v22;
                var v23 = FinanceChargeFees; v23.Clean = value; FinanceChargeFees = v23;
                var v24 = FirstChangeRecase; v24.Clean = value; FirstChangeRecase = v24;
                var v25 = FirstPmtDateAfterRecast; v25.Clean = value; FirstPmtDateAfterRecast = v25;
                var v26 = FullPaymentAfterInterestOnly; v26.Clean = value; FullPaymentAfterInterestOnly = v26;
                var v27 = FullyARMPaymentAfterNegAm; v27.Clean = value; FullyARMPaymentAfterNegAm = v27;
                var v28 = FullyIndexRateHousingRatio; v28.Clean = value; FullyIndexRateHousingRatio = v28;
                var v29 = FullyIndexRateMaxTotalPayment; v29.Clean = value; FullyIndexRateMaxTotalPayment = v29;
                var v30 = FullyIndexRateMonthlyPayment; v30.Clean = value; FullyIndexRateMonthlyPayment = v30;
                var v31 = FullyIndexRateTotalDebtRatio; v31.Clean = value; FullyIndexRateTotalDebtRatio = v31;
                var v32 = GeneralATR_Status_Alimony; v32.Clean = value; GeneralATR_Status_Alimony = v32;
                var v33 = GeneralATR_Status_Assets; v33.Clean = value; GeneralATR_Status_Assets = v33;
                var v34 = GeneralATR_Status_ChildSupport; v34.Clean = value; GeneralATR_Status_ChildSupport = v34;
                var v35 = GeneralATR_Status_CoveredLoan; v35.Clean = value; GeneralATR_Status_CoveredLoan = v35;
                var v36 = GeneralATR_Status_CreditHistory; v36.Clean = value; GeneralATR_Status_CreditHistory = v36;
                var v37 = GeneralATR_Status_DebtObligations; v37.Clean = value; GeneralATR_Status_DebtObligations = v37;
                var v38 = GeneralATR_Status_DTI; v38.Clean = value; GeneralATR_Status_DTI = v38;
                var v39 = GeneralATR_Status_Employment; v39.Clean = value; GeneralATR_Status_Employment = v39;
                var v40 = GeneralATR_Status_Income; v40.Clean = value; GeneralATR_Status_Income = v40;
                var v41 = GeneralATR_Status_MtgRelatedObligations; v41.Clean = value; GeneralATR_Status_MtgRelatedObligations = v41;
                var v42 = GeneralATR_Status_Overall; v42.Clean = value; GeneralATR_Status_Overall = v42;
                var v43 = GeneralATR_Status_ResidualIncome; v43.Clean = value; GeneralATR_Status_ResidualIncome = v43;
                var v44 = GeneralATR_Status_SimultaneousLoan; v44.Clean = value; GeneralATR_Status_SimultaneousLoan = v44;
                var v45 = GSEAgencyQM_CalculatedThreshold; v45.Clean = value; GSEAgencyQM_CalculatedThreshold = v45;
                var v46 = GSEAgencyQM_Status_Alimony; v46.Clean = value; GSEAgencyQM_Status_Alimony = v46;
                var v47 = GSEAgencyQM_Status_Assets; v47.Clean = value; GSEAgencyQM_Status_Assets = v47;
                var v48 = GSEAgencyQM_Status_BalloonPayment; v48.Clean = value; GSEAgencyQM_Status_BalloonPayment = v48;
                var v49 = GSEAgencyQM_Status_ChildSupport; v49.Clean = value; GSEAgencyQM_Status_ChildSupport = v49;
                var v50 = GSEAgencyQM_Status_CoveredLoan; v50.Clean = value; GSEAgencyQM_Status_CoveredLoan = v50;
                var v51 = GSEAgencyQM_Status_CreditHistory; v51.Clean = value; GSEAgencyQM_Status_CreditHistory = v51;
                var v52 = GSEAgencyQM_Status_DebtObligations; v52.Clean = value; GSEAgencyQM_Status_DebtObligations = v52;
                var v53 = GSEAgencyQM_Status_DTI; v53.Clean = value; GSEAgencyQM_Status_DTI = v53;
                var v54 = GSEAgencyQM_Status_Employment; v54.Clean = value; GSEAgencyQM_Status_Employment = v54;
                var v55 = GSEAgencyQM_Status_Income; v55.Clean = value; GSEAgencyQM_Status_Income = v55;
                var v56 = GSEAgencyQM_Status_InterestOnly; v56.Clean = value; GSEAgencyQM_Status_InterestOnly = v56;
                var v57 = GSEAgencyQM_Status_LoanTerm; v57.Clean = value; GSEAgencyQM_Status_LoanTerm = v57;
                var v58 = GSEAgencyQM_Status_MtgRelatedObligations; v58.Clean = value; GSEAgencyQM_Status_MtgRelatedObligations = v58;
                var v59 = GSEAgencyQM_Status_NegativeAmortization; v59.Clean = value; GSEAgencyQM_Status_NegativeAmortization = v59;
                var v60 = GSEAgencyQM_Status_Overall; v60.Clean = value; GSEAgencyQM_Status_Overall = v60;
                var v61 = GSEAgencyQM_Status_PointsFeesLimit; v61.Clean = value; GSEAgencyQM_Status_PointsFeesLimit = v61;
                var v62 = GSEAgencyQM_Status_PrepaymentPenalty; v62.Clean = value; GSEAgencyQM_Status_PrepaymentPenalty = v62;
                var v63 = GSEAgencyQM_Status_ResidualIncome; v63.Clean = value; GSEAgencyQM_Status_ResidualIncome = v63;
                var v64 = GSEAgencyQM_Status_SafeHarborEligibility; v64.Clean = value; GSEAgencyQM_Status_SafeHarborEligibility = v64;
                var v65 = GSEAgencyQM_Status_SimultaneousLoan; v65.Clean = value; GSEAgencyQM_Status_SimultaneousLoan = v65;
                var v66 = Has30DayLatePayment; v66.Clean = value; Has30DayLatePayment = v66;
                var v67 = Id; v67.Clean = value; Id = v67;
                var v68 = InitialMaxTotalPayment; v68.Clean = value; InitialMaxTotalPayment = v68;
                var v69 = InitialRateHousingRatio; v69.Clean = value; InitialRateHousingRatio = v69;
                var v70 = InitialRateMonthlyPayment; v70.Clean = value; InitialRateMonthlyPayment = v70;
                var v71 = InitialRateTotalDebtRatio; v71.Clean = value; InitialRateTotalDebtRatio = v71;
                var v72 = InterestOnlyMonths; v72.Clean = value; InterestOnlyMonths = v72;
                var v73 = InterestOnlyRecastDate; v73.Clean = value; InterestOnlyRecastDate = v73;
                var v74 = IsConsumerLiklyDefault; v74.Clean = value; IsConsumerLiklyDefault = v74;
                var v75 = IsEligibleForSafeHarbor; v75.Clean = value; IsEligibleForSafeHarbor = v75;
                var v76 = IsEvaluatedAlimonyObligations; v76.Clean = value; IsEvaluatedAlimonyObligations = v76;
                var v77 = IsEvaluatedChildSupportObligations; v77.Clean = value; IsEvaluatedChildSupportObligations = v77;
                var v78 = IsEvaluatedCreditHistory; v78.Clean = value; IsEvaluatedCreditHistory = v78;
                var v79 = IsEvaluatedCurrentEmploymentStatus; v79.Clean = value; IsEvaluatedCurrentEmploymentStatus = v79;
                var v80 = IsEvaluatedCurrentExpectedAssets; v80.Clean = value; IsEvaluatedCurrentExpectedAssets = v80;
                var v81 = IsEvaluatedCurrentExpectedIncome; v81.Clean = value; IsEvaluatedCurrentExpectedIncome = v81;
                var v82 = IsEvaluatedDebtObligations; v82.Clean = value; IsEvaluatedDebtObligations = v82;
                var v83 = IsEvaluatedDebtToIncomeRatio; v83.Clean = value; IsEvaluatedDebtToIncomeRatio = v83;
                var v84 = IsEvaluatedMonthlyCoveredLoanPayment; v84.Clean = value; IsEvaluatedMonthlyCoveredLoanPayment = v84;
                var v85 = IsEvaluatedMonthlyMortgageRelatedObligations; v85.Clean = value; IsEvaluatedMonthlyMortgageRelatedObligations = v85;
                var v86 = IsEvaluatedMonthlySimultaneousLoanPayment; v86.Clean = value; IsEvaluatedMonthlySimultaneousLoanPayment = v86;
                var v87 = IsEvaluatedResidualIncome; v87.Clean = value; IsEvaluatedResidualIncome = v87;
                var v88 = IsHigherPricedLoan; v88.Clean = value; IsHigherPricedLoan = v88;
                var v89 = LoanProgram; v89.Clean = value; LoanProgram = v89;
                var v90 = LoanProgramDescription; v90.Clean = value; LoanProgramDescription = v90;
                var v91 = LoanRateFixedin5Years; v91.Clean = value; LoanRateFixedin5Years = v91;
                var v92 = LOBrokerCompensationAmount; v92.Clean = value; LOBrokerCompensationAmount = v92;
                var v93 = Max5YrsHousingRatio; v93.Clean = value; Max5YrsHousingRatio = v93;
                var v94 = Max5YrsPrincipleAndInterest; v94.Clean = value; Max5YrsPrincipleAndInterest = v94;
                var v95 = Max5YrsTotalDebtRatio; v95.Clean = value; Max5YrsTotalDebtRatio = v95;
                var v96 = Max5YrsTotalPayment; v96.Clean = value; Max5YrsTotalPayment = v96;
                var v97 = MaxPrepaymentPenaltyFees; v97.Clean = value; MaxPrepaymentPenaltyFees = v97;
                var v98 = NegAmRecastDate; v98.Clean = value; NegAmRecastDate = v98;
                var v99 = PaymentDecreasedBy10Percent; v99.Clean = value; PaymentDecreasedBy10Percent = v99;
                var v100 = PointsFeesThresholdMet; v100.Clean = value; PointsFeesThresholdMet = v100;
                var v101 = PrepaymentPenaltyPayoffFees; v101.Clean = value; PrepaymentPenaltyPayoffFees = v101;
                var v102 = PrepayPenaltyPercentage; v102.Clean = value; PrepayPenaltyPercentage = v102;
                var v103 = PreventConsumersDefault; v103.Clean = value; PreventConsumersDefault = v103;
                var v104 = PrincipalBalanceIncreased; v104.Clean = value; PrincipalBalanceIncreased = v104;
                var v105 = PrincipalHasDeferred; v105.Clean = value; PrincipalHasDeferred = v105;
                var v106 = QMLoanType; v106.Clean = value; QMLoanType = v106;
                var v107 = RateReductionBasisPoints; v107.Clean = value; RateReductionBasisPoints = v107;
                var v108 = RateReductionDiscountPoints; v108.Clean = value; RateReductionDiscountPoints = v108;
                var v109 = RateReductionMaxBonaFideDiscountPoint; v109.Clean = value; RateReductionMaxBonaFideDiscountPoint = v109;
                var v110 = RealEstateFees; v110.Clean = value; RealEstateFees = v110;
                var v111 = RecastDifferencePayment; v111.Clean = value; RecastDifferencePayment = v111;
                var v112 = RegZTotalLoanAmount; v112.Clean = value; RegZTotalLoanAmount = v112;
                var v113 = RequiredServicesLenderSelectedAmt; v113.Clean = value; RequiredServicesLenderSelectedAmt = v113;
                var v114 = SmallCreditorQM_CalculatedThreshold; v114.Clean = value; SmallCreditorQM_CalculatedThreshold = v114;
                var v115 = SmallCreditorQM_Status_Alimony; v115.Clean = value; SmallCreditorQM_Status_Alimony = v115;
                var v116 = SmallCreditorQM_Status_Assets; v116.Clean = value; SmallCreditorQM_Status_Assets = v116;
                var v117 = SmallCreditorQM_Status_BalloonPayment; v117.Clean = value; SmallCreditorQM_Status_BalloonPayment = v117;
                var v118 = SmallCreditorQM_Status_ChildSupport; v118.Clean = value; SmallCreditorQM_Status_ChildSupport = v118;
                var v119 = SmallCreditorQM_Status_CoveredLoan; v119.Clean = value; SmallCreditorQM_Status_CoveredLoan = v119;
                var v120 = SmallCreditorQM_Status_DebtObligations; v120.Clean = value; SmallCreditorQM_Status_DebtObligations = v120;
                var v121 = SmallCreditorQM_Status_DTI; v121.Clean = value; SmallCreditorQM_Status_DTI = v121;
                var v122 = SmallCreditorQM_Status_Income; v122.Clean = value; SmallCreditorQM_Status_Income = v122;
                var v123 = SmallCreditorQM_Status_InterestOnly; v123.Clean = value; SmallCreditorQM_Status_InterestOnly = v123;
                var v124 = SmallCreditorQM_Status_LoanTerm; v124.Clean = value; SmallCreditorQM_Status_LoanTerm = v124;
                var v125 = SmallCreditorQM_Status_MtgRelatedObligations; v125.Clean = value; SmallCreditorQM_Status_MtgRelatedObligations = v125;
                var v126 = SmallCreditorQM_Status_NegativeAmortization; v126.Clean = value; SmallCreditorQM_Status_NegativeAmortization = v126;
                var v127 = SmallCreditorQM_Status_Overall; v127.Clean = value; SmallCreditorQM_Status_Overall = v127;
                var v128 = SmallCreditorQM_Status_PointsFeesLimit; v128.Clean = value; SmallCreditorQM_Status_PointsFeesLimit = v128;
                var v129 = SmallCreditorQM_Status_PrepaymentPenalty; v129.Clean = value; SmallCreditorQM_Status_PrepaymentPenalty = v129;
                var v130 = SmallCreditorQM_Status_ResidualIncome; v130.Clean = value; SmallCreditorQM_Status_ResidualIncome = v130;
                var v131 = SmallCreditorQM_Status_SafeHarborEligibility; v131.Clean = value; SmallCreditorQM_Status_SafeHarborEligibility = v131;
                var v132 = StandardQM_CalculatedThreshold; v132.Clean = value; StandardQM_CalculatedThreshold = v132;
                var v133 = StandardQM_Status_Alimony; v133.Clean = value; StandardQM_Status_Alimony = v133;
                var v134 = StandardQM_Status_Assets; v134.Clean = value; StandardQM_Status_Assets = v134;
                var v135 = StandardQM_Status_BalloonPayment; v135.Clean = value; StandardQM_Status_BalloonPayment = v135;
                var v136 = StandardQM_Status_ChildSupport; v136.Clean = value; StandardQM_Status_ChildSupport = v136;
                var v137 = StandardQM_Status_CoveredLoan; v137.Clean = value; StandardQM_Status_CoveredLoan = v137;
                var v138 = StandardQM_Status_CreditHistory; v138.Clean = value; StandardQM_Status_CreditHistory = v138;
                var v139 = StandardQM_Status_DebtObligations; v139.Clean = value; StandardQM_Status_DebtObligations = v139;
                var v140 = StandardQM_Status_DTI; v140.Clean = value; StandardQM_Status_DTI = v140;
                var v141 = StandardQM_Status_Employment; v141.Clean = value; StandardQM_Status_Employment = v141;
                var v142 = StandardQM_Status_Income; v142.Clean = value; StandardQM_Status_Income = v142;
                var v143 = StandardQM_Status_InterestOnly; v143.Clean = value; StandardQM_Status_InterestOnly = v143;
                var v144 = StandardQM_Status_LoanTerm; v144.Clean = value; StandardQM_Status_LoanTerm = v144;
                var v145 = StandardQM_Status_MtgRelatedObligations; v145.Clean = value; StandardQM_Status_MtgRelatedObligations = v145;
                var v146 = StandardQM_Status_NegativeAmortization; v146.Clean = value; StandardQM_Status_NegativeAmortization = v146;
                var v147 = StandardQM_Status_Overall; v147.Clean = value; StandardQM_Status_Overall = v147;
                var v148 = StandardQM_Status_PointsFeesLimit; v148.Clean = value; StandardQM_Status_PointsFeesLimit = v148;
                var v149 = StandardQM_Status_PrepaymentPenalty; v149.Clean = value; StandardQM_Status_PrepaymentPenalty = v149;
                var v150 = StandardQM_Status_ResidualIncome; v150.Clean = value; StandardQM_Status_ResidualIncome = v150;
                var v151 = StandardQM_Status_SafeHarborEligibility; v151.Clean = value; StandardQM_Status_SafeHarborEligibility = v151;
                var v152 = StandardQM_Status_SimultaneousLoan; v152.Clean = value; StandardQM_Status_SimultaneousLoan = v152;
                var v153 = StartingAdjustedRateMaxBonaFideDiscountPoint; v153.Clean = value; StartingAdjustedRateMaxBonaFideDiscountPoint = v153;
                var v154 = Status_CreditHistory; v154.Clean = value; Status_CreditHistory = v154;
                var v155 = Status_SimultaneousLoan; v155.Clean = value; Status_SimultaneousLoan = v155;
                var v156 = ThresholdExceedsQM; v156.Clean = value; ThresholdExceedsQM = v156;
                var v157 = TitleServicesLenderTitleinsuranceFee; v157.Clean = value; TitleServicesLenderTitleinsuranceFee = v157;
                var v158 = TotalCoMortgagorIncome; v158.Clean = value; TotalCoMortgagorIncome = v158;
                var v159 = TotalIncome; v159.Clean = value; TotalIncome = v159;
                var v160 = TotalPointsFeesSec32Percent; v160.Clean = value; TotalPointsFeesSec32Percent = v160;
                var v161 = TransactionExemptFromRegZ; v161.Clean = value; TransactionExemptFromRegZ = v161;
                var v162 = UnitCount; v162.Clean = value; UnitCount = v162;
                var v163 = UpfrontPMIFees; v163.Clean = value; UpfrontPMIFees = v163;
                var v164 = WithOriginalCreditor; v164.Clean = value; WithOriginalCreditor = v164;
                var v165 = WrittenApplicationDate; v165.Clean = value; WrittenApplicationDate = v165;
                _settingClean = 0;
            }
        }
    }
}