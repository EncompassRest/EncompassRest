using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// UserOtherRights
    /// </summary>
    public sealed class LoanOtherRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _applyLoanTemplates;
        private DirtyValue<bool?>? _applyMilestoneTemplate;
        private DirtyValue<bool?>? _deleteBorrowers;
        private ManageBorrowersRights? _manageBorrowers;
        private DirtyValue<bool?>? _manageMilestoneDatesMode;
        private DirtyValue<bool?>? _manageMilestoneTemplatesMode;
        private ManageServiceProvidersListRights? _manageServiceProvidersList;
        private DirtyValue<bool?>? _manuallyBlockMultiUserEditing;

        /// <summary>
        /// UserOtherRights ApplyLoanTemplates
        /// </summary>
        public bool? ApplyLoanTemplates { get => _applyLoanTemplates; set => SetField(ref _applyLoanTemplates, value); }

        /// <summary>
        /// UserOtherRights ApplyMilestoneTemplate
        /// </summary>
        public bool? ApplyMilestoneTemplate { get => _applyMilestoneTemplate; set => SetField(ref _applyMilestoneTemplate, value); }

        /// <summary>
        /// UserOtherRights DeleteBorrowers
        /// </summary>
        [JsonProperty("delete Borrowers")]
        public bool? DeleteBorrowers { get => _deleteBorrowers; set => SetField(ref _deleteBorrowers, value); }

        /// <summary>
        /// UserOtherRights ManageBorrowers
        /// </summary>
        [AllowNull]
        public ManageBorrowersRights ManageBorrowers { get => GetField(ref _manageBorrowers); set => SetField(ref _manageBorrowers, value); }

        /// <summary>
        /// UserOtherRights ManageMilestoneDatesMode
        /// </summary>
        public bool? ManageMilestoneDatesMode { get => _manageMilestoneDatesMode; set => SetField(ref _manageMilestoneDatesMode, value); }

        /// <summary>
        /// UserOtherRights ManageMilestoneTemplatesMode
        /// </summary>
        public bool? ManageMilestoneTemplatesMode { get => _manageMilestoneTemplatesMode; set => SetField(ref _manageMilestoneTemplatesMode, value); }

        /// <summary>
        /// UserOtherRights ManageServiceProvidersList
        /// </summary>
        [AllowNull]
        public ManageServiceProvidersListRights ManageServiceProvidersList { get => GetField(ref _manageServiceProvidersList); set => SetField(ref _manageServiceProvidersList, value); }

        /// <summary>
        /// UserOtherRights ManuallyBlockMultiUserEditing
        /// </summary>
        [JsonProperty("manuallyBlockMulti-UserEditing")]
        public bool? ManuallyBlockMultiUserEditing { get => _manuallyBlockMultiUserEditing; set => SetField(ref _manuallyBlockMultiUserEditing, value); }
    }
}