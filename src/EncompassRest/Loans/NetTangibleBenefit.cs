using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class NetTangibleBenefit
    {
        public Value<bool?> AprNotExceedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAprNotExceedIndicator() => !AprNotExceedIndicator.Clean;
        public Value<bool?> AvoidingForeclosureIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAvoidingForeclosureIndicator() => !AvoidingForeclosureIndicator.Clean;
        public Value<bool?> BeneficialChangedForBorrowerIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBeneficialChangedForBorrowerIndicator() => !BeneficialChangedForBorrowerIndicator.Clean;
        public Value<string> BonaFideFinancialEmergency { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBonaFideFinancialEmergency() => !BonaFideFinancialEmergency.Clean;
        public Value<bool?> BorrowerCanRecoupCostofRefinancingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerCanRecoupCostofRefinancingIndicator() => !BorrowerCanRecoupCostofRefinancingIndicator.Clean;
        public Value<bool?> BorrowerCanRecoupIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerCanRecoupIndicator() => !BorrowerCanRecoupIndicator.Clean;
        public Value<bool?> BorrowerMonthlyPaymentLowerThan20Indicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerMonthlyPaymentLowerThan20Indicator() => !BorrowerMonthlyPaymentLowerThan20Indicator.Clean;
        public Value<string> BorrowerReceivedReasonable { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerReceivedReasonable() => !BorrowerReceivedReasonable.Clean;
        public Value<bool?> BorrowerReceivesAmountExcessCostAndFeesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerReceivesAmountExcessCostAndFeesIndicator() => !BorrowerReceivesAmountExcessCostAndFeesIndicator.Clean;
        public Value<bool?> ChangeLoanFromArmtoFixedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangeLoanFromArmtoFixedIndicator() => !ChangeLoanFromArmtoFixedIndicator.Clean;
        public Value<bool?> ChangingLoanToFixedRateIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChangingLoanToFixedRateIndicator() => !ChangingLoanToFixedRateIndicator.Clean;
        public Value<bool?> ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConsolidatingOtherExistingLoansIntoNewLoanIndicator() => !ConsolidatingOtherExistingLoansIntoNewLoanIndicator.Clean;
        public Value<bool?> EliminatingBalloonPaymentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEliminatingBalloonPaymentIndicator() => !EliminatingBalloonPaymentIndicator.Clean;
        public Value<bool?> EliminatingNegArmIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEliminatingNegArmIndicator() => !EliminatingNegArmIndicator.Clean;
        public Value<bool?> EliminatingPrivateMortgageInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEliminatingPrivateMortgageInsuranceIndicator() => !EliminatingPrivateMortgageInsuranceIndicator.Clean;
        public Value<decimal?> ExistingLoanAprPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanAprPercent() => !ExistingLoanAprPercent.Clean;
        public Value<bool?> ExistingLoanBalloonIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanBalloonIndicator() => !ExistingLoanBalloonIndicator.Clean;
        public Value<decimal?> ExistingLoanBorrowerReceivesCashOutAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanBorrowerReceivesCashOutAmount() => !ExistingLoanBorrowerReceivesCashOutAmount.Clean;
        public Value<bool?> ExistingLoanBorrowerReceivesCashOutIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanBorrowerReceivesCashOutIndicator() => !ExistingLoanBorrowerReceivesCashOutIndicator.Clean;
        public Value<decimal?> ExistingLoanBottomRatioPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanBottomRatioPercent() => !ExistingLoanBottomRatioPercent.Clean;
        public Value<DateTime?> ExistingLoanDateLoanClosed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanDateLoanClosed() => !ExistingLoanDateLoanClosed.Clean;
        public Value<decimal?> ExistingLoanFullyIndexRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanFullyIndexRatePercent() => !ExistingLoanFullyIndexRatePercent.Clean;
        public Value<decimal?> ExistingLoanInterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanInterestRatePercent() => !ExistingLoanInterestRatePercent.Clean;
        public Value<bool?> ExistingLoanIsGuaranteedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanIsGuaranteedIndicator() => !ExistingLoanIsGuaranteedIndicator.Clean;
        public Value<bool?> ExistingLoanIsLoanRefinancedAsSpecial { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanIsLoanRefinancedAsSpecial() => !ExistingLoanIsLoanRefinancedAsSpecial.Clean;
        public Value<bool?> ExistingLoanIsNegativeAmortizationFeatureIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanIsNegativeAmortizationFeatureIndicator() => !ExistingLoanIsNegativeAmortizationFeatureIndicator.Clean;
        public Value<bool?> ExistingLoanIsPrepaymentPenalty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanIsPrepaymentPenalty() => !ExistingLoanIsPrepaymentPenalty.Clean;
        public Value<string> ExistingLoanLoanAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanLoanAmortizationType() => !ExistingLoanLoanAmortizationType.Clean;
        public Value<decimal?> ExistingLoanLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanLoanAmount() => !ExistingLoanLoanAmount.Clean;
        public Value<int?> ExistingLoanLoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanLoanTerm() => !ExistingLoanLoanTerm.Clean;
        public Value<decimal?> ExistingLoanLtvPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanLtvPercent() => !ExistingLoanLtvPercent.Clean;
        public Value<decimal?> ExistingLoanMaximumRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanMaximumRatePercent() => !ExistingLoanMaximumRatePercent.Clean;
        public Value<int?> ExistingLoanMonthsRemaining { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanMonthsRemaining() => !ExistingLoanMonthsRemaining.Clean;
        public Value<decimal?> ExistingLoanPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPaymentAmount() => !ExistingLoanPaymentAmount.Clean;
        public Value<decimal?> ExistingLoanPaymentDifference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPaymentDifference() => !ExistingLoanPaymentDifference.Clean;
        public Value<decimal?> ExistingLoanPaymentIncludeMiObligation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPaymentIncludeMiObligation() => !ExistingLoanPaymentIncludeMiObligation.Clean;
        public Value<decimal?> ExistingLoanPaymentIncludeMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPaymentIncludeMortgageInsurance() => !ExistingLoanPaymentIncludeMortgageInsurance.Clean;
        public Value<decimal?> ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan() => !ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan.Clean;
        public Value<string> ExistingLoanPrepaymentPenaltyBasedOn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPrepaymentPenaltyBasedOn() => !ExistingLoanPrepaymentPenaltyBasedOn.Clean;
        public Value<decimal?> ExistingLoanPrepaymentPenaltyPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPrepaymentPenaltyPercentage() => !ExistingLoanPrepaymentPenaltyPercentage.Clean;
        public Value<int?> ExistingLoanPrepaymentPenaltyTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPrepaymentPenaltyTerm() => !ExistingLoanPrepaymentPenaltyTerm.Clean;
        public Value<string> ExistingLoanProvidedByLicenseeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanProvidedByLicenseeType() => !ExistingLoanProvidedByLicenseeType.Clean;
        public Value<string> ExistingLoanPurposeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanPurposeType() => !ExistingLoanPurposeType.Clean;
        public Value<int?> ExistingLoanRecoupCostsYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanRecoupCostsYears() => !ExistingLoanRecoupCostsYears.Clean;
        public Value<decimal?> ExistingLoanSavingsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanSavingsAmount() => !ExistingLoanSavingsAmount.Clean;
        public Value<decimal?> ExistingLoanTotalDebtPayoff { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanTotalDebtPayoff() => !ExistingLoanTotalDebtPayoff.Clean;
        public Value<decimal?> ExistingLoanWeightedAverageInterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExistingLoanWeightedAverageInterestRatePercent() => !ExistingLoanWeightedAverageInterestRatePercent.Clean;
        public Value<bool?> HomeLoanComplianceWith209 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeLoanComplianceWith209() => !HomeLoanComplianceWith209.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> LenderDeterminedBorrowersInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderDeterminedBorrowersInterest() => !LenderDeterminedBorrowersInterest.Clean;
        public Value<bool?> NewLoanIsGuaranteedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewLoanIsGuaranteedIndicator() => !NewLoanIsGuaranteedIndicator.Clean;
        public Value<bool?> NewLoanIsNegativeAmortizationFeatureIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewLoanIsNegativeAmortizationFeatureIndicator() => !NewLoanIsNegativeAmortizationFeatureIndicator.Clean;
        public Value<bool?> NewLoanIsSafeHarborQM { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewLoanIsSafeHarborQM() => !NewLoanIsSafeHarborQM.Clean;
        public Value<bool?> NewLoanIsSpecialMortgageOriginatedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewLoanIsSpecialMortgageOriginatedIndicator() => !NewLoanIsSpecialMortgageOriginatedIndicator.Clean;
        public Value<decimal?> NewLoanPaymentWithMiDifference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewLoanPaymentWithMiDifference() => !NewLoanPaymentWithMiDifference.Clean;
        public Value<decimal?> NewLoanPaymentWithObligationDifference { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewLoanPaymentWithObligationDifference() => !NewLoanPaymentWithObligationDifference.Clean;
        public Value<bool?> NewLoanPayOffConsolidateDebtIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewLoanPayOffConsolidateDebtIndicator() => !NewLoanPayOffConsolidateDebtIndicator.Clean;
        public Value<decimal?> NewLoanWeightedAverageInterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewLoanWeightedAverageInterestRatePercent() => !NewLoanWeightedAverageInterestRatePercent.Clean;
        public Value<bool?> ObtainingLowerIntMonthlyPaymentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeObtainingLowerIntMonthlyPaymentIndicator() => !ObtainingLowerIntMonthlyPaymentIndicator.Clean;
        public Value<bool?> ObtainingLowerIntRateIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeObtainingLowerIntRateIndicator() => !ObtainingLowerIntRateIndicator.Clean;
        public Value<bool?> ObtainingShortAmortScheduleIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeObtainingShortAmortScheduleIndicator() => !ObtainingShortAmortScheduleIndicator.Clean;
        public Value<bool?> OtherReason { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherReason() => !OtherReason.Clean;
        public Value<string> OtherReasonDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherReasonDescription() => !OtherReasonDescription.Clean;
        public Value<bool?> PrintBorrowerInitialLinesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintBorrowerInitialLinesIndicator() => !PrintBorrowerInitialLinesIndicator.Clean;
        public Value<bool?> ProceedsOfNewLoanWillBeUsedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProceedsOfNewLoanWillBeUsedIndicator() => !ProceedsOfNewLoanWillBeUsedIndicator.Clean;
        public Value<bool?> ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator() => !ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator.Clean;
        public Value<bool?> RefinancingLoanIsHomeEquityIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancingLoanIsHomeEquityIndicator() => !RefinancingLoanIsHomeEquityIndicator.Clean;
        public Value<bool?> RefinancingRespondBonaFide { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinancingRespondBonaFide() => !RefinancingRespondBonaFide.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AprNotExceedIndicator.Clean
                    && AvoidingForeclosureIndicator.Clean
                    && BeneficialChangedForBorrowerIndicator.Clean
                    && BonaFideFinancialEmergency.Clean
                    && BorrowerCanRecoupCostofRefinancingIndicator.Clean
                    && BorrowerCanRecoupIndicator.Clean
                    && BorrowerMonthlyPaymentLowerThan20Indicator.Clean
                    && BorrowerReceivedReasonable.Clean
                    && BorrowerReceivesAmountExcessCostAndFeesIndicator.Clean
                    && ChangeLoanFromArmtoFixedIndicator.Clean
                    && ChangingLoanToFixedRateIndicator.Clean
                    && ConsolidatingOtherExistingLoansIntoNewLoanIndicator.Clean
                    && EliminatingBalloonPaymentIndicator.Clean
                    && EliminatingNegArmIndicator.Clean
                    && EliminatingPrivateMortgageInsuranceIndicator.Clean
                    && ExistingLoanAprPercent.Clean
                    && ExistingLoanBalloonIndicator.Clean
                    && ExistingLoanBorrowerReceivesCashOutAmount.Clean
                    && ExistingLoanBorrowerReceivesCashOutIndicator.Clean
                    && ExistingLoanBottomRatioPercent.Clean
                    && ExistingLoanDateLoanClosed.Clean
                    && ExistingLoanFullyIndexRatePercent.Clean
                    && ExistingLoanInterestRatePercent.Clean
                    && ExistingLoanIsGuaranteedIndicator.Clean
                    && ExistingLoanIsLoanRefinancedAsSpecial.Clean
                    && ExistingLoanIsNegativeAmortizationFeatureIndicator.Clean
                    && ExistingLoanIsPrepaymentPenalty.Clean
                    && ExistingLoanLoanAmortizationType.Clean
                    && ExistingLoanLoanAmount.Clean
                    && ExistingLoanLoanTerm.Clean
                    && ExistingLoanLtvPercent.Clean
                    && ExistingLoanMaximumRatePercent.Clean
                    && ExistingLoanMonthsRemaining.Clean
                    && ExistingLoanPaymentAmount.Clean
                    && ExistingLoanPaymentDifference.Clean
                    && ExistingLoanPaymentIncludeMiObligation.Clean
                    && ExistingLoanPaymentIncludeMortgageInsurance.Clean
                    && ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan.Clean
                    && ExistingLoanPrepaymentPenaltyBasedOn.Clean
                    && ExistingLoanPrepaymentPenaltyPercentage.Clean
                    && ExistingLoanPrepaymentPenaltyTerm.Clean
                    && ExistingLoanProvidedByLicenseeType.Clean
                    && ExistingLoanPurposeType.Clean
                    && ExistingLoanRecoupCostsYears.Clean
                    && ExistingLoanSavingsAmount.Clean
                    && ExistingLoanTotalDebtPayoff.Clean
                    && ExistingLoanWeightedAverageInterestRatePercent.Clean
                    && HomeLoanComplianceWith209.Clean
                    && Id.Clean
                    && LenderDeterminedBorrowersInterest.Clean
                    && NewLoanIsGuaranteedIndicator.Clean
                    && NewLoanIsNegativeAmortizationFeatureIndicator.Clean
                    && NewLoanIsSafeHarborQM.Clean
                    && NewLoanIsSpecialMortgageOriginatedIndicator.Clean
                    && NewLoanPaymentWithMiDifference.Clean
                    && NewLoanPaymentWithObligationDifference.Clean
                    && NewLoanPayOffConsolidateDebtIndicator.Clean
                    && NewLoanWeightedAverageInterestRatePercent.Clean
                    && ObtainingLowerIntMonthlyPaymentIndicator.Clean
                    && ObtainingLowerIntRateIndicator.Clean
                    && ObtainingShortAmortScheduleIndicator.Clean
                    && OtherReason.Clean
                    && OtherReasonDescription.Clean
                    && PrintBorrowerInitialLinesIndicator.Clean
                    && ProceedsOfNewLoanWillBeUsedIndicator.Clean
                    && ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator.Clean
                    && RefinancingLoanIsHomeEquityIndicator.Clean
                    && RefinancingRespondBonaFide.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AprNotExceedIndicator; v0.Clean = value; AprNotExceedIndicator = v0;
                var v1 = AvoidingForeclosureIndicator; v1.Clean = value; AvoidingForeclosureIndicator = v1;
                var v2 = BeneficialChangedForBorrowerIndicator; v2.Clean = value; BeneficialChangedForBorrowerIndicator = v2;
                var v3 = BonaFideFinancialEmergency; v3.Clean = value; BonaFideFinancialEmergency = v3;
                var v4 = BorrowerCanRecoupCostofRefinancingIndicator; v4.Clean = value; BorrowerCanRecoupCostofRefinancingIndicator = v4;
                var v5 = BorrowerCanRecoupIndicator; v5.Clean = value; BorrowerCanRecoupIndicator = v5;
                var v6 = BorrowerMonthlyPaymentLowerThan20Indicator; v6.Clean = value; BorrowerMonthlyPaymentLowerThan20Indicator = v6;
                var v7 = BorrowerReceivedReasonable; v7.Clean = value; BorrowerReceivedReasonable = v7;
                var v8 = BorrowerReceivesAmountExcessCostAndFeesIndicator; v8.Clean = value; BorrowerReceivesAmountExcessCostAndFeesIndicator = v8;
                var v9 = ChangeLoanFromArmtoFixedIndicator; v9.Clean = value; ChangeLoanFromArmtoFixedIndicator = v9;
                var v10 = ChangingLoanToFixedRateIndicator; v10.Clean = value; ChangingLoanToFixedRateIndicator = v10;
                var v11 = ConsolidatingOtherExistingLoansIntoNewLoanIndicator; v11.Clean = value; ConsolidatingOtherExistingLoansIntoNewLoanIndicator = v11;
                var v12 = EliminatingBalloonPaymentIndicator; v12.Clean = value; EliminatingBalloonPaymentIndicator = v12;
                var v13 = EliminatingNegArmIndicator; v13.Clean = value; EliminatingNegArmIndicator = v13;
                var v14 = EliminatingPrivateMortgageInsuranceIndicator; v14.Clean = value; EliminatingPrivateMortgageInsuranceIndicator = v14;
                var v15 = ExistingLoanAprPercent; v15.Clean = value; ExistingLoanAprPercent = v15;
                var v16 = ExistingLoanBalloonIndicator; v16.Clean = value; ExistingLoanBalloonIndicator = v16;
                var v17 = ExistingLoanBorrowerReceivesCashOutAmount; v17.Clean = value; ExistingLoanBorrowerReceivesCashOutAmount = v17;
                var v18 = ExistingLoanBorrowerReceivesCashOutIndicator; v18.Clean = value; ExistingLoanBorrowerReceivesCashOutIndicator = v18;
                var v19 = ExistingLoanBottomRatioPercent; v19.Clean = value; ExistingLoanBottomRatioPercent = v19;
                var v20 = ExistingLoanDateLoanClosed; v20.Clean = value; ExistingLoanDateLoanClosed = v20;
                var v21 = ExistingLoanFullyIndexRatePercent; v21.Clean = value; ExistingLoanFullyIndexRatePercent = v21;
                var v22 = ExistingLoanInterestRatePercent; v22.Clean = value; ExistingLoanInterestRatePercent = v22;
                var v23 = ExistingLoanIsGuaranteedIndicator; v23.Clean = value; ExistingLoanIsGuaranteedIndicator = v23;
                var v24 = ExistingLoanIsLoanRefinancedAsSpecial; v24.Clean = value; ExistingLoanIsLoanRefinancedAsSpecial = v24;
                var v25 = ExistingLoanIsNegativeAmortizationFeatureIndicator; v25.Clean = value; ExistingLoanIsNegativeAmortizationFeatureIndicator = v25;
                var v26 = ExistingLoanIsPrepaymentPenalty; v26.Clean = value; ExistingLoanIsPrepaymentPenalty = v26;
                var v27 = ExistingLoanLoanAmortizationType; v27.Clean = value; ExistingLoanLoanAmortizationType = v27;
                var v28 = ExistingLoanLoanAmount; v28.Clean = value; ExistingLoanLoanAmount = v28;
                var v29 = ExistingLoanLoanTerm; v29.Clean = value; ExistingLoanLoanTerm = v29;
                var v30 = ExistingLoanLtvPercent; v30.Clean = value; ExistingLoanLtvPercent = v30;
                var v31 = ExistingLoanMaximumRatePercent; v31.Clean = value; ExistingLoanMaximumRatePercent = v31;
                var v32 = ExistingLoanMonthsRemaining; v32.Clean = value; ExistingLoanMonthsRemaining = v32;
                var v33 = ExistingLoanPaymentAmount; v33.Clean = value; ExistingLoanPaymentAmount = v33;
                var v34 = ExistingLoanPaymentDifference; v34.Clean = value; ExistingLoanPaymentDifference = v34;
                var v35 = ExistingLoanPaymentIncludeMiObligation; v35.Clean = value; ExistingLoanPaymentIncludeMiObligation = v35;
                var v36 = ExistingLoanPaymentIncludeMortgageInsurance; v36.Clean = value; ExistingLoanPaymentIncludeMortgageInsurance = v36;
                var v37 = ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan; v37.Clean = value; ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan = v37;
                var v38 = ExistingLoanPrepaymentPenaltyBasedOn; v38.Clean = value; ExistingLoanPrepaymentPenaltyBasedOn = v38;
                var v39 = ExistingLoanPrepaymentPenaltyPercentage; v39.Clean = value; ExistingLoanPrepaymentPenaltyPercentage = v39;
                var v40 = ExistingLoanPrepaymentPenaltyTerm; v40.Clean = value; ExistingLoanPrepaymentPenaltyTerm = v40;
                var v41 = ExistingLoanProvidedByLicenseeType; v41.Clean = value; ExistingLoanProvidedByLicenseeType = v41;
                var v42 = ExistingLoanPurposeType; v42.Clean = value; ExistingLoanPurposeType = v42;
                var v43 = ExistingLoanRecoupCostsYears; v43.Clean = value; ExistingLoanRecoupCostsYears = v43;
                var v44 = ExistingLoanSavingsAmount; v44.Clean = value; ExistingLoanSavingsAmount = v44;
                var v45 = ExistingLoanTotalDebtPayoff; v45.Clean = value; ExistingLoanTotalDebtPayoff = v45;
                var v46 = ExistingLoanWeightedAverageInterestRatePercent; v46.Clean = value; ExistingLoanWeightedAverageInterestRatePercent = v46;
                var v47 = HomeLoanComplianceWith209; v47.Clean = value; HomeLoanComplianceWith209 = v47;
                var v48 = Id; v48.Clean = value; Id = v48;
                var v49 = LenderDeterminedBorrowersInterest; v49.Clean = value; LenderDeterminedBorrowersInterest = v49;
                var v50 = NewLoanIsGuaranteedIndicator; v50.Clean = value; NewLoanIsGuaranteedIndicator = v50;
                var v51 = NewLoanIsNegativeAmortizationFeatureIndicator; v51.Clean = value; NewLoanIsNegativeAmortizationFeatureIndicator = v51;
                var v52 = NewLoanIsSafeHarborQM; v52.Clean = value; NewLoanIsSafeHarborQM = v52;
                var v53 = NewLoanIsSpecialMortgageOriginatedIndicator; v53.Clean = value; NewLoanIsSpecialMortgageOriginatedIndicator = v53;
                var v54 = NewLoanPaymentWithMiDifference; v54.Clean = value; NewLoanPaymentWithMiDifference = v54;
                var v55 = NewLoanPaymentWithObligationDifference; v55.Clean = value; NewLoanPaymentWithObligationDifference = v55;
                var v56 = NewLoanPayOffConsolidateDebtIndicator; v56.Clean = value; NewLoanPayOffConsolidateDebtIndicator = v56;
                var v57 = NewLoanWeightedAverageInterestRatePercent; v57.Clean = value; NewLoanWeightedAverageInterestRatePercent = v57;
                var v58 = ObtainingLowerIntMonthlyPaymentIndicator; v58.Clean = value; ObtainingLowerIntMonthlyPaymentIndicator = v58;
                var v59 = ObtainingLowerIntRateIndicator; v59.Clean = value; ObtainingLowerIntRateIndicator = v59;
                var v60 = ObtainingShortAmortScheduleIndicator; v60.Clean = value; ObtainingShortAmortScheduleIndicator = v60;
                var v61 = OtherReason; v61.Clean = value; OtherReason = v61;
                var v62 = OtherReasonDescription; v62.Clean = value; OtherReasonDescription = v62;
                var v63 = PrintBorrowerInitialLinesIndicator; v63.Clean = value; PrintBorrowerInitialLinesIndicator = v63;
                var v64 = ProceedsOfNewLoanWillBeUsedIndicator; v64.Clean = value; ProceedsOfNewLoanWillBeUsedIndicator = v64;
                var v65 = ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator; v65.Clean = value; ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator = v65;
                var v66 = RefinancingLoanIsHomeEquityIndicator; v66.Clean = value; RefinancingLoanIsHomeEquityIndicator = v66;
                var v67 = RefinancingRespondBonaFide; v67.Clean = value; RefinancingRespondBonaFide = v67;
                _settingClean = 0;
            }
        }
    }
}