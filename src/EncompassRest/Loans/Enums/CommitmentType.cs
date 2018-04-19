using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CommitmentType
    /// </summary>
    public enum CommitmentType
    {
        /// <summary>
        /// Best Efforts
        /// </summary>
        [EnumMember(Value = "Best Efforts")]
        BestEfforts = 0,
        /// <summary>
        /// Mandatory
        /// </summary>
        Mandatory = 1
    }
}