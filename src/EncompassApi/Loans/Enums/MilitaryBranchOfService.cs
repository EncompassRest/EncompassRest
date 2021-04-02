using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// MilitaryBranchOfService
    /// </summary>
    public enum MilitaryBranchOfService
    {
        /// <summary>
        /// Air Force
        /// </summary>
        [Description("Air Force")]
        AirForce = 0,
        /// <summary>
        /// Army
        /// </summary>
        Army = 1,
        /// <summary>
        /// Coast Guard
        /// </summary>
        [Description("Coast Guard")]
        CoastGuard = 2,
        /// <summary>
        /// Marines
        /// </summary>
        [Description("Marines")]
        Marine = 3,
        /// <summary>
        /// Navy
        /// </summary>
        Navy = 4,
        /// <summary>
        /// Other
        /// </summary>
        Other = 5
    }
}