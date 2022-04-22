namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTab5Rights
    /// </summary>
    public sealed class CustomFieldsTab5Rights : ParentAccessRights
    {
        /// <summary>
        /// CustomFieldsTab5Rights EditTab5CustomFields
        /// </summary>
        public bool? EditTab5CustomFields { get => GetValue<bool?>(); set => SetValue(value); }
    }
}