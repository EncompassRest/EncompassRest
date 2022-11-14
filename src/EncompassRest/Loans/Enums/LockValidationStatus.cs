using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// LockValidationStatus
    /// </summary>
    public enum LockValidationStatus
    {
        /// <summary>
        /// Needs Validation
        /// </summary>
        [EnumMember(Value = "Needs Validation")]
        NeedsValidation = 0,
        /// <summary>
        /// Price Changed, still qualifies
        /// </summary>
        [EnumMember(Value = "Price Changed, still qualifies")]
        PriceChangedStillQualifies = 1,
        /// <summary>
        /// Loan no longer qualifies
        /// </summary>
        [EnumMember(Value = "Loan no longer qualifies")]
        LoanNoLongerQualifies = 2,
        /// <summary>
        /// No Price change, still qualifies
        /// </summary>
        [EnumMember(Value = "No Price change, still qualifies")]
        NoPriceChangeStillQualifies = 3
    }
}