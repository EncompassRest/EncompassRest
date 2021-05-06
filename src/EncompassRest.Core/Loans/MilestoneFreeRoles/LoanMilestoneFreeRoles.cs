namespace EncompassRest.Loans.MilestoneFreeRoles
{
    /// <summary>
    /// The Loan Milestone Free Roles Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.MilestoneFreeRoles.v1 namespace.
    /// </summary>
    public interface ILoanMilestoneFreeRoles : ILoanApiObject
    {
    }

    internal sealed class LoanMilestoneFreeRoles : LoanApiObject, ILoanMilestoneFreeRoles
    {
        internal LoanMilestoneFreeRoles(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}