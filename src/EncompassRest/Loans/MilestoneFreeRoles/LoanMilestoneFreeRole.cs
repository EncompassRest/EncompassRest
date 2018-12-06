namespace EncompassRest.Loans.MilestoneFreeRoles
{
    /// <summary>
    /// LoanMilestoneFreeRole
    /// </summary>
    public sealed class LoanMilestoneFreeRole : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private LoanAssociate _loanAssociate;

        /// <summary>
        /// Unique Identifier of a milestone-free log.
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Object containing loan associate details.
        /// </summary>
        public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }
    }
}