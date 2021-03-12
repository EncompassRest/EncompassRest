namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Underwriting Conditions Apis.
    /// </summary>
    public interface ILoanUnderwritingConditions : ILoanConditions<UnderwritingCondition>
    {
    }

    /// <summary>
    /// The Loan Underwriting Conditions Apis.
    /// </summary>
    public sealed class LoanUnderwritingConditions : LoanConditions<UnderwritingCondition>, ILoanUnderwritingConditions
    {
        internal LoanUnderwritingConditions(IEncompassRestClient client, string loanId)
            : base(client, loanId, "underwriting")
        {
        }
    }
}