namespace EncompassApi.Loans.Conditions
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
        internal LoanUnderwritingConditions(EncompassApiClient client, string loanId)
            : base(client, loanId, "underwriting")
        {
        }
    }
}