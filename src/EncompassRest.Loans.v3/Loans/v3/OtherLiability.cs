using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OtherLiability
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class OtherLiability : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _attention;
    private DirtyValue<decimal?>? _balance;
    private DirtyValue<StringEnumValue<Owner>>? _borrowerType;
    private DirtyValue<string?>? _country;
    private DirtyValue<decimal?>? _creditLimit;
    private DirtyValue<DateTime?>? _depositoryRequestDate;
    private DirtyValue<bool?>? _foreignAddressIndicator;
    private DirtyValue<string?>? _holderAddressCity;
    private DirtyValue<string?>? _holderAddressPostalCode;
    private DirtyValue<string?>? _holderAddressState;
    private DirtyValue<string?>? _holderAddressStreetLine1;
    private DirtyValue<string?>? _holderEmail;
    private DirtyValue<string?>? _holderFax;
    private DirtyValue<string?>? _holderName;
    private DirtyValue<string?>? _holderPhone;
    private DirtyValue<string?>? _id;
    private DirtyValue<StringEnumValue<LiabilityOrExpenseType>>? _liabilityOrExpenseType;
    private DirtyValue<decimal?>? _monthlyPayment;
    private DirtyValue<int?>? _monthsLeft;
    private DirtyValue<string?>? _otherDescription;
    private DirtyValue<bool?>? _printAttachmentIndicator;
    private DirtyValue<bool?>? _printUserJobTitleIndicator;
    private DirtyValue<bool?>? _printUserNameIndicator;
    private DirtyValue<string?>? _title;
    private DirtyValue<string?>? _titleFax;
    private DirtyValue<string?>? _titlePhone;

    /// <summary>
    /// Other Liabilities ID [URLAROL0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Depository Attention Contact [URLAROL0006]
    /// </summary>
    public string? Attention { get => _attention; set => SetField(ref _attention, value); }

    /// <summary>
    /// Other Liabilities Balance [URLAROL0020]
    /// </summary>
    public decimal? Balance { get => _balance; set => SetField(ref _balance, value); }

    /// <summary>
    /// Other Liabilities Borrower Type [URLAROL0001]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

    /// <summary>
    /// Other Liabilities Country [URLAROL0022]
    /// </summary>
    public string? Country { get => _country; set => SetField(ref _country, value); }

    /// <summary>
    /// Other Liabilities Credit Limit [URLAROL0021]
    /// </summary>
    public decimal? CreditLimit { get => _creditLimit; set => SetField(ref _creditLimit, value); }

    /// <summary>
    /// Depository Request Date [URLAROL0098]
    /// </summary>
    public DateTime? DepositoryRequestDate { get => _depositoryRequestDate; set => SetField(ref _depositoryRequestDate, value); }

    /// <summary>
    /// Depository Foreign Address Indicator [URLAROL0023]
    /// </summary>
    public bool? ForeignAddressIndicator { get => _foreignAddressIndicator; set => SetField(ref _foreignAddressIndicator, value); }

    /// <summary>
    /// Depository Attention City [URLAROL0008]
    /// </summary>
    public string? HolderAddressCity { get => _holderAddressCity; set => SetField(ref _holderAddressCity, value); }

    /// <summary>
    /// Depository Attention Zipcode [URLAROL0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => _holderAddressPostalCode; set => SetField(ref _holderAddressPostalCode, value); }

    /// <summary>
    /// Depository Attention State [URLAROL0009]
    /// </summary>
    public string? HolderAddressState { get => _holderAddressState; set => SetField(ref _holderAddressState, value); }

    /// <summary>
    /// Depository Address [URLAROL0007]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => _holderAddressStreetLine1; set => SetField(ref _holderAddressStreetLine1, value); }

    /// <summary>
    /// Depository Email [URLAROL0013]
    /// </summary>
    public string? HolderEmail { get => _holderEmail; set => SetField(ref _holderEmail, value); }

    /// <summary>
    /// Depository Fax [URLAROL0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => _holderFax; set => SetField(ref _holderFax, value); }

    /// <summary>
    /// Depository Name [URLAROL0005]
    /// </summary>
    public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

    /// <summary>
    /// Depository Phone [URLAROL0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => _holderPhone; set => SetField(ref _holderPhone, value); }

    /// <summary>
    /// OtherLiabilityContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Other Liabilities Liability or Expense Type [URLAROL0002]
    /// </summary>
    public StringEnumValue<LiabilityOrExpenseType> LiabilityOrExpenseType { get => _liabilityOrExpenseType; set => SetField(ref _liabilityOrExpenseType, value); }

    /// <summary>
    /// Other Liabilities Monthly Payment [URLAROL0003]
    /// </summary>
    public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

    /// <summary>
    /// Months Left [URLAROL0019]
    /// </summary>
    public int? MonthsLeft { get => _monthsLeft; set => SetField(ref _monthsLeft, value); }

    /// <summary>
    /// Other Liabilities Other Description [URLAROL0004]
    /// </summary>
    public string? OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [URLAROL0018]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => _printAttachmentIndicator; set => SetField(ref _printAttachmentIndicator, value); }

    /// <summary>
    /// Depository Print User Job Title [URLAROL0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => _printUserJobTitleIndicator; set => SetField(ref _printUserJobTitleIndicator, value); }

    /// <summary>
    /// Depository Print User Name as Title [URLAROL0015]
    /// </summary>
    public bool? PrintUserNameIndicator { get => _printUserNameIndicator; set => SetField(ref _printUserNameIndicator, value); }

    /// <summary>
    /// Depository From Title [URLAROL0014]
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// Depository From Fax [URLAROL0017]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => _titleFax; set => SetField(ref _titleFax, value); }

    /// <summary>
    /// Depository From Phone [URLAROL0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => _titlePhone; set => SetField(ref _titlePhone, value); }
}