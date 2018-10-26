using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// SettingsReportRights
    /// </summary>
    public sealed class SettingsReportRights : DirtyExtensibleObject
    {
        private CancelSettingReportsRights _cancelSettingReports;
        private DirtyValue<bool?> _deleteSettingsReports;
        private DirtyValue<bool?> _generateViewSettingsReports;
        private DirtyValue<bool?> _viewSettingsReportsSubmittedByOthers;

        /// <summary>
        /// SettingsReportRights CancelSettingReports
        /// </summary>
        public CancelSettingReportsRights CancelSettingReports { get => GetField(ref _cancelSettingReports); set => SetField(ref _cancelSettingReports, value); }

        /// <summary>
        /// SettingsReportRights DeleteSettingsReports
        /// </summary>
        public bool? DeleteSettingsReports { get => _deleteSettingsReports; set => SetField(ref _deleteSettingsReports, value); }

        /// <summary>
        /// SettingsReportRights GenerateViewSettingsReports
        /// </summary>
        [JsonProperty("generate&ViewSettingsReports")]
        public bool? GenerateViewSettingsReports { get => _generateViewSettingsReports; set => SetField(ref _generateViewSettingsReports, value); }

        /// <summary>
        /// SettingsReportRights ViewSettingsReportsSubmittedByOthers
        /// </summary>
        public bool? ViewSettingsReportsSubmittedByOthers { get => _viewSettingsReportsSubmittedByOthers; set => SetField(ref _viewSettingsReportsSubmittedByOthers, value); }
    }
}