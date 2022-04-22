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
    /// <summary>
    /// EnhancedDisclosureTracking2015Log ApplicationDate
    /// </summary>
    public DateTime? ApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log ChangedCircumstanceIndicator
    /// </summary>
    public bool? ChangedCircumstanceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log ChangeInCircumstance
    /// </summary>
    public string? ChangeInCircumstance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log ChangeInCircumstanceComments
    /// </summary>
    public string? ChangeInCircumstanceComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log ClosingDisclosure
    /// </summary>
    [AllowNull]
    public ClosingDisclosureFields ClosingDisclosure { get => GetEntity<ClosingDisclosureFields>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log Contents
    /// </summary>
    [AllowNull]
    public IList<string?> Contents { get => GetList<string?>(); set => SetList(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosedApr
    /// </summary>
    [AllowNull]
    public LockableDecimalField DisclosedApr { get => GetEntity<LockableDecimalField>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosedBy
    /// </summary>
    [AllowNull]
    public LockableUserRefField DisclosedBy { get => GetEntity<LockableUserRefField>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosedDailyInterest
    /// </summary>
    [AllowNull]
    public LockableDecimalField DisclosedDailyInterest { get => GetEntity<LockableDecimalField>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosedDate
    /// </summary>
    [AllowNull]
    public DisclosedDateField DisclosedDate { get => GetEntity<DisclosedDateField>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosedFinanceCharge
    /// </summary>
    [AllowNull]
    public LockableDecimalField DisclosedFinanceCharge { get => GetEntity<LockableDecimalField>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosedMethod
    /// </summary>
    public StringEnumValue<DisclosedOrReceivedMethod> DisclosedMethod { get => GetValue<StringEnumValue<DisclosedOrReceivedMethod>>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosedMethodDescription
    /// </summary>
    public string? DisclosedMethodDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosureCreatedDate
    /// </summary>
    public DateTime? DisclosureCreatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosureRecipients
    /// </summary>
    [AllowNull]
    public IList<DisclosureRecipient> DisclosureRecipients { get => GetList<DisclosureRecipient>(); set => SetList(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log DisclosureType
    /// </summary>
    public StringEnumValue<EnhancedDisclosureTracking2015LogDisclosureType> DisclosureType { get => GetValue<StringEnumValue<EnhancedDisclosureTracking2015LogDisclosureType>>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log Documents
    /// </summary>
    [AllowNull]
    public DisclosureTrackingDocuments Documents { get => GetEntity<DisclosureTrackingDocuments>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log FeeChanges
    /// </summary>
    [AllowNull]
    public IList<DisclosureFeeChange> FeeChanges { get => GetList<DisclosureFeeChange>(); set => SetList(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log FeeLevelDisclosuresIndicator
    /// </summary>
    public bool? FeeLevelDisclosuresIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log Fulfillments
    /// </summary>
    [AllowNull]
    public IList<Fulfillment> Fulfillments { get => GetList<Fulfillment>(); set => SetList(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log IncludedInTimeline
    /// </summary>
    public bool? IncludedInTimeline { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log IntentToProceed
    /// </summary>
    [AllowNull]
    public IntentToProceed IntentToProceed { get => GetEntity<IntentToProceed>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log LinkedLogId
    /// </summary>
    public string? LinkedLogId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log LoanAmount
    /// </summary>
    public decimal? LoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log LoanEstimate
    /// </summary>
    [AllowNull]
    public LoanEstimateFields LoanEstimate { get => GetEntity<LoanEstimateFields>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log LoanProgram
    /// </summary>
    public string? LoanProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log LoanXml
    /// </summary>
    public string? LoanXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log PropertyAddress
    /// </summary>
    [AllowNull]
    public Address PropertyAddress { get => GetEntity<Address>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log Provider
    /// </summary>
    public StringEnumValue<EnhancedDisclosureTracking2015LogProvider> Provider { get => GetValue<StringEnumValue<EnhancedDisclosureTracking2015LogProvider>>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log ProviderDescription
    /// </summary>
    public string? ProviderDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log Status
    /// </summary>
    public StringEnumValue<EnhancedDisclosureTracking2015LogStatus> Status { get => GetValue<StringEnumValue<EnhancedDisclosureTracking2015LogStatus>>(); set => SetValue(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log Tracking
    /// </summary>
    [AllowNull]
    public TrackingFields Tracking { get => GetEntity<TrackingFields>(); set => SetEntity(value); }

    /// <summary>
    /// EnhancedDisclosureTracking2015Log UseForUcdExport
    /// </summary>
    public bool? UseForUcdExport { get => GetValue<bool?>(); set => SetValue(value); }
}