using System.ComponentModel;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// LoanToConduitCode
    /// </summary>
    public enum LoanToConduitCode
    {
        /// <summary>
        /// First Union Capital Markets
        /// </summary>
        [Description("First Union Capital Markets")]
        FUB = 0,
        /// <summary>
        /// GE Capital Mortgage Services, Inc
        /// </summary>
        [Description("GE Capital Mortgage Services, Inc")]
        GE = 1,
        /// <summary>
        /// Indy Mac and Affiliates
        /// </summary>
        [Description("Indy Mac and Affiliates")]
        IND = 2,
        /// <summary>
        /// Ocwen Financial Corporation
        /// </summary>
        [Description("Ocwen Financial Corporation")]
        OCW = 3,
        /// <summary>
        /// Residential Funding Corporation
        /// </summary>
        [Description("Residential Funding Corporation")]
        RFC = 4,
        /// <summary>
        /// The Money Store
        /// </summary>
        [Description("The Money Store")]
        TMS = 5
    }
}