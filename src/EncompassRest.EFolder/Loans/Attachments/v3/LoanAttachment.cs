using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.Attachments.v3;

/// <summary>
/// LoanAttachment
/// </summary>
public sealed class LoanAttachment : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Gets or sets the unqiue identifier for this attachment.
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gets or sets the display title for this attachment.
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gets or sets the type of attachment.
    /// </summary>
    public StringEnumValue<AttachmentType> Type { get => GetValue<StringEnumValue<AttachmentType>>(); set => SetValue(value); }

    /// <summary>
    /// Retrieve only. Returns the source list of original file attachment IDs.
    /// </summary>
    public IList<string?> Sources { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// Retrieve only. Gets or sets IsActive if file is assigned to document.
    /// <c>true</c> indicates it is the active attachment on the document. (Current Version is checked on the Document Details window in Encompass.)
    /// <c>false</c> indicates it is not the active attachment on the document. (Current Version is unchecked on the Document Details window in Encompass.)
    /// </summary>
    public bool? IsActive { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Retrieve only. Gets or sets the parent reference (i.e document).
    /// </summary>
    public EntityReference AssignedTo { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Gets or sets the file size in bytes.
    /// </summary>
    public int? FileSize { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gets or sets the rotation offset of this attachment in degrees.
    /// </summary>
    public int? Rotation { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Retrieve only. Gets or sets IsRemoved.
    /// </summary>
    public bool? IsRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Retrieve only. Gets or sets the list of pages associated with an image attachment.
    /// </summary>
    public IList<FileAttachmentPage> Pages { get => GetList<FileAttachmentPage>(); set => SetList(value); }

    /// <summary>
    /// Retrieve only. Gets or sets the Entity Reference of the user who created this attachment.
    /// </summary>
    public EntityReference CreatedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Retrieve only. Gets or sets the date/time in UTC this attachment was created.
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanAttachment ObjectId
    /// </summary>
    public string? ObjectId { get => GetValue<string?>(); set => SetValue(value); }
}