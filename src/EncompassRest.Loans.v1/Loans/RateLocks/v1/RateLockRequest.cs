using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// RateLockRequest
    /// </summary>
    public sealed partial class RateLockRequest : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Unique identifier of the rate lock request.
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Lock request type. Possible values are: lock, re-lock, extension, trade, extension, cancellation
        /// </summary>
        public StringEnumValue<RequestType> RequestType { get => GetValue<StringEnumValue<RequestType>>(); set => SetValue(value); }

        /// <summary>
        /// Status of the rate lock before there is an action performed on the request. Possible values are not locked, active lock, cancelled lock, expired lock
        /// </summary>
        public StringEnumValue<RequestStatus> RequestStatus { get => GetValue<StringEnumValue<RequestStatus>>(); set => SetValue(value); }

        /// <summary>
        /// Status of the lock request. Possible values are: requested, locked, old lock, old request, expired, cancelled, extension requested, denied, registered, old registration
        /// </summary>
        public StringEnumValue<LockStatus> LockStatus { get => GetValue<StringEnumValue<LockStatus>>(); set => SetValue(value); }

        /// <summary>
        /// Indicates the total number of lock days for the request.
        /// </summary>
        public int? LockNumberOfDays { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Date on which the rate lock expires.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        public DateTime? LockExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The entityRefContract describing the entity or user who submitted the lock request.
        /// </summary>
        public EntityReference? RequestedBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// The date and time when the lock request is created.
        /// </summary>
        public DateTime? RequestedDate { get => GetValue<DateTime?>(); set => SetValue(value); }
        
        /// <summary>
        /// The date and time when lock request was fulfilled.
        /// </summary>
        public DateTime? FulfilledDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The entityRefContract describing the entity or user who fulfilled the lock request.
        /// </summary>
        public EntityReference? FulfilledBy { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Name of the Investor.
        /// </summary>
        public string? Investor { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Investor's delivery date.
        /// </summary>
        public DateTime? InvestorDeliveryDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Flags that indicate the status of the request. Possible values are:
        /// hideLog - Indicates the lock request log needs to be hidden)
        /// fakeRequest - Indicates the lock is created with/out a request
        /// lockExtension - Indicates the lock is extended.
        /// lockCancellation - Indicates the lock is cancelled.
        /// reLock - Indicates that the rate lock is re-locked.
        /// </summary>
        [AllowNull]
        public IList<StringEnumValue<RequestIndicator>> RequestIndicators { get => GetList<StringEnumValue<RequestIndicator>>(); set => SetList(value); }

        /// <summary>
        /// Object containing attributes that describe the parent lock request.
        /// </summary>
        public ParentRateLockRequest? ParentLockRequest { get => GetValue<ParentRateLockRequest?>(); set => SetValue(value); }

        /// <summary>
        /// Rate Lock CustomFields
        /// </summary>
        [AllowNull]
        public IList<CustomField> CustomFields { get => GetList<CustomField>(); set => SetList(value); }

        /// <summary>
        /// Investor's commitment.
        /// </summary>
        public string? InvestorCommitment { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Object containing attributes that describe loan information.
        /// </summary>
        public LoanInformation? LoanInformation { get => GetValue<LoanInformation?>(); set => SetValue(value); }

        /// <summary>
        /// Attributes that define the lock request.
        /// </summary>
        public LockRequest? LockRequest { get => GetValue<LockRequest?>(); set => SetValue(value); }

        /// <summary>
        /// Contains buy side attributes.
        /// </summary>
        public BuySide? BuySide { get => GetValue<BuySide?>(); set => SetValue(value); }

        /// <summary>
        /// Contains attributes that describe the rate lock sell side.
        /// </summary>
        public SellSide? SellSide { get => GetValue<SellSide?>(); set => SetValue(value); }

        /// <summary>
        /// Contains attributes that describe the rate lock comparison.
        /// </summary>
        public Comparison? Comparison { get => GetValue<Comparison?>(); set => SetValue(value); }
    }
}