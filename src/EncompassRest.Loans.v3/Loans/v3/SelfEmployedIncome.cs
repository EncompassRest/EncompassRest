using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// SelfEmployedIncome
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(FormType))]
public sealed partial class SelfEmployedIncome : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// SelfEmployedIncome BoolFieldValue
    /// </summary>
    public bool? BoolFieldValue { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// 1084A/1040 Business Information - Business Name [FM1084.X177]
    /// </summary>
    public string? BusinessName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// 1084A/1040 Other Descr [FM1084.X18]
    /// </summary>
    public StringEnumValue<FieldName> FieldName { get => GetValue<StringEnumValue<FieldName>>(); set => SetValue(value); }

    /// <summary>
    /// SelfEmployedIncome FieldValue
    /// </summary>
    public string? FieldValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SelfEmployedIncome FirstYearAmount
    /// </summary>
    public decimal? FirstYearAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// SelfEmployedIncome FormType
    /// </summary>
    public StringEnumValue<FormType> FormType { get => GetValue<StringEnumValue<FormType>>(); set => SetValue(value); }

    /// <summary>
    /// SelfEmployedIncome SecondYearAmount
    /// </summary>
    public decimal? SecondYearAmount { get => GetValue<decimal?>(); set => SetValue(value); }
}