namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTab1Rights
    /// </summary>
    public sealed class CustomFieldsTab1Rights : ParentAccessRights
    {
        /// <summary>
        /// CustomFieldsTab1Rights EditTab1CustomFields
        /// </summary>
        public bool? EditTab1CustomFields { get => GetValue<bool?>(); set => SetValue(value); }
    }
}