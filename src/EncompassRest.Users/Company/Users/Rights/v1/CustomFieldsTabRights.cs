namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CustomFieldsTabRights
    /// </summary>
    public sealed class CustomFieldsTabRights : ParentAccessRights
    {
        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab1
        /// </summary>
        public bool? CustomFieldsTab1 { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab2
        /// </summary>
        public bool? CustomFieldsTab2 { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab3
        /// </summary>
        public bool? CustomFieldsTab3 { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab4
        /// </summary>
        public bool? CustomFieldsTab4 { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab5
        /// </summary>
        public bool? CustomFieldsTab5 { get => GetValue<bool?>(); set => SetValue(value); }
    }
}