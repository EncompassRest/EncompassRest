using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BuildingStatusType
    /// </summary>
    public enum BuildingStatusType
    {
        /// <summary>
        /// Existing
        /// </summary>
        Existing = 0,
        /// <summary>
        /// Proposed
        /// </summary>
        Proposed = 1,
        /// <summary>
        /// Subject To Alteration Improvement Repair And Rehabilitation
        /// </summary>
        [Description("Subject To Alteration Improvement Repair And Rehabilitation")]
        SubjectToAlterationImprovementRepairAndRehabilitation = 2,
        /// <summary>
        /// Substantially Rehabilitated
        /// </summary>
        [Description("Substantially Rehabilitated")]
        SubstantiallyRehabilitated = 3,
        /// <summary>
        /// Under Construction
        /// </summary>
        [Description("Under Construction")]
        UnderConstruction = 4
    }
}