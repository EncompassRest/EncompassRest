using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkPrimaryLender : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _address.Dirty
                    || _city.Dirty
                    || _comments.Dirty
                    || _id.Dirty
                    || _name.Dirty
                    || _newYorkPrimaryLenderIndex.Dirty
                    || _postalCode.Dirty
                    || _state.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _address.Dirty = value;
                _city.Dirty = value;
                _comments.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _newYorkPrimaryLenderIndex.Dirty = value;
                _postalCode.Dirty = value;
                _state.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}