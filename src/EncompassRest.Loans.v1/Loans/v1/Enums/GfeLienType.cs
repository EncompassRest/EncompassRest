using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// GfeLienType
    /// </summary>
    public enum GfeLienType
    {
        /// <summary>
        /// Undefined
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// BORROWER_LIENS
        /// </summary>
        [EnumMember(Value = "BORROWER_LIENS")]
        BORROWERLIENS = 1,
        /// <summary>
        /// PROPERTY_LIENS
        /// </summary>
        [EnumMember(Value = "PROPERTY_LIENS")]
        PROPERTYLIENS = 2
    }
}