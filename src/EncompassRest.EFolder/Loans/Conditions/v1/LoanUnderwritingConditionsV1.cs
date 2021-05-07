namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// The Loan Underwriting Conditions Apis.
    /// </summary>
    public interface ILoanUnderwritingConditionsV1 : ILoanConditionsV1<UnderwritingCondition>
    {
    }

    internal sealed class LoanUnderwritingConditionsV1 : LoanConditionsV1<UnderwritingCondition>, ILoanUnderwritingConditionsV1
    {
        internal LoanUnderwritingConditionsV1(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "underwriting")
        {
        }
    }
}