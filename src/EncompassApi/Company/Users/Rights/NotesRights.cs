using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// NotesRights
    /// </summary>
    public sealed class NotesRights : ParentAccessRights
    {
        private EditNotesRights? _editNotes;

        /// <summary>
        /// NotesRights EditNotes
        /// </summary>
        [AllowNull]
        public EditNotesRights EditNotes { get => GetField(ref _editNotes); set => SetField(ref _editNotes, value); }
    }
}