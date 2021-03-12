using System;

namespace EncompassApi.Loans
{
    /// <summary>
    /// PurchaseConditionLog
    /// </summary>
    public sealed partial class PurchaseConditionLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?>? _allowToClearIndicator;
        private DirtyValue<string?>? _category;
        private DirtyValue<string?>? _clearedBy;
        private DirtyValue<DateTime?>? _dateClearedUtc;
        private DirtyValue<DateTime?>? _dateFulfilledUtc;
        private DirtyValue<DateTime?>? _dateRejectedUtc;
        private DirtyValue<DateTime?>? _dateReviewedUtc;
        private DirtyValue<DateTime?>? _dateWaivedUtc;
        private DirtyValue<int?>? _forRoleId;
        private DirtyValue<string?>? _fulfilledBy;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isExternalIndicator;
        private DirtyValue<bool?>? _isInternalIndicator;
        private DirtyValue<string?>? _priorTo;
        private DirtyValue<string?>? _rejectedBy;
        private DirtyValue<string?>? _reviewedBy;
        private DirtyValue<string?>? _waivedBy;

        /// <summary>
        /// PurchaseConditionLog AllowToClearIndicator
        /// </summary>
        public bool? AllowToClearIndicator { get => _allowToClearIndicator; set => SetField(ref _allowToClearIndicator, value); }

        /// <summary>
        /// PurchaseConditionLog Category
        /// </summary>
        public string? Category { get => _category; set => SetField(ref _category, value); }

        /// <summary>
        /// PurchaseConditionLog ClearedBy
        /// </summary>
        public string? ClearedBy { get => _clearedBy; set => SetField(ref _clearedBy, value); }

        /// <summary>
        /// PurchaseConditionLog DateClearedUtc
        /// </summary>
        public DateTime? DateClearedUtc { get => _dateClearedUtc; set => SetField(ref _dateClearedUtc, value); }

        /// <summary>
        /// PurchaseConditionLog DateFulfilledUtc
        /// </summary>
        public DateTime? DateFulfilledUtc { get => _dateFulfilledUtc; set => SetField(ref _dateFulfilledUtc, value); }

        /// <summary>
        /// PurchaseConditionLog DateRejectedUtc
        /// </summary>
        public DateTime? DateRejectedUtc { get => _dateRejectedUtc; set => SetField(ref _dateRejectedUtc, value); }

        /// <summary>
        /// PurchaseConditionLog DateReviewedUtc
        /// </summary>
        public DateTime? DateReviewedUtc { get => _dateReviewedUtc; set => SetField(ref _dateReviewedUtc, value); }

        /// <summary>
        /// PurchaseConditionLog DateWaivedUtc
        /// </summary>
        public DateTime? DateWaivedUtc { get => _dateWaivedUtc; set => SetField(ref _dateWaivedUtc, value); }

        /// <summary>
        /// PurchaseConditionLog ForRoleId
        /// </summary>
        public int? ForRoleId { get => _forRoleId; set => SetField(ref _forRoleId, value); }

        /// <summary>
        /// PurchaseConditionLog FulfilledBy
        /// </summary>
        public string? FulfilledBy { get => _fulfilledBy; set => SetField(ref _fulfilledBy, value); }

        /// <summary>
        /// PurchaseConditionLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PurchaseConditionLog IsExternalIndicator
        /// </summary>
        public bool? IsExternalIndicator { get => _isExternalIndicator; set => SetField(ref _isExternalIndicator, value); }

        /// <summary>
        /// PurchaseConditionLog IsInternalIndicator
        /// </summary>
        public bool? IsInternalIndicator { get => _isInternalIndicator; set => SetField(ref _isInternalIndicator, value); }

        /// <summary>
        /// PurchaseConditionLog PriorTo
        /// </summary>
        public string? PriorTo { get => _priorTo; set => SetField(ref _priorTo, value); }

        /// <summary>
        /// PurchaseConditionLog RejectedBy
        /// </summary>
        public string? RejectedBy { get => _rejectedBy; set => SetField(ref _rejectedBy, value); }

        /// <summary>
        /// PurchaseConditionLog ReviewedBy
        /// </summary>
        public string? ReviewedBy { get => _reviewedBy; set => SetField(ref _reviewedBy, value); }

        /// <summary>
        /// PurchaseConditionLog WaivedBy
        /// </summary>
        public string? WaivedBy { get => _waivedBy; set => SetField(ref _waivedBy, value); }
    }
}