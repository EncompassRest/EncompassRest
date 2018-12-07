namespace EncompassRest
{
    /// <summary>
    /// Address
    /// </summary>
    public sealed class Address : DirtyExtensibleObject
    {
        private DirtyValue<string> _city;
        private DirtyValue<StringEnumValue<State>> _state;
        private DirtyValue<string> _street1;
        private DirtyValue<string> _street2;
        private DirtyValue<string> _zip;

        /// <summary>
        /// The city in which the address is located.
        /// </summary>
        public string City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// The state in which the address is located.
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Line 1 of the address.
        /// </summary>
        public string Street1 { get => _street1; set => SetField(ref _street1, value); }

        /// <summary>
        /// Line 2 of the address.
        /// </summary>
        public string Street2 { get => _street2; set => SetField(ref _street2, value); }

        /// <summary>
        /// The address's ZIP code.
        /// </summary>
        public string Zip { get => _zip; set => SetField(ref _zip, value); }
    }
}