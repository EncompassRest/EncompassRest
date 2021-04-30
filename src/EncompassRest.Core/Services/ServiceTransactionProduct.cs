namespace EncompassRest.Services
{
    /// <summary>
    /// ServiceTransactionProduct
    /// </summary>
    public sealed class ServiceTransactionProduct : ExtensibleObject
    {
        /// <summary>
        /// The unique Ellie Mae identifier for the Partner service provider with whom the service request was placed. 
        /// </summary>
        public string? PartnerId { get; set; }

        /// <summary>
        /// The name of the product for which the service request was placed.
        /// </summary>
        public StringEnumValue<ServiceType> ProductName { get; set; }

        /// <summary>
        /// The Encompass application (SmartClient/LO Connect/NG) display name of the product for which the service request was placed
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// The service category of the product for which the service request was placed.
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// Reference metadata for the Encompass entity in whose context the service request was placed. This may be a reference to an individual borrower or a loan in its entirety.
        /// </summary>
        public EntityReference? EntityRef { get; set; }
    }
}