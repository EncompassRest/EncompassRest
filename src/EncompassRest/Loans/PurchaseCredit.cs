using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class PurchaseCredit : ExtensibleObject
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<PurchaseCreditType>> _purchaseCreditType;
        public StringEnumValue<PurchaseCreditType> PurchaseCreditType { get => _purchaseCreditType; set => _purchaseCreditType = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amount.Dirty
                    || _id.Dirty
                    || _purchaseCreditType.Dirty;
            }
            set
            {
                _amount.Dirty = value;
                _id.Dirty = value;
                _purchaseCreditType.Dirty = value;
            }
        }
    }
}