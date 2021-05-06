using System.Runtime.Serialization;

namespace EncompassRest.Services.v1.Verification
{
    /// <summary>
    /// EVVOEEmployer
    /// </summary>
    public enum EVVOEEmployer
    {
        /// <summary>
        /// Current Employer(s)
        /// </summary>
        [EnumMember(Value = "Current Employer(s)")]
        Current = 0,
        /// <summary>
        /// Previous Employer(s)
        /// </summary>
        [EnumMember(Value = "Previous Employer(s)")]
        Previous = 1,
        /// <summary>
        /// Both (Current &amp; Previous)
        /// </summary>
        [EnumMember(Value = "Both (Current & Previous)")]
        CurrentAndPrevious = 2
    }
}