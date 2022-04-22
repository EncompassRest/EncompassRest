namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// TrashFolderTasksRights
    /// </summary>
    public sealed class TrashFolderTasksRights : DirtyExtensibleObject
    {
        /// <summary>
        /// TrashFolderTasksRights DeleteLoansPermanently
        /// </summary>
        public bool? DeleteLoansPermanently { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// TrashFolderTasksRights RestoreLoanstoFolder
        /// </summary>
        public bool? RestoreLoanstoFolder { get => GetValue<bool?>(); set => SetValue(value); }
    }
}