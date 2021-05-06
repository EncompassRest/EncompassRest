using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ConstructionToPermanentClosingFeatureType
    /// </summary>
    public enum ConstructionToPermanentClosingFeatureType
    {
        /// <summary>
        /// Automatic Conversion
        /// </summary>
        [Description("Automatic Conversion")]
        AutomaticConversion = 0,
        /// <summary>
        /// Modification Agreement
        /// </summary>
        [Description("Modification Agreement")]
        ModificationAgreement = 1,
        /// <summary>
        /// New Note
        /// </summary>
        [Description("New Note")]
        NewNote = 2
    }
}