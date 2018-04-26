using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PriorLoanType
    /// </summary>
    public enum PriorLoanType
    {
        /// <summary>
        /// FHA-Fixed
        /// </summary>
        [EnumMember(Value = "FHA-Fixed")]
        FHAFixed = 0,
        /// <summary>
        /// FHA-ARM/HARM
        /// </summary>
        [EnumMember(Value = "FHA-ARM/HARM")]
        FHAARMHARM = 1,
        /// <summary>
        /// Conventional-Fixed
        /// </summary>
        [EnumMember(Value = "Conventional-Fixed")]
        ConventionalFixed = 2,
        /// <summary>
        /// Conventional-ARM/HARM
        /// </summary>
        [EnumMember(Value = "Conventional-ARM/HARM")]
        ConventionalARMHARM = 3,
        /// <summary>
        /// Conventional-Interest Only
        /// </summary>
        [EnumMember(Value = "Conventional-Interest Only")]
        ConventionalInterestOnly = 4,
        /// <summary>
        /// VA-Fixed
        /// </summary>
        [EnumMember(Value = "VA-Fixed")]
        VAFixed = 5,
        /// <summary>
        /// VA-ARM/HARM
        /// </summary>
        [EnumMember(Value = "VA-ARM/HARM")]
        VAARMHARM = 6,
        /// <summary>
        /// Other
        /// </summary>
        Other = 7
    }
}