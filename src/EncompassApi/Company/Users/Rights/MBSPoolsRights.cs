namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// MBSPoolsRights
    /// </summary>
    public sealed class MBSPoolsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editMBSPools;

        /// <summary>
        /// MBSPoolsRights EditMBSPools
        /// </summary>
        public bool? EditMBSPools { get => _editMBSPools; set => SetField(ref _editMBSPools, value); }
    }
}