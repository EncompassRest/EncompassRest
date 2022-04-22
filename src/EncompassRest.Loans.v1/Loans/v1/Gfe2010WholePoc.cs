using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Gfe2010WholePoc
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(Gfe2010WholePocIndex) + "," + nameof(LineNumber))]
public sealed partial class Gfe2010WholePoc : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Gfe2010WholePoc Gfe2010WholePocIndex
    /// </summary>
    public int? Gfe2010WholePocIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010WholePoc Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010WholePoc LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010WholePoc WholePoc
    /// </summary>
    public decimal? WholePoc { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010WholePoc WholePocPaidByType
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Other\":\"O\"}")]
    public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => GetValue<StringEnumValue<WholePocPaidByType>>(); set => SetValue(value); }
}