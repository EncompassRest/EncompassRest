using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// MilitaryService
/// </summary>
public sealed partial class MilitaryService : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _branch;
    private DirtyValue<DateTime?>? _endDate;
    private DirtyValue<int?>? _militaryServiceIndex;
    private DirtyValue<string?>? _name;
    private DirtyValue<StringEnumValue<OfficerOrEnlisted>>? _officerOrEnlisted;
    private DirtyValue<string?>? _serviceNumber;
    private DirtyValue<string?>? _ssn;
    private DirtyValue<DateTime?>? _startDate;

    /// <summary>
    /// MilitaryServiceContract Branch
    /// </summary>
    public string? Branch { get => _branch; set => SetField(ref _branch, value); }

    /// <summary>
    /// MilitaryServiceContract EndDate
    /// </summary>
    public DateTime? EndDate { get => _endDate; set => SetField(ref _endDate, value); }

    /// <summary>
    /// MilitaryServiceContract MilitaryServiceIndex
    /// </summary>
    public int? MilitaryServiceIndex { get => _militaryServiceIndex; set => SetField(ref _militaryServiceIndex, value); }

    /// <summary>
    /// MilitaryServiceContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// MilitaryServiceContract OfficerOrEnlisted
    /// </summary>
    public StringEnumValue<OfficerOrEnlisted> OfficerOrEnlisted { get => _officerOrEnlisted; set => SetField(ref _officerOrEnlisted, value); }

    /// <summary>
    /// MilitaryServiceContract ServiceNumber
    /// </summary>
    public string? ServiceNumber { get => _serviceNumber; set => SetField(ref _serviceNumber, value); }

    /// <summary>
    /// MilitaryServiceContract Ssn
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
    public string? Ssn { get => _ssn; set => SetField(ref _ssn, value); }

    /// <summary>
    /// MilitaryServiceContract StartDate
    /// </summary>
    public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }
}