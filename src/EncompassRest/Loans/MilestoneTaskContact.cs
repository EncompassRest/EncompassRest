using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _address; v0.Clean = value; _address = v0;
                var v1 = _city; v1.Clean = value; _city = v1;
                var v2 = _contactId; v2.Clean = value; _contactId = v2;
                var v3 = _email; v3.Clean = value; _email = v3;
                var v4 = _guid; v4.Clean = value; _guid = v4;
                var v5 = _id; v5.Clean = value; _id = v5;
                var v6 = _name; v6.Clean = value; _name = v6;
                var v7 = _phone; v7.Clean = value; _phone = v7;
                var v8 = _role; v8.Clean = value; _role = v8;
                var v9 = _state; v9.Clean = value; _state = v9;
                var v10 = _zip; v10.Clean = value; _zip = v10;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}