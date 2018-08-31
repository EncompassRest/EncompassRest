using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public sealed class UpdateLoanOptions : LoanOptions
    {
        public bool AppendData { get; set; } = false;

        /// <summary>
        /// If set to <c>false</c> in combination with <see cref="LoanOptions.Populate"/> having a <c>true</c> value allows you
        /// to recalculate changes to your local <see cref="Loan"/> object without persisting those changes to the server.
        /// </summary>
        public bool? Persistent { get; set; }

        internal override QueryParameters ToQueryParameters(bool forPersistingTransientUpdates = false)
        {
            var queryParameters = base.ToQueryParameters();
            if (!string.IsNullOrEmpty(LoanTemplate))
            {
                queryParameters.Add("appendData", AppendData.ToString().ToLower());
            }
            if (Persistent.HasValue && !forPersistingTransientUpdates)
            {
                queryParameters.Add("persistent", Persistent.ToString().ToLower());
            }
            return queryParameters;
        }
    }
}