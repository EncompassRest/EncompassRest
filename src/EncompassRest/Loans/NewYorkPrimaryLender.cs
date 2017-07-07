using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkPrimaryLender : IClean
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<int?> _newYorkPrimaryLenderIndex;
        public int? NewYorkPrimaryLenderIndex { get { return _newYorkPrimaryLenderIndex; } set { _newYorkPrimaryLenderIndex = value; } }
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
                    && _city.Clean
                    && _comments.Clean
                    && _id.Clean
                    && _name.Clean
                    && _newYorkPrimaryLenderIndex.Clean
                    && _postalCode.Clean
                    && _state.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var address = _address; address.Clean = value; _address = address;
                var city = _city; city.Clean = value; _city = city;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var id = _id; id.Clean = value; _id = id;
                var name = _name; name.Clean = value; _name = name;
                var newYorkPrimaryLenderIndex = _newYorkPrimaryLenderIndex; newYorkPrimaryLenderIndex.Clean = value; _newYorkPrimaryLenderIndex = newYorkPrimaryLenderIndex;
                var postalCode = _postalCode; postalCode.Clean = value; _postalCode = postalCode;
                var state = _state; state.Clean = value; _state = state;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public NewYorkPrimaryLender()
        {
            Clean = true;
        }
    }
}