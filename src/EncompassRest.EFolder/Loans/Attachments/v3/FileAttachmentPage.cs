using System.Collections.Generic;

namespace EncompassRest.Loans.Attachments.v3;

/// <summary>
/// FileAttachmentPage
/// </summary>
public sealed class FileAttachmentPage : DirtyExtensibleObject
{
    /// <summary>
    /// Required. Gets or sets the unique identifier of the image file.
    /// </summary>
    public ImageEntityReference? PageImage { get => GetValue<ImageEntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets an image thumbnail for the page.
    /// </summary>
    public ImageEntityReference? ThumbnailImage { get => GetValue<ImageEntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Gets or sets Annotations for the page.
    /// </summary>
    public IList<FileAttachmentAnnotation> Annotations { get => GetList<FileAttachmentAnnotation>(); set => SetList(value); }

    /// <summary>
    /// Required. Gets or sets the size of the image file in bytes.
    /// </summary>
    public int? FileSize { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the rotation in degrees.
    /// </summary>
    public int? Rotation { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Retrieve only. Gets or sets the Original File.
    /// </summary>
    public string? OriginalKey { get => GetValue<string?>(); set => SetValue(value); }
}