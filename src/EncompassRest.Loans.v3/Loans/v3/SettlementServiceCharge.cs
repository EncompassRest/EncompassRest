namespace EncompassRest.Loans.v3;

/// <summary>
/// SettlementServiceCharge
/// </summary>
public sealed partial class SettlementServiceCharge : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _amount;
    private DirtyValue<string?>? _description;
    private DirtyValue<int?>? _settlementServiceChargeIndex;

    /// <summary>
    /// SettlementServiceChargeContract Amount
    /// </summary>
    public string? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// SettlementServiceChargeContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// SettlementServiceChargeContract SettlementServiceChargeIndex
    /// </summary>
    public int? SettlementServiceChargeIndex { get => _settlementServiceChargeIndex; set => SetField(ref _settlementServiceChargeIndex, value); }
}