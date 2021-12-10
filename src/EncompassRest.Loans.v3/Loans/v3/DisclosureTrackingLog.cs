using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureTrackingLog
/// </summary>
public sealed partial class DisclosureTrackingLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<LogAlert>? _alerts;
    private DirtyValue<DateTime?>? _applicationDate;
    private DirtyValue<string?>? _borrowerName;
    private DirtyValue<string?>? _borrowerPairId;
    private DirtyValue<string?>? _coBorrowerName;
    private DirtyList<LogComment>? _commentList;
    private DirtyValue<string?>? _comments;
    private DirtyValue<bool?>? _containGfe;
    private DirtyValue<bool?>? _containSafeHarbor;
    private DirtyValue<bool?>? _containTil;
    private DirtyValue<DateTime?>? _date;
    private DirtyValue<string?>? _disclosedApr;
    private DirtyValue<string?>? _disclosedBy;
    private DirtyValue<string?>? _disclosedByFullName;
    private DirtyValue<string?>? _disclosedMethod;
    private DirtyValue<DateTime?>? _disclosureCreatedDateTime;
    private DirtyValue<bool?>? _eDisclosureApplicationPackageIndicator;
    private DirtyValue<bool?>? _eDisclosureApprovalPackageIndicator;
    private DirtyValue<DateTime?>? _eDisclosureBorrowerAcceptConsentDate;
    private DirtyValue<DateTime?>? _eDisclosureBorrowereSignedDate;
    private DirtyValue<DateTime?>? _eDisclosureBorrowerRejectConsentDate;
    private DirtyValue<DateTime?>? _eDisclosureBorrowerViewConsentDate;
    private DirtyValue<DateTime?>? _eDisclosureBorrowerViewMessageDate;
    private DirtyValue<DateTime?>? _eDisclosureBorrowerWetSignedDate;
    private DirtyValue<DateTime?>? _eDisclosureCoBorrowerAcceptConsentDate;
    private DirtyValue<DateTime?>? _eDisclosureCoBorrowereSignedDate;
    private DirtyValue<DateTime?>? _eDisclosureCoBorrowerRejectConsentDate;
    private DirtyValue<DateTime?>? _eDisclosureCoBorrowerViewConsentDate;
    private DirtyValue<DateTime?>? _eDisclosureCoBorrowerViewMessageDate;
    private DirtyValue<DateTime?>? _eDisclosureCoBorrowerWebSignedDate;
    private DirtyValue<string?>? _eDisclosureConsentPdf;
    private DirtyValue<string?>? _eDisclosureDisclosedMessage;
    private DirtyValue<bool?>? _eDisclosureLockPackageIndicator;
    private DirtyValue<string?>? _eDisclosureManualFulfillmentComment;
    private DirtyValue<DateTime?>? _eDisclosureManualFulfillmentDate;
    private DirtyValue<string?>? _eDisclosureManualFulfillmentMethod;
    private DirtyValue<string?>? _eDisclosureManuallyFulfilledBy;
    private DirtyValue<DateTime?>? _eDisclosurePackageCreatedDate;
    private DirtyValue<string?>? _eDisclosurePackageId;
    private DirtyValue<string?>? _eDisclosurePackageViewableFile;
    private DirtyValue<bool?>? _eDisclosureThreeDayPackageIndicator;
    private DirtyValue<string?>? _financeCharge;
    private DirtyList<DisclosureForm>? _forms;
    private DirtyValue<string?>? _fulfillmentOrderedBy;
    private DirtyValue<DateTime?>? _fulfillmentProcessedDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _isDisclosed;
    private DirtyValue<string?>? _isDisclosedAprLocked;
    private DirtyValue<string?>? _isDisclosedByLocked;
    private DirtyValue<string?>? _isDisclosedFinanceChargeLocked;
    private DirtyValue<string?>? _isDisclosedReceivedDateLocked;
    private DirtyValue<string?>? _isLocked;
    private DirtyValue<bool?>? _isWetSignedIndicator;
    private DirtyValue<string?>? _loanAmount;
    private DirtyValue<string?>? _loanProgram;
    private DirtyValue<string?>? _lockedDisclosedAprField;
    private DirtyValue<string?>? _lockedDisclosedByField;
    private DirtyValue<string?>? _lockedDisclosedFinanceChargeField;
    private DirtyValue<DateTime?>? _lockedDisclosedReceivedDate;
    private DirtyValue<string?>? _manuallyCreated;
    private DirtyValue<string?>? _propertyAddress;
    private DirtyValue<string?>? _propertyCity;
    private DirtyValue<string?>? _propertyState;
    private DirtyValue<string?>? _propertyZip;
    private DirtyValue<DateTime?>? _receivedDate;
    private DirtyList<LogSnapshotField>? _snapshotFields;

    /// <summary>
    /// DisclosureTrackingLogContract Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

    /// <summary>
    /// DisclosureTrackingLogContract ApplicationDate
    /// </summary>
    public DateTime? ApplicationDate { get => _applicationDate; set => SetField(ref _applicationDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract BorrowerName
    /// </summary>
    public string? BorrowerName { get => _borrowerName; set => SetField(ref _borrowerName, value); }

    /// <summary>
    /// DisclosureTrackingLogContract BorrowerPairId
    /// </summary>
    public string? BorrowerPairId { get => _borrowerPairId; set => SetField(ref _borrowerPairId, value); }

    /// <summary>
    /// DisclosureTrackingLogContract CoBorrowerName
    /// </summary>
    public string? CoBorrowerName { get => _coBorrowerName; set => SetField(ref _coBorrowerName, value); }

    /// <summary>
    /// DisclosureTrackingLogContract CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

    /// <summary>
    /// DisclosureTrackingLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// DisclosureTrackingLogContract ContainGfe
    /// </summary>
    public bool? ContainGfe { get => _containGfe; set => SetField(ref _containGfe, value); }

    /// <summary>
    /// DisclosureTrackingLogContract ContainSafeHarbor
    /// </summary>
    public bool? ContainSafeHarbor { get => _containSafeHarbor; set => SetField(ref _containSafeHarbor, value); }

    /// <summary>
    /// DisclosureTrackingLogContract ContainTil
    /// </summary>
    public bool? ContainTil { get => _containTil; set => SetField(ref _containTil, value); }

    /// <summary>
    /// DisclosureTrackingLogContract Date
    /// </summary>
    public DateTime? Date { get => _date; set => SetField(ref _date, value); }

    /// <summary>
    /// DisclosureTrackingLogContract DisclosedApr
    /// </summary>
    public string? DisclosedApr { get => _disclosedApr; set => SetField(ref _disclosedApr, value); }

    /// <summary>
    /// DisclosureTrackingLogContract DisclosedBy
    /// </summary>
    public string? DisclosedBy { get => _disclosedBy; set => SetField(ref _disclosedBy, value); }

    /// <summary>
    /// DisclosureTrackingLogContract DisclosedByFullName
    /// </summary>
    public string? DisclosedByFullName { get => _disclosedByFullName; set => SetField(ref _disclosedByFullName, value); }

    /// <summary>
    /// DisclosureTrackingLogContract DisclosedMethod
    /// </summary>
    public string? DisclosedMethod { get => _disclosedMethod; set => SetField(ref _disclosedMethod, value); }

    /// <summary>
    /// DisclosureTrackingLogContract DisclosureCreatedDateTime
    /// </summary>
    public DateTime? DisclosureCreatedDateTime { get => _disclosureCreatedDateTime; set => SetField(ref _disclosureCreatedDateTime, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureApplicationPackageIndicator
    /// </summary>
    public bool? EDisclosureApplicationPackageIndicator { get => _eDisclosureApplicationPackageIndicator; set => SetField(ref _eDisclosureApplicationPackageIndicator, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureApprovalPackageIndicator
    /// </summary>
    public bool? EDisclosureApprovalPackageIndicator { get => _eDisclosureApprovalPackageIndicator; set => SetField(ref _eDisclosureApprovalPackageIndicator, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureBorrowerAcceptConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerAcceptConsentDate { get => _eDisclosureBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureBorrowerAcceptConsentDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureBorrowereSignedDate
    /// </summary>
    public DateTime? EDisclosureBorrowereSignedDate { get => _eDisclosureBorrowereSignedDate; set => SetField(ref _eDisclosureBorrowereSignedDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureBorrowerRejectConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerRejectConsentDate { get => _eDisclosureBorrowerRejectConsentDate; set => SetField(ref _eDisclosureBorrowerRejectConsentDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureBorrowerViewConsentDate
    /// </summary>
    public DateTime? EDisclosureBorrowerViewConsentDate { get => _eDisclosureBorrowerViewConsentDate; set => SetField(ref _eDisclosureBorrowerViewConsentDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureBorrowerViewMessageDate
    /// </summary>
    public DateTime? EDisclosureBorrowerViewMessageDate { get => _eDisclosureBorrowerViewMessageDate; set => SetField(ref _eDisclosureBorrowerViewMessageDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureBorrowerWetSignedDate
    /// </summary>
    public DateTime? EDisclosureBorrowerWetSignedDate { get => _eDisclosureBorrowerWetSignedDate; set => SetField(ref _eDisclosureBorrowerWetSignedDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureCoBorrowerAcceptConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get => _eDisclosureCoBorrowerAcceptConsentDate; set => SetField(ref _eDisclosureCoBorrowerAcceptConsentDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureCoBorrowereSignedDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowereSignedDate { get => _eDisclosureCoBorrowereSignedDate; set => SetField(ref _eDisclosureCoBorrowereSignedDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureCoBorrowerRejectConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerRejectConsentDate { get => _eDisclosureCoBorrowerRejectConsentDate; set => SetField(ref _eDisclosureCoBorrowerRejectConsentDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureCoBorrowerViewConsentDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerViewConsentDate { get => _eDisclosureCoBorrowerViewConsentDate; set => SetField(ref _eDisclosureCoBorrowerViewConsentDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureCoBorrowerViewMessageDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerViewMessageDate { get => _eDisclosureCoBorrowerViewMessageDate; set => SetField(ref _eDisclosureCoBorrowerViewMessageDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureCoBorrowerWebSignedDate
    /// </summary>
    public DateTime? EDisclosureCoBorrowerWebSignedDate { get => _eDisclosureCoBorrowerWebSignedDate; set => SetField(ref _eDisclosureCoBorrowerWebSignedDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureConsentPdf
    /// </summary>
    public string? EDisclosureConsentPdf { get => _eDisclosureConsentPdf; set => SetField(ref _eDisclosureConsentPdf, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureDisclosedMessage
    /// </summary>
    public string? EDisclosureDisclosedMessage { get => _eDisclosureDisclosedMessage; set => SetField(ref _eDisclosureDisclosedMessage, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureLockPackageIndicator
    /// </summary>
    public bool? EDisclosureLockPackageIndicator { get => _eDisclosureLockPackageIndicator; set => SetField(ref _eDisclosureLockPackageIndicator, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureManualFulfillmentComment
    /// </summary>
    public string? EDisclosureManualFulfillmentComment { get => _eDisclosureManualFulfillmentComment; set => SetField(ref _eDisclosureManualFulfillmentComment, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureManualFulfillmentDate
    /// </summary>
    public DateTime? EDisclosureManualFulfillmentDate { get => _eDisclosureManualFulfillmentDate; set => SetField(ref _eDisclosureManualFulfillmentDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureManualFulfillmentMethod
    /// </summary>
    public string? EDisclosureManualFulfillmentMethod { get => _eDisclosureManualFulfillmentMethod; set => SetField(ref _eDisclosureManualFulfillmentMethod, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureManuallyFulfilledBy
    /// </summary>
    public string? EDisclosureManuallyFulfilledBy { get => _eDisclosureManuallyFulfilledBy; set => SetField(ref _eDisclosureManuallyFulfilledBy, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosurePackageCreatedDate
    /// </summary>
    public DateTime? EDisclosurePackageCreatedDate { get => _eDisclosurePackageCreatedDate; set => SetField(ref _eDisclosurePackageCreatedDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosurePackageId
    /// </summary>
    public string? EDisclosurePackageId { get => _eDisclosurePackageId; set => SetField(ref _eDisclosurePackageId, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosurePackageViewableFile
    /// </summary>
    public string? EDisclosurePackageViewableFile { get => _eDisclosurePackageViewableFile; set => SetField(ref _eDisclosurePackageViewableFile, value); }

    /// <summary>
    /// DisclosureTrackingLogContract EDisclosureThreeDayPackageIndicator
    /// </summary>
    public bool? EDisclosureThreeDayPackageIndicator { get => _eDisclosureThreeDayPackageIndicator; set => SetField(ref _eDisclosureThreeDayPackageIndicator, value); }

    /// <summary>
    /// DisclosureTrackingLogContract FinanceCharge
    /// </summary>
    public string? FinanceCharge { get => _financeCharge; set => SetField(ref _financeCharge, value); }

    /// <summary>
    /// DisclosureTrackingLogContract Forms
    /// </summary>
    [AllowNull]
    public IList<DisclosureForm> Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }

    /// <summary>
    /// DisclosureTrackingLogContract FulfillmentOrderedBy
    /// </summary>
    public string? FulfillmentOrderedBy { get => _fulfillmentOrderedBy; set => SetField(ref _fulfillmentOrderedBy, value); }

    /// <summary>
    /// DisclosureTrackingLogContract FulfillmentProcessedDate
    /// </summary>
    public DateTime? FulfillmentProcessedDate { get => _fulfillmentProcessedDate; set => SetField(ref _fulfillmentProcessedDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// DisclosureTrackingLogContract IsDisclosed
    /// </summary>
    public string? IsDisclosed { get => _isDisclosed; set => SetField(ref _isDisclosed, value); }

    /// <summary>
    /// DisclosureTrackingLogContract IsDisclosedAprLocked
    /// </summary>
    public string? IsDisclosedAprLocked { get => _isDisclosedAprLocked; set => SetField(ref _isDisclosedAprLocked, value); }

    /// <summary>
    /// DisclosureTrackingLogContract IsDisclosedByLocked
    /// </summary>
    public string? IsDisclosedByLocked { get => _isDisclosedByLocked; set => SetField(ref _isDisclosedByLocked, value); }

    /// <summary>
    /// DisclosureTrackingLogContract IsDisclosedFinanceChargeLocked
    /// </summary>
    public string? IsDisclosedFinanceChargeLocked { get => _isDisclosedFinanceChargeLocked; set => SetField(ref _isDisclosedFinanceChargeLocked, value); }

    /// <summary>
    /// DisclosureTrackingLogContract IsDisclosedReceivedDateLocked
    /// </summary>
    public string? IsDisclosedReceivedDateLocked { get => _isDisclosedReceivedDateLocked; set => SetField(ref _isDisclosedReceivedDateLocked, value); }

    /// <summary>
    /// DisclosureTrackingLogContract IsLocked
    /// </summary>
    public string? IsLocked { get => _isLocked; set => SetField(ref _isLocked, value); }

    /// <summary>
    /// DisclosureTrackingLogContract IsWetSignedIndicator
    /// </summary>
    public bool? IsWetSignedIndicator { get => _isWetSignedIndicator; set => SetField(ref _isWetSignedIndicator, value); }

    /// <summary>
    /// DisclosureTrackingLogContract LoanAmount
    /// </summary>
    public string? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

    /// <summary>
    /// DisclosureTrackingLogContract LoanProgram
    /// </summary>
    public string? LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }

    /// <summary>
    /// DisclosureTrackingLogContract LockedDisclosedAprField
    /// </summary>
    public string? LockedDisclosedAprField { get => _lockedDisclosedAprField; set => SetField(ref _lockedDisclosedAprField, value); }

    /// <summary>
    /// DisclosureTrackingLogContract LockedDisclosedByField
    /// </summary>
    public string? LockedDisclosedByField { get => _lockedDisclosedByField; set => SetField(ref _lockedDisclosedByField, value); }

    /// <summary>
    /// DisclosureTrackingLogContract LockedDisclosedFinanceChargeField
    /// </summary>
    public string? LockedDisclosedFinanceChargeField { get => _lockedDisclosedFinanceChargeField; set => SetField(ref _lockedDisclosedFinanceChargeField, value); }

    /// <summary>
    /// DisclosureTrackingLogContract LockedDisclosedReceivedDate
    /// </summary>
    public DateTime? LockedDisclosedReceivedDate { get => _lockedDisclosedReceivedDate; set => SetField(ref _lockedDisclosedReceivedDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract ManuallyCreated
    /// </summary>
    public string? ManuallyCreated { get => _manuallyCreated; set => SetField(ref _manuallyCreated, value); }

    /// <summary>
    /// DisclosureTrackingLogContract PropertyAddress
    /// </summary>
    public string? PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }

    /// <summary>
    /// DisclosureTrackingLogContract PropertyCity
    /// </summary>
    public string? PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }

    /// <summary>
    /// DisclosureTrackingLogContract PropertyState
    /// </summary>
    public string? PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }

    /// <summary>
    /// DisclosureTrackingLogContract PropertyZip
    /// </summary>
    public string? PropertyZip { get => _propertyZip; set => SetField(ref _propertyZip, value); }

    /// <summary>
    /// DisclosureTrackingLogContract ReceivedDate
    /// </summary>
    public DateTime? ReceivedDate { get => _receivedDate; set => SetField(ref _receivedDate, value); }

    /// <summary>
    /// DisclosureTrackingLogContract SnapshotFields
    /// </summary>
    [AllowNull]
    public IList<LogSnapshotField> SnapshotFields { get => GetField(ref _snapshotFields); set => SetField(ref _snapshotFields, value); }
}