namespace EncompassRest.Loans
{
    public sealed class FileAttachmentReference : EntityReference
    {
        private DirtyValue<string> _refId;
        public string RefId { get => _refId; set => SetField(ref _refId, value); }
        private DirtyValue<bool?> _isActive;
        public bool? IsActive { get => _isActive; set => SetField(ref _isActive, value); }
    }
}