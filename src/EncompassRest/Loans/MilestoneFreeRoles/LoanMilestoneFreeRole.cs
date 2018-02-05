namespace EncompassRest.Loans.MilestoneFreeRoles
{
    public sealed class LoanMilestoneFreeRole : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private LoanAssociate _loanAssociate;
        public LoanAssociate LoanAssociate { get => _loanAssociate ?? (_loanAssociate = new LoanAssociate()); set => _loanAssociate = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
                    || _guid.Dirty
                    || _loanAssociate?.Dirty == true;
            }
            set
            {
                _id.Dirty = value;
                _guid.Dirty = value;
                if (_loanAssociate != null) _loanAssociate.Dirty = value;
            }
        }
    }
}