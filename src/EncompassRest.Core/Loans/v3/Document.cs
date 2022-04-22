using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Document
/// </summary>
public sealed partial class Document : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Document AccessibleTo
    /// </summary>
    [AllowNull]
    public IList<string?> AccessibleTo { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// Document Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetEntity<ApplicationReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document Attachments
    /// </summary>
    [AllowNull]
    public IList<FileAttachmentReference> Attachments { get => GetList<FileAttachmentReference>(); set => SetList(value); }

    /// <summary>
    /// Document Conditions
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Conditions { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// Document CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document DaysDue
    /// </summary>
    public int? DaysDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Document DaysTillExpire
    /// </summary>
    public int? DaysTillExpire { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Document Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document DocumentGroups
    /// </summary>
    [AllowNull]
    public IList<string?> DocumentGroups { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// Document DocumentTypes
    /// </summary>
    [AllowNull]
    public IList<string?> DocumentTypes { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// Document EmnSignature
    /// </summary>
    public string? EmnSignature { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document ExpirationDate
    /// </summary>
    public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Document IsProtected
    /// </summary>
    public bool? IsProtected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Document Milestone
    /// </summary>
    [AllowNull]
    public EntityReference Milestone { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document PackageId
    /// </summary>
    public string? PackageId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document ReadyForUwBy
    /// </summary>
    [AllowNull]
    public EntityReference ReadyForUwBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document ReadyForUwDate
    /// </summary>
    public DateTime? ReadyForUwDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document ReadyToShipBy
    /// </summary>
    [AllowNull]
    public EntityReference ReadyToShipBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document ReadyToShipDate
    /// </summary>
    public DateTime? ReadyToShipDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document ReviewedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReviewedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// Document ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document Roles
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Roles { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// Document Status
    /// </summary>
    public StringEnumValue<DocumentStatus> Status { get => GetValue<StringEnumValue<DocumentStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Document StatusDate
    /// </summary>
    public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Document Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Document Verification
    /// </summary>
    [AllowNull]
    public EntityReference Verification { get => GetEntity<EntityReference>(); set => SetEntity(value); }
}