using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Vod
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Vod : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Depository Request ID [DD0035]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Contact [DD0003]
    /// </summary>
    public string? Attention { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Country [DD0040]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Request Date [DD0098]
    /// </summary>
    public DateTime? DepositoryRequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Foreign Address Indicator [DD0039]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention City [DD0005]
    /// </summary>
    public string? HolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention Zipcode [DD0007]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? HolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Attention State [DD0006]
    /// </summary>
    public string? HolderAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Address [DD0004]
    /// </summary>
    public string? HolderAddressStreetLine1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Comments [DD0029]
    /// </summary>
    public string? HolderComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Email [DD0028]
    /// </summary>
    public string? HolderEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Fax [DD0027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Name [DD0002]
    /// </summary>
    public string? HolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Phone [DD0026]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HolderPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Vod Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Include In AUS/Export [DD0052]
    /// </summary>
    public bool? IncludeInAusExport { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Vod Items
    /// </summary>
    [AllowNull]
    public IList<VodItem> Items { get => GetList<VodItem>(); set => SetList(value); }

    /// <summary>
    /// Depository No Link to Doc Tracking [DD0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Request is For [DD0024]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print - See Attached Authorization [DD0036]
    /// </summary>
    public bool? PrintAttachmentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Job Title [DD0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Print User Name as Title [DD0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Title [DD0037]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Fax [DD0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository From Phone [DD0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Depository Total Balance [DD0034]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => GetValue<decimal?>(); set => SetValue(value); }
}