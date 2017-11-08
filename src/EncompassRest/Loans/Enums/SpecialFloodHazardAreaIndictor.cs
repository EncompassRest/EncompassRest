using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum SpecialFloodHazardAreaIndictor
    {
        A = 0,
        [EnumMember(Value = "A1-A30")]
        A1A30 = 1,
        A99 = 2,
        AE = 3,
        AH = 4,
        AO = 5,
        AR = 6,
        [EnumMember(Value = "AR/A")]
        ARA = 7,
        [EnumMember(Value = "AR/AE")]
        ARAE = 8,
        [EnumMember(Value = "AR/AH")]
        ARAH = 9,
        [EnumMember(Value = "AR/AO")]
        ARAO = 10,
        B = 11,
        C = 12,
        D = 13,
        FHSHA = 14,
        No = 15,
        S = 16,
        V = 17,
        VE = 18,
        VO = 19,
        [EnumMember(Value = "V1-V30")]
        V1V30 = 20,
        X = 21,
        X500 = 22,
        XS = 23,
        XU = 24,
        Yes = 25
    }
}