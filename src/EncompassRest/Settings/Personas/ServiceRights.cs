namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// ServiceRights
    /// </summary>
    public sealed class ServiceRights : DirtyExtensibleObject
    {
        private DirtyValue<StringEnumValue<ServiceCategory>> _category;
        private DirtyValue<StringEnumValue<AccessSetting>> _accessSetting;
        private DirtyValue<StringEnumValue<RightsDefaultAccess>> _defaultAccess;

        /// <summary>
        /// ServiceRights Category
        /// </summary>
        public StringEnumValue<ServiceCategory> Category { get => _category; set => SetField(ref _category, value); }

        /// <summary>
        /// ServiceRights AccessSetting
        /// </summary>
        public StringEnumValue<AccessSetting> AccessSetting { get => _accessSetting; set => SetField(ref _accessSetting, value); }

        /// <summary>
        /// ServiceRights DefaultAccess
        /// </summary>
        public StringEnumValue<RightsDefaultAccess> DefaultAccess { get => _defaultAccess; set => SetField(ref _defaultAccess, value); }
    }
}