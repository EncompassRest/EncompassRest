using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// OtherIncomeSource
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class OtherIncomeSource : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Other Income Source ID [URLAROISNN01]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention Contact [URLAROISNN06]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherIncomeSource BorrowerId
    /// </summary>
    public string? BorrowerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherIncomeSource Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Description [URLAROISNN18]
    /// </summary>
    public StringEnumValue<OtherIncomeSourceDescription> Description { get => GetValue<StringEnumValue<OtherIncomeSourceDescription>>(); set => SetValue(value); }

    /// <summary>
    /// OtherIncomeSource EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Foreign Income [URLAROISNN20]
    /// </summary>
    public bool? ForeignIncomeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Attention City [URLAROISNN08]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention Zipcode [URLAROISNN10]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention State [URLAROISNN09]
    /// </summary>
    public StringEnumValue<State> HolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Address [URLAROISNN07]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Email [URLAROISNN13]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fax [URLAROISNN12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Name [URLAROISNN05]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Phone [URLAROISNN11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherIncomeSource Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Monthly Amount [URLAROISNN22]
    /// </summary>
    public decimal? MonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Other Description [URLAROISNN19]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Date [URLAROISNN03]
    /// </summary>
    public DateTime? OtherIncomeSourceDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// OtherIncomeSource OtherIncomeSourceIndex
    /// </summary>
    public int? OtherIncomeSourceIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source is For [URLAROISNN02]
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Print - See Attached Authorization [URLAROISNN04]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Print User Job Title [URLAROISNN64]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Print User Name [URLAROISNN15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Seasonal Income [URLAROISNN21]
    /// </summary>
    public bool? SeasonalIncomeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source From Title [URLAROISNN14]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source From Fax [URLAROISNN17]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source From Phone [URLAROISNN16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}