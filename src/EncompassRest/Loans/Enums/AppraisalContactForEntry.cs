using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// AppraisalContactForEntry
    /// </summary>
    public enum AppraisalContactForEntry
    {
        /// <summary>
        /// Borrower
        /// </summary>
        Borrower = 0,
        /// <summary>
        /// CoBorrower
        /// </summary>
        CoBorrower = 1,
        /// <summary>
        /// Property Manager
        /// </summary>
        [EnumMember(Value = "Property Manager")]
        PropertyManager = 2,
        /// <summary>
        /// Real Estate Agent
        /// </summary>
        [EnumMember(Value = "Real Estate Agent")]
        RealEstateAgent = 3,
        /// <summary>
        /// Relative
        /// </summary>
        Relative = 4
    }
}