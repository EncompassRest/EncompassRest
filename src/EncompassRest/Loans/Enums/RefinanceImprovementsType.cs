using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// RefinanceImprovementsType
    /// </summary>
    public enum RefinanceImprovementsType
    {
        /// <summary>
        /// made
        /// </summary>
        [Description("made")]
        Made = 0,
        /// <summary>
        /// to be made
        /// </summary>
        [Description("to be made")]
        ToBeMade = 1
    }
}