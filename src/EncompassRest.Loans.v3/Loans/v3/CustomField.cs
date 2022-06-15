using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CustomField
/// </summary>
public sealed partial class CustomField : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CustomField FieldName
    /// </summary>
    public string? FieldName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CustomField Format
    /// </summary>
    public StringEnumValue<LoanFieldFormat> Format { get => GetValue<StringEnumValue<LoanFieldFormat>>(); set => SetValue(value); }

    /// <summary>
    /// Custom Field Value [CUST00FV]
    /// </summary>
    public object? Value { get => GetValue<object?>(); set => SetValue(value); }
}