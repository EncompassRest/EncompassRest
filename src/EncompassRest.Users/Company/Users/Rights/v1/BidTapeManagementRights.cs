namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// BidTapeManagementRights
    /// </summary>
    public sealed class BidTapeManagementRights : ParentAccessRights
    {
        /// <summary>
        /// BidTapeManagementRights EditBidTapeManagement
        /// </summary>
        public bool? EditBidTapeManagement { get => GetValue<bool?>(); set => SetValue(value); }
    }
}