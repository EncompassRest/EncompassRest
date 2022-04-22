namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ManageAccessToDocumentsRights
    /// </summary>
    public sealed class ManageAccessToDocumentsRights : ParentAccessRights
    {
        /// <summary>
        /// ManageAccessToDocumentsRights RemoveAccessFromProtectedRoles
        /// </summary>
        public bool? RemoveAccessFromProtectedRoles { get => GetValue<bool?>(); set => SetValue(value); }
    }
}