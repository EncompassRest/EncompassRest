namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// ManageAccessToDocumentsRights
    /// </summary>
    public sealed class ManageAccessToDocumentsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _removeAccessFromProtectedRoles;

        /// <summary>
        /// ManageAccessToDocumentsRights RemoveAccessFromProtectedRoles
        /// </summary>
        public bool? RemoveAccessFromProtectedRoles { get => _removeAccessFromProtectedRoles; set => SetField(ref _removeAccessFromProtectedRoles, value); }
    }
}