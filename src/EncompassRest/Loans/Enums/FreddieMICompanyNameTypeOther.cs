using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// FreddieMICompanyNameTypeOther
    /// </summary>
    public enum FreddieMICompanyNameTypeOther
    {
        /// <summary>
        /// Amerin
        /// </summary>
        Amerin = 0,
        /// <summary>
        /// CAHLIF
        /// </summary>
        CAHLIF = 1,
        /// <summary>
        /// CMGPreSep94
        /// </summary>
        CMGPreSep94 = 2,
        /// <summary>
        /// Common wealth
        /// </summary>
        [EnumMember(Value = "Common wealth")]
        CommonWealth = 3,
        /// <summary>
        /// MIF
        /// </summary>
        MIF = 4,
        /// <summary>
        /// NMI
        /// </summary>
        NMI = 5,
        /// <summary>
        /// RMIC-NC
        /// </summary>
        [EnumMember(Value = "RMIC-NC")]
        RMICNC = 6,
        /// <summary>
        /// Verex
        /// </summary>
        Verex = 7,
        /// <summary>
        /// Wisc Mtg Assr
        /// </summary>
        [EnumMember(Value = "Wisc Mtg Assr")]
        WiscMtgAssr = 8
    }
}