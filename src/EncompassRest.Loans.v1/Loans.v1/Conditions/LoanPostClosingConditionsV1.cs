namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// The Loan PostClosing Conditions Apis.
    /// </summary>
    public interface ILoanPostClosingConditionsV1 : ILoanConditionsV1<PostClosingCondition>
    {
    }

    internal sealed class LoanPostClosingConditionsV1 : LoanConditionsV1<PostClosingCondition>, ILoanPostClosingConditionsV1
    {
        internal LoanPostClosingConditionsV1(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "postclosing")
        {
        }
    }
}