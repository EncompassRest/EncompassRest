using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Documents
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class DocumentComment : IDirty
    {
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<int?> _forRoleId;
        public int? ForRoleId { get => _forRoleId; set => _forRoleId = value; }
        private DirtyValue<Guid?> _commentId;
        public Guid? CommentId { get => _commentId; set => _commentId = value; }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => _dateCreated = value; }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _dateReviewed;
        public DateTime? DateReviewed { get => _dateReviewed; set => _dateReviewed = value; }
        private DirtyValue<string> _reviewedBy;
        public string ReviewedBy { get => _reviewedBy; set => _reviewedBy = value; }
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
                var dirty = _comments.Dirty
                    || _forRoleId.Dirty
                    || _commentId.Dirty
                    || _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _createdByName.Dirty
                    || _dateReviewed.Dirty
                    || _reviewedBy.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _comments.Dirty = value;
                _forRoleId.Dirty = value;
                _commentId.Dirty = value;
                _dateCreated.Dirty = value;
                _createdBy.Dirty = value;
                _createdByName.Dirty = value;
                _dateReviewed.Dirty = value;
                _reviewedBy.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}