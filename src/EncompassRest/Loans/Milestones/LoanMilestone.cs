using System;

namespace EncompassRest.Loans.Milestones
{
    [Entity(PropertiesToAlwaysSerialize = nameof(StartDate))]
    public sealed class LoanMilestone : DirtyExtensibleObject
    {
        private DirtyValue<string> _id;
        private DirtyValue<DateTime?> _startDate;
        private LoanAssociate _loanAssociate;
        private DirtyValue<int?> _expectedDays;
        private DirtyValue<bool?> _doneIndicator;
        private DirtyValue<int?> _actualDays;
        private DirtyValue<bool?> _reviewedIndicator;
        private DirtyValue<bool?> _roleRequired;
        private DirtyValue<string> _milestoneName;
        private DirtyValue<string> _milestoneIdString;
        private DirtyValue<string> _comments;

        public string Id { get => _id; set => SetField(ref _id, value); }

        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }

        public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }

        public int? ExpectedDays { get => _expectedDays; set => SetField(ref _expectedDays, value); }

        public bool? DoneIndicator { get => _doneIndicator; set => SetField(ref _doneIndicator, value); }

        public int? ActualDays { get => _actualDays; set => SetField(ref _actualDays, value); }

        public bool? ReviewedIndicator { get => _reviewedIndicator; set => SetField(ref _reviewedIndicator, value); }

        public bool? RoleRequired { get => _roleRequired; set => SetField(ref _roleRequired, value); }

        public string MilestoneName { get => _milestoneName; set => SetField(ref _milestoneName, value); }

        public string MilestoneIdString { get => _milestoneIdString; set => SetField(ref _milestoneIdString, value); }

        public string Comments { get => _comments; set => SetField(ref _comments, value); }
    }
}
