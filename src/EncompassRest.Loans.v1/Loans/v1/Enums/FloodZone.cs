using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
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
        Yes = 25
    }
}