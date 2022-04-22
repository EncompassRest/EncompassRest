namespace EncompassRest.Loans.v3;

/// <summary>
/// ApplicationReference
/// </summary>
public sealed partial class ApplicationReference : EntityReference, IIdentifiable
{
    /// <summary>
    /// ApplicationReference LegacyId
    /// </summary>
    public string? LegacyId { get => GetValue<string?>(); set => SetValue(value); }
}