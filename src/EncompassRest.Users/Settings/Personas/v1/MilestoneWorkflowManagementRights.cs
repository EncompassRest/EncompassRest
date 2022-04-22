using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// MilestoneWorkflowManagementRights
    /// </summary>
    public sealed class MilestoneWorkflowManagementRights : DirtyExtensibleObject
    {
        /// <summary>
        /// MilestoneWorkflowManagementRights AcceptFiles
        /// </summary>
        [AllowNull]
        public IList<EntityReference> AcceptFiles { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights ReturnFiles
        /// </summary>
        [AllowNull]
        public IList<EntityReference> ReturnFiles { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights ChangeExpectedDate
        /// </summary>
        [AllowNull]
        public IList<EntityReference> ChangeExpectedDate { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights FinishMilestones
        /// </summary>
        [AllowNull]
        public IList<EntityReference> FinishMilestones { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights AssignLoanTeamMembers
        /// </summary>
        [AllowNull]
        public IList<LoanTeamMemberRights> AssignLoanTeamMembers { get => GetList<LoanTeamMemberRights>(); set => SetList(value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights EditComments
        /// </summary>
        [AllowNull]
        public IList<EntityReference> EditComments { get => GetList<EntityReference>(); set => SetList(value); }
    }
}