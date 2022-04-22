using System;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Attachments.v1
{
    /// <summary>
    /// PageAnnotation
    /// </summary>
    public sealed class PageAnnotation : DirtyExtensibleObject
    {
        /// <summary>
        /// Date the attachment or page annotation was created.
        /// </summary>
        public DateTime? DateCreated { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// UserID of the user who created the attachment or annotation.
        /// </summary>
        public string? CreatedBy { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The text of the annotation.
        /// </summary>
        public string? Text { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The horizontal location of the annotation.
        /// </summary>
        public int? Left { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The vertical location of the annotation.
        /// </summary>
        public int? Top { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The width of the annotation.
        /// </summary>
        public int? Width { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The height of the annotation.
        /// </summary>
        public int? Height { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// The visibility type of the annotation.
        /// </summary>
        [EnumFormat(EnumFormat.DecimalValue)]
        public AnnotationVisibilityType? VisibilityType { get => GetValue<AnnotationVisibilityType?>(); set => SetValue(value); }
    }
}