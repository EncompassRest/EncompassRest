namespace EncompassRest.Loans.v3;

/// <summary>
/// LockDenial
/// </summary>
public sealed partial class LockDenial : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<bool?>? _alertIndicator;
    private DirtyValue<string?>? _deniedBy;
    private DirtyValue<string?>? _deniedById;
    private DirtyValue<string?>? _requestGuid;
    private DirtyValue<string?>? _timeDenied;

    /// <summary>
    /// LockDenialContract AlertIndicator
    /// </summary>
    public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }

    /// <summary>
    /// LockDenialContract DeniedBy
    /// </summary>
    public string? DeniedBy { get => _deniedBy; set => SetField(ref _deniedBy, value); }

    /// <summary>
    /// LockDenialContract DeniedById
    /// </summary>
    public string? DeniedById { get => _deniedById; set => SetField(ref _deniedById, value); }

    /// <summary>
    /// LockDenialContract RequestGuid
    /// </summary>
    public string? RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }

    /// <summary>
    /// LockDenialContract TimeDenied
    /// </summary>
    public string? TimeDenied { get => _timeDenied; set => SetField(ref _timeDenied, value); }
}