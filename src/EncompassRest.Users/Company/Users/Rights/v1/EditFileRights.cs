namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EditFileRights
    /// </summary>
    public sealed class EditFileRights : ParentAccessRights
    {
        /// <summary>
        /// EditFileRights DeletePagePermanently
        /// </summary>
        public bool? DeletePagePermanently { get => GetValue<bool?>(); set => SetValue(value); }
    }
}