using System;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageAnnotation : DirtyExtensibleObject
    {
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }
        private DirtyValue<string> _text;
        public string Text { get => _text; set => SetField(ref _text, value); }
        private DirtyValue<int?> _left;
        public int? Left { get => _left; set => SetField(ref _left, value); }
        private DirtyValue<int?> _top;
        public int? Top { get => _top; set => SetField(ref _top, value); }
        private DirtyValue<int?> _width;
        public int? Width { get => _width; set => SetField(ref _width, value); }
        private DirtyValue<int?> _height;
        public int? Height { get => _height; set => SetField(ref _height, value); }
        private DirtyValue<AnnotationVisibilityType?> _visibilityType;
        [EnumFormat(EnumFormat.DecimalValue)]
        public AnnotationVisibilityType? VisibilityType { get => _visibilityType; set => SetField(ref _visibilityType, value); }
    }
}