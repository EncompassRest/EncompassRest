using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// AddendumType
    /// </summary>
    public enum AddendumType
    {
        /// <summary>
        /// V.A.
        /// </summary>
        [EnumMember(Value = "V.A.")]
        VA = 0,
        /// <summary>
        /// HUD / FHA
        /// </summary>
        [EnumMember(Value = "HUD / FHA")]
        HUDFHA = 1
    }
}