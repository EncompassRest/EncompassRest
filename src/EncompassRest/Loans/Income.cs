#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Income : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<bool?> _currentIndicator;
        public bool? CurrentIndicator { get => _currentIndicator; set => _currentIndicator = value; }
        private DirtyValue<StringEnumValue<Description>> _description;
        public StringEnumValue<Description> Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _incomeType;
        public string IncomeType { get => _incomeType; set => _incomeType = value; }
        private DirtyValue<int?> _otherIncomeIndex;
        public int? OtherIncomeIndex { get => _otherIncomeIndex; set => _otherIncomeIndex = value; }
        private DirtyValue<string> _owner;
        public string Owner { get => _owner; set => _owner = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amount.Dirty
                    || _currentIndicator.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _incomeType.Dirty
                    || _otherIncomeIndex.Dirty
                    || _owner.Dirty;
            }
            set
            {
                _amount.Dirty = value;
                _currentIndicator.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _incomeType.Dirty = value;
                _otherIncomeIndex.Dirty = value;
                _owner.Dirty = value;
            }
        }
    }
}