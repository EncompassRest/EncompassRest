using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NetTangibleBenefit
    /// </summary>
    public sealed partial class NetTangibleBenefit : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _aprNotExceedIndicator;
        private DirtyValue<bool?> _avoidingForeclosureIndicator;
        private DirtyValue<bool?> _beneficialChangedForBorrowerIndicator;
        private DirtyValue<string> _bonaFideFinancialEmergency;
        private DirtyValue<bool?> _borrowerCanRecoupCostofRefinancingIndicator;
        private DirtyValue<bool?> _borrowerCanRecoupIndicator;
        private DirtyValue<bool?> _borrowerMonthlyPaymentLowerThan20Indicator;
        private DirtyValue<string> _borrowerReceivedReasonable;
        private DirtyValue<bool?> _borrowerReceivesAmountExcessCostAndFeesIndicator;
        private DirtyValue<bool?> _changeLoanFromArmtoFixedIndicator;
        private DirtyValue<bool?> _changingLoanToFixedRateIndicator;
        private DirtyValue<bool?> _consolidatingOtherExistingLoansIntoNewLoanIndicator;
        private DirtyValue<bool?> _eliminatingBalloonPaymentIndicator;
        private DirtyValue<bool?> _eliminatingNegArmIndicator;
        private DirtyValue<bool?> _eliminatingPrivateMortgageInsuranceIndicator;
        private DirtyValue<decimal?> _existingLoanAprPercent;
        private DirtyValue<bool?> _existingLoanBalloonIndicator;
        private DirtyValue<decimal?> _existingLoanBorrowerReceivesCashOutAmount;
        private DirtyValue<bool?> _existingLoanBorrowerReceivesCashOutIndicator;
        private DirtyValue<decimal?> _existingLoanBottomRatioPercent;
        private DirtyValue<DateTime?> _existingLoanDateLoanClosed;
        private DirtyValue<decimal?> _existingLoanFullyIndexRatePercent;
        private DirtyValue<decimal?> _existingLoanInterestRatePercent;
        private DirtyValue<bool?> _existingLoanIsGuaranteedIndicator;
        private DirtyValue<bool?> _existingLoanIsLoanRefinancedAsSpecial;
        private DirtyValue<bool?> _existingLoanIsNegativeAmortizationFeatureIndicator;
        private DirtyValue<bool?> _existingLoanIsPrepaymentPenalty;
        private DirtyValue<StringEnumValue<AmortizationType>> _existingLoanLoanAmortizationType;
        private DirtyValue<decimal?> _existingLoanLoanAmount;
        private DirtyValue<int?> _existingLoanLoanTerm;
        private DirtyValue<decimal?> _existingLoanLtvPercent;
        private DirtyValue<decimal?> _existingLoanMaximumRatePercent;
        private DirtyValue<int?> _existingLoanMonthsRemaining;
        private DirtyValue<decimal?> _existingLoanPaymentAmount;
        private DirtyValue<decimal?> _existingLoanPaymentDifference;
        private DirtyValue<decimal?> _existingLoanPaymentIncludeMiObligation;
        private DirtyValue<decimal?> _existingLoanPaymentIncludeMortgageInsurance;
        private DirtyValue<decimal?> _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan;
        private DirtyValue<StringEnumValue<PrepaymentPenaltyBasedOn>> _existingLoanPrepaymentPenaltyBasedOn;
        private DirtyValue<decimal?> _existingLoanPrepaymentPenaltyPercentage;
        private DirtyValue<int?> _existingLoanPrepaymentPenaltyTerm;
        private DirtyValue<StringEnumValue<ExistingLoanProvidedByLicenseeType>> _existingLoanProvidedByLicenseeType;
        private DirtyValue<StringEnumValue<LoanPurposeType>> _existingLoanPurposeType;
        private DirtyValue<int?> _existingLoanRecoupCostsYears;
        private DirtyValue<decimal?> _existingLoanSavingsAmount;
        private DirtyValue<decimal?> _existingLoanTotalDebtPayoff;
        private DirtyValue<decimal?> _existingLoanWeightedAverageInterestRatePercent;
        private DirtyValue<bool?> _homeLoanComplianceWith209;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _lenderDeterminedBorrowersInterest;
        private DirtyValue<bool?> _newLoanIsGuaranteedIndicator;
        private DirtyValue<bool?> _newLoanIsNegativeAmortizationFeatureIndicator;
        private DirtyValue<bool?> _newLoanIsSafeHarborQM;
        private DirtyValue<bool?> _newLoanIsSpecialMortgageOriginatedIndicator;
        private DirtyValue<decimal?> _newLoanPaymentWithMiDifference;
        private DirtyValue<decimal?> _newLoanPaymentWithObligationDifference;
        private DirtyValue<bool?> _newLoanPayOffConsolidateDebtIndicator;
        private DirtyValue<decimal?> _newLoanWeightedAverageInterestRatePercent;
        private DirtyValue<bool?> _obtainingLowerIntMonthlyPaymentIndicator;
        private DirtyValue<bool?> _obtainingLowerIntRateIndicator;
        private DirtyValue<bool?> _obtainingShortAmortScheduleIndicator;
        private DirtyValue<bool?> _otherReason;
        private DirtyValue<string> _otherReasonDescription;
        private DirtyValue<bool?> _printBorrowerInitialLinesIndicator;
        private DirtyValue<bool?> _proceedsOfNewLoanWillBeUsedIndicator;
        private DirtyValue<bool?> _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator;
        private DirtyValue<bool?> _refinancingLoanIsHomeEquityIndicator;
        private DirtyValue<bool?> _refinancingRespondBonaFide;

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The APR of the new refinancing loan at consummation does not exceed by more than 2.5% for closed-end first lien loans...? [NTB.X52]
        /// </summary>
        public bool? AprNotExceedIndicator { get => _aprNotExceedIndicator; set => SetField(ref _aprNotExceedIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Avoiding foreclosure? [NTB.X44]
        /// </summary>
        public bool? AvoidingForeclosureIndicator { get => _avoidingForeclosureIndicator; set => SetField(ref _avoidingForeclosureIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - There is a beneficial change for the borrower in the duration of the loan? [NTB.X50]
        /// </summary>
        public bool? BeneficialChangedForBorrowerIndicator { get => _beneficialChangedForBorrowerIndicator; set => SetField(ref _beneficialChangedForBorrowerIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Old/Current Loan Info - Bona Fide Financial Emergency [NTB.X58]
        /// </summary>
        public string BonaFideFinancialEmergency { get => _bonaFideFinancialEmergency; set => SetField(ref _bonaFideFinancialEmergency, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The borrower(s) is/are able to recoup the costs of refinancing the loan within two years and reduce the interest rate by 2...? [NTB.X57]
        /// </summary>
        public bool? BorrowerCanRecoupCostofRefinancingIndicator { get => _borrowerCanRecoupCostofRefinancingIndicator; set => SetField(ref _borrowerCanRecoupCostofRefinancingIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The borrower is able to recoup the costs of refinancing the home loan within two years, taking into account the costs and...? [NTB.X54]
        /// </summary>
        public bool? BorrowerCanRecoupIndicator { get => _borrowerCanRecoupIndicator; set => SetField(ref _borrowerCanRecoupIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The borrower's monthly payment to pay the new consolidated debt is a minimum of 20% lower than the total of all monthly...? [NTB.X55]
        /// </summary>
        public bool? BorrowerMonthlyPaymentLowerThan20Indicator { get => _borrowerMonthlyPaymentLowerThan20Indicator; set => SetField(ref _borrowerMonthlyPaymentLowerThan20Indicator, value); }

        /// <summary>
        /// Net Tangible Benefit Old/Current Loan Info - Borrower Received Reasonable, Tangible Net Benefit [NTB.X59]
        /// </summary>
        public string BorrowerReceivedReasonable { get => _borrowerReceivedReasonable; set => SetField(ref _borrowerReceivedReasonable, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The borrower(s) receive(s) a reasonable amount of cash in excess of and in relation to the cost and fees as part of the refinancing? [NTB.X51]
        /// </summary>
        public bool? BorrowerReceivesAmountExcessCostAndFeesIndicator { get => _borrowerReceivesAmountExcessCostAndFeesIndicator; set => SetField(ref _borrowerReceivesAmountExcessCostAndFeesIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - There is a change from an adjustable rate loan to a fixed rate loan, taking into account costs and fees and the costs can be...? [NTB.X56]
        /// </summary>
        public bool? ChangeLoanFromArmtoFixedIndicator { get => _changeLoanFromArmtoFixedIndicator; set => SetField(ref _changeLoanFromArmtoFixedIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Changing from an adjustable rate loan to a fixed rate loan? [NTB.X40]
        /// </summary>
        public bool? ChangingLoanToFixedRateIndicator { get => _changingLoanToFixedRateIndicator; set => SetField(ref _changingLoanToFixedRateIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Consolidating other existing loans into a new mortgage loan? [NTB.X46]
        /// </summary>
        public bool? ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get => _consolidatingOtherExistingLoansIntoNewLoanIndicator; set => SetField(ref _consolidatingOtherExistingLoansIntoNewLoanIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Eliminating a balloon payment feature? [NTB.X42]
        /// </summary>
        public bool? EliminatingBalloonPaymentIndicator { get => _eliminatingBalloonPaymentIndicator; set => SetField(ref _eliminatingBalloonPaymentIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Eliminating a negative amortization feature? [NTB.X41]
        /// </summary>
        public bool? EliminatingNegArmIndicator { get => _eliminatingNegArmIndicator; set => SetField(ref _eliminatingNegArmIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Eliminating private mortgage insurance? [NTB.X45]
        /// </summary>
        public bool? EliminatingPrivateMortgageInsuranceIndicator { get => _eliminatingPrivateMortgageInsuranceIndicator; set => SetField(ref _eliminatingPrivateMortgageInsuranceIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - APR [NTB.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLoanAprPercent { get => _existingLoanAprPercent; set => SetField(ref _existingLoanAprPercent, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Balloon Indicator [NTB.X61]
        /// </summary>
        public bool? ExistingLoanBalloonIndicator { get => _existingLoanBalloonIndicator; set => SetField(ref _existingLoanBalloonIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Borrower Receives Cash Out Amount [NTB.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanBorrowerReceivesCashOutAmount { get => _existingLoanBorrowerReceivesCashOutAmount; set => SetField(ref _existingLoanBorrowerReceivesCashOutAmount, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Is the Borrower receiving any cash out from the transaction? [NTB.X30]
        /// </summary>
        public bool? ExistingLoanBorrowerReceivesCashOutIndicator { get => _existingLoanBorrowerReceivesCashOutIndicator; set => SetField(ref _existingLoanBorrowerReceivesCashOutIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Bottom Ratio [NTB.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLoanBottomRatioPercent { get => _existingLoanBottomRatioPercent; set => SetField(ref _existingLoanBottomRatioPercent, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Date Loan Closed [NTB.X1]
        /// </summary>
        public DateTime? ExistingLoanDateLoanClosed { get => _existingLoanDateLoanClosed; set => SetField(ref _existingLoanDateLoanClosed, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Fully Index Rate [NTB.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLoanFullyIndexRatePercent { get => _existingLoanFullyIndexRatePercent; set => SetField(ref _existingLoanFullyIndexRatePercent, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Interest Rate [NTB.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLoanInterestRatePercent { get => _existingLoanInterestRatePercent; set => SetField(ref _existingLoanInterestRatePercent, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The existing loan is guaranteed, originated, or funded by the Federal Housing Administration, the Department of Veterans Affairs, or other State or federal housing finance agencies. [NTB.X49]
        /// </summary>
        public bool? ExistingLoanIsGuaranteedIndicator { get => _existingLoanIsGuaranteedIndicator; set => SetField(ref _existingLoanIsGuaranteedIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The existing loan being refinanced is a special mortgage originated, subsidized, or guaranteed by or through a state, tribal or local... [NTB.X15]
        /// </summary>
        public bool? ExistingLoanIsLoanRefinancedAsSpecial { get => _existingLoanIsLoanRefinancedAsSpecial; set => SetField(ref _existingLoanIsLoanRefinancedAsSpecial, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Negative Amortization Feature [NTB.X12]
        /// </summary>
        public bool? ExistingLoanIsNegativeAmortizationFeatureIndicator { get => _existingLoanIsNegativeAmortizationFeatureIndicator; set => SetField(ref _existingLoanIsNegativeAmortizationFeatureIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty? [NTB.X13]
        /// </summary>
        public bool? ExistingLoanIsPrepaymentPenalty { get => _existingLoanIsPrepaymentPenalty; set => SetField(ref _existingLoanIsPrepaymentPenalty, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Loan Amortization Type [NTB.X5]
        /// </summary>
        public StringEnumValue<AmortizationType> ExistingLoanLoanAmortizationType { get => _existingLoanLoanAmortizationType; set => SetField(ref _existingLoanLoanAmortizationType, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Loan Amount [NTB.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanLoanAmount { get => _existingLoanLoanAmount; set => SetField(ref _existingLoanLoanAmount, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Loan Term [NTB.X3]
        /// </summary>
        public int? ExistingLoanLoanTerm { get => _existingLoanLoanTerm; set => SetField(ref _existingLoanLoanTerm, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - LTV [NTB.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLoanLtvPercent { get => _existingLoanLtvPercent; set => SetField(ref _existingLoanLtvPercent, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Maximum Rate [NTB.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLoanMaximumRatePercent { get => _existingLoanMaximumRatePercent; set => SetField(ref _existingLoanMaximumRatePercent, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Months Remaining [NTB.X4]
        /// </summary>
        public int? ExistingLoanMonthsRemaining { get => _existingLoanMonthsRemaining; set => SetField(ref _existingLoanMonthsRemaining, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Payment Amount [NTB.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanPaymentAmount { get => _existingLoanPaymentAmount; set => SetField(ref _existingLoanPaymentAmount, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Difference between current payment and new payment [NTB.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanPaymentDifference { get => _existingLoanPaymentDifference; set => SetField(ref _existingLoanPaymentDifference, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Total Monthly Mortgage Obligation [NTB.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanPaymentIncludeMiObligation { get => _existingLoanPaymentIncludeMiObligation; set => SetField(ref _existingLoanPaymentIncludeMiObligation, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Payment with Mortgage Insurance [NTB.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanPaymentIncludeMortgageInsurance { get => _existingLoanPaymentIncludeMortgageInsurance; set => SetField(ref _existingLoanPaymentIncludeMortgageInsurance, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Amount of the Prepayment Penalty to be included in the new loan amount [NTB.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get => _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan; set => SetField(ref _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty Based On [NTB.X26]
        /// </summary>
        public StringEnumValue<PrepaymentPenaltyBasedOn> ExistingLoanPrepaymentPenaltyBasedOn { get => _existingLoanPrepaymentPenaltyBasedOn; set => SetField(ref _existingLoanPrepaymentPenaltyBasedOn, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty % [NTB.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLoanPrepaymentPenaltyPercentage { get => _existingLoanPrepaymentPenaltyPercentage; set => SetField(ref _existingLoanPrepaymentPenaltyPercentage, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty Term [NTB.X6]
        /// </summary>
        public int? ExistingLoanPrepaymentPenaltyTerm { get => _existingLoanPrepaymentPenaltyTerm; set => SetField(ref _existingLoanPrepaymentPenaltyTerm, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Existing Loan was provided by the Licensee, Affiliate of Licensee or Related Entity of Licensee? [NTB.X34]
        /// </summary>
        public StringEnumValue<ExistingLoanProvidedByLicenseeType> ExistingLoanProvidedByLicenseeType { get => _existingLoanProvidedByLicenseeType; set => SetField(ref _existingLoanProvidedByLicenseeType, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Loan Purpose [NTB.X19]
        /// </summary>
        public StringEnumValue<LoanPurposeType> ExistingLoanPurposeType { get => _existingLoanPurposeType; set => SetField(ref _existingLoanPurposeType, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Recoup Costs in Years [NTB.X33]
        /// </summary>
        public int? ExistingLoanRecoupCostsYears { get => _existingLoanRecoupCostsYears; set => SetField(ref _existingLoanRecoupCostsYears, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Savings Amount [NTB.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanSavingsAmount { get => _existingLoanSavingsAmount; set => SetField(ref _existingLoanSavingsAmount, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Total Debt Paid Off [NTB.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExistingLoanTotalDebtPayoff { get => _existingLoanTotalDebtPayoff; set => SetField(ref _existingLoanTotalDebtPayoff, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Weighted Average Interest Rate [NTB.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ExistingLoanWeightedAverageInterestRatePercent { get => _existingLoanWeightedAverageInterestRatePercent; set => SetField(ref _existingLoanWeightedAverageInterestRatePercent, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - A Home Loan is in Compliance With 209 CMR 53.03 if it Meets Any of The Following (Check All That Apply) [NTB.X62]
        /// </summary>
        public bool? HomeLoanComplianceWith209 { get => _homeLoanComplianceWith209; set => SetField(ref _homeLoanComplianceWith209, value); }

        /// <summary>
        /// NetTangibleBenefit Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Lender Has Determined That This New Home Loan is in The Borrowers Interest. [NTB.X66]
        /// </summary>
        public bool? LenderDeterminedBorrowersInterest { get => _lenderDeterminedBorrowersInterest; set => SetField(ref _lenderDeterminedBorrowersInterest, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The new loan is guaranteed, originated, or funded by the Federal Housing Administration, the Department of Veterans Affairs, or other State or federal housing finance agencies.? [NTB.X48]
        /// </summary>
        public bool? NewLoanIsGuaranteedIndicator { get => _newLoanIsGuaranteedIndicator; set => SetField(ref _newLoanIsGuaranteedIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit New Loan Info - Negative Amortization Feature [NTB.X25]
        /// </summary>
        public bool? NewLoanIsNegativeAmortizationFeatureIndicator { get => _newLoanIsNegativeAmortizationFeatureIndicator; set => SetField(ref _newLoanIsNegativeAmortizationFeatureIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Loan Info - The new home loan is a Safe Harbor Qualified Mortgage. [NTB.X67]
        /// </summary>
        public bool? NewLoanIsSafeHarborQM { get => _newLoanIsSafeHarborQM; set => SetField(ref _newLoanIsSafeHarborQM, value); }

        /// <summary>
        /// Net Tangible Benefit New Loan Info - The new loan is a special mortgage originated, subsidized, or guaranteed by or through a state, tribal, or local government or a... [NTB.X23]
        /// </summary>
        public bool? NewLoanIsSpecialMortgageOriginatedIndicator { get => _newLoanIsSpecialMortgageOriginatedIndicator; set => SetField(ref _newLoanIsSpecialMortgageOriginatedIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit New Loan Info - Difference between current payment with MI and new payment with MI [NTB.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? NewLoanPaymentWithMiDifference { get => _newLoanPaymentWithMiDifference; set => SetField(ref _newLoanPaymentWithMiDifference, value); }

        /// <summary>
        /// Net Tangible Benefit New Loan Info - Difference between current payment total obligation and new payment total obligation [NTB.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? NewLoanPaymentWithObligationDifference { get => _newLoanPaymentWithObligationDifference; set => SetField(ref _newLoanPaymentWithObligationDifference, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Will the new loan pay-off/consolidate Debt? [NTB.X35]
        /// </summary>
        public bool? NewLoanPayOffConsolidateDebtIndicator { get => _newLoanPayOffConsolidateDebtIndicator; set => SetField(ref _newLoanPayOffConsolidateDebtIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit New Loan Info - Weighted Average Interest Rate [NTB.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? NewLoanWeightedAverageInterestRatePercent { get => _newLoanWeightedAverageInterestRatePercent; set => SetField(ref _newLoanWeightedAverageInterestRatePercent, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Obtaining a lower monthly payment, including principal, interest, taxes, and insurance? [NTB.X38]
        /// </summary>
        public bool? ObtainingLowerIntMonthlyPaymentIndicator { get => _obtainingLowerIntMonthlyPaymentIndicator; set => SetField(ref _obtainingLowerIntMonthlyPaymentIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Obtaining a lower interest rate? [NTB.X37]
        /// </summary>
        public bool? ObtainingLowerIntRateIndicator { get => _obtainingLowerIntRateIndicator; set => SetField(ref _obtainingLowerIntRateIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Obtaining a shorter amortization schedule? [NTB.X39]
        /// </summary>
        public bool? ObtainingShortAmortScheduleIndicator { get => _obtainingShortAmortScheduleIndicator; set => SetField(ref _obtainingShortAmortScheduleIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Other [NTB.X64]
        /// </summary>
        public bool? OtherReason { get => _otherReason; set => SetField(ref _otherReason, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Other Description [NTB.X65]
        /// </summary>
        public string OtherReasonDescription { get => _otherReasonDescription; set => SetField(ref _otherReasonDescription, value); }

        /// <summary>
        /// Net Tangible Benefit Loan Info - Print Borrower Initial Lines for Each Benefit? [NTB.X60]
        /// </summary>
        public bool? PrintBorrowerInitialLinesIndicator { get => _printBorrowerInitialLinesIndicator; set => SetField(ref _printBorrowerInitialLinesIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The proceeds of the new loan will be used for purposes that are of such importance to the borrower(s) that the borrower(s) is/are willing to obtain a new loan, even if that loan has terms that may not be as favorable as the existing loan.  [NTB.X47]
        /// </summary>
        public bool? ProceedsOfNewLoanWillBeUsedIndicator { get => _proceedsOfNewLoanWillBeUsedIndicator; set => SetField(ref _proceedsOfNewLoanWillBeUsedIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Receiving cash-out from the new loan in an amount greater than all closing costs incurred in connection with the loan? [NTB.X43]
        /// </summary>
        public bool? ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get => _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator; set => SetField(ref _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The new refinancing loan is a home equity credit line and the APR will not exceed at any time during the term of the agreement...? [NTB.X53]
        /// </summary>
        public bool? RefinancingLoanIsHomeEquityIndicator { get => _refinancingLoanIsHomeEquityIndicator; set => SetField(ref _refinancingLoanIsHomeEquityIndicator, value); }

        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The Refinancing is Necessary to Respond to a Bona-Fide Personal Need or Order of a Court [NTB.X63]
        /// </summary>
        public bool? RefinancingRespondBonaFide { get => _refinancingRespondBonaFide; set => SetField(ref _refinancingRespondBonaFide, value); }
    }
}