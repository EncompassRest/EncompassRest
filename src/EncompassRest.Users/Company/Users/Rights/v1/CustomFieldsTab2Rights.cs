namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTab2Rights
    /// </summary>
    public sealed class CustomFieldsTab2Rights : ParentAccessRights
    {
        /// <summary>
        /// CustomFieldsTab2Rights EditTab2CustomFields
        /// </summary>
        public bool? EditTab2CustomFields { get => GetValue<bool?>(); set => SetValue(value); }
    }
}