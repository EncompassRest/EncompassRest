using System;
using System.Diagnostics.CodeAnalysis;

namespace EncompassApi.Loans.Milestones
{
    /// <summary>
    /// LoanMilestone
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(StartDate))]
    public sealed class LoanMilestone : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _id;
        private DirtyValue<DateTime?>? _startDate;
        private LoanAssociate? _loanAssociate;
        private DirtyValue<int?>? _expectedDays;
        private DirtyValue<bool?>? _doneIndicator;
        private DirtyValue<int?>? _actualDays;
        private DirtyValue<bool?>? _reviewedIndicator;
        private DirtyValue<bool?>? _roleRequired;
        private DirtyValue<string?>? _milestoneName;
        private DirtyValue<string?>? _milestoneIdString;
        private DirtyValue<string?>? _comments;

        /// <summary>
        /// Unique identifier of the milestone.
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// The start date of the milestone.
        /// </summary>
        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

        /// <summary>
        /// Object containing loan associate details.
        /// </summary>
        [AllowNull]
        public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }

        /// <summary>
        /// The expected number of days to finish the milestone.
        /// </summary>
        public int? ExpectedDays { get => _expectedDays; set => SetField(ref _expectedDays, value); }

        /// <summary>
        /// Indicates whether the milestone has been completed.
        /// </summary>
        public bool? DoneIndicator { get => _doneIndicator; set => SetField(ref _doneIndicator, value); }

        /// <summary>
        /// Indicates the number of days to complete the milestone.
        /// </summary>
        public int? ActualDays { get => _actualDays; set => SetField(ref _actualDays, value); }

        /// <summary>
        /// Indicates whether all activities or documents related to the milestone have been reviewed.
        /// </summary>
        public bool? ReviewedIndicator { get => _reviewedIndicator; set => SetField(ref _reviewedIndicator, value); }

        /// <summary>
        /// Specifies whether assigning a loan team member to this milestone is required.
        /// </summary>
        public bool? RoleRequired { get => _roleRequired; set => SetField(ref _roleRequired, value); }

        /// <summary>
        /// Name of the milestone set by the Encompass administrator.
        /// </summary>
        public string? MilestoneName { get => _milestoneName; set => SetField(ref _milestoneName, value); }

        /// <summary>
        /// LoanMilestone MilestoneIdString
        /// </summary>
        public string? MilestoneIdString { get => _milestoneIdString; set => SetField(ref _milestoneIdString, value); }

        /// <summary>
        /// LoanMilestone Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }
    }
}