namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTab2Rights
    /// </summary>
    public sealed class CustomFieldsTab2Rights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editTab2CustomFields;

        /// <summary>
        /// CustomFieldsTab2Rights EditTab2CustomFields
        /// </summary>
        public bool? EditTab2CustomFields { get => _editTab2CustomFields; set => SetField(ref _editTab2CustomFields, value); }
    }
}