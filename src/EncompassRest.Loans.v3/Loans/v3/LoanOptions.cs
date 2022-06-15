using System.Collections.Generic;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.v3;

/// <summary>
/// The loan options for loan retrieval.
/// </summary>
public abstract class LoanOptions : Options
{
    /// <summary>
    /// List of loan entities to retrieve from the loan.
    /// </summary>
    public List<StringEnumValue<LoanEntity>>? Entities { get; set; }

    /// <summary>
    /// Indicate whether or not to ignore blank template values for the loan program template.
    /// </summary>
    public bool? IgnoreEmptyLoanProgramValues { get; set; }

    /// <summary>
    /// Indicator whether or not to ignore empty fields on the Closing Cost Template when being applied from Loan program template.
    /// </summary>
    public bool? IgnoreEmptyLoanProgramClosingCostValues { get; set; }

    /// <summary>
    /// Indicator for ignoring empty closing cost data when applying a Closing Cost template.
    /// </summary>
    public bool? IgnoreEmptyClosingCostValues { get; set; }

    /// <summary>
    /// Indicator for ignoring empty closing cost data when applying a Funding template.
    /// </summary>
    public bool? IgnoreEmptyFundingTemplateValues { get; set; }

    /// <summary>
    /// Include fields and objects that are empty.
    /// </summary>
    public bool? IncludeEmpty { get; set; }

    /// <summary>
    /// Include records removed from entities.
    /// </summary>
    public bool? IncludeRemoved { get; set; }

    /// <summary>
    /// View of resulting loan.
    /// </summary>
    public StringEnumValue<LoanView> View { get; set; }

    internal LoanOptions()
    {
    }

    internal override QueryParameters ToQueryParameters()
    {
        var queryParameters = base.ToQueryParameters();
        if (Entities?.Count > 0)
        {
            queryParameters.Add("entities", string.Join(",", Entities));
        }
        if (IgnoreEmptyLoanProgramValues.HasValue)
        {
            queryParameters.Add("ignoreEmptyLoanProgramValues", IgnoreEmptyLoanProgramValues.ToString().ToLower());
        }
        if (IgnoreEmptyLoanProgramClosingCostValues.HasValue)
        {
            queryParameters.Add("ignoreEmptyLoanProgramClosingCostValues", IgnoreEmptyLoanProgramClosingCostValues.ToString().ToLower());
        }
        if (IgnoreEmptyClosingCostValues.HasValue)
        {
            queryParameters.Add("ignoreEmptyClosingCostValues", IgnoreEmptyClosingCostValues.ToString().ToLower());
        }
        if (IgnoreEmptyFundingTemplateValues.HasValue)
        {
            queryParameters.Add("ignoreEmptyFundingTemplateValues", IgnoreEmptyFundingTemplateValues.ToString().ToLower());
        }
        if (IncludeEmpty.HasValue)
        {
            queryParameters.Add("includeEmpty", IncludeEmpty.ToString().ToLower());
        }
        if (IncludeRemoved.HasValue)
        {
            queryParameters.Add("includeRemoved", IncludeRemoved.ToString().ToLower());
        }
        if (!string.IsNullOrEmpty(View))
        {
            queryParameters.Add("view", View);
        }
        return queryParameters;
    }
}