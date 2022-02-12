using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FannieMICompanyNameTypeOther
/// </summary>
public enum FannieMICompanyNameTypeOther
{
    /// <summary>
    /// CAHLIF
    /// </summary>
    CAHLIF = 0,
    /// <summary>
    /// MD Housing
    /// </summary>
    [EnumMember(Value = "MD Housing")]
    MDHousing = 1,
    /// <summary>
    /// MIF
    /// </summary>
    MIF = 2,
    /// <summary>
    /// NMI
    /// </summary>
    NMI = 3,
    /// <summary>
    /// SONYMA (FNM Removed 12/2016)
    /// </summary>
    [Description("SONYMA (FNM Removed 12/2016)")]
    SONYMA = 4,
    /// <summary>
    /// ArchMI (FRE added 05/2015)
    /// </summary>
    [Description("ArchMI (FRE added 05/2015)")]
    ArchMI = 5
}