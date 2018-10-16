using System.Collections.Generic;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageImage : Image
    {
        private DirtyValue<string> _nativeKey;
        private DirtyValue<int?> _rotation;
        private DirtyValue<long?> _fileSize;
        private PageThumbnail _thumbnail;
        private DirtyList<PageAnnotation> _annotations;

        public string NativeKey { get => _nativeKey; set => SetField(ref _nativeKey, value); }

        public int? Rotation { get => _rotation; set => SetField(ref _rotation, value); }

        public long? FileSize { get => _fileSize; set => SetField(ref _fileSize, value); }

        public PageThumbnail Thumbnail { get => GetField(ref _thumbnail); set => SetField(ref _thumbnail, value); }

        public IList<PageAnnotation> Annotations { get => GetField(ref _annotations); set => SetField(ref _annotations, value); }
    }
}