using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ShippingContact : IDirty
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<string> _address2;
        public string Address2 { get { return _address2; } set { _address2 = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<string> _fax;
        public string Fax { get { return _fax; } set { _fax = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<string> _shippingContactType;
        public string ShippingContactType { get { return _shippingContactType; } set { _shippingContactType = value; } }
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
                    || _address2.Dirty
                    || _city.Dirty
                    || _contactName.Dirty
                    || _email.Dirty
                    || _fax.Dirty
                    || _id.Dirty
                    || _name.Dirty
                    || _phone.Dirty
                    || _postalCode.Dirty
                    || _shippingContactType.Dirty
                    || _state.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _address.Dirty = value;
                _address2.Dirty = value;
                _city.Dirty = value;
                _contactName.Dirty = value;
                _email.Dirty = value;
                _fax.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _phone.Dirty = value;
                _postalCode.Dirty = value;
                _shippingContactType.Dirty = value;
                _state.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}