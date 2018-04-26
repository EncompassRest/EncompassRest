using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CreditReportCompany
    /// </summary>
    public enum CreditReportCompany
    {
        /// <summary>
        /// CBC Companies
        /// </summary>
        [Description("CBC Companies")]
        [EnumMember(Value = "1")]
        n1 = 1,
        /// <summary>
        /// Fidelity National Credit
        /// </summary>
        [Description("Fidelity National Credit")]
        [EnumMember(Value = "4")]
        n4 = 4,
        /// <summary>
        /// Equifax Mortgage Information Services
        /// </summary>
        [Description("Equifax Mortgage Information Services")]
        [EnumMember(Value = "5")]
        n5 = 5,
        /// <summary>
        /// Factual Data
        /// </summary>
        [Description("Factual Data")]
        [EnumMember(Value = "6")]
        n6 = 6,
        /// <summary>
        /// First American Credco
        /// </summary>
        [Description("First American Credco")]
        [EnumMember(Value = "8")]
        n8 = 8,
        /// <summary>
        /// LandAmerica Credit Services- Info1
        /// </summary>
        [Description("LandAmerica Credit Services- Info1")]
        A = 100,
        /// <summary>
        /// LandSafe
        /// </summary>
        [Description("LandSafe")]
        B = 101
    }
}