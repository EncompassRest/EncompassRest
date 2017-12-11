#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ShippingContact : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _address2;
        public string Address2 { get => _address2; set => _address2 = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _contactName;
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<string> _email;
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _fax;
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _phone;
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _shippingContactType;
        public string ShippingContactType { get => _shippingContactType; set => _shippingContactType = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _address.Dirty
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
            }
            set
            {
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
            }
        }
    }
}