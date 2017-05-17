using System.Collections.Generic;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageImage : Image
    {
        public string NativeKey { get; set; }
        public int? Rotation { get; set; }
        public long? FileSize { get; set; }
        public PageThumbnail Thumbnail { get; set; }
        public List<PageAnnotation> Annotations { get; set; }
    }
}