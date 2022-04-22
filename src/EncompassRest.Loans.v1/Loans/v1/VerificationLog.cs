using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// VerificationLog
/// </summary>
public sealed partial class VerificationLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// VerificationLog AccessedBy
    /// </summary>
    public string? AccessedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog AccessedDateUtc
    /// </summary>
    public DateTime? AccessedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog AddedBy
    /// </summary>
    public string? AddedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// VerificationLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog AllowedRoleDelimitedList
    /// </summary>
    public string? AllowedRoleDelimitedList { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog AllowedRoles
    /// </summary>
    [AllowNull]
    public IList<EntityReference> AllowedRoles { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// VerificationLog AllowedRolesXml
    /// </summary>
    public string? AllowedRolesXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ArchiveDateUtc
    /// </summary>
    public DateTime? ArchiveDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ArchivedBy
    /// </summary>
    public string? ArchivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ClosingDocumentIndicator
    /// </summary>
    public bool? ClosingDocumentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// VerificationLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Company
    /// </summary>
    public string? Company { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Conditions
    /// </summary>
    [AllowNull]
    public IList<EntityReference> Conditions { get => GetList<EntityReference>(); set => SetList(value); }

    /// <summary>
    /// VerificationLog ConditionsXml
    /// </summary>
    public string? ConditionsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DateAddedUtc
    /// </summary>
    public DateTime? DateAddedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DateExpected
    /// </summary>
    public DateTime? DateExpected { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DateExpires
    /// </summary>
    public DateTime? DateExpires { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DateReceived
    /// </summary>
    public DateTime? DateReceived { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DateRequested
    /// </summary>
    public DateTime? DateRequested { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DateRerequested
    /// </summary>
    public DateTime? DateRerequested { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DaysDue
    /// </summary>
    public int? DaysDue { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DaysTillExpire
    /// </summary>
    public int? DaysTillExpire { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DocumentDateTimeType
    /// </summary>
    public string? DocumentDateTimeType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog DocVerificationsXml
    /// </summary>
    public string? DocVerificationsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog EDisclosureIndicator
    /// </summary>
    public bool? EDisclosureIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog EPassSignature
    /// </summary>
    public string? EPassSignature { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Expected
    /// </summary>
    public bool? Expected { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Expires
    /// </summary>
    public bool? Expires { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog FileAttachmentsXml
    /// </summary>
    public string? FileAttachmentsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog GroupName
    /// </summary>
    public string? GroupName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsAssetVerification
    /// </summary>
    public bool? IsAssetVerification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsEmploymentVerification
    /// </summary>
    public bool? IsEmploymentVerification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsEPassIndicator
    /// </summary>
    public bool? IsEPassIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsExpired
    /// </summary>
    public bool? IsExpired { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsExternalIndicator
    /// </summary>
    public bool? IsExternalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsIncomeVerification
    /// </summary>
    public bool? IsIncomeVerification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsObligationVerification
    /// </summary>
    public bool? IsObligationVerification { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsPastDue
    /// </summary>
    public bool? IsPastDue { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsThirdPartyDocIndicator
    /// </summary>
    public bool? IsThirdPartyDocIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsTPOWebcenterPortalIndicator
    /// </summary>
    public bool? IsTPOWebcenterPortalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog IsWebCenterIndicator
    /// </summary>
    public bool? IsWebCenterIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog LastAttachmentDateUtc
    /// </summary>
    public DateTime? LastAttachmentDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog LogId
    /// </summary>
    public string? LogId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog OrderDateUtc
    /// </summary>
    public DateTime? OrderDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog PairId
    /// </summary>
    public string? PairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog PreClosingDocumentIndicator
    /// </summary>
    public bool? PreClosingDocumentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Received
    /// </summary>
    public bool? Received { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ReceiveDateUtc
    /// </summary>
    public DateTime? ReceiveDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ReceivedBy
    /// </summary>
    public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ReorderDateUtc
    /// </summary>
    public DateTime? ReorderDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Requested
    /// </summary>
    public bool? Requested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog RequestedBy
    /// </summary>
    public string? RequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog RequestedFrom
    /// </summary>
    public string? RequestedFrom { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Rerequested
    /// </summary>
    public bool? Rerequested { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog RerequestedBy
    /// </summary>
    public string? RerequestedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Reviewed
    /// </summary>
    public bool? Reviewed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ReviewedBy
    /// </summary>
    public string? ReviewedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ReviewedDateUtc
    /// </summary>
    public DateTime? ReviewedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ShippingReady
    /// </summary>
    public bool? ShippingReady { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ShippingReadyBy
    /// </summary>
    public string? ShippingReadyBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog ShippingReadyDateUtc
    /// </summary>
    public DateTime? ShippingReadyDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Stage
    /// </summary>
    public string? Stage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Status
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog Title
    /// </summary>
    public string? Title { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog UnderwritingReady
    /// </summary>
    public bool? UnderwritingReady { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog UnderwritingReadyBy
    /// </summary>
    public string? UnderwritingReadyBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// VerificationLog UnderwritingReadyDateUtc
    /// </summary>
    public DateTime? UnderwritingReadyDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}