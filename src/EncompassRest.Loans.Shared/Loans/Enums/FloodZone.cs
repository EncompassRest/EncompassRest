using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// FloodZone
/// </summary>
public enum FloodZone
{
    /// <summary>
    /// A
    /// </summary>
    A = 0,
    /// <summary>
    /// A1-A30
    /// </summary>
    [EnumMember(Value = "A1-A30")]
    A1A30 = 1,
    /// <summary>
    /// A99
    /// </summary>
    A99 = 2,
    /// <summary>
    /// AE
    /// </summary>
    AE = 3,
    /// <summary>
    /// AH
    /// </summary>
    AH = 4,
    /// <summary>
    /// AO
    /// </summary>
    AO = 5,
    /// <summary>
    /// AR
    /// </summary>
    AR = 6,
    /// <summary>
    /// AR/A
    /// </summary>
    [EnumMember(Value = "AR/A")]
    ARA = 7,
    /// <summary>
    /// AR/AE
    /// </summary>
    [EnumMember(Value = "AR/AE")]
    ARAE = 8,
    /// <summary>
    /// AR/AH
    /// </summary>
    [EnumMember(Value = "AR/AH")]
    ARAH = 9,
    /// <summary>
    /// AR/AO
    /// </summary>
    [EnumMember(Value = "AR/AO")]
    ARAO = 10,
    /// <summary>
    /// B
    /// </summary>
    B = 11,
    /// <summary>
    /// C
    /// </summary>
    C = 12,
    /// <summary>
    /// D
    /// </summary>
    D = 13,
    /// <summary>
    /// FHSHA
    /// </summary>
    FHSHA = 14,
    /// <summary>
    /// No
    /// </summary>
    No = 15,
    /// <summary>
    /// S
    /// </summary>
    S = 16,
    /// <summary>
    /// V
    /// </summary>
    V = 17,
    /// <summary>
    /// VE
    /// </summary>
    VE = 18,
    /// <summary>
    /// VO
    /// </summary>
    VO = 19,
    /// <summary>
    /// V1-V30
    /// </summary>
    [EnumMember(Value = "V1-V30")]
    V1V30 = 20,
    /// <summary>
    /// X
    /// </summary>
    X = 21,
    /// <summary>
    /// X500
    /// </summary>
    X500 = 22,
    /// <summary>
    /// XS
    /// </summary>
    XS = 23,
    /// <summary>
    /// XU
    /// </summary>
    XU = 24,
    /// <summary>
    /// Yes
    /// </summary>
    Yes = 25,
    /// <summary>
    /// None
    /// </summary>
    None = 26,
    /// <summary>
    /// A1
    /// </summary>
    A1 = 27,
    /// <summary>
    /// A2
    /// </summary>
    A2 = 28,
    /// <summary>
    /// A3
    /// </summary>
    A3 = 29,
    /// <summary>
    /// A4
    /// </summary>
    A4 = 30,
    /// <summary>
    /// A5
    /// </summary>
    A5 = 31,
    /// <summary>
    /// A6
    /// </summary>
    A6 = 32,
    /// <summary>
    /// A7
    /// </summary>
    A7 = 33,
    /// <summary>
    /// A8
    /// </summary>
    A8 = 34,
    /// <summary>
    /// A9
    /// </summary>
    A9 = 35,
    /// <summary>
    /// A10
    /// </summary>
    A10 = 36,
    /// <summary>
    /// A11
    /// </summary>
    A11 = 37,
    /// <summary>
    /// A12
    /// </summary>
    A12 = 38,
    /// <summary>
    /// A13
    /// </summary>
    A13 = 39,
    /// <summary>
    /// A14
    /// </summary>
    A14 = 40,
    /// <summary>
    /// A15
    /// </summary>
    A15 = 41,
    /// <summary>
    /// A16
    /// </summary>
    A16 = 42,
    /// <summary>
    /// A17
    /// </summary>
    A17 = 43,
    /// <summary>
    /// A18
    /// </summary>
    A18 = 44,
    /// <summary>
    /// A19
    /// </summary>
    A19 = 45,
    /// <summary>
    /// A20
    /// </summary>
    A20 = 46,
    /// <summary>
    /// A21
    /// </summary>
    A21 = 47,
    /// <summary>
    /// A22
    /// </summary>
    A22 = 48,
    /// <summary>
    /// A23
    /// </summary>
    A23 = 49,
    /// <summary>
    /// A24
    /// </summary>
    A24 = 50,
    /// <summary>
    /// A25
    /// </summary>
    A25 = 51,
    /// <summary>
    /// A26
    /// </summary>
    A26 = 52,
    /// <summary>
    /// A27
    /// </summary>
    A27 = 53,
    /// <summary>
    /// A28
    /// </summary>
    A28 = 54,
    /// <summary>
    /// A29
    /// </summary>
    A29 = 55,
    /// <summary>
    /// A30
    /// </summary>
    A30 = 56,
    /// <summary>
    /// V1
    /// </summary>
    V1 = 57,
    /// <summary>
    /// V2
    /// </summary>
    V2 = 58,
    /// <summary>
    /// V3
    /// </summary>
    V3 = 59,
    /// <summary>
    /// V4
    /// </summary>
    V4 = 60,
    /// <summary>
    /// V5
    /// </summary>
    V5 = 61,
    /// <summary>
    /// V6
    /// </summary>
    V6 = 62,
    /// <summary>
    /// V7
    /// </summary>
    V7 = 63,
    /// <summary>
    /// V8
    /// </summary>
    V8 = 64,
    /// <summary>
    /// V9
    /// </summary>
    V9 = 65,
    /// <summary>
    /// V10
    /// </summary>
    V10 = 66,
    /// <summary>
    /// V11
    /// </summary>
    V11 = 67,
    /// <summary>
    /// V12
    /// </summary>
    V12 = 68,
    /// <summary>
    /// V13
    /// </summary>
    V13 = 69,
    /// <summary>
    /// V14
    /// </summary>
    V14 = 70,
    /// <summary>
    /// V15
    /// </summary>
    V15 = 71,
    /// <summary>
    /// V16
    /// </summary>
    V16 = 72,
    /// <summary>
    /// V17
    /// </summary>
    V17 = 73,
    /// <summary>
    /// V18
    /// </summary>
    V18 = 74,
    /// <summary>
    /// V19
    /// </summary>
    V19 = 75,
    /// <summary>
    /// V20
    /// </summary>
    V20 = 76,
    /// <summary>
    /// V21
    /// </summary>
    V21 = 77,
    /// <summary>
    /// V22
    /// </summary>
    V22 = 78,
    /// <summary>
    /// V23
    /// </summary>
    V23 = 79,
    /// <summary>
    /// V24
    /// </summary>
    V24 = 80,
    /// <summary>
    /// V25
    /// </summary>
    V25 = 81,
    /// <summary>
    /// V26
    /// </summary>
    V26 = 82,
    /// <summary>
    /// V27
    /// </summary>
    V27 = 83,
    /// <summary>
    /// V28
    /// </summary>
    V28 = 84,
    /// <summary>
    /// V29
    /// </summary>
    V29 = 85,
    /// <summary>
    /// V30
    /// </summary>
    V30 = 86
}