using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockRequestBorrower
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(LrbIndex))]
public sealed partial class LockRequestBorrower : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockRequestBorrower EquifaxScore
    /// </summary>
    public string? EquifaxScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestBorrower ExperianScore
    /// </summary>
    public string? ExperianScore { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestBorrower FirstName
    /// </summary>
    public string? FirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestBorrower LastName
    /// </summary>
    public string? LastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestBorrower LrbIndex
    /// </summary>
    public int? LrbIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestBorrower Ssn
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? Ssn { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockRequestBorrower TransUnionScore
    /// </summary>
    public string? TransUnionScore { get => GetValue<string?>(); set => SetValue(value); }
}