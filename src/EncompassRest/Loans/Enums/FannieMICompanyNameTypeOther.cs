using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum FannieMICompanyNameTypeOther
    {
        CAHLIF = 0,
        [EnumMember(Value = "MD Housing")]
        MDHousing = 1,
        MIF = 2,
        NMI = 3,
        SONYMA = 4,
        ArchMI = 5
    }
}