using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// RiskGradeEvaluationType
    /// </summary>
    public enum RiskGradeEvaluationType
    {
        /// <summary>
        /// None
        /// </summary>
        [Description("None")]
        [EnumMember(Value = "00")]
        n00 = 0,
        /// <summary>
        /// General Electric Mortgage Insurance Corporation
        /// </summary>
        [Description("General Electric Mortgage Insurance Corporation")]
        [EnumMember(Value = "01")]
        n01 = 1,
        /// <summary>
        /// Verex
        /// </summary>
        [Description("Verex")]
        [EnumMember(Value = "05")]
        n05 = 5,
        /// <summary>
        /// PMI Mortgage Insurance Company
        /// </summary>
        [Description("PMI Mortgage Insurance Company")]
        [EnumMember(Value = "11")]
        n11 = 11,
        /// <summary>
        /// United Guaranty Residential Insurance
        /// </summary>
        [Description("United Guaranty Residential Insurance")]
        [EnumMember(Value = "12")]
        n12 = 12,
        /// <summary>
        /// Republic Mortgage Insurance Company
        /// </summary>
        [Description("Republic Mortgage Insurance Company")]
        [EnumMember(Value = "13")]
        n13 = 13,
        /// <summary>
        /// Wisconsin Mortgage Co
        /// </summary>
        [Description("Wisconsin Mortgage Co")]
        [EnumMember(Value = "16")]
        n16 = 16,
        /// <summary>
        /// Triad Guaranty Insurance Corporation
        /// </summary>
        [Description("Triad Guaranty Insurance Corporation")]
        [EnumMember(Value = "24")]
        n24 = 24,
        /// <summary>
        /// Radian Guaranty Inc
        /// </summary>
        [Description("Radian Guaranty Inc")]
        [EnumMember(Value = "33")]
        n33 = 33,
        /// <summary>
        /// Capital Mortgage Reinsurance
        /// </summary>
        [Description("Capital Mortgage Reinsurance")]
        [EnumMember(Value = "58")]
        n58 = 58,
        /// <summary>
        /// FHA Insured
        /// </summary>
        [Description("FHA Insured")]
        [EnumMember(Value = "91")]
        n91 = 91,
        /// <summary>
        /// VA Guaranteed
        /// </summary>
        [Description("VA Guaranteed")]
        [EnumMember(Value = "92")]
        n92 = 92,
        /// <summary>
        /// Lender Paid
        /// </summary>
        [Description("Lender Paid")]
        [EnumMember(Value = "98")]
        n98 = 98,
        /// <summary>
        /// Unknown
        /// </summary>
        [Description("Unknown")]
        [EnumMember(Value = "99")]
        n99 = 99
    }
}