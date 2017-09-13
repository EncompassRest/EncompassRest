using System;
using System.Threading;

namespace EncompassRest.Loans.Attachments
{
    public sealed class PageAnnotation : IDirty
    {
        private Value<DateTime?> _dateCreated;
        public DateTime? DateCreated { get { return _dateCreated; } set { _dateCreated = value; } }
        private Value<string> _createdBy;
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
        private Value<string> _text;
        public string Text { get { return _text; } set { _text = value; } }
        private Value<int?> _left;
        public int? Left { get { return _left; } set { _left = value; } }
        private Value<int?> _top;
        public int? Top { get { return _top; } set { _top = value; } }
        private Value<int?> _width;
        public int? Width { get { return _width; } set { _width = value; } }
        private Value<int?> _height;
        public int? Height { get { return _height; } set { _height = value; } }
        private Value<AnnotationVisibilityType?> _visibilityType;
        public AnnotationVisibilityType? VisibilityType { get { return _visibilityType; } set { _visibilityType = value; } }
        private int _gettingDirty;
        private int _settingDirty;
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _dateCreated.Dirty
                    || _createdBy.Dirty
                    || _text.Dirty
                    || _left.Dirty
                    || _top.Dirty
                    || _width.Dirty
                    || _height.Dirty
                    || _visibilityType.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _dateCreated.Dirty = value;
                _createdBy.Dirty = value;
                _text.Dirty = value;
                _left.Dirty = value;
                _top.Dirty = value;
                _width.Dirty = value;
                _height.Dirty = value;
                _visibilityType.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}