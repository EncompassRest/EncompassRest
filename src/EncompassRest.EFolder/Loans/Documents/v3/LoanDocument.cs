using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.v3;

namespace EncompassRest.Loans.Documents.v3;

/// <summary>
/// LoanDocument
/// </summary>
public sealed partial class LoanDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LoanDocument AccessibleTo
    /// </summary>
    [AllowNull]
    public IList<string?> AccessibleTo { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// LoanDocument Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetEntity<ApplicationReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument Attachments
    /// </summary>
    [AllowNull]
    public IList<FileAttachmentReference> Attachments { get => GetList<FileAttachmentReference>(); set => SetList(value); }

    /// <summary>
    /// LoanDocument Conditions
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Conditions { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// LoanDocument CreatedBy
    /// </summary>
    [AllowNull]
    public EntityReference CreatedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument CreatedDate
    /// </summary>
    public DateTime? CreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument DaysDue
    /// </summary>
    public int? DaysDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument DaysTillExpire
    /// </summary>
    public int? DaysTillExpire { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument DocumentGroups
    /// </summary>
    [AllowNull]
    public IList<string?> DocumentGroups { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// LoanDocument DocumentTypes
    /// </summary>
    [AllowNull]
    public IList<string?> DocumentTypes { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// LoanDocument EmnSignature
    /// </summary>
    public string? EmnSignature { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument ExpectedDate
    /// </summary>
    public DateTime? ExpectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument ExpirationDate
    /// </summary>
    public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument IsMarkedRemoved
    /// </summary>
    public bool? IsMarkedRemoved { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument IsProtected
    /// </summary>
    public bool? IsProtected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument Milestone
    /// </summary>
    [AllowNull]
    public EntityReference Milestone { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument PackageId
    /// </summary>
    public string? PackageId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument ReadyForUwBy
    /// </summary>
    [AllowNull]
    public EntityReference ReadyForUwBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument ReadyForUwDate
    /// </summary>
    public DateTime? ReadyForUwDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument ReadyToShipBy
    /// </summary>
    [AllowNull]
    public EntityReference ReadyToShipBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument ReadyToShipDate
    /// </summary>
    public DateTime? ReadyToShipDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument ReceivedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReceivedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument RequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument RequestedDate
    /// </summary>
    public DateTime? RequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument RerequestedBy
    /// </summary>
    [AllowNull]
    public EntityReference RerequestedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument RerequestedDate
    /// </summary>
    public DateTime? RerequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument ReviewedBy
    /// </summary>
    [AllowNull]
    public EntityReference ReviewedBy { get => GetEntity<EntityReference>(); set => SetEntity(value); }

    /// <summary>
    /// LoanDocument ReviewedDate
    /// </summary>
    public DateTime? ReviewedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument Roles
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Roles { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// LoanDocument Status
    /// </summary>
    public StringEnumValue<DocumentStatus> Status { get => GetValue<StringEnumValue<DocumentStatus>>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument StatusDate
    /// </summary>
    public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanDocument Verification
    /// </summary>
    [AllowNull]
    public EntityReference Verification { get => GetEntity<EntityReference>(); set => SetEntity(value); }
}