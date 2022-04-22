using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.Attachments.v1
{
    /// <summary>
    /// PageImage
    /// </summary>
    public sealed class PageImage : Image
    {
        /// <summary>
        /// The Native key.
        /// </summary>
        public string? NativeKey { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The rotation of the image.
        /// </summary>
        public int? Rotation { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The size of the image file.
        /// </summary>
        public long? FileSize { get => GetValue<long?>(); set => SetValue(value); }

        /// <summary>
        /// PageImage Thumbnail
        /// </summary>
        [AllowNull]
        public PageThumbnail Thumbnail { get => GetEntity<PageThumbnail>(); set => SetEntity(value); }

        /// <summary>
        /// PageImage Annotations
        /// </summary>
        [AllowNull]
        public IList<PageAnnotation> Annotations { get => GetList<PageAnnotation>(); set => SetList(value); }
    }
}