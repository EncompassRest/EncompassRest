using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FreddieMICompanyNameTypeOther
    {
        Amerin = 0,
        CAHLIF = 1,
        CMGPreSep94 = 2,
        [EnumMember(Value = "Common wealth")]
        CommonWealth = 3,
        MIF = 4,
        NMI = 5,
        [EnumMember(Value = "RMIC-NC")]
        RMICNC = 6,
        Verex = 7,
        [EnumMember(Value = "Wisc Mtg Assr")]
        WiscMtgAssr = 8
    }
}