namespace EncompassRest.Services.v1
{
    /// <summary>
    /// ServiceCredentials
    /// </summary>
    public class ServiceCredentials : ExtensibleObject
    {
        /// <summary>
        /// Username for the service provider account.
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Password for the service provider account.
        /// </summary>
        public string? Password { get; set; }
    }
}