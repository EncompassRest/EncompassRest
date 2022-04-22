namespace EncompassRest.Loans.v1;

/// <summary>
/// TQLComplianceAlert
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TQLComplianceAlert : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TQLComplianceAlert Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Categories [TQLCOMPLIANCEALERTNN01]
    /// </summary>
    public string? LastComplianceOrderAlertCategories { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Message [TQLCOMPLIANCEALERTNN03]
    /// </summary>
    public string? LastComplianceOrderAlertMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Category Result [TQLCOMPLIANCEALERTNN02]
    /// </summary>
    public string? LastComplianceOrderDescriptionOfAlerts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQLComplianceAlert TQLComplianceAlertIndex
    /// </summary>
    public int? TQLComplianceAlertIndex { get => GetValue<int?>(); set => SetValue(value); }
}