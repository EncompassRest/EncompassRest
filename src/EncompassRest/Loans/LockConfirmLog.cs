#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LockConfirmLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _alertIndicator;
        public bool? AlertIndicator { get => _alertIndicator; set => _alertIndicator = value; }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyValue<DateTime?> _buySideExpirationDate;
        public DateTime? BuySideExpirationDate { get => _buySideExpirationDate; set => _buySideExpirationDate = value; }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _confirmedBy;
        public string ConfirmedBy { get => _confirmedBy; set => _confirmedBy = value; }
        private DirtyValue<bool?> _confirmedByIdIndicator;
        public bool? ConfirmedByIdIndicator { get => _confirmedByIdIndicator; set => _confirmedByIdIndicator = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _requestGuid;
        public string RequestGuid { get => _requestGuid; set => _requestGuid = value; }
        private DirtyValue<string> _sellSideDeliveredBy;
        public string SellSideDeliveredBy { get => _sellSideDeliveredBy; set => _sellSideDeliveredBy = value; }
        private DirtyValue<DateTime?> _sellSideDeliveryDate;
        public DateTime? SellSideDeliveryDate { get => _sellSideDeliveryDate; set => _sellSideDeliveryDate = value; }
        private DirtyValue<DateTime?> _sellSideExpirationDate;
        public DateTime? SellSideExpirationDate { get => _sellSideExpirationDate; set => _sellSideExpirationDate = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _timeConfirmed;
        public string TimeConfirmed { get => _timeConfirmed; set => _timeConfirmed = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _alertIndicator.Dirty
                    || _buySideExpirationDate.Dirty
                    || _comments.Dirty
                    || _confirmedBy.Dirty
                    || _confirmedByIdIndicator.Dirty
                    || _dateUtc.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _requestGuid.Dirty
                    || _sellSideDeliveredBy.Dirty
                    || _sellSideDeliveryDate.Dirty
                    || _sellSideExpirationDate.Dirty
                    || _systemId.Dirty
                    || _timeConfirmed.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true;
            }
            set
            {
                _alertIndicator.Dirty = value;
                _buySideExpirationDate.Dirty = value;
                _comments.Dirty = value;
                _confirmedBy.Dirty = value;
                _confirmedByIdIndicator.Dirty = value;
                _dateUtc.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _requestGuid.Dirty = value;
                _sellSideDeliveredBy.Dirty = value;
                _sellSideDeliveryDate.Dirty = value;
                _sellSideExpirationDate.Dirty = value;
                _systemId.Dirty = value;
                _timeConfirmed.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}