using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FreOfferingIdentifier
/// </summary>
public enum FreOfferingIdentifier
{
    /// <summary>
    /// CHOICEHome
    /// </summary>
    CHOICEHome = 0,
    /// <summary>
    /// CHOICERenovation
    /// </summary>
    CHOICERenovation = 1,
    /// <summary>
    /// Community Land Trust
    /// </summary>
    [Description("Community Land Trust")]
    CommunityLandTrust = 2,
    /// <summary>
    /// GreenCHOICE
    /// </summary>
    GreenCHOICE = 3,
    /// <summary>
    /// Refi Possible
    /// </summary>
    [EnumMember(Value = "Refi Possible")]
    RefiPossible = 4,
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
    /// 310:Relief Refinance - Open Access (Retired 12/31/2018)
    /// </summary>
    [Description("310:Relief Refinance - Open Access (Retired 12/31/2018)")]
    [EnumMember(Value = "310")]
    n310 = 310,
    /// <summary>
    /// 320:Enhanced Relief Refinance
    /// </summary>
    [Description("320:Enhanced Relief Refinance")]
    [EnumMember(Value = "320")]
    n320 = 320
}