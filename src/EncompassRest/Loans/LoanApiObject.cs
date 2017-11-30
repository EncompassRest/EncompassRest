namespace EncompassRest.Loans
{
    public abstract class LoanApiObject : ApiObject
    {
        public string LoanId { get; }

        internal LoanApiObject(EncompassRestClient client, string loanId, string baseApiPath)
            : base(client, $"encompass/v1/loans/{loanId}/{baseApiPath}")
        {
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{LoanId}{(string.IsNullOrEmpty(resourceId) ? string.Empty : $"/{resourceId}")}");
    }
}