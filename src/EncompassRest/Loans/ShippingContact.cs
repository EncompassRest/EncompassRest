using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ShippingContact : IClean
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _address.Clean
                    && _address2.Clean
                    && _city.Clean
                    && _contactName.Clean
                    && _email.Clean
                    && _fax.Clean
                    && _id.Clean
                    && _name.Clean
                    && _phone.Clean
                    && _postalCode.Clean
                    && _shippingContactType.Clean
                    && _state.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _address; v0.Clean = value; _address = v0;
                var v1 = _address2; v1.Clean = value; _address2 = v1;
                var v2 = _city; v2.Clean = value; _city = v2;
                var v3 = _contactName; v3.Clean = value; _contactName = v3;
                var v4 = _email; v4.Clean = value; _email = v4;
                var v5 = _fax; v5.Clean = value; _fax = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _name; v7.Clean = value; _name = v7;
                var v8 = _phone; v8.Clean = value; _phone = v8;
                var v9 = _postalCode; v9.Clean = value; _postalCode = v9;
                var v10 = _shippingContactType; v10.Clean = value; _shippingContactType = v10;
                var v11 = _state; v11.Clean = value; _state = v11;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}