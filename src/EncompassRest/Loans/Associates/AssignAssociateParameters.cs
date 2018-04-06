using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Associates
{
    public sealed class AssignAssociateParameters
    {
        public StringEnumValue<LoanAssociateType> LoanAssociateType { get; }

        public string Id { get; }

        public AssignAssociateParameters(LoanAssociateType loanAssociateType, string id)
            : this(loanAssociateType.Validate(nameof(loanAssociateType)).AsString(EnumFormat.EnumMemberValue, EnumFormat.Name), id)
        {
        }

        public AssignAssociateParameters(string loanAssociateType, string id)
        {
            Preconditions.NotNullOrEmpty(loanAssociateType, nameof(loanAssociateType));
            Preconditions.NotNullOrEmpty(id, nameof(id));

            LoanAssociateType = loanAssociateType;
            Id = id;
        }
    }
}