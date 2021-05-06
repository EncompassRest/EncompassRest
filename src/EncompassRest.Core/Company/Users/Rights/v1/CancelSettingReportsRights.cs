namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CancelSettingReportsRights
    /// </summary>
    public sealed class CancelSettingReportsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _cancelSettingsReportsSubmittedByOthers;

        /// <summary>
        /// CancelSettingReportsRights CancelSettingsReportsSubmittedByOthers
        /// </summary>
        public bool? CancelSettingsReportsSubmittedByOthers { get => _cancelSettingsReportsSubmittedByOthers; set => SetField(ref _cancelSettingsReportsSubmittedByOthers, value); }
    }
}