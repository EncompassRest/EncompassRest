using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ReoProperty
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class ReoProperty : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Mortgage Property Date Acquired [FM0022]
    /// </summary>
    public DateTime? AcquiredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ReoProperty AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property City [FM0006]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Country [FM0057]
    /// </summary>
    public string? Country { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Country Code [FM0051]
    /// </summary>
    public string? CountryCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Disposition Status [FM0024]
    /// </summary>
    public StringEnumValue<DispositionStatusType> DispositionStatusType { get => GetValue<StringEnumValue<DispositionStatusType>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Foreign Address Indicator [FM0058]
    /// </summary>
    public bool? ForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Future Use of Property [FM0055]
    /// </summary>
    public StringEnumValue<FuturePropertyUsageType> FuturePropertyUsageType { get => GetValue<StringEnumValue<FuturePropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Description If Future Use of Property Is Other [FM0056]
    /// </summary>
    public string? FutureUsageTypeOtherDesc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Type [FM0018]
    /// </summary>
    public StringEnumValue<GsePropertyType> GsePropertyType { get => GetValue<StringEnumValue<GsePropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property REO ID [FM0043]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Include In AUS/Export [FM0052]
    /// </summary>
    public bool? IncludeInAusExport { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Not linked to Liability [FM0049]
    /// </summary>
    public bool? LiabilityDoesNotApply { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Monthly Payment [FM0016]
    /// </summary>
    public decimal? LienInstallmentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Unpaid Balance [FM0017]
    /// </summary>
    public decimal? LienUpbAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Monthly Expense [FM0021]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? MaintenanceExpenseAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Market Value [FM0019]
    /// </summary>
    public decimal? MarketValueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property No Link to Doc Tracking [FM0097]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? NoLinkToDocTrackIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Number of Units [FM0054]
    /// </summary>
    public int? NumberOfUnits { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Owner [FM0046]
    /// </summary>
    public StringEnumValue<Owner> Owner { get => GetValue<StringEnumValue<Owner>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Participation Percent [FM0014]
    /// </summary>
    public decimal? ParticipationPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Date Acquired [FM0059]
    /// </summary>
    public DateTime? PendingSaleDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Percent of Units Rented [FM0026]
    /// </summary>
    public decimal? PercentageofRental { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Zipcode [FM0008]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Print - See Attached Authorization [FM0036]
    /// </summary>
    public bool? PrintAttachIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Print User Job Title [FM0064]
    /// </summary>
    public bool? PrintUserJobTitleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Print User Name as Title [FM0038]
    /// </summary>
    public bool? PrintUserNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Use of Property [FM0041]
    /// </summary>
    public StringEnumValue<ReoPropertyUsageType> PropertyUsageType { get => GetValue<StringEnumValue<ReoPropertyUsageType>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Purchase Price [FM0023]
    /// </summary>
    public int? PurchasePrice { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Monthly Gross Rental Income [FM0020]
    /// </summary>
    public decimal? RentalIncomeGrossAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Net Rental Income [FM0032]
    /// </summary>
    public decimal? RentalIncomeNetAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Comments [FM0025]
    /// </summary>
    public string? ReoComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Request Date [FM0098]
    /// </summary>
    public DateTime? RequestDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property State [FM0007]
    /// </summary>
    public string? State { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Address [FM0004]
    /// </summary>
    public string? StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Is the Subject Property [FM0028]
    /// </summary>
    public bool? SubjectIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property From Title [FM0037]
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property From Fax [FM0045]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitleFax { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property From Phone [FM0044]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? TitlePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Unit Number [FM0048]
    /// </summary>
    public string? UnitNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Unit Type [FM0047]
    /// </summary>
    public StringEnumValue<UnitType> UnitType { get => GetValue<StringEnumValue<UnitType>>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property URLA 2020 Street Address [FM0050]
    /// </summary>
    public string? Urla2020StreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Mortgage Property Year in Which Built [FM0053]
    /// </summary>
    public string? YearBuilt { get => GetValue<string?>(); set => SetValue(value); }
}