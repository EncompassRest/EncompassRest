using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MilestoneWorkFlowManagementRights
    /// </summary>
    public sealed class MilestoneWorkFlowManagementRights : DirtyExtensibleObject
    {
        /// <summary>
        /// MilestoneWorkFlowManagementRights AcceptFiles
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> AcceptFiles { get => GetDictionary<string, bool>(); set => SetDictionary(value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights AssignLoanTeamMembers
        /// </summary>
        [AllowNull]
        public AssignLoanTeamMembersRights AssignLoanTeamMembers { get => GetEntity<AssignLoanTeamMembersRights>(); set => SetEntity(value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights ChangeExpectedDate
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> ChangeExpectedDate { get => GetDictionary<string, bool>(); set => SetDictionary(value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights EditMilestoneComments
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> EditMilestoneComments { get => GetDictionary<string, bool>(); set => SetDictionary(value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights FinishMilestones
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> FinishMilestones { get => GetDictionary<string, bool>(); set => SetDictionary(value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights ReturnFiles
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> ReturnFiles { get => GetDictionary<string, bool>(); set => SetDictionary(value); }
    }
}