using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PaymentOption
    /// </summary>
    public enum PaymentOption
    {
        /// <summary>
        /// Standard Front Loaded
        /// </summary>
        [EnumMember(Value = "Standard Front Loaded")]
        StandardFrontLoaded = 0,
        /// <summary>
        /// Level
        /// </summary>
        Level = 1,
        /// <summary>
        /// Life of Loan
        /// </summary>
        [EnumMember(Value = "Life of Loan")]
        LifeOfLoan = 2,
        /// <summary>
        /// Single Specific
        /// </summary>
        [EnumMember(Value = "Single Specific")]
        SingleSpecific = 3,
        /// <summary>
        /// Standard Back Loaded
        /// </summary>
        [EnumMember(Value = "Standard Back Loaded")]
        StandardBackLoaded = 4,
        /// <summary>
        /// Deferred
        /// </summary>
        Deferred = 5
    }
}