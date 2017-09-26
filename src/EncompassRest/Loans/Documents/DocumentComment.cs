using System;
using System.Threading;

namespace EncompassRest.Loans.Documents
{
    public sealed class DocumentComment : IDirty
    {
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<int?> _forRoleId;
        public int? ForRoleId { get { return _forRoleId; } set { _forRoleId = value; } }
        private Value<Guid?> _commentId;
        public Guid? CommentId { get { return _commentId; } set { _commentId = value; } }
        private Value<DateTime?> _dateCreated;
        public DateTime? DateCreated { get { return _dateCreated; } set { _dateCreated = value; } }
        private Value<string> _createdBy;
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
        private Value<string> _createdByName;
        public string CreatedByName { get { return _createdByName; } set { _createdByName = value; } }
        private Value<DateTime?> _dateReviewed;
        public DateTime? DateReviewed { get { return _dateReviewed; } set { _dateReviewed = value; } }
        private Value<string> _reviewedBy;
        public string ReviewedBy { get { return _reviewedBy; } set { _reviewedBy = value; } }
        private int _gettingDirty;
        private int _settingDirty;
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _comments.Dirty
                    || _forRoleId.Dirty
                    || _commentId.Dirty
                    || _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _createdByName.Dirty
                    || _dateReviewed.Dirty
                    || _reviewedBy.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _comments.Dirty = value;
                _forRoleId.Dirty = value;
                _commentId.Dirty = value;
                _dateCreated.Dirty = value;
                _createdBy.Dirty = value;
                _createdByName.Dirty = value;
                _dateReviewed.Dirty = value;
                _reviewedBy.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}