using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkFee : IClean
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _date;
        public DateTime? Date { get { return _date; } set { _date = value; } }
        private Value<string> _feeType;
        public string FeeType { get { return _feeType; } set { _feeType = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<int?> _newYorkFeeIndex;
        public int? NewYorkFeeIndex { get { return _newYorkFeeIndex; } set { _newYorkFeeIndex = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _address.Clean
                    && _amount.Clean
                    && _city.Clean
                    && _comments.Clean
                    && _date.Clean
                    && _feeType.Clean
                    && _id.Clean
                    && _name.Clean
                    && _newYorkFeeIndex.Clean
                    && _postalCode.Clean
                    && _state.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _address; v0.Clean = value; _address = v0;
                var v1 = _amount; v1.Clean = value; _amount = v1;
                var v2 = _city; v2.Clean = value; _city = v2;
                var v3 = _comments; v3.Clean = value; _comments = v3;
                var v4 = _date; v4.Clean = value; _date = v4;
                var v5 = _feeType; v5.Clean = value; _feeType = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _name; v7.Clean = value; _name = v7;
                var v8 = _newYorkFeeIndex; v8.Clean = value; _newYorkFeeIndex = v8;
                var v9 = _postalCode; v9.Clean = value; _postalCode = v9;
                var v10 = _state; v10.Clean = value; _state = v10;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public NewYorkFee()
        {
            Clean = true;
        }
    }
}