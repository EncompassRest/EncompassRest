namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AddNotesToFileRights
    /// </summary>
    public sealed class AddNotesToFileRights : ParentAccessRights
    {
        /// <summary>
        /// AddNotesToFileRights DeleteNotes
        /// </summary>
        public bool? DeleteNotes { get => GetValue<bool?>(); set => SetValue(value); }
    }
}