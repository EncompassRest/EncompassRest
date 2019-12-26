using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan options used in both creation and updates.
    /// </summary>
    public abstract class LoanOptions
    {
        /// <summary>
        /// Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.
        /// </summary>
        public bool Populate { get; set; } = false;

        /// <summary>
        /// Path to the loan template that will be applied to the loan.
        /// </summary>
        public string? LoanTemplate { get; set; }

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