using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Income
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(IncomeType) + "," + nameof(OtherIncomeIndex) + "," + nameof(Owner))]
public sealed partial class Income : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Income Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income CurrentIndicator
    /// </summary>
    public bool? CurrentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Income Description
    /// </summary>
    public StringEnumValue<Description> Description { get => GetValue<StringEnumValue<Description>>(); set => SetValue(value); }

    /// <summary>
    /// Income Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Income IncomeType
    /// </summary>
    public StringEnumValue<IncomeType> IncomeType { get => GetValue<StringEnumValue<IncomeType>>(); set => SetValue(value); }

    /// <summary>
    /// Income OtherIncomeIndex
    /// </summary>
    public int? OtherIncomeIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Income Owner
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }
}