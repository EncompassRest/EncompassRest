using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Usda
/// </summary>
public sealed partial class Usda : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Usda AdditionalIncomeFromPrimaryEmployment
    /// </summary>
    public decimal? AdditionalIncomeFromPrimaryEmployment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Additional Adult Household Member(s) (Base Income: Primary Employment from Wages, Salary, self-Employed, Additional income to Primary Employment, Other Income) [USDA.X167]
    /// </summary>
    public decimal? AdditionalMemberBaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Usda AdjustedAnnualIncome
    /// </summary>
    public decimal? AdjustedAnnualIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 8 [USDA.X214]
    /// </summary>
    public string? AdjustedIncomeCalculationDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 10 [USDA.X215]
    /// </summary>
    public string? AdjustedIncomeCalculationDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Adjusted Income Calculation - Calculate and Record how the calculation of deduction in the space below line 11 [USDA.X216]
    /// </summary>
    public string? AdjustedIncomeCalculationDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Advance Amount to Date [USDA.X134]
    /// </summary>
    public decimal? AdvanceAmountToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Amount of Loanline of Credit [USDA.X133]
    /// </summary>
    public decimal? AmountLoanlineCredit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Annual Child Care Expenses [USDA.X173]
    /// </summary>
    public decimal? AnnualChildCareExpenses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Usda AnnualIncome
    /// </summary>
    public decimal? AnnualIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 1 [USDA.X209]
    /// </summary>
    public string? AnnualIncomeCalculationDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 2 [USDA.X210]
    /// </summary>
    public string? AnnualIncomeCalculationDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 3 [USDA.X211]
    /// </summary>
    public string? AnnualIncomeCalculationDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 4 [USDA.X212]
    /// </summary>
    public string? AnnualIncomeCalculationDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Income Calculation - Calculate and Record how the calculation of each income source/type was determined in the space below line 5 [USDA.X213]
    /// </summary>
    public string? AnnualIncomeCalculationDescription5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Annual Review Date [USDA.X147]
    /// </summary>
    public DateTime? AnnualReviewDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Application Number [USDA.X29]
    /// </summary>
    public string? ApplicationNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Approved Lender Tax ID No [USDA.X25]
    /// </summary>
    public string? ApprovedLenderTaxId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Usda AssetIncome
    /// </summary>
    public decimal? AssetIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Balance Owed On Loan [USDA.X144]
    /// </summary>
    public decimal? BalanceOwedOnLoan { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Usda BorrowerBaseIncome
    /// </summary>
    public decimal? BorrowerBaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Borrower Total Stable Income [USDA.X201]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BorrowerTotalStableIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Borrower Type Code [USDA.X123]
    /// </summary>
    public StringEnumValue<BorrowerTypeCode> BorrowerTypeCode { get => GetValue<StringEnumValue<BorrowerTypeCode>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Buydown / Interest Assistance Rate [USDA.X139]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BuydownInterestAssistanceRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Case Number - Borrower ID [USDA.X122]
    /// </summary>
    public string? CaseNumberBorrowerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Case Number - CO [USDA.X121]
    /// </summary>
    public string? CaseNumberCo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Case Number - ST [USDA.X120]
    /// </summary>
    public string? CaseNumberSt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Certification Effective Date [USDA.X126]
    /// </summary>
    public DateTime? CertificationEffectiveDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Certification Expiration Date [USDA.X127]
    /// </summary>
    public DateTime? CertificationExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Certified Loan [USDA.X148]
    /// </summary>
    public bool? CertifiedLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Child Care Provider - Address [USDA.X99]
    /// </summary>
    public string? ChildCareProviderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Child Care Provider - City [USDA.X100]
    /// </summary>
    public string? ChildCareProviderCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Child Care Provider - Phone Number [USDA.X103]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ChildCareProviderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Child Care Provider - Name [USDA.X98]
    /// </summary>
    public string? ChildCareProviderProviderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Child Care Provider - State [USDA.X101]
    /// </summary>
    public string? ChildCareProviderState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Child Care Provider - Zip [USDA.X102]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ChildCareProviderZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Child Care Cost Per Month [USDA.X97]
    /// </summary>
    public decimal? ChildCostPerMonth { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Child Care Cost Per Week [USDA.X96]
    /// </summary>
    public decimal? ChildCostPerWeek { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Usda CoborrowerBaseIncome
    /// </summary>
    public decimal? CoborrowerBaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Co-Borrower Stable Dependable Monthly Income (parties to note only) [USDA.X202]
    /// </summary>
    public decimal? CoborrowerStableBaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Coborrower Calculation of Base Income Description [USDA.X203]
    /// </summary>
    public string? CoborrowerStableBaseIncomeDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Co-Borrower Other Stable Dependable Monthly Income (parties to note only) [USDA.X204]
    /// </summary>
    public decimal? CoborrowerStableOtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Coborrower Calculation of Other Income Description [USDA.X205]
    /// </summary>
    public string? CoborrowerStableOtherIncomeDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - CoBorrower Total Stable Income [USDA.X206]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CoBorrowerTotalStableIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Date Confirmed Obligation Processed [USDA.X154]
    /// </summary>
    public DateTime? ConfirmedObligationProcessedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Dependent Deduction [USDA.X172]
    /// </summary>
    public decimal? DependentDeduction { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Disability Deduction [USDA.X175]
    /// </summary>
    public decimal? DisabilityDeduction { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Elderly Household Deduction [USDA.X174]
    /// </summary>
    public decimal? ElderlyHouseholdDeduction { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Fee Rate [USDA.X131]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FeeRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Financed Loan Closing Cost Description [USDA.X21]
    /// </summary>
    public string? FinancedLoanClosingCostDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Financed Loan Closing Costs [USDA.X217]
    /// </summary>
    public decimal? FinancedLoanClosingCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Guarantee Fee Collected [USDA.X160]
    /// </summary>
    public decimal? GuaranteeFeeCollected { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Guarantee Fee On Commitment [USDA.X161]
    /// </summary>
    public decimal? GuaranteeFeeOnCommitment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Guarantee Fee Purpose Code [USDA.X130]
    /// </summary>
    public StringEnumValue<GuaranteeFeePurposeCodeType> GuaranteeFeePurposeCodeType { get => GetValue<StringEnumValue<GuaranteeFeePurposeCodeType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Date Guarantee Period Begins [USDA.X145]
    /// </summary>
    public DateTime? GuaranteePeriodBeginsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Date Guarantee Period Ends [USDA.X146]
    /// </summary>
    public DateTime? GuaranteePeriodEndsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Type of Guarantee [USDA.X142]
    /// </summary>
    public StringEnumValue<GuaranteeType> GuaranteeType { get => GetValue<StringEnumValue<GuaranteeType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Household Size [USDA.X179]
    /// </summary>
    public int? HouseholdSize { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Interest Assistance Code [USDA.X129]
    /// </summary>
    public StringEnumValue<InterestAssistanceCodeType> InterestAssistanceCodeType { get => GetValue<StringEnumValue<InterestAssistanceCodeType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Is Interest Rate Based on Fannie Mae [USDA.X18]
    /// </summary>
    public bool? InterestRateBasedonFannieIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Interest Rate Code [USDA.X143]
    /// </summary>
    public StringEnumValue<InterestRateCodeType> InterestRateCodeType { get => GetValue<StringEnumValue<InterestRateCodeType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Is Interest Rate Based on Fannie Mae - Interest Rate will Float Until Loan Closing [USDA.X19]
    /// </summary>
    public bool? InterestRateFloatToLoanClosingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Characteristics Present Housing - Lack Adequate Heat Indicator [USDA.X105]
    /// </summary>
    public bool? LackAdequateHeatIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Lender's Authorized Representative Company Name [USDA.X32]
    /// </summary>
    public string? LenderAuthorizedRepCompany { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Lender's Authorized Representative Name [USDA.X31]
    /// </summary>
    public string? LenderAuthorizedRepName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Lender's Authorized Representative Title [USDA.X30]
    /// </summary>
    public string? LenderAuthorizedRepTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Lender ID No [USDA.X186]
    /// </summary>
    public string? LenderIdNo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Lender's Note Interest Rate On Guaranteed Portion [USDA.X137]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LenderNoteRateOnGuaranteedPortion { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Lender's Note Interest Rate On Non-Guaranteed Portion [USDA.X138]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LenderNoteRateOnNonGuaranteedPortion { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Lender Status Code [USDA.X124]
    /// </summary>
    public StringEnumValue<LenderStatusCodeType> LenderStatusCodeType { get => GetValue<StringEnumValue<LenderStatusCodeType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Lender Type Code [USDA.X125]
    /// </summary>
    public StringEnumValue<LenderTypeCode> LenderTypeCode { get => GetValue<StringEnumValue<LenderTypeCode>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Date Loan Note Guarantee Issued [USDA.X159]
    /// </summary>
    public DateTime? LoanNoteGuaranteeIssuedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - DateLoan Note Guarantee Request Received [USDA.X157]
    /// </summary>
    public DateTime? LoanNoteGuaranteeRequestReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Type [USDA.X43]
    /// </summary>
    public StringEnumValue<UsdaLoanType> LoanType { get => GetValue<StringEnumValue<UsdaLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Characteristics Present Housing - Lock Complete Plumbing Indicator [USDA.X104]
    /// </summary>
    public bool? LockCompletePlumbingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Medical Expenses [USDA.X176]
    /// </summary>
    public decimal? MedicalExpenses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Moderate Income Limit [USDA.X180]
    /// </summary>
    public decimal? ModerateIncomeLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Monthly Repayment Income [USDA.X184]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyRepaymentIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Number of Dependent for Deduction (child under age 18, or full-time student) [USDA.X185]
    /// </summary>
    public int? NumberofDependents { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Number of people in household [USDA.X9]
    /// </summary>
    public int? NumberofPeopleInHousehold { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Date of Obligation in GLS [USDA.X153]
    /// </summary>
    public DateTime? ObligationInGlsDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Obligation Matches Commitment and Lender Request [USDA.X156]
    /// </summary>
    public bool? ObligationMatchesCommitmentLenderRequestIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Official Who Confirmed GLS Updated [USDA.X155]
    /// </summary>
    public string? OfficialWhoConfirmedGlsUpdated { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA One Time Close [USDA.X219]
    /// </summary>
    public bool? OneTimeClose { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Other Income (Alimony, Child Support, y, Pension/Retirement, Social Security, Disability, Trust Income, Notes Receivable, etc.) [USDA.X169]
    /// </summary>
    public decimal? OtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Other Stable Dependable Monthly Income (parties to note only) [USDA.X183]
    /// </summary>
    public decimal? OtherStableDependableMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Characteristics Present Housing - Overcrowded Indicator [USDA.X107]
    /// </summary>
    public bool? OvercrowdedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Percent of Loan Guaranteed [USDA.X199]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PercentofLoanGuaranteed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Period of Operating Line of Credit Years [USDA.X140]
    /// </summary>
    public StringEnumValue<PeriodOperatingLineCreditYearsType> PeriodOperatingLineCreditYearsType { get => GetValue<StringEnumValue<PeriodOperatingLineCreditYearsType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Characteristics Present Housing - Physically Deteriorated or Structurally Unsound Indicator [USDA.X106]
    /// </summary>
    public bool? PhysicallyDeterioratedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual and Repayment Income Worksheet Prepared By Name [USDA.X196]
    /// </summary>
    public string? PreparedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA -  Annual and Repayment Income Worksheet Prepared By Title [USDA.X197]
    /// </summary>
    public string? PreparedByTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Present Landloard - Address [USDA.X109]
    /// </summary>
    public string? PresentLandloardAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Present Landloard - City [USDA.X110]
    /// </summary>
    public string? PresentLandloardCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Present Landloard - Name [USDA.X108]
    /// </summary>
    public string? PresentLandloardName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Present Landloard - Phone Number [USDA.X113]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PresentLandloardPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Present Landloard - State [USDA.X111]
    /// </summary>
    public string? PresentLandloardState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Present Landloard - Zip [USDA.X112]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PresentLandloardZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Previous Landloard - Address [USDA.X115]
    /// </summary>
    public string? PreviousLandloardAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Previous Landloard - City [USDA.X116]
    /// </summary>
    public string? PreviousLandloardCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Previous Landloard - Name [USDA.X114]
    /// </summary>
    public string? PreviousLandloardName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Previous Landloard - Phone Number [USDA.X119]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PreviousLandloardPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Previous Landloard - State [USDA.X117]
    /// </summary>
    public string? PreviousLandloardState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Previous Landloard - Zip [USDA.X118]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PreviousLandlordZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Purchase or Refinanced Amount [USDA.X198]
    /// </summary>
    public decimal? PurchaseOrRefinancedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Purchase / Refinance Description [USDA.X20]
    /// </summary>
    public string? PurchaseOrRefinanceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - RD SFH Refinance Loan Indicator [USDA.X8]
    /// </summary>
    public StringEnumValue<RdsfhRefinancedLoanIndicatorType> RdsfhRefinancedLoanIndicatorType { get => GetValue<StringEnumValue<RdsfhRefinancedLoanIndicatorType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA Refinance Loan Indicator [USDA.X7]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? RefinanceLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Refinance Type [USDA.X218]
    /// </summary>
    public StringEnumValue<UsdaRefinanceType> RefinanceType { get => GetValue<StringEnumValue<UsdaRefinanceType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Repair / Other Amount [USDA.X24]
    /// </summary>
    public decimal? RepairOtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Repair / Other Description [USDA.X23]
    /// </summary>
    public string? RepairOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Reservation Amount Requested [USDA.X33]
    /// </summary>
    public decimal? ReservationAmountRequested { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Reserved [USDA.X141]
    /// </summary>
    public string? Reserved { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Servicing Office [USDA.X128]
    /// </summary>
    public string? ServicingOfficeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Applicants Eligible for SFHGLP [USDA.X181]
    /// </summary>
    public bool? SfhglpIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Source of Funds [USDA.X166]
    /// </summary>
    public StringEnumValue<SourceOfFundsType> SourceOfFundsType { get => GetValue<StringEnumValue<SourceOfFundsType>>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Stable Dependable Monthly Income (parties to note only) [USDA.X182]
    /// </summary>
    public decimal? StableDependableMonthlyIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Borrower Calculation of Other Income Description [USDA.X200]
    /// </summary>
    public string? StableOtherIncomeDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - Address [USDA.X36]
    /// </summary>
    public string? SubmittingLenderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - City [USDA.X37]
    /// </summary>
    public string? SubmittingLenderCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - Contact Fax Number [USDA.X42]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SubmittingLenderContactFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - Contact Name [USDA.X40]
    /// </summary>
    public string? SubmittingLenderContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - Contact Phone Number [USDA.X41]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SubmittingLenderContactPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - Name [USDA.X34]
    /// </summary>
    public string? SubmittingLenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - State [USDA.X38]
    /// </summary>
    public string? SubmittingLenderState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - Tax ID No. [USDA.X35]
    /// </summary>
    public string? SubmittingLenderTaxId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Submitting Lender Information - Zip [USDA.X39]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SubmittingLenderZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Term of Buydown / Interest Assistance Years [USDA.X135]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\"}")]
    public int? TermOfBuydown { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Third Party Originator (TPO) [USDA.X27]
    /// </summary>
    public string? ThirdPartyOriginator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Loan Closing - Title [USDA.X149]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Total of Borrower and Coborrower Stable Base Income [USDA.X207]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBorrowerStableBaseIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Total of Borrower and Coborrower Stable Other Income [USDA.X208]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBorrowerStableOtherIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Annual Adjusted Income - Total Household Deduction [USDA.X177]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalHouseholdDeduction { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Total Request Amount [USDA.X26]
    /// </summary>
    public decimal? TotalRequestAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Third Party Originator (TPO) Tax ID No. [USDA.X28]
    /// </summary>
    public string? TpoTaxId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Underwriting Decision By [USDA.X151]
    /// </summary>
    public string? UnderwritingDecisionBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Underwriting Decision Date [USDA.X150]
    /// </summary>
    public DateTime? UnderwritingDecisionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Underwriting Decision [USDA.X152]
    /// </summary>
    public StringEnumValue<UnderwritingDecisionType> UnderwritingDecisionType { get => GetValue<StringEnumValue<UnderwritingDecisionType>>(); set => SetValue(value); }

    /// <summary>
    /// Usda UsdaHouseholdIncomes
    /// </summary>
    [AllowNull]
    public IList<UsdaHouseholdIncome> UsdaHouseholdIncomes { get => GetList<UsdaHouseholdIncome>(); set => SetList(value); }

    /// <summary>
    /// USDA - Tracking - Verification Code [USDA.X163]
    /// </summary>
    public string? VerificationCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - Tracking - Date Verified in Unifi [USDA.X162]
    /// </summary>
    public DateTime? VerifiedInUnifiDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}