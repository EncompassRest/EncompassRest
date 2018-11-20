namespace EncompassRest.Services
{
    /// <summary>
    /// ServiceTransactionIdentity
    /// </summary>
    public sealed class ServiceTransactionIdentity : ExtensibleObject
    {
        /// <summary>
        /// ServiceTransactionIdentity ClientId
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// ServiceTransactionIdentity UserId
        /// </summary>
        public string UserId { get; set; }
    }
}