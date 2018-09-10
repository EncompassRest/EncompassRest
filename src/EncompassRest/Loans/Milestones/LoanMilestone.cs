using System;

namespace EncompassRest.Loans.Milestones
{
    [Entity(PropertiesToAlwaysSerialize = nameof(StartDate))]
    public sealed class LoanMilestone : DirtyExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<DateTime?> _startDate;
        public DateTime? StartDate { get => _startDate; set => SetField(ref _startDate, value); }
        private LoanAssociate _loanAssociate;
        public LoanAssociate LoanAssociate { get => GetField(ref _loanAssociate); set => SetField(ref _loanAssociate, value); }
        private DirtyValue<int?> _expectedDays;
        public int? ExpectedDays { get => _expectedDays; set => SetField(ref _expectedDays, value); }
        private DirtyValue<bool?> _doneIndicator;
        public bool? DoneIndicator { get => _doneIndicator; set => SetField(ref _doneIndicator, value); }
        private DirtyValue<int?> _actualDays;
        public int? ActualDays { get => _actualDays; set => SetField(ref _actualDays, value); }
        private DirtyValue<bool?> _reviewedIndicator;
        public bool? ReviewedIndicator { get => _reviewedIndicator; set => SetField(ref _reviewedIndicator, value); }
        private DirtyValue<bool?> _roleRequired;
        public bool? RoleRequired { get => _roleRequired; set => SetField(ref _roleRequired, value); }
        private DirtyValue<string> _milestoneName;
        public string MilestoneName { get => _milestoneName; set => SetField(ref _milestoneName, value); }
        private DirtyValue<string> _milestoneIdString;
        public string MilestoneIdString { get => _milestoneIdString; set => SetField(ref _milestoneIdString, value); }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
    }
}
