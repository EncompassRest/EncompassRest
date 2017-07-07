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
                var aprNotExceedIndicator = _aprNotExceedIndicator; aprNotExceedIndicator.Clean = value; _aprNotExceedIndicator = aprNotExceedIndicator;
                var avoidingForeclosureIndicator = _avoidingForeclosureIndicator; avoidingForeclosureIndicator.Clean = value; _avoidingForeclosureIndicator = avoidingForeclosureIndicator;
                var beneficialChangedForBorrowerIndicator = _beneficialChangedForBorrowerIndicator; beneficialChangedForBorrowerIndicator.Clean = value; _beneficialChangedForBorrowerIndicator = beneficialChangedForBorrowerIndicator;
                var bonaFideFinancialEmergency = _bonaFideFinancialEmergency; bonaFideFinancialEmergency.Clean = value; _bonaFideFinancialEmergency = bonaFideFinancialEmergency;
                var borrowerCanRecoupCostofRefinancingIndicator = _borrowerCanRecoupCostofRefinancingIndicator; borrowerCanRecoupCostofRefinancingIndicator.Clean = value; _borrowerCanRecoupCostofRefinancingIndicator = borrowerCanRecoupCostofRefinancingIndicator;
                var borrowerCanRecoupIndicator = _borrowerCanRecoupIndicator; borrowerCanRecoupIndicator.Clean = value; _borrowerCanRecoupIndicator = borrowerCanRecoupIndicator;
                var borrowerMonthlyPaymentLowerThan20Indicator = _borrowerMonthlyPaymentLowerThan20Indicator; borrowerMonthlyPaymentLowerThan20Indicator.Clean = value; _borrowerMonthlyPaymentLowerThan20Indicator = borrowerMonthlyPaymentLowerThan20Indicator;
                var borrowerReceivedReasonable = _borrowerReceivedReasonable; borrowerReceivedReasonable.Clean = value; _borrowerReceivedReasonable = borrowerReceivedReasonable;
                var borrowerReceivesAmountExcessCostAndFeesIndicator = _borrowerReceivesAmountExcessCostAndFeesIndicator; borrowerReceivesAmountExcessCostAndFeesIndicator.Clean = value; _borrowerReceivesAmountExcessCostAndFeesIndicator = borrowerReceivesAmountExcessCostAndFeesIndicator;
                var changeLoanFromArmtoFixedIndicator = _changeLoanFromArmtoFixedIndicator; changeLoanFromArmtoFixedIndicator.Clean = value; _changeLoanFromArmtoFixedIndicator = changeLoanFromArmtoFixedIndicator;
                var changingLoanToFixedRateIndicator = _changingLoanToFixedRateIndicator; changingLoanToFixedRateIndicator.Clean = value; _changingLoanToFixedRateIndicator = changingLoanToFixedRateIndicator;
                var consolidatingOtherExistingLoansIntoNewLoanIndicator = _consolidatingOtherExistingLoansIntoNewLoanIndicator; consolidatingOtherExistingLoansIntoNewLoanIndicator.Clean = value; _consolidatingOtherExistingLoansIntoNewLoanIndicator = consolidatingOtherExistingLoansIntoNewLoanIndicator;
                var eliminatingBalloonPaymentIndicator = _eliminatingBalloonPaymentIndicator; eliminatingBalloonPaymentIndicator.Clean = value; _eliminatingBalloonPaymentIndicator = eliminatingBalloonPaymentIndicator;
                var eliminatingNegArmIndicator = _eliminatingNegArmIndicator; eliminatingNegArmIndicator.Clean = value; _eliminatingNegArmIndicator = eliminatingNegArmIndicator;
                var eliminatingPrivateMortgageInsuranceIndicator = _eliminatingPrivateMortgageInsuranceIndicator; eliminatingPrivateMortgageInsuranceIndicator.Clean = value; _eliminatingPrivateMortgageInsuranceIndicator = eliminatingPrivateMortgageInsuranceIndicator;
                var existingLoanAprPercent = _existingLoanAprPercent; existingLoanAprPercent.Clean = value; _existingLoanAprPercent = existingLoanAprPercent;
                var existingLoanBalloonIndicator = _existingLoanBalloonIndicator; existingLoanBalloonIndicator.Clean = value; _existingLoanBalloonIndicator = existingLoanBalloonIndicator;
                var existingLoanBorrowerReceivesCashOutAmount = _existingLoanBorrowerReceivesCashOutAmount; existingLoanBorrowerReceivesCashOutAmount.Clean = value; _existingLoanBorrowerReceivesCashOutAmount = existingLoanBorrowerReceivesCashOutAmount;
                var existingLoanBorrowerReceivesCashOutIndicator = _existingLoanBorrowerReceivesCashOutIndicator; existingLoanBorrowerReceivesCashOutIndicator.Clean = value; _existingLoanBorrowerReceivesCashOutIndicator = existingLoanBorrowerReceivesCashOutIndicator;
                var existingLoanBottomRatioPercent = _existingLoanBottomRatioPercent; existingLoanBottomRatioPercent.Clean = value; _existingLoanBottomRatioPercent = existingLoanBottomRatioPercent;
                var existingLoanDateLoanClosed = _existingLoanDateLoanClosed; existingLoanDateLoanClosed.Clean = value; _existingLoanDateLoanClosed = existingLoanDateLoanClosed;
                var existingLoanFullyIndexRatePercent = _existingLoanFullyIndexRatePercent; existingLoanFullyIndexRatePercent.Clean = value; _existingLoanFullyIndexRatePercent = existingLoanFullyIndexRatePercent;
                var existingLoanInterestRatePercent = _existingLoanInterestRatePercent; existingLoanInterestRatePercent.Clean = value; _existingLoanInterestRatePercent = existingLoanInterestRatePercent;
                var existingLoanIsGuaranteedIndicator = _existingLoanIsGuaranteedIndicator; existingLoanIsGuaranteedIndicator.Clean = value; _existingLoanIsGuaranteedIndicator = existingLoanIsGuaranteedIndicator;
                var existingLoanIsLoanRefinancedAsSpecial = _existingLoanIsLoanRefinancedAsSpecial; existingLoanIsLoanRefinancedAsSpecial.Clean = value; _existingLoanIsLoanRefinancedAsSpecial = existingLoanIsLoanRefinancedAsSpecial;
                var existingLoanIsNegativeAmortizationFeatureIndicator = _existingLoanIsNegativeAmortizationFeatureIndicator; existingLoanIsNegativeAmortizationFeatureIndicator.Clean = value; _existingLoanIsNegativeAmortizationFeatureIndicator = existingLoanIsNegativeAmortizationFeatureIndicator;
                var existingLoanIsPrepaymentPenalty = _existingLoanIsPrepaymentPenalty; existingLoanIsPrepaymentPenalty.Clean = value; _existingLoanIsPrepaymentPenalty = existingLoanIsPrepaymentPenalty;
                var existingLoanLoanAmortizationType = _existingLoanLoanAmortizationType; existingLoanLoanAmortizationType.Clean = value; _existingLoanLoanAmortizationType = existingLoanLoanAmortizationType;
                var existingLoanLoanAmount = _existingLoanLoanAmount; existingLoanLoanAmount.Clean = value; _existingLoanLoanAmount = existingLoanLoanAmount;
                var existingLoanLoanTerm = _existingLoanLoanTerm; existingLoanLoanTerm.Clean = value; _existingLoanLoanTerm = existingLoanLoanTerm;
                var existingLoanLtvPercent = _existingLoanLtvPercent; existingLoanLtvPercent.Clean = value; _existingLoanLtvPercent = existingLoanLtvPercent;
                var existingLoanMaximumRatePercent = _existingLoanMaximumRatePercent; existingLoanMaximumRatePercent.Clean = value; _existingLoanMaximumRatePercent = existingLoanMaximumRatePercent;
                var existingLoanMonthsRemaining = _existingLoanMonthsRemaining; existingLoanMonthsRemaining.Clean = value; _existingLoanMonthsRemaining = existingLoanMonthsRemaining;
                var existingLoanPaymentAmount = _existingLoanPaymentAmount; existingLoanPaymentAmount.Clean = value; _existingLoanPaymentAmount = existingLoanPaymentAmount;
                var existingLoanPaymentDifference = _existingLoanPaymentDifference; existingLoanPaymentDifference.Clean = value; _existingLoanPaymentDifference = existingLoanPaymentDifference;
                var existingLoanPaymentIncludeMiObligation = _existingLoanPaymentIncludeMiObligation; existingLoanPaymentIncludeMiObligation.Clean = value; _existingLoanPaymentIncludeMiObligation = existingLoanPaymentIncludeMiObligation;
                var existingLoanPaymentIncludeMortgageInsurance = _existingLoanPaymentIncludeMortgageInsurance; existingLoanPaymentIncludeMortgageInsurance.Clean = value; _existingLoanPaymentIncludeMortgageInsurance = existingLoanPaymentIncludeMortgageInsurance;
                var existingLoanPrepaymentPenaltyAmountIncludedInNewLoan = _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan; existingLoanPrepaymentPenaltyAmountIncludedInNewLoan.Clean = value; _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan = existingLoanPrepaymentPenaltyAmountIncludedInNewLoan;
                var existingLoanPrepaymentPenaltyBasedOn = _existingLoanPrepaymentPenaltyBasedOn; existingLoanPrepaymentPenaltyBasedOn.Clean = value; _existingLoanPrepaymentPenaltyBasedOn = existingLoanPrepaymentPenaltyBasedOn;
                var existingLoanPrepaymentPenaltyPercentage = _existingLoanPrepaymentPenaltyPercentage; existingLoanPrepaymentPenaltyPercentage.Clean = value; _existingLoanPrepaymentPenaltyPercentage = existingLoanPrepaymentPenaltyPercentage;
                var existingLoanPrepaymentPenaltyTerm = _existingLoanPrepaymentPenaltyTerm; existingLoanPrepaymentPenaltyTerm.Clean = value; _existingLoanPrepaymentPenaltyTerm = existingLoanPrepaymentPenaltyTerm;
                var existingLoanProvidedByLicenseeType = _existingLoanProvidedByLicenseeType; existingLoanProvidedByLicenseeType.Clean = value; _existingLoanProvidedByLicenseeType = existingLoanProvidedByLicenseeType;
                var existingLoanPurposeType = _existingLoanPurposeType; existingLoanPurposeType.Clean = value; _existingLoanPurposeType = existingLoanPurposeType;
                var existingLoanRecoupCostsYears = _existingLoanRecoupCostsYears; existingLoanRecoupCostsYears.Clean = value; _existingLoanRecoupCostsYears = existingLoanRecoupCostsYears;
                var existingLoanSavingsAmount = _existingLoanSavingsAmount; existingLoanSavingsAmount.Clean = value; _existingLoanSavingsAmount = existingLoanSavingsAmount;
                var existingLoanTotalDebtPayoff = _existingLoanTotalDebtPayoff; existingLoanTotalDebtPayoff.Clean = value; _existingLoanTotalDebtPayoff = existingLoanTotalDebtPayoff;
                var existingLoanWeightedAverageInterestRatePercent = _existingLoanWeightedAverageInterestRatePercent; existingLoanWeightedAverageInterestRatePercent.Clean = value; _existingLoanWeightedAverageInterestRatePercent = existingLoanWeightedAverageInterestRatePercent;
                var homeLoanComplianceWith209 = _homeLoanComplianceWith209; homeLoanComplianceWith209.Clean = value; _homeLoanComplianceWith209 = homeLoanComplianceWith209;
                var id = _id; id.Clean = value; _id = id;
                var lenderDeterminedBorrowersInterest = _lenderDeterminedBorrowersInterest; lenderDeterminedBorrowersInterest.Clean = value; _lenderDeterminedBorrowersInterest = lenderDeterminedBorrowersInterest;
                var newLoanIsGuaranteedIndicator = _newLoanIsGuaranteedIndicator; newLoanIsGuaranteedIndicator.Clean = value; _newLoanIsGuaranteedIndicator = newLoanIsGuaranteedIndicator;
                var newLoanIsNegativeAmortizationFeatureIndicator = _newLoanIsNegativeAmortizationFeatureIndicator; newLoanIsNegativeAmortizationFeatureIndicator.Clean = value; _newLoanIsNegativeAmortizationFeatureIndicator = newLoanIsNegativeAmortizationFeatureIndicator;
                var newLoanIsSafeHarborQM = _newLoanIsSafeHarborQM; newLoanIsSafeHarborQM.Clean = value; _newLoanIsSafeHarborQM = newLoanIsSafeHarborQM;
                var newLoanIsSpecialMortgageOriginatedIndicator = _newLoanIsSpecialMortgageOriginatedIndicator; newLoanIsSpecialMortgageOriginatedIndicator.Clean = value; _newLoanIsSpecialMortgageOriginatedIndicator = newLoanIsSpecialMortgageOriginatedIndicator;
                var newLoanPaymentWithMiDifference = _newLoanPaymentWithMiDifference; newLoanPaymentWithMiDifference.Clean = value; _newLoanPaymentWithMiDifference = newLoanPaymentWithMiDifference;
                var newLoanPaymentWithObligationDifference = _newLoanPaymentWithObligationDifference; newLoanPaymentWithObligationDifference.Clean = value; _newLoanPaymentWithObligationDifference = newLoanPaymentWithObligationDifference;
                var newLoanPayOffConsolidateDebtIndicator = _newLoanPayOffConsolidateDebtIndicator; newLoanPayOffConsolidateDebtIndicator.Clean = value; _newLoanPayOffConsolidateDebtIndicator = newLoanPayOffConsolidateDebtIndicator;
                var newLoanWeightedAverageInterestRatePercent = _newLoanWeightedAverageInterestRatePercent; newLoanWeightedAverageInterestRatePercent.Clean = value; _newLoanWeightedAverageInterestRatePercent = newLoanWeightedAverageInterestRatePercent;
                var obtainingLowerIntMonthlyPaymentIndicator = _obtainingLowerIntMonthlyPaymentIndicator; obtainingLowerIntMonthlyPaymentIndicator.Clean = value; _obtainingLowerIntMonthlyPaymentIndicator = obtainingLowerIntMonthlyPaymentIndicator;
                var obtainingLowerIntRateIndicator = _obtainingLowerIntRateIndicator; obtainingLowerIntRateIndicator.Clean = value; _obtainingLowerIntRateIndicator = obtainingLowerIntRateIndicator;
                var obtainingShortAmortScheduleIndicator = _obtainingShortAmortScheduleIndicator; obtainingShortAmortScheduleIndicator.Clean = value; _obtainingShortAmortScheduleIndicator = obtainingShortAmortScheduleIndicator;
                var otherReason = _otherReason; otherReason.Clean = value; _otherReason = otherReason;
                var otherReasonDescription = _otherReasonDescription; otherReasonDescription.Clean = value; _otherReasonDescription = otherReasonDescription;
                var printBorrowerInitialLinesIndicator = _printBorrowerInitialLinesIndicator; printBorrowerInitialLinesIndicator.Clean = value; _printBorrowerInitialLinesIndicator = printBorrowerInitialLinesIndicator;
                var proceedsOfNewLoanWillBeUsedIndicator = _proceedsOfNewLoanWillBeUsedIndicator; proceedsOfNewLoanWillBeUsedIndicator.Clean = value; _proceedsOfNewLoanWillBeUsedIndicator = proceedsOfNewLoanWillBeUsedIndicator;
                var receivingCashOutFromNewLoanGreaterThanClosingCostIndicator = _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator; receivingCashOutFromNewLoanGreaterThanClosingCostIndicator.Clean = value; _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator = receivingCashOutFromNewLoanGreaterThanClosingCostIndicator;
                var refinancingLoanIsHomeEquityIndicator = _refinancingLoanIsHomeEquityIndicator; refinancingLoanIsHomeEquityIndicator.Clean = value; _refinancingLoanIsHomeEquityIndicator = refinancingLoanIsHomeEquityIndicator;
                var refinancingRespondBonaFide = _refinancingRespondBonaFide; refinancingRespondBonaFide.Clean = value; _refinancingRespondBonaFide = refinancingRespondBonaFide;
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