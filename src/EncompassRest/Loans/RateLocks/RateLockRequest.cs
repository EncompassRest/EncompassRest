using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// RateLockRequest
    /// </summary>
    public sealed partial class RateLockRequest : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _id;
        private DirtyValue<StringEnumValue<RequestType>>? _requestType;
        private DirtyValue<StringEnumValue<RequestStatus>>? _requestStatus;
        private DirtyValue<StringEnumValue<LockStatus>>? _lockStatus;
        private DirtyValue<int?>? _lockNumberOfDays;
        private DirtyValue<DateTime?>? _lockExpirationDate;
        private DirtyValue<EntityReference?>? _requestedBy;
        private DirtyValue<DateTime?>? _requestedDate;
        private DirtyValue<DateTime?>? _fulfilledDate;
        private DirtyValue<EntityReference?>? _fulfilledBy;
        private DirtyValue<string?>? _investor;
        private DirtyValue<DateTime?>? _investorDeliveryDate;
        private DirtyValue<List<string>?>? _requestIndicators;
        private DirtyValue<ParentRateLockRequest?>? _parentLockRequest;
        private DirtyList<CustomField>? _customFields;
        private DirtyValue<string?>? _investorCommitment;
        private DirtyValue<LoanInformation?>? _loanInformation;
        private DirtyValue<LockRequest?>? _lockRequest;
        private DirtyValue<BuySide?>? _buySide;
        private DirtyValue<SellSide?>? _sellSide;
        private DirtyValue<Comparison?>? _comparison;

        /// <summary>
        /// Unique identifier of the rate lock request.
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Lock request type. Possible values are: lock, re-lock, extension, trade, extension, cancellation
        /// </summary>
        public StringEnumValue<RequestType> RequestType { get => _requestType; set => SetField(ref _requestType, value); }

        /// <summary>
        /// Status of the rate lock before there is an action performed on the request. Possible values are not locked, active lock, cancelled lock, expired lock
        /// </summary>
        public StringEnumValue<RequestStatus> RequestStatus { get => _requestStatus; set => SetField(ref _requestStatus, value); }

        /// <summary>
        /// Status of the lock request. Possible values are: requested, locked, old lock, old request, expired, cancelled, extension requested, denied, registered, old registration
        /// </summary>
        public StringEnumValue<LockStatus> LockStatus { get => _lockStatus; set => SetField(ref _lockStatus, value); }

        /// <summary>
        /// Indicates the total number of lock days for the request.
        /// </summary>
        public int? LockNumberOfDays { get => _lockNumberOfDays; set => SetField(ref _lockNumberOfDays, value); }

        /// <summary>
        /// Date on which the rate lock expires.
        /// </summary>
        public DateTime? LockExpirationDate { get => _lockExpirationDate; set => SetField(ref _lockExpirationDate, value); }

        /// <summary>
        /// The entityRefContract describing the entity or user who submitted the lock request.
        /// </summary>
        public EntityReference? RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// The date and time when the lock request is created.
        /// </summary>
        public DateTime? RequestedDate { get => _requestedDate; set => SetField(ref _requestedDate, value); }
        
        /// <summary>
        /// The date and time when lock request was fulfilled.
        /// </summary>
        public DateTime? FulfilledDate { get => _fulfilledDate; set => SetField(ref _fulfilledDate, value); }

        /// <summary>
        /// The entityRefContract describing the entity or user who fulfilled the lock request.
        /// </summary>
        public EntityReference? FulfilledBy { get => _fulfilledBy; set => SetField(ref _fulfilledBy, value); }

        /// <summary>
        /// Name of the Investor.
        /// </summary>
        public string? Investor { get => _investor; set => SetField(ref _investor, value); }

        /// <summary>
        /// Investor's delivery date.
        /// </summary>
        public DateTime? InvestorDeliveryDate { get => _investorDeliveryDate; set => SetField(ref _investorDeliveryDate, value); }

        /// <summary>
        /// Flags that indicate the status of the request. Possible values are:
        /// hideLog - Indicates the lock request log needs to be hidden)
        /// fakeRequest - Indicates the lock is created with/out a request
        /// lockExtension - Indicates the lock is extended.
        /// lockCancellation - Indicates the lock is cancelled.
        /// reLock - Indicates that the rate lock is re-locked.
        /// </summary>
        public List<string>? RequestIndicators { get => _requestIndicators; set => SetField(ref _requestIndicators, value); }

        /// <summary>
        /// Object containing attributes that describe the parent lock request.
        /// </summary>
        public ParentRateLockRequest? ParentLockRequest { get => _parentLockRequest; set => SetField(ref _parentLockRequest, value); }

        /// <summary>
        /// Rate Lock CustomFields
        /// </summary>
        [AllowNull]
        public IList<CustomField> CustomFields { get => GetField(ref _customFields); set => SetField(ref _customFields, value); }

        /// <summary>
        /// Investor's commitment.
        /// </summary>
        public string? InvestorCommitment { get => _investorCommitment; set => SetField(ref _investorCommitment, value); }

        /// <summary>
        /// Object containing attributes that describe loan information.
        /// </summary>
        public LoanInformation? LoanInformation { get => _loanInformation; set => SetField(ref _loanInformation, value); }

        /// <summary>
        /// Attributes that define the lock request.
        /// </summary>
        public LockRequest? LockRequest { get => _lockRequest; set => SetField(ref _lockRequest, value); }

        /// <summary>
        /// Contains buy side attributes.
        /// </summary>
        public BuySide? BuySide { get => _buySide; set => SetField(ref _buySide, value); }

        /// <summary>
        /// Contains attributes that describe the rate lock sell side.
        /// </summary>
        public SellSide? SellSide { get => _sellSide; set => SetField(ref _sellSide, value); }

        /// <summary>
        /// Contains attributes that describe the rate lock comparison.
        /// </summary>
        public Comparison? Comparison { get => _comparison; set => SetField(ref _comparison, value); }
    }

}