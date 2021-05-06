using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// FloorBasis
    /// </summary>
    public enum FloorBasis
    {
        /// <summary>
        /// Note Rate
        /// </summary>
        [Description("Note Rate")]
        NoteRate = 0,
        /// <summary>
        /// Margin
        /// </summary>
        Margin = 1
    }
}