using System;
using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageAnnotation : IDirty
    {
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get { return _dateCreated; } set { _dateCreated = value; } }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
        private DirtyValue<string> _text;
        public string Text { get { return _text; } set { _text = value; } }
        private DirtyValue<int?> _left;
        public int? Left { get { return _left; } set { _left = value; } }
        private DirtyValue<int?> _top;
        public int? Top { get { return _top; } set { _top = value; } }
        private DirtyValue<int?> _width;
        public int? Width { get { return _width; } set { _width = value; } }
        private DirtyValue<int?> _height;
        public int? Height { get { return _height; } set { _height = value; } }
        private DirtyValue<AnnotationVisibilityType?> _visibilityType;
        [EnumOutput(EnumOutput.Integer)]
        public AnnotationVisibilityType? VisibilityType { get { return _visibilityType; } set { _visibilityType = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
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
                    || _extensionDataInternal?.Dirty == true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}