namespace EncompassRest.Services
{
    public sealed class ServiceTransactionIdentity : ExtensibleObject
    {
        public string ClientId { get; set; }

        public string UserId { get; set; }
    }
}