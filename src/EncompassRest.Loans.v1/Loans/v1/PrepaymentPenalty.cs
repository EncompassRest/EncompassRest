using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PrepaymentPenalty
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class PrepaymentPenalty : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PrepaymentPenalty FullPrepaymentPenaltyOptionType
    /// </summary>
    public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => GetValue<StringEnumValue<FullPrepaymentPenaltyOptionType>>(); set => SetValue(value); }

    /// <summary>
    /// PrepaymentPenalty Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

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