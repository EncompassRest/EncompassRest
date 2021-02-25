using System;
using EncompassApi.Utilities;
using EnumsNET;

namespace EncompassApi.Loans.Attachments
{
    /// <summary>
    /// PageAnnotation
    /// </summary>
    public sealed class PageAnnotation : DirtyExtensibleObject
    {
        private DirtyValue<DateTime?>? _dateCreated;
        private DirtyValue<string?>? _createdBy;
        private DirtyValue<string?>? _text;
        private DirtyValue<int?>? _left;
        private DirtyValue<int?>? _top;
        private DirtyValue<int?>? _width;
        private DirtyValue<int?>? _height;
        private DirtyValue<AnnotationVisibilityType?>? _visibilityType;

        /// <summary>
        /// Date the attachment or page annotation was created.
        /// </summary>
        public DateTime? DateCreated { get => _dateCreated; set => SetField(ref _dateCreated, value); }

        /// <summary>
        /// UserID of the user who created the attachment or annotation.
        /// </summary>
        public string? CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        /// <summary>
        /// The text of the annotation.
        /// </summary>
        public string? Text { get => _text; set => SetField(ref _text, value); }

        /// <summary>
        /// The horizontal location of the annotation.
        /// </summary>
        public int? Left { get => _left; set => SetField(ref _left, value); }

        /// <summary>
        /// The vertical location of the annotation.
        /// </summary>
        public int? Top { get => _top; set => SetField(ref _top, value); }

        /// <summary>
        /// The width of the annotation.
        /// </summary>
        public int? Width { get => _width; set => SetField(ref _width, value); }

        /// <summary>
        /// The height of the annotation.
        /// </summary>
        public int? Height { get => _height; set => SetField(ref _height, value); }

        /// <summary>
        /// The visibility type of the annotation.
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public AnnotationVisibilityType? VisibilityType { get => _visibilityType; set => SetField(ref _visibilityType, value); }
    }
}