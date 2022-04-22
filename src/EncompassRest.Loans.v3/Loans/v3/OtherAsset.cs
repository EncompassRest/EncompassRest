using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// OtherAsset
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class OtherAsset : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Other Assets Other Asset Id [URLAROA0099]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Asset Type [URLAROA0002]
    /// </summary>
    public StringEnumValue<OtherAssetType> AssetType { get => GetValue<StringEnumValue<OtherAssetType>>(); set => SetValue(value); }

    /// <summary>
    /// Other Asset Attention [URLAROA0006]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Borrower Type [URLAROA0001]
    /// </summary>
    public StringEnumValue<Owner> BorrowerType { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Cash Or Market Value [URLAROA0003]
    /// </summary>
    public decimal? CashOrMarketValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Address City [URLAROA0008]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Address Postal Code [URLAROA0010]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Address State [URLAROA0009]
    /// </summary>
    public string? HolderAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Address Street Line 1 [URLAROA0007]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Email [URLAROA0013]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Fax [URLAROA0012]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Asset Creditor Name [URLAROA0005]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Holder Phone [URLAROA0011]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherAsset Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Asset Date [URLAROA0019]
    /// </summary>
    public DateTime? OtherAssetDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Other Description [URLAROA0004]
    /// </summary>
    public StringEnumValue<OtherDescription> OtherDescription { get => GetValue<StringEnumValue<OtherDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Print - See Attached Authorization [URLAROA0018]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Print User Job Title [URLAROA0020]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets Print User Name as Title [URLAROA0015]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant From Title [URLAROA0014]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets From Fax [URLAROA0017]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Assets From Phone [URLAROA0016]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}