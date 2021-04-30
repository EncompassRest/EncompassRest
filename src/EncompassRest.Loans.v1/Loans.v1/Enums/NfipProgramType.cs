using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// NfipProgramType
    /// </summary>
    public enum NfipProgramType
    {
        /// <summary>
        /// Regular NFIP Program
        /// </summary>
        [Description("Regular NFIP Program")]
        Regular = 0,
        /// <summary>
        /// Emergency NFIP Program
        /// </summary>
        [Description("Emergency NFIP Program")]
        Emergency = 1
    }
}