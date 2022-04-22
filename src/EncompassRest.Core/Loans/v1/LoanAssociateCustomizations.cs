using EncompassRest.Loans.Enums;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Loans.v1
{
    [Entity(PropertiesToAlwaysSerialize = nameof(LoanAssociateType))]
    partial class LoanAssociate
    {
        /// <summary>
        /// The loan associate constructor.
        /// </summary>
        /// <param name="id">The loan associate id.</param>
        /// <param name="loanAssociateType">The loan associate type.</param>
        public LoanAssociate(string id, LoanAssociateType loanAssociateType)
            : this(id, loanAssociateType.Validate(nameof(loanAssociateType)).GetValue())
        {
        }

        /// <summary>
        /// The loan associate constructor.
        /// </summary>
        /// <param name="id">The loan associate id.</param>
        /// <param name="loanAssociateType">The loan associate type.</param>
        public LoanAssociate(string id, string loanAssociateType)
        {
            Preconditions.NotNullOrEmpty(id, nameof(id));
            Preconditions.NotNullOrEmpty(loanAssociateType, nameof(loanAssociateType));

            Id = id;
            LoanAssociateType = loanAssociateType;
        }

        /// <summary>
        /// The loan associate constructor.
        /// </summary>
        [JsonConstructor]
        public LoanAssociate()
        {
        }
    }
}