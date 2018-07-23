using System;

namespace EncompassRest.Loans.Milestones
{
    [Entity(PropertiesToAlwaysSerialize = nameof(StartDate))]
    public sealed class LoanMilestone : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _startDate;
        public DateTime? StartDate { get => _startDate; set => _startDate = value; }
        private LoanAssociate _loanAssociate;
        public LoanAssociate LoanAssociate { get => _loanAssociate ?? (_loanAssociate = new LoanAssociate()); set => _loanAssociate = value; }
        private DirtyValue<int?> _expectedDays;
        public int? ExpectedDays { get => _expectedDays; set => _expectedDays = value; }
        private DirtyValue<bool?> _doneIndicator;
        public bool? DoneIndicator { get => _doneIndicator; set => _doneIndicator = value; }
        private DirtyValue<int?> _actualDays;
        public int? ActualDays { get => _actualDays; set => _actualDays = value; }
        private DirtyValue<bool?> _reviewedIndicator;
        public bool? ReviewedIndicator { get => _reviewedIndicator; set => _reviewedIndicator = value; }
        private DirtyValue<bool?> _roleRequired;
        public bool? RoleRequired { get => _roleRequired; set => _roleRequired = value; }
        private DirtyValue<string> _milestoneName;
        public string MilestoneName { get => _milestoneName; set => _milestoneName = value; }
        private DirtyValue<string> _milestoneIdString;
        public string MilestoneIdString { get => _milestoneIdString; set => _milestoneIdString = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
                    || _startDate.Dirty
                    || _loanAssociate?.Dirty == true
                    || _expectedDays.Dirty
                    || _doneIndicator.Dirty
                    || _actualDays.Dirty
                    || _reviewedIndicator.Dirty
                    || _roleRequired.Dirty
                    || _milestoneName.Dirty
                    || _milestoneIdString.Dirty
                    || _comments.Dirty;
            }
            set
            {
                _id.Dirty = value;
                _startDate.Dirty = value;
                if (_loanAssociate != null) _loanAssociate.Dirty = value;
                _expectedDays.Dirty = value;
                _doneIndicator.Dirty = value;
                _actualDays.Dirty = value;
                _reviewedIndicator.Dirty = value;
                _roleRequired.Dirty = value;
                _milestoneName.Dirty = value;
                _milestoneIdString.Dirty = value;
                _comments.Dirty = value;
            }
        }
    }
}
