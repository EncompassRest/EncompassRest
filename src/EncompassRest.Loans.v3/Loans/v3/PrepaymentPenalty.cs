using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PrepaymentPenalty
/// </summary>
public sealed partial class PrepaymentPenalty : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<FullPrepaymentPenaltyOptionType>>? _fullPrepaymentPenaltyOptionType;
    private DirtyValue<int?>? _prepaymentPenaltyIndex;
    private DirtyValue<decimal?>? _prepaymentPenaltyPercent;
    private DirtyValue<int?>? _termMonthsCount;

    /// <summary>
    /// PrepaymentPenaltyContract FullPrepaymentPenaltyOptionType
    /// </summary>
    public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => _fullPrepaymentPenaltyOptionType; set => SetField(ref _fullPrepaymentPenaltyOptionType, value); }

    /// <summary>
    /// PrepaymentPenaltyContract PrepaymentPenaltyIndex
    /// </summary>
    public int? PrepaymentPenaltyIndex { get => _prepaymentPenaltyIndex; set => SetField(ref _prepaymentPenaltyIndex, value); }

    /// <summary>
    /// PrepaymentPenaltyContract PrepaymentPenaltyPercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PrepaymentPenaltyPercent { get => _prepaymentPenaltyPercent; set => SetField(ref _prepaymentPenaltyPercent, value); }

    /// <summary>
    /// PrepaymentPenaltyContract TermMonthsCount
    /// </summary>
    public int? TermMonthsCount { get => _termMonthsCount; set => SetField(ref _termMonthsCount, value); }
}