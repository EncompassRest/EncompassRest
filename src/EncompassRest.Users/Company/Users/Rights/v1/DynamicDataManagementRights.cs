namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DynamicDataManagementRights
    /// </summary>
    public sealed class DynamicDataManagementRights : ParentAccessRights
    {
        /// <summary>
        /// DynamicDataManagementRights DataTables
        /// </summary>
        public bool? DataTables { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DynamicDataManagementRights FeeRules
        /// </summary>
        public bool? FeeRules { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DynamicDataManagementRights FieldRules
        /// </summary>
        public bool? FieldRules { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DynamicDataManagementRights GlobalDDMSettings
        /// </summary>
        public bool? GlobalDDMSettings { get => GetValue<bool?>(); set => SetValue(value); }
    }
}