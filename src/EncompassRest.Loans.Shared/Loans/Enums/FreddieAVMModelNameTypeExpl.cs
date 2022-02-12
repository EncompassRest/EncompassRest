using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FreddieAVMModelNameTypeExpl
/// </summary>
public enum FreddieAVMModelNameTypeExpl
{
    /// <summary>
    /// AVMax
    /// </summary>
    AVMax = 0,
    /// <summary>
    /// CAValue
    /// </summary>
    CAValue = 1,
    /// <summary>
    /// CollateralMarketValue
    /// </summary>
    CollateralMarketValue = 2,
    /// <summary>
    /// FraudGuard
    /// </summary>
    FraudGuard = 3,
    /// <summary>
    /// FREAllowedAVM
    /// </summary>
    FREAllowedAVM = 4,
    /// <summary>
    /// I_AVM
    /// </summary>
    [EnumMember(Value = "I_AVM")]
    IAVM = 5,
    /// <summary>
    /// IVal
    /// </summary>
    IVal = 6,
    /// <summary>
    /// PowerBase6
    /// </summary>
    PowerBase6 = 7,
    /// <summary>
    /// RapidValue
    /// </summary>
    RapidValue = 8,
    /// <summary>
    /// RealValue
    /// </summary>
    RealValue = 9,
    /// <summary>
    /// RealAssessment
    /// </summary>
    RealAssessment = 10,
    /// <summary>
    /// RealtorValuationModel
    /// </summary>
    RealtorValuationModel = 11,
    /// <summary>
    /// Relar
    /// </summary>
    Relar = 12,
    /// <summary>
    /// SiteXValue
    /// </summary>
    SiteXValue = 13,
    /// <summary>
    /// Vector
    /// </summary>
    Vector = 14,
    /// <summary>
    /// Veros
    /// </summary>
    Veros = 15,
    /// <summary>
    /// VeroValueAdvantage
    /// </summary>
    VeroValueAdvantage = 16,
    /// <summary>
    /// VeroValuePreferred
    /// </summary>
    VeroValuePreferred = 17
}