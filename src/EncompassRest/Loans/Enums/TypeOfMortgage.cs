using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum TypeOfMortgage
    {
        RegularFixed = 0,
        GPM = 1,
        OtherGPM = 2,
        GEM = 3,
        TemporaryBuydown = 4,
        HybridARM = 5,
        ARM = 6
    }
}