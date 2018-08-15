using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentTrackingLog
    /// </summary>
    public sealed partial class DocumentTrackingLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _action;
        /// <summary>
        /// DocumentTrackingLog Action
        /// </summary>
        public string Action { get => _action; set => SetField(ref _action, value); }
        private DirtyValue<string> _actionCd;
        /// <summary>
        /// DocumentTrackingLog ActionCd
        /// </summary>
        public string ActionCd { get => _actionCd; set => SetField(ref _actionCd, value); }
        private DirtyValue<string> _contact;
        /// <summary>
        /// DocumentTrackingLog Contact
        /// </summary>
        public string Contact { get => _contact; set => SetField(ref _contact, value); }
        private DirtyValue<bool?> _dOT;
        /// <summary>
        /// DocumentTrackingLog DOT
        /// </summary>
        public bool? DOT { get => _dOT; set => SetField(ref _dOT, value); }
        private DirtyValue<bool?> _email;
        /// <summary>
        /// DocumentTrackingLog Email
        /// </summary>
        public bool? Email { get => _email; set => SetField(ref _email, value); }
        private DirtyValue<bool?> _fTP;
        /// <summary>
        /// DocumentTrackingLog FTP
        /// </summary>
        public bool? FTP { get => _fTP; set => SetField(ref _fTP, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// DocumentTrackingLog Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _logBy;
        /// <summary>
        /// DocumentTrackingLog LogBy
        /// </summary>
        public string LogBy { get => _logBy; set => SetField(ref _logBy, value); }
        private DirtyValue<string> _logDate;
        /// <summary>
        /// DocumentTrackingLog LogDate
        /// </summary>
        public string LogDate { get => _logDate; set => SetField(ref _logDate, value); }
        private DirtyValue<string> _organization;
        /// <summary>
        /// DocumentTrackingLog Organization
        /// </summary>
        public string Organization { get => _organization; set => SetField(ref _organization, value); }
        private DirtyValue<bool?> _phone;
        /// <summary>
        /// DocumentTrackingLog Phone
        /// </summary>
        public bool? Phone { get => _phone; set => SetField(ref _phone, value); }
    }
}