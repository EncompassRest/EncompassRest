using System;
using System.Collections.Generic;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    public sealed class LoanAttachment : ExtensibleObject
    {
        private DirtyValue<string> _attachmentId;
        public string AttachmentId { get => _attachmentId; set => _attachmentId = value; }
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => _dateCreated = value; }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<AttachmentCreateReason?> _createReason;
        [EnumFormat(EnumFormat.DecimalValue)]
        public AttachmentCreateReason? CreateReason { get => _createReason; set => _createReason = value; }
        private DirtyValue<AttachmentType?> _attachmentType;
        [EnumFormat(EnumFormat.DecimalValue)]
        public AttachmentType? AttachmentType { get => _attachmentType; set => _attachmentType = value; }
        private DirtyValue<long?> _fileSize;
        public long? FileSize { get => _fileSize; set => _fileSize = value; }
        private DirtyValue<bool?> _isActive;
        public bool? IsActive { get => _isActive; set => _isActive = value; }
        private DirtyList<PageImage> _pages;
        public IList<PageImage> Pages { get => _pages ?? (_pages = new DirtyList<PageImage>()); set => _pages = new DirtyList<PageImage>(value); }
        private DirtyValue<int?> _rotation;
        public int? Rotation { get => _rotation; set => _rotation = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        private EntityReference _document;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference Document { get => _document; set => _document = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _attachmentId.Dirty
                    || _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _createdByName.Dirty
                    || _createReason.Dirty
                    || _attachmentType.Dirty
                    || _fileSize.Dirty
                    || _isActive.Dirty
                    || _pages?.Dirty == true
                    || _rotation.Dirty
                    || _title.Dirty;
            }
            set
            {
                _attachmentId.Dirty = value;
                _dateCreated.Dirty = value;
                _createdBy.Dirty = value;
                _createdByName.Dirty = value;
                _createReason.Dirty = value;
                _attachmentType.Dirty = value;
                _fileSize.Dirty = value;
                _isActive.Dirty = value;
                if (_pages != null) _pages.Dirty = value;
                _rotation.Dirty = value;
                _title.Dirty = value;
            }
        }
    }
}