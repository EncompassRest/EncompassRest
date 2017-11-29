using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class PrepaymentPenalty : ExtensibleObject
    {
        private DirtyValue<StringEnumValue<FullPrepaymentPenaltyOptionType>> _fullPrepaymentPenaltyOptionType;
        public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => _fullPrepaymentPenaltyOptionType; set => _fullPrepaymentPenaltyOptionType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        public decimal? PrepaymentPenaltyPercent { get => _prepaymentPenaltyPercent; set => _prepaymentPenaltyPercent = value; }
        private DirtyValue<int?> _termMonthsCount;
        public int? TermMonthsCount { get => _termMonthsCount; set => _termMonthsCount = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _fullPrepaymentPenaltyOptionType.Dirty
                    || _id.Dirty
                    || _prepaymentPenaltyPercent.Dirty
                    || _termMonthsCount.Dirty;
            }
            set
            {
                _fullPrepaymentPenaltyOptionType.Dirty = value;
                _id.Dirty = value;
                _prepaymentPenaltyPercent.Dirty = value;
                _termMonthsCount.Dirty = value;
            }
        }
    }
}