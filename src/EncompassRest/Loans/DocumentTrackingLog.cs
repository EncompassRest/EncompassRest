using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentTrackingLog
    /// </summary>
    public sealed partial class DocumentTrackingLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _action;
        private DirtyValue<string> _actionCd;
        private DirtyValue<string> _contact;
        private DirtyValue<bool?> _dOT;
        private DirtyValue<bool?> _email;
        private DirtyValue<bool?> _fTP;
        private DirtyValue<string> _id;
        private DirtyValue<string> _logBy;
        private DirtyValue<string> _logDate;
        private DirtyValue<string> _organization;
        private DirtyValue<bool?> _phone;
        private DirtyValue<DateTime?> _updatedDateUtc;

        /// <summary>
        /// DocumentTrackingLog Action
        /// </summary>
        public string Action { get => _action; set => SetField(ref _action, value); }

        /// <summary>
        /// DocumentTrackingLog ActionCd
        /// </summary>
        public string ActionCd { get => _actionCd; set => SetField(ref _actionCd, value); }

        /// <summary>
        /// DocumentTrackingLog Contact
        /// </summary>
        public string Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// DocumentTrackingLog DOT
        /// </summary>
        public bool? DOT { get => _dOT; set => SetField(ref _dOT, value); }

        /// <summary>
        /// DocumentTrackingLog Email
        /// </summary>
        public bool? Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// DocumentTrackingLog FTP
        /// </summary>
        public bool? FTP { get => _fTP; set => SetField(ref _fTP, value); }

        /// <summary>
        /// DocumentTrackingLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// DocumentTrackingLog LogBy
        /// </summary>
        public string LogBy { get => _logBy; set => SetField(ref _logBy, value); }

        /// <summary>
        /// DocumentTrackingLog LogDate
        /// </summary>
        public string LogDate { get => _logDate; set => SetField(ref _logDate, value); }

        /// <summary>
        /// DocumentTrackingLog Organization
        /// </summary>
        public string Organization { get => _organization; set => SetField(ref _organization, value); }

        /// <summary>
        /// DocumentTrackingLog Phone
        /// </summary>
        public bool? Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// DocumentTrackingLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}