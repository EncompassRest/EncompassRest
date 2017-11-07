using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum UseNew2015FormsIndicator
    {
        [EnumMember(Value = "Old GFE and HUD-1")]
        OldGFEAndHUD1 = 0,
        [EnumMember(Value = "RESPA 2010 GFE and HUD-1")]
        RESPA2010GFEAndHUD1 = 1,
        [EnumMember(Value = "RESPA-TILA 2015 LE and CD")]
        RESPATILA2015LEAndCD = 2
    }
}