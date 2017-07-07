using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class MilestoneTaskContact : IClean
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<string> _contactId;
        public string ContactId { get { return _contactId; } set { _contactId = value; } }
        private Value<string> _email;
        public string Email { get { return _email; } set { _email = value; } }
        private Value<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _phone;
        public string Phone { get { return _phone; } set { _phone = value; } }
        private Value<string> _role;
        public string Role { get { return _role; } set { _role = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<string> _zip;
        public string Zip { get { return _zip; } set { _zip = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _address.Clean
                    && _city.Clean
                    && _contactId.Clean
                    && _email.Clean
                    && _guid.Clean
                    && _id.Clean
                    && _name.Clean
                    && _phone.Clean
                    && _role.Clean
                    && _state.Clean
                    && _zip.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var address = _address; address.Clean = value; _address = address;
                var city = _city; city.Clean = value; _city = city;
                var contactId = _contactId; contactId.Clean = value; _contactId = contactId;
                var email = _email; email.Clean = value; _email = email;
                var guid = _guid; guid.Clean = value; _guid = guid;
                var id = _id; id.Clean = value; _id = id;
                var name = _name; name.Clean = value; _name = name;
                var phone = _phone; phone.Clean = value; _phone = phone;
                var role = _role; role.Clean = value; _role = role;
                var state = _state; state.Clean = value; _state = state;
                var zip = _zip; zip.Clean = value; _zip = zip;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public MilestoneTaskContact()
        {
            Clean = true;
        }
    }
}