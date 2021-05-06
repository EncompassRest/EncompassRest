using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// PoolAccrualRateStructureType
    /// </summary>
    public enum PoolAccrualRateStructureType
    {
        /// <summary>
        /// Stated Structure
        /// </summary>
        [Description("Stated Structure")]
        StatedStructure = 0,
        /// <summary>
        /// Weighted Average Structure
        /// </summary>
        [Description("Weighted Average Structure")]
        WeightedAverageStructure = 1
    }
}