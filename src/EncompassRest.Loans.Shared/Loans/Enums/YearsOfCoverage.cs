using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// YearsOfCoverage
/// </summary>
public enum YearsOfCoverage
{
    /// <summary>
    /// 1 year
    /// </summary>
    [Description("1 year")]
    [EnumMember(Value = "1")]
    n1 = 1,
    /// <summary>
    /// 3 year
    /// </summary>
    [Description("3 year")]
    [EnumMember(Value = "3")]
    n3 = 3,
    /// <summary>
    /// 5 year
    /// </summary>
    [Description("5 year")]
    [EnumMember(Value = "5")]
    n5 = 5,
    /// <summary>
    /// 6 year
    /// </summary>
    [Description("6 year")]
    [EnumMember(Value = "6")]
    n6 = 6,
    /// <summary>
    /// 7 year
    /// </summary>
    [Description("7 year")]
    [EnumMember(Value = "7")]
    n7 = 7,
    /// <summary>
    /// 10 year
    /// </summary>
    [Description("10 year")]
    [EnumMember(Value = "10")]
    n10 = 10,
    /// <summary>
    /// 12 year
    /// </summary>
    [Description("12 year")]
    [EnumMember(Value = "12")]
    n12 = 12,
    /// <summary>
    /// 15 year
    /// </summary>
    [Description("15 year")]
    [EnumMember(Value = "15")]
    n15 = 15,
    /// <summary>
    /// Life of loan
    /// </summary>
    [Description("Life of loan")]
    [EnumMember(Value = "99")]
    n99 = 99
}