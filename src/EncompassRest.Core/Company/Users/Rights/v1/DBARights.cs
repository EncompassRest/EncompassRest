namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DBARights
    /// </summary>
    public sealed class DBARights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editDBA;

        /// <summary>
        /// DBARights EditDBA
        /// </summary>
        public bool? EditDBA { get => _editDBA; set => SetField(ref _editDBA, value); }
    }
}