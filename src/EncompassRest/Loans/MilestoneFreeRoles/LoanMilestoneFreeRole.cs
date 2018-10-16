namespace EncompassRest.Loans.MilestoneFreeRoles
{
    public sealed class LoanMilestoneFreeRole : DirtyExtensibleObject
    {
        private DirtyValue<string> _id;
        private LoanAssociate _loanAssociate;

        public string Id { get => _id; set => SetField(ref _id, value); }
        
        public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }
    }
}