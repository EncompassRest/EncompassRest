using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LogComment : IClean
    {
        private Value<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private Value<string> _addedByName;
        public string AddedByName { get { return _addedByName; } set { _addedByName = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private Value<int?> _forRoleId;
        public int? ForRoleId { get { return _forRoleId; } set { _forRoleId = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isInternal;
        public bool? IsInternal { get { return _isInternal; } set { _isInternal = value; } }
        private Value<string> _reviewedBy;
        public string ReviewedBy { get { return _reviewedBy; } set { _reviewedBy = value; } }
        private Value<DateTime?> _reviewedDate;
        public DateTime? ReviewedDate { get { return _reviewedDate; } set { _reviewedDate = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _addedBy.Clean
                    && _addedByName.Clean
                    && _comments.Clean
                    && _date.Clean
                    && _forRoleId.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _isInternal.Clean
                    && _reviewedBy.Clean
                    && _reviewedDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _addedBy; v0.Clean = value; _addedBy = v0;
                var v1 = _addedByName; v1.Clean = value; _addedByName = v1;
                var v2 = _comments; v2.Clean = value; _comments = v2;
                var v3 = _date; v3.Clean = value; _date = v3;
                var v4 = _forRoleId; v4.Clean = value; _forRoleId = v4;
                var v5 = _guid; v5.Clean = value; _guid = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _isInternal; v7.Clean = value; _isInternal = v7;
                var v8 = _reviewedBy; v8.Clean = value; _reviewedBy = v8;
                var v9 = _reviewedDate; v9.Clean = value; _reviewedDate = v9;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LogComment()
        {
            Clean = true;
        }
    }
}