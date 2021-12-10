using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EnhancedDisclosureTracking2015Log
/// </summary>
public sealed partial class EnhancedDisclosureTracking2015Log : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _applicationDate;
    private DirtyValue<bool?>? _changedCircumstanceIndicator;
    private DirtyValue<string?>? _changeInCircumstance;
    private DirtyValue<string?>? _changeInCircumstanceComments;
    private ClosingDisclosureFields? _closingDisclosure;
    private DirtyList<string?>? _contents;
    private LockableDecimalField? _disclosedApr;
    private LockableUserRefField? _disclosedBy;
    private LockableDecimalField? _disclosedDailyInterest;
    private DisclosedDateField? _disclosedDate;
    private LockableDecimalField? _disclosedFinanceCharge;
    private DirtyValue<StringEnumValue<DisclosedOrReceivedMethod>>? _disclosedMethod;
    private DirtyValue<string?>? _disclosedMethodDescription;
    private DirtyValue<DateTime?>? _disclosureCreatedDate;
    private DirtyList<DisclosureRecipient>? _disclosureRecipients;
    private DirtyValue<StringEnumValue<EnhancedDisclosureTracking2015LogDisclosureType>>? _disclosureType;
    private DisclosureTrackingDocuments? _documents;
    private DirtyList<DisclosureFeeChange>? _feeChanges;
    private DirtyValue<bool?>? _feeLevelDisclosuresIndicator;
    private DirtyList<Fulfillment>? _fulfillments;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _includedInTimeline;
    private IntentToProceed? _intentToProceed;
    private DirtyValue<string?>? _linkedLogId;
    private DirtyValue<decimal?>? _loanAmount;
    private LoanEstimateFields? _loanEstimate;
    private DirtyValue<string?>? _loanProgram;
    private DirtyValue<string?>? _loanXml;
    private Address? _propertyAddress;
    private DirtyValue<StringEnumValue<EnhancedDisclosureTracking2015LogProvider>>? _provider;
    private DirtyValue<string?>? _providerDescription;
    private DirtyValue<object?>? _snapshot;
    private DirtyValue<StringEnumValue<EnhancedDisclosureTracking2015LogStatus>>? _status;
    private TrackingFields? _tracking;
    private DirtyValue<bool?>? _useForUcdExport;

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract ApplicationDate
    /// </summary>
    public DateTime? ApplicationDate { get => _applicationDate; set => SetField(ref _applicationDate, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract ChangedCircumstanceIndicator
    /// </summary>
    public bool? ChangedCircumstanceIndicator { get => _changedCircumstanceIndicator; set => SetField(ref _changedCircumstanceIndicator, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract ChangeInCircumstance
    /// </summary>
    public string? ChangeInCircumstance { get => _changeInCircumstance; set => SetField(ref _changeInCircumstance, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract ChangeInCircumstanceComments
    /// </summary>
    public string? ChangeInCircumstanceComments { get => _changeInCircumstanceComments; set => SetField(ref _changeInCircumstanceComments, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract ClosingDisclosure
    /// </summary>
    [AllowNull]
    public ClosingDisclosureFields ClosingDisclosure { get => GetField(ref _closingDisclosure); set => SetField(ref _closingDisclosure, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract Contents
    /// </summary>
    [AllowNull]
    public IList<string?> Contents { get => GetField(ref _contents); set => SetField(ref _contents, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosedApr
    /// </summary>
    [AllowNull]
    public LockableDecimalField DisclosedApr { get => GetField(ref _disclosedApr); set => SetField(ref _disclosedApr, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosedBy
    /// </summary>
    [AllowNull]
    public LockableUserRefField DisclosedBy { get => GetField(ref _disclosedBy); set => SetField(ref _disclosedBy, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosedDailyInterest
    /// </summary>
    [AllowNull]
    public LockableDecimalField DisclosedDailyInterest { get => GetField(ref _disclosedDailyInterest); set => SetField(ref _disclosedDailyInterest, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosedDate
    /// </summary>
    [AllowNull]
    public DisclosedDateField DisclosedDate { get => GetField(ref _disclosedDate); set => SetField(ref _disclosedDate, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosedFinanceCharge
    /// </summary>
    [AllowNull]
    public LockableDecimalField DisclosedFinanceCharge { get => GetField(ref _disclosedFinanceCharge); set => SetField(ref _disclosedFinanceCharge, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosedMethod
    /// </summary>
    public StringEnumValue<DisclosedOrReceivedMethod> DisclosedMethod { get => _disclosedMethod; set => SetField(ref _disclosedMethod, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosedMethodDescription
    /// </summary>
    public string? DisclosedMethodDescription { get => _disclosedMethodDescription; set => SetField(ref _disclosedMethodDescription, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosureCreatedDate
    /// </summary>
    public DateTime? DisclosureCreatedDate { get => _disclosureCreatedDate; set => SetField(ref _disclosureCreatedDate, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosureRecipients
    /// </summary>
    [AllowNull]
    public IList<DisclosureRecipient> DisclosureRecipients { get => GetField(ref _disclosureRecipients); set => SetField(ref _disclosureRecipients, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract DisclosureType
    /// </summary>
    public StringEnumValue<EnhancedDisclosureTracking2015LogDisclosureType> DisclosureType { get => _disclosureType; set => SetField(ref _disclosureType, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract Documents
    /// </summary>
    [AllowNull]
    public DisclosureTrackingDocuments Documents { get => GetField(ref _documents); set => SetField(ref _documents, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract FeeChanges
    /// </summary>
    [AllowNull]
    public IList<DisclosureFeeChange> FeeChanges { get => GetField(ref _feeChanges); set => SetField(ref _feeChanges, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract FeeLevelDisclosuresIndicator
    /// </summary>
    public bool? FeeLevelDisclosuresIndicator { get => _feeLevelDisclosuresIndicator; set => SetField(ref _feeLevelDisclosuresIndicator, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract Fulfillments
    /// </summary>
    [AllowNull]
    public IList<Fulfillment> Fulfillments { get => GetField(ref _fulfillments); set => SetField(ref _fulfillments, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract IncludedInTimeline
    /// </summary>
    public bool? IncludedInTimeline { get => _includedInTimeline; set => SetField(ref _includedInTimeline, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract IntentToProceed
    /// </summary>
    [AllowNull]
    public IntentToProceed IntentToProceed { get => GetField(ref _intentToProceed); set => SetField(ref _intentToProceed, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract LinkedLogId
    /// </summary>
    public string? LinkedLogId { get => _linkedLogId; set => SetField(ref _linkedLogId, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract LoanAmount
    /// </summary>
    public decimal? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract LoanEstimate
    /// </summary>
    [AllowNull]
    public LoanEstimateFields LoanEstimate { get => GetField(ref _loanEstimate); set => SetField(ref _loanEstimate, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract LoanProgram
    /// </summary>
    public string? LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract LoanXml
    /// </summary>
    public string? LoanXml { get => _loanXml; set => SetField(ref _loanXml, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract PropertyAddress
    /// </summary>
    [AllowNull]
    public Address PropertyAddress { get => GetField(ref _propertyAddress); set => SetField(ref _propertyAddress, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract Provider
    /// </summary>
    public StringEnumValue<EnhancedDisclosureTracking2015LogProvider> Provider { get => _provider; set => SetField(ref _provider, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract ProviderDescription
    /// </summary>
    public string? ProviderDescription { get => _providerDescription; set => SetField(ref _providerDescription, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract Snapshot
    /// </summary>
    public object? Snapshot { get => _snapshot; set => SetField(ref _snapshot, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract Status
    /// </summary>
    public StringEnumValue<EnhancedDisclosureTracking2015LogStatus> Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract Tracking
    /// </summary>
    [AllowNull]
    public TrackingFields Tracking { get => GetField(ref _tracking); set => SetField(ref _tracking, value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015LogContract UseForUcdExport
    /// </summary>
    public bool? UseForUcdExport { get => _useForUcdExport; set => SetField(ref _useForUcdExport, value); }
}