namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PersonasRights
    /// </summary>
    public sealed class PersonasRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _edit;

        /// <summary>
        /// PersonasRights Edit
        /// </summary>
        public bool? Edit { get => _edit; set => SetField(ref _edit, value); }
    }
}