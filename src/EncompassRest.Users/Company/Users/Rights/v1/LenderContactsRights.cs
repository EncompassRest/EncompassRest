namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LenderContactsRights
    /// </summary>
    public sealed class LenderContactsRights : ParentAccessRights
    {
        /// <summary>
        /// LenderContactsRights EditLenderContacts
        /// </summary>
        public bool? EditLenderContacts { get => GetValue<bool?>(); set => SetValue(value); }
    }
}