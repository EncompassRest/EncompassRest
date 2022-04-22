namespace EncompassRest.Loans.v3;

/// <summary>
/// LockDenial
/// </summary>
public sealed partial class LockDenial : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LockDenial AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenial DeniedBy
    /// </summary>
    public string? DeniedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenial DeniedById
    /// </summary>
    public string? DeniedById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenial RequestGuid
    /// </summary>
    public string? RequestGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LockDenial TimeDenied
    /// </summary>
    public string? TimeDenied { get => GetValue<string?>(); set => SetValue(value); }
}