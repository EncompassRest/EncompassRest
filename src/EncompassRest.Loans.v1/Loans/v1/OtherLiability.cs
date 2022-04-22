using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// OtherLiability
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class OtherLiability : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Other Liabilities ID [URLAROLNN99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Contact [URLAROLNN06]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Balance [URLAROLNN20]
    /// </summary>
    public decimal? Balance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Borrower Type [URLAROLNN01]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// OtherLiability Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Country [URLAROLNN22]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Credit Limit [URLAROLNN21]
    /// </summary>
    public decimal? CreditLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Request Date [URLAROLNN98]
    /// </summary>
    public DateTime? DepositoryRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// OtherLiability EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Foreign Address Indicator [URLAROLNN23]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention City [URLAROLNN08]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Zipcode [URLAROLNN10]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention State [URLAROLNN09]
    /// </summary>
    public StringEnumValue<State> HolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Depository Address [URLAROLNN07]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Email [URLAROLNN13]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Fax [URLAROLNN12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Name [URLAROLNN05]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Phone [URLAROLNN11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherLiability Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Liability or Expense Type [URLAROLNN02]
    /// </summary>
    public StringEnumValue<LiabilityOrExpenseType> LiabilityOrExpenseType { get => GetValue<StringEnumValue<LiabilityOrExpenseType>>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Monthly Payment [URLAROLNN03]
    /// </summary>
    public decimal? MonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Months Left [URLAROLNN19]
    /// </summary>
    public int? MonthsLeft { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Other Liabilities Other Description [URLAROLNN04]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [URLAROLNN18]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Job Title [URLAROLNN64]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Name as Title [URLAROLNN15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Title [URLAROLNN14]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Fax [URLAROLNN17]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Phone [URLAROLNN16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}