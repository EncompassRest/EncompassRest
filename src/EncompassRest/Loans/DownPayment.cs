using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DownPayment : ExtensibleObject
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<StringEnumValue<DownPaymentType>> _downPaymentType;
        public StringEnumValue<DownPaymentType> DownPaymentType { get => _downPaymentType; set => _downPaymentType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _sourceDescription;
        public string SourceDescription { get => _sourceDescription; set => _sourceDescription = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amount.Dirty
                    || _downPaymentType.Dirty
                    || _id.Dirty
                    || _sourceDescription.Dirty;
            }
            set
            {
                _amount.Dirty = value;
                _downPaymentType.Dirty = value;
                _id.Dirty = value;
                _sourceDescription.Dirty = value;
            }
        }
    }
}