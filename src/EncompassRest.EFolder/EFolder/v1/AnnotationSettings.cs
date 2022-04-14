using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.EFolder.v1
{
    /// <summary>
    /// AnnotationSettings
    /// </summary>
    public sealed class AnnotationSettings : ExtensibleObject
    {
        /// <summary>
        /// Defines the annotation visibility settings.
        /// </summary>
        public IList<StringEnumValue<AnnotationVisibilityType>> Visibility { get; }

        /// <summary>
        /// AnnotationSettings constructor.
        /// </summary>
        /// <param name="visibility">Defines the annotation visibility settings.</param>
        public AnnotationSettings(IEnumerable<AnnotationVisibilityType> visibility)
            : this(visibility?.Select(e => e.Validate(nameof(visibility)).GetValue())!)
        {
        }

        /// <summary>
        /// AnnotationSettings constructor.
        /// </summary>
        /// <param name="visibility">Defines the annotation visibility settings.</param>
        public AnnotationSettings(IEnumerable<string> visibility)
        {
            Preconditions.NotNull(visibility, nameof(visibility));

            Visibility = new ReadOnlyCollection<StringEnumValue<AnnotationVisibilityType>>(visibility.Select(v => new StringEnumValue<AnnotationVisibilityType>(v)).ToList());
        }
    }
}
