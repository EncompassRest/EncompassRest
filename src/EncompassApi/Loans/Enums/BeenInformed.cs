using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// BeenInformed
    /// </summary>
    public enum BeenInformed
    {
        /// <summary>
        /// The reasonable value of the property as determined by V.A.
        /// </summary>
        [EnumMember(Value = "The reasonable value of the property as determined by V.A.")]
        TheReasonableValueOfThePropertyAsDeterminedByVA = 0,
        /// <summary>
        /// The statement of appraised value as determined by HUD / FHA
        /// </summary>
        [EnumMember(Value = "The statement of appraised value as determined by HUD / FHA")]
        TheStatementOfAppraisedValueAsDeterminedByHUDFHA = 1
    }
}