using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ShippingContact
    /// </summary>
    public sealed partial class ShippingContact : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// ShippingContact Address
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<string> _address2;
        /// <summary>
        /// ShippingContact Address2
        /// </summary>
        public string Address2 { get => _address2; set => _address2 = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// ShippingContact City
        /// </summary>
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _contactName;
        /// <summary>
        /// ShippingContact ContactName
        /// </summary>
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// ShippingContact Email
        /// </summary>
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _fax;
        /// <summary>
        /// ShippingContact Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ShippingContact Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// ShippingContact Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _phone;
        /// <summary>
        /// ShippingContact Phone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// ShippingContact PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<StringEnumValue<ShippingContactType>> _shippingContactType;
        /// <summary>
        /// ShippingContact ShippingContactType
        /// </summary>
        public StringEnumValue<ShippingContactType> ShippingContactType { get => _shippingContactType; set => _shippingContactType = value; }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// ShippingContact State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => _state = value; }
        internal override bool DirtyInternal
        {
            get => _address.Dirty
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