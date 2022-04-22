using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OtherIncomeSource
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class OtherIncomeSource : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Other Income Source ID [URLAROIS0001]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention Contact [URLAROIS0006]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Description [URLAROIS0018]
    /// </summary>
    public StringEnumValue<OtherIncomeSourceDescription> Description { get => GetValue<StringEnumValue<OtherIncomeSourceDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Foreign Income [URLAROIS0020]
    /// </summary>
    public bool? ForeignIncomeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Attention City [URLAROIS0008]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention Zipcode [URLAROIS0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention State [URLAROIS0009]
    /// </summary>
    public string? HolderAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Address [URLAROIS0007]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Email [URLAROIS0013]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fax [URLAROIS0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Name [URLAROIS0005]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Phone [URLAROIS0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherIncomeSource Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Monthly Amount [URLAROIS0022]
    /// </summary>
    public decimal? MonthlyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Other Description [URLAROIS0019]
    /// </summary>
    public string? OtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Date [URLAROIS0003]
    /// </summary>
    public DateTime? OtherIncomeSourceDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source is For [URLAROIS0002]
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Print - See Attached Authorization [URLAROIS0004]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Print User Job Title [URLAROIS0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source Print User Name [URLAROIS0015]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Seasonal Income [URLAROIS0021]
    /// </summary>
    public bool? SeasonalIncomeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source From Title [URLAROIS0014]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source From Fax [URLAROIS0017]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Income Source From Phone [URLAROIS0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}