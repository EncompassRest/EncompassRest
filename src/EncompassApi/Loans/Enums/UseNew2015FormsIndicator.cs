using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// UseNew2015FormsIndicator
    /// </summary>
    public enum UseNew2015FormsIndicator
    {
        /// <summary>
        /// OldGFEandHUD1
        /// </summary>
        [Description("OldGFEandHUD1")]
        [EnumMember(Value = "Old GFE and HUD-1")]
        OldGFEAndHUD1 = 0,
        /// <summary>
        /// RESPA2010GFEandHUD1
        /// </summary>
        [Description("RESPA2010GFEandHUD1")]
        [EnumMember(Value = "RESPA 2010 GFE and HUD-1")]
        RESPA2010GFEAndHUD1 = 1,
        /// <summary>
        /// TILARESPA2015LEandCD
        /// </summary>
        [Description("TILARESPA2015LEandCD")]
        [EnumMember(Value = "RESPA-TILA 2015 LE and CD")]
        RESPATILA2015LEAndCD = 2
    }
}