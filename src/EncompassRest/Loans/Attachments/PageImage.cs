using System.Collections.Generic;
using System.Threading;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageImage : Image
    {
        private DirtyValue<string> _nativeKey;
        public string NativeKey { get { return _nativeKey; } set { _nativeKey = value; } }
        private DirtyValue<int?> _rotation;
        public int? Rotation { get { return _rotation; } set { _rotation = value; } }
        private DirtyValue<long?> _fileSize;
        public long? FileSize { get { return _fileSize; } set { _fileSize = value; } }
        public PageThumbnail Thumbnail { get; set; }
        private DirtyValue<List<PageAnnotation>> _annotations;
        public List<PageAnnotation> Annotations { get { return _annotations; } set { _annotations = value; } }
        private int _gettingDirty;
        private int _settingDirty;
        internal override bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = base.Dirty
                    || _nativeKey.Dirty
                    || _rotation.Dirty
                    || _fileSize.Dirty
                    || Thumbnail.Dirty
                    || _annotations.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                base.Dirty = value;
                _nativeKey.Dirty = value;
                _rotation.Dirty = value;
                _fileSize.Dirty = value;
                Thumbnail.Dirty = value;
                _annotations.Dirty = value;
                _settingDirty = 0;
            }
        }
    }
}