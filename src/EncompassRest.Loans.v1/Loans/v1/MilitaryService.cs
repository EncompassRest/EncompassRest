using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// MilitaryService
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(MilitaryServiceIndex))]
public sealed partial class MilitaryService : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilitaryService Branch
    /// </summary>
    public string? Branch { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilitaryService EndDate
    /// </summary>
    public DateTime? EndDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilitaryService Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilitaryService MilitaryServiceIndex
    /// </summary>
    public int? MilitaryServiceIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilitaryService Name
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilitaryService OfficerOrEnlisted
    /// </summary>
    public StringEnumValue<OfficerOrEnlisted> OfficerOrEnlisted { get => GetValue<StringEnumValue<OfficerOrEnlisted>>(); set => SetValue(value); }

    /// <summary>
    /// MilitaryService ServiceNumber
    /// </summary>
    public string? ServiceNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilitaryService SSN
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN, ReadOnly = true)]
    public string? SSN { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilitaryService StartDate
    /// </summary>
    public DateTime? StartDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}