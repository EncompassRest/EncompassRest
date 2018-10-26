namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// LOCompRights
    /// </summary>
    public sealed class LOCompRights : ParentAccessRights
    {
        private DirtyValue<bool?> _editLOComp;

        /// <summary>
        /// LOCompRights EditLOComp
        /// </summary>
        public bool? EditLOComp { get => _editLOComp; set => SetField(ref _editLOComp, value); }
    }
}