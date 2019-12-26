namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// CustomFieldsTabRights
    /// </summary>
    public sealed class CustomFieldsTabRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _customFieldsTab1;
        private DirtyValue<bool?>? _customFieldsTab2;
        private DirtyValue<bool?>? _customFieldsTab3;
        private DirtyValue<bool?>? _customFieldsTab4;
        private DirtyValue<bool?>? _customFieldsTab5;

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab1
        /// </summary>
        public bool? CustomFieldsTab1 { get => _customFieldsTab1; set => SetField(ref _customFieldsTab1, value); }

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab2
        /// </summary>
        public bool? CustomFieldsTab2 { get => _customFieldsTab2; set => SetField(ref _customFieldsTab2, value); }

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab3
        /// </summary>
        public bool? CustomFieldsTab3 { get => _customFieldsTab3; set => SetField(ref _customFieldsTab3, value); }

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab4
        /// </summary>
        public bool? CustomFieldsTab4 { get => _customFieldsTab4; set => SetField(ref _customFieldsTab4, value); }

        /// <summary>
        /// CustomFieldsTabRights CustomFieldsTab5
        /// </summary>
        public bool? CustomFieldsTab5 { get => _customFieldsTab5; set => SetField(ref _customFieldsTab5, value); }
    }
}