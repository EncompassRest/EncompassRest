using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// PropertyImprovementsType
    /// </summary>
    public enum PropertyImprovementsType
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