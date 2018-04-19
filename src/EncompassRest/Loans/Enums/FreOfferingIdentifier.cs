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
        /// 210:Alt 97
        /// </summary>
        [Description("210:Alt 97")]
        [EnumMember(Value = "210")]
        n210 = 210,
        /// <summary>
        /// 220:Freddie Mac 100
        /// </summary>
        [Description("220:Freddie Mac 100")]
        [EnumMember(Value = "220")]
        n220 = 220,
        /// <summary>
        /// 230:Initial Int 10/20 FIXED
        /// </summary>
        [Description("230:Initial Int 10/20 FIXED")]
        [EnumMember(Value = "230")]
        n230 = 230,
        /// <summary>
        /// 231:Initial Int 15/15 FIXED
        /// </summary>
        [Description("231:Initial Int 15/15 FIXED")]
        [EnumMember(Value = "231")]
        n231 = 231,
        /// <summary>
        /// 232:Initial Int ARM
        /// </summary>
        [Description("232:Initial Int ARM")]
        [EnumMember(Value = "232")]
        n232 = 232,
        /// <summary>
        /// 233:Initial Int ARM 10 Year
        /// </summary>
        [Description("233:Initial Int ARM 10 Year")]
        [EnumMember(Value = "233")]
        n233 = 233,
        /// <summary>
        /// 240:Home Possible 100
        /// </summary>
        [Description("240:Home Possible 100")]
        [EnumMember(Value = "240")]
        n240 = 240,
        /// <summary>
        /// 241:Home Possible
        /// </summary>
        [Description("241:Home Possible")]
        [EnumMember(Value = "241")]
        n241 = 241,
        /// <summary>
        /// 242:Home Possible Neighborhood Solutions 100
        /// </summary>
        [Description("242:Home Possible Neighborhood Solutions 100")]
        [EnumMember(Value = "242")]
        n242 = 242,
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