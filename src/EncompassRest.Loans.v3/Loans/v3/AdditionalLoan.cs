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
    private DirtyValue<StringEnumValue<AccountType>>? _accountType;
    private DirtyValue<DateTime?>? _additionalLoanRequestDate;
    private DirtyValue<bool?>? _affordableLoan;
    private DirtyValue<string?>? _altId;
    private DirtyValue<decimal?>? _amountAppliedToDownpayment;
    private DirtyValue<string?>? _attention;
    private DirtyValue<StringEnumValue<Owner>>? _borrowerType;
    private DirtyValue<decimal?>? _helocCreditLimitAmount;
    private DirtyValue<decimal?>? _helocInitialDraw;
    private DirtyValue<string?>? _holderAddressCity;
    private DirtyValue<string?>? _holderAddressPostalCode;
    private DirtyValue<string?>? _holderAddressState;
    private DirtyValue<string?>? _holderAddressStreetLine1;
    private DirtyValue<string?>? _holderEmail;
    private DirtyValue<string?>? _holderFax;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<string?>? _holderPhone;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _individualCreditorIndicator;
    private DirtyValue<StringEnumValue<AdditionalLoanLienPosition>>? _lienPosition;
    private DirtyValue<bool?>? _linkedPiggybackIndicator;
    private DirtyValue<decimal?>? _maximumPiLoanAmount;
    private DirtyValue<decimal?>? _maximumPiNoteRate;
    private DirtyValue<int?>? _maximumPiTerm;
    private DirtyValue<decimal?>? _maximumPrincipalAndInterestIn5Years;
    private DirtyValue<decimal?>? _monthlyPiLoanAmount;
    private DirtyValue<decimal?>? _monthlyPiNoteRate;
    private DirtyValue<int?>? _monthlyPiTerm;
    private DirtyValue<decimal?>? _monthlyPrincipalAndInterest;
    private DirtyValue<bool?>? _paymentDeferredFirstFiveYears;
    private DirtyValue<bool?>? _printAttachmentIndicator;
    private DirtyValue<bool?>? _printUserJobTitleIndicator;
    private DirtyValue<bool?>? _printUserNameIndicator;
    private DirtyValue<StringEnumValue<SourceOfFunds>>? _sourceOfFunds;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleFax;
    private DirtyValue<string?>? _titlePhone;

    /// <summary>
    /// Additional Loans AccountType [URLARAL0016]
    /// </summary>
    public StringEnumValue<AccountType> AccountType { get => _accountType; set => SetField(ref _accountType, value); }

    /// <summary>
    /// Additional Loans Request Date [URLARAL0098]
    /// </summary>
    public DateTime? AdditionalLoanRequestDate { get => _additionalLoanRequestDate; set => SetField(ref _additionalLoanRequestDate, value); }

    /// <summary>
    /// Additional Loans  Affordable Loan Indicator [URLARAL0024]
    /// </summary>
    public bool? AffordableLoan { get => _affordableLoan; set => SetField(ref _affordableLoan, value); }

    /// <summary>
    /// Additional Loans ID [URLARAL0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Additional Loans Amount Applied To Downpayment [URLARAL0022]
    /// </summary>
    public decimal? AmountAppliedToDownpayment { get => _amountAppliedToDownpayment; set => SetField(ref _amountAppliedToDownpayment, value); }

    /// <summary>
    /// Depository Attention Contact [URLARAL0003]
    /// </summary>
    public string? Attention { get => _attention; set => SetField(ref _attention, value); }

    /// <summary>
    /// Additional Loans Borrower Type [URLARAL0001]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

    /// <summary>
    /// Additional Loans : Loan Amount/HELOC Credit Limit [URLARAL0020]
    /// </summary>
    public decimal? HelocCreditLimitAmount { get => _helocCreditLimitAmount; set => SetField(ref _helocCreditLimitAmount, value); }

    /// <summary>
    /// Additional Loans HELOC Initial Draw [URLARAL0021]
    /// </summary>
    public decimal? HelocInitialDraw { get => _helocInitialDraw; set => SetField(ref _helocInitialDraw, value); }

    /// <summary>
    /// Depository Attention City [URLARAL0005]
    /// </summary>
    public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

    /// <summary>
    /// Depository Attention Zipcode [URLARAL0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

    /// <summary>
    /// Depository Attention State [URLARAL0006]
    /// </summary>
    public string? HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

    /// <summary>
    /// Depository Address [URLARAL0004]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

    /// <summary>
    /// Depository Email [URLARAL0010]
    /// </summary>
    public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

    /// <summary>
    /// Depository Fax [URLARAL0009]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

    /// <summary>
    /// Depository Name [URLARAL0002]
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// Depository Phone [URLARAL0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

    /// <summary>
    /// AdditionalLoanContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Creditor is an individual Indicator [URLARAL0032]
    /// </summary>
    public bool? IndividualCreditorIndicator { get => _individualCreditorIndicator; set => SetField(ref _individualCreditorIndicator, value); }

    /// <summary>
    /// Additional Loans Lien Position [URLARAL0017]
    /// </summary>
    public StringEnumValue<AdditionalLoanLienPosition> LienPosition { get => _lienPosition; set => SetField(ref _lienPosition, value); }

    /// <summary>
    /// Additional Loans Linked Piggyback Indicator [URLARAL0025]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? LinkedPiggybackIndicator { get => _linkedPiggybackIndicator; set => SetField(ref _linkedPiggybackIndicator, value); }

    /// <summary>
    /// Additional Loans MaximumPILoanAmount [URLARAL0031]
    /// </summary>
    public decimal? MaximumPiLoanAmount { get => _maximumPiLoanAmount; set => SetField(ref _maximumPiLoanAmount, value); }

    /// <summary>
    /// Additional Loans : MaximumPINoteRate [URLARAL0029]
    /// </summary>
    public decimal? MaximumPiNoteRate { get => _maximumPiNoteRate; set => SetField(ref _maximumPiNoteRate, value); }

    /// <summary>
    /// Additional Loans MaximumPITerm [URLARAL0030]
    /// </summary>
    public int? MaximumPiTerm { get => _maximumPiTerm; set => SetField(ref _maximumPiTerm, value); }

    /// <summary>
    /// Additional Loans Maximum Principal and Interest within 5 Years [URLARAL0019]
    /// </summary>
    public decimal? MaximumPrincipalAndInterestIn5Years { get => _maximumPrincipalAndInterestIn5Years; set => SetField(ref _maximumPrincipalAndInterestIn5Years, value); }

    /// <summary>
    /// Additional Loans MonthlyPILoanAmount [URLARAL0028]
    /// </summary>
    public decimal? MonthlyPiLoanAmount { get => _monthlyPiLoanAmount; set => SetField(ref _monthlyPiLoanAmount, value); }

    /// <summary>
    /// Additional Loans calculator : MonthlyPINoteRate [URLARAL0026]
    /// </summary>
    public decimal? MonthlyPiNoteRate { get => _monthlyPiNoteRate; set => SetField(ref _monthlyPiNoteRate, value); }

    /// <summary>
    /// Additional Loans MonthlyPITerm [URLARAL0027]
    /// </summary>
    public int? MonthlyPiTerm { get => _monthlyPiTerm; set => SetField(ref _monthlyPiTerm, value); }

    /// <summary>
    /// Additional Loans Monthly Principal and Interest [URLARAL0018]
    /// </summary>
    public decimal? MonthlyPrincipalAndInterest { get => _monthlyPrincipalAndInterest; set => SetField(ref _monthlyPrincipalAndInterest, value); }

    /// <summary>
    /// Additional Loans Payment Deferred First Five Years [URLARAL0023]
    /// </summary>
    public bool? PaymentDeferredFirstFiveYears { get => _paymentDeferredFirstFiveYears; set => SetField(ref _paymentDeferredFirstFiveYears, value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [URLARAL0015]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// Depository Print User Job Title [URLARAL0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// Depository Print User Name as Title [URLARAL0012]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// Source of Funds [URLARAL0033]
    /// </summary>
    public StringEnumValue<SourceOfFunds> SourceOfFunds { get => _sourceOfFunds; set => SetField(ref _sourceOfFunds, value); }

    /// <summary>
    /// Depository From Title [URLARAL0011]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// Depository From Fax [URLARAL0014]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// Depository From Phone [URLARAL0013]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
}