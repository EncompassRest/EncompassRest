namespace EncompassRest.Contacts
{
    public sealed class ContactAddress : ExtensibleObject
    {
        private DirtyValue<string> _street1;
        public string Street1 { get => _street1; set => _street1 = value; }
        private DirtyValue<string> _street2;
        public string Street2 { get => _street2; set => _street2 = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<string> _zip;
        public string Zip { get => _zip; set => _zip = value; }
    }
}