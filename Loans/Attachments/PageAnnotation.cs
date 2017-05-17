using System;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageAnnotation
    {
        public DateTime? DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string Text { get; set; }
        public int? Left { get; set; }
        public int? Top { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public AnnotationVisibilityType? VisibilityType { get; set; }
    }
}