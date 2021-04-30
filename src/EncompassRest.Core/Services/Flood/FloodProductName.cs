using System.Runtime.Serialization;

namespace EncompassRest.Services.Flood
{
    /// <summary>
    /// FloodProductName
    /// </summary>
    public enum FloodProductName
    {
        /// <summary>
        /// Basic Determination
        /// </summary>
        [EnumMember(Value = "Basic Determination")]
        BasicDetermination = 25,
        /// <summary>
        /// Basic Determination w/ HMDA Information
        /// </summary>
        [EnumMember(Value = "Basic Determination w/ HMDA Information")]
        BasicDeterminationWHMDAInformation = 40,
        /// <summary>
        /// Life of Loan Determination
        /// </summary>
        [EnumMember(Value = "Life of Loan Determination")]
        LifeOfLoanDetermination = 26,
        /// <summary>
        /// Life of Loan Determination w/ HMDA Information
        /// </summary>
        [EnumMember(Value = "Life of Loan Determination w/ HMDA Information")]
        LifeOfLoanDeterminationWHMDAInformation = 41,
        /// <summary>
        /// Life of Loan Upgrade
        /// </summary>
        [EnumMember(Value = "Life of Loan Upgrade")]
        LifeOfLoanUpgrade = 129,
        /// <summary>
        /// 2nd Mortgage
        /// </summary>
        [EnumMember(Value = "2nd Mortgage")]
        SecondMortgage = 206,
        /// <summary>
        /// Refinance
        /// </summary>
        Refinance = 205
    }
}