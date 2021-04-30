using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// ExportLoanNumber
    /// </summary>
    public enum ExportLoanNumber
    {
        /// <summary>
        /// Inv. loan # as Lender loan #
        /// </summary>
        [Description("Inv. loan # as Lender loan #")]
        UseInvestorNumber = 0,
        /// <summary>
        /// Lender loan # as Inv. loan #
        /// </summary>
        [Description("Lender loan # as Inv. loan #")]
        UseLoanNumber = 1
    }
}