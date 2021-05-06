namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DeleteNotesRights
    /// </summary>
    public sealed class DeleteNotesRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _deleteFilePermanently;

        /// <summary>
        /// DeleteNotesRights DeleteFilePermanently
        /// </summary>
        public bool? DeleteFilePermanently { get => _deleteFilePermanently; set => SetField(ref _deleteFilePermanently, value); }
    }
}