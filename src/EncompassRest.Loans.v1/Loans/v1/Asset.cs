using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Asset
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(AssetType) + "," + nameof(VodIndex), SerializeWholeListWhenDirty = true)]
public sealed partial class Asset : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Asset AccountIdentifier [182], [1715]
    /// </summary>
    public string? AccountIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Request ID [DDNN35]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset AssetIndex
    /// </summary>
    public int? AssetIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Asset AssetType
    /// </summary>
    public StringEnumValue<AssetType> AssetType { get => GetValue<StringEnumValue<AssetType>>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Contact [DDNN03]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset BorrowerId
    /// </summary>
    public string? BorrowerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset CashOrMarketValueAmount
    /// </summary>
    public decimal? CashOrMarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Asset Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Country [DDNN40]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset DepositoryAccountName
    /// </summary>
    public string? DepositoryAccountName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Request Date [DDNN98]
    /// </summary>
    public DateTime? DepositoryRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Asset Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Foreign Address Indicator [DDNN39]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention City [DDNN05]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Zipcode [DDNN07]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention State [DDNN06]
    /// </summary>
    public StringEnumValue<State> HolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Depository Address [DDNN04]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Comments [DDNN29]
    /// </summary>
    public string? HolderComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Email [DDNN28]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Fax [DDNN27]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset HolderName [DDNN02]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Phone [DDNN26]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Asset Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Include In AUS/Export [DDNN52]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Include In AUS/Export\"}")]
    public bool? IncludeInAusExport { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Asset IsEmpty
    /// </summary>
    public bool? IsEmpty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Asset IsVod
    /// </summary>
    public bool? IsVod { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Assets Life Ins Face Amt [303]
    /// </summary>
    public decimal? LifeInsuranceFaceValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Asset NameInAccount
    /// </summary>
    public string? NameInAccount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository No Link to Doc Tracking [DDNN97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Request is For [DDNN24]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [DDNN36]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Job Title [DDNN64]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Name as Title [DDNN38]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Title [DDNN37]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Fax [DDNN45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Phone [DDNN44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Total Balance [DDNN34]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Asset Urla2020CashOrMarketValueAmount
    /// </summary>
    public decimal? Urla2020CashOrMarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Asset VodIndex
    /// </summary>
    public int? VodIndex { get => GetValue<int?>(); set => SetValue(value); }
}