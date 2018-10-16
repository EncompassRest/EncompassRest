using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PostClosingConditionLog
    /// </summary>
    public sealed partial class PostClosingConditionLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _addedBy;
        private DirtyList<LogAlert> _alerts;
        private DirtyValue<string> _alertsXml;
        private DirtyValue<bool?> _cleared;
        private DirtyValue<string> _clearedBy;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _commentListXml;
        private DirtyValue<string> _comments;
        private DirtyValue<DateTime?> _dateAddedUtc;
        private DirtyValue<DateTime?> _dateClearedUtc;
        private DirtyValue<DateTime?> _dateExpected;
        private DirtyValue<DateTime?> _dateReceived;
        private DirtyValue<DateTime?> _dateRequestedUtc;
        private DirtyValue<DateTime?> _dateRerequestedUtc;
        private DirtyValue<DateTime?> _dateSentUtc;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<int?> _daysTillDue;
        private DirtyValue<string> _description;
        private DirtyValue<string> _details;
        private DirtyValue<bool?> _expected;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _isPastDue;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _pairId;
        private DirtyValue<bool?> _received;
        private DirtyValue<string> _receivedBy;
        private DirtyValue<string> _recipient;
        private DirtyValue<bool?> _requested;
        private DirtyValue<string> _requestedBy;
        private DirtyValue<string> _requestedFrom;
        private DirtyValue<bool?> _rerequested;
        private DirtyValue<string> _rerequestedBy;
        private DirtyValue<bool?> _sent;
        private DirtyValue<string> _sentBy;
        private DirtyValue<string> _source;
        private DirtyValue<string> _status;
        private DirtyValue<string> _statusDescription;
        private DirtyValue<string> _systemId;
        private DirtyValue<string> _title;
        private DirtyValue<DateTime?> _updatedDateUtc;

        /// <summary>
        /// PostClosingConditionLog AddedBy
        /// </summary>
        public string AddedBy { get => _addedBy; set => SetField(ref _addedBy, value); }

        /// <summary>
        /// PostClosingConditionLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// PostClosingConditionLog AlertsXml
        /// </summary>
        public string AlertsXml { get => _alertsXml; set => SetField(ref _alertsXml, value); }

        /// <summary>
        /// PostClosingConditionLog Cleared
        /// </summary>
        public bool? Cleared { get => _cleared; set => SetField(ref _cleared, value); }

        /// <summary>
        /// PostClosingConditionLog ClearedBy
        /// </summary>
        public string ClearedBy { get => _clearedBy; set => SetField(ref _clearedBy, value); }

        /// <summary>
        /// PostClosingConditionLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// PostClosingConditionLog CommentListXml
        /// </summary>
        public string CommentListXml { get => _commentListXml; set => SetField(ref _commentListXml, value); }

        /// <summary>
        /// PostClosingConditionLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// PostClosingConditionLog DateAddedUtc
        /// </summary>
        public DateTime? DateAddedUtc { get => _dateAddedUtc; set => SetField(ref _dateAddedUtc, value); }

        /// <summary>
        /// PostClosingConditionLog DateClearedUtc
        /// </summary>
        public DateTime? DateClearedUtc { get => _dateClearedUtc; set => SetField(ref _dateClearedUtc, value); }

        /// <summary>
        /// PostClosingConditionLog DateExpected
        /// </summary>
        public DateTime? DateExpected { get => _dateExpected; set => SetField(ref _dateExpected, value); }

        /// <summary>
        /// PostClosingConditionLog DateReceived
        /// </summary>
        public DateTime? DateReceived { get => _dateReceived; set => SetField(ref _dateReceived, value); }

        /// <summary>
        /// PostClosingConditionLog DateRequestedUtc
        /// </summary>
        public DateTime? DateRequestedUtc { get => _dateRequestedUtc; set => SetField(ref _dateRequestedUtc, value); }

        /// <summary>
        /// PostClosingConditionLog DateRerequestedUtc
        /// </summary>
        public DateTime? DateRerequestedUtc { get => _dateRerequestedUtc; set => SetField(ref _dateRerequestedUtc, value); }

        /// <summary>
        /// PostClosingConditionLog DateSentUtc
        /// </summary>
        public DateTime? DateSentUtc { get => _dateSentUtc; set => SetField(ref _dateSentUtc, value); }

        /// <summary>
        /// PostClosingConditionLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// PostClosingConditionLog DaysTillDue
        /// </summary>
        public int? DaysTillDue { get => _daysTillDue; set => SetField(ref _daysTillDue, value); }

        /// <summary>
        /// PostClosingConditionLog Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// PostClosingConditionLog Details
        /// </summary>
        public string Details { get => _details; set => SetField(ref _details, value); }

        /// <summary>
        /// PostClosingConditionLog Expected
        /// </summary>
        public bool? Expected { get => _expected; set => SetField(ref _expected, value); }

        /// <summary>
        /// PostClosingConditionLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// PostClosingConditionLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// PostClosingConditionLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PostClosingConditionLog IsPastDue
        /// </summary>
        public bool? IsPastDue { get => _isPastDue; set => SetField(ref _isPastDue, value); }

        /// <summary>
        /// PostClosingConditionLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// PostClosingConditionLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// PostClosingConditionLog PairId
        /// </summary>
        public string PairId { get => _pairId; set => SetField(ref _pairId, value); }

        /// <summary>
        /// PostClosingConditionLog Received
        /// </summary>
        public bool? Received { get => _received; set => SetField(ref _received, value); }

        /// <summary>
        /// PostClosingConditionLog ReceivedBy
        /// </summary>
        public string ReceivedBy { get => _receivedBy; set => SetField(ref _receivedBy, value); }

        /// <summary>
        /// PostClosingConditionLog Recipient
        /// </summary>
        public string Recipient { get => _recipient; set => SetField(ref _recipient, value); }

        /// <summary>
        /// PostClosingConditionLog Requested
        /// </summary>
        public bool? Requested { get => _requested; set => SetField(ref _requested, value); }

        /// <summary>
        /// PostClosingConditionLog RequestedBy
        /// </summary>
        public string RequestedBy { get => _requestedBy; set => SetField(ref _requestedBy, value); }

        /// <summary>
        /// PostClosingConditionLog RequestedFrom
        /// </summary>
        public string RequestedFrom { get => _requestedFrom; set => SetField(ref _requestedFrom, value); }

        /// <summary>
        /// PostClosingConditionLog Rerequested
        /// </summary>
        public bool? Rerequested { get => _rerequested; set => SetField(ref _rerequested, value); }

        /// <summary>
        /// PostClosingConditionLog RerequestedBy
        /// </summary>
        public string RerequestedBy { get => _rerequestedBy; set => SetField(ref _rerequestedBy, value); }

        /// <summary>
        /// PostClosingConditionLog Sent
        /// </summary>
        public bool? Sent { get => _sent; set => SetField(ref _sent, value); }

        /// <summary>
        /// PostClosingConditionLog SentBy
        /// </summary>
        public string SentBy { get => _sentBy; set => SetField(ref _sentBy, value); }

        /// <summary>
        /// PostClosingConditionLog Source
        /// </summary>
        public string Source { get => _source; set => SetField(ref _source, value); }

        /// <summary>
        /// PostClosingConditionLog Status
        /// </summary>
        public string Status { get => _status; set => SetField(ref _status, value); }

        /// <summary>
        /// PostClosingConditionLog StatusDescription
        /// </summary>
        public string StatusDescription { get => _statusDescription; set => SetField(ref _statusDescription, value); }

        /// <summary>
        /// PostClosingConditionLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// PostClosingConditionLog Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

        /// <summary>
        /// PostClosingConditionLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}