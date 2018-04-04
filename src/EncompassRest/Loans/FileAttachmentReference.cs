namespace EncompassRest.Loans
{
    public sealed class FileAttachmentReference : EntityReference
    {
        private DirtyValue<string> _refId;
        public string RefId { get => _refId; set => _refId = value; }
        private DirtyValue<bool?> _isActive;
        public bool? IsActive { get => _isActive; set => _isActive = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return base.DirtyInternal
                    || _refId.Dirty
                    || _isActive.Dirty;
            }
            set
            {
                _refId.Dirty = value;
                _isActive.Dirty = value;
                base.DirtyInternal = value;
            }
        }
    }
}