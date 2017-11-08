using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class NetTangibleBenefit : IDirty
    {
        private DirtyValue<bool?> _aprNotExceedIndicator;
        public bool? AprNotExceedIndicator { get { return _aprNotExceedIndicator; } set { _aprNotExceedIndicator = value; } }
        private DirtyValue<bool?> _avoidingForeclosureIndicator;
        public bool? AvoidingForeclosureIndicator { get { return _avoidingForeclosureIndicator; } set { _avoidingForeclosureIndicator = value; } }
        private DirtyValue<bool?> _beneficialChangedForBorrowerIndicator;
        public bool? BeneficialChangedForBorrowerIndicator { get { return _beneficialChangedForBorrowerIndicator; } set { _beneficialChangedForBorrowerIndicator = value; } }
        private DirtyValue<string> _bonaFideFinancialEmergency;
        public string BonaFideFinancialEmergency { get { return _bonaFideFinancialEmergency; } set { _bonaFideFinancialEmergency = value; } }
        private DirtyValue<bool?> _borrowerCanRecoupCostofRefinancingIndicator;
        public bool? BorrowerCanRecoupCostofRefinancingIndicator { get { return _borrowerCanRecoupCostofRefinancingIndicator; } set { _borrowerCanRecoupCostofRefinancingIndicator = value; } }
        private DirtyValue<bool?> _borrowerCanRecoupIndicator;
        public bool? BorrowerCanRecoupIndicator { get { return _borrowerCanRecoupIndicator; } set { _borrowerCanRecoupIndicator = value; } }
        private DirtyValue<bool?> _borrowerMonthlyPaymentLowerThan20Indicator;
        public bool? BorrowerMonthlyPaymentLowerThan20Indicator { get { return _borrowerMonthlyPaymentLowerThan20Indicator; } set { _borrowerMonthlyPaymentLowerThan20Indicator = value; } }
        private DirtyValue<string> _borrowerReceivedReasonable;
        public string BorrowerReceivedReasonable { get { return _borrowerReceivedReasonable; } set { _borrowerReceivedReasonable = value; } }
        private DirtyValue<bool?> _borrowerReceivesAmountExcessCostAndFeesIndicator;
        public bool? BorrowerReceivesAmountExcessCostAndFeesIndicator { get { return _borrowerReceivesAmountExcessCostAndFeesIndicator; } set { _borrowerReceivesAmountExcessCostAndFeesIndicator = value; } }
        private DirtyValue<bool?> _changeLoanFromArmtoFixedIndicator;
        public bool? ChangeLoanFromArmtoFixedIndicator { get { return _changeLoanFromArmtoFixedIndicator; } set { _changeLoanFromArmtoFixedIndicator = value; } }
        private DirtyValue<bool?> _changingLoanToFixedRateIndicator;
        public bool? ChangingLoanToFixedRateIndicator { get { return _changingLoanToFixedRateIndicator; } set { _changingLoanToFixedRateIndicator = value; } }
        private DirtyValue<bool?> _consolidatingOtherExistingLoansIntoNewLoanIndicator;
        public bool? ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get { return _consolidatingOtherExistingLoansIntoNewLoanIndicator; } set { _consolidatingOtherExistingLoansIntoNewLoanIndicator = value; } }
        private DirtyValue<bool?> _eliminatingBalloonPaymentIndicator;
        public bool? EliminatingBalloonPaymentIndicator { get { return _eliminatingBalloonPaymentIndicator; } set { _eliminatingBalloonPaymentIndicator = value; } }
        private DirtyValue<bool?> _eliminatingNegArmIndicator;
        public bool? EliminatingNegArmIndicator { get { return _eliminatingNegArmIndicator; } set { _eliminatingNegArmIndicator = value; } }
        private DirtyValue<bool?> _eliminatingPrivateMortgageInsuranceIndicator;
        public bool? EliminatingPrivateMortgageInsuranceIndicator { get { return _eliminatingPrivateMortgageInsuranceIndicator; } set { _eliminatingPrivateMortgageInsuranceIndicator = value; } }
        private DirtyValue<decimal?> _existingLoanAprPercent;
        public decimal? ExistingLoanAprPercent { get { return _existingLoanAprPercent; } set { _existingLoanAprPercent = value; } }
        private DirtyValue<bool?> _existingLoanBalloonIndicator;
        public bool? ExistingLoanBalloonIndicator { get { return _existingLoanBalloonIndicator; } set { _existingLoanBalloonIndicator = value; } }
        private DirtyValue<decimal?> _existingLoanBorrowerReceivesCashOutAmount;
        public decimal? ExistingLoanBorrowerReceivesCashOutAmount { get { return _existingLoanBorrowerReceivesCashOutAmount; } set { _existingLoanBorrowerReceivesCashOutAmount = value; } }
        private DirtyValue<bool?> _existingLoanBorrowerReceivesCashOutIndicator;
        public bool? ExistingLoanBorrowerReceivesCashOutIndicator { get { return _existingLoanBorrowerReceivesCashOutIndicator; } set { _existingLoanBorrowerReceivesCashOutIndicator = value; } }
        private DirtyValue<decimal?> _existingLoanBottomRatioPercent;
        public decimal? ExistingLoanBottomRatioPercent { get { return _existingLoanBottomRatioPercent; } set { _existingLoanBottomRatioPercent = value; } }
        private DirtyValue<DateTime?> _existingLoanDateLoanClosed;
        public DateTime? ExistingLoanDateLoanClosed { get { return _existingLoanDateLoanClosed; } set { _existingLoanDateLoanClosed = value; } }
        private DirtyValue<decimal?> _existingLoanFullyIndexRatePercent;
        public decimal? ExistingLoanFullyIndexRatePercent { get { return _existingLoanFullyIndexRatePercent; } set { _existingLoanFullyIndexRatePercent = value; } }
        private DirtyValue<decimal?> _existingLoanInterestRatePercent;
        public decimal? ExistingLoanInterestRatePercent { get { return _existingLoanInterestRatePercent; } set { _existingLoanInterestRatePercent = value; } }
        private DirtyValue<bool?> _existingLoanIsGuaranteedIndicator;
        public bool? ExistingLoanIsGuaranteedIndicator { get { return _existingLoanIsGuaranteedIndicator; } set { _existingLoanIsGuaranteedIndicator = value; } }
        private DirtyValue<bool?> _existingLoanIsLoanRefinancedAsSpecial;
        public bool? ExistingLoanIsLoanRefinancedAsSpecial { get { return _existingLoanIsLoanRefinancedAsSpecial; } set { _existingLoanIsLoanRefinancedAsSpecial = value; } }
        private DirtyValue<bool?> _existingLoanIsNegativeAmortizationFeatureIndicator;
        public bool? ExistingLoanIsNegativeAmortizationFeatureIndicator { get { return _existingLoanIsNegativeAmortizationFeatureIndicator; } set { _existingLoanIsNegativeAmortizationFeatureIndicator = value; } }
        private DirtyValue<bool?> _existingLoanIsPrepaymentPenalty;
        public bool? ExistingLoanIsPrepaymentPenalty { get { return _existingLoanIsPrepaymentPenalty; } set { _existingLoanIsPrepaymentPenalty = value; } }
        private StringEnumValue<AmortizationType> _existingLoanLoanAmortizationType;
        public StringEnumValue<AmortizationType> ExistingLoanLoanAmortizationType { get { return _existingLoanLoanAmortizationType; } set { _existingLoanLoanAmortizationType = value; } }
        private DirtyValue<decimal?> _existingLoanLoanAmount;
        public decimal? ExistingLoanLoanAmount { get { return _existingLoanLoanAmount; } set { _existingLoanLoanAmount = value; } }
        private DirtyValue<int?> _existingLoanLoanTerm;
        public int? ExistingLoanLoanTerm { get { return _existingLoanLoanTerm; } set { _existingLoanLoanTerm = value; } }
        private DirtyValue<decimal?> _existingLoanLtvPercent;
        public decimal? ExistingLoanLtvPercent { get { return _existingLoanLtvPercent; } set { _existingLoanLtvPercent = value; } }
        private DirtyValue<decimal?> _existingLoanMaximumRatePercent;
        public decimal? ExistingLoanMaximumRatePercent { get { return _existingLoanMaximumRatePercent; } set { _existingLoanMaximumRatePercent = value; } }
        private DirtyValue<int?> _existingLoanMonthsRemaining;
        public int? ExistingLoanMonthsRemaining { get { return _existingLoanMonthsRemaining; } set { _existingLoanMonthsRemaining = value; } }
        private DirtyValue<decimal?> _existingLoanPaymentAmount;
        public decimal? ExistingLoanPaymentAmount { get { return _existingLoanPaymentAmount; } set { _existingLoanPaymentAmount = value; } }
        private DirtyValue<decimal?> _existingLoanPaymentDifference;
        public decimal? ExistingLoanPaymentDifference { get { return _existingLoanPaymentDifference; } set { _existingLoanPaymentDifference = value; } }
        private DirtyValue<decimal?> _existingLoanPaymentIncludeMiObligation;
        public decimal? ExistingLoanPaymentIncludeMiObligation { get { return _existingLoanPaymentIncludeMiObligation; } set { _existingLoanPaymentIncludeMiObligation = value; } }
        private DirtyValue<decimal?> _existingLoanPaymentIncludeMortgageInsurance;
        public decimal? ExistingLoanPaymentIncludeMortgageInsurance { get { return _existingLoanPaymentIncludeMortgageInsurance; } set { _existingLoanPaymentIncludeMortgageInsurance = value; } }
        private DirtyValue<decimal?> _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan;
        public decimal? ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get { return _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan; } set { _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan = value; } }
        private StringEnumValue<PrepaymentPenaltyBasedOn> _existingLoanPrepaymentPenaltyBasedOn;
        public StringEnumValue<PrepaymentPenaltyBasedOn> ExistingLoanPrepaymentPenaltyBasedOn { get { return _existingLoanPrepaymentPenaltyBasedOn; } set { _existingLoanPrepaymentPenaltyBasedOn = value; } }
        private DirtyValue<decimal?> _existingLoanPrepaymentPenaltyPercentage;
        public decimal? ExistingLoanPrepaymentPenaltyPercentage { get { return _existingLoanPrepaymentPenaltyPercentage; } set { _existingLoanPrepaymentPenaltyPercentage = value; } }
        private DirtyValue<int?> _existingLoanPrepaymentPenaltyTerm;
        public int? ExistingLoanPrepaymentPenaltyTerm { get { return _existingLoanPrepaymentPenaltyTerm; } set { _existingLoanPrepaymentPenaltyTerm = value; } }
        private StringEnumValue<ExistingLoanProvidedByLicenseeType> _existingLoanProvidedByLicenseeType;
        public StringEnumValue<ExistingLoanProvidedByLicenseeType> ExistingLoanProvidedByLicenseeType { get { return _existingLoanProvidedByLicenseeType; } set { _existingLoanProvidedByLicenseeType = value; } }
        private StringEnumValue<LoanPurposeType> _existingLoanPurposeType;
        public StringEnumValue<LoanPurposeType> ExistingLoanPurposeType { get { return _existingLoanPurposeType; } set { _existingLoanPurposeType = value; } }
        private DirtyValue<int?> _existingLoanRecoupCostsYears;
        public int? ExistingLoanRecoupCostsYears { get { return _existingLoanRecoupCostsYears; } set { _existingLoanRecoupCostsYears = value; } }
        private DirtyValue<decimal?> _existingLoanSavingsAmount;
        public decimal? ExistingLoanSavingsAmount { get { return _existingLoanSavingsAmount; } set { _existingLoanSavingsAmount = value; } }
        private DirtyValue<decimal?> _existingLoanTotalDebtPayoff;
        public decimal? ExistingLoanTotalDebtPayoff { get { return _existingLoanTotalDebtPayoff; } set { _existingLoanTotalDebtPayoff = value; } }
        private DirtyValue<decimal?> _existingLoanWeightedAverageInterestRatePercent;
        public decimal? ExistingLoanWeightedAverageInterestRatePercent { get { return _existingLoanWeightedAverageInterestRatePercent; } set { _existingLoanWeightedAverageInterestRatePercent = value; } }
        private DirtyValue<bool?> _homeLoanComplianceWith209;
        public bool? HomeLoanComplianceWith209 { get { return _homeLoanComplianceWith209; } set { _homeLoanComplianceWith209 = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _lenderDeterminedBorrowersInterest;
        public bool? LenderDeterminedBorrowersInterest { get { return _lenderDeterminedBorrowersInterest; } set { _lenderDeterminedBorrowersInterest = value; } }
        private DirtyValue<bool?> _newLoanIsGuaranteedIndicator;
        public bool? NewLoanIsGuaranteedIndicator { get { return _newLoanIsGuaranteedIndicator; } set { _newLoanIsGuaranteedIndicator = value; } }
        private DirtyValue<bool?> _newLoanIsNegativeAmortizationFeatureIndicator;
        public bool? NewLoanIsNegativeAmortizationFeatureIndicator { get { return _newLoanIsNegativeAmortizationFeatureIndicator; } set { _newLoanIsNegativeAmortizationFeatureIndicator = value; } }
        private DirtyValue<bool?> _newLoanIsSafeHarborQM;
        public bool? NewLoanIsSafeHarborQM { get { return _newLoanIsSafeHarborQM; } set { _newLoanIsSafeHarborQM = value; } }
        private DirtyValue<bool?> _newLoanIsSpecialMortgageOriginatedIndicator;
        public bool? NewLoanIsSpecialMortgageOriginatedIndicator { get { return _newLoanIsSpecialMortgageOriginatedIndicator; } set { _newLoanIsSpecialMortgageOriginatedIndicator = value; } }
        private DirtyValue<decimal?> _newLoanPaymentWithMiDifference;
        public decimal? NewLoanPaymentWithMiDifference { get { return _newLoanPaymentWithMiDifference; } set { _newLoanPaymentWithMiDifference = value; } }
        private DirtyValue<decimal?> _newLoanPaymentWithObligationDifference;
        public decimal? NewLoanPaymentWithObligationDifference { get { return _newLoanPaymentWithObligationDifference; } set { _newLoanPaymentWithObligationDifference = value; } }
        private DirtyValue<bool?> _newLoanPayOffConsolidateDebtIndicator;
        public bool? NewLoanPayOffConsolidateDebtIndicator { get { return _newLoanPayOffConsolidateDebtIndicator; } set { _newLoanPayOffConsolidateDebtIndicator = value; } }
        private DirtyValue<decimal?> _newLoanWeightedAverageInterestRatePercent;
        public decimal? NewLoanWeightedAverageInterestRatePercent { get { return _newLoanWeightedAverageInterestRatePercent; } set { _newLoanWeightedAverageInterestRatePercent = value; } }
        private DirtyValue<bool?> _obtainingLowerIntMonthlyPaymentIndicator;
        public bool? ObtainingLowerIntMonthlyPaymentIndicator { get { return _obtainingLowerIntMonthlyPaymentIndicator; } set { _obtainingLowerIntMonthlyPaymentIndicator = value; } }
        private DirtyValue<bool?> _obtainingLowerIntRateIndicator;
        public bool? ObtainingLowerIntRateIndicator { get { return _obtainingLowerIntRateIndicator; } set { _obtainingLowerIntRateIndicator = value; } }
        private DirtyValue<bool?> _obtainingShortAmortScheduleIndicator;
        public bool? ObtainingShortAmortScheduleIndicator { get { return _obtainingShortAmortScheduleIndicator; } set { _obtainingShortAmortScheduleIndicator = value; } }
        private DirtyValue<bool?> _otherReason;
        public bool? OtherReason { get { return _otherReason; } set { _otherReason = value; } }
        private DirtyValue<string> _otherReasonDescription;
        public string OtherReasonDescription { get { return _otherReasonDescription; } set { _otherReasonDescription = value; } }
        private DirtyValue<bool?> _printBorrowerInitialLinesIndicator;
        public bool? PrintBorrowerInitialLinesIndicator { get { return _printBorrowerInitialLinesIndicator; } set { _printBorrowerInitialLinesIndicator = value; } }
        private DirtyValue<bool?> _proceedsOfNewLoanWillBeUsedIndicator;
        public bool? ProceedsOfNewLoanWillBeUsedIndicator { get { return _proceedsOfNewLoanWillBeUsedIndicator; } set { _proceedsOfNewLoanWillBeUsedIndicator = value; } }
        private DirtyValue<bool?> _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator;
        public bool? ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get { return _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator; } set { _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator = value; } }
        private DirtyValue<bool?> _refinancingLoanIsHomeEquityIndicator;
        public bool? RefinancingLoanIsHomeEquityIndicator { get { return _refinancingLoanIsHomeEquityIndicator; } set { _refinancingLoanIsHomeEquityIndicator = value; } }
        private DirtyValue<bool?> _refinancingRespondBonaFide;
        public bool? RefinancingRespondBonaFide { get { return _refinancingRespondBonaFide; } set { _refinancingRespondBonaFide = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _aprNotExceedIndicator.Dirty
                    || _avoidingForeclosureIndicator.Dirty
                    || _beneficialChangedForBorrowerIndicator.Dirty
                    || _bonaFideFinancialEmergency.Dirty
                    || _borrowerCanRecoupCostofRefinancingIndicator.Dirty
                    || _borrowerCanRecoupIndicator.Dirty
                    || _borrowerMonthlyPaymentLowerThan20Indicator.Dirty
                    || _borrowerReceivedReasonable.Dirty
                    || _borrowerReceivesAmountExcessCostAndFeesIndicator.Dirty
                    || _changeLoanFromArmtoFixedIndicator.Dirty
                    || _changingLoanToFixedRateIndicator.Dirty
                    || _consolidatingOtherExistingLoansIntoNewLoanIndicator.Dirty
                    || _eliminatingBalloonPaymentIndicator.Dirty
                    || _eliminatingNegArmIndicator.Dirty
                    || _eliminatingPrivateMortgageInsuranceIndicator.Dirty
                    || _existingLoanAprPercent.Dirty
                    || _existingLoanBalloonIndicator.Dirty
                    || _existingLoanBorrowerReceivesCashOutAmount.Dirty
                    || _existingLoanBorrowerReceivesCashOutIndicator.Dirty
                    || _existingLoanBottomRatioPercent.Dirty
                    || _existingLoanDateLoanClosed.Dirty
                    || _existingLoanFullyIndexRatePercent.Dirty
                    || _existingLoanInterestRatePercent.Dirty
                    || _existingLoanIsGuaranteedIndicator.Dirty
                    || _existingLoanIsLoanRefinancedAsSpecial.Dirty
                    || _existingLoanIsNegativeAmortizationFeatureIndicator.Dirty
                    || _existingLoanIsPrepaymentPenalty.Dirty
                    || _existingLoanLoanAmortizationType.Dirty
                    || _existingLoanLoanAmount.Dirty
                    || _existingLoanLoanTerm.Dirty
                    || _existingLoanLtvPercent.Dirty
                    || _existingLoanMaximumRatePercent.Dirty
                    || _existingLoanMonthsRemaining.Dirty
                    || _existingLoanPaymentAmount.Dirty
                    || _existingLoanPaymentDifference.Dirty
                    || _existingLoanPaymentIncludeMiObligation.Dirty
                    || _existingLoanPaymentIncludeMortgageInsurance.Dirty
                    || _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan.Dirty
                    || _existingLoanPrepaymentPenaltyBasedOn.Dirty
                    || _existingLoanPrepaymentPenaltyPercentage.Dirty
                    || _existingLoanPrepaymentPenaltyTerm.Dirty
                    || _existingLoanProvidedByLicenseeType.Dirty
                    || _existingLoanPurposeType.Dirty
                    || _existingLoanRecoupCostsYears.Dirty
                    || _existingLoanSavingsAmount.Dirty
                    || _existingLoanTotalDebtPayoff.Dirty
                    || _existingLoanWeightedAverageInterestRatePercent.Dirty
                    || _homeLoanComplianceWith209.Dirty
                    || _id.Dirty
                    || _lenderDeterminedBorrowersInterest.Dirty
                    || _newLoanIsGuaranteedIndicator.Dirty
                    || _newLoanIsNegativeAmortizationFeatureIndicator.Dirty
                    || _newLoanIsSafeHarborQM.Dirty
                    || _newLoanIsSpecialMortgageOriginatedIndicator.Dirty
                    || _newLoanPaymentWithMiDifference.Dirty
                    || _newLoanPaymentWithObligationDifference.Dirty
                    || _newLoanPayOffConsolidateDebtIndicator.Dirty
                    || _newLoanWeightedAverageInterestRatePercent.Dirty
                    || _obtainingLowerIntMonthlyPaymentIndicator.Dirty
                    || _obtainingLowerIntRateIndicator.Dirty
                    || _obtainingShortAmortScheduleIndicator.Dirty
                    || _otherReason.Dirty
                    || _otherReasonDescription.Dirty
                    || _printBorrowerInitialLinesIndicator.Dirty
                    || _proceedsOfNewLoanWillBeUsedIndicator.Dirty
                    || _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator.Dirty
                    || _refinancingLoanIsHomeEquityIndicator.Dirty
                    || _refinancingRespondBonaFide.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _aprNotExceedIndicator.Dirty = value;
                _avoidingForeclosureIndicator.Dirty = value;
                _beneficialChangedForBorrowerIndicator.Dirty = value;
                _bonaFideFinancialEmergency.Dirty = value;
                _borrowerCanRecoupCostofRefinancingIndicator.Dirty = value;
                _borrowerCanRecoupIndicator.Dirty = value;
                _borrowerMonthlyPaymentLowerThan20Indicator.Dirty = value;
                _borrowerReceivedReasonable.Dirty = value;
                _borrowerReceivesAmountExcessCostAndFeesIndicator.Dirty = value;
                _changeLoanFromArmtoFixedIndicator.Dirty = value;
                _changingLoanToFixedRateIndicator.Dirty = value;
                _consolidatingOtherExistingLoansIntoNewLoanIndicator.Dirty = value;
                _eliminatingBalloonPaymentIndicator.Dirty = value;
                _eliminatingNegArmIndicator.Dirty = value;
                _eliminatingPrivateMortgageInsuranceIndicator.Dirty = value;
                _existingLoanAprPercent.Dirty = value;
                _existingLoanBalloonIndicator.Dirty = value;
                _existingLoanBorrowerReceivesCashOutAmount.Dirty = value;
                _existingLoanBorrowerReceivesCashOutIndicator.Dirty = value;
                _existingLoanBottomRatioPercent.Dirty = value;
                _existingLoanDateLoanClosed.Dirty = value;
                _existingLoanFullyIndexRatePercent.Dirty = value;
                _existingLoanInterestRatePercent.Dirty = value;
                _existingLoanIsGuaranteedIndicator.Dirty = value;
                _existingLoanIsLoanRefinancedAsSpecial.Dirty = value;
                _existingLoanIsNegativeAmortizationFeatureIndicator.Dirty = value;
                _existingLoanIsPrepaymentPenalty.Dirty = value;
                _existingLoanLoanAmortizationType.Dirty = value;
                _existingLoanLoanAmount.Dirty = value;
                _existingLoanLoanTerm.Dirty = value;
                _existingLoanLtvPercent.Dirty = value;
                _existingLoanMaximumRatePercent.Dirty = value;
                _existingLoanMonthsRemaining.Dirty = value;
                _existingLoanPaymentAmount.Dirty = value;
                _existingLoanPaymentDifference.Dirty = value;
                _existingLoanPaymentIncludeMiObligation.Dirty = value;
                _existingLoanPaymentIncludeMortgageInsurance.Dirty = value;
                _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan.Dirty = value;
                _existingLoanPrepaymentPenaltyBasedOn.Dirty = value;
                _existingLoanPrepaymentPenaltyPercentage.Dirty = value;
                _existingLoanPrepaymentPenaltyTerm.Dirty = value;
                _existingLoanProvidedByLicenseeType.Dirty = value;
                _existingLoanPurposeType.Dirty = value;
                _existingLoanRecoupCostsYears.Dirty = value;
                _existingLoanSavingsAmount.Dirty = value;
                _existingLoanTotalDebtPayoff.Dirty = value;
                _existingLoanWeightedAverageInterestRatePercent.Dirty = value;
                _homeLoanComplianceWith209.Dirty = value;
                _id.Dirty = value;
                _lenderDeterminedBorrowersInterest.Dirty = value;
                _newLoanIsGuaranteedIndicator.Dirty = value;
                _newLoanIsNegativeAmortizationFeatureIndicator.Dirty = value;
                _newLoanIsSafeHarborQM.Dirty = value;
                _newLoanIsSpecialMortgageOriginatedIndicator.Dirty = value;
                _newLoanPaymentWithMiDifference.Dirty = value;
                _newLoanPaymentWithObligationDifference.Dirty = value;
                _newLoanPayOffConsolidateDebtIndicator.Dirty = value;
                _newLoanWeightedAverageInterestRatePercent.Dirty = value;
                _obtainingLowerIntMonthlyPaymentIndicator.Dirty = value;
                _obtainingLowerIntRateIndicator.Dirty = value;
                _obtainingShortAmortScheduleIndicator.Dirty = value;
                _otherReason.Dirty = value;
                _otherReasonDescription.Dirty = value;
                _printBorrowerInitialLinesIndicator.Dirty = value;
                _proceedsOfNewLoanWillBeUsedIndicator.Dirty = value;
                _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator.Dirty = value;
                _refinancingLoanIsHomeEquityIndicator.Dirty = value;
                _refinancingRespondBonaFide.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}