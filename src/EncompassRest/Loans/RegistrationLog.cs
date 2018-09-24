using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RegistrationLog
    /// </summary>
    public sealed partial class RegistrationLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert> _alerts;
        private DirtyList<LogComment> _commentList;
        private DirtyValue<string> _comments;
        private DirtyValue<bool?> _currentIndicator;
        private DirtyValue<DateTime?> _dateUtc;
        private DirtyValue<DateTime?> _expiredDate;
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        private DirtyValue<string> _guid;
        private DirtyValue<string> _id;
        private DirtyValue<string> _investorName;
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        private DirtyValue<int?> _logRecordIndex;
        private DirtyValue<string> _reference;
        private DirtyValue<string> _registeredById;
        private DirtyValue<string> _registeredByName;
        private DirtyValue<DateTime?> _registeredDate;
        private DirtyValue<string> _systemId;

        /// <summary>
        /// RegistrationLog Alerts
        /// </summary>
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// RegistrationLog CommentList
        /// </summary>
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// RegistrationLog Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// RegistrationLog CurrentIndicator
        /// </summary>
        public bool? CurrentIndicator { get => _currentIndicator; set => SetField(ref _currentIndicator, value); }

        /// <summary>
        /// RegistrationLog DateUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// RegistrationLog ExpiredDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ExpiredDate { get => _expiredDate; set => SetField(ref _expiredDate, value); }

        /// <summary>
        /// RegistrationLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// RegistrationLog Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// RegistrationLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// RegistrationLog InvestorName
        /// </summary>
        public string InvestorName { get => _investorName; set => SetField(ref _investorName, value); }

        /// <summary>
        /// RegistrationLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// RegistrationLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// RegistrationLog Reference
        /// </summary>
        public string Reference { get => _reference; set => SetField(ref _reference, value); }

        /// <summary>
        /// RegistrationLog RegisteredById
        /// </summary>
        public string RegisteredById { get => _registeredById; set => SetField(ref _registeredById, value); }

        /// <summary>
        /// RegistrationLog RegisteredByName
        /// </summary>
        public string RegisteredByName { get => _registeredByName; set => SetField(ref _registeredByName, value); }

        /// <summary>
        /// RegistrationLog RegisteredDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? RegisteredDate { get => _registeredDate; set => SetField(ref _registeredDate, value); }

        /// <summary>
        /// RegistrationLog SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}