using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UserOtherRights
    /// </summary>
    public sealed class LoanOtherRights : DirtyExtensibleObject
    {
        /// <summary>
        /// UserOtherRights ApplyLoanTemplates
        /// </summary>
        public bool? ApplyLoanTemplates { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserOtherRights ApplyMilestoneTemplate
        /// </summary>
        public bool? ApplyMilestoneTemplate { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserOtherRights DeleteBorrowers
        /// </summary>
        [JsonProperty("delete Borrowers")]
        public bool? DeleteBorrowers { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserOtherRights ManageBorrowers
        /// </summary>
        [AllowNull]
        public ManageBorrowersRights ManageBorrowers { get => GetEntity<ManageBorrowersRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserOtherRights ManageMilestoneDatesMode
        /// </summary>
        public bool? ManageMilestoneDatesMode { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserOtherRights ManageMilestoneTemplatesMode
        /// </summary>
        public bool? ManageMilestoneTemplatesMode { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UserOtherRights ManageServiceProvidersList
        /// </summary>
        [AllowNull]
        public ManageServiceProvidersListRights ManageServiceProvidersList { get => GetEntity<ManageServiceProvidersListRights>(); set => SetEntity(value); }

        /// <summary>
        /// UserOtherRights ManuallyBlockMultiUserEditing
        /// </summary>
        [JsonProperty("manuallyBlockMulti-UserEditing")]
        public bool? ManuallyBlockMultiUserEditing { get => GetValue<bool?>(); set => SetValue(value); }
    }
}