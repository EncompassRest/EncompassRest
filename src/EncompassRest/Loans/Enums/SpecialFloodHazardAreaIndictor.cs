using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// SpecialFloodHazardAreaIndictor
    /// </summary>
    public enum SpecialFloodHazardAreaIndictor
    {
        /// <summary>
        /// Yes
        /// </summary>
        Yes = 0,
        /// <summary>
        /// No
        /// </summary>
        No = 1,
        /// <summary>
        /// None
        /// </summary>
        None = 2,
        /// <summary>
        /// A1-A30
        /// </summary>
        [EnumMember(Value = "A1-A30")]
        A1A30 = 3,
        /// <summary>
        /// A1
        /// </summary>
        A1 = 4,
        /// <summary>
        /// A2
        /// </summary>
        A2 = 5,
        /// <summary>
        /// A3
        /// </summary>
        A3 = 6,
        /// <summary>
        /// A4
        /// </summary>
        A4 = 7,
        /// <summary>
        /// A5
        /// </summary>
        A5 = 8,
        /// <summary>
        /// A6
        /// </summary>
        A6 = 9,
        /// <summary>
        /// A7
        /// </summary>
        A7 = 10,
        /// <summary>
        /// A8
        /// </summary>
        A8 = 11,
        /// <summary>
        /// A9
        /// </summary>
        A9 = 12,
        /// <summary>
        /// A10
        /// </summary>
        A10 = 13,
        /// <summary>
        /// A11
        /// </summary>
        A11 = 14,
        /// <summary>
        /// A12
        /// </summary>
        A12 = 15,
        /// <summary>
        /// A13
        /// </summary>
        A13 = 16,
        /// <summary>
        /// A14
        /// </summary>
        A14 = 17,
        /// <summary>
        /// A15
        /// </summary>
        A15 = 18,
        /// <summary>
        /// A16
        /// </summary>
        A16 = 19,
        /// <summary>
        /// A17
        /// </summary>
        A17 = 20,
        /// <summary>
        /// A18
        /// </summary>
        A18 = 21,
        /// <summary>
        /// A19
        /// </summary>
        A19 = 22,
        /// <summary>
        /// A20
        /// </summary>
        A20 = 23,
        /// <summary>
        /// A21
        /// </summary>
        A21 = 24,
        /// <summary>
        /// A22
        /// </summary>
        A22 = 25,
        /// <summary>
        /// A23
        /// </summary>
        A23 = 26,
        /// <summary>
        /// A24
        /// </summary>
        A24 = 27,
        /// <summary>
        /// A25
        /// </summary>
        A25 = 28,
        /// <summary>
        /// A26
        /// </summary>
        A26 = 29,
        /// <summary>
        /// A27
        /// </summary>
        A27 = 30,
        /// <summary>
        /// A28
        /// </summary>
        A28 = 31,
        /// <summary>
        /// A29
        /// </summary>
        A29 = 32,
        /// <summary>
        /// A30
        /// </summary>
        A30 = 33,
        /// <summary>
        /// V1-V30
        /// </summary>
        [EnumMember(Value = "V1-V30")]
        V1V30 = 34,
        /// <summary>
        /// V1
        /// </summary>
        V1 = 35,
        /// <summary>
        /// V2
        /// </summary>
        V2 = 36,
        /// <summary>
        /// V3
        /// </summary>
        V3 = 37,
        /// <summary>
        /// V4
        /// </summary>
        V4 = 38,
        /// <summary>
        /// V5
        /// </summary>
        V5 = 39,
        /// <summary>
        /// V6
        /// </summary>
        V6 = 40,
        /// <summary>
        /// V7
        /// </summary>
        V7 = 41,
        /// <summary>
        /// V8
        /// </summary>
        V8 = 42,
        /// <summary>
        /// V9
        /// </summary>
        V9 = 43,
        /// <summary>
        /// V10
        /// </summary>
        V10 = 44,
        /// <summary>
        /// V11
        /// </summary>
        V11 = 45,
        /// <summary>
        /// V12
        /// </summary>
        V12 = 46,
        /// <summary>
        /// V13
        /// </summary>
        V13 = 47,
        /// <summary>
        /// V14
        /// </summary>
        V14 = 48,
        /// <summary>
        /// V15
        /// </summary>
        V15 = 49,
        /// <summary>
        /// V16
        /// </summary>
        V16 = 50,
        /// <summary>
        /// V17
        /// </summary>
        V17 = 51,
        /// <summary>
        /// V18
        /// </summary>
        V18 = 52,
        /// <summary>
        /// V19
        /// </summary>
        V19 = 53,
        /// <summary>
        /// V20
        /// </summary>
        V20 = 54,
        /// <summary>
        /// V21
        /// </summary>
        V21 = 55,
        /// <summary>
        /// V22
        /// </summary>
        V22 = 56,
        /// <summary>
        /// V23
        /// </summary>
        V23 = 57,
        /// <summary>
        /// V24
        /// </summary>
        V24 = 58,
        /// <summary>
        /// V25
        /// </summary>
        V25 = 59,
        /// <summary>
        /// V26
        /// </summary>
        V26 = 60,
        /// <summary>
        /// V27
        /// </summary>
        V27 = 61,
        /// <summary>
        /// V28
        /// </summary>
        V28 = 62,
        /// <summary>
        /// V29
        /// </summary>
        V29 = 63,
        /// <summary>
        /// V30
        /// </summary>
        V30 = 64,
        /// <summary>
        /// A
        /// </summary>
        A = 65,
        /// <summary>
        /// A99
        /// </summary>
        A99 = 66,
        /// <summary>
        /// AE
        /// </summary>
        AE = 67,
        /// <summary>
        /// AH
        /// </summary>
        AH = 68,
        /// <summary>
        /// AO
        /// </summary>
        AO = 69,
        /// <summary>
        /// AR
        /// </summary>
        AR = 70,
        /// <summary>
        /// AR/A
        /// </summary>
        [EnumMember(Value = "AR/A")]
        ARA = 71,
        /// <summary>
        /// AR/AE
        /// </summary>
        [EnumMember(Value = "AR/AE")]
        ARAE = 72,
        /// <summary>
        /// AR/AH
        /// </summary>
        [EnumMember(Value = "AR/AH")]
        ARAH = 73,
        /// <summary>
        /// AR/AO
        /// </summary>
        [EnumMember(Value = "AR/AO")]
        ARAO = 74,
        /// <summary>
        /// B
        /// </summary>
        B = 75,
        /// <summary>
        /// BX
        /// </summary>
        BX = 76,
        /// <summary>
        /// C
        /// </summary>
        C = 77,
        /// <summary>
        /// CX
        /// </summary>
        CX = 78,
        /// <summary>
        /// D
        /// </summary>
        D = 79,
        /// <summary>
        /// FHSHA
        /// </summary>
        FHSHA = 80,
        /// <summary>
        /// S
        /// </summary>
        S = 81,
        /// <summary>
        /// V
        /// </summary>
        V = 82,
        /// <summary>
        /// VE
        /// </summary>
        VE = 83,
        /// <summary>
        /// VO
        /// </summary>
        VO = 84,
        /// <summary>
        /// X
        /// </summary>
        X = 85,
        /// <summary>
        /// X500
        /// </summary>
        X500 = 86,
        /// <summary>
        /// XS
        /// </summary>
        XS = 87,
        /// <summary>
        /// XU
        /// </summary>
        XU = 88
    }
}