namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Preliminary Conditions Apis.
    /// </summary>
    public interface ILoanPreliminaryConditions : ILoanConditions<PreliminaryCondition>
    {
    }

    /// <summary>
    /// The Loan Preliminary Conditions Apis.
    /// </summary>
    public sealed class LoanPreliminaryConditions : LoanConditions<PreliminaryCondition>, ILoanPreliminaryConditions
    {
        internal LoanPreliminaryConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "preliminary")
        {
        }
    }
}