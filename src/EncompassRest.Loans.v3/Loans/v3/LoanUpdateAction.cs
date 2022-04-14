using System.Runtime.Serialization;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanUpdateAction
/// </summary>
public enum LoanUpdateAction
{
    /// <summary>
    /// Register a TPO Loan and populate TPO information.
    /// </summary>
    [EnumMember(Value = "tpoRegister")]
    TpoRegister = 0,
    /// <summary>
    /// Submit a loan to TPO.
    /// </summary>
    [EnumMember(Value = "tpoSubmit")]
    TpoSubmit = 1,
    /// <summary>
    /// Resubmit a loan to TPO.
    /// </summary>
    [EnumMember(Value = "tpoResubmit")]
    TpoResubmit = 2,
    /// <summary>
    /// Order an appraisal for a loan.
    /// </summary>
    [EnumMember(Value = "tpoOrderAppraisal")]
    TpoOrderAppraisal = 3,
    /// <summary>
    /// Generate LE/Disclosures for a loan.
    /// </summary>
    [EnumMember(Value = "tpoGenerateDisclosures")]
    TpoGenerateDisclosures = 4
}