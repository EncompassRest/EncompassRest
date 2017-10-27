using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed class PageImage : Image
    {
        private DirtyValue<string> _nativeKey;
        public string NativeKey { get { return _nativeKey; } set { _nativeKey = value; } }
        private DirtyValue<int?> _rotation;
        public int? Rotation { get { return _rotation; } set { _rotation = value; } }
        private DirtyValue<long?> _fileSize;
        public long? FileSize { get { return _fileSize; } set { _fileSize = value; } }
        public PageThumbnail Thumbnail { get; set; }
        private DirtyList<PageAnnotation> _annotations;
        public IList<PageAnnotation> Annotations { get { return _annotations ?? (_annotations = new DirtyList<PageAnnotation>()); } set { _annotations = new DirtyList<PageAnnotation>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty;
        internal override bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = base.Dirty
                    || _nativeKey.Dirty
                    || _rotation.Dirty
                    || _fileSize.Dirty
                    || Thumbnail?.Dirty == true
                    || _annotations?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                base.Dirty = value;
                _nativeKey.Dirty = value;
                _rotation.Dirty = value;
                _fileSize.Dirty = value;
                if (Thumbnail != null) Thumbnail.Dirty = value;
                if (_annotations != null) _annotations.Dirty = value;
                _settingDirty = false;
            }
        }
    }
}