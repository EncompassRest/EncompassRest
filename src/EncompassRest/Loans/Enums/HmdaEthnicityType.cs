using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// HmdaEthnicityType
    /// </summary>
    public enum HmdaEthnicityType
    {
        /// <summary>
        /// Hispanic or Latino
        /// </summary>
        [EnumMember(Value = "Hispanic or Latino")]
        HispanicOrLatino = 0,
        /// <summary>
        /// Not Hispanic or Latino
        /// </summary>
        [EnumMember(Value = "Not Hispanic or Latino")]
        NotHispanicOrLatino = 1,
        /// <summary>
        /// Information not provided
        /// </summary>
        [EnumMember(Value = "Information not provided")]
        InformationNotProvided = 2,
        /// <summary>
        /// Not applicable
        /// </summary>
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 3
    }
}