using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PriorLoanType
    {
        [EnumMember(Value = "FHA-Fixed")]
        FHAFixed = 0,
        [EnumMember(Value = "FHA-ARM/HARM")]
        FHAARMHARM = 1,
        [EnumMember(Value = "Conventional-Fixed")]
        ConventionalFixed = 2,
        [EnumMember(Value = "Conventional-ARM/HARM")]
        ConventionalARMHARM = 3,
        [EnumMember(Value = "Conventional-Interest Only")]
        ConventionalInterestOnly = 4,
        [EnumMember(Value = "VA-Fixed")]
        VAFixed = 5,
        [EnumMember(Value = "VA-ARM/HARM")]
        VAARMHARM = 6,
        Other = 7
    }
}