namespace EncompassRest.Loans.v3;

/// <summary>
/// SettlementServiceCharge
/// </summary>
public sealed partial class SettlementServiceCharge : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// SettlementServiceCharge Amount
    /// </summary>
    public string? Amount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementServiceCharge Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// SettlementServiceCharge SettlementServiceChargeIndex
    /// </summary>
    public int? SettlementServiceChargeIndex { get => GetValue<int?>(); set => SetValue(value); }
}