using EncompassRest.Utilities;

namespace EncompassRest.Loans.v3;

/// <summary>
/// The loan update options.
/// </summary>
public sealed class LoanUpdateOptions : LoanUpdateOptionsBase
{
    /// <summary>
    /// Lock ID used to lock loan.
    /// </summary>
    public string? LockId { get; set; }

    internal override QueryParameters ToQueryParameters()
    {
        var queryParameters = base.ToQueryParameters();
        if (!string.IsNullOrEmpty(LockId))
        {
            queryParameters.Add("lockId", LockId);
        }
        return queryParameters;
    }
}