using EncompassRest.Utilities;

namespace EncompassRest.Services.v1
{
    /// <summary>
    /// ServiceOptions
    /// </summary>
    public abstract class ServiceOptions : ExtensibleObject
    {
        /// <summary>
        /// Indicates the request type being submitted.
        /// </summary>
        public string RequestType { get; }

        internal ServiceOptions(string requestType)
        {
            Preconditions.NotNullOrEmpty(requestType, nameof(requestType));

            RequestType = requestType;
        }
    }
}