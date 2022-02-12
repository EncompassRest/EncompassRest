namespace EncompassRest.Loans.v1;

/// <summary>
/// TQLFraudAlert
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TQLFraudAlert : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _driveFraudAlertCode;
    private DirtyValue<string?>? _driveFraudAlertStatus;
    private DirtyValue<string?>? _fraudGuardFraudAlertCode;
    private DirtyValue<string?>? _fraudGuardFraudAlertStatus;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _lastFraudOrderAlertCategories;
    private DirtyValue<string?>? _lastFraudOrderAlertID;
    private DirtyValue<string?>? _lastFraudOrderAlertLevel;
    private DirtyValue<string?>? _lastFraudOrderDescriptionOfAlerts;
    private DirtyValue<int?>? _tQLFraudAlertIndex;

    /// <summary>
    /// TQL - Fraud Orders -DRIVE  Fraud Alert Code #1-99 [TQLFRAUDALERTNN06]
    /// </summary>
    public string? DriveFraudAlertCode { get => _driveFraudAlertCode; set => SetField(ref _driveFraudAlertCode, value); }

    /// <summary>
    /// TQL - Fraud Orders - DRIVE Fraud Alert Status #1-99 [TQLFRAUDALERTNN05]
    /// </summary>
    public string? DriveFraudAlertStatus { get => _driveFraudAlertStatus; set => SetField(ref _driveFraudAlertStatus, value); }

    /// <summary>
    /// TQL - Fraud Orders - FraudGuard Fraud Alert Code #1-99 [TQLFRAUDALERTNN08]
    /// </summary>
    public string? FraudGuardFraudAlertCode { get => _fraudGuardFraudAlertCode; set => SetField(ref _fraudGuardFraudAlertCode, value); }

    /// <summary>
    /// TQL - Fraud Orders - FraudGuard Fraud Alert Status #1-99 [TQLFRAUDALERTNN07]
    /// </summary>
    public string? FraudGuardFraudAlertStatus { get => _fraudGuardFraudAlertStatus; set => SetField(ref _fraudGuardFraudAlertStatus, value); }

    /// <summary>
    /// TQLFraudAlert Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Categories [TQLFRAUDALERTNN01]
    /// </summary>
    public string? LastFraudOrderAlertCategories { get => _lastFraudOrderAlertCategories; set => SetField(ref _lastFraudOrderAlertCategories, value); }

    /// <summary>
    /// TQL - Fraud Orders - Fraud Alert ID [TQLFRAUDALERTNN04]
    /// </summary>
    public string? LastFraudOrderAlertID { get => _lastFraudOrderAlertID; set => SetField(ref _lastFraudOrderAlertID, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Alert Level [TQLFRAUDALERTNN03]
    /// </summary>
    public string? LastFraudOrderAlertLevel { get => _lastFraudOrderAlertLevel; set => SetField(ref _lastFraudOrderAlertLevel, value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Alert Message [TQLFRAUDALERTNN02]
    /// </summary>
    public string? LastFraudOrderDescriptionOfAlerts { get => _lastFraudOrderDescriptionOfAlerts; set => SetField(ref _lastFraudOrderDescriptionOfAlerts, value); }

    /// <summary>
    /// TQLFraudAlert TQLFraudAlertIndex
    /// </summary>
    public int? TQLFraudAlertIndex { get => _tQLFraudAlertIndex; set => SetField(ref _tQLFraudAlertIndex, value); }
}