namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ParentAccessRights
    /// </summary>
    public abstract class ParentAccessRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ParentAccessRights ParentAccess
        /// </summary>
        public bool? ParentAccess { get => GetValue<bool?>(); set => SetValue(value); }
    }
}