using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public abstract class LoanOptions
    {
        public bool Populate { get; set; } = false;

        public string LoanTemplate { get; set; }

        internal LoanOptions()
        {
        }

        internal virtual QueryParameters ToQueryParameters(bool forPersistingTransientUpdates = false)
        {
            var queryParameters = new QueryParameters();
            if (Populate && !forPersistingTransientUpdates)
            {
                queryParameters.Add("view", "entity");
            }
            if (!string.IsNullOrEmpty(LoanTemplate))
            {
                queryParameters.Add("loanTemplate", LoanTemplate);
            }
            return queryParameters;
        }
    }
}