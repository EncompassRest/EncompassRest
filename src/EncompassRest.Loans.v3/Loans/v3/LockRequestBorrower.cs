using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LockRequestBorrower
/// </summary>
public sealed partial class LockRequestBorrower : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _equifaxScore;
    private DirtyValue<string?>? _experianScore;
    private DirtyValue<string?>? _firstName;
    private DirtyValue<string?>? _lastName;
    private DirtyValue<int?>? _lrbIndex;
    private DirtyValue<string?>? _ssn;
    private DirtyValue<string?>? _transUnionScore;

    /// <summary>
    /// LockRequestBorrowerContract EquifaxScore
    /// </summary>
    public string? EquifaxScore { get => _equifaxScore; set => SetField(ref _equifaxScore, value); }

    /// <summary>
    /// LockRequestBorrowerContract ExperianScore
    /// </summary>
    public string? ExperianScore { get => _experianScore; set => SetField(ref _experianScore, value); }

    /// <summary>
    /// LockRequestBorrowerContract FirstName
    /// </summary>
    public string? FirstName { get => _firstName; set => SetField(ref _firstName, value); }

    /// <summary>
    /// LockRequestBorrowerContract LastName
    /// </summary>
    public string? LastName { get => _lastName; set => SetField(ref _lastName, value); }

    /// <summary>
    /// LockRequestBorrowerContract LrbIndex
    /// </summary>
    public int? LrbIndex { get => _lrbIndex; set => SetField(ref _lrbIndex, value); }

    /// <summary>
    /// LockRequestBorrowerContract Ssn
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? Ssn { get => _ssn; set => SetField(ref _ssn, value); }

    /// <summary>
    /// LockRequestBorrowerContract TransUnionScore
    /// </summary>
    public string? TransUnionScore { get => _transUnionScore; set => SetField(ref _transUnionScore, value); }
}