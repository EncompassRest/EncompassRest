using EncompassRest.Utilities;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loans Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.v1 namespace.
    /// </summary>
    public interface ILoans : IApiObject
    {
        /// <summary>
        /// Gets the Loan Apis for the loan with the specified <paramref name="loanId"/>. The Loan Apis exposed as extension methods from the Core and EncompassRest.Services packages
        /// within the EncompassRest.Loans.v1 namespace.
        /// </summary>
        /// <param name="loanId">The loan id.</param>
        /// <returns></returns>
        ILoanApis GetLoanApis(string loanId);
    }

    internal sealed class Loans : ApiObject, ILoans
    {
        internal Loans(EncompassRestClient client)
            : base(client, null)
        {
        }

        public ILoanApis GetLoanApis(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanApis(Client, loanId);
        }
    }
}