namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// OrganizationsUserRights
    /// </summary>
    public sealed class OrganizationsUserRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addLEI;
        private DirtyValue<bool?>? _editLEI;

        /// <summary>
        /// OrganizationsUserRights AddLEI
        /// </summary>
        public bool? AddLEI { get => _addLEI; set => SetField(ref _addLEI, value); }

        /// <summary>
        /// OrganizationsUserRights EditLEI
        /// </summary>
        public bool? EditLEI { get => _editLEI; set => SetField(ref _editLEI, value); }
    }
}