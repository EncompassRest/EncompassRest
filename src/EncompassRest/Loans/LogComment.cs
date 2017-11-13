using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class LogComment : IDirty
    {
        private DirtyValue<string> _addedBy;
        public string AddedBy { get => _addedBy; set => _addedBy = value; }
        private DirtyValue<string> _addedByName;
        public string AddedByName { get => _addedByName; set => _addedByName = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<int?> _forRoleId;
        public int? ForRoleId { get => _forRoleId; set => _forRoleId = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isInternal;
        public bool? IsInternal { get => _isInternal; set => _isInternal = value; }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get => _reviewedBy; set => _reviewedBy = value; }
        private DirtyValue<DateTime?> _reviewedDate;
        public DateTime? ReviewedDate { get => _reviewedDate; set => _reviewedDate = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _addedBy.Dirty
                    || _addedByName.Dirty
                    || _comments.Dirty
                    || _date.Dirty
                    || _forRoleId.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isInternal.Dirty
                    || _reviewedBy.Dirty
                    || _reviewedDate.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}