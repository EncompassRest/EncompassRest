using System.Runtime.Serialization;

namespace EncompassRest.Services.v1
{
    /// <summary>
    /// ServiceStatus
    /// </summary>
    public enum ServiceStatus
    {
        /// <summary>
        /// pending - The service request is currently being processed by the service provider.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending = 0,
        /// <summary>
        /// success - The service request was successfully fulfilled by the service provider.
        /// </summary>
        [EnumMember(Value = "success")]
        Success = 1,
        /// <summary>
        /// error - There has been an error while processing the service request. Error details are illustrated in the response body.
        /// </summary>
        [EnumMember(Value = "error")]
        Error = 2
    }
}