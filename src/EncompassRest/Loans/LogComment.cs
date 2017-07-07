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
                var addedBy = _addedBy; addedBy.Clean = value; _addedBy = addedBy;
                var addedByName = _addedByName; addedByName.Clean = value; _addedByName = addedByName;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var date = _date; date.Clean = value; _date = date;
                var forRoleId = _forRoleId; forRoleId.Clean = value; _forRoleId = forRoleId;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var isInternal = _isInternal; isInternal.Clean = value; _isInternal = isInternal;
                var reviewedBy = _reviewedBy; reviewedBy.Clean = value; _reviewedBy = reviewedBy;
                var reviewedDate = _reviewedDate; reviewedDate.Clean = value; _reviewedDate = reviewedDate;
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