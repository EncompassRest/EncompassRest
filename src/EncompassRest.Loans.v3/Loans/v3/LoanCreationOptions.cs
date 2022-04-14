﻿using EncompassRest.Utilities;

namespace EncompassRest.Loans.v3;

/// <summary>
/// The loan creation options.
/// </summary>
public sealed class LoanCreationOptions : LoanUpdateOptionsBase
{
    /// <summary>
    /// Name of the loan folder.
    /// </summary>
    public string LoanFolder { get; set; }

    /// <summary>
    /// The unique identifier of the User you want to assign as Loan Officer to the loan at the time of loan creation.
    /// </summary>
    public string? LoId { get; set; }

    /// <summary>
    /// CreateLoanOptions constructor.
    /// </summary>
    /// <param name="loanFolder">Name of the loan folder.</param>
    public LoanCreationOptions(string loanFolder)
    {
        Preconditions.NotNullOrEmpty(loanFolder, nameof(loanFolder));

        LoanFolder = loanFolder;
    }

    internal override QueryParameters ToQueryParameters()
    {
        var queryParameters = base.ToQueryParameters();
        if (!string.IsNullOrEmpty(LoanFolder))
        {
            queryParameters.Add("loanFolder", LoanFolder);
        }
        if (!string.IsNullOrEmpty(LoId))
        {
            queryParameters.Add("loId", LoId);
        }
        return queryParameters;
    }
}