using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// SelfEmployedIncome
/// </summary>
public sealed partial class SelfEmployedIncome : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _boolFieldValue;
    private DirtyValue<string?>? _businessName;
    private DirtyValue<StringEnumValue<FieldName>>? _fieldName;
    private DirtyValue<string?>? _fieldValue;
    private DirtyValue<decimal?>? _firstYearAmount;
    private DirtyValue<StringEnumValue<FormType>>? _formType;
    private DirtyValue<decimal?>? _secondYearAmount;

    /// <summary>
    /// SelfEmployedIncomeContract BoolFieldValue
    /// </summary>
    public bool? BoolFieldValue { get => _boolFieldValue; set => SetField(ref _boolFieldValue, value); }

    /// <summary>
    /// 1084A/1040 Business Information - Business Name [FM1084.X177]
    /// </summary>
    public string? BusinessName { get => _businessName; set => SetField(ref _businessName, value); }

    /// <summary>
    /// 1084A/1040 Other Descr [FM1084.X18]
    /// </summary>
    public StringEnumValue<FieldName> FieldName { get => _fieldName; set => SetField(ref _fieldName, value); }

    /// <summary>
    /// SelfEmployedIncomeContract FieldValue
    /// </summary>
    public string? FieldValue { get => _fieldValue; set => SetField(ref _fieldValue, value); }

    /// <summary>
    /// SelfEmployedIncomeContract FirstYearAmount
    /// </summary>
    public decimal? FirstYearAmount { get => _firstYearAmount; set => SetField(ref _firstYearAmount, value); }

    /// <summary>
    /// SelfEmployedIncomeContract FormType
    /// </summary>
    public StringEnumValue<FormType> FormType { get => _formType; set => SetField(ref _formType, value); }

    /// <summary>
    /// SelfEmployedIncomeContract SecondYearAmount
    /// </summary>
    public decimal? SecondYearAmount { get => _secondYearAmount; set => SetField(ref _secondYearAmount, value); }
}