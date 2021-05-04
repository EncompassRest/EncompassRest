namespace EncompassRest.Loans.Milestones
{
    /// <summary>
    /// The Loan Milestones Apis.
    /// </summary>
    public interface ILoanMilestones : ILoanApiObject
    {
    }

    internal sealed class LoanMilestones : LoanApiObject, ILoanMilestones
    {
        internal LoanMilestones(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "milestones")
        {
        }
    }
}