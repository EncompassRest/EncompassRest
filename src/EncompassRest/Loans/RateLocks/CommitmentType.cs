using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// CommitmentTypes
    /// </summary>
    public enum CommitmentType
    {
        /// <summary>
        /// Mandatory
        /// </summary>
        [EnumMember(Value = "mandatory")]
        Mandatory = 0,
        /// <summary>
        /// Best Efforts
        /// </summary>
        [EnumMember(Value = "best Efforts")]
        BestEfforts = 1
        
    }
}