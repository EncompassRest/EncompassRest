using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// SettingsReportRights
    /// </summary>
    public sealed class SettingsReportRights : DirtyExtensibleObject
    {
        /// <summary>
        /// SettingsReportRights CancelSettingReports
        /// </summary>
        [AllowNull]
        public CancelSettingReportsRights CancelSettingReports { get => GetEntity<CancelSettingReportsRights>(); set => SetEntity(value); }

        /// <summary>
        /// SettingsReportRights DeleteSettingsReports
        /// </summary>
        public bool? DeleteSettingsReports { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SettingsReportRights GenerateViewSettingsReports
        /// </summary>
        [JsonProperty("generate&ViewSettingsReports")]
        public bool? GenerateViewSettingsReports { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// SettingsReportRights ViewSettingsReportsSubmittedByOthers
        /// </summary>
        public bool? ViewSettingsReportsSubmittedByOthers { get => GetValue<bool?>(); set => SetValue(value); }
    }
}