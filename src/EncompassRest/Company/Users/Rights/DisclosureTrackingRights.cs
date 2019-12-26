using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// DisclosureTrackingRights
    /// </summary>
    public sealed class DisclosureTrackingRights : ParentAccessRights
    {
        private ChangeDisclosureInformationRights? _changeDisclosureInformation;
        private CreateManualEntryRights? _createManualEntry;
        private DirtyValue<bool?>? _excludeIncludeRecords;
        private DirtyValue<bool?>? _manuallyFulfill;

        /// <summary>
        /// DisclosureTrackingRights ChangeDisclosureInformation
        /// </summary>
        [AllowNull]
        public ChangeDisclosureInformationRights ChangeDisclosureInformation { get => GetField(ref _changeDisclosureInformation); set => SetField(ref _changeDisclosureInformation, value); }

        /// <summary>
        /// DisclosureTrackingRights CreateManualEntry
        /// </summary>
        [AllowNull]
        public CreateManualEntryRights CreateManualEntry { get => GetField(ref _createManualEntry); set => SetField(ref _createManualEntry, value); }

        /// <summary>
        /// DisclosureTrackingRights ExcludeIncludeRecords
        /// </summary>
        [JsonProperty("exclude/IncludeRecords")]
        public bool? ExcludeIncludeRecords { get => _excludeIncludeRecords; set => SetField(ref _excludeIncludeRecords, value); }

        /// <summary>
        /// DisclosureTrackingRights ManuallyFulfill
        /// </summary>
        public bool? ManuallyFulfill { get => _manuallyFulfill; set => SetField(ref _manuallyFulfill, value); }
    }
}