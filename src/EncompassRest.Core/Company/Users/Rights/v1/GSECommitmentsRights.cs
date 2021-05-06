namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// GSECommitmentsRights
    /// </summary>
    public sealed class GSECommitmentsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editGSECommitments;

        /// <summary>
        /// GSECommitmentsRights EditGSECommitments
        /// </summary>
        public bool? EditGSECommitments { get => _editGSECommitments; set => SetField(ref _editGSECommitments, value); }
    }
}