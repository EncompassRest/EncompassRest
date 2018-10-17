using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// IndexMargin
    /// </summary>
    public enum IndexMargin
    {
        /// <summary>
        /// 1 Year UST CM
        /// </summary>
        [Description("1 Year UST CM")]
        UST1YW = 0,
        /// <summary>
        /// 3 Year UST CM
        /// </summary>
        [Description("3 Year UST CM")]
        UST3YW = 1,
        /// <summary>
        /// 5 Year UST CM
        /// </summary>
        [Description("5 Year UST CM")]
        UST5YW = 2,
        /// <summary>
        /// 7 Year UST CM
        /// </summary>
        [Description("7 Year UST CM")]
        UST7YW = 3,
        /// <summary>
        /// 10 Year UST CM
        /// </summary>
        [Description("10 Year UST CM")]
        UST10YW = 4,
        /// <summary>
        /// 20 Year UST CM
        /// </summary>
        [Description("20 Year UST CM")]
        UST20YW = 5,
        /// <summary>
        /// 30 Year UST CM
        /// </summary>
        [Description("30 Year UST CM")]
        UST30YW = 6,
        /// <summary>
        /// 1 Year US Treasury CM
        /// </summary>
        [Description("1 Year US Treasury CM")]
        UST1Y = 7,
        /// <summary>
        /// 3 Year US Treasury CM
        /// </summary>
        [Description("3 Year US Treasury CM")]
        UST3Y = 8,
        /// <summary>
        /// 5 Year US Treasury CM
        /// </summary>
        [Description("5 Year US Treasury CM")]
        UST5Y = 9,
        /// <summary>
        /// 7 Year US Treasury CM
        /// </summary>
        [Description("7 Year US Treasury CM")]
        UST7Y = 10,
        /// <summary>
        /// 10 Year US Treasury CM
        /// </summary>
        [Description("10 Year US Treasury CM")]
        UST10Y = 11,
        /// <summary>
        /// 20 Year US Treasury CM
        /// </summary>
        [Description("20 Year US Treasury CM")]
        UST20Y = 12,
        /// <summary>
        /// 30 Year US Treasury CM
        /// </summary>
        [Description("30 Year US Treasury CM")]
        UST30Y = 13,
        /// <summary>
        /// 3-MonthCD
        /// </summary>
        [Description("3-MonthCD")]
        [EnumMember(Value = "3MoCD(12MoAvg)")]
        n3MoCD12MoAvg = 14,
        /// <summary>
        /// 6 Month CD weekly
        /// </summary>
        [Description("6 Month CD weekly")]
        [EnumMember(Value = "6MCDW")]
        n6MCDW = 15,
        /// <summary>
        /// 6 Month US Treasury CM
        /// </summary>
        [Description("6 Month US Treasury CM")]
        UST6M = 16,
        /// <summary>
        /// 90 Day AA Commercial Paper Rates
        /// </summary>
        [Description("90 Day AA Commercial Paper Rates")]
        FRBCommercial3M = 17,
        /// <summary>
        /// Bank Prime Loan Rate
        /// </summary>
        [Description("Bank Prime Loan Rate")]
        FRBBankPrime = 18,
        /// <summary>
        /// COFI 11th District
        /// </summary>
        [Description("COFI 11th District")]
        FHLBSFCOFI = 19,
        /// <summary>
        /// Conventional Mortgage Rate
        /// </summary>
        [Description("Conventional Mortgage Rate")]
        CMR = 20,
        /// <summary>
        /// National Average Contract Mortgage Rate
        /// </summary>
        [Description("National Average Contract Mortgage Rate")]
        [EnumMember(Value = "FHFB_NACMR")]
        FHFBNACMR = 21,
        /// <summary>
        /// Federal Reserve Discount Rate
        /// </summary>
        [Description("Federal Reserve Discount Rate")]
        FRBDiscount = 22,
        /// <summary>
        /// Freddie Mac 30Y/30D delivery
        /// </summary>
        [Description("Freddie Mac 30Y/30D delivery")]
        FHLMC30Y30D = 23,
        /// <summary>
        /// Freddie Mac 30Y/60D delivery
        /// </summary>
        [Description("Freddie Mac 30Y/60D delivery")]
        FHLMC30Y60D = 24,
        /// <summary>
        /// Freddie Mac 30Y/90D delivery
        /// </summary>
        [Description("Freddie Mac 30Y/90D delivery")]
        FHLMC30Y90D = 25,
        /// <summary>
        /// Freddie Mac 1 Month LIBOR
        /// </summary>
        [Description("Freddie Mac 1 Month LIBOR")]
        FHLMCLIBOR1M = 26,
        /// <summary>
        /// Freddie Mac 3 Month LIBOR
        /// </summary>
        [Description("Freddie Mac 3 Month LIBOR")]
        FHLMCLIBOR3M = 27,
        /// <summary>
        /// Freddie Mac 6 Month LIBOR
        /// </summary>
        [Description("Freddie Mac 6 Month LIBOR")]
        FHLMCLIBOR6M = 28,
        /// <summary>
        /// Freddie Mac 1 Year LIBOR
        /// </summary>
        [Description("Freddie Mac 1 Year LIBOR")]
        FHLMCLIBOR1Y = 29,
        /// <summary>
        /// Fannie Mae 12 Month Average
        /// </summary>
        [Description("Fannie Mae 12 Month Average")]
        FNMA12MAVG = 30,
        /// <summary>
        /// Fannie Mae 15Y/60D delivery
        /// </summary>
        [Description("Fannie Mae 15Y/60D delivery")]
        FNMA15Y60D = 31,
        /// <summary>
        /// Fannie Mae 30Y/30D delivery
        /// </summary>
        [Description("Fannie Mae 30Y/30D delivery")]
        FNMA30Y30D = 32,
        /// <summary>
        /// Fannie Mae 30Y/60D delivery
        /// </summary>
        [Description("Fannie Mae 30Y/60D delivery")]
        FNMA30Y60D = 33,
        /// <summary>
        /// Fannie Mae 30Y/90D delivery
        /// </summary>
        [Description("Fannie Mae 30Y/90D delivery")]
        FNMA30Y90D = 34,
        /// <summary>
        /// Fannie Mae 1 Month LIBOR
        /// </summary>
        [Description("Fannie Mae 1 Month LIBOR")]
        FNMALIBOR1M = 35,
        /// <summary>
        /// Fannie Mae 3 Month LIBOR
        /// </summary>
        [Description("Fannie Mae 3 Month LIBOR")]
        FNMALIBOR3M = 36,
        /// <summary>
        /// Fannie Mae 6 Month LIBOR
        /// </summary>
        [Description("Fannie Mae 6 Month LIBOR")]
        FNMALIBOR6M = 37,
        /// <summary>
        /// Fannie Mae 1 Year LIBOR
        /// </summary>
        [Description("Fannie Mae 1 Year LIBOR")]
        FNMALIBOR1Y = 38,
        /// <summary>
        /// LIBOR - 1 month
        /// </summary>
        [Description("LIBOR - 1 month")]
        LIBOR1M = 39,
        /// <summary>
        /// LIBOR - 3 month
        /// </summary>
        [Description("LIBOR - 3 month")]
        LIBOR3M = 40,
        /// <summary>
        /// LIBOR - 6 month
        /// </summary>
        [Description("LIBOR - 6 month")]
        LIBOR6M = 41,
        /// <summary>
        /// LIBOR - 12 month
        /// </summary>
        [Description("LIBOR - 12 month")]
        LIBOR12M = 42,
        /// <summary>
        /// Monthly Treasury Average
        /// </summary>
        [Description("Monthly Treasury Average")]
        MTA = 43,
        /// <summary>
        /// TN Max Interest Rate
        /// </summary>
        [Description("TN Max Interest Rate")]
        TNMax = 44,
        /// <summary>
        /// WSJ Prime Rate
        /// </summary>
        [Description("WSJ Prime Rate")]
        WSJPrime = 45,
        /// <summary>
        /// WSJ Prime Rate
        /// </summary>
        [Description("WSJ Prime Rate")]
        WSJPrimeWkly = 46
    }
}