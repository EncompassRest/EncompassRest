namespace EncompassRest.Services
{
    public sealed class ServiceTransactionProduct : ExtensibleObject
    {
        public string PartnerId { get; set; }

        public StringEnumValue<ServiceType> ProductName { get; set; }

        public string DisplayName { get; set; }

        public string Category { get; set; }

        public EntityReference EntityRef { get; set; }
    }
}