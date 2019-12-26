using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// MilestoneWorkflowManagementRights
    /// </summary>
    public sealed class MilestoneWorkflowManagementRights : DirtyExtensibleObject
    {
        private DirtyList<EntityReference>? _acceptFiles;
        private DirtyList<EntityReference>? _returnFiles;
        private DirtyList<EntityReference>? _changeExpectedDate;
        private DirtyList<EntityReference>? _finishMilestones;
        private DirtyList<LoanTeamMemberRights>? _assignLoanTeamMembers;
        private DirtyList<EntityReference>? _editComments;

        /// <summary>
        /// MilestoneWorkflowManagementRights AcceptFiles
        /// </summary>
        [AllowNull]
        public IList<EntityReference> AcceptFiles { get => GetField(ref _acceptFiles); set => SetField(ref _acceptFiles, value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights ReturnFiles
        /// </summary>
        [AllowNull]
        public IList<EntityReference> ReturnFiles { get => GetField(ref _returnFiles); set => SetField(ref _returnFiles, value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights ChangeExpectedDate
        /// </summary>
        [AllowNull]
        public IList<EntityReference> ChangeExpectedDate { get => GetField(ref _changeExpectedDate); set => SetField(ref _changeExpectedDate, value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights FinishMilestones
        /// </summary>
        [AllowNull]
        public IList<EntityReference> FinishMilestones { get => GetField(ref _finishMilestones); set => SetField(ref _finishMilestones, value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights AssignLoanTeamMembers
        /// </summary>
        [AllowNull]
        public IList<LoanTeamMemberRights> AssignLoanTeamMembers { get => GetField(ref _assignLoanTeamMembers); set => SetField(ref _assignLoanTeamMembers, value); }

        /// <summary>
        /// MilestoneWorkflowManagementRights EditComments
        /// </summary>
        [AllowNull]
        public IList<EntityReference> EditComments { get => GetField(ref _editComments); set => SetField(ref _editComments, value); }
    }
}