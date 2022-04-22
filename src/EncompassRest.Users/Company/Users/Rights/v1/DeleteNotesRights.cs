namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DeleteNotesRights
    /// </summary>
    public sealed class DeleteNotesRights : DirtyExtensibleObject
    {
        /// <summary>
        /// DeleteNotesRights DeleteFilePermanently
        /// </summary>
        public bool? DeleteFilePermanently { get => GetValue<bool?>(); set => SetValue(value); }
    }
}