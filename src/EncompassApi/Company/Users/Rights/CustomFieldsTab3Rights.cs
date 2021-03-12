namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// CustomFieldsTab3Rights
    /// </summary>
    public sealed class CustomFieldsTab3Rights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editTab3CustomFields;

        /// <summary>
        /// CustomFieldsTab3Rights EditTab3CustomFields
        /// </summary>
        public bool? EditTab3CustomFields { get => _editTab3CustomFields; set => SetField(ref _editTab3CustomFields, value); }
    }
}