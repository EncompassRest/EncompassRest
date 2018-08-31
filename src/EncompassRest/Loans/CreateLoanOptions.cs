using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public sealed class CreateLoanOptions : LoanOptions
    {
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