using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// FhaVaLoan
/// </summary>
public sealed partial class FhaVaLoan : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// HUD Addendum Type [1711]
    /// </summary>
    public StringEnumValue<AddendumType> AddendumType { get => GetValue<StringEnumValue<AddendumType>>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 1 [3185]
    /// </summary>
    public bool? AdditionalCondition1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 2 [3186]
    /// </summary>
    public bool? AdditionalCondition2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 3 [3187]
    /// </summary>
    public bool? AdditionalCondition3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 4 [3188]
    /// </summary>
    public bool? AdditionalCondition4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 5 [3189]
    /// </summary>
    public bool? AdditionalCondition5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 6 [3190]
    /// </summary>
    public bool? AdditionalCondition6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 7 [3191]
    /// </summary>
    public bool? AdditionalCondition7 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 8 [3193]
    /// </summary>
    public bool? AdditionalCondition8 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 9 [3195]
    /// </summary>
    public bool? AdditionalCondition9 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Address Validated By [3061]
    /// </summary>
    public string? AddressValidatedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Address Validation Message [3063]
    /// </summary>
    public string? AddressValidationMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum - All Conditions of Approval Have Been Satisfied Indicator [4092]
    /// </summary>
    public bool? AllConditionsSatisfied { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Appraisal Logged Date [3076]
    /// </summary>
    public DateTime? AppraisalLoggedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Appraisal Lookup By [3077]
    /// </summary>
    public string? AppraisalLookupBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Property Value [1639]
    /// </summary>
    public StringEnumValue<BeenInformed> BeenInformed { get => GetValue<StringEnumValue<BeenInformed>>(); set => SetValue(value); }

    /// <summary>
    /// Borr Other Ownd RE Addr [461]
    /// </summary>
    public string? BorrowerCertificationAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Other RE City [1738]
    /// </summary>
    public string? BorrowerCertificationCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Other RE Zip [1740]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? BorrowerCertificationPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Other RE State [1739]
    /// </summary>
    public StringEnumValue<State> BorrowerCertificationState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management CAIVRS Obtained By [3068]
    /// </summary>
    public string? CAIVRSObtainedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Case Binder Shipped By [3091]
    /// </summary>
    public string? CaseBinderShippedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Case Binder Shipped Date [3090]
    /// </summary>
    public DateTime? CaseBinderShippedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Closed Date [748]
    /// </summary>
    public DateTime? ClosingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management CondoPud ID [3075]
    /// </summary>
    public string? CondoPudID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Condo Pud Lookup By [3074]
    /// </summary>
    public string? CondoPudLookupBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Condo Pud Lookup Date [3073]
    /// </summary>
    public DateTime? CondoPudLookupDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Closing Cost [FICC.X15]
    /// </summary>
    public decimal? ConventionalClosingCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Down Payment [FICC.X16]
    /// </summary>
    public decimal? ConventionalDownPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Interest Rate [FICC.X17]
    /// </summary>
    public decimal? ConventionalInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Loan Term [FICC.X18]
    /// </summary>
    public int? ConventionalLoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional LTV [FICC.X20]
    /// </summary>
    public decimal? ConventionalLTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Max Years of Monthly Insurance Premium Payments [FICC.X22]
    /// </summary>
    public int? ConventionalMaxYearsMI { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Monthly Mortgage Income [FICC.X21]
    /// </summary>
    public decimal? ConventionalMMI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Monthly Payment [FICC.X19]
    /// </summary>
    public decimal? ConventionalMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Mortgage Amount [FICC.X14]
    /// </summary>
    public decimal? ConventionalMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional Sales Price [FICC.X13]
    /// </summary>
    public decimal? ConventionalSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice Conventional UMIP [FICC.X23]
    /// </summary>
    public decimal? ConventionalUMIP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Date Approval Expires [3177]
    /// </summary>
    public DateTime? DateApprovalExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Date Mtg Approved [3176]
    /// </summary>
    public DateTime? DateMortgageApproved { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Addl Condition Check 7 Detail [3192]
    /// </summary>
    public string? DetailForOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Discounts [1046]
    /// </summary>
    public decimal? DiscountPoints { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 1 [1795]
    /// </summary>
    public string? DulyAgentAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Lender Cert Author Agent Addr 2 [684]
    /// </summary>
    public string? DulyAgentCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Function 1 [1796]
    /// </summary>
    public string? DulyAgentFunction1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Function 2 [1798]
    /// </summary>
    public string? DulyAgentFunction2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Name [322]
    /// </summary>
    public string? DulyAgentName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 3 [1797]
    /// </summary>
    public string? DulyAgentState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 2 [4691]
    /// </summary>
    public string? DulyAuthAgentAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 3 [4695]
    /// </summary>
    public string? DulyAuthAgentAddress3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 4 [4700]
    /// </summary>
    public string? DulyAuthAgentAddress4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Addr 5 [4705]
    /// </summary>
    public string? DulyAuthAgentAddress5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Lender Cert Author Agent City 2 [4692]
    /// </summary>
    public string? DulyAuthAgentCity2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Author Agent City 3 [4696]
    /// </summary>
    public string? DulyAuthAgentCity3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Author Agent City 4 [4701]
    /// </summary>
    public string? DulyAuthAgentCity4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Author Agent City 5 [4706]
    /// </summary>
    public string? DulyAuthAgentCity5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Function 3 [4698]
    /// </summary>
    public string? DulyAuthAgentFunction3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Function 4 [4703]
    /// </summary>
    public string? DulyAuthAgentFunction4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Function 5 [4708]
    /// </summary>
    public string? DulyAuthAgentFunction5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Name 2 [4690]
    /// </summary>
    public string? DulyAuthAgentName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Name 3 [4694]
    /// </summary>
    public string? DulyAuthAgentName3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Name 4 [4699]
    /// </summary>
    public string? DulyAuthAgentName4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent Name 5 [4704]
    /// </summary>
    public string? DulyAuthAgentName5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent State 2 [4693]
    /// </summary>
    public string? DulyAuthAgentState2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent State 3 [4697]
    /// </summary>
    public string? DulyAuthAgentState3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent State 4 [4702]
    /// </summary>
    public string? DulyAuthAgentState4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Duly Auth Agent State 5 [4707]
    /// </summary>
    public string? DulyAuthAgentState5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Dwelling To Be Covered By Yes/No [1016]
    /// </summary>
    public bool? DwellingCoveredBy { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FhaVaLoan Eem
    /// </summary>
    [AllowNull]
    public EnergyEfficientMortgage Eem { get => GetEntity<EnergyEfficientMortgage>(); set => SetEntity(value); }

    /// <summary>
    /// FHA Management Eligibility Assessment [3631]
    /// </summary>
    public StringEnumValue<EligibilityAssessment> EligibilityAssessment { get => GetValue<StringEnumValue<EligibilityAssessment>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Energy Eff Improvements Amt [1721]
    /// </summary>
    public decimal? EnergyEfficientMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FhaVaLoan EnergyEfficientMortgageItems
    /// </summary>
    [AllowNull]
    public IList<EnergyEfficientMortgageItem> EnergyEfficientMortgageItems { get => GetList<EnergyEfficientMortgageItem>(); set => SetList(value); }

    /// <summary>
    /// Borr Cert Prior VA Home Loan [1398]
    /// </summary>
    public bool? EverHadVAHomeLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Excess Seller Contribution [3053]
    /// </summary>
    public decimal? ExcessContributionAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Existing Debt for Refi Loan [3052]
    /// </summary>
    public decimal? ExistingDebtAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management FHA Case Ordered By [3059]
    /// </summary>
    public string? FHACaseOrderedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Closing Cost [FICC.X4]
    /// </summary>
    public decimal? FHAClosingCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Down Payment [FICC.X5]
    /// </summary>
    public decimal? FHADownPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Interest Rate [FICC.X6]
    /// </summary>
    public decimal? FHAInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Loan Term [FICC.X7]
    /// </summary>
    public int? FHALoanTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA LTV [FICC.X9]
    /// </summary>
    public decimal? FHALTV { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Counsel Type [3062]
    /// </summary>
    public StringEnumValue<FHAManagementCounselType> FHAManagementCounselType { get => GetValue<StringEnumValue<FHAManagementCounselType>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Max Loan Amt [1720]
    /// </summary>
    public decimal? FHAMaxLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Monthly Mortgage Income [FICC.X10]
    /// </summary>
    public decimal? FHAMMI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Monthly Payment [FICC.X8]
    /// </summary>
    public decimal? FHAMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Mortgage Amount [FICC.X2]
    /// </summary>
    public decimal? FHAMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Mortgage Amount with UMIP [FICC.X3]
    /// </summary>
    public decimal? FHAMortgageAmountUMIP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Sales Price [FICC.X1]
    /// </summary>
    public decimal? FHASalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA UMIP [FICC.X12]
    /// </summary>
    public decimal? FHAUMIP { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Informed Consumer Choice FHA Max Years of Monthly Insurance Premium Payments [FICC.X11]
    /// </summary>
    public int? FHAYearsMonthlyInsurance { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Process Mgmt Foreclosed Property [3093]
    /// </summary>
    public bool? ForeclosedProperty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Freddie Mac Counsel Type [2847]
    /// </summary>
    public StringEnumValue<FreddieMacCounselType> FreddieMacCounselType { get => GetValue<StringEnumValue<FreddieMacCounselType>>(); set => SetValue(value); }

    /// <summary>
    /// FHA Funding Fee Paid in Cash [1160]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FundingFeePaidInCash { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Gift Funds Amt [220]
    /// </summary>
    public decimal? GiftFundsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Rec Lead Paint Poisoning Info [1400]
    /// </summary>
    public bool? HaveReceivedLeadPaintPoisoningInfo { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Approved or Modified [3175]
    /// </summary>
    public StringEnumValue<HUD1003AddendumApproved> HUD1003AddendumApproved { get => GetValue<StringEnumValue<HUD1003AddendumApproved>>(); set => SetValue(value); }

    /// <summary>
    /// FhaVaLoan Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Entity Acting As Agent [4688]
    /// </summary>
    public bool? IsEntityActingAsAgent { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Last Refi Date [3057]
    /// </summary>
    public DateTime? LastRefiDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management LDP/GSA Search Date [3069]
    /// </summary>
    public DateTime? LDPGSASearchDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management LDP/GSA Searched By [3070]
    /// </summary>
    public string? LDPGSASearchedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Lender Addr [3633]
    /// </summary>
    public string? LenderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Lender City [3634]
    /// </summary>
    public string? LenderCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Lender Co Name [3632]
    /// </summary>
    public string? LenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Lender Info NMLS [3637]
    /// </summary>
    public string? LenderNMLS { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Lender Zip [3636]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LenderPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Lenders Rep Name [1754]
    /// </summary>
    public string? LenderRepresentativeName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Lenders Rep Phone [1756]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? LenderRepresentativePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Lenders Rep Title [1755]
    /// </summary>
    public string? LenderRepresentativeTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Lender State [3635]
    /// </summary>
    public StringEnumValue<State> LenderState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3638]
    /// </summary>
    public string? LenderTaxID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Loan Score ID [3630]
    /// </summary>
    public string? LoanScoreID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management MI Applied By [3087]
    /// </summary>
    public string? MIAppliedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management MI Applied Date [3086]
    /// </summary>
    public DateTime? MIAppliedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management MIC Retrived Date [3089]
    /// </summary>
    public DateTime? MICRetrivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Min Down Pymt [1117]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumDownPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management MIP 1st Due Date [3083]
    /// </summary>
    public DateTime? MIP1stDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management MIP 1st To Investor [3085]
    /// </summary>
    public DateTime? MIP1stToInvestor { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management MIP Periodic Remitted Date [3084]
    /// </summary>
    public DateTime? MIPRemittedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management MI Rejected Date [3088]
    /// </summary>
    public DateTime? MIRejectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Interest Rate [3179]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ModifiedInterestRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Loan Amount [3178]
    /// </summary>
    public decimal? ModifiedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Mthly Pymt [3182]
    /// </summary>
    public decimal? ModifiedMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Amt Mthly Premium [3184]
    /// </summary>
    public decimal? ModifiedMonthlyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Proposed Maturity Mth [3181]
    /// </summary>
    public int? ModifiedProposedMaturityMonth { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Proposed Maturity Yr [3180]
    /// </summary>
    public int? ModifiedProposedMaturityYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Term Annual Premium [3196]
    /// </summary>
    public int? ModifiedTermAnnualPremium { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mod Amt Up Front Premium [3183]
    /// </summary>
    public decimal? ModifiedUpfrontPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Mortgagee Representative [3194]
    /// </summary>
    public string? MortgageeRepresentative { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Mtg Financial Interest Does/Does Not [153]
    /// </summary>
    public StringEnumValue<DoesOrDoesNot> MortgageFinancialInterest { get => GetValue<StringEnumValue<DoesOrDoesNot>>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Non-Realty/Other Items [1137]
    /// </summary>
    public decimal? NonRealtyAndOtherItems { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Obtain CAIVRS Date [3067]
    /// </summary>
    public DateTime? ObtainCAIVRSDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Occupancy [1065]
    /// </summary>
    public StringEnumValue<Occupancy> Occupancy { get => GetValue<StringEnumValue<Occupancy>>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Old Agency Case Identifier [3066]
    /// </summary>
    public string? OldAgencyCaseIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Original Mtg Amt [744]
    /// </summary>
    public decimal? OriginalMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Other Mo Pymt [1648]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherLiabilitiesMonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liabilities Other Unpaid Bal [1649]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherLiabilitiesUnpaidBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Mo Shelter Exp Est Other [1348]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherMonthlyShelterExpense { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// VA Title Other Descr [1064]
    /// </summary>
    public string? OtherTitleDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Own More than 4 [1017]
    /// </summary>
    public bool? OwnMoreThanFourDwellings { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Own/Sold Other than RE [900]
    /// </summary>
    public bool? OwnOrSoldOtherRealEstate { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Paid Amt [201]
    /// </summary>
    public decimal? PaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Premium # Mos [409]
    /// </summary>
    public int? PremiumMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Prepaid Expenses [61]
    /// </summary>
    public decimal? PrepaidExpenses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Previous Purchase Date [3058]
    /// </summary>
    public DateTime? PreviousPurchaseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Refi Authorization Prior Endorsement Date [3432]
    /// </summary>
    public DateTime? PriorEndorsementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD Maturity Mos [1392]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ProposedMaturityMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Term [1347]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? ProposedMaturityYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Purpose VA [28]
    /// </summary>
    public StringEnumValue<FhaVaLoanPurposeOfLoan> PurposeOfLoan { get => GetValue<StringEnumValue<FhaVaLoanPurposeOfLoan>>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Refi Authorization By [3065]
    /// </summary>
    public string? RefiAuthorizationBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Refi Authorization Date [3064]
    /// </summary>
    public DateTime? RefiAuthorizationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Other RE Sales Price [687]
    /// </summary>
    public decimal? SalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW 2nd Mtg Amt [1140]
    /// </summary>
    public decimal? SecondMortgageAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total FHA Closing Costs Seller [1131]
    /// </summary>
    public decimal? SellerPaidClosingCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Serving Transfered Date [3092]
    /// </summary>
    public DateTime? ServingTransferedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VA Mo Shelter Exp Est Special Asmts [1346]
    /// </summary>
    public decimal? SpecialAssessments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Sponsor/Agent Street [1113]
    /// </summary>
    public string? SponsorAgentAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Sponsor/Agent City [1114]
    /// </summary>
    public string? SponsorAgentCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Sponsor/Agent Name [1111]
    /// </summary>
    public string? SponsorAgentName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsor Agent Info NMLS [3640]
    /// </summary>
    public string? SponsorAgentNMLS { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Sponsor/Agent Zip [1744]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SponsorAgentPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Sponsor/Agent State [1743]
    /// </summary>
    public StringEnumValue<State> SponsorAgentState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsor Agent Info Tax ID [3641]
    /// </summary>
    public string? SponsorAgentTaxID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsored Originations Name [3656]
    /// </summary>
    public string? SponsoredOriginationsName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsored Originations NMLS ID [3657]
    /// </summary>
    public string? SponsoredOriginationsNMLS { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Sponsored Originations Tax ID [3658]
    /// </summary>
    public string? SponsoredOriginationsTaxID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Sponsor ID [1060]
    /// </summary>
    public string? SponsorID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VA Title Vested In [1497]
    /// </summary>
    public StringEnumValue<TitleVestedIn> TitleVestedIn { get => GetValue<StringEnumValue<TitleVestedIn>>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Other RE To Be Sold [933]
    /// </summary>
    public bool? ToBeSold { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA MCAW Total Closing Cost [386]
    /// </summary>
    public decimal? TotalClosingCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Total Scorecard By [3072]
    /// </summary>
    public string? TotalScorecardBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Total Scorecard Date [3071]
    /// </summary>
    public DateTime? TotalScorecardDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management UFMIP Remittance Due Date [3078]
    /// </summary>
    public DateTime? UFMIPRemittanceDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management UFMIP Remitted Amount [3081]
    /// </summary>
    public decimal? UFMIPRemittedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management UFMIP Remitted By [3080]
    /// </summary>
    public string? UFMIPRemittedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management UFMIP Remitted Date [3079]
    /// </summary>
    public DateTime? UFMIPRemittedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management UFMIP Verification Code [3082]
    /// </summary>
    public string? UFMIPVerificationCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD 1003 Addendum Use Default Lender [3639]
    /// </summary>
    public bool? UseDefaultLenderInfo { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Borr Mo Housing Exp Utiliy Incl [1087]
    /// </summary>
    public bool? UtilityIncluded { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FHA Management Address Validation Date [3060]
    /// </summary>
    public DateTime? ValidateAddressDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Cert Aware/Unaware of Valuation [1399]
    /// </summary>
    public StringEnumValue<ValuationAwareness> Valuation { get => GetValue<StringEnumValue<ValuationAwareness>>(); set => SetValue(value); }
}