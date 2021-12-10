using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// GfeFee
/// </summary>
public sealed partial class GfeFee : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _amountDescription;
    private DirtyValue<decimal?>? _brokerAmount;
    private DirtyValue<string?>? _description;
    private DirtyValue<int?>? _gfeFeeIndex;
    private DirtyValue<StringEnumValue<GfeFeeType>>? _gfeFeeType;
    private DirtyValue<decimal?>? _otherAmount;
    private DirtyValue<string?>? _rate;

    /// <summary>
    /// GfeFeeContract AmountDescription [1663], [1665]
    /// </summary>
    public string? AmountDescription { get => _amountDescription; set => SetField(ref _amountDescription, value); }

    /// <summary>
    /// GfeFeeContract BrokerAmount
    /// </summary>
    public decimal? BrokerAmount { get => _brokerAmount; set => SetField(ref _brokerAmount, value); }

    /// <summary>
    /// GfeFeeContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// GfeFeeContract GfeFeeIndex
    /// </summary>
    public int? GfeFeeIndex { get => _gfeFeeIndex; set => SetField(ref _gfeFeeIndex, value); }

    /// <summary>
    /// GfeFeeContract GfeFeeType
    /// </summary>
    public StringEnumValue<GfeFeeType> GfeFeeType { get => _gfeFeeType; set => SetField(ref _gfeFeeType, value); }

    /// <summary>
    /// GfeFeeContract OtherAmount
    /// </summary>
    public decimal? OtherAmount { get => _otherAmount; set => SetField(ref _otherAmount, value); }

    /// <summary>
    /// GfeFeeContract Rate [1847], [1848]
    /// </summary>
    public string? Rate { get => _rate; set => SetField(ref _rate, value); }
}