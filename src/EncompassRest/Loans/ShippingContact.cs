using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ShippingContact
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ShippingContactType))]
    public sealed partial class ShippingContact : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// ShippingContact Address
        /// </summary>
        public string Address { get => _address; set => SetField(ref _address, value); }
        private DirtyValue<string> _address2;
        /// <summary>
        /// ShippingContact Address2
        /// </summary>
        public string Address2 { get => _address2; set => SetField(ref _address2, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// ShippingContact City
        /// </summary>
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<string> _contactName;
        /// <summary>
        /// ShippingContact ContactName
        /// </summary>
        public string ContactName { get => _contactName; set => SetField(ref _contactName, value); }
        private DirtyValue<string> _email;
        /// <summary>
        /// ShippingContact Email
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }
        private DirtyValue<string> _fax;
        /// <summary>
        /// ShippingContact Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => SetField(ref _fax, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ShippingContact Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _name;
        /// <summary>
        /// ShippingContact Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
        private DirtyValue<string> _phone;
        /// <summary>
        /// ShippingContact Phone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Phone { get => _phone; set => SetField(ref _phone, value); }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// ShippingContact PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }
        private DirtyValue<StringEnumValue<ShippingContactType>> _shippingContactType;
        /// <summary>
        /// ShippingContact ShippingContactType
        /// </summary>
        public StringEnumValue<ShippingContactType> ShippingContactType { get => _shippingContactType; set => SetField(ref _shippingContactType, value); }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// ShippingContact State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
    }
}