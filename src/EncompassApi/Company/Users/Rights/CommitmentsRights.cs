namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// CommitmentsRights
    /// </summary>
    public sealed class CommitmentsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editCommitments;

        /// <summary>
        /// CommitmentsRights EditCommitments
        /// </summary>
        public bool? EditCommitments { get => _editCommitments; set => SetField(ref _editCommitments, value); }
    }
}