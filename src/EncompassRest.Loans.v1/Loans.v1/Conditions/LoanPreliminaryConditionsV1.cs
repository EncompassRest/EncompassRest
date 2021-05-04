namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// The Loan Preliminary Conditions Apis.
    /// </summary>
    public interface ILoanPreliminaryConditionsV1 : ILoanConditionsV1<PreliminaryCondition>
    {
    }

    internal sealed class LoanPreliminaryConditionsV1 : LoanConditionsV1<PreliminaryCondition>, ILoanPreliminaryConditionsV1
    {
        internal LoanPreliminaryConditionsV1(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "preliminary")
        {
        }
    }
}