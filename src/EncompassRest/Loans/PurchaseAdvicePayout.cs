#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseAdvicePayout : ExtensibleObject
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<decimal?> _diffAmount;
        public decimal? DiffAmount { get => _diffAmount; set => _diffAmount = value; }
        private DirtyValue<decimal?> _expectedAmount;
        public decimal? ExpectedAmount { get => _expectedAmount; set => _expectedAmount = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amount.Dirty
                    || _description.Dirty
                    || _diffAmount.Dirty
                    || _expectedAmount.Dirty
                    || _id.Dirty;
            }
            set
            {
                _amount.Dirty = value;
                _description.Dirty = value;
                _diffAmount.Dirty = value;
                _expectedAmount.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}