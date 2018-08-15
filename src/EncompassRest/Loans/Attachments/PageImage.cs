using System.Collections.Generic;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageImage : Image
    {
        private DirtyValue<string> _nativeKey;
        public string NativeKey { get => _nativeKey; set => SetField(ref _nativeKey, value); }
        private DirtyValue<int?> _rotation;
        public int? Rotation { get => _rotation; set => SetField(ref _rotation, value); }
        private DirtyValue<long?> _fileSize;
        public long? FileSize { get => _fileSize; set => SetField(ref _fileSize, value); }
        public PageThumbnail Thumbnail { get; set; }
        private DirtyList<PageAnnotation> _annotations;
        public IList<PageAnnotation> Annotations { get => GetField(ref _annotations); set => SetField(ref _annotations, value); }
    }
}