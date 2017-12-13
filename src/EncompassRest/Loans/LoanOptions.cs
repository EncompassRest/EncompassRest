using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public abstract class LoanOptions
    {
        public bool Populate { get; set; }

        public string LoanTemplate { get; set; }

        internal LoanOptions()
        {
        }

        internal virtual QueryParameters ToQueryParameters()
        {
            var queryParameters = new QueryParameters();
            if (Populate)
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