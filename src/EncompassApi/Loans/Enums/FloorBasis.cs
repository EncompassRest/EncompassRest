using System.ComponentModel;

namespace EncompassApi.Loans.Enums
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