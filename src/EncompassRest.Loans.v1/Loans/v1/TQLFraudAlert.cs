namespace EncompassRest.Loans.v1;

/// <summary>
/// TQLFraudAlert
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class TQLFraudAlert : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// TQL - Fraud Orders -DRIVE  Fraud Alert Code #1-99 [TQLFRAUDALERTNN06]
    /// </summary>
    public string? DriveFraudAlertCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - DRIVE Fraud Alert Status #1-99 [TQLFRAUDALERTNN05]
    /// </summary>
    public string? DriveFraudAlertStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - FraudGuard Fraud Alert Code #1-99 [TQLFRAUDALERTNN08]
    /// </summary>
    public string? FraudGuardFraudAlertCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - FraudGuard Fraud Alert Status #1-99 [TQLFRAUDALERTNN07]
    /// </summary>
    public string? FraudGuardFraudAlertStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQLFraudAlert Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Fraud Categories [TQLFRAUDALERTNN01]
    /// </summary>
    public string? LastFraudOrderAlertCategories { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Fraud Alert ID [TQLFRAUDALERTNN04]
    /// </summary>
    public string? LastFraudOrderAlertID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Alert Level [TQLFRAUDALERTNN03]
    /// </summary>
    public string? LastFraudOrderAlertLevel { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQL - Fraud Orders - Last Alert Message [TQLFRAUDALERTNN02]
    /// </summary>
    public string? LastFraudOrderDescriptionOfAlerts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TQLFraudAlert TQLFraudAlertIndex
    /// </summary>
    public int? TQLFraudAlertIndex { get => GetValue<int?>(); set => SetValue(value); }
}