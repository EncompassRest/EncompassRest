namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTab4Rights
    /// </summary>
    public sealed class CustomFieldsTab4Rights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editTab4CustomFields;

        /// <summary>
        /// CustomFieldsTab4Rights EditTab4CustomFields
        /// </summary>
        public bool? EditTab4CustomFields { get => _editTab4CustomFields; set => SetField(ref _editTab4CustomFields, value); }
    }
}