namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MasterCommitmentsRights
    /// </summary>
    public sealed class MasterCommitmentsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editMasterContracts;

        /// <summary>
        /// MasterCommitmentsRights EditMasterContracts
        /// </summary>
        public bool? EditMasterContracts { get => _editMasterContracts; set => SetField(ref _editMasterContracts, value); }
    }
}