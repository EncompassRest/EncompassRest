using System;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.v1;

namespace EncompassRest.Loans.Milestones.v1
{
    /// <summary>
    /// LoanMilestone
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(StartDate))]
    public sealed class LoanMilestone : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Unique identifier of the milestone.
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The start date of the milestone.
        /// </summary>
        public DateTime? StartDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// Object containing loan associate details.
        /// </summary>
        [AllowNull]
        public LoanAssociate LoanAssociate { get => GetEntity<LoanAssociate>(); set => SetEntity(value); }

        /// <summary>
        /// The expected number of days to finish the milestone.
        /// </summary>
        public int? ExpectedDays { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the milestone has been completed.
        /// </summary>
        public bool? DoneIndicator { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates the number of days to complete the milestone.
        /// </summary>
        public int? ActualDays { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether all activities or documents related to the milestone have been reviewed.
        /// </summary>
        public bool? ReviewedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Specifies whether assigning a loan team member to this milestone is required.
        /// </summary>
        public bool? RoleRequired { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Name of the milestone set by the Encompass administrator.
        /// </summary>
        public string? MilestoneName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// LoanMilestone MilestoneIdString
        /// </summary>
        public string? MilestoneIdString { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// LoanMilestone Comments
        /// </summary>
        public string? Comments { get => GetValue<string?>(); set => SetValue(value); }
    }
}