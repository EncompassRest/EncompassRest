namespace EncompassRest.Loans.v3;

/// <summary>
/// TqlComplianceAlert
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TqlComplianceAlert : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TqlComplianceAlert Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Categories [TQLCOMPLIANCEALERT0001]
    /// </summary>
    public string? LastComplianceOrderAlertCategories { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Message [TQLCOMPLIANCEALERT0003]
    /// </summary>
    public string? LastComplianceOrderAlertMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Category Result [TQLCOMPLIANCEALERT0002]
    /// </summary>
    public string? LastComplianceOrderDescriptionOfAlerts { get => GetValue<string?>(); set => SetValue(value); }
}