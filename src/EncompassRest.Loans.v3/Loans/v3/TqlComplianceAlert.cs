namespace EncompassRest.Loans.v3;

/// <summary>
/// TqlComplianceAlert
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TqlComplianceAlert : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _lastComplianceOrderAlertCategories;
    private DirtyValue<string?>? _lastComplianceOrderAlertMessage;
    private DirtyValue<string?>? _lastComplianceOrderDescriptionOfAlerts;

    /// <summary>
    /// TqlComplianceAlertContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Categories [TQLCOMPLIANCEALERT0001]
    /// </summary>
    public string? LastComplianceOrderAlertCategories { get => _lastComplianceOrderAlertCategories; set => SetField(ref _lastComplianceOrderAlertCategories, value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Message [TQLCOMPLIANCEALERT0003]
    /// </summary>
    public string? LastComplianceOrderAlertMessage { get => _lastComplianceOrderAlertMessage; set => SetField(ref _lastComplianceOrderAlertMessage, value); }

    /// <summary>
    /// TQL - Compliance Orders - Last Alert Category Result [TQLCOMPLIANCEALERT0002]
    /// </summary>
    public string? LastComplianceOrderDescriptionOfAlerts { get => _lastComplianceOrderDescriptionOfAlerts; set => SetField(ref _lastComplianceOrderDescriptionOfAlerts, value); }
}