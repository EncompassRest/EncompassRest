using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan creation options.
    /// </summary>
    public sealed class CreateLoanOptions : LoanOptions
    {
        /// <summary>
        /// Name of the loan folder.
        /// </summary>
        public string LoanFolder { get; set; }
        
        /// <summary>
        /// The unique identifier of the User you want to assign as Loan Officer to the loan at the time of loan creation.
        /// </summary>
        public string LoId { get; set; }

        internal override QueryParameters ToQueryParameters()
        {
            var queryParameters = base.ToQueryParameters();
            if (!string.IsNullOrEmpty(LoanFolder))
            {
                queryParameters.Add("loanFolder", LoanFolder);
            }
            if (!string.IsNullOrEmpty(LoId))
            {
                queryParameters.Add("loId", LoId);
            }
            return queryParameters;
        }
    }
}