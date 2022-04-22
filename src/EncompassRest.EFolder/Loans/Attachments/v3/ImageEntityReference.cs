namespace EncompassRest.Loans.Attachments.v3;

/// <summary>
/// ImageEntityReference
/// </summary>
public sealed class ImageEntityReference : DirtyExtensibleObject
{
    /// <summary>
    /// Required. Gets or sets the Entity Height.
    /// </summary>
    public int? Height { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the Entity Width.
    /// </summary>
    public int? Width { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the Entity DpiX.
    /// </summary>
    public int? DpiX { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the Entity DpiY.
    /// </summary>
    public int? DpiY { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets ZipKey.
    /// </summary>
    public string? ZipKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets ImageKey.
    /// </summary>
    public string? ImageKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gets or sets OriginalKey.
    /// </summary>
    public string? OriginalKey { get => GetValue<string?>(); set => SetValue(value); }
}