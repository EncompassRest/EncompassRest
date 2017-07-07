using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var address = _address; address.Clean = value; _address = address;
                var address2 = _address2; address2.Clean = value; _address2 = address2;
                var city = _city; city.Clean = value; _city = city;
                var contactName = _contactName; contactName.Clean = value; _contactName = contactName;
                var email = _email; email.Clean = value; _email = email;
                var fax = _fax; fax.Clean = value; _fax = fax;
                var id = _id; id.Clean = value; _id = id;
                var name = _name; name.Clean = value; _name = name;
                var phone = _phone; phone.Clean = value; _phone = phone;
                var postalCode = _postalCode; postalCode.Clean = value; _postalCode = postalCode;
                var shippingContactType = _shippingContactType; shippingContactType.Clean = value; _shippingContactType = shippingContactType;
                var state = _state; state.Clean = value; _state = state;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ShippingContact()
        {
            Clean = true;
        }
    }
}