using System.Runtime.Serialization;

namespace EncompassApi.Services.Verification
{
    /// <summary>
    /// EV4506TTaxReturnFor
    /// </summary>
    public enum EV4506TTaxReturnFor
    {
        /// <summary>
        /// borrower
        /// </summary>
        [EnumMember(Value = "borrower")]
        Borrower = 0,
        /// <summary>
        /// coBorrower
        /// </summary>
        [EnumMember(Value = "coBorrower")]
        CoBorrower = 1,
        /// <summary>
        /// joint
        /// </summary>
        [EnumMember(Value = "joint")]
        Joint = 2
    }
}