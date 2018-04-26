using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RegistrationLog
    /// </summary>
    public sealed partial class RegistrationLog : ExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        /// <summary>
        /// RegistrationLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        /// <summary>
        /// RegistrationLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// RegistrationLog Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<bool?> _currentIndicator;
        /// <summary>
        /// RegistrationLog CurrentIndicator
        /// </summary>
        public bool? CurrentIndicator { get => _currentIndicator; set => _currentIndicator = value; }
        private DirtyValue<DateTime?> _dateUtc;
        /// <summary>
        /// RegistrationLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<DateTime?> _expiredDate;
        /// <summary>
        /// RegistrationLog ExpiredDate
        /// </summary>
        public DateTime? ExpiredDate { get => _expiredDate; set => _expiredDate = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        /// <summary>
        /// RegistrationLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// RegistrationLog Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// RegistrationLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _investorName;
        /// <summary>
        /// RegistrationLog InvestorName
        /// </summary>
        public string InvestorName { get => _investorName; set => _investorName = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        /// <summary>
        /// RegistrationLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        /// <summary>
        /// RegistrationLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _reference;
        /// <summary>
        /// RegistrationLog Reference
        /// </summary>
        public string Reference { get => _reference; set => _reference = value; }
        private DirtyValue<string> _registeredById;
        /// <summary>
        /// RegistrationLog RegisteredById
        /// </summary>
        public string RegisteredById { get => _registeredById; set => _registeredById = value; }
        private DirtyValue<string> _registeredByName;
        /// <summary>
        /// RegistrationLog RegisteredByName
        /// </summary>
        public string RegisteredByName { get => _registeredByName; set => _registeredByName = value; }
        private DirtyValue<DateTime?> _registeredDate;
        /// <summary>
        /// RegistrationLog RegisteredDate
        /// </summary>
        public DateTime? RegisteredDate { get => _registeredDate; set => _registeredDate = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// RegistrationLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get => _comments.Dirty
                || _currentIndicator.Dirty
                || _dateUtc.Dirty
                || _expiredDate.Dirty
                || _fileAttachmentsMigrated.Dirty
                || _guid.Dirty
                || _id.Dirty
                || _investorName.Dirty
                || _isSystemSpecificIndicator.Dirty
                || _logRecordIndex.Dirty
                || _reference.Dirty
                || _registeredById.Dirty
                || _registeredByName.Dirty
                || _registeredDate.Dirty
                || _systemId.Dirty
                || _alerts?.Dirty == true
                || _commentList?.Dirty == true;
            set
            {
                _comments.Dirty = value;
                _currentIndicator.Dirty = value;
                _dateUtc.Dirty = value;
                _expiredDate.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _investorName.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _reference.Dirty = value;
                _registeredById.Dirty = value;
                _registeredByName.Dirty = value;
                _registeredDate.Dirty = value;
                _systemId.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}