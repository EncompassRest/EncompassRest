namespace EncompassRest.Loans.MilestoneFreeRoles
{
    public sealed class LoanMilestoneFreeRole : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private LoanAssociate _loanAssociate;
        public LoanAssociate LoanAssociate { get => _loanAssociate ?? (_loanAssociate = new LoanAssociate()); set => _loanAssociate = value; }
    }
}