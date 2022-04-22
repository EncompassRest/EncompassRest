using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// NotesRights
    /// </summary>
    public sealed class NotesRights : ParentAccessRights
    {
        /// <summary>
        /// NotesRights EditNotes
        /// </summary>
        [AllowNull]
        public EditNotesRights EditNotes { get => GetEntity<EditNotesRights>(); set => SetEntity(value); }
    }
}