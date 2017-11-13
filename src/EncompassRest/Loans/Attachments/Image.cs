using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public abstract class Image : IDirty
    {
        private DirtyValue<string> _imageKey;
        public string ImageKey { get => _imageKey; set => _imageKey = value; }
        private DirtyValue<string> _zipKey;
        public string ZipKey { get => _zipKey; set => _zipKey = value; }
        private DirtyValue<int?> _width;
        public int? Width { get => _width; set => _width = value; }
        private DirtyValue<int?> _height;
        public int? Height { get => _height; set => _height = value; }
        private DirtyValue<float?> _horizontalResolution;
        public float? HorizontalResolution { get => _horizontalResolution; set => _horizontalResolution = value; }
        private DirtyValue<float?> _verticalResolution;
        public float? VeriticalResolution { get => _verticalResolution; set => _verticalResolution = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
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
                    || _extensionData?.Dirty == true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}