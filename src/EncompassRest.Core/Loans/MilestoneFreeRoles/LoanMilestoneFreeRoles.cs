namespace EncompassRest.Loans.MilestoneFreeRoles
{
    /// <summary>
    /// The Loan Milestone Free Roles Apis.
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