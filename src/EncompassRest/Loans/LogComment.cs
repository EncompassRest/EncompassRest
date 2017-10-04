using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LogComment : IDirty
    {
        private DirtyValue<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private DirtyValue<string> _addedByName;
        public string AddedByName { get { return _addedByName; } set { _addedByName = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private DirtyValue<int?> _forRoleId;
        public int? ForRoleId { get { return _forRoleId; } set { _forRoleId = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isInternal;
        public bool? IsInternal { get { return _isInternal; } set { _isInternal = value; } }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get { return _reviewedBy; } set { _reviewedBy = value; } }
        private DirtyValue<DateTime?> _reviewedDate;
        public DateTime? ReviewedDate { get { return _reviewedDate; } set { _reviewedDate = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _addedBy.Dirty
                    || _addedByName.Dirty
                    || _comments.Dirty
                    || _date.Dirty
                    || _forRoleId.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isInternal.Dirty
                    || _reviewedBy.Dirty
                    || _reviewedDate.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _addedBy.Dirty = value;
                _addedByName.Dirty = value;
                _comments.Dirty = value;
                _date.Dirty = value;
                _forRoleId.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isInternal.Dirty = value;
                _reviewedBy.Dirty = value;
                _reviewedDate.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}