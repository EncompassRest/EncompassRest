using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LoanRights
    /// </summary>
    public sealed class LoanRights : DirtyExtensibleObject
    {
        /// <summary>
        /// LoanRights ClosingDocs
        /// </summary>
        [AllowNull]
        public ClosingDocsRights ClosingDocs { get => GetEntity<ClosingDocsRights>(); set => SetEntity(value); }

        /// <summary>
        /// LoanRights ItemizationFee
        /// </summary>
        [AllowNull]
        public ItemizationFeeRights ItemizationFee { get => GetEntity<ItemizationFeeRights>(); set => SetEntity(value); }

        /// <summary>
        /// LoanRights MilestoneWorkFlowManagement
        /// </summary>
        [JsonProperty("milestone/WorkFlowManagement")]
        [AllowNull]
        public MilestoneWorkFlowManagementRights MilestoneWorkFlowManagement { get => GetEntity<MilestoneWorkFlowManagementRights>(); set => SetEntity(value); }

        /// <summary>
        /// LoanRights Other
        /// </summary>
        [AllowNull]
        public LoanOtherRights Other { get => GetEntity<LoanOtherRights>(); set => SetEntity(value); }

        /// <summary>
        /// LoanRights OtherChangeRESPATILAFormVersion
        /// </summary>
        [JsonProperty("other_ChangeRESPA-TILAFormVersion")]
        public bool? OtherChangeRESPATILAFormVersion { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanRights OtherChangeURLAFormVersion
        /// </summary>
        [JsonProperty("other_ChangeURLAFormVersion")]
        public bool? OtherChangeURLAFormVersion { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LoanRights OtherDisplayMilestoneListChangeScreen
        /// </summary>
        [JsonProperty("other_DisplayMilestoneListChangeScreen")]
        [AllowNull]
        public OtherDisplayMilestoneListChangeScreenRights OtherDisplayMilestoneListChangeScreen { get => GetEntity<OtherDisplayMilestoneListChangeScreenRights>(); set => SetEntity(value); }

        /// <summary>
        /// LoanRights Print
        /// </summary>
        public PrintRights Print { get => GetEntity<PrintRights>(); set => SetEntity(value); }
    }
}