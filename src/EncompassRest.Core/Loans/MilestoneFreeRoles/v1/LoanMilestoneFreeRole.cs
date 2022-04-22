using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.v1;

namespace EncompassRest.Loans.MilestoneFreeRoles.v1
{
    /// <summary>
    /// LoanMilestoneFreeRole
    /// </summary>
    public sealed class LoanMilestoneFreeRole : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Unique Identifier of a milestone-free log.
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Object containing loan associate details.
        /// </summary>
        [AllowNull]
        public LoanAssociate LoanAssociate { get => GetEntity<LoanAssociate>(); set => SetEntity(value); }
    }
}