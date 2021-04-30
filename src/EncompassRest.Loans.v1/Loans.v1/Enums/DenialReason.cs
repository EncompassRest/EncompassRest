using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// DenialReason
    /// </summary>
    public enum DenialReason
    {
        /// <summary>
        /// 1. Debt-to-income ratio
        /// </summary>
        [Description("1. Debt-to-income ratio")]
        [EnumMember(Value = "Debt to Income Ratio")]
        DebtToIncomeRatio = 0,
        /// <summary>
        /// 2. Employment history
        /// </summary>
        [Description("2. Employment history")]
        [EnumMember(Value = "Employment history")]
        EmploymentHistory = 1,
        /// <summary>
        /// 3. Credit history
        /// </summary>
        [Description("3. Credit history")]
        [EnumMember(Value = "Credit history")]
        CreditHistory = 2,
        /// <summary>
        /// 4. Collateral
        /// </summary>
        [Description("4. Collateral")]
        Collateral = 3,
        /// <summary>
        /// 5. Insufficient cash (downpayment, closing costs)
        /// </summary>
        [Description("5. Insufficient cash (downpayment, closing costs)")]
        [EnumMember(Value = "Insufficient Cash")]
        InsufficientCash = 4,
        /// <summary>
        /// 6. Unverifiable information
        /// </summary>
        [Description("6. Unverifiable information")]
        [EnumMember(Value = "Unverifiable Information")]
        UnverifiableInformation = 5,
        /// <summary>
        /// 7. Credit application incomplete
        /// </summary>
        [Description("7. Credit application incomplete")]
        [EnumMember(Value = "Credit application Incomplete")]
        CreditApplicationIncomplete = 6,
        /// <summary>
        /// 8. Mortgage insurance denied
        /// </summary>
        [Description("8. Mortgage insurance denied")]
        [EnumMember(Value = "Mortgage insurance denied")]
        MortgageInsuranceDenied = 7,
        /// <summary>
        /// 9. Other
        /// </summary>
        [Description("9. Other")]
        Other = 8,
        /// <summary>
        /// 10. Not applicable
        /// </summary>
        [Description("10. Not applicable")]
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 9,
        /// <summary>
        /// 1111. Exempt
        /// </summary>
        [Description("1111. Exempt")]
        Exempt = 10
    }
}