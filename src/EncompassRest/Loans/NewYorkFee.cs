using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkFee : IDirty
    {
        private DirtyValue<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private DirtyValue<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private DirtyValue<string> _feeType;
        public string FeeType { get { return _feeType; } set { _feeType = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private DirtyValue<int?> _newYorkFeeIndex;
        public int? NewYorkFeeIndex { get { return _newYorkFeeIndex; } set { _newYorkFeeIndex = value; } }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private DirtyValue<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _address.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}