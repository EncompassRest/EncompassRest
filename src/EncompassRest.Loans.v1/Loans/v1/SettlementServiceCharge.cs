namespace EncompassRest.Loans.v1;

/// <summary>
/// SettlementServiceCharge
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
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
    /// SettlementServiceCharge Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}