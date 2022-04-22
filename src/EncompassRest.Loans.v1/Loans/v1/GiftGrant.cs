using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// GiftGrant
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class GiftGrant : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Gift or Grant ID [URLARGGNN01]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Amount [URLARGGNN21]
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Asset Type [URLARGGNN18]
    /// </summary>
    public StringEnumValue<GiftGrantAssetType> AssetType { get => GetValue<StringEnumValue<GiftGrantAssetType>>(); set => SetValue(value); }

    /// <summary>
    /// Attention Contact [URLARGGNN06]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GiftGrant BorrowerId
    /// </summary>
    public string? BorrowerId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GiftGrant Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Deposited [URLARGGNN20]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Deposited\"}")]
    public bool? DepositedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GiftGrant EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GiftGrant GiftGrantIndex
    /// </summary>
    public int? GiftGrantIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Date [URLARGGNN03]
    /// </summary>
    public DateTime? GiftorGrantDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Attention City [URLARGGNN08]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention Zipcode [URLARGGNN10]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Attention State [URLARGGNN09]
    /// </summary>
    public StringEnumValue<State> HolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Address [URLARGGNN07]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Email [URLARGGNN13]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fax [URLARGGNN12]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Name [URLARGGNN05]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Phone [URLARGGNN11]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GiftGrant Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Source Description [URLARGGNN22]
    /// </summary>
    public string? OtherSourceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant is For [URLARGGNN02]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Print - See Attached Authorization [URLARGGNN04]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Print user's job title [URLARGGNN64]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Print User Name [URLARGGNN15]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant Source [URLARGGNN19]
    /// </summary>
    public StringEnumValue<GiftGrantSource> Source { get => GetValue<StringEnumValue<GiftGrantSource>>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant From Title [URLARGGNN14]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant From Fax [URLARGGNN17]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gift or Grant From Phone [URLARGGNN16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }
}