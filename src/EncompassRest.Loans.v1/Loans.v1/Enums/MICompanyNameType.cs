using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// MICompanyNameType
    /// </summary>
    public enum MICompanyNameType
    {
        /// <summary>
        /// CMG (FNM Removed 1/2017)
        /// </summary>
        [Description("CMG (FNM Removed 1/2017)")]
        CMG = 0,
        /// <summary>
        /// Essent
        /// </summary>
        Essent = 1,
        /// <summary>
        /// Genworth
        /// </summary>
        Genworth = 2,
        /// <summary>
        /// MGIC
        /// </summary>
        MGIC = 3,
        /// <summary>
        /// Other
        /// </summary>
        Other = 4,
        /// <summary>
        /// PMI
        /// </summary>
        PMI = 5,
        /// <summary>
        /// Radian
        /// </summary>
        Radian = 6,
        /// <summary>
        /// RMIC
        /// </summary>
        RMIC = 7,
        /// <summary>
        /// Triad
        /// </summary>
        Triad = 8,
        /// <summary>
        /// UGI
        /// </summary>
        UGI = 9
    }
}