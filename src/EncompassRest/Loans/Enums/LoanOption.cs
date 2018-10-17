using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LoanOption
    /// </summary>
    public enum LoanOption
    {
        /// <summary>
        /// Loan Option 1
        /// </summary>
        [EnumMember(Value = "Loan Option 1")]
        LoanOption1 = 1,
        /// <summary>
        /// Loan Option 2
        /// </summary>
        [EnumMember(Value = "Loan Option 2")]
        LoanOption2 = 2,
        /// <summary>
        /// Loan Option 3
        /// </summary>
        [EnumMember(Value = "Loan Option 3")]
        LoanOption3 = 3,
        /// <summary>
        /// Loan Option 4
        /// </summary>
        [EnumMember(Value = "Loan Option 4")]
        LoanOption4 = 4,
        /// <summary>
        /// Other Option
        /// </summary>
        [EnumMember(Value = "Other Option")]
        OtherOption = 100
    }
}