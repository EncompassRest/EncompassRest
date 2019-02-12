using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreOfferingIdentifier
    /// </summary>
    public enum FreOfferingIdentifier
    {
        /// <summary>
        /// 241:Home Possible
        /// </summary>
        [Description("241:Home Possible")]
        [EnumMember(Value = "241")]
        n241 = 241,
        /// <summary>
        /// 243:Home Possible Neighborhood Solution
        /// </summary>
        [Description("243:Home Possible Neighborhood Solution")]
        [EnumMember(Value = "243")]
        n243 = 243,
        /// <summary>
        /// 250:Home Possible Advantage
        /// </summary>
        [Description("250:Home Possible Advantage")]
        [EnumMember(Value = "250")]
        n250 = 250,
        /// <summary>
        /// 251:Home Possible Advantage for HFAs
        /// </summary>
        [Description("251:Home Possible Advantage for HFAs")]
        [EnumMember(Value = "251")]
        n251 = 251,
        /// <summary>
        /// 310:Relief Refinance - Open Access
        /// </summary>
        [Description("310:Relief Refinance - Open Access")]
        [EnumMember(Value = "310")]
        n310 = 310,
        /// <summary>
        /// 320:Enhanced Relief Refinance
        /// </summary>
        [Description("320:Enhanced Relief Refinance")]
        [EnumMember(Value = "320")]
        n320 = 320
    }
}