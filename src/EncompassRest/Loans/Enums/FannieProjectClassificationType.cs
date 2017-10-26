using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieProjectClassificationType
    {
        E = 0,
        F = 1,
        G = 2,
        P = 3,
        Q = 4,
        R = 5,
        S = 6,
        T = 7,
        U = 8,
        V = 9,
        [EnumMember(Value = "1")]
        n1 = 10,
        [EnumMember(Value = "2")]
        n2 = 11
    }
}