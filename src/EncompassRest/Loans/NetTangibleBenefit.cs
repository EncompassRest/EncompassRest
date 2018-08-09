using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NetTangibleBenefit
    /// </summary>
    public sealed partial class NetTangibleBenefit : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _aprNotExceedIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The APR of the new refinancing loan at consummation does not exceed by more than 2.5% for closed-end first lien loans...? [NTB.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The APR of the new refinancing loan at consummation does not exceed by more than 2.5% for closed-end first lien loans...?")]
        public bool? AprNotExceedIndicator { get => _aprNotExceedIndicator; set => _aprNotExceedIndicator = value; }
        private DirtyValue<bool?> _avoidingForeclosureIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Avoiding foreclosure? [NTB.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Avoiding foreclosure?")]
        public bool? AvoidingForeclosureIndicator { get => _avoidingForeclosureIndicator; set => _avoidingForeclosureIndicator = value; }
        private DirtyValue<bool?> _beneficialChangedForBorrowerIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - There is a beneficial change for the borrower in the duration of the loan? [NTB.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - There is a beneficial change for the borrower in the duration of the loan?")]
        public bool? BeneficialChangedForBorrowerIndicator { get => _beneficialChangedForBorrowerIndicator; set => _beneficialChangedForBorrowerIndicator = value; }
        private DirtyValue<string> _bonaFideFinancialEmergency;
        /// <summary>
        /// Net Tangible Benefit Old/Current Loan Info - Bona Fide Financial Emergency [NTB.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Old/Current Loan Info - Bona Fide Financial Emergency")]
        public string BonaFideFinancialEmergency { get => _bonaFideFinancialEmergency; set => _bonaFideFinancialEmergency = value; }
        private DirtyValue<bool?> _borrowerCanRecoupCostofRefinancingIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The borrower(s) is/are able to recoup the costs of refinancing the loan within two years and reduce the interest rate by 2...? [NTB.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The borrower(s) is/are able to recoup the costs of refinancing the loan within two years and reduce the interest rate by 2...?")]
        public bool? BorrowerCanRecoupCostofRefinancingIndicator { get => _borrowerCanRecoupCostofRefinancingIndicator; set => _borrowerCanRecoupCostofRefinancingIndicator = value; }
        private DirtyValue<bool?> _borrowerCanRecoupIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The borrower is able to recoup the costs of refinancing the home loan within two years, taking into account the costs and...? [NTB.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The borrower is able to recoup the costs of refinancing the home loan within two years, taking into account the costs and...?")]
        public bool? BorrowerCanRecoupIndicator { get => _borrowerCanRecoupIndicator; set => _borrowerCanRecoupIndicator = value; }
        private DirtyValue<bool?> _borrowerMonthlyPaymentLowerThan20Indicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The borrower's monthly payment to pay the new consolidated debt is a minimum of 20% lower than the total of all monthly...? [NTB.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The borrower's monthly payment to pay the new consolidated debt is a minimum of 20% lower than the total of all monthly...?")]
        public bool? BorrowerMonthlyPaymentLowerThan20Indicator { get => _borrowerMonthlyPaymentLowerThan20Indicator; set => _borrowerMonthlyPaymentLowerThan20Indicator = value; }
        private DirtyValue<string> _borrowerReceivedReasonable;
        /// <summary>
        /// Net Tangible Benefit Old/Current Loan Info - Borrower Received Reasonable, Tangible Net Benefit [NTB.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Old/Current Loan Info - Borrower Received Reasonable, Tangible Net Benefit")]
        public string BorrowerReceivedReasonable { get => _borrowerReceivedReasonable; set => _borrowerReceivedReasonable = value; }
        private DirtyValue<bool?> _borrowerReceivesAmountExcessCostAndFeesIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The borrower(s) receive(s) a reasonable amount of cash in excess of and in relation to the cost and fees as part of the refinancing? [NTB.X51]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The borrower(s) receive(s) a reasonable amount of cash in excess of and in relation to the cost and fees as part of the refinancing?")]
        public bool? BorrowerReceivesAmountExcessCostAndFeesIndicator { get => _borrowerReceivesAmountExcessCostAndFeesIndicator; set => _borrowerReceivesAmountExcessCostAndFeesIndicator = value; }
        private DirtyValue<bool?> _changeLoanFromArmtoFixedIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - There is a change from an adjustable rate loan to a fixed rate loan, taking into account costs and fees and the costs can be...? [NTB.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - There is a change from an adjustable rate loan to a fixed rate loan, taking into account costs and fees and the costs can be...?")]
        public bool? ChangeLoanFromArmtoFixedIndicator { get => _changeLoanFromArmtoFixedIndicator; set => _changeLoanFromArmtoFixedIndicator = value; }
        private DirtyValue<bool?> _changingLoanToFixedRateIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Changing from an adjustable rate loan to a fixed rate loan? [NTB.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Changing from an adjustable rate loan to a fixed rate loan?")]
        public bool? ChangingLoanToFixedRateIndicator { get => _changingLoanToFixedRateIndicator; set => _changingLoanToFixedRateIndicator = value; }
        private DirtyValue<bool?> _consolidatingOtherExistingLoansIntoNewLoanIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Consolidating other existing loans into a new mortgage loan? [NTB.X46]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Consolidating other existing loans into a new mortgage loan?")]
        public bool? ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get => _consolidatingOtherExistingLoansIntoNewLoanIndicator; set => _consolidatingOtherExistingLoansIntoNewLoanIndicator = value; }
        private DirtyValue<bool?> _eliminatingBalloonPaymentIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Eliminating a balloon payment feature? [NTB.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Eliminating a balloon payment feature?")]
        public bool? EliminatingBalloonPaymentIndicator { get => _eliminatingBalloonPaymentIndicator; set => _eliminatingBalloonPaymentIndicator = value; }
        private DirtyValue<bool?> _eliminatingNegArmIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Eliminating a negative amortization feature? [NTB.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Eliminating a negative amortization feature?")]
        public bool? EliminatingNegArmIndicator { get => _eliminatingNegArmIndicator; set => _eliminatingNegArmIndicator = value; }
        private DirtyValue<bool?> _eliminatingPrivateMortgageInsuranceIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Eliminating private mortgage insurance? [NTB.X45]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Eliminating private mortgage insurance?")]
        public bool? EliminatingPrivateMortgageInsuranceIndicator { get => _eliminatingPrivateMortgageInsuranceIndicator; set => _eliminatingPrivateMortgageInsuranceIndicator = value; }
        private DirtyValue<decimal?> _existingLoanAprPercent;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - APR [NTB.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit Existing Loan Info - APR")]
        public decimal? ExistingLoanAprPercent { get => _existingLoanAprPercent; set => _existingLoanAprPercent = value; }
        private DirtyValue<bool?> _existingLoanBalloonIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Balloon Indicator [NTB.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Balloon Indicator")]
        public bool? ExistingLoanBalloonIndicator { get => _existingLoanBalloonIndicator; set => _existingLoanBalloonIndicator = value; }
        private DirtyValue<decimal?> _existingLoanBorrowerReceivesCashOutAmount;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Borrower Receives Cash Out Amount [NTB.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Borrower Receives Cash Out Amount")]
        public decimal? ExistingLoanBorrowerReceivesCashOutAmount { get => _existingLoanBorrowerReceivesCashOutAmount; set => _existingLoanBorrowerReceivesCashOutAmount = value; }
        private DirtyValue<bool?> _existingLoanBorrowerReceivesCashOutIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Is the Borrower receiving any cash out from the transaction? [NTB.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Is the Borrower receiving any cash out from the transaction?")]
        public bool? ExistingLoanBorrowerReceivesCashOutIndicator { get => _existingLoanBorrowerReceivesCashOutIndicator; set => _existingLoanBorrowerReceivesCashOutIndicator = value; }
        private DirtyValue<decimal?> _existingLoanBottomRatioPercent;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Bottom Ratio [NTB.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit Existing Loan Info - Bottom Ratio")]
        public decimal? ExistingLoanBottomRatioPercent { get => _existingLoanBottomRatioPercent; set => _existingLoanBottomRatioPercent = value; }
        private DirtyValue<DateTime?> _existingLoanDateLoanClosed;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Date Loan Closed [NTB.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Date Loan Closed")]
        public DateTime? ExistingLoanDateLoanClosed { get => _existingLoanDateLoanClosed; set => _existingLoanDateLoanClosed = value; }
        private DirtyValue<decimal?> _existingLoanFullyIndexRatePercent;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Fully Index Rate [NTB.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit Existing Loan Info - Fully Index Rate")]
        public decimal? ExistingLoanFullyIndexRatePercent { get => _existingLoanFullyIndexRatePercent; set => _existingLoanFullyIndexRatePercent = value; }
        private DirtyValue<decimal?> _existingLoanInterestRatePercent;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Interest Rate [NTB.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit Existing Loan Info - Interest Rate")]
        public decimal? ExistingLoanInterestRatePercent { get => _existingLoanInterestRatePercent; set => _existingLoanInterestRatePercent = value; }
        private DirtyValue<bool?> _existingLoanIsGuaranteedIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The existing loan is guaranteed, originated, or funded by the Federal Housing Administration, the Department of Veterans Affairs, or other State or federal housing finance agencies. [NTB.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The existing loan is guaranteed, originated, or funded by the Federal Housing Administration, the Department of Veterans Affairs, or other State or federal housing finance agencies.")]
        public bool? ExistingLoanIsGuaranteedIndicator { get => _existingLoanIsGuaranteedIndicator; set => _existingLoanIsGuaranteedIndicator = value; }
        private DirtyValue<bool?> _existingLoanIsLoanRefinancedAsSpecial;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The existing loan being refinanced is a special mortgage originated, subsidized, or guaranteed by or through a state, tribal or local... [NTB.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The existing loan being refinanced is a special mortgage originated, subsidized, or guaranteed by or through a state, tribal or local...")]
        public bool? ExistingLoanIsLoanRefinancedAsSpecial { get => _existingLoanIsLoanRefinancedAsSpecial; set => _existingLoanIsLoanRefinancedAsSpecial = value; }
        private DirtyValue<bool?> _existingLoanIsNegativeAmortizationFeatureIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Negative Amortization Feature [NTB.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Negative Amortization Feature")]
        public bool? ExistingLoanIsNegativeAmortizationFeatureIndicator { get => _existingLoanIsNegativeAmortizationFeatureIndicator; set => _existingLoanIsNegativeAmortizationFeatureIndicator = value; }
        private DirtyValue<bool?> _existingLoanIsPrepaymentPenalty;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty? [NTB.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Prepayment Penalty?")]
        public bool? ExistingLoanIsPrepaymentPenalty { get => _existingLoanIsPrepaymentPenalty; set => _existingLoanIsPrepaymentPenalty = value; }
        private DirtyValue<StringEnumValue<AmortizationType>> _existingLoanLoanAmortizationType;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Loan Amortization Type [NTB.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Loan Amortization Type")]
        public StringEnumValue<AmortizationType> ExistingLoanLoanAmortizationType { get => _existingLoanLoanAmortizationType; set => _existingLoanLoanAmortizationType = value; }
        private DirtyValue<decimal?> _existingLoanLoanAmount;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Loan Amount [NTB.X2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Loan Amount")]
        public decimal? ExistingLoanLoanAmount { get => _existingLoanLoanAmount; set => _existingLoanLoanAmount = value; }
        private DirtyValue<int?> _existingLoanLoanTerm;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Loan Term [NTB.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Loan Term")]
        public int? ExistingLoanLoanTerm { get => _existingLoanLoanTerm; set => _existingLoanLoanTerm = value; }
        private DirtyValue<decimal?> _existingLoanLtvPercent;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - LTV [NTB.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit Existing Loan Info - LTV")]
        public decimal? ExistingLoanLtvPercent { get => _existingLoanLtvPercent; set => _existingLoanLtvPercent = value; }
        private DirtyValue<decimal?> _existingLoanMaximumRatePercent;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Maximum Rate [NTB.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit Existing Loan Info - Maximum Rate")]
        public decimal? ExistingLoanMaximumRatePercent { get => _existingLoanMaximumRatePercent; set => _existingLoanMaximumRatePercent = value; }
        private DirtyValue<int?> _existingLoanMonthsRemaining;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Months Remaining [NTB.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Months Remaining")]
        public int? ExistingLoanMonthsRemaining { get => _existingLoanMonthsRemaining; set => _existingLoanMonthsRemaining = value; }
        private DirtyValue<decimal?> _existingLoanPaymentAmount;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Payment Amount [NTB.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Payment Amount")]
        public decimal? ExistingLoanPaymentAmount { get => _existingLoanPaymentAmount; set => _existingLoanPaymentAmount = value; }
        private DirtyValue<decimal?> _existingLoanPaymentDifference;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Difference between current payment and new payment [NTB.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Difference between current payment and new payment")]
        public decimal? ExistingLoanPaymentDifference { get => _existingLoanPaymentDifference; set => _existingLoanPaymentDifference = value; }
        private DirtyValue<decimal?> _existingLoanPaymentIncludeMiObligation;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Total Monthly Mortgage Obligation [NTB.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Total Monthly Mortgage Obligation")]
        public decimal? ExistingLoanPaymentIncludeMiObligation { get => _existingLoanPaymentIncludeMiObligation; set => _existingLoanPaymentIncludeMiObligation = value; }
        private DirtyValue<decimal?> _existingLoanPaymentIncludeMortgageInsurance;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Payment with Mortgage Insurance [NTB.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Payment with Mortgage Insurance")]
        public decimal? ExistingLoanPaymentIncludeMortgageInsurance { get => _existingLoanPaymentIncludeMortgageInsurance; set => _existingLoanPaymentIncludeMortgageInsurance = value; }
        private DirtyValue<decimal?> _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Amount of the Prepayment Penalty to be included in the new loan amount [NTB.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Amount of the Prepayment Penalty to be included in the new loan amount")]
        public decimal? ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get => _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan; set => _existingLoanPrepaymentPenaltyAmountIncludedInNewLoan = value; }
        private DirtyValue<StringEnumValue<PrepaymentPenaltyBasedOn>> _existingLoanPrepaymentPenaltyBasedOn;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty Based On [NTB.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Prepayment Penalty Based On")]
        public StringEnumValue<PrepaymentPenaltyBasedOn> ExistingLoanPrepaymentPenaltyBasedOn { get => _existingLoanPrepaymentPenaltyBasedOn; set => _existingLoanPrepaymentPenaltyBasedOn = value; }
        private DirtyValue<decimal?> _existingLoanPrepaymentPenaltyPercentage;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty % [NTB.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit Existing Loan Info - Prepayment Penalty %")]
        public decimal? ExistingLoanPrepaymentPenaltyPercentage { get => _existingLoanPrepaymentPenaltyPercentage; set => _existingLoanPrepaymentPenaltyPercentage = value; }
        private DirtyValue<int?> _existingLoanPrepaymentPenaltyTerm;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty Term [NTB.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Prepayment Penalty Term")]
        public int? ExistingLoanPrepaymentPenaltyTerm { get => _existingLoanPrepaymentPenaltyTerm; set => _existingLoanPrepaymentPenaltyTerm = value; }
        private DirtyValue<StringEnumValue<ExistingLoanProvidedByLicenseeType>> _existingLoanProvidedByLicenseeType;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Existing Loan was provided by the Licensee, Affiliate of Licensee or Related Entity of Licensee? [NTB.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Existing Loan was provided by the Licensee, Affiliate of Licensee or Related Entity of Licensee?")]
        public StringEnumValue<ExistingLoanProvidedByLicenseeType> ExistingLoanProvidedByLicenseeType { get => _existingLoanProvidedByLicenseeType; set => _existingLoanProvidedByLicenseeType = value; }
        private DirtyValue<StringEnumValue<LoanPurposeType>> _existingLoanPurposeType;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Loan Purpose [NTB.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Loan Purpose")]
        public StringEnumValue<LoanPurposeType> ExistingLoanPurposeType { get => _existingLoanPurposeType; set => _existingLoanPurposeType = value; }
        private DirtyValue<int?> _existingLoanRecoupCostsYears;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Recoup Costs in Years [NTB.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Recoup Costs in Years")]
        public int? ExistingLoanRecoupCostsYears { get => _existingLoanRecoupCostsYears; set => _existingLoanRecoupCostsYears = value; }
        private DirtyValue<decimal?> _existingLoanSavingsAmount;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Savings Amount [NTB.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Savings Amount")]
        public decimal? ExistingLoanSavingsAmount { get => _existingLoanSavingsAmount; set => _existingLoanSavingsAmount = value; }
        private DirtyValue<decimal?> _existingLoanTotalDebtPayoff;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Total Debt Paid Off [NTB.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit Existing Loan Info - Total Debt Paid Off")]
        public decimal? ExistingLoanTotalDebtPayoff { get => _existingLoanTotalDebtPayoff; set => _existingLoanTotalDebtPayoff = value; }
        private DirtyValue<decimal?> _existingLoanWeightedAverageInterestRatePercent;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Weighted Average Interest Rate [NTB.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit Existing Loan Info - Weighted Average Interest Rate")]
        public decimal? ExistingLoanWeightedAverageInterestRatePercent { get => _existingLoanWeightedAverageInterestRatePercent; set => _existingLoanWeightedAverageInterestRatePercent = value; }
        private DirtyValue<bool?> _homeLoanComplianceWith209;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - A Home Loan is in Compliance With 209 CMR 53.03 if it Meets Any of The Following (Check All That Apply) [NTB.X62]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - A Home Loan is in Compliance With 209 CMR 53.03 if it Meets Any of The Following (Check All That Apply)")]
        public bool? HomeLoanComplianceWith209 { get => _homeLoanComplianceWith209; set => _homeLoanComplianceWith209 = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// NetTangibleBenefit Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _lenderDeterminedBorrowersInterest;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Lender Has Determined That This New Home Loan is in The Borrowers Interest. [NTB.X66]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Lender Has Determined That This New Home Loan is in The Borrowers Interest.")]
        public bool? LenderDeterminedBorrowersInterest { get => _lenderDeterminedBorrowersInterest; set => _lenderDeterminedBorrowersInterest = value; }
        private DirtyValue<bool?> _newLoanIsGuaranteedIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The new loan is guaranteed, originated, or funded by the Federal Housing Administration, the Department of Veterans Affairs, or other State or federal housing finance agencies.? [NTB.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The new loan is guaranteed, originated, or funded by the Federal Housing Administration, the Department of Veterans Affairs, or other State or federal housing finance agencies.?")]
        public bool? NewLoanIsGuaranteedIndicator { get => _newLoanIsGuaranteedIndicator; set => _newLoanIsGuaranteedIndicator = value; }
        private DirtyValue<bool?> _newLoanIsNegativeAmortizationFeatureIndicator;
        /// <summary>
        /// Net Tangible Benefit New Loan Info - Negative Amortization Feature [NTB.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit New Loan Info - Negative Amortization Feature")]
        public bool? NewLoanIsNegativeAmortizationFeatureIndicator { get => _newLoanIsNegativeAmortizationFeatureIndicator; set => _newLoanIsNegativeAmortizationFeatureIndicator = value; }
        private DirtyValue<bool?> _newLoanIsSafeHarborQM;
        /// <summary>
        /// Net Tangible Benefit Loan Info - The new home loan is a Safe Harbor Qualified Mortgage. [NTB.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Loan Info - The new home loan is a Safe Harbor Qualified Mortgage.")]
        public bool? NewLoanIsSafeHarborQM { get => _newLoanIsSafeHarborQM; set => _newLoanIsSafeHarborQM = value; }
        private DirtyValue<bool?> _newLoanIsSpecialMortgageOriginatedIndicator;
        /// <summary>
        /// Net Tangible Benefit New Loan Info - The new loan is a special mortgage originated, subsidized, or guaranteed by or through a state, tribal, or local government or a... [NTB.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit New Loan Info - The new loan is a special mortgage originated, subsidized, or guaranteed by or through a state, tribal, or local government or a...")]
        public bool? NewLoanIsSpecialMortgageOriginatedIndicator { get => _newLoanIsSpecialMortgageOriginatedIndicator; set => _newLoanIsSpecialMortgageOriginatedIndicator = value; }
        private DirtyValue<decimal?> _newLoanPaymentWithMiDifference;
        /// <summary>
        /// Net Tangible Benefit New Loan Info - Difference between current payment with MI and new payment with MI [NTB.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit New Loan Info - Difference between current payment with MI and new payment with MI")]
        public decimal? NewLoanPaymentWithMiDifference { get => _newLoanPaymentWithMiDifference; set => _newLoanPaymentWithMiDifference = value; }
        private DirtyValue<decimal?> _newLoanPaymentWithObligationDifference;
        /// <summary>
        /// Net Tangible Benefit New Loan Info - Difference between current payment total obligation and new payment total obligation [NTB.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Net Tangible Benefit New Loan Info - Difference between current payment total obligation and new payment total obligation")]
        public decimal? NewLoanPaymentWithObligationDifference { get => _newLoanPaymentWithObligationDifference; set => _newLoanPaymentWithObligationDifference = value; }
        private DirtyValue<bool?> _newLoanPayOffConsolidateDebtIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Will the new loan pay-off/consolidate Debt? [NTB.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Will the new loan pay-off/consolidate Debt?")]
        public bool? NewLoanPayOffConsolidateDebtIndicator { get => _newLoanPayOffConsolidateDebtIndicator; set => _newLoanPayOffConsolidateDebtIndicator = value; }
        private DirtyValue<decimal?> _newLoanWeightedAverageInterestRatePercent;
        /// <summary>
        /// Net Tangible Benefit New Loan Info - Weighted Average Interest Rate [NTB.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Net Tangible Benefit New Loan Info - Weighted Average Interest Rate")]
        public decimal? NewLoanWeightedAverageInterestRatePercent { get => _newLoanWeightedAverageInterestRatePercent; set => _newLoanWeightedAverageInterestRatePercent = value; }
        private DirtyValue<bool?> _obtainingLowerIntMonthlyPaymentIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Obtaining a lower monthly payment, including principal, interest, taxes, and insurance? [NTB.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Obtaining a lower monthly payment, including principal, interest, taxes, and insurance?")]
        public bool? ObtainingLowerIntMonthlyPaymentIndicator { get => _obtainingLowerIntMonthlyPaymentIndicator; set => _obtainingLowerIntMonthlyPaymentIndicator = value; }
        private DirtyValue<bool?> _obtainingLowerIntRateIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Obtaining a lower interest rate? [NTB.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Obtaining a lower interest rate?")]
        public bool? ObtainingLowerIntRateIndicator { get => _obtainingLowerIntRateIndicator; set => _obtainingLowerIntRateIndicator = value; }
        private DirtyValue<bool?> _obtainingShortAmortScheduleIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Obtaining a shorter amortization schedule? [NTB.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Obtaining a shorter amortization schedule?")]
        public bool? ObtainingShortAmortScheduleIndicator { get => _obtainingShortAmortScheduleIndicator; set => _obtainingShortAmortScheduleIndicator = value; }
        private DirtyValue<bool?> _otherReason;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Other [NTB.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Other")]
        public bool? OtherReason { get => _otherReason; set => _otherReason = value; }
        private DirtyValue<string> _otherReasonDescription;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Other Description [NTB.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Other Description")]
        public string OtherReasonDescription { get => _otherReasonDescription; set => _otherReasonDescription = value; }
        private DirtyValue<bool?> _printBorrowerInitialLinesIndicator;
        /// <summary>
        /// Net Tangible Benefit Loan Info - Print Borrower Initial Lines for Each Benefit? [NTB.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Loan Info - Print Borrower Initial Lines for Each Benefit?")]
        public bool? PrintBorrowerInitialLinesIndicator { get => _printBorrowerInitialLinesIndicator; set => _printBorrowerInitialLinesIndicator = value; }
        private DirtyValue<bool?> _proceedsOfNewLoanWillBeUsedIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The proceeds of the new loan will be used for purposes that are of such importance to the borrower(s) that the borrower(s) is/are willing to obtain a new loan, even if that loan has terms that may not be as favorable as the existing loan.  [NTB.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The proceeds of the new loan will be used for purposes that are of such importance to the borrower(s) that the borrower(s) is/are willing to obtain a new loan, even if that loan has terms that may not be as favorable as the existing loan. ")]
        public bool? ProceedsOfNewLoanWillBeUsedIndicator { get => _proceedsOfNewLoanWillBeUsedIndicator; set => _proceedsOfNewLoanWillBeUsedIndicator = value; }
        private DirtyValue<bool?> _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - Receiving cash-out from the new loan in an amount greater than all closing costs incurred in connection with the loan? [NTB.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - Receiving cash-out from the new loan in an amount greater than all closing costs incurred in connection with the loan?")]
        public bool? ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get => _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator; set => _receivingCashOutFromNewLoanGreaterThanClosingCostIndicator = value; }
        private DirtyValue<bool?> _refinancingLoanIsHomeEquityIndicator;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The new refinancing loan is a home equity credit line and the APR will not exceed at any time during the term of the agreement...? [NTB.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The new refinancing loan is a home equity credit line and the APR will not exceed at any time during the term of the agreement...?")]
        public bool? RefinancingLoanIsHomeEquityIndicator { get => _refinancingLoanIsHomeEquityIndicator; set => _refinancingLoanIsHomeEquityIndicator = value; }
        private DirtyValue<bool?> _refinancingRespondBonaFide;
        /// <summary>
        /// Net Tangible Benefit Existing Loan Info - The Refinancing is Necessary to Respond to a Bona-Fide Personal Need or Order of a Court [NTB.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Net Tangible Benefit Existing Loan Info - The Refinancing is Necessary to Respond to a Bona-Fide Personal Need or Order of a Court")]
        public bool? RefinancingRespondBonaFide { get => _refinancingRespondBonaFide; set => _refinancingRespondBonaFide = value; }
    }
}