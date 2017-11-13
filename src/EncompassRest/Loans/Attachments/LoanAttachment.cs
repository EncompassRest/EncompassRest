using System;
using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class LoanAttachment : IDirty
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
        [EnumOutput(EnumOutput.Integer)]
        public AttachmentCreateReason? CreateReason { get => _createReason; set => _createReason = value; }
        private DirtyValue<AttachmentType?> _attachmentType;
        [EnumOutput(EnumOutput.Integer)]
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
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference Document { get; set; }
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
                var dirty = _attachmentId.Dirty
                    || _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _createdByName.Dirty
                    || _createReason.Dirty
                    || _attachmentType.Dirty
                    || _fileSize.Dirty
                    || _isActive.Dirty
                    || _pages?.Dirty == true
                    || _rotation.Dirty
                    || _title.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}