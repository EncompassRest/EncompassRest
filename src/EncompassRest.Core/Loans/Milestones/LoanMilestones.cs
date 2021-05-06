namespace EncompassRest.Loans.Milestones
{
    /// <summary>
    /// The Loan Milestones Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.Milestones.v1 namespace.
    /// </summary>
    public interface ILoanMilestones : ILoanApiObject
    {
    }

    internal sealed class LoanMilestones : LoanApiObject, ILoanMilestones
    {
        internal LoanMilestones(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }
    }
}