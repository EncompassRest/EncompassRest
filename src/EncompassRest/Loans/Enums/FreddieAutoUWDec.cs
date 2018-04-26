using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieAutoUWDec
    /// </summary>
    public enum FreddieAutoUWDec
    {
        /// <summary>
        /// A1 Accept
        /// </summary>
        [EnumMember(Value = "A1 Accept")]
        A1Accept = 0,
        /// <summary>
        /// A2 Accept
        /// </summary>
        [EnumMember(Value = "A2 Accept")]
        A2Accept = 1,
        /// <summary>
        /// Accept
        /// </summary>
        Accept = 2,
        /// <summary>
        /// Approve
        /// </summary>
        Approve = 3,
        /// <summary>
        /// Approve Eligible
        /// </summary>
        [EnumMember(Value = "Approve Eligible")]
        ApproveEligible = 4,
        /// <summary>
        /// C1 Caution
        /// </summary>
        [EnumMember(Value = "C1 Caution")]
        C1Caution = 5,
        /// <summary>
        /// C2 Caution
        /// </summary>
        [EnumMember(Value = "C2 Caution")]
        C2Caution = 6,
        /// <summary>
        /// Caution
        /// </summary>
        Caution = 7,
        /// <summary>
        /// Caution Eligible For A Minus
        /// </summary>
        [EnumMember(Value = "Caution Eligible For A Minus")]
        CautionEligibleForAMinus = 8
    }
}