namespace EncompassRest.Loans.v3;

/// <summary>
/// TqlFraudAlert
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TqlFraudAlert : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _driveFraudAlertCode;
    private DirtyValue<string?>? _driveFraudAlertStatus;
    private DirtyValue<string?>? _fraudGuardFraudAlertCode;
    private DirtyValue<string?>? _fraudGuardFraudAlertStatus;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _lastFraudOrderAlertCategories;
    private DirtyValue<string?>? _lastFraudOrderAlertId;
    private DirtyValue<string?>? _lastFraudOrderAlertLevel;
    private DirtyValue<string?>? _lastFraudOrderDescriptionOfAlerts;

    /// <summary>
    /// TQL - Fraud Orders -DRIVE  Fraud Alert Code #1-99 [TQLFRAUDALERT0006]
    /// </summary>
    public string? DriveFraudAlertCode { get => _driveFraudAlertCode; set => SetField(ref _driveFraudAlertCode, value); }

    /// <summary>
    /// TQL - Fraud Orders - DRIVE Fraud Alert Status #1-99 [TQLFRAUDALERT0005]
    /// </summary>
    public string? DriveFraudAlertStatus { get => _driveFraudAlertStatus; set => SetField(ref _driveFraudAlertStatus, value); }

    /// <summary>
    /// TQL - Fraud Orders - FraudGuard Fraud Alert Code #1-99 [TQLFRAUDALERT0008]
    /// </summary>
    public string? FraudGuardFraudAlertCode { get => _fraudGuardFraudAlertCode; set => SetField(ref _fraudGuardFraudAlertCode, value); }

    /// <summary>
    /// TQL - Fraud Orders - FraudGuard Fraud Alert Status #1-99 [TQLFRAUDALERT0007]
    /// </summary>
    public string? FraudGuardFraudAlertStatus { get => _fraudGuardFraudAlertStatus; set => SetField(ref _fraudGuardFraudAlertStatus, value); }

    /// <summary>
    /// TqlFraudAlertContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Categories [TQLFRAUDALERT0001]
    /// </summary>
    public string? LastFraudOrderAlertCategories { get => _lastFraudOrderAlertCategories; set => SetField(ref _lastFraudOrderAlertCategories, value); }

    /// <summary>
    /// TQL - Fraud Orders - Fraud Alert ID [TQLFRAUDALERT0004]
    /// </summary>
    public string? LastFraudOrderAlertId { get => _lastFraudOrderAlertId; set => SetField(ref _lastFraudOrderAlertId, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Alert Level [TQLFRAUDALERT0003]
    /// </summary>
    public string? LastFraudOrderAlertLevel { get => _lastFraudOrderAlertLevel; set => SetField(ref _lastFraudOrderAlertLevel, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Alert Message [TQLFRAUDALERT0002]
    /// </summary>
    public string? LastFraudOrderDescriptionOfAlerts { get => _lastFraudOrderDescriptionOfAlerts; set => SetField(ref _lastFraudOrderDescriptionOfAlerts, value); }
}