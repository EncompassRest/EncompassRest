using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum IndexMargin
    {
        UST1YW = 0,
        UST3YW = 1,
        UST5YW = 2,
        UST7YW = 3,
        UST10YW = 4,
        UST20YW = 5,
        UST30YW = 6,
        UST1Y = 7,
        UST3Y = 8,
        UST5Y = 9,
        UST7Y = 10,
        UST10Y = 11,
        UST20Y = 12,
        UST30Y = 13,
        [EnumMember(Value = "3MoCD(12MoAvg)")]
        n3MoCD12MoAvg = 14,
        [EnumMember(Value = "6MCDW")]
        n6MCDW = 15,
        UST6M = 16,
        FRBCommercial3M = 17,
        FRBBankPrime = 18,
        FHLBSFCOFI = 19,
        CMR = 20,
        [EnumMember(Value = "FHFB_NACMR")]
        FHFBNACMR = 21,
        FRBDiscount = 22,
        FHLMC30Y30D = 23,
        FHLMC30Y60D = 24,
        FHLMC30Y90D = 25,
        FHLMCLIBOR1M = 26,
        FHLMCLIBOR3M = 27,
        FHLMCLIBOR6M = 28,
        FHLMCLIBOR1Y = 29,
        FNMA12MAVG = 30,
        FNMA15Y60D = 31,
        FNMA30Y30D = 32,
        FNMA30Y60D = 33,
        FNMA30Y90D = 34,
        FNMALIBOR1M = 35,
        FNMALIBOR3M = 36,
        FNMALIBOR6M = 37,
        FNMALIBOR1Y = 38,
        LIBOR1M = 39,
        LIBOR3M = 40,
        LIBOR6M = 41,
        LIBOR12M = 42,
        MTA = 43,
        TNMax = 44,
        WSJPrime = 45,
        WSJPrimeWkly = 46
    }
}