#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class GfeFee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _amountDescription;
        public string AmountDescription { get => _amountDescription; set => _amountDescription = value; }
        private DirtyValue<decimal?> _brokerAmount;
        public decimal? BrokerAmount { get => _brokerAmount; set => _brokerAmount = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _gfeFeeIndex;
        public int? GfeFeeIndex { get => _gfeFeeIndex; set => _gfeFeeIndex = value; }
        private DirtyValue<StringEnumValue<GfeFeeType>> _gfeFeeType;
        public StringEnumValue<GfeFeeType> GfeFeeType { get => _gfeFeeType; set => _gfeFeeType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _otherAmount;
        public decimal? OtherAmount { get => _otherAmount; set => _otherAmount = value; }
        private DirtyValue<string> _rate;
        public string Rate { get => _rate; set => _rate = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amountDescription.Dirty
                    || _brokerAmount.Dirty
                    || _description.Dirty
                    || _gfeFeeIndex.Dirty
                    || _gfeFeeType.Dirty
                    || _id.Dirty
                    || _otherAmount.Dirty
                    || _rate.Dirty;
            }
            set
            {
                _amountDescription.Dirty = value;
                _brokerAmount.Dirty = value;
                _description.Dirty = value;
                _gfeFeeIndex.Dirty = value;
                _gfeFeeType.Dirty = value;
                _id.Dirty = value;
                _otherAmount.Dirty = value;
                _rate.Dirty = value;
            }
        }
    }
}