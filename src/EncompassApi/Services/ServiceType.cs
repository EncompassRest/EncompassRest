using System.Runtime.Serialization;

namespace EncompassApi.Services
{
    /// <summary>
    /// ServiceType
    /// </summary>
    public enum ServiceType
    {
        /// <summary>
        /// CREDITIQ
        /// </summary>
        [EnumMember(Value = "CREDITIQ")]
        Credit = 0,
        /// <summary>
        /// VERIF
        /// </summary>
        [EnumMember(Value = "VERIF")]
        Verification = 1,
        /// <summary>
        /// AUS
        /// </summary>
        AUS = 3,
        /// <summary>
        /// APPRAISAL
        /// </summary>
        [EnumMember(Value = "APPRAISAL")]
        Appraisal = 4,
        /// <summary>
        /// FLOOD
        /// </summary>
        [EnumMember(Value = "FLOOD")]
        Flood = 5
    }
}