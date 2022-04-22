using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// AdditionalLoan
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AdditionalLoan : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Additional Loans AccountType [URLARALNN16]
    /// </summary>
    public StringEnumValue<AccountType> AccountType { get => GetValue<StringEnumValue<AccountType>>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Request Date [URLARALNN98]
    /// </summary>
    public DateTime? AdditionalLoanRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans  Affordable Loan Indicator [URLARALNN24]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Affordable Loan \"}")]
    public bool? AffordableLoan { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans ID [URLARALNN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Amount Applied To Downpayment [URLARALNN22]
    /// </summary>
    public decimal? AmountAppliedToDownpayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Contact [URLARALNN03]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Borrower Type [URLARALNN01]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// AdditionalLoan Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// AdditionalLoan EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans : Loan Amount/HELOC Credit Limit [URLARALNN20]
    /// </summary>
    public decimal? HELOCCreditLimitAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans HELOC Initial Draw [URLARALNN21]
    /// </summary>
    public decimal? HELOCInitialDraw { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention City [URLARALNN05]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Zipcode [URLARALNN07]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention State [URLARALNN06]
    /// </summary>
    public StringEnumValue<State> HolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Depository Address [URLARALNN04]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Email [URLARALNN10]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Fax [URLARALNN09]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Name [URLARALNN02]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Phone [URLARALNN08]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AdditionalLoan Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Creditor is an individual Indicator [URLARALNN32]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Creditor is an individual\"}")]
    public bool? IndividualCreditorIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Lien Position [URLARALNN17]
    /// </summary>
    public StringEnumValue<AdditionalLoanLienPosition> LienPosition { get => GetValue<StringEnumValue<AdditionalLoanLienPosition>>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Linked Piggyback Indicator [URLARALNN25]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Linked Piggyback Indicator \"}")]
    public bool? LinkedPiggybackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans MaximumPILoanAmount [URLARALNN31]
    /// </summary>
    public decimal? MaximumPILoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans : MaximumPINoteRate [URLARALNN29]
    /// </summary>
    public decimal? MaximumPINoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans MaximumPITerm [URLARALNN30]
    /// </summary>
    public int? MaximumPITerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Maximum Principal and Interest within 5 Years [URLARALNN19]
    /// </summary>
    public decimal? MaximumPrincipalAndInterestIn5Years { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans MonthlyPILoanAmount [URLARALNN28]
    /// </summary>
    public decimal? MonthlyPILoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans calculator : MonthlyPINoteRate [URLARALNN26]
    /// </summary>
    public decimal? MonthlyPINoteRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans MonthlyPITerm [URLARALNN27]
    /// </summary>
    public int? MonthlyPITerm { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Monthly Principal and Interest [URLARALNN18]
    /// </summary>
    public decimal? MonthlyPrincipalAndInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Additional Loans Payment Deferred First Five Years [URLARALNN23]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Payment Deferred for First Five Years\"}")]
    public bool? PaymentDeferredFirstFiveYears { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [URLARALNN15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Job Title [URLARALNN64]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Name as Title [URLARALNN12]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Source of Funds [URLARALNN33]
    /// </summary>
    public StringEnumValue<SourceOfFunds> SourceOfFunds { get => GetValue<StringEnumValue<SourceOfFunds>>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Title [URLARALNN11]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Fax [URLARALNN14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Phone [URLARALNN13]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}