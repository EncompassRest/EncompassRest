using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// UlddBorrowerType
    /// </summary>
    public enum UlddBorrowerType
    {
        /// <summary>
        /// Individual
        /// </summary>
        Individual = 0,
        /// <summary>
        /// Legal Entity
        /// </summary>
        [EnumMember(Value = "Legal Entity")]
        LegalEntity = 1
    }
}