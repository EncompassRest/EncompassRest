using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PoolInterestRateRoundingType
    {
        Down = 0,
        Nearest = 1,
        NoRounding = 2,
        Up = 3
    }
}