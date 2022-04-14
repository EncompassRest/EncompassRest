using EncompassRest.Utilities;

namespace EncompassRest.Loans.v3;

/// <summary>
/// The loan options used in both creation and updates.
/// </summary>
public abstract class LoanUpdateOptionsBase : LoanOptions
{
    /// <summary>
    /// Action to be performed on the loan while updating the loan.
    /// </summary>
    public StringEnumValue<LoanUpdateAction> Action { get; set; }

    /// <summary>
    /// Path to the loan template that will be applied to the loan.
    /// </summary>
    public StringEnumValue<TemplateType> TemplateType { get; set; }

    /// <summary>
    /// Path to the loan template that will be applied to the loan.
    /// </summary>
    public string? TemplatePath { get; set; }

    internal LoanUpdateOptionsBase()
    {
    }

    internal override QueryParameters ToQueryParameters()
    {
        var queryParameters = base.ToQueryParameters();
        if (!string.IsNullOrEmpty(Action))
        {
            queryParameters.Add("action", Action);
        }
        if (!string.IsNullOrEmpty(TemplatePath))
        {
            queryParameters.Add("templatePath", TemplatePath);
        }
        if (!string.IsNullOrEmpty(TemplateType))
        {
            queryParameters.Add("templateType", TemplateType);
        }
        return queryParameters;
    }
}