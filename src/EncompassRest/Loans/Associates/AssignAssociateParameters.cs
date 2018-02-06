using EncompassRest.Utilities;

namespace EncompassRest.Loans.Associates
{
    public sealed class AssignAssociateParameters
    {
        public string LoanAssociateType { get; }

        public string UserId { get; }

        public AssignAssociateParameters(string loanAssociateType, string userId)
        {
            Preconditions.NotNullOrEmpty(loanAssociateType, nameof(loanAssociateType));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));

            LoanAssociateType = loanAssociateType;
            UserId = userId;
        }
    }
}