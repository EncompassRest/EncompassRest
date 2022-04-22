using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DisclosureTrackingLog
/// </summary>
public sealed partial class DisclosureTrackingLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DisclosureTrackingLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTrackingLog AlertsXml
    /// </summary>
    public string? AlertsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog ApplicationDate
    /// </summary>
    public DateTime? ApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog BorrowerName
    /// </summary>
    public string? BorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog BorrowerPairId
    /// </summary>
    public string? BorrowerPairId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog CoBorrowerName
    /// </summary>
    public string? CoBorrowerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTrackingLog CommentListXml
    /// </summary>
    public string? CommentListXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog ContainGfe
    /// </summary>
    public bool? ContainGfe { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog ContainSafeHarbor
    /// </summary>
    public bool? ContainSafeHarbor { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog ContainTil
    /// </summary>
    public bool? ContainTil { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog DisclosedAPR
    /// </summary>
    public string? DisclosedAPR { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog DisclosedBy
    /// </summary>
    public string? DisclosedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog DisclosedByFullName
    /// </summary>
    public string? DisclosedByFullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog DisclosedMethod
    /// </summary>
    public string? DisclosedMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog DisclosureCreatedDttmUtc
    /// </summary>
    public DateTime? DisclosureCreatedDttmUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureApplicationPackageIndicator
    /// </summary>
    public bool? EDisclosureApplicationPackageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureApprovalPackageIndicator
    /// </summary>
    public bool? EDisclosureApprovalPackageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureBorrowerAcceptConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerAcceptConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureBorrowereSignedDate
    /// </summary>
    public DateTime? EDisclosureBorrowereSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureBorrowerRejectConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerRejectConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureBorrowerViewConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerViewConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureBorrowerViewMessageDate
    /// </summary>
    public DateTime? EDisclosureBorrowerViewMessageDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureBorrowerWetSignedDate
    /// </summary>
    public DateTime? EDisclosureBorrowerWetSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureCoBorrowerAcceptConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureCoBorrowereSignedDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowereSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureCoBorrowerRejectConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureCoBorrowerViewConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerViewConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureCoBorrowerViewMessageDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerViewMessageDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureCoBorrowerWebSignedDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerWebSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureConsentPdf
    /// </summary>
    public string? EDisclosureConsentPdf { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureDisclosedMessage
    /// </summary>
    public string? EDisclosureDisclosedMessage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureLockPackageIndicator
    /// </summary>
    public bool? EDisclosureLockPackageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureManualFulfillmentComment
    /// </summary>
    public string? EDisclosureManualFulfillmentComment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureManualFulfillmentDate
    /// </summary>
    public DateTime? EDisclosureManualFulfillmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureManualFulfillmentMethod
    /// </summary>
    public string? EDisclosureManualFulfillmentMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureManuallyFulfilledBy
    /// </summary>
    public string? EDisclosureManuallyFulfilledBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosurePackageCreatedDate
    /// </summary>
    public DateTime? EDisclosurePackageCreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosurePackageId
    /// </summary>
    public string? EDisclosurePackageId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosurePackageViewableFile
    /// </summary>
    public string? EDisclosurePackageViewableFile { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog EDisclosureThreeDayPackageIndicator
    /// </summary>
    public bool? EDisclosureThreeDayPackageIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog FinanceCharge
    /// </summary>
    public string? FinanceCharge { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog Forms
    /// </summary>
    [AllowNull]
    public IList<DisclosureForm> Forms { get => GetList<DisclosureForm>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTrackingLog FormsXml
    /// </summary>
    public string? FormsXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog FulfillmentOrderedBy
    /// </summary>
    public string? FulfillmentOrderedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog FullfillmentProcessedDate
    /// </summary>
    public string? FullfillmentProcessedDate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog IsDisclosed
    /// </summary>
    public string? IsDisclosed { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog IsDisclosedAprLocked
    /// </summary>
    public string? IsDisclosedAprLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog IsDisclosedByLocked
    /// </summary>
    public string? IsDisclosedByLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog IsDisclosedFinanceChargeLocked
    /// </summary>
    public string? IsDisclosedFinanceChargeLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog IsDisclosedReceivedDateLocked
    /// </summary>
    public string? IsDisclosedReceivedDateLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog IsLocked
    /// </summary>
    public string? IsLocked { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog IsWetSignedIndicator
    /// </summary>
    public bool? IsWetSignedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog LoanAmount
    /// </summary>
    public string? LoanAmount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog LoanProgram
    /// </summary>
    public string? LoanProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog LockedDisclosedAprField
    /// </summary>
    public string? LockedDisclosedAprField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog LockedDisclosedByField
    /// </summary>
    public string? LockedDisclosedByField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog LockedDisclosedFinanceChargeField
    /// </summary>
    public string? LockedDisclosedFinanceChargeField { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog LockedDisclosedReceivedDate
    /// </summary>
    public DateTime? LockedDisclosedReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog ManuallyCreated
    /// </summary>
    public string? ManuallyCreated { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog PropertyAddress
    /// </summary>
    public string? PropertyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog PropertyCity
    /// </summary>
    public string? PropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog PropertyState
    /// </summary>
    public string? PropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog PropertyZip
    /// </summary>
    public string? PropertyZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog SnapshotFields
    /// </summary>
    [AllowNull]
    public IList<LogSnapshotField> SnapshotFields { get => GetList<LogSnapshotField>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTrackingLog SnapshotXml
    /// </summary>
    public string? SnapshotXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureTrackingLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}