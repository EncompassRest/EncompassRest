namespace EncompassRest.CustomDataObjects
{
    public sealed class CustomDataObject : ExtensibleObject, IIdentifiable
    {
        public string Name { get; set; }

        public byte[] DataObject { get; set; }

        [IdPropertyName(nameof(Name))]
        string IIdentifiable.Id { get => Name; set => Name = value; }
    }
}