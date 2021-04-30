using System.Runtime.Serialization;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// AtrSmallCreditors
    /// </summary>
    public enum AtrSmallCreditors
    {
        /// <summary>
        /// Small Creditor
        /// </summary>
        [EnumMember(Value = "Small Creditor")]
        SmallCreditor = 0,
        /// <summary>
        /// Rural Small Creditor
        /// </summary>
        [EnumMember(Value = "Rural Small Creditor")]
        RuralSmallCreditor = 1
    }
}