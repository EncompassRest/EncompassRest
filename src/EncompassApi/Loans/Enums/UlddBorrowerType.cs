using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
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