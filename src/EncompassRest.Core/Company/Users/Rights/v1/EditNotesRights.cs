namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EditNotesRights
    /// </summary>
    public sealed class EditNotesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deleteNotes;

        /// <summary>
        /// EditNotesRights DeleteNotes
        /// </summary>
        public bool? DeleteNotes { get => _deleteNotes; set => SetField(ref _deleteNotes, value); }
    }
}