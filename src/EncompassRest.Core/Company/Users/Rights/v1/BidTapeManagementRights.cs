namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// BidTapeManagementRights
    /// </summary>
    public sealed class BidTapeManagementRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editBidTapeManagement;

        /// <summary>
        /// BidTapeManagementRights EditBidTapeManagement
        /// </summary>
        public bool? EditBidTapeManagement { get => _editBidTapeManagement; set => SetField(ref _editBidTapeManagement, value); }
    }
}