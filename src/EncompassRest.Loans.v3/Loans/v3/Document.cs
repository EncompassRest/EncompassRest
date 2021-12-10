using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Document
/// </summary>
public sealed partial class Document : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<string?>? _accessibleTo;
    private ApplicationReference? _application;
    private DirtyList<FileAttachmentReference>? _attachments;
    private DirtyList<EntityReference>? _conditions;
    private EntityReference? _createdBy;
    private DirtyValue<DateTime?>? _createdDate;
    private DirtyValue<int?>? _daysDue;
    private DirtyValue<int?>? _daysTillExpire;
    private DirtyValue<string?>? _description;
    private DirtyList<string?>? _documentGroups;
    private DirtyList<string?>? _documentTypes;
    private DirtyValue<string?>? _emnSignature;
    private DirtyValue<DateTime?>? _expectedDate;
    private DirtyValue<DateTime?>? _expirationDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isMarkedRemoved;
    private DirtyValue<bool?>? _isProtected;
    private EntityReference? _milestone;
    private DirtyValue<string?>? _packageId;
    private EntityReference? _readyForUwBy;
    private DirtyValue<DateTime?>? _readyForUwDate;
    private EntityReference? _readyToShipBy;
    private DirtyValue<DateTime?>? _readyToShipDate;
    private EntityReference? _receivedBy;
    private DirtyValue<DateTime?>? _receivedDate;
    private EntityReference? _requestedBy;
    private DirtyValue<DateTime?>? _requestedDate;
    private DirtyValue<string?>? _requestedFrom;
    private EntityReference? _rerequestedBy;
    private DirtyValue<DateTime?>? _rerequestedDate;
    private EntityReference? _reviewedBy;
    private DirtyValue<DateTime?>? _reviewedDate;
    private DirtyList<EntityReference>? _roles;
    private DirtyValue<string?>? _status;
    private DirtyValue<DateTime?>? _statusDate;
    private DirtyValue<string?>? _title;
    private EntityReference? _verification;

    /// <summary>
    /// DocumentContract AccessibleTo
    /// </summary>
    [AllowNull]
    public IList<string?> AccessibleTo { get => GetField(ref _accessibleTo); set => SetField(ref _accessibleTo, value); }

    /// <summary>
    /// DocumentContract Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetField(ref _application); set => SetField(ref _application, value); }

    /// <summary>
    /// DocumentContract Attachments
    /// </summary>
    [AllowNull]
    public IList<FileAttachmentReference> Attachments { get => GetField(ref _attachments); set => SetField(ref _attachments, value); }

    /// <summary>
    /// DocumentContract Conditions
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Conditions { get => GetField(ref _conditions); set => SetField(ref _conditions, value); }

    /// <summary>
    /// DocumentContract CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetField(ref _createdBy); set => SetField(ref _createdBy, value); }

    /// <summary>
    /// DocumentContract CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => _createdDate; set => SetField(ref _createdDate, value); }

    /// <summary>
    /// DocumentContract DaysDue
    /// </summary>
    public int? DaysDue { get => _daysDue; set => SetField(ref _daysDue, value); }

    /// <summary>
    /// DocumentContract DaysTillExpire
    /// </summary>
    public int? DaysTillExpire { get => _daysTillExpire; set => SetField(ref _daysTillExpire, value); }

    /// <summary>
    /// DocumentContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// DocumentContract DocumentGroups
    /// </summary>
    [AllowNull]
    public IList<string?> DocumentGroups { get => GetField(ref _documentGroups); set => SetField(ref _documentGroups, value); }

    /// <summary>
    /// DocumentContract DocumentTypes
    /// </summary>
    [AllowNull]
    public IList<string?> DocumentTypes { get => GetField(ref _documentTypes); set => SetField(ref _documentTypes, value); }

    /// <summary>
    /// DocumentContract EmnSignature
    /// </summary>
    public string? EmnSignature { get => _emnSignature; set => SetField(ref _emnSignature, value); }

    /// <summary>
    /// DocumentContract ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => _expectedDate; set => SetField(ref _expectedDate, value); }

    /// <summary>
    /// DocumentContract ExpirationDate
    /// </summary>
    public DateTime? ExpirationDate { get => _expirationDate; set => SetField(ref _expirationDate, value); }

    /// <summary>
    /// DocumentContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// DocumentContract IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => _isMarkedRemoved; set => SetField(ref _isMarkedRemoved, value); }

    /// <summary>
    /// DocumentContract IsProtected
    /// </summary>
    public bool? IsProtected { get => _isProtected; set => SetField(ref _isProtected, value); }

    /// <summary>
    /// DocumentContract Milestone
    /// </summary>
    [AllowNull]
    public EntityReference Milestone { get => GetField(ref _milestone); set => SetField(ref _milestone, value); }

    /// <summary>
    /// DocumentContract PackageId
    /// </summary>
    public string? PackageId { get => _packageId; set => SetField(ref _packageId, value); }

    /// <summary>
    /// DocumentContract ReadyForUwBy
    /// </summary>
    [AllowNull]
    public EntityReference ReadyForUwBy { get => GetField(ref _readyForUwBy); set => SetField(ref _readyForUwBy, value); }

    /// <summary>
    /// DocumentContract ReadyForUwDate
    /// </summary>
    public DateTime? ReadyForUwDate { get => _readyForUwDate; set => SetField(ref _readyForUwDate, value); }

    /// <summary>
    /// DocumentContract ReadyToShipBy
    /// </summary>
    [AllowNull]
    public EntityReference ReadyToShipBy { get => GetField(ref _readyToShipBy); set => SetField(ref _readyToShipBy, value); }

    /// <summary>
    /// DocumentContract ReadyToShipDate
    /// </summary>
    public DateTime? ReadyToShipDate { get => _readyToShipDate; set => SetField(ref _readyToShipDate, value); }

    /// <summary>
    /// DocumentContract ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetField(ref _receivedBy); set => SetField(ref _receivedBy, value); }

    /// <summary>
    /// DocumentContract ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

    /// <summary>
    /// DocumentContract RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetField(ref _requestedBy); set => SetField(ref _requestedBy, value); }

    /// <summary>
    /// DocumentContract RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }

    /// <summary>
    /// DocumentContract RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

    /// <summary>
    /// DocumentContract RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetField(ref _rerequestedBy); set => SetField(ref _rerequestedBy, value); }

    /// <summary>
    /// DocumentContract RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => _rerequestedDate; set => SetField(ref _rerequestedDate, value); }

    /// <summary>
    /// DocumentContract ReviewedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReviewedBy { get => GetField(ref _reviewedBy); set => SetField(ref _reviewedBy, value); }

    /// <summary>
    /// DocumentContract ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get => _reviewedDate; set => SetField(ref _reviewedDate, value); }

    /// <summary>
    /// DocumentContract Roles
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Roles { get => GetField(ref _roles); set => SetField(ref _roles, value); }

    /// <summary>
    /// DocumentContract Status
    /// </summary>
    public string? Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// DocumentContract StatusDate
    /// </summary>
    public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }

    /// <summary>
    /// DocumentContract Title
    /// </summary>
    public string? Title { get => _title; set => SetField(ref _title, value); }

    /// <summary>
    /// DocumentContract Verification
    /// </summary>
    [AllowNull]
    public EntityReference Verification { get => GetField(ref _verification); set => SetField(ref _verification, value); }
}