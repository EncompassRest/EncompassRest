namespace EncompassRest.Contacts
{
    public sealed class ContactAddress : DirtyExtensibleObject
    {
        private DirtyValue<string> _street1;
        public string Street1 { get => _street1; set => SetField(ref _street1, value); }
        private DirtyValue<string> _street2;
        public string Street2 { get => _street2; set => SetField(ref _street2, value); }
        private DirtyValue<string> _city;
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<string> _state;
        public string State { get => _state; set => SetField(ref _state, value); }
        private DirtyValue<string> _zip;
        public string Zip { get => _zip; set => SetField(ref _zip, value); }
    }
}