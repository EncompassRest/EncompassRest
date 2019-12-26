using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// MilestoneWorkFlowManagementRights
    /// </summary>
    public sealed class MilestoneWorkFlowManagementRights : DirtyExtensibleObject
    {
        private DirtyDictionary<string, bool>? _acceptFiles;
        private AssignLoanTeamMembersRights? _assignLoanTeamMembers;
        private DirtyDictionary<string, bool>? _changeExpectedDate;
        private DirtyDictionary<string, bool>? _editMilestoneComments;
        private DirtyDictionary<string, bool>? _finishMilestones;
        private DirtyDictionary<string, bool>? _returnFiles;

        /// <summary>
        /// MilestoneWorkFlowManagementRights AcceptFiles
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> AcceptFiles { get => GetField(ref _acceptFiles); set => SetField(ref _acceptFiles, value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights AssignLoanTeamMembers
        /// </summary>
        [AllowNull]
        public AssignLoanTeamMembersRights AssignLoanTeamMembers { get => GetField(ref _assignLoanTeamMembers); set => SetField(ref _assignLoanTeamMembers, value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights ChangeExpectedDate
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> ChangeExpectedDate { get => GetField(ref _changeExpectedDate); set => SetField(ref _changeExpectedDate, value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights EditMilestoneComments
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> EditMilestoneComments { get => GetField(ref _editMilestoneComments); set => SetField(ref _editMilestoneComments, value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights FinishMilestones
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> FinishMilestones { get => GetField(ref _finishMilestones); set => SetField(ref _finishMilestones, value); }

        /// <summary>
        /// MilestoneWorkFlowManagementRights ReturnFiles
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> ReturnFiles { get => GetField(ref _returnFiles); set => SetField(ref _returnFiles, value); }
    }
}