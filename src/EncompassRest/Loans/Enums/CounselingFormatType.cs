using System.ComponentModel;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CounselingFormatType
    /// </summary>
    public enum CounselingFormatType
    {
        /// <summary>
        /// Borrower Education Not Required
        /// </summary>
        [Description("Borrower Education Not Required")]
        BorrowerEducationNotRequired = 0,
        /// <summary>
        /// Classroom
        /// </summary>
        Classroom = 1,
        /// <summary>
        /// Home Study
        /// </summary>
        [Description("Home Study")]
        HomeStudy = 2,
        /// <summary>
        /// Individual
        /// </summary>
        Individual = 3,
        /// <summary>
        /// Other
        /// </summary>
        Other = 4
    }
}