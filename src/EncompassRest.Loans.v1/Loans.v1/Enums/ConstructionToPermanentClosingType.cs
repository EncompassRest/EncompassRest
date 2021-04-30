using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ConstructionToPermanentClosingType
    /// </summary>
    public enum ConstructionToPermanentClosingType
    {
        /// <summary>
        /// One Closing
        /// </summary>
        [Description("One Closing")]
        OneClosing = 1,
        /// <summary>
        /// Two Closing
        /// </summary>
        [Description("Two Closing")]
        TwoClosing = 2
    }
}