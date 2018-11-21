using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// InvestorCollateralProgramIdentifier
    /// </summary>
    public enum InvestorCollateralProgramIdentifier
    {
        /// <summary>
        /// DU Refi Plus Property Fieldwork Waiver
        /// </summary>
        [Description("DU Refi Plus Property Fieldwork Waiver")]
        DURefiPlusPropertyFieldworkWaiver = 0,
        /// <summary>
        /// DU Property Inspection Report Form 2075
        /// </summary>
        [Description("DU Property Inspection Report Form 2075")]
        DUPropertyInspectionReportForm2075 = 1,
        /// <summary>
        /// Level 1 Property Inspection Waiver
        /// </summary>
        [Description("Level 1 Property Inspection Waiver")]
        Level1PropertyInspectionWaiver = 2,
        /// <summary>
        /// Property Inspection Waiver
        /// </summary>
        [Description("Property Inspection Waiver")]
        PropertyInspectionWaiver = 3
    }
}