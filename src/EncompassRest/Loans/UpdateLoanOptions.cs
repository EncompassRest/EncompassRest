using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    public sealed class UpdateLoanOptions : LoanOptions
    {
        public bool AppendData { get; set; }

        internal override QueryParameters ToQueryParameters()
        {
            var queryParameters = base.ToQueryParameters();
            if (!string.IsNullOrEmpty(LoanTemplate))
            {
                queryParameters.Add("appendData", AppendData.ToString().ToLower());
            }
            return queryParameters;
        }
    }
}