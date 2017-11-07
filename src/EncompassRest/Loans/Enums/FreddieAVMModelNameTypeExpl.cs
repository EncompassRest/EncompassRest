using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieAVMModelNameTypeExpl
    {
        AVMax = 0,
        CAValue = 1,
        CollateralMarketValue = 2,
        FraudGuard = 3,
        FREAllowedAVM = 4,
        [EnumMember(Value = "I_AVM")]
        IAVM = 5,
        IVal = 6,
        PowerBase6 = 7,
        RapidValue = 8,
        RealValue = 9,
        RealAssessment = 10,
        RealtorValuationModel = 11,
        Relar = 12,
        SiteXValue = 13,
        Vector = 14,
        Veros = 15,
        VeroValueAdvantage = 16,
        VeroValuePreferred = 17
    }
}