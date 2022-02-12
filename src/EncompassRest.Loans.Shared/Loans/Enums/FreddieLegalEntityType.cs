using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FreddieLegalEntityType
/// </summary>
public enum FreddieLegalEntityType
{
    /// <summary>
    /// Estate
    /// </summary>
    Estate = 0,
    /// <summary>
    /// Government Entity
    /// </summary>
    [EnumMember(Value = "Government Entity")]
    GovernmentEntity = 1,
    /// <summary>
    /// Limited Liability Company
    /// </summary>
    [EnumMember(Value = "Limited Liability Company")]
    LimitedLiabilityCompany = 2,
    /// <summary>
    /// Limited Partnership
    /// </summary>
    [EnumMember(Value = "Limited Partnership")]
    LimitedPartnership = 3,
    /// <summary>
    /// Joint Venture
    /// </summary>
    [EnumMember(Value = "Joint Venture")]
    JointVenture = 4,
    /// <summary>
    /// Nonprofit Corporation
    /// </summary>
    [EnumMember(Value = "Nonprofit Corporation")]
    NonprofitCorporation = 5,
    /// <summary>
    /// Other
    /// </summary>
    Other = 6
}