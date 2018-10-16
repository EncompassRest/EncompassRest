using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// VaLoanDataAppraisalType
    /// </summary>
    public enum VaLoanDataAppraisalType
    {
        /// <summary>
        /// IND-Single Prop-Ind Appraisal
        /// </summary>
        [Description("IND-Single Prop-Ind Appraisal")]
        IND = 0,
        /// <summary>
        /// MCRV
        /// </summary>
        MCRV = 1,
        /// <summary>
        /// LAPP-Lender
        /// </summary>
        [Description("LAPP-Lender")]
        LAPP = 2,
        /// <summary>
        /// MBL-Manufactured Home
        /// </summary>
        [Description("MBL-Manufactured Home")]
        MBL = 3,
        /// <summary>
        /// HUD-HUD Conversion
        /// </summary>
        [Description("HUD-HUD Conversion")]
        HUD = 4,
        /// <summary>
        /// PMC-Property Management Case
        /// </summary>
        [Description("PMC-Property Management Case")]
        PMC = 5
    }
}