namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EditNotesRights
    /// </summary>
    public sealed class EditNotesRights : ParentAccessRights
    {
        /// <summary>
        /// EditNotesRights DeleteNotes
        /// </summary>
        public bool? DeleteNotes { get => GetValue<bool?>(); set => SetValue(value); }
    }
}