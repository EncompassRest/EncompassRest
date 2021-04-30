namespace EncompassRest.Loans.Conditions.v1
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
        internal LoanUnderwritingConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "underwriting")
        {
        }
    }
}