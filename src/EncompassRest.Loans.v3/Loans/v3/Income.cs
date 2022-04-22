using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Income
/// </summary>
public sealed partial class Income : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Income Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Income Description
    /// </summary>
    public StringEnumValue<Description> Description { get => GetValue<StringEnumValue<Description>>(); set => SetValue(value); }

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