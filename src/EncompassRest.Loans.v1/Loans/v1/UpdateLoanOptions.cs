using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1;

/// <summary>
/// The loan update options.
/// </summary>
public sealed class UpdateLoanOptions : LoanOptions
{
    /// <summary>
    /// When applying a loan template, set to <c>true</c> to only write the non-blank field values in the template to the loan. Set to <c>false</c> to write all field values in the template (including blank fields) to the loan.
    /// </summary>
    public bool AppendData { get; set; } = false;

    internal override QueryParameters ToQueryParameters()
    {
        var queryParameters = base.ToQueryParameters();
        if (!string.IsNullOrEmpty(LoanTemplate))
        {
            queryParameters.Add("appendData", AppendData.ToString().ToLower());
        }
        return queryParameters;
    }
}