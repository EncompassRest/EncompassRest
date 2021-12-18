using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// PrimaryMIAbsenceReasonTypeOtherDescription
    /// </summary>
    public enum PrimaryMIAbsenceReasonTypeOtherDescription
    {
        /// <summary>
        /// Indemnification In Lieu Of MI
        /// </summary>
        [Description("Indemnification In Lieu Of MI")]
        IndemnificationInLieuOfMI = 0,
        /// <summary>
        /// No MI Based on Mortgage Being Refinanced
        /// </summary>
        [Description("No MI Based on Mortgage Being Refinanced")]
        NoMIBasedonMortgageBeingRefinanced = 1,
        /// <summary>
        /// Recourse In Lieu Of MI
        /// </summary>
        [Description("Recourse In Lieu Of MI")]
        RecourseInLieuOfMI = 2,
        /// <summary>
        /// No MI Based On Investor Requirements (FRE)
        /// </summary>
        [Description("No MI Based On Investor Requirements (FRE)")]
        NoMIBasedOnInvestorRequirements = 3
    }
}