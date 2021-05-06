namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTab5Rights
    /// </summary>
    public sealed class CustomFieldsTab5Rights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editTab5CustomFields;

        /// <summary>
        /// CustomFieldsTab5Rights EditTab5CustomFields
        /// </summary>
        public bool? EditTab5CustomFields { get => _editTab5CustomFields; set => SetField(ref _editTab5CustomFields, value); }
    }
}