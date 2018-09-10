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
        /// <summary>
        /// LockConfirmLog AlertIndicator
        /// </summary>
        public bool? AlertIndicator { get => _alertIndicator; set => SetField(ref _alertIndicator, value); }
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// LockConfirmLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }
        private DirtyValue<DateTime?> _buySideExpirationDate;
        /// <summary>
        /// LockConfirmLog BuySideExpirationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => SetField(ref _buySideExpirationDate, value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// LockConfirmLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// LockConfirmLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _confirmedBy;
        /// <summary>
        /// LockConfirmLog ConfirmedBy
        /// </summary>
        public string ConfirmedBy { get => _confirmedBy; set => SetField(ref _confirmedBy, value); }
        private DirtyValue<string> _confirmedById;
        /// <summary>
        /// LockConfirmLog ConfirmedById
        /// </summary>
        public string ConfirmedById { get => _confirmedById; set => SetField(ref _confirmedById, value); }
        private DirtyValue<bool?> _confirmedByIdIndicator;
        /// <summary>
        /// LockConfirmLog ConfirmedByIdIndicator
        /// </summary>
        public bool? ConfirmedByIdIndicator { get => _confirmedByIdIndicator; set => SetField(ref _confirmedByIdIndicator, value); }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// LockConfirmLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// LockConfirmLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// LockConfirmLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LockConfirmLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// LockConfirmLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// LockConfirmLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }
        private DirtyValue<string> _requestGuid;
        /// <summary>
        /// LockConfirmLog RequestGuid
        /// </summary>
        public string RequestGuid { get => _requestGuid; set => SetField(ref _requestGuid, value); }
        private DirtyValue<string> _sellSideDeliveredBy;
        /// <summary>
        /// LockConfirmLog SellSideDeliveredBy
        /// </summary>
        public string SellSideDeliveredBy { get => _sellSideDeliveredBy; set => SetField(ref _sellSideDeliveredBy, value); }
        private DirtyValue<DateTime?> _sellSideDeliveryDate;
        /// <summary>
        /// LockConfirmLog SellSideDeliveryDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => SetField(ref _sellSideDeliveryDate, value); }
        private DirtyValue<DateTime?> _sellSideExpirationDate;
        /// <summary>
        /// LockConfirmLog SellSideExpirationDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => SetField(ref _sellSideExpirationDate, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// LockConfirmLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
        private DirtyValue<string> _timeConfirmed;
        /// <summary>
        /// LockConfirmLog TimeConfirmed
        /// </summary>
        public string TimeConfirmed { get => _timeConfirmed; set => SetField(ref _timeConfirmed, value); }
    }
}