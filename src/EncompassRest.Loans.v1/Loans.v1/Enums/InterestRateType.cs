using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// InterestRateType
    /// </summary>
    public enum InterestRateType
    {
        /// <summary>
        /// Note Interest Rate
        /// </summary>
        [EnumMember(Value = "Note Interest Rate")]
        NoteInterestRate = 0,
        /// <summary>
        /// Prime Rate Plus
        /// </summary>
        [EnumMember(Value = "Prime Rate Plus")]
        PrimeRatePlus = 1,
        /// <summary>
        /// Other
        /// </summary>
        Other = 2
    }
}