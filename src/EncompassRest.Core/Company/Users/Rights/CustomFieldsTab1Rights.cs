namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// CustomFieldsTab1Rights
    /// </summary>
    public sealed class CustomFieldsTab1Rights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editTab1CustomFields;

        /// <summary>
        /// CustomFieldsTab1Rights EditTab1CustomFields
        /// </summary>
        public bool? EditTab1CustomFields { get => _editTab1CustomFields; set => SetField(ref _editTab1CustomFields, value); }
    }
}