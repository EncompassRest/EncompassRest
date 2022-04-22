using System;

namespace EncompassRest.Loans.Attachments.v3;

/// <summary>
/// FileAttachmentAnnotation
/// </summary>
public sealed class FileAttachmentAnnotation : DirtyExtensibleObject
{
    /// <summary>
    /// Required. Gets or sets the text body of the annotation.
    /// </summary>
    public string? Text { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Retrieve only. Gets or sets the user that created the annotation.
    /// </summary>
    public EntityReference? CreatedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// Retrieve only. Gets or sets the date the annotation was created.
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the Visibility type of the annotation.
    /// </summary>
    public StringEnumValue<AnnotationVisibilityType> Visibility { get => GetValue<StringEnumValue<AnnotationVisibilityType>>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the Left of the annotation.
    /// </summary>
    public int? Left { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the Top of the annotation.
    /// </summary>
    public int? Top { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the Width of the annotation.
    /// </summary>
    public int? Width { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Required. Gets or sets the Height of this annotation.
    /// </summary>
    public int? Height { get => GetValue<int?>(); set => SetValue(value); }
}