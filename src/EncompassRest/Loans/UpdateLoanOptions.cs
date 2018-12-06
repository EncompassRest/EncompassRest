using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The loan update options.
    /// </summary>
    public sealed class UpdateLoanOptions : LoanOptions
    {
        /// <summary>
        /// When applying a loan template, set to <c>true</c> to only write the non-blank field values in the template to the loan. Set to <c>false</c> to write all field values in the template (including blank fields) to the loan.
        /// </summary>
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