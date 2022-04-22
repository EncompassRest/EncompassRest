using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// NetTangibleBenefit
/// </summary>
public sealed partial class NetTangibleBenefit : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The APR of the new refinancing loan at consummation does not exceed by more than 2.5% for closed-end first lien loans...? [NTB.X52]
    /// </summary>
    public bool? AprNotExceedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Avoiding foreclosure? [NTB.X44]
    /// </summary>
    public bool? AvoidingForeclosureIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - There is a beneficial change for the borrower in the duration of the loan? [NTB.X50]
    /// </summary>
    public bool? BeneficialChangedForBorrowerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Old/Current Loan Info - Bona Fide Financial Emergency [NTB.X58]
    /// </summary>
    public string? BonaFideFinancialEmergency { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The borrower(s) is/are able to recoup the costs of refinancing the loan within two years and reduce the interest rate by 2...? [NTB.X57]
    /// </summary>
    public bool? BorrowerCanRecoupCostofRefinancingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The borrower is able to recoup the costs of refinancing the home loan within two years, taking into account the costs and...? [NTB.X54]
    /// </summary>
    public bool? BorrowerCanRecoupIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The borrower's monthly payment to pay the new consolidated debt is a minimum of 20% lower than the total of all monthly...? [NTB.X55]
    /// </summary>
    public bool? BorrowerMonthlyPaymentLowerThan20Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Old/Current Loan Info - Borrower Received Reasonable, Tangible Net Benefit [NTB.X59]
    /// </summary>
    public string? BorrowerReceivedReasonable { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The borrower(s) receive(s) a reasonable amount of cash in excess of and in relation to the cost and fees as part of the refinancing? [NTB.X51]
    /// </summary>
    public bool? BorrowerReceivesAmountExcessCostAndFeesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - There is a change from an adjustable rate loan to a fixed rate loan, taking into account costs and fees and the costs can be...? [NTB.X56]
    /// </summary>
    public bool? ChangeLoanFromArmtoFixedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Changing from an adjustable rate loan to a fixed rate loan? [NTB.X40]
    /// </summary>
    public bool? ChangingLoanToFixedRateIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Consolidating other existing loans into a new mortgage loan? [NTB.X46]
    /// </summary>
    public bool? ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Eliminating a balloon payment feature? [NTB.X42]
    /// </summary>
    public bool? EliminatingBalloonPaymentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Eliminating a negative amortization feature? [NTB.X41]
    /// </summary>
    public bool? EliminatingNegArmIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Eliminating private mortgage insurance? [NTB.X45]
    /// </summary>
    public bool? EliminatingPrivateMortgageInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - APR [NTB.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLoanAprPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Balloon Indicator [NTB.X61]
    /// </summary>
    public bool? ExistingLoanBalloonIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Borrower Receives Cash Out Amount [NTB.X31]
    /// </summary>
    public decimal? ExistingLoanBorrowerReceivesCashOutAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Is the Borrower receiving any cash out from the transaction? [NTB.X30]
    /// </summary>
    public bool? ExistingLoanBorrowerReceivesCashOutIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Bottom Ratio [NTB.X18]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLoanBottomRatioPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Date Loan Closed [NTB.X1]
    /// </summary>
    public DateTime? ExistingLoanDateLoanClosed { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Fully Index Rate [NTB.X9]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLoanFullyIndexRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Interest Rate [NTB.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLoanInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The existing loan is guaranteed, originated, or funded by the Federal Housing Administration, the Department of Veterans Affairs, or other State or federal housing finance agencies. [NTB.X49]
    /// </summary>
    public bool? ExistingLoanIsGuaranteedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The existing loan being refinanced is a special mortgage originated, subsidized, or guaranteed by or through a state, tribal or local... [NTB.X15]
    /// </summary>
    public bool? ExistingLoanIsLoanRefinancedAsSpecial { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Negative Amortization Feature [NTB.X12]
    /// </summary>
    public bool? ExistingLoanIsNegativeAmortizationFeatureIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty? [NTB.X13]
    /// </summary>
    public bool? ExistingLoanIsPrepaymentPenalty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Loan Amortization Type [NTB.X5]
    /// </summary>
    public StringEnumValue<AmortizationType> ExistingLoanLoanAmortizationType { get => GetValue<StringEnumValue<AmortizationType>>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Loan Amount [NTB.X2]
    /// </summary>
    public decimal? ExistingLoanLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Loan Term [NTB.X3]
    /// </summary>
    public int? ExistingLoanLoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - LTV [NTB.X17]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLoanLtvPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Maximum Rate [NTB.X10]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLoanMaximumRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Months Remaining [NTB.X4]
    /// </summary>
    public int? ExistingLoanMonthsRemaining { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Payment Amount [NTB.X20]
    /// </summary>
    public decimal? ExistingLoanPaymentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Difference between current payment and new payment [NTB.X29]
    /// </summary>
    public decimal? ExistingLoanPaymentDifference { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Total Monthly Mortgage Obligation [NTB.X21]
    /// </summary>
    public decimal? ExistingLoanPaymentIncludeMiObligation { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Payment with Mortgage Insurance [NTB.X22]
    /// </summary>
    public decimal? ExistingLoanPaymentIncludeMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Amount of the Prepayment Penalty to be included in the new loan amount [NTB.X16]
    /// </summary>
    public decimal? ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty Based On [NTB.X26]
    /// </summary>
    public StringEnumValue<PrepaymentPenaltyBasedOn> ExistingLoanPrepaymentPenaltyBasedOn { get => GetValue<StringEnumValue<PrepaymentPenaltyBasedOn>>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty % [NTB.X14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLoanPrepaymentPenaltyPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Prepayment Penalty Term [NTB.X6]
    /// </summary>
    public int? ExistingLoanPrepaymentPenaltyTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Existing Loan was provided by the Licensee, Affiliate of Licensee or Related Entity of Licensee? [NTB.X34]
    /// </summary>
    public StringEnumValue<ExistingLoanProvidedByLicenseeType> ExistingLoanProvidedByLicenseeType { get => GetValue<StringEnumValue<ExistingLoanProvidedByLicenseeType>>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Loan Purpose [NTB.X19]
    /// </summary>
    public StringEnumValue<LoanPurposeType> ExistingLoanPurposeType { get => GetValue<StringEnumValue<LoanPurposeType>>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Recoup Costs in Years [NTB.X33]
    /// </summary>
    public int? ExistingLoanRecoupCostsYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Savings Amount [NTB.X32]
    /// </summary>
    public decimal? ExistingLoanSavingsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Total Debt Paid Off [NTB.X36]
    /// </summary>
    public decimal? ExistingLoanTotalDebtPayoff { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Weighted Average Interest Rate [NTB.X11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ExistingLoanWeightedAverageInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - A Home Loan is in Compliance With 209 CMR 53.03 if it Meets Any of The Following (Check All That Apply) [NTB.X62]
    /// </summary>
    public bool? HomeLoanComplianceWith209 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Lender Has Determined That This New Home Loan is in The Borrowers Interest. [NTB.X66]
    /// </summary>
    public bool? LenderDeterminedBorrowersInterest { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The new loan is guaranteed, originated, or funded by the Federal Housing Administration, the Department of Veterans Affairs, or other State or federal housing finance agencies.? [NTB.X48]
    /// </summary>
    public bool? NewLoanIsGuaranteedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit New Loan Info - Negative Amortization Feature [NTB.X25]
    /// </summary>
    public bool? NewLoanIsNegativeAmortizationFeatureIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Loan Info - The new home loan is a Safe Harbor Qualified Mortgage. [NTB.X67]
    /// </summary>
    public bool? NewLoanIsSafeHarborQm { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit New Loan Info - The new loan is a special mortgage originated, subsidized, or guaranteed by or through a state, tribal, or local government or a... [NTB.X23]
    /// </summary>
    public bool? NewLoanIsSpecialMortgageOriginatedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit New Loan Info - Difference between current payment with MI and new payment with MI [NTB.X27]
    /// </summary>
    public decimal? NewLoanPaymentWithMiDifference { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit New Loan Info - Difference between current payment total obligation and new payment total obligation [NTB.X28]
    /// </summary>
    public decimal? NewLoanPaymentWithObligationDifference { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Will the new loan pay-off/consolidate Debt? [NTB.X35]
    /// </summary>
    public bool? NewLoanPayOffConsolidateDebtIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit New Loan Info - Weighted Average Interest Rate [NTB.X24]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? NewLoanWeightedAverageInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Obtaining a lower monthly payment, including principal, interest, taxes, and insurance? [NTB.X38]
    /// </summary>
    public bool? ObtainingLowerIntMonthlyPaymentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Obtaining a lower interest rate? [NTB.X37]
    /// </summary>
    public bool? ObtainingLowerIntRateIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Obtaining a shorter amortization schedule? [NTB.X39]
    /// </summary>
    public bool? ObtainingShortAmortScheduleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Other [NTB.X64]
    /// </summary>
    public bool? OtherReason { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Other Description [NTB.X65]
    /// </summary>
    public string? OtherReasonDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Loan Info - Print Borrower Initial Lines for Each Benefit? [NTB.X60]
    /// </summary>
    public bool? PrintBorrowerInitialLinesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The proceeds of the new loan will be used for purposes that are of such importance to the borrower(s) that the borrower(s) is/are willing to obtain a new loan, even if that loan has terms that may not be as favorable as the existing loan.  [NTB.X47]
    /// </summary>
    public bool? ProceedsOfNewLoanWillBeUsedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - Receiving cash-out from the new loan in an amount greater than all closing costs incurred in connection with the loan? [NTB.X43]
    /// </summary>
    public bool? ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The new refinancing loan is a home equity credit line and the APR will not exceed at any time during the term of the agreement...? [NTB.X53]
    /// </summary>
    public bool? RefinancingLoanIsHomeEquityIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Existing Loan Info - The Refinancing is Necessary to Respond to a Bona-Fide Personal Need or Order of a Court [NTB.X63]
    /// </summary>
    public bool? RefinancingRespondBonaFide { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Loan Info - VA Cashout Refinance - New Loan Results in an Increase in Borrower's Income [NTB.X69]
    /// </summary>
    public bool? VaBorrowerIncomeIncreasedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Loan Info - VA Cashout Refinance - The New Loan Refinances an Interim Loan to Construct, Alter or Repair Primary Home [NTB.X70]
    /// </summary>
    public bool? VaNewLoanAlterPrimaryHomeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Loan Info - VA Cashout Refinance - The New Loan Amount is Equal to or Less Than 90 Percentage of the Reasonable Value of the Home [NTB.X71]
    /// </summary>
    public bool? VaNewLoanEqualorLess90Indicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Net Tangible Benefit Loan Info - VA Cashout Refinance - Term is shorter than refinanced loan [NTB.X68]
    /// </summary>
    public bool? VaTermShorterThanRefinancedLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}