using System;
using System.Collections.Generic;
using System.Threading;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachment : IDirty
    {
        private Value<string> _attachmentId;
        public string AttachmentId { get { return _attachmentId; } set { _attachmentId = value; } }
        private Value<DateTime?> _dateCreated;
        public DateTime? DateCreated { get { return _dateCreated; } set { _dateCreated = value; } }
        private Value<string> _createdBy;
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
        private Value<string> _createdByName;
        public string CreatedByName { get { return _createdByName; } set { _createdByName = value; } }
        private Value<AttachmentCreateReason?> _createReason;
        [EnumOutput(EnumOutput.Integer)]
        public AttachmentCreateReason? CreateReason { get { return _createReason; } set { _createReason = value; } }
        private Value<AttachmentType?> _attachmentType;
        [EnumOutput(EnumOutput.Integer)]
        public AttachmentType? AttachmentType { get { return _attachmentType; } set { _attachmentType = value; } }
        private Value<long?> _fileSize;
        public long? FileSize { get { return _fileSize; } set { _fileSize = value; } }
        private Value<bool?> _isActive;
        public bool? IsActive { get { return _isActive; } set { _isActive = value; } }
        private Value<List<PageImage>> _pages;
        public List<PageImage> Pages { get { return _pages; } set { _pages = value; } }
        private Value<int?> _rotation;
        public int? Rotation { get { return _rotation; } set { _rotation = value; } }
        private Value<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference Document { get; set; }
        private int _gettingDirty;
        private int _settingDirty;
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _attachmentId.Dirty
                    || _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _createdByName.Dirty
                    || _createReason.Dirty
                    || _attachmentType.Dirty
                    || _fileSize.Dirty
                    || _isActive.Dirty
                    || _pages.Dirty
                    || _rotation.Dirty
                    || _title.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _attachmentId.Dirty = value;
                _dateCreated.Dirty = value;
                _createdBy.Dirty = value;
                _createdByName.Dirty = value;
                _createReason.Dirty = value;
                _attachmentType.Dirty = value;
                _fileSize.Dirty = value;
                _isActive.Dirty = value;
                _pages.Dirty = value;
                _rotation.Dirty = value;
                _title.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}