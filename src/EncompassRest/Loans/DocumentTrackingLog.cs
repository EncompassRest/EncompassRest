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
        public string Action { get => _action; set => _action = value; }
        private DirtyValue<string> _actionCd;
        /// <summary>
        /// DocumentTrackingLog ActionCd
        /// </summary>
        public string ActionCd { get => _actionCd; set => _actionCd = value; }
        private DirtyValue<string> _contact;
        /// <summary>
        /// DocumentTrackingLog Contact
        /// </summary>
        public string Contact { get => _contact; set => _contact = value; }
        private DirtyValue<bool?> _dOT;
        /// <summary>
        /// DocumentTrackingLog DOT
        /// </summary>
        public bool? DOT { get => _dOT; set => _dOT = value; }
        private DirtyValue<bool?> _email;
        /// <summary>
        /// DocumentTrackingLog Email
        /// </summary>
        public bool? Email { get => _email; set => _email = value; }
        private DirtyValue<bool?> _fTP;
        /// <summary>
        /// DocumentTrackingLog FTP
        /// </summary>
        public bool? FTP { get => _fTP; set => _fTP = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// DocumentTrackingLog Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _logBy;
        /// <summary>
        /// DocumentTrackingLog LogBy
        /// </summary>
        public string LogBy { get => _logBy; set => _logBy = value; }
        private DirtyValue<string> _logDate;
        /// <summary>
        /// DocumentTrackingLog LogDate
        /// </summary>
        public string LogDate { get => _logDate; set => _logDate = value; }
        private DirtyValue<string> _organization;
        /// <summary>
        /// DocumentTrackingLog Organization
        /// </summary>
        public string Organization { get => _organization; set => _organization = value; }
        private DirtyValue<bool?> _phone;
        /// <summary>
        /// DocumentTrackingLog Phone
        /// </summary>
        public bool? Phone { get => _phone; set => _phone = value; }
        internal override bool DirtyInternal
        {
            get => _action.Dirty
                || _actionCd.Dirty
                || _contact.Dirty
                || _dOT.Dirty
                || _email.Dirty
                || _fTP.Dirty
                || _id.Dirty
                || _logBy.Dirty
                || _logDate.Dirty
                || _organization.Dirty
                || _phone.Dirty;
            set
            {
                _action.Dirty = value;
                _actionCd.Dirty = value;
                _contact.Dirty = value;
                _dOT.Dirty = value;
                _email.Dirty = value;
                _fTP.Dirty = value;
                _id.Dirty = value;
                _logBy.Dirty = value;
                _logDate.Dirty = value;
                _organization.Dirty = value;
                _phone.Dirty = value;
            }
        }
    }
}