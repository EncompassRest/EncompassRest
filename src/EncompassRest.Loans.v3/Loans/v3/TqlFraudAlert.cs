namespace EncompassRest.Loans.v3;

/// <summary>
/// TqlFraudAlert
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TqlFraudAlert : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TQL - Fraud Orders -DRIVE  Fraud Alert Code #1-99 [TQLFRAUDALERT0006]
    /// </summary>
    public string? DriveFraudAlertCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - DRIVE Fraud Alert Status #1-99 [TQLFRAUDALERT0005]
    /// </summary>
    public string? DriveFraudAlertStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - FraudGuard Fraud Alert Code #1-99 [TQLFRAUDALERT0008]
    /// </summary>
    public string? FraudGuardFraudAlertCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - FraudGuard Fraud Alert Status #1-99 [TQLFRAUDALERT0007]
    /// </summary>
    public string? FraudGuardFraudAlertStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TqlFraudAlert Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Categories [TQLFRAUDALERT0001]
    /// </summary>
    public string? LastFraudOrderAlertCategories { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Fraud Alert ID [TQLFRAUDALERT0004]
    /// </summary>
    public string? LastFraudOrderAlertId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Alert Level [TQLFRAUDALERT0003]
    /// </summary>
    public string? LastFraudOrderAlertLevel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Alert Message [TQLFRAUDALERT0002]
    /// </summary>
    public string? LastFraudOrderDescriptionOfAlerts { get => GetValue<string?>(); set => SetValue(value); }
}