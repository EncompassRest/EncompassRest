using EncompassRest.Utilities;

namespace EncompassRest.Services
{
    public abstract class ServiceOptions
    {
        public string RequestType { get; }

        internal ServiceOptions(string requestType)
        {
            Preconditions.NotNullOrEmpty(requestType, nameof(requestType));

            RequestType = requestType;
        }
    }
}