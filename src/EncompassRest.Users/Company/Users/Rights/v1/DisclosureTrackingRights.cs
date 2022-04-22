using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DisclosureTrackingRights
    /// </summary>
    public sealed class DisclosureTrackingRights : ParentAccessRights
    {
        /// <summary>
        /// DisclosureTrackingRights ChangeDisclosureInformation
        /// </summary>
        [AllowNull]
        public ChangeDisclosureInformationRights ChangeDisclosureInformation { get => GetEntity<ChangeDisclosureInformationRights>(); set => SetEntity(value); }

        /// <summary>
        /// DisclosureTrackingRights CreateManualEntry
        /// </summary>
        [AllowNull]
        public CreateManualEntryRights CreateManualEntry { get => GetEntity<CreateManualEntryRights>(); set => SetEntity(value); }

        /// <summary>
        /// DisclosureTrackingRights ExcludeIncludeRecords
        /// </summary>
        [JsonProperty("exclude/IncludeRecords")]
        public bool? ExcludeIncludeRecords { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// DisclosureTrackingRights ManuallyFulfill
        /// </summary>
        public bool? ManuallyFulfill { get => GetValue<bool?>(); set => SetValue(value); }
    }
}