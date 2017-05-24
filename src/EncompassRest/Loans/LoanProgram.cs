using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanProgram
    {
        public Value<string> Acquisition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcquisition() => !Acquisition.Clean;
        public Value<string> AdditionalArmInformation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalArmInformation() => !AdditionalArmInformation.Clean;
        public Value<string> AllDateAndNumericalDisclosures { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAllDateAndNumericalDisclosures() => !AllDateAndNumericalDisclosures.Clean;
        public Value<decimal?> AnnualFeeNeeded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFeeNeeded() => !AnnualFeeNeeded.Clean;
        public Value<string> ArmTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArmTypeDescription() => !ArmTypeDescription.Clean;
        public Value<string> AssumptionOnYourProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssumptionOnYourProperty() => !AssumptionOnYourProperty.Clean;
        public Value<int?> BalloonLoanMaturityTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalloonLoanMaturityTermMonths() => !BalloonLoanMaturityTermMonths.Clean;
        public Value<int?> BuydownChangeFrequencyMonths1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownChangeFrequencyMonths1() => !BuydownChangeFrequencyMonths1.Clean;
        public Value<int?> BuydownChangeFrequencyMonths2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownChangeFrequencyMonths2() => !BuydownChangeFrequencyMonths2.Clean;
        public Value<int?> BuydownChangeFrequencyMonths3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownChangeFrequencyMonths3() => !BuydownChangeFrequencyMonths3.Clean;
        public Value<int?> BuydownChangeFrequencyMonths4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownChangeFrequencyMonths4() => !BuydownChangeFrequencyMonths4.Clean;
        public Value<int?> BuydownChangeFrequencyMonths5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownChangeFrequencyMonths5() => !BuydownChangeFrequencyMonths5.Clean;
        public Value<int?> BuydownChangeFrequencyMonths6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownChangeFrequencyMonths6() => !BuydownChangeFrequencyMonths6.Clean;
        public Value<decimal?> BuydownIncreaseRatePercent1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIncreaseRatePercent1() => !BuydownIncreaseRatePercent1.Clean;
        public Value<decimal?> BuydownIncreaseRatePercent2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIncreaseRatePercent2() => !BuydownIncreaseRatePercent2.Clean;
        public Value<decimal?> BuydownIncreaseRatePercent3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIncreaseRatePercent3() => !BuydownIncreaseRatePercent3.Clean;
        public Value<decimal?> BuydownIncreaseRatePercent4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIncreaseRatePercent4() => !BuydownIncreaseRatePercent4.Clean;
        public Value<decimal?> BuydownIncreaseRatePercent5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIncreaseRatePercent5() => !BuydownIncreaseRatePercent5.Clean;
        public Value<decimal?> BuydownIncreaseRatePercent6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownIncreaseRatePercent6() => !BuydownIncreaseRatePercent6.Clean;
        public Value<string> CalculateBasedOnRemainingBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCalculateBasedOnRemainingBalance() => !CalculateBasedOnRemainingBalance.Clean;
        public Value<string> ClosingCostProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostProgram() => !ClosingCostProgram.Clean;
        public Value<string> ConstructionDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionDescription() => !ConstructionDescription.Clean;
        public Value<decimal?> ConstructionInterestReserveAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionInterestReserveAmount() => !ConstructionInterestReserveAmount.Clean;
        public Value<string> ConstructionLoanMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionLoanMethod() => !ConstructionLoanMethod.Clean;
        public Value<int?> ConstructionPeriodMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionPeriodMonths() => !ConstructionPeriodMonths.Clean;
        public Value<decimal?> ConstructionRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionRate() => !ConstructionRate.Clean;
        public Value<string> Convertible { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConvertible() => !Convertible.Clean;
        public Value<string> CreditDisability { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditDisability() => !CreditDisability.Clean;
        public Value<string> CreditLifeInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditLifeInsurance() => !CreditLifeInsurance.Clean;
        public Value<string> DemandFeature { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDemandFeature() => !DemandFeature.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<string> DisclosureType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureType() => !DisclosureType.Clean;
        public Value<string> Discounted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscounted() => !Discounted.Clean;
        public Value<decimal?> DiscountedRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountedRate() => !DiscountedRate.Clean;
        public Value<string> DrawRepayPeriodTableName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawRepayPeriodTableName() => !DrawRepayPeriodTableName.Clean;
        public Value<decimal?> FhaUpfrontMiPremiumPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaUpfrontMiPremiumPercent() => !FhaUpfrontMiPremiumPercent.Clean;
        public Value<string> FloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsurance() => !FloodInsurance.Clean;
        public Value<decimal?> FloorPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloorPercent() => !FloorPercent.Clean;
        public Value<decimal?> FundingFeePaidInCash { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingFeePaidInCash() => !FundingFeePaidInCash.Clean;
        public Value<decimal?> GpmExtraPaymentForEarlyPayOff { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGpmExtraPaymentForEarlyPayOff() => !GpmExtraPaymentForEarlyPayOff.Clean;
        public Value<decimal?> GpmRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGpmRate() => !GpmRate.Clean;
        public Value<int?> GpmYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGpmYears() => !GpmYears.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> IfYouPurchase { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIfYouPurchase() => !IfYouPurchase.Clean;
        public Value<string> IfYouPurchaseType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIfYouPurchaseType() => !IfYouPurchaseType.Clean;
        public Value<decimal?> IndexCurrentValuePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexCurrentValuePercent() => !IndexCurrentValuePercent.Clean;
        public Value<decimal?> IndexMarginPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIndexMarginPercent() => !IndexMarginPercent.Clean;
        public Value<decimal?> InitialAdvanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialAdvanceAmount() => !InitialAdvanceAmount.Clean;
        public Value<int?> InterestOnlyMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyMonths() => !InterestOnlyMonths.Clean;
        public Value<int?> LateChargeDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateChargeDays() => !LateChargeDays.Clean;
        public Value<decimal?> LateChargePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateChargePercent() => !LateChargePercent.Clean;
        public Value<string> LateChargeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLateChargeType() => !LateChargeType.Clean;
        public Value<string> LenderInvestorCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderInvestorCode() => !LenderInvestorCode.Clean;
        public Value<string> LienPriorityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienPriorityType() => !LienPriorityType.Clean;
        public Value<int?> LoanAmortizationTermMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmortizationTermMonths() => !LoanAmortizationTermMonths.Clean;
        public Value<string> LoanAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmortizationType() => !LoanAmortizationType.Clean;
        public Value<string> LoanDocumentationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanDocumentationType() => !LoanDocumentationType.Clean;
        public Value<string> LoanFeaturesPaymentFrequencyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFeaturesPaymentFrequencyType() => !LoanFeaturesPaymentFrequencyType.Clean;
        public Value<string> LoanProgramName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanProgramName() => !LoanProgramName.Clean;
        public Value<string> LockField { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockField() => !LockField.Clean;
        public Value<decimal?> MaxBackRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxBackRatio() => !MaxBackRatio.Clean;
        public Value<decimal?> MaxCltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxCltv() => !MaxCltv.Clean;
        public Value<decimal?> MaxFrontRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxFrontRatio() => !MaxFrontRatio.Clean;
        public Value<decimal?> MaximumBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumBalance() => !MaximumBalance.Clean;
        public Value<decimal?> MaxLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxLoanAmount() => !MaxLoanAmount.Clean;
        public Value<decimal?> MaxLtv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxLtv() => !MaxLtv.Clean;
        public Value<string> MeansAnEstimate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMeansAnEstimate() => !MeansAnEstimate.Clean;
        public Value<string> MiCalculationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiCalculationType() => !MiCalculationType.Clean;
        public Value<string> MidpointCancellation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMidpointCancellation() => !MidpointCancellation.Clean;
        public Value<string> MinCreditScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinCreditScore() => !MinCreditScore.Clean;
        public Value<decimal?> MinimumAdvanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumAdvanceAmount() => !MinimumAdvanceAmount.Clean;
        public Value<decimal?> MinimumAllowableApr { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumAllowableApr() => !MinimumAllowableApr.Clean;
        public Value<decimal?> MinimumPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumPaymentAmount() => !MinimumPaymentAmount.Clean;
        public Value<decimal?> MinimumPaymentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumPaymentPercent() => !MinimumPaymentPercent.Clean;
        public Value<decimal?> MipPaidInCash { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMipPaidInCash() => !MipPaidInCash.Clean;
        public Value<string> Mmi { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMmi() => !Mmi.Clean;
        public Value<decimal?> MortgageInsuranceAdjustmentFactor1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceAdjustmentFactor1() => !MortgageInsuranceAdjustmentFactor1.Clean;
        public Value<decimal?> MortgageInsuranceAdjustmentFactor2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceAdjustmentFactor2() => !MortgageInsuranceAdjustmentFactor2.Clean;
        public Value<decimal?> MortgageInsuranceCancelPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceCancelPercent() => !MortgageInsuranceCancelPercent.Clean;
        public Value<decimal?> MortgageInsuranceMonthlyPayment1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceMonthlyPayment1() => !MortgageInsuranceMonthlyPayment1.Clean;
        public Value<decimal?> MortgageInsuranceMonthlyPayment2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceMonthlyPayment2() => !MortgageInsuranceMonthlyPayment2.Clean;
        public Value<int?> MortgageInsuranceMonthsOfAdjustment1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceMonthsOfAdjustment1() => !MortgageInsuranceMonthsOfAdjustment1.Clean;
        public Value<int?> MortgageInsuranceMonthsOfAdjustment2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageInsuranceMonthsOfAdjustment2() => !MortgageInsuranceMonthsOfAdjustment2.Clean;
        public Value<string> MortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageType() => !MortgageType.Clean;
        public Value<string> OtherAmortizationTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAmortizationTypeDescription() => !OtherAmortizationTypeDescription.Clean;
        public Value<string> OtherLoanPurposeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherLoanPurposeDescription() => !OtherLoanPurposeDescription.Clean;
        public Value<string> OtherMortgageTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherMortgageTypeDescription() => !OtherMortgageTypeDescription.Clean;
        public Value<int?> PaymentAdjustmentDurationMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentAdjustmentDurationMonths() => !PaymentAdjustmentDurationMonths.Clean;
        public Value<decimal?> PaymentAdjustmentPeriodicCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentAdjustmentPeriodicCapPercent() => !PaymentAdjustmentPeriodicCapPercent.Clean;
        public Value<decimal?> PaymentFactor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentFactor() => !PaymentFactor.Clean;
        public Value<decimal?> PercentageOfRental { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentageOfRental() => !PercentageOfRental.Clean;
        public Value<string> PerDiemCalculationMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerDiemCalculationMethodType() => !PerDiemCalculationMethodType.Clean;
        public Value<string> Pmi { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePmi() => !Pmi.Clean;
        public Value<string> PrepaymentPenaltyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyIndicator() => !PrepaymentPenaltyIndicator.Clean;
        public Value<string> ProgramCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProgramCode() => !ProgramCode.Clean;
        public Value<string> PropertyInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyInsurance() => !PropertyInsurance.Clean;
        public Value<string> PropertyUsageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyUsageType() => !PropertyUsageType.Clean;
        public Value<decimal?> QualifyingRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQualifyingRatePercent() => !QualifyingRatePercent.Clean;
        public Value<int?> RateAdjustmentDurationMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentDurationMonths() => !RateAdjustmentDurationMonths.Clean;
        public Value<decimal?> RateAdjustmentLifetimeCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentLifetimeCapPercent() => !RateAdjustmentLifetimeCapPercent.Clean;
        public Value<decimal?> RateAdjustmentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentPercent() => !RateAdjustmentPercent.Clean;
        public Value<decimal?> RateAdjustmentSubsequentCapPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentSubsequentCapPercent() => !RateAdjustmentSubsequentCapPercent.Clean;
        public Value<int?> RateAdjustmentSubsequentRateAdjustmentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateAdjustmentSubsequentRateAdjustmentMonths() => !RateAdjustmentSubsequentRateAdjustmentMonths.Clean;
        public Value<int?> RecastPaidMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecastPaidMonths() => !RecastPaidMonths.Clean;
        public Value<int?> RecastStopMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecastStopMonths() => !RecastStopMonths.Clean;
        public Value<string> RefundPaymentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefundPaymentIndicator() => !RefundPaymentIndicator.Clean;
        public Value<decimal?> RequestedInterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequestedInterestRatePercent() => !RequestedInterestRatePercent.Clean;
        public Value<string> RequiredDeposit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredDeposit() => !RequiredDeposit.Clean;
        public Value<decimal?> RoundPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundPercent() => !RoundPercent.Clean;
        public Value<string> RoundType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundType() => !RoundType.Clean;
        public Value<string> SecurityInterestInNameOf { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecurityInterestInNameOf() => !SecurityInterestInNameOf.Clean;
        public Value<string> SecurityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecurityType() => !SecurityType.Clean;
        public Value<decimal?> SubjectPropertyGrossRentalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubjectPropertyGrossRentalIncome() => !SubjectPropertyGrossRentalIncome.Clean;
        public Value<decimal?> TeaserRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTeaserRate() => !TeaserRate.Clean;
        public Value<decimal?> TerminationFeeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTerminationFeeAmount() => !TerminationFeeAmount.Clean;
        public Value<int?> TerminationPeriodMonthsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTerminationPeriodMonthsCount() => !TerminationPeriodMonthsCount.Clean;
        public Value<decimal?> ThirdPartyFeeFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyFeeFrom() => !ThirdPartyFeeFrom.Clean;
        public Value<decimal?> ThirdPartyFeeTo { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyFeeTo() => !ThirdPartyFeeTo.Clean;
        public Value<string> Type { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeType() => !Type.Clean;
        public Value<string> UseDaysInYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUseDaysInYears() => !UseDaysInYears.Clean;
        public Value<string> UsePitiForRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUsePitiForRatio() => !UsePitiForRatio.Clean;
        public Value<string> VariableRateFeature { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVariableRateFeature() => !VariableRateFeature.Clean;
        public Value<decimal?> YearlyTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyTerm() => !YearlyTerm.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Acquisition.Clean
                    && AdditionalArmInformation.Clean
                    && AllDateAndNumericalDisclosures.Clean
                    && AnnualFeeNeeded.Clean
                    && ArmTypeDescription.Clean
                    && AssumptionOnYourProperty.Clean
                    && BalloonLoanMaturityTermMonths.Clean
                    && BuydownChangeFrequencyMonths1.Clean
                    && BuydownChangeFrequencyMonths2.Clean
                    && BuydownChangeFrequencyMonths3.Clean
                    && BuydownChangeFrequencyMonths4.Clean
                    && BuydownChangeFrequencyMonths5.Clean
                    && BuydownChangeFrequencyMonths6.Clean
                    && BuydownIncreaseRatePercent1.Clean
                    && BuydownIncreaseRatePercent2.Clean
                    && BuydownIncreaseRatePercent3.Clean
                    && BuydownIncreaseRatePercent4.Clean
                    && BuydownIncreaseRatePercent5.Clean
                    && BuydownIncreaseRatePercent6.Clean
                    && CalculateBasedOnRemainingBalance.Clean
                    && ClosingCostProgram.Clean
                    && ConstructionDescription.Clean
                    && ConstructionInterestReserveAmount.Clean
                    && ConstructionLoanMethod.Clean
                    && ConstructionPeriodMonths.Clean
                    && ConstructionRate.Clean
                    && Convertible.Clean
                    && CreditDisability.Clean
                    && CreditLifeInsurance.Clean
                    && DemandFeature.Clean
                    && Description.Clean
                    && DisclosureType.Clean
                    && Discounted.Clean
                    && DiscountedRate.Clean
                    && DrawRepayPeriodTableName.Clean
                    && FhaUpfrontMiPremiumPercent.Clean
                    && FloodInsurance.Clean
                    && FloorPercent.Clean
                    && FundingFeePaidInCash.Clean
                    && GpmExtraPaymentForEarlyPayOff.Clean
                    && GpmRate.Clean
                    && GpmYears.Clean
                    && Id.Clean
                    && IfYouPurchase.Clean
                    && IfYouPurchaseType.Clean
                    && IndexCurrentValuePercent.Clean
                    && IndexMarginPercent.Clean
                    && InitialAdvanceAmount.Clean
                    && InterestOnlyMonths.Clean
                    && LateChargeDays.Clean
                    && LateChargePercent.Clean
                    && LateChargeType.Clean
                    && LenderInvestorCode.Clean
                    && LienPriorityType.Clean
                    && LoanAmortizationTermMonths.Clean
                    && LoanAmortizationType.Clean
                    && LoanDocumentationType.Clean
                    && LoanFeaturesPaymentFrequencyType.Clean
                    && LoanProgramName.Clean
                    && LockField.Clean
                    && MaxBackRatio.Clean
                    && MaxCltv.Clean
                    && MaxFrontRatio.Clean
                    && MaximumBalance.Clean
                    && MaxLoanAmount.Clean
                    && MaxLtv.Clean
                    && MeansAnEstimate.Clean
                    && MiCalculationType.Clean
                    && MidpointCancellation.Clean
                    && MinCreditScore.Clean
                    && MinimumAdvanceAmount.Clean
                    && MinimumAllowableApr.Clean
                    && MinimumPaymentAmount.Clean
                    && MinimumPaymentPercent.Clean
                    && MipPaidInCash.Clean
                    && Mmi.Clean
                    && MortgageInsuranceAdjustmentFactor1.Clean
                    && MortgageInsuranceAdjustmentFactor2.Clean
                    && MortgageInsuranceCancelPercent.Clean
                    && MortgageInsuranceMonthlyPayment1.Clean
                    && MortgageInsuranceMonthlyPayment2.Clean
                    && MortgageInsuranceMonthsOfAdjustment1.Clean
                    && MortgageInsuranceMonthsOfAdjustment2.Clean
                    && MortgageType.Clean
                    && OtherAmortizationTypeDescription.Clean
                    && OtherLoanPurposeDescription.Clean
                    && OtherMortgageTypeDescription.Clean
                    && PaymentAdjustmentDurationMonths.Clean
                    && PaymentAdjustmentPeriodicCapPercent.Clean
                    && PaymentFactor.Clean
                    && PercentageOfRental.Clean
                    && PerDiemCalculationMethodType.Clean
                    && Pmi.Clean
                    && PrepaymentPenaltyIndicator.Clean
                    && ProgramCode.Clean
                    && PropertyInsurance.Clean
                    && PropertyUsageType.Clean
                    && QualifyingRatePercent.Clean
                    && RateAdjustmentDurationMonths.Clean
                    && RateAdjustmentLifetimeCapPercent.Clean
                    && RateAdjustmentPercent.Clean
                    && RateAdjustmentSubsequentCapPercent.Clean
                    && RateAdjustmentSubsequentRateAdjustmentMonths.Clean
                    && RecastPaidMonths.Clean
                    && RecastStopMonths.Clean
                    && RefundPaymentIndicator.Clean
                    && RequestedInterestRatePercent.Clean
                    && RequiredDeposit.Clean
                    && RoundPercent.Clean
                    && RoundType.Clean
                    && SecurityInterestInNameOf.Clean
                    && SecurityType.Clean
                    && SubjectPropertyGrossRentalIncome.Clean
                    && TeaserRate.Clean
                    && TerminationFeeAmount.Clean
                    && TerminationPeriodMonthsCount.Clean
                    && ThirdPartyFeeFrom.Clean
                    && ThirdPartyFeeTo.Clean
                    && Type.Clean
                    && UseDaysInYears.Clean
                    && UsePitiForRatio.Clean
                    && VariableRateFeature.Clean
                    && YearlyTerm.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Acquisition; v0.Clean = value; Acquisition = v0;
                var v1 = AdditionalArmInformation; v1.Clean = value; AdditionalArmInformation = v1;
                var v2 = AllDateAndNumericalDisclosures; v2.Clean = value; AllDateAndNumericalDisclosures = v2;
                var v3 = AnnualFeeNeeded; v3.Clean = value; AnnualFeeNeeded = v3;
                var v4 = ArmTypeDescription; v4.Clean = value; ArmTypeDescription = v4;
                var v5 = AssumptionOnYourProperty; v5.Clean = value; AssumptionOnYourProperty = v5;
                var v6 = BalloonLoanMaturityTermMonths; v6.Clean = value; BalloonLoanMaturityTermMonths = v6;
                var v7 = BuydownChangeFrequencyMonths1; v7.Clean = value; BuydownChangeFrequencyMonths1 = v7;
                var v8 = BuydownChangeFrequencyMonths2; v8.Clean = value; BuydownChangeFrequencyMonths2 = v8;
                var v9 = BuydownChangeFrequencyMonths3; v9.Clean = value; BuydownChangeFrequencyMonths3 = v9;
                var v10 = BuydownChangeFrequencyMonths4; v10.Clean = value; BuydownChangeFrequencyMonths4 = v10;
                var v11 = BuydownChangeFrequencyMonths5; v11.Clean = value; BuydownChangeFrequencyMonths5 = v11;
                var v12 = BuydownChangeFrequencyMonths6; v12.Clean = value; BuydownChangeFrequencyMonths6 = v12;
                var v13 = BuydownIncreaseRatePercent1; v13.Clean = value; BuydownIncreaseRatePercent1 = v13;
                var v14 = BuydownIncreaseRatePercent2; v14.Clean = value; BuydownIncreaseRatePercent2 = v14;
                var v15 = BuydownIncreaseRatePercent3; v15.Clean = value; BuydownIncreaseRatePercent3 = v15;
                var v16 = BuydownIncreaseRatePercent4; v16.Clean = value; BuydownIncreaseRatePercent4 = v16;
                var v17 = BuydownIncreaseRatePercent5; v17.Clean = value; BuydownIncreaseRatePercent5 = v17;
                var v18 = BuydownIncreaseRatePercent6; v18.Clean = value; BuydownIncreaseRatePercent6 = v18;
                var v19 = CalculateBasedOnRemainingBalance; v19.Clean = value; CalculateBasedOnRemainingBalance = v19;
                var v20 = ClosingCostProgram; v20.Clean = value; ClosingCostProgram = v20;
                var v21 = ConstructionDescription; v21.Clean = value; ConstructionDescription = v21;
                var v22 = ConstructionInterestReserveAmount; v22.Clean = value; ConstructionInterestReserveAmount = v22;
                var v23 = ConstructionLoanMethod; v23.Clean = value; ConstructionLoanMethod = v23;
                var v24 = ConstructionPeriodMonths; v24.Clean = value; ConstructionPeriodMonths = v24;
                var v25 = ConstructionRate; v25.Clean = value; ConstructionRate = v25;
                var v26 = Convertible; v26.Clean = value; Convertible = v26;
                var v27 = CreditDisability; v27.Clean = value; CreditDisability = v27;
                var v28 = CreditLifeInsurance; v28.Clean = value; CreditLifeInsurance = v28;
                var v29 = DemandFeature; v29.Clean = value; DemandFeature = v29;
                var v30 = Description; v30.Clean = value; Description = v30;
                var v31 = DisclosureType; v31.Clean = value; DisclosureType = v31;
                var v32 = Discounted; v32.Clean = value; Discounted = v32;
                var v33 = DiscountedRate; v33.Clean = value; DiscountedRate = v33;
                var v34 = DrawRepayPeriodTableName; v34.Clean = value; DrawRepayPeriodTableName = v34;
                var v35 = FhaUpfrontMiPremiumPercent; v35.Clean = value; FhaUpfrontMiPremiumPercent = v35;
                var v36 = FloodInsurance; v36.Clean = value; FloodInsurance = v36;
                var v37 = FloorPercent; v37.Clean = value; FloorPercent = v37;
                var v38 = FundingFeePaidInCash; v38.Clean = value; FundingFeePaidInCash = v38;
                var v39 = GpmExtraPaymentForEarlyPayOff; v39.Clean = value; GpmExtraPaymentForEarlyPayOff = v39;
                var v40 = GpmRate; v40.Clean = value; GpmRate = v40;
                var v41 = GpmYears; v41.Clean = value; GpmYears = v41;
                var v42 = Id; v42.Clean = value; Id = v42;
                var v43 = IfYouPurchase; v43.Clean = value; IfYouPurchase = v43;
                var v44 = IfYouPurchaseType; v44.Clean = value; IfYouPurchaseType = v44;
                var v45 = IndexCurrentValuePercent; v45.Clean = value; IndexCurrentValuePercent = v45;
                var v46 = IndexMarginPercent; v46.Clean = value; IndexMarginPercent = v46;
                var v47 = InitialAdvanceAmount; v47.Clean = value; InitialAdvanceAmount = v47;
                var v48 = InterestOnlyMonths; v48.Clean = value; InterestOnlyMonths = v48;
                var v49 = LateChargeDays; v49.Clean = value; LateChargeDays = v49;
                var v50 = LateChargePercent; v50.Clean = value; LateChargePercent = v50;
                var v51 = LateChargeType; v51.Clean = value; LateChargeType = v51;
                var v52 = LenderInvestorCode; v52.Clean = value; LenderInvestorCode = v52;
                var v53 = LienPriorityType; v53.Clean = value; LienPriorityType = v53;
                var v54 = LoanAmortizationTermMonths; v54.Clean = value; LoanAmortizationTermMonths = v54;
                var v55 = LoanAmortizationType; v55.Clean = value; LoanAmortizationType = v55;
                var v56 = LoanDocumentationType; v56.Clean = value; LoanDocumentationType = v56;
                var v57 = LoanFeaturesPaymentFrequencyType; v57.Clean = value; LoanFeaturesPaymentFrequencyType = v57;
                var v58 = LoanProgramName; v58.Clean = value; LoanProgramName = v58;
                var v59 = LockField; v59.Clean = value; LockField = v59;
                var v60 = MaxBackRatio; v60.Clean = value; MaxBackRatio = v60;
                var v61 = MaxCltv; v61.Clean = value; MaxCltv = v61;
                var v62 = MaxFrontRatio; v62.Clean = value; MaxFrontRatio = v62;
                var v63 = MaximumBalance; v63.Clean = value; MaximumBalance = v63;
                var v64 = MaxLoanAmount; v64.Clean = value; MaxLoanAmount = v64;
                var v65 = MaxLtv; v65.Clean = value; MaxLtv = v65;
                var v66 = MeansAnEstimate; v66.Clean = value; MeansAnEstimate = v66;
                var v67 = MiCalculationType; v67.Clean = value; MiCalculationType = v67;
                var v68 = MidpointCancellation; v68.Clean = value; MidpointCancellation = v68;
                var v69 = MinCreditScore; v69.Clean = value; MinCreditScore = v69;
                var v70 = MinimumAdvanceAmount; v70.Clean = value; MinimumAdvanceAmount = v70;
                var v71 = MinimumAllowableApr; v71.Clean = value; MinimumAllowableApr = v71;
                var v72 = MinimumPaymentAmount; v72.Clean = value; MinimumPaymentAmount = v72;
                var v73 = MinimumPaymentPercent; v73.Clean = value; MinimumPaymentPercent = v73;
                var v74 = MipPaidInCash; v74.Clean = value; MipPaidInCash = v74;
                var v75 = Mmi; v75.Clean = value; Mmi = v75;
                var v76 = MortgageInsuranceAdjustmentFactor1; v76.Clean = value; MortgageInsuranceAdjustmentFactor1 = v76;
                var v77 = MortgageInsuranceAdjustmentFactor2; v77.Clean = value; MortgageInsuranceAdjustmentFactor2 = v77;
                var v78 = MortgageInsuranceCancelPercent; v78.Clean = value; MortgageInsuranceCancelPercent = v78;
                var v79 = MortgageInsuranceMonthlyPayment1; v79.Clean = value; MortgageInsuranceMonthlyPayment1 = v79;
                var v80 = MortgageInsuranceMonthlyPayment2; v80.Clean = value; MortgageInsuranceMonthlyPayment2 = v80;
                var v81 = MortgageInsuranceMonthsOfAdjustment1; v81.Clean = value; MortgageInsuranceMonthsOfAdjustment1 = v81;
                var v82 = MortgageInsuranceMonthsOfAdjustment2; v82.Clean = value; MortgageInsuranceMonthsOfAdjustment2 = v82;
                var v83 = MortgageType; v83.Clean = value; MortgageType = v83;
                var v84 = OtherAmortizationTypeDescription; v84.Clean = value; OtherAmortizationTypeDescription = v84;
                var v85 = OtherLoanPurposeDescription; v85.Clean = value; OtherLoanPurposeDescription = v85;
                var v86 = OtherMortgageTypeDescription; v86.Clean = value; OtherMortgageTypeDescription = v86;
                var v87 = PaymentAdjustmentDurationMonths; v87.Clean = value; PaymentAdjustmentDurationMonths = v87;
                var v88 = PaymentAdjustmentPeriodicCapPercent; v88.Clean = value; PaymentAdjustmentPeriodicCapPercent = v88;
                var v89 = PaymentFactor; v89.Clean = value; PaymentFactor = v89;
                var v90 = PercentageOfRental; v90.Clean = value; PercentageOfRental = v90;
                var v91 = PerDiemCalculationMethodType; v91.Clean = value; PerDiemCalculationMethodType = v91;
                var v92 = Pmi; v92.Clean = value; Pmi = v92;
                var v93 = PrepaymentPenaltyIndicator; v93.Clean = value; PrepaymentPenaltyIndicator = v93;
                var v94 = ProgramCode; v94.Clean = value; ProgramCode = v94;
                var v95 = PropertyInsurance; v95.Clean = value; PropertyInsurance = v95;
                var v96 = PropertyUsageType; v96.Clean = value; PropertyUsageType = v96;
                var v97 = QualifyingRatePercent; v97.Clean = value; QualifyingRatePercent = v97;
                var v98 = RateAdjustmentDurationMonths; v98.Clean = value; RateAdjustmentDurationMonths = v98;
                var v99 = RateAdjustmentLifetimeCapPercent; v99.Clean = value; RateAdjustmentLifetimeCapPercent = v99;
                var v100 = RateAdjustmentPercent; v100.Clean = value; RateAdjustmentPercent = v100;
                var v101 = RateAdjustmentSubsequentCapPercent; v101.Clean = value; RateAdjustmentSubsequentCapPercent = v101;
                var v102 = RateAdjustmentSubsequentRateAdjustmentMonths; v102.Clean = value; RateAdjustmentSubsequentRateAdjustmentMonths = v102;
                var v103 = RecastPaidMonths; v103.Clean = value; RecastPaidMonths = v103;
                var v104 = RecastStopMonths; v104.Clean = value; RecastStopMonths = v104;
                var v105 = RefundPaymentIndicator; v105.Clean = value; RefundPaymentIndicator = v105;
                var v106 = RequestedInterestRatePercent; v106.Clean = value; RequestedInterestRatePercent = v106;
                var v107 = RequiredDeposit; v107.Clean = value; RequiredDeposit = v107;
                var v108 = RoundPercent; v108.Clean = value; RoundPercent = v108;
                var v109 = RoundType; v109.Clean = value; RoundType = v109;
                var v110 = SecurityInterestInNameOf; v110.Clean = value; SecurityInterestInNameOf = v110;
                var v111 = SecurityType; v111.Clean = value; SecurityType = v111;
                var v112 = SubjectPropertyGrossRentalIncome; v112.Clean = value; SubjectPropertyGrossRentalIncome = v112;
                var v113 = TeaserRate; v113.Clean = value; TeaserRate = v113;
                var v114 = TerminationFeeAmount; v114.Clean = value; TerminationFeeAmount = v114;
                var v115 = TerminationPeriodMonthsCount; v115.Clean = value; TerminationPeriodMonthsCount = v115;
                var v116 = ThirdPartyFeeFrom; v116.Clean = value; ThirdPartyFeeFrom = v116;
                var v117 = ThirdPartyFeeTo; v117.Clean = value; ThirdPartyFeeTo = v117;
                var v118 = Type; v118.Clean = value; Type = v118;
                var v119 = UseDaysInYears; v119.Clean = value; UseDaysInYears = v119;
                var v120 = UsePitiForRatio; v120.Clean = value; UsePitiForRatio = v120;
                var v121 = VariableRateFeature; v121.Clean = value; VariableRateFeature = v121;
                var v122 = YearlyTerm; v122.Clean = value; YearlyTerm = v122;
                _settingClean = 0;
            }
        }
    }
}