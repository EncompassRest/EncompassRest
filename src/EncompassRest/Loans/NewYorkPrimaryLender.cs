using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkPrimaryLender
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !_address.Clean;
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !_city.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !_name.Clean;
        private Value<int?> _newYorkPrimaryLenderIndex;
        public int? NewYorkPrimaryLenderIndex { get { return _newYorkPrimaryLenderIndex; } set { _newYorkPrimaryLenderIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewYorkPrimaryLenderIndex() => !_newYorkPrimaryLenderIndex.Clean;
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !_postalCode.Clean;
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !_state.Clean;
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
                var v0 = _address; v0.Clean = value; _address = v0;
                var v1 = _city; v1.Clean = value; _city = v1;
                var v2 = _comments; v2.Clean = value; _comments = v2;
                var v3 = _id; v3.Clean = value; _id = v3;
                var v4 = _name; v4.Clean = value; _name = v4;
                var v5 = _newYorkPrimaryLenderIndex; v5.Clean = value; _newYorkPrimaryLenderIndex = v5;
                var v6 = _postalCode; v6.Clean = value; _postalCode = v6;
                var v7 = _state; v7.Clean = value; _state = v7;
                _settingClean = 0;
            }
        }
    }
}