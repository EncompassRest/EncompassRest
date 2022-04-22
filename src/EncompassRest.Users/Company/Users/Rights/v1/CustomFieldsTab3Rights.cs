namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTab3Rights
    /// </summary>
    public sealed class CustomFieldsTab3Rights : ParentAccessRights
    {
        /// <summary>
        /// CustomFieldsTab3Rights EditTab3CustomFields
        /// </summary>
        public bool? EditTab3CustomFields { get => GetValue<bool?>(); set => SetValue(value); }
    }
}