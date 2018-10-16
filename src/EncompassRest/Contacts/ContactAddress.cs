namespace EncompassRest.Contacts
{
    public sealed class ContactAddress : DirtyExtensibleObject
    {
        private DirtyValue<string> _street1;
        private DirtyValue<string> _street2;
        private DirtyValue<string> _city;
        private DirtyValue<string> _state;
        private DirtyValue<string> _zip;

        public string Street1 { get => _street1; set => SetField(ref _street1, value); }

        public string Street2 { get => _street2; set => SetField(ref _street2, value); }

        public string City { get => _city; set => SetField(ref _city, value); }

        public string State { get => _state; set => SetField(ref _state, value); }

        public string Zip { get => _zip; set => SetField(ref _zip, value); }
    }
}