using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    public abstract class Image : IDirty
    {
        private DirtyValue<string> _imageKey;
        public string ImageKey { get { return _imageKey; } set { _imageKey = value; } }
        private DirtyValue<string> _zipKey;
        public string ZipKey { get { return _zipKey; } set { _zipKey = value; } }
        private DirtyValue<int?> _width;
        public int? Width { get { return _width; } set { _width = value; } }
        private DirtyValue<int?> _height;
        public int? Height { get { return _height; } set { _height = value; } }
        private DirtyValue<float?> _horizontalResolution;
        public float? HorizontalResolution { get { return _horizontalResolution; } set { _horizontalResolution = value; } }
        private DirtyValue<float?> _verticalResolution;
        public float? VeriticalResolution { get { return _verticalResolution; } set { _verticalResolution = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal virtual bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _imageKey.Dirty
                    || _zipKey.Dirty
                    || _width.Dirty
                    || _height.Dirty
                    || _horizontalResolution.Dirty
                    || _verticalResolution.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _imageKey.Dirty = value;
                _zipKey.Dirty = value;
                _width.Dirty = value;
                _height.Dirty = value;
                _horizontalResolution.Dirty = value;
                _verticalResolution.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}