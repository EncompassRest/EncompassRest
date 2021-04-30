namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AddNotesToFileRights
    /// </summary>
    public sealed class AddNotesToFileRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deleteNotes;

        /// <summary>
        /// AddNotesToFileRights DeleteNotes
        /// </summary>
        public bool? DeleteNotes { get => _deleteNotes; set => SetField(ref _deleteNotes, value); }
    }
}