using System;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageAnnotation : DirtyExtensibleObject
    {
        private DirtyValue<DateTime?> _dateCreated;
        private DirtyValue<string> _createdBy;
        private DirtyValue<string> _text;
        private DirtyValue<int?> _left;
        private DirtyValue<int?> _top;
        private DirtyValue<int?> _width;
        private DirtyValue<int?> _height;
        private DirtyValue<AnnotationVisibilityType?> _visibilityType;

        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        public string CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        public string Text { get => _text; set => SetField(ref _text, value); }

        public int? Left { get => _left; set => SetField(ref _left, value); }

        public int? Top { get => _top; set => SetField(ref _top, value); }

        public int? Width { get => _width; set => SetField(ref _width, value); }

        public int? Height { get => _height; set => SetField(ref _height, value); }

        [EnumFormat(EnumFormat.DecimalValue)]
        public AnnotationVisibilityType? VisibilityType { get => _visibilityType; set => SetField(ref _visibilityType, value); }
    }
}