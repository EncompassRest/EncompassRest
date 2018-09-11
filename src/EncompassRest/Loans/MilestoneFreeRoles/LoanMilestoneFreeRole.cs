namespace EncompassRest.Loans.MilestoneFreeRoles
{
    public sealed class LoanMilestoneFreeRole : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => SetField(ref _id, value); }
        private LoanAssociate _loanAssociate;
        public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }
    }
}