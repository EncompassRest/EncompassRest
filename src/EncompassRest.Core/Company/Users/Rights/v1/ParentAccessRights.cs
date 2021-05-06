namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ParentAccessRights
    /// </summary>
    public abstract class ParentAccessRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _parentAccess;

        /// <summary>
        /// ParentAccessRights ParentAccess
        /// </summary>
        public bool? ParentAccess { get => _parentAccess; set => SetField(ref _parentAccess, value); }
    }
}