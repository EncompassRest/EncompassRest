namespace EncompassRest.Loans.v1;

/// <summary>
/// StatusOnlineEvent
/// </summary>
public sealed partial class StatusOnlineEvent : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// StatusOnlineEvent DateText
    /// </summary>
    public string? DateText { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StatusOnlineEvent Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// StatusOnlineEvent Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}