using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PrepaymentPenalty
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(PrepaymentPenaltyIndex))]
public sealed partial class PrepaymentPenalty : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PrepaymentPenalty FullPrepaymentPenaltyOptionType
    /// </summary>
    public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => GetValue<StringEnumValue<FullPrepaymentPenaltyOptionType>>(); set => SetValue(value); }

    /// <summary>
    /// PrepaymentPenalty PrepaymentPenaltyIndex
    /// </summary>
    public int? PrepaymentPenaltyIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PrepaymentPenalty PrepaymentPenaltyPercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PrepaymentPenaltyPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PrepaymentPenalty TermMonthsCount
    /// </summary>
    public int? TermMonthsCount { get => GetValue<int?>(); set => SetValue(value); }
}