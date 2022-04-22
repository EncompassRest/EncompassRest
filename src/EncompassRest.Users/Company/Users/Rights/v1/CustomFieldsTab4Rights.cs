namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTab4Rights
    /// </summary>
    public sealed class CustomFieldsTab4Rights : ParentAccessRights
    {
        /// <summary>
        /// CustomFieldsTab4Rights EditTab4CustomFields
        /// </summary>
        public bool? EditTab4CustomFields { get => GetValue<bool?>(); set => SetValue(value); }
    }
}