using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// SubmissionOfApplication
/// </summary>
public enum SubmissionOfApplication
{
    /// <summary>
    /// 1. Submitted directly to your institution
    /// </summary>
    [Description("1. Submitted directly to your institution")]
    [EnumMember(Value = "Submitted directly to your institution")]
    SubmittedDirectlyToYourInstitution = 0,
    /// <summary>
    /// 2. Not submitted directly to your institution
    /// </summary>
    [Description("2. Not submitted directly to your institution")]
    [EnumMember(Value = "Not submitted directly to your institution")]
    NotSubmittedDirectlyToYourInstitution = 1,
    /// <summary>
    /// 3. Not applicable
    /// </summary>
    [Description("3. Not applicable")]
    [EnumMember(Value = "Not applicable")]
    NotApplicable = 2,
    /// <summary>
    /// 1111. Exempt
    /// </summary>
    [Description("1111. Exempt")]
    Exempt = 3
}