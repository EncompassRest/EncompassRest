namespace EncompassRest.CustomDataObjects
{
    public sealed class CustomDataObject : ExtensibleObject
    {
        public string Name { get; set; }

        public byte[] DataObject { get; set; }
    }
}