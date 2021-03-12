using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// LoanRights
    /// </summary>
    public sealed class LoanRights : DirtyExtensibleObject
    {
        private ClosingDocsRights? _closingDocs;
        private ItemizationFeeRights? _itemizationFee;
        private MilestoneWorkFlowManagementRights? _milestoneWorkFlowManagement;
        private LoanOtherRights? _other;
        private DirtyValue<bool?>? _otherChangeRESPATILAFormVersion;
        private DirtyValue<bool?>? _otherChangeURLAFormVersion;
        private OtherDisplayMilestoneListChangeScreenRights? _otherDisplayMilestoneListChangeScreen;
        private PrintRights? _print;

        /// <summary>
        /// LoanRights ClosingDocs
        /// </summary>
        [AllowNull]
        public ClosingDocsRights ClosingDocs { get => GetField(ref _closingDocs); set => SetField(ref _closingDocs, value); }

        /// <summary>
        /// LoanRights ItemizationFee
        /// </summary>
        [AllowNull]
        public ItemizationFeeRights ItemizationFee { get => GetField(ref _itemizationFee); set => SetField(ref _itemizationFee, value); }

        /// <summary>
        /// LoanRights MilestoneWorkFlowManagement
        /// </summary>
        [JsonProperty("milestone/WorkFlowManagement")]
        [AllowNull]
        public MilestoneWorkFlowManagementRights MilestoneWorkFlowManagement { get => GetField(ref _milestoneWorkFlowManagement); set => SetField(ref _milestoneWorkFlowManagement, value); }

        /// <summary>
        /// LoanRights Other
        /// </summary>
        [AllowNull]
        public LoanOtherRights Other { get => GetField(ref _other); set => SetField(ref _other, value); }

        /// <summary>
        /// LoanRights OtherChangeRESPATILAFormVersion
        /// </summary>
        [JsonProperty("other_ChangeRESPA-TILAFormVersion")]
        public bool? OtherChangeRESPATILAFormVersion { get => _otherChangeRESPATILAFormVersion; set => SetField(ref _otherChangeRESPATILAFormVersion, value); }

        /// <summary>
        /// LoanRights OtherChangeURLAFormVersion
        /// </summary>
        [JsonProperty("other_ChangeURLAFormVersion")]
        public bool? OtherChangeURLAFormVersion { get => _otherChangeURLAFormVersion; set => SetField(ref _otherChangeURLAFormVersion, value); }

        /// <summary>
        /// LoanRights OtherDisplayMilestoneListChangeScreen
        /// </summary>
        [JsonProperty("other_DisplayMilestoneListChangeScreen")]
        [AllowNull]
        public OtherDisplayMilestoneListChangeScreenRights OtherDisplayMilestoneListChangeScreen { get => GetField(ref _otherDisplayMilestoneListChangeScreen); set => SetField(ref _otherDisplayMilestoneListChangeScreen, value); }

        /// <summary>
        /// LoanRights Print
        /// </summary>
        public PrintRights Print { get => GetField(ref _print); set => SetField(ref _print, value); }
    }
}