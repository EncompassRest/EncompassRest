using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// STDDownPaymentSectionRemark
    /// </summary>
    public enum STDDownPaymentSectionRemark
    {
        /// <summary>
        /// K
        /// </summary>
        K = 0,
        /// <summary>
        /// L
        /// </summary>
        L = 1,
        /// <summary>
        /// K and L
        /// </summary>
        [EnumMember(Value = "K and L")]
        KAndL = 2
    }
}