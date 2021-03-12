namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// DynamicDataManagementRights
    /// </summary>
    public sealed class DynamicDataManagementRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _dataTables;
        private DirtyValue<bool?>? _feeRules;
        private DirtyValue<bool?>? _fieldRules;
        private DirtyValue<bool?>? _globalDDMSettings;

        /// <summary>
        /// DynamicDataManagementRights DataTables
        /// </summary>
        public bool? DataTables { get => _dataTables; set => SetField(ref _dataTables, value); }

        /// <summary>
        /// DynamicDataManagementRights FeeRules
        /// </summary>
        public bool? FeeRules { get => _feeRules; set => SetField(ref _feeRules, value); }

        /// <summary>
        /// DynamicDataManagementRights FieldRules
        /// </summary>
        public bool? FieldRules { get => _fieldRules; set => SetField(ref _fieldRules, value); }

        /// <summary>
        /// DynamicDataManagementRights GlobalDDMSettings
        /// </summary>
        public bool? GlobalDDMSettings { get => _globalDDMSettings; set => SetField(ref _globalDDMSettings, value); }
    }
}