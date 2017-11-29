using System.Collections.Generic;
using Newtonsoft.Json;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageImage : Image
    {
        private DirtyValue<string> _nativeKey;
        public string NativeKey { get => _nativeKey; set => _nativeKey = value; }
        private DirtyValue<int?> _rotation;
        public int? Rotation { get => _rotation; set => _rotation = value; }
        private DirtyValue<long?> _fileSize;
        public long? FileSize { get => _fileSize; set => _fileSize = value; }
        public PageThumbnail Thumbnail { get; set; }
        private DirtyList<PageAnnotation> _annotations;
        public IList<PageAnnotation> Annotations { get => _annotations ?? (_annotations = new DirtyList<PageAnnotation>()); set => _annotations = new DirtyList<PageAnnotation>(value); }
        internal override bool DirtyInternal
        {
            get
            {
                return base.DirtyInternal
                    || _nativeKey.Dirty
                    || _rotation.Dirty
                    || _fileSize.Dirty
                    || Thumbnail?.Dirty == true
                    || _annotations?.Dirty == true;
            }
            set
            {
                base.DirtyInternal = value;
                _nativeKey.Dirty = value;
                _rotation.Dirty = value;
                _fileSize.Dirty = value;
                if (Thumbnail != null) Thumbnail.Dirty = value;
                if (_annotations != null) _annotations.Dirty = value;
            }
        }
    }
}