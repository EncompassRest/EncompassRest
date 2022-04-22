namespace EncompassRest.Loans;

/// <summary>
/// FileAttachmentReference
/// </summary>
public sealed partial class FileAttachmentReference : EntityReference, IIdentifiable
{
    /// <summary>
    /// FileAttachmentReference IsActive
    /// </summary>
    public bool? IsActive { get => GetValue<bool?>(); set => SetValue(value); }
}