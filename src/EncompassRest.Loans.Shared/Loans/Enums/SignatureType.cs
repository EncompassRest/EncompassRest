using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// SignatureType
/// </summary>
public enum SignatureType
{
    /// <summary>
    /// As Applicant
    /// </summary>
    [Description("As Applicant")]
    AsApplicant = 0,
    /// <summary>
    /// By Name
    /// </summary>
    [Description("By Name")]
    ByName = 1,
    /// <summary>
    /// None
    /// </summary>
    None = 2
}