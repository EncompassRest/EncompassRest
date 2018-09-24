using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LockConfirmLog
    /// </summary>
    public sealed partial class LockConfirmLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _alertIndicator;
        private DirtyList<LogAlert> _alerts;
        private DirtyValue<DateTime?> _buySideExpirationDate;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _comments;
        private DirtyValue<string> _confirmedBy;
        private DirtyValue<string> _confirmedById;
        private DirtyValue<bool?> _confirmedByIdIndicator;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _requestGuid;
        private DirtyValue<string> _sellSideDeliveredBy;
        private DirtyValue<DateTime?> _sellSideDeliveryDate;
        private DirtyValue<DateTime?> _sellSideExpirationDate;
        private DirtyValue<string> _systemId;
        private DirtyValue<string> _timeConfirmed;

        /// <summary>
        /// LockConfirmLog AlertIndicator
        /// </summary>
        public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }

        /// <summary>
        /// LockConfirmLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// LockConfirmLog BuySideExpirationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => SetField(ref _buySideExpirationDate, value); }

        /// <summary>
        /// LockConfirmLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// LockConfirmLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// LockConfirmLog ConfirmedBy
        /// </summary>
        public string ConfirmedBy { get => _confirmedBy; set => SetField(ref _confirmedBy, value); }

        /// <summary>
        /// LockConfirmLog ConfirmedById
        /// </summary>
        public string ConfirmedById { get => _confirmedById; set => SetField(ref _confirmedById, value); }

        /// <summary>
        /// LockConfirmLog ConfirmedByIdIndicator
        /// </summary>
        public bool? ConfirmedByIdIndicator { get => _confirmedByIdIndicator; set => SetField(ref _confirmedByIdIndicator, value); }

        /// <summary>
        /// LockConfirmLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// LockConfirmLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// LockConfirmLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// LockConfirmLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LockConfirmLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// LockConfirmLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// LockConfirmLog RequestGuid
        /// </summary>
        public string RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }

        /// <summary>
        /// LockConfirmLog SellSideDeliveredBy
        /// </summary>
        public string SellSideDeliveredBy { get => _sellSideDeliveredBy; set => SetField(ref _sellSideDeliveredBy, value); }

        /// <summary>
        /// LockConfirmLog SellSideDeliveryDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => SetField(ref _sellSideDeliveryDate, value); }

        /// <summary>
        /// LockConfirmLog SellSideExpirationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => SetField(ref _sellSideExpirationDate, value); }

        /// <summary>
        /// LockConfirmLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// LockConfirmLog TimeConfirmed
        /// </summary>
        public string TimeConfirmed { get => _timeConfirmed; set => SetField(ref _timeConfirmed, value); }
    }
}