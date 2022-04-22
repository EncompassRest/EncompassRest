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
    /// <summary>
    /// Other Liabilities ID [URLAROL0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Contact [URLAROL0006]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Balance [URLAROL0020]
    /// </summary>
    public decimal? Balance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Borrower Type [URLAROL0001]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Country [URLAROL0022]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Credit Limit [URLAROL0021]
    /// </summary>
    public decimal? CreditLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Request Date [URLAROL0098]
    /// </summary>
    public DateTime? DepositoryRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Foreign Address Indicator [URLAROL0023]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention City [URLAROL0008]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Zipcode [URLAROL0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention State [URLAROL0009]
    /// </summary>
    public string? HolderAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Address [URLAROL0007]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Email [URLAROL0013]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Fax [URLAROL0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Name [URLAROL0005]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Phone [URLAROL0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherLiability Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Liability or Expense Type [URLAROL0002]
    /// </summary>
    public StringEnumValue<LiabilityOrExpenseType> LiabilityOrExpenseType { get => GetValue<StringEnumValue<LiabilityOrExpenseType>>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Monthly Payment [URLAROL0003]
    /// </summary>
    public decimal? MonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Months Left [URLAROL0019]
    /// </summary>
    public int? MonthsLeft { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Other Description [URLAROL0004]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [URLAROL0018]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Job Title [URLAROL0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Name as Title [URLAROL0015]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Title [URLAROL0014]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Fax [URLAROL0017]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Phone [URLAROL0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}