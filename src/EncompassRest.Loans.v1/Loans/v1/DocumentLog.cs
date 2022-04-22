using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DocumentLog
/// </summary>
public sealed partial class DocumentLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DocumentLog AccessedBy
    /// </summary>
    public string? AccessedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog AccessedDateUtc
    /// </summary>
    public DateTime? AccessedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// DocumentLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog AllowedRoleDelimitedList
    /// </summary>
    public string? AllowedRoleDelimitedList { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog AllowedRoles
    /// </summary>
    [AllowNull]
    public IList<EntityReference> AllowedRoles { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// DocumentLog AllowedRolesXml
    /// </summary>
    public string? AllowedRolesXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ArchiveDateUtc
    /// </summary>
    public DateTime? ArchiveDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ArchivedBy
    /// </summary>
    public string? ArchivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ClosingDocumentIndicator
    /// </summary>
    public bool? ClosingDocumentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// DocumentLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Company
    /// </summary>
    public string? Company { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Conditions
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Conditions { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// DocumentLog ConditionsXml
    /// </summary>
    public string? ConditionsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DateAddedUtc
    /// </summary>
    public DateTime? DateAddedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DateExpected
    /// </summary>
    public DateTime? DateExpected { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DateExpires
    /// </summary>
    public DateTime? DateExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DateReceived
    /// </summary>
    public DateTime? DateReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DateRequested
    /// </summary>
    public DateTime? DateRequested { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DateRerequested
    /// </summary>
    public DateTime? DateRerequested { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DaysDue
    /// </summary>
    public int? DaysDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DaysTillExpire
    /// </summary>
    public int? DaysTillExpire { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DocumentDateTimeType
    /// </summary>
    public string? DocumentDateTimeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog DocVerificationsXml
    /// </summary>
    public string? DocVerificationsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog EDisclosureIndicator
    /// </summary>
    public bool? EDisclosureIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog EPassSignature
    /// </summary>
    public string? EPassSignature { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Expected
    /// </summary>
    public bool? Expected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Expires
    /// </summary>
    public bool? Expires { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog FileAttachmentReferences
    /// </summary>
    [AllowNull]
    public IList<FileAttachmentReference> FileAttachmentReferences { get => GetList<FileAttachmentReference>(); set => SetList(value); }

    /// <summary>
    /// DocumentLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog FileAttachmentsXml
    /// </summary>
    public string? FileAttachmentsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog GroupName
    /// </summary>
    public string? GroupName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsAssetVerification
    /// </summary>
    public bool? IsAssetVerification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsEmploymentVerification
    /// </summary>
    public bool? IsEmploymentVerification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsEPassIndicator
    /// </summary>
    public bool? IsEPassIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsExpired
    /// </summary>
    public bool? IsExpired { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsExternalIndicator
    /// </summary>
    public bool? IsExternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsIncomeVerification
    /// </summary>
    public bool? IsIncomeVerification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsObligationVerification
    /// </summary>
    public bool? IsObligationVerification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsPastDue
    /// </summary>
    public bool? IsPastDue { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsThirdPartyDocIndicator
    /// </summary>
    public bool? IsThirdPartyDocIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsTPOWebcenterPortalIndicator
    /// </summary>
    public bool? IsTPOWebcenterPortalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog IsWebCenterIndicator
    /// </summary>
    public bool? IsWebCenterIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog LastAttachmentDateUtc
    /// </summary>
    public DateTime? LastAttachmentDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog OrderDateUtc
    /// </summary>
    public DateTime? OrderDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog PackageId
    /// </summary>
    public string? PackageId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog PairId
    /// </summary>
    public string? PairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog PreClosingDocumentIndicator
    /// </summary>
    public bool? PreClosingDocumentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Received
    /// </summary>
    public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ReceiveDateUtc
    /// </summary>
    public DateTime? ReceiveDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ReceivedBy
    /// </summary>
    public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ReorderDateUtc
    /// </summary>
    public DateTime? ReorderDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Requested
    /// </summary>
    public bool? Requested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog RequestedBy
    /// </summary>
    public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Rerequested
    /// </summary>
    public bool? Rerequested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog RerequestedBy
    /// </summary>
    public string? RerequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Reviewed
    /// </summary>
    public bool? Reviewed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ReviewedBy
    /// </summary>
    public string? ReviewedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ReviewedDateUtc
    /// </summary>
    public DateTime? ReviewedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ShippingReady
    /// </summary>
    public bool? ShippingReady { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ShippingReadyBy
    /// </summary>
    public string? ShippingReadyBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog ShippingReadyDateUtc
    /// </summary>
    public DateTime? ShippingReadyDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Stage
    /// </summary>
    public string? Stage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog UnderwritingReady
    /// </summary>
    public bool? UnderwritingReady { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog UnderwritingReadyBy
    /// </summary>
    public string? UnderwritingReadyBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog UnderwritingReadyDateUtc
    /// </summary>
    public DateTime? UnderwritingReadyDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}