using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// AUS
    /// </summary>
    public enum AUS
    {
        /// <summary>
        /// 1. Desktop Underwriter (DU)
        /// </summary>
        [Description("1. Desktop Underwriter (DU)")]
        DU = 0,
        /// <summary>
        /// 2. Loan Prospector (LP)
        /// </summary>
        [Description("2. Loan Prospector (LP)")]
        LP = 1,
        /// <summary>
        /// 3. Technology Open to Approved Lenders (TOTAL) Scorecard
        /// </summary>
        [Description("3. Technology Open to Approved Lenders (TOTAL) Scorecard")]
        TOTAL = 2,
        /// <summary>
        /// 4. Guaranteed Underwriting System (GUS)
        /// </summary>
        [Description("4. Guaranteed Underwriting System (GUS)")]
        GUS = 3,
        /// <summary>
        /// 5. Other
        /// </summary>
        [Description("5. Other")]
        Other = 4,
        /// <summary>
        /// 6. Not applicable
        /// </summary>
        [Description("6. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 5,
        /// <summary>
        /// 1111. Exempt
        /// </summary>
        [Description("1111. Exempt")]
        Exempt = 6,
        /// <summary>
        /// 7. Internal Proprietary System
        /// </summary>
        [Description("7. Internal Proprietary System")]
        [EnumMember(Value = "Internal Proprietary System")]
        InternalProprietarySystem = 7
    }
}