using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ReoProperty
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ReoProperty : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Mortgage Property Date Acquired [FMNN22]
    /// </summary>
    public DateTime? AcquiredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property City [FMNN06]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Country [FMNN57]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Country Code [FMNN51]
    /// </summary>
    public string? CountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Disposition Status [FMNN24]
    /// </summary>
    public StringEnumValue<DispositionStatusType> DispositionStatusType { get => GetValue<StringEnumValue<DispositionStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// ReoProperty EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Foreign Address Indicator [FMNN58]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Future Use of Property [FMNN55]
    /// </summary>
    public StringEnumValue<FuturePropertyUsageType> FuturePropertyUsageType { get => GetValue<StringEnumValue<FuturePropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Description If Future Use of Property Is Other [FMNN56]
    /// </summary>
    public string? FutureUsageTypeOtherDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Type [FMNN18]
    /// </summary>
    public StringEnumValue<GsePropertyType> GsePropertyType { get => GetValue<StringEnumValue<GsePropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// ReoProperty Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Include In AUS/Export [FMNN52]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Include In AUS/Export\"}")]
    public bool? IncludeInAusExport { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// ReoProperty IsEmpty
    /// </summary>
    public bool? IsEmpty { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Not linked to Liability [FMNN49]
    /// </summary>
    public bool? LiabilityDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Monthly Payment [FMNN16]
    /// </summary>
    public decimal? LienInstallmentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Unpaid Balance [FMNN17]
    /// </summary>
    public decimal? LienUpbAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Monthly Expense [FMNN21]
    /// </summary>
    public string? MaintenanceExpenseAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Market Value [FMNN19]
    /// </summary>
    public decimal? MarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property No Link to Doc Tracking [FMNN97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Number of Units [FMNN54]
    /// </summary>
    public int? NumberOfUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Owner [FMNN46]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Participation Percent [FMNN14]
    /// </summary>
    public decimal? ParticipationPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Date Acquired [FMNN59]
    /// </summary>
    public DateTime? PendingSaleDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Percent of Units Rented [FMNN26]
    /// </summary>
    public decimal? PercentageofRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Zipcode [FMNN08]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Print - See Attached Authorization [FMNN36]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print \\\"See attached borrower's authorization\\\" on signature line.\"}")]
    public bool? PrintAttachIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Print User Job Title [FMNN64]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's job title\"}")]
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Print User Name as Title [FMNN38]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Print user's name as title\"}")]
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Use of Property [FMNN41]
    /// </summary>
    public StringEnumValue<ReoPropertyUsageType> PropertyUsageType { get => GetValue<StringEnumValue<ReoPropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Purchase Price [FMNN23]
    /// </summary>
    public int? PurchasePrice { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Monthly Gross Rental Income [FMNN20]
    /// </summary>
    public decimal? RentalIncomeGrossAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Net Rental Income [FMNN32]
    /// </summary>
    public decimal? RentalIncomeNetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Comments [FMNN25]
    /// </summary>
    public string? ReoComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property REO ID [FMNN43]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ReoId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ReoProperty ReoPropertyIndex
    /// </summary>
    public int? ReoPropertyIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Request Date [FMNN98]
    /// </summary>
    public DateTime? RequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property State [FMNN07]
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Address [FMNN04]
    /// </summary>
    public string? StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Is the Subject Property [FMNN28]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Subject Property\"}")]
    public bool? SubjectIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property From Title [FMNN37]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property From Fax [FMNN45]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property From Phone [FMNN44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Unit Number [FMNN48]
    /// </summary>
    public string? UnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Unit Type [FMNN47]
    /// </summary>
    public StringEnumValue<UnitType> UnitType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property URLA 2020 Street Address [FMNN50]
    /// </summary>
    public string? URLA2020StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Year in Which Built [FMNN53]
    /// </summary>
    public string? YearBuilt { get => GetValue<string?>(); set => SetValue(value); }
}