namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// TrashFolderTasksRights
    /// </summary>
    public sealed class TrashFolderTasksRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _deleteLoansPermanently;
        private DirtyValue<bool?> _restoreLoanstoFolder;

        /// <summary>
        /// TrashFolderTasksRights DeleteLoansPermanently
        /// </summary>
        public bool? DeleteLoansPermanently { get => _deleteLoansPermanently; set => SetField(ref _deleteLoansPermanently, value); }

        /// <summary>
        /// TrashFolderTasksRights RestoreLoanstoFolder
        /// </summary>
        public bool? RestoreLoanstoFolder { get => _restoreLoanstoFolder; set => SetField(ref _restoreLoanstoFolder, value); }
    }
}