using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AdditionalLoan
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AdditionalLoan : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Additional Loans AccountType [URLARAL0016]
    /// </summary>
    public StringEnumValue<AccountType> AccountType { get => GetValue<StringEnumValue<AccountType>>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Request Date [URLARAL0098]
    /// </summary>
    public DateTime? AdditionalLoanRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans  Affordable Loan Indicator [URLARAL0024]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Affordable Loan\"}")]
    public bool? AffordableLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans ID [URLARAL0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Amount Applied To Downpayment [URLARAL0022]
    /// </summary>
    public decimal? AmountAppliedToDownpayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Contact [URLARAL0003]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Borrower Type [URLARAL0001]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans : Loan Amount/HELOC Credit Limit [URLARAL0020]
    /// </summary>
    public decimal? HelocCreditLimitAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans HELOC Initial Draw [URLARAL0021]
    /// </summary>
    public decimal? HelocInitialDraw { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention City [URLARAL0005]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Zipcode [URLARAL0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention State [URLARAL0006]
    /// </summary>
    public string? HolderAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Address [URLARAL0004]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Email [URLARAL0010]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Fax [URLARAL0009]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Name [URLARAL0002]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Phone [URLARAL0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AdditionalLoan Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Creditor is an individual Indicator [URLARAL0032]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Creditor is an individual\"}")]
    public bool? IndividualCreditorIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Lien Position [URLARAL0017]
    /// </summary>
    public StringEnumValue<AdditionalLoanLienPosition> LienPosition { get => GetValue<StringEnumValue<AdditionalLoanLienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Linked Piggyback Indicator [URLARAL0025]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Linked Piggyback Indicator\"}", ReadOnly = true)]
    public bool? LinkedPiggybackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans MaximumPILoanAmount [URLARAL0031]
    /// </summary>
    public decimal? MaximumPiLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans : MaximumPINoteRate [URLARAL0029]
    /// </summary>
    public decimal? MaximumPiNoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans MaximumPITerm [URLARAL0030]
    /// </summary>
    public int? MaximumPiTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Maximum Principal and Interest within 5 Years [URLARAL0019]
    /// </summary>
    public decimal? MaximumPrincipalAndInterestIn5Years { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans MonthlyPILoanAmount [URLARAL0028]
    /// </summary>
    public decimal? MonthlyPiLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans calculator : MonthlyPINoteRate [URLARAL0026]
    /// </summary>
    public decimal? MonthlyPiNoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans MonthlyPITerm [URLARAL0027]
    /// </summary>
    public int? MonthlyPiTerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Monthly Principal and Interest [URLARAL0018]
    /// </summary>
    public decimal? MonthlyPrincipalAndInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Payment Deferred First Five Years [URLARAL0023]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Payment Deferred for First Five Years\"}")]
    public bool? PaymentDeferredFirstFiveYears { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [URLARAL0015]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Job Title [URLARAL0064]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Name as Title [URLARAL0012]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Source of Funds [URLARAL0033]
    /// </summary>
    public StringEnumValue<SourceOfFunds> SourceOfFunds { get => GetValue<StringEnumValue<SourceOfFunds>>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Title [URLARAL0011]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Fax [URLARAL0014]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Phone [URLARAL0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}