using System.Runtime.Serialization;

namespace EncompassRest.Loans.v3;

/// <summary>
/// TemplateType
/// </summary>
public enum TemplateType
{
    /// <summary>
    /// templateSet
    /// </summary>
    [EnumMember(Value = "templateSet")]
    TemplateSet = 0,
    /// <summary>
    /// funding
    /// </summary>
    [EnumMember(Value = "funding")]
    Funding = 1,
    /// <summary>
    /// closingCost
    /// </summary>
    [EnumMember(Value = "closingCost")]
    ClosingCost = 2,
    /// <summary>
    /// loanProgram
    /// </summary>
    [EnumMember(Value = "loanProgram")]
    LoanProgram = 3
}