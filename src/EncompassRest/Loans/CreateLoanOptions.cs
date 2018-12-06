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

        internal override QueryParameters ToQueryParameters(bool forPersistingTransientUpdates = false)
        {
            var queryParameters = base.ToQueryParameters();
            if (!string.IsNullOrEmpty(LoanFolder))
            {
                queryParameters.Add("loanFolder", LoanFolder);
            }
            return queryParameters;
        }
    }
}