using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    partial class Application
    {
        string IIdentifiable.Id { get => Id ?? ApplicationId; set { Id = value; ApplicationId = value; } }
    }

    partial class CustomField
    {
        [IdPropertyName(nameof(FieldName))]
        string IIdentifiable.Id { get => FieldName; set => FieldName = value; }
    }

    partial class FieldLockData
    {
        [IdPropertyName(nameof(ModelPath))]
        string IIdentifiable.Id { get => ModelPath; set => ModelPath = value; }
    }

    [Entity(PropertiesToAlwaysSerialize = nameof(LoanAssociateType))]
    partial class LoanAssociate
    {
        public LoanAssociate(string id, LoanAssociateType loanAssociateType)
            : this(id, loanAssociateType.Validate(nameof(loanAssociateType)).GetValue())
        {
        }

        public LoanAssociate(string id, string loanAssociateType)
        {
            Preconditions.NotNullOrEmpty(id, nameof(id));
            Preconditions.NotNullOrEmpty(loanAssociateType, nameof(loanAssociateType));

            Id = id;
            LoanAssociateType = loanAssociateType;
        }

        [JsonConstructor]
        public LoanAssociate()
        {
        }
    }
}