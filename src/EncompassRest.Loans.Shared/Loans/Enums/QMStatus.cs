using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// QMStatus
/// </summary>
public enum QMStatus
{
    /// <summary>
    /// QM
    /// </summary>
    QM = 0,
    /// <summary>
    /// Non-QM
    /// </summary>
    [EnumMember(Value = "Non-QM")]
    NonQM = 1,
    /// <summary>
    /// Exempt
    /// </summary>
    Exempt = 2
}