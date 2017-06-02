using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class NetTangibleBenefit : IClean
    {
        private Value<bool?> _aprNotExceedIndicator;
        public bool? AprNotExceedIndicator { get { return _aprNotExceedIndicator; } set { _aprNotExceedIndicator = value; } }
        private Value<bool?> _avoidingForeclosureIndicator;
        public bool? AvoidingForeclosureIndicator { get { return _avoidingForeclosureIndicator; } set { _avoidingForeclosureIndicator = value; } }
        private Value<bool?> _beneficialChangedForBorrowerIndicator;
        public bool? BeneficialChangedForBorrowerIndicator { get { return _beneficialChangedForBorrowerIndicator; } set { _beneficialChangedForBorrowerIndicator = value; } }
        private Value<string> _bonaFideFinancialEmergency;
        public string BonaFideFinancialEmergency { get { return _bonaFideFinancialEmergency; } set { _bonaFideFinancialEmergency = value; } }
        private Value<bool?> _borrowerCanRecoupCostofRefinancingIndicator;
        public bool? BorrowerCanRecoupCostofRefinancingIndicator { get { return _borrowerCanRecoupCostofRefinancingIndicator; } set { _borrowerCanRecoupCostofRefinancingIndicator = value; } }
        private Value<bool?> _borrowerCanRecoupIndicator;
        public bool? BorrowerCanRecoupIndicator { get { return _borrowerCanRecoupIndicator; } set { _borrowerCanRecoupIndicator = value; } }
        private Value<bool?> _borrowerMonthlyPaymentLowerThan20Indicator;
        public bool? BorrowerMonthlyPaymentLowerThan20Indicator { get { return _borrowerMonthlyPaymentLowerThan20Indicator; } set { _borrowerMonthlyPaymentLowerThan20Indicator = value; } }
        private Value<string> _borrowerReceivedReasonable;
        public string BorrowerReceivedReasonable { get { return _borrowerReceivedReasonable; } set { _borrowerReceivedReasonable = value; } }
        private Value<bool?> _borrowerReceivesAmountExcessCostAndFeesIndicator;
        public bool? BorrowerReceivesAmountExcessCostAndFeesIndicator { get { return _borrowerReceivesAmountExcessCostAndFeesIndicator; } set { _borrowerReceivesAmountExcessCostAndFeesIndicator = value; } }
        private Value<bool?> _changeLoanFromArmtoFixedIndicator;
        public bool? ChangeLoanFromArmtoFixedIndicator { get { return _changeLoanFromArmtoFixedIndicator; } set { _changeLoanFromArmtoFixedIndicator = value; } }
        private Value<bool?> _changingLoanToFixedRateIndicator;
        public bool? ChangingLoanToFixedRateIndicator { get { return _changingLoanToFixedRateIndicator; } set { _changingLoanToFixedRateIndicator = value; } }
        private Value<bool?> _consolidatingOtherExistingLoansIntoNewLoanIndicator;
        public bool? ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get { return _consolidatingOtherExistingLoansIntoNewLoanIndicator; } set { _consolidatingOtherExistingLoansIntoNewLoanIndicator = value; } }
        private Value<bool?> _eliminatingBalloonPaymentIndicator;
        public bool? EliminatingBalloonPaymentIndicator { get { return _eliminatingBalloonPaymentIndicator; } set { _eliminatingBalloonPaymentIndicator = value; } }
        private Value<bool?> _eliminatingNegArmIndicator;
        public bool? EliminatingNegArmIndicator { get { return _eliminatingNegArmIndicator; } set { _eliminatingNegArmIndicator = value; } }
        private Value<bool?> _eliminatingPrivateMortgageInsuranceIndicator;
        public bool? EliminatingPrivateMortgageInsuranceIndicator { get { return _eliminatingPrivateMortgageInsuranceIndicator; } set { _eliminatingPrivateMortgageInsuranceIndicator = value; } }
        private Value<decimal?> _existingLoanAprPercent;
        public decimal? ExistingLoanAprPercent { get { return _existingLoanAprPercent; } set { _existingLoanAprPercent = value; } }
        private Value<bool?> _existingLoanBalloonIndicator;
        public bool? ExistingLoanBalloonIndicator { get { return _existingLoanBalloonIndicator; } set { _existingLoanBalloonIndicator = value; } }
        private Value<decimal?> _existingLoanBorrowerReceivesCashOutAmount;
        public decimal? ExistingLoanBorrowerReceivesCashOutAmount { get { return _existingLoanBorrowerReceivesCashOutAmount; } set { _existingLoanBorrowerReceivesCashOutAmount = value; } }
        private Value<bool?> _existingLoanBorrowerReceivesCashOutIndicator;
        public bool? ExistingLoanBorrowerReceivesCashOutIndicator { get { return _existingLoanBorrowerReceivesCashOutIndicator; } set { _existingLoanBorrowerReceivesCashOutIndicator = value; } }
        private Value<decimal?> _existingLoanBottomRatioPercent;
        public decimal? ExistingLoanBottomRatioPercent { get { return _existingLoanBottomRatioPercent; } set { _existingLoanBottomRatioPercent = value; } }
        private Value<DateTime?> _existingLoanDateLoanClosed;
        public DateTime? ExistingLoanDateLoanClosed { get { return _existingLoanDateLoanClosed; } set { _existingLoanDateLoanClosed = value; } }
        private Value<decimal?> _existingLoanFullyIndexRatePercent;
        public decimal? ExistingLoanFullyIndexRatePercent { get { return _existingLoanFullyIndexRatePercent; } set { _existingLoanFullyIndexRatePercent = value; } }
        private Value<decimal?> _existingLoanInterestRatePercent;
        public decimal? ExistingLoanInterestRatePercent { get { return _existingLoanInterestRatePercent; } set { _existingLoanInterestRatePercent = value; } }
        private Value<bool?> _existingLoanIsGuaranteedIndicator;
        public bool? ExistingLoanIsGuaranteedIndicator { get { return _existingLoanIsGuaranteedIndicator; } set { _existingLoanIsGuaranteedIndicator = value; } }
        private Value<bool?> _existingLoanIsLoanRefinancedAsSpecial;
        public bool? ExistingLoanIsLoanRefinancedAsSpecial { get { return _existingLoanIsLoanRefinancedAsSpecial; } set { _existingLoanIsLoanRefinancedAsSpecial = value; } }
        private Value<bool?> _existingLoanIsNegativeAmortizationFeatureIndicator;
        public bool? ExistingLoanIsNegativeAmortizationFeatureIndicator { get { return _existingLoanIsNegativeAmortizationFeatureIndicator; } set { _existingLoanIsNegativeAmortizationFeatureIndicator = value; } }
        private Value<bool?> _existingLoanIsPrepaymentPenalty;
        public bool? ExistingLoanIsPrepaymentPenalty { get { return _existingLoanIsPrepaymentPenalty; } set { _existingLoanIsPrepaymentPenalty = value; } }
        private Value<string> _existingLoanLoanAmortizationType;
        public string ExistingLoanLoanAmortizationType { get { return _existingLoanLoanAmortizationType; } set { _existingLoanLoanAmortizationType = value; } }
        private Value<decimal?> _existingLoanLoanAmount;
        public decimal? ExistingLoanLoanAmount { get { return _existingLoanLoanAmount; } set { _existingLoanLoanAmount = value; } }
        private Value<int?> _existingLoanLoanTerm;
        public int? ExistingLoanLoanTerm { get { return _existingLoanLoanTerm; } set { _existingLoanLoanTerm = value; } }
        private Value<decimal?> _existingLoanLtvPercent;
        public decimal? ExistingLoanLtvPercent { get { return _existingLoanLtvPercent; } set { _existingLoanLtvPercent = value; } }
        private Value<decimal?> _existingLoanMaximumRatePercent;
        public decimal? ExistingLoanMaximumRatePercent { get { return _existingLoanMaximumRatePercent; } set { _existingLoanMaximumRatePercent = value; } }
        private Value<int?> _existingLoanMonthsRemaining;
        public int? ExistingLoanMonthsRemaining { get { return _existingLoanMonthsRemaining; } set { _existingLoanMonthsRemaining = value; } }
        private Value<decimal?> _existingLoanPaymentAmount;
        public decimal? ExistingLoanPaymentAmount { get { return _existingLoanPaymentAmount; } set { _existingLoanPaymentAmount = value; } }
        private Value<decimal?> _existingLoanPaymentDifference;
        public decimal? ExistingLoanPaymentDifference { get { return _existingLoanPaymentDifference; } set { _existingLoanPaymentDifference = value; } }
        private Value<decimal?> _existingLoanPaymentIncludeMiObligation;
        public decimal? ExistingLoanPaymentIncludeMiObligation { get { return _existingLoanPaymentIncludeMiObligation; } set { _existingLoanPaymentIncludeMiObligation = value; } }
        private Value<decimal?> _existingLoanPaymentIncludeMortgageInsurance;
        public decimal? ExistingLoanPaymentIncludeMortgageInsurance { get { return _existingLoanPaymentIncludeMortgageInsurance; } set { _existingLoanPaymentIncludeMortgageInsurance = value; } }
        private Value<decimal?> _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan;
        public decimal? ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get { return _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan; } set { _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan = value; } }
        private Value<string> _existingLoanPrepaymentPenaltyBasedOn;
        public string ExistingLoanPrepaymentPenaltyBasedOn { get { return _existingLoanPrepaymentPenaltyBasedOn; } set { _existingLoanPrepaymentPenaltyBasedOn = value; } }
        private Value<decimal?> _existingLoanPrepaymentPenaltyPercentage;
        public decimal? ExistingLoanPrepaymentPenaltyPercentage { get { return _existingLoanPrepaymentPenaltyPercentage; } set { _existingLoanPrepaymentPenaltyPercentage = value; } }
        private Value<int?> _existingLoanPrepaymentPenaltyTerm;
        public int? ExistingLoanPrepaymentPenaltyTerm { get { return _existingLoanPrepaymentPenaltyTerm; } set { _existingLoanPrepaymentPenaltyTerm = value; } }
        private Value<string> _existingLoanProvidedByLicenseeType;
        public string ExistingLoanProvidedByLicenseeType { get { return _existingLoanProvidedByLicenseeType; } set { _existingLoanProvidedByLicenseeType = value; } }
        private Value<string> _existingLoanPurposeType;
        public string ExistingLoanPurposeType { get { return _existingLoanPurposeType; } set { _existingLoanPurposeType = value; } }
        private Value<int?> _existingLoanRecoupCostsYears;
        public int? ExistingLoanRecoupCostsYears { get { return _existingLoanRecoupCostsYears; } set { _existingLoanRecoupCostsYears = value; } }
        private Value<decimal?> _existingLoanSavingsAmount;
        public decimal? ExistingLoanSavingsAmount { get { return _existingLoanSavingsAmount; } set { _existingLoanSavingsAmount = value; } }
        private Value<decimal?> _existingLoanTotalDebtPayoff;
        public decimal? ExistingLoanTotalDebtPayoff { get { return _existingLoanTotalDebtPayoff; } set { _existingLoanTotalDebtPayoff = value; } }
        private Value<decimal?> _existingLoanWeightedAverageInterestRatePercent;
        public decimal? ExistingLoanWeightedAverageInterestRatePercent { get { return _existingLoanWeightedAverageInterestRatePercent; } set { _existingLoanWeightedAverageInterestRatePercent = value; } }
        private Value<bool?> _homeLoanComplianceWith209;
        public bool? HomeLoanComplianceWith209 { get { return _homeLoanComplianceWith209; } set { _homeLoanComplianceWith209 = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _lenderDeterminedBorrowersInterest;
        public bool? LenderDeterminedBorrowersInterest { get { return _lenderDeterminedBorrowersInterest; } set { _lenderDeterminedBorrowersInterest = value; } }
        private Value<bool?> _newLoanIsGuaranteedIndicator;
        public bool? NewLoanIsGuaranteedIndicator { get { return _newLoanIsGuaranteedIndicator; } set { _newLoanIsGuaranteedIndicator = value; } }
        private Value<bool?> _newLoanIsNegativeAmortizationFeatureIndicator;
        public bool? NewLoanIsNegativeAmortizationFeatureIndicator { get { return _newLoanIsNegativeAmortizationFeatureIndicator; } set { _newLoanIsNegativeAmortizationFeatureIndicator = value; } }
        private Value<bool?> _newLoanIsSafeHarborQM;
        public bool? NewLoanIsSafeHarborQM { get { return _newLoanIsSafeHarborQM; } set { _newLoanIsSafeHarborQM = value; } }
        private Value<bool?> _newLoanIsSpecialMortgageOriginatedIndicator;
        public bool? NewLoanIsSpecialMortgageOriginatedIndicator { get { return _newLoanIsSpecialMortgageOriginatedIndicator; } set { _newLoanIsSpecialMortgageOriginatedIndicator = value; } }
        private Value<decimal?> _newLoanPaymentWithMiDifference;
        public decimal? NewLoanPaymentWithMiDifference { get { return _newLoanPaymentWithMiDifference; } set { _newLoanPaymentWithMiDifference = value; } }
        private Value<decimal?> _newLoanPaymentWithObligationDifference;
        public decimal? NewLoanPaymentWithObligationDifference { get { return _newLoanPaymentWithObligationDifference; } set { _newLoanPaymentWithObligationDifference = value; } }
        private Value<bool?> _newLoanPayOffConsolidateDebtIndicator;
        public bool? NewLoanPayOffConsolidateDebtIndicator { get { return _newLoanPayOffConsolidateDebtIndicator; } set { _newLoanPayOffConsolidateDebtIndicator = value; } }
        private Value<decimal?> _newLoanWeightedAverageInterestRatePercent;
        public decimal? NewLoanWeightedAverageInterestRatePercent { get { return _newLoanWeightedAverageInterestRatePercent; } set { _newLoanWeightedAverageInterestRatePercent = value; } }
        private Value<bool?> _obtainingLowerIntMonthlyPaymentIndicator;
        public bool? ObtainingLowerIntMonthlyPaymentIndicator { get { return _obtainingLowerIntMonthlyPaymentIndicator; } set { _obtainingLowerIntMonthlyPaymentIndicator = value; } }
        private Value<bool?> _obtainingLowerIntRateIndicator;
        public bool? ObtainingLowerIntRateIndicator { get { return _obtainingLowerIntRateIndicator; } set { _obtainingLowerIntRateIndicator = value; } }
        private Value<bool?> _obtainingShortAmortScheduleIndicator;
        public bool? ObtainingShortAmortScheduleIndicator { get { return _obtainingShortAmortScheduleIndicator; } set { _obtainingShortAmortScheduleIndicator = value; } }
        private Value<bool?> _otherReason;
        public bool? OtherReason { get { return _otherReason; } set { _otherReason = value; } }
        private Value<string> _otherReasonDescription;
        public string OtherReasonDescription { get { return _otherReasonDescription; } set { _otherReasonDescription = value; } }
        private Value<bool?> _printBorrowerInitialLinesIndicator;
        public bool? PrintBorrowerInitialLinesIndicator { get { return _printBorrowerInitialLinesIndicator; } set { _printBorrowerInitialLinesIndicator = value; } }
        private Value<bool?> _proceedsOfNewLoanWillBeUsedIndicator;
        public bool? ProceedsOfNewLoanWillBeUsedIndicator { get { return _proceedsOfNewLoanWillBeUsedIndicator; } set { _proceedsOfNewLoanWillBeUsedIndicator = value; } }
        private Value<bool?> _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator;
        public bool? ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get { return _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator; } set { _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator = value; } }
        private Value<bool?> _refinancingLoanIsHomeEquityIndicator;
        public bool? RefinancingLoanIsHomeEquityIndicator { get { return _refinancingLoanIsHomeEquityIndicator; } set { _refinancingLoanIsHomeEquityIndicator = value; } }
        private Value<bool?> _refinancingRespondBonaFide;
        public bool? RefinancingRespondBonaFide { get { return _refinancingRespondBonaFide; } set { _refinancingRespondBonaFide = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _aprNotExceedIndicator.Clean
                    && _avoidingForeclosureIndicator.Clean
                    && _beneficialChangedForBorrowerIndicator.Clean
                    && _bonaFideFinancialEmergency.Clean
                    && _borrowerCanRecoupCostofRefinancingIndicator.Clean
                    && _borrowerCanRecoupIndicator.Clean
                    && _borrowerMonthlyPaymentLowerThan20Indicator.Clean
                    && _borrowerReceivedReasonable.Clean
                    && _borrowerReceivesAmountExcessCostAndFeesIndicator.Clean
                    && _changeLoanFromArmtoFixedIndicator.Clean
                    && _changingLoanToFixedRateIndicator.Clean
                    && _consolidatingOtherExistingLoansIntoNewLoanIndicator.Clean
                    && _eliminatingBalloonPaymentIndicator.Clean
                    && _eliminatingNegArmIndicator.Clean
                    && _eliminatingPrivateMortgageInsuranceIndicator.Clean
                    && _existingLoanAprPercent.Clean
                    && _existingLoanBalloonIndicator.Clean
                    && _existingLoanBorrowerReceivesCashOutAmount.Clean
                    && _existingLoanBorrowerReceivesCashOutIndicator.Clean
                    && _existingLoanBottomRatioPercent.Clean
                    && _existingLoanDateLoanClosed.Clean
                    && _existingLoanFullyIndexRatePercent.Clean
                    && _existingLoanInterestRatePercent.Clean
                    && _existingLoanIsGuaranteedIndicator.Clean
                    && _existingLoanIsLoanRefinancedAsSpecial.Clean
                    && _existingLoanIsNegativeAmortizationFeatureIndicator.Clean
                    && _existingLoanIsPrepaymentPenalty.Clean
                    && _existingLoanLoanAmortizationType.Clean
                    && _existingLoanLoanAmount.Clean
                    && _existingLoanLoanTerm.Clean
                    && _existingLoanLtvPercent.Clean
                    && _existingLoanMaximumRatePercent.Clean
                    && _existingLoanMonthsRemaining.Clean
                    && _existingLoanPaymentAmount.Clean
                    && _existingLoanPaymentDifference.Clean
                    && _existingLoanPaymentIncludeMiObligation.Clean
                    && _existingLoanPaymentIncludeMortgageInsurance.Clean
                    && _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan.Clean
                    && _existingLoanPrepaymentPenaltyBasedOn.Clean
                    && _existingLoanPrepaymentPenaltyPercentage.Clean
                    && _existingLoanPrepaymentPenaltyTerm.Clean
                    && _existingLoanProvidedByLicenseeType.Clean
                    && _existingLoanPurposeType.Clean
                    && _existingLoanRecoupCostsYears.Clean
                    && _existingLoanSavingsAmount.Clean
                    && _existingLoanTotalDebtPayoff.Clean
                    && _existingLoanWeightedAverageInterestRatePercent.Clean
                    && _homeLoanComplianceWith209.Clean
                    && _id.Clean
                    && _lenderDeterminedBorrowersInterest.Clean
                    && _newLoanIsGuaranteedIndicator.Clean
                    && _newLoanIsNegativeAmortizationFeatureIndicator.Clean
                    && _newLoanIsSafeHarborQM.Clean
                    && _newLoanIsSpecialMortgageOriginatedIndicator.Clean
                    && _newLoanPaymentWithMiDifference.Clean
                    && _newLoanPaymentWithObligationDifference.Clean
                    && _newLoanPayOffConsolidateDebtIndicator.Clean
                    && _newLoanWeightedAverageInterestRatePercent.Clean
                    && _obtainingLowerIntMonthlyPaymentIndicator.Clean
                    && _obtainingLowerIntRateIndicator.Clean
                    && _obtainingShortAmortScheduleIndicator.Clean
                    && _otherReason.Clean
                    && _otherReasonDescription.Clean
                    && _printBorrowerInitialLinesIndicator.Clean
                    && _proceedsOfNewLoanWillBeUsedIndicator.Clean
                    && _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator.Clean
                    && _refinancingLoanIsHomeEquityIndicator.Clean
                    && _refinancingRespondBonaFide.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _aprNotExceedIndicator; v0.Clean = value; _aprNotExceedIndicator = v0;
                var v1 = _avoidingForeclosureIndicator; v1.Clean = value; _avoidingForeclosureIndicator = v1;
                var v2 = _beneficialChangedForBorrowerIndicator; v2.Clean = value; _beneficialChangedForBorrowerIndicator = v2;
                var v3 = _bonaFideFinancialEmergency; v3.Clean = value; _bonaFideFinancialEmergency = v3;
                var v4 = _borrowerCanRecoupCostofRefinancingIndicator; v4.Clean = value; _borrowerCanRecoupCostofRefinancingIndicator = v4;
                var v5 = _borrowerCanRecoupIndicator; v5.Clean = value; _borrowerCanRecoupIndicator = v5;
                var v6 = _borrowerMonthlyPaymentLowerThan20Indicator; v6.Clean = value; _borrowerMonthlyPaymentLowerThan20Indicator = v6;
                var v7 = _borrowerReceivedReasonable; v7.Clean = value; _borrowerReceivedReasonable = v7;
                var v8 = _borrowerReceivesAmountExcessCostAndFeesIndicator; v8.Clean = value; _borrowerReceivesAmountExcessCostAndFeesIndicator = v8;
                var v9 = _changeLoanFromArmtoFixedIndicator; v9.Clean = value; _changeLoanFromArmtoFixedIndicator = v9;
                var v10 = _changingLoanToFixedRateIndicator; v10.Clean = value; _changingLoanToFixedRateIndicator = v10;
                var v11 = _consolidatingOtherExistingLoansIntoNewLoanIndicator; v11.Clean = value; _consolidatingOtherExistingLoansIntoNewLoanIndicator = v11;
                var v12 = _eliminatingBalloonPaymentIndicator; v12.Clean = value; _eliminatingBalloonPaymentIndicator = v12;
                var v13 = _eliminatingNegArmIndicator; v13.Clean = value; _eliminatingNegArmIndicator = v13;
                var v14 = _eliminatingPrivateMortgageInsuranceIndicator; v14.Clean = value; _eliminatingPrivateMortgageInsuranceIndicator = v14;
                var v15 = _existingLoanAprPercent; v15.Clean = value; _existingLoanAprPercent = v15;
                var v16 = _existingLoanBalloonIndicator; v16.Clean = value; _existingLoanBalloonIndicator = v16;
                var v17 = _existingLoanBorrowerReceivesCashOutAmount; v17.Clean = value; _existingLoanBorrowerReceivesCashOutAmount = v17;
                var v18 = _existingLoanBorrowerReceivesCashOutIndicator; v18.Clean = value; _existingLoanBorrowerReceivesCashOutIndicator = v18;
                var v19 = _existingLoanBottomRatioPercent; v19.Clean = value; _existingLoanBottomRatioPercent = v19;
                var v20 = _existingLoanDateLoanClosed; v20.Clean = value; _existingLoanDateLoanClosed = v20;
                var v21 = _existingLoanFullyIndexRatePercent; v21.Clean = value; _existingLoanFullyIndexRatePercent = v21;
                var v22 = _existingLoanInterestRatePercent; v22.Clean = value; _existingLoanInterestRatePercent = v22;
                var v23 = _existingLoanIsGuaranteedIndicator; v23.Clean = value; _existingLoanIsGuaranteedIndicator = v23;
                var v24 = _existingLoanIsLoanRefinancedAsSpecial; v24.Clean = value; _existingLoanIsLoanRefinancedAsSpecial = v24;
                var v25 = _existingLoanIsNegativeAmortizationFeatureIndicator; v25.Clean = value; _existingLoanIsNegativeAmortizationFeatureIndicator = v25;
                var v26 = _existingLoanIsPrepaymentPenalty; v26.Clean = value; _existingLoanIsPrepaymentPenalty = v26;
                var v27 = _existingLoanLoanAmortizationType; v27.Clean = value; _existingLoanLoanAmortizationType = v27;
                var v28 = _existingLoanLoanAmount; v28.Clean = value; _existingLoanLoanAmount = v28;
                var v29 = _existingLoanLoanTerm; v29.Clean = value; _existingLoanLoanTerm = v29;
                var v30 = _existingLoanLtvPercent; v30.Clean = value; _existingLoanLtvPercent = v30;
                var v31 = _existingLoanMaximumRatePercent; v31.Clean = value; _existingLoanMaximumRatePercent = v31;
                var v32 = _existingLoanMonthsRemaining; v32.Clean = value; _existingLoanMonthsRemaining = v32;
                var v33 = _existingLoanPaymentAmount; v33.Clean = value; _existingLoanPaymentAmount = v33;
                var v34 = _existingLoanPaymentDifference; v34.Clean = value; _existingLoanPaymentDifference = v34;
                var v35 = _existingLoanPaymentIncludeMiObligation; v35.Clean = value; _existingLoanPaymentIncludeMiObligation = v35;
                var v36 = _existingLoanPaymentIncludeMortgageInsurance; v36.Clean = value; _existingLoanPaymentIncludeMortgageInsurance = v36;
                var v37 = _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan; v37.Clean = value; _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan = v37;
                var v38 = _existingLoanPrepaymentPenaltyBasedOn; v38.Clean = value; _existingLoanPrepaymentPenaltyBasedOn = v38;
                var v39 = _existingLoanPrepaymentPenaltyPercentage; v39.Clean = value; _existingLoanPrepaymentPenaltyPercentage = v39;
                var v40 = _existingLoanPrepaymentPenaltyTerm; v40.Clean = value; _existingLoanPrepaymentPenaltyTerm = v40;
                var v41 = _existingLoanProvidedByLicenseeType; v41.Clean = value; _existingLoanProvidedByLicenseeType = v41;
                var v42 = _existingLoanPurposeType; v42.Clean = value; _existingLoanPurposeType = v42;
                var v43 = _existingLoanRecoupCostsYears; v43.Clean = value; _existingLoanRecoupCostsYears = v43;
                var v44 = _existingLoanSavingsAmount; v44.Clean = value; _existingLoanSavingsAmount = v44;
                var v45 = _existingLoanTotalDebtPayoff; v45.Clean = value; _existingLoanTotalDebtPayoff = v45;
                var v46 = _existingLoanWeightedAverageInterestRatePercent; v46.Clean = value; _existingLoanWeightedAverageInterestRatePercent = v46;
                var v47 = _homeLoanComplianceWith209; v47.Clean = value; _homeLoanComplianceWith209 = v47;
                var v48 = _id; v48.Clean = value; _id = v48;
                var v49 = _lenderDeterminedBorrowersInterest; v49.Clean = value; _lenderDeterminedBorrowersInterest = v49;
                var v50 = _newLoanIsGuaranteedIndicator; v50.Clean = value; _newLoanIsGuaranteedIndicator = v50;
                var v51 = _newLoanIsNegativeAmortizationFeatureIndicator; v51.Clean = value; _newLoanIsNegativeAmortizationFeatureIndicator = v51;
                var v52 = _newLoanIsSafeHarborQM; v52.Clean = value; _newLoanIsSafeHarborQM = v52;
                var v53 = _newLoanIsSpecialMortgageOriginatedIndicator; v53.Clean = value; _newLoanIsSpecialMortgageOriginatedIndicator = v53;
                var v54 = _newLoanPaymentWithMiDifference; v54.Clean = value; _newLoanPaymentWithMiDifference = v54;
                var v55 = _newLoanPaymentWithObligationDifference; v55.Clean = value; _newLoanPaymentWithObligationDifference = v55;
                var v56 = _newLoanPayOffConsolidateDebtIndicator; v56.Clean = value; _newLoanPayOffConsolidateDebtIndicator = v56;
                var v57 = _newLoanWeightedAverageInterestRatePercent; v57.Clean = value; _newLoanWeightedAverageInterestRatePercent = v57;
                var v58 = _obtainingLowerIntMonthlyPaymentIndicator; v58.Clean = value; _obtainingLowerIntMonthlyPaymentIndicator = v58;
                var v59 = _obtainingLowerIntRateIndicator; v59.Clean = value; _obtainingLowerIntRateIndicator = v59;
                var v60 = _obtainingShortAmortScheduleIndicator; v60.Clean = value; _obtainingShortAmortScheduleIndicator = v60;
                var v61 = _otherReason; v61.Clean = value; _otherReason = v61;
                var v62 = _otherReasonDescription; v62.Clean = value; _otherReasonDescription = v62;
                var v63 = _printBorrowerInitialLinesIndicator; v63.Clean = value; _printBorrowerInitialLinesIndicator = v63;
                var v64 = _proceedsOfNewLoanWillBeUsedIndicator; v64.Clean = value; _proceedsOfNewLoanWillBeUsedIndicator = v64;
                var v65 = _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator; v65.Clean = value; _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator = v65;
                var v66 = _refinancingLoanIsHomeEquityIndicator; v66.Clean = value; _refinancingLoanIsHomeEquityIndicator = v66;
                var v67 = _refinancingRespondBonaFide; v67.Clean = value; _refinancingRespondBonaFide = v67;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public NetTangibleBenefit()
        {
            Clean = true;
        }
    }
}