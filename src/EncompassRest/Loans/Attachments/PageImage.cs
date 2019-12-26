using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.Attachments
{
    /// <summary>
    /// PageImage
    /// </summary>
    public sealed class PageImage : Image
    {
        private DirtyValue<string?>? _nativeKey;
        private DirtyValue<int?>? _rotation;
        private DirtyValue<long?>? _fileSize;
        private PageThumbnail? _thumbnail;
        private DirtyList<PageAnnotation>? _annotations;

        /// <summary>
        /// The Native key.
        /// </summary>
        public string? NativeKey { get => _nativeKey; set => SetField(ref _nativeKey, value); }

        /// <summary>
        /// The rotation of the image.
        /// </summary>
        public int? Rotation { get => _rotation; set => SetField(ref _rotation, value); }

        /// <summary>
        /// The size of the image file.
        /// </summary>
        public long? FileSize { get => _fileSize; set => SetField(ref _fileSize, value); }

        /// <summary>
        /// PageImage Thumbnail
        /// </summary>
        [AllowNull]
        public PageThumbnail Thumbnail { get => GetField(ref _thumbnail); set => SetField(ref _thumbnail, value); }

        /// <summary>
        /// PageImage Annotations
        /// </summary>
        [AllowNull]
        public IList<PageAnnotation> Annotations { get => GetField(ref _annotations); set => SetField(ref _annotations, value); }
    }
}