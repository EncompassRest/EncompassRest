using System.Threading;

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
        private int _gettingDirty;
        private int _settingDirty;
        internal virtual bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _imageKey.Dirty
                    || _zipKey.Dirty
                    || _width.Dirty
                    || _height.Dirty
                    || _horizontalResolution.Dirty
                    || _verticalResolution.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _imageKey.Dirty = value;
                _zipKey.Dirty = value;
                _width.Dirty = value;
                _height.Dirty = value;
                _horizontalResolution.Dirty = value;
                _verticalResolution.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}