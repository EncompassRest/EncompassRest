using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// HUD1003AddendumApproved
    /// </summary>
    public enum HUD1003AddendumApproved
    {
        /// <summary>
        /// Approved
        /// </summary>
        Approved = 0,
        /// <summary>
        /// Modified And Approved
        /// </summary>
        [EnumMember(Value = "Modified And Approved")]
        ModifiedAndApproved = 1
    }
}