using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// JointAssetLiabilityReportingIndicator
    /// </summary>
    public enum JointAssetLiabilityReportingIndicator
    {
        /// <summary>
        /// Jointly
        /// </summary>
        Jointly = 0,
        /// <summary>
        /// Not Jointly
        /// </summary>
        [Description("Not Jointly")]
        NotJointly = 1
    }
}