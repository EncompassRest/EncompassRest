using System;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageAnnotation : ExtensibleObject
    {
        private DirtyValue<DateTime?> _dateCreated;
        public DateTime? DateCreated { get => _dateCreated; set => _dateCreated = value; }
        private DirtyValue<string> _createdBy;
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        private DirtyValue<string> _text;
        public string Text { get => _text; set => _text = value; }
        private DirtyValue<int?> _left;
        public int? Left { get => _left; set => _left = value; }
        private DirtyValue<int?> _top;
        public int? Top { get => _top; set => _top = value; }
        private DirtyValue<int?> _width;
        public int? Width { get => _width; set => _width = value; }
        private DirtyValue<int?> _height;
        public int? Height { get => _height; set => _height = value; }
        private DirtyValue<AnnotationVisibilityType?> _visibilityType;
        [EnumFormat(EnumFormat.DecimalValue)]
        public AnnotationVisibilityType? VisibilityType { get => _visibilityType; set => _visibilityType = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _text.Dirty
                    || _left.Dirty
                    || _top.Dirty
                    || _width.Dirty
                    || _height.Dirty
                    || _visibilityType.Dirty;
            }
            set
            {
                _dateCreated.Dirty = value;
                _createdBy.Dirty = value;
                _text.Dirty = value;
                _left.Dirty = value;
                _top.Dirty = value;
                _width.Dirty = value;
                _height.Dirty = value;
                _visibilityType.Dirty = value;
            }
        }
    }
}