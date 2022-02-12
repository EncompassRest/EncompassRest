using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// MortgageInsuranceCompany
/// </summary>
public enum MortgageInsuranceCompany
{
    /// <summary>
    /// General Electric Mortgage Insurance Corporation
    /// </summary>
    [Description("General Electric Mortgage Insurance Corporation")]
    [EnumMember(Value = "01")]
    n01 = 1,
    /// <summary>
    /// Mortgage Guaranty Insurance Corporation
    /// </summary>
    [Description("Mortgage Guaranty Insurance Corporation")]
    [EnumMember(Value = "06")]
    n06 = 6,
    /// <summary>
    /// PMI Mortgage Insurance Company
    /// </summary>
    [Description("PMI Mortgage Insurance Company")]
    [EnumMember(Value = "11")]
    n11 = 11,
    /// <summary>
    /// United Guaranty Residential Insurance
    /// </summary>
    [Description("United Guaranty Residential Insurance")]
    [EnumMember(Value = "12")]
    n12 = 12,
    /// <summary>
    /// Republic Mortgage Insurance Company
    /// </summary>
    [Description("Republic Mortgage Insurance Company")]
    [EnumMember(Value = "13")]
    n13 = 13,
    /// <summary>
    /// Triad Guaranty Insurance Corporation
    /// </summary>
    [Description("Triad Guaranty Insurance Corporation")]
    [EnumMember(Value = "24")]
    n24 = 24,
    /// <summary>
    /// Radian Guaranty Ince
    /// </summary>
    [Description("Radian Guaranty Ince")]
    [EnumMember(Value = "33")]
    n33 = 33,
    /// <summary>
    /// CMG Mortgage Insurance Company
    /// </summary>
    [Description("CMG Mortgage Insurance Company")]
    [EnumMember(Value = "38")]
    n38 = 38
}