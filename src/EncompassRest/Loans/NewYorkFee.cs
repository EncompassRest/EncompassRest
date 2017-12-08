#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkFee : ExtensibleObject
    {
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get => _date; set => _date = value; }
        private DirtyValue<string> _feeType;
        public string FeeType { get => _feeType; set => _feeType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<int?> _newYorkFeeIndex;
        public int? NewYorkFeeIndex { get => _newYorkFeeIndex; set => _newYorkFeeIndex = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _address.Dirty
                    || _amount.Dirty
                    || _city.Dirty
                    || _comments.Dirty
                    || _date.Dirty
                    || _feeType.Dirty
                    || _id.Dirty
                    || _name.Dirty
                    || _newYorkFeeIndex.Dirty
                    || _postalCode.Dirty
                    || _state.Dirty;
            }
            set
            {
                _address.Dirty = value;
                _amount.Dirty = value;
                _city.Dirty = value;
                _comments.Dirty = value;
                _date.Dirty = value;
                _feeType.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _newYorkFeeIndex.Dirty = value;
                _postalCode.Dirty = value;
                _state.Dirty = value;
            }
        }
    }
}