using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// CustomField
/// </summary>
public sealed partial class CustomField : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _fieldName;
    private DirtyValue<StringEnumValue<LoanFieldFormat>>? _format;

    /// <summary>
    /// CustomFieldContract FieldName
    /// </summary>
    public string? FieldName { get => _fieldName; set => SetField(ref _fieldName, value); }

    /// <summary>
    /// CustomFieldContract Format
    /// </summary>
    public StringEnumValue<LoanFieldFormat> Format { get => _format; set => SetField(ref _format, value); }
}