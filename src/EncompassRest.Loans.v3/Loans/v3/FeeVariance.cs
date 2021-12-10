using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// FeeVariance
/// </summary>
public sealed partial class FeeVariance : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _cd;
    private DirtyValue<string?>? _description;
    private DirtyValue<int?>? _feeVarianceChargeIndex;
    private DirtyValue<StringEnumValue<FeeVarianceFeeType>>? _feeVarianceFeeType;
    private DirtyValue<decimal?>? _initialLe;
    private DirtyValue<decimal?>? _itemization;
    private DirtyValue<decimal?>? _le;
    private DirtyValue<string?>? _line;

    /// <summary>
    /// FeeVarianceContract Cd
    /// </summary>
    public decimal? Cd { get => _cd; set => SetField(ref _cd, value); }

    /// <summary>
    /// FeeVarianceContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// FeeVarianceContract FeeVarianceChargeIndex
    /// </summary>
    public int? FeeVarianceChargeIndex { get => _feeVarianceChargeIndex; set => SetField(ref _feeVarianceChargeIndex, value); }

    /// <summary>
    /// FeeVarianceContract FeeVarianceFeeType
    /// </summary>
    public StringEnumValue<FeeVarianceFeeType> FeeVarianceFeeType { get => _feeVarianceFeeType; set => SetField(ref _feeVarianceFeeType, value); }

    /// <summary>
    /// FeeVarianceContract InitialLe
    /// </summary>
    public decimal? InitialLe { get => _initialLe; set => SetField(ref _initialLe, value); }

    /// <summary>
    /// FeeVarianceContract Itemization
    /// </summary>
    public decimal? Itemization { get => _itemization; set => SetField(ref _itemization, value); }

    /// <summary>
    /// FeeVarianceContract Le
    /// </summary>
    public decimal? Le { get => _le; set => SetField(ref _le, value); }

    /// <summary>
    /// FeeVarianceContract Line
    /// </summary>
    public string? Line { get => _line; set => SetField(ref _line, value); }
}