using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// YesNoOrNA
    /// </summary>
    public enum YesNoOrNA
    {
        /// <summary>
        /// No
        /// </summary>
        No = 0,
        /// <summary>
        /// Yes
        /// </summary>
        Yes = 1,
        /// <summary>
        /// N/A
        /// </summary>
        [EnumMember(Value = "N/A")]
        NA = 2
    }
}