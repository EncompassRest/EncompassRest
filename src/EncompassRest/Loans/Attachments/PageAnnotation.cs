using System;
using System.Collections.Generic;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class PageAnnotation : IDirty
    {
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => _dateCreated = value; }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        private DirtyValue<string> _text;
        public string Text { get => _text; set => _text = value; }
        private DirtyValue<int?> _left;
        public int? Left { get => _left; set => _left = value; }
        private DirtyValue<int?> _top;
        public int? Top { get => _top; set => _top = value; }
        private DirtyValue<int?> _width;
        public int? Width { get => _width; set => _width = value; }
        private DirtyValue<int?> _height;
        public int? Height { get => _height; set => _height = value; }
        private DirtyValue<AnnotationVisibilityType?> _visibilityType;
        [EnumFormat(EnumFormat.DecimalValue)]
        public AnnotationVisibilityType? VisibilityType { get => _visibilityType; set => _visibilityType = value; }
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
                var dirty = _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _text.Dirty
                    || _left.Dirty
                    || _top.Dirty
                    || _width.Dirty
                    || _height.Dirty
                    || _visibilityType.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _dateCreated.Dirty = value;
                _createdBy.Dirty = value;
                _text.Dirty = value;
                _left.Dirty = value;
                _top.Dirty = value;
                _width.Dirty = value;
                _height.Dirty = value;
                _visibilityType.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}