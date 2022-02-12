using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// OpenEndLineOfCredit
/// </summary>
public enum OpenEndLineOfCredit
{
    /// <summary>
    /// 1. Open-end line of credit
    /// </summary>
    [Description("1. Open-end line of credit")]
    [EnumMember(Value = "Open-end line of credit")]
    OpenEndLineOfCredit = 0,
    /// <summary>
    /// 2. Not an open-end line of credit
    /// </summary>
    [Description("2. Not an open-end line of credit")]
    [EnumMember(Value = "Not an open-end line of credit")]
    NotAnOpenEndLineOfCredit = 1,
    /// <summary>
    /// 1111. Exempt
    /// </summary>
    [Description("1111. Exempt")]
    Exempt = 2
}