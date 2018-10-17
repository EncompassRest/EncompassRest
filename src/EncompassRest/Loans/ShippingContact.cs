using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ShippingContact
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(ShippingContactType))]
    public sealed partial class ShippingContact : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        private DirtyValue<string> _address2;
        private DirtyValue<string> _city;
        private DirtyValue<string> _contactName;
        private DirtyValue<string> _email;
        private DirtyValue<string> _fax;
        private DirtyValue<string> _id;
        private DirtyValue<string> _name;
        private DirtyValue<string> _phone;
        private DirtyValue<string> _postalCode;
        private DirtyValue<StringEnumValue<ShippingContactType>> _shippingContactType;
        private DirtyValue<StringEnumValue<State>> _state;

        /// <summary>
        /// ShippingContact Address
        /// </summary>
        public string Address { get => _address; set => SetField(ref _address, value); }

        /// <summary>
        /// ShippingContact Address2
        /// </summary>
        public string Address2 { get => _address2; set => SetField(ref _address2, value); }

        /// <summary>
        /// ShippingContact City
        /// </summary>
        public string City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// ShippingContact ContactName
        /// </summary>
        public string ContactName { get => _contactName; set => SetField(ref _contactName, value); }

        /// <summary>
        /// ShippingContact Email
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// ShippingContact Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// ShippingContact Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// ShippingContact Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// ShippingContact Phone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// ShippingContact PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// ShippingContact ShippingContactType
        /// </summary>
        public StringEnumValue<ShippingContactType> ShippingContactType { get => _shippingContactType; set => SetField(ref _shippingContactType, value); }

        /// <summary>
        /// ShippingContact State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
    }
}