namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CancelSettingReportsRights
    /// </summary>
    public sealed class CancelSettingReportsRights : ParentAccessRights
    {
        /// <summary>
        /// CancelSettingReportsRights CancelSettingsReportsSubmittedByOthers
        /// </summary>
        public bool? CancelSettingsReportsSubmittedByOthers { get => GetValue<bool?>(); set => SetValue(value); }
    }
}