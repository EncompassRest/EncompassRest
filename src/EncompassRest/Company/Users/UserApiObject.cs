using EncompassRest.Utilities;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// Base class for User Apis
    /// </summary>
    public abstract class UserApiObject : ApiObject
    {
        /// <summary>
        /// User's Id
        /// </summary>
        public string UserId { get; }

        internal UserApiObject(EncompassRestClient client, string userId, string baseApiPath)
            : base(client, $"encompass/v1/company/users/{userId}{baseApiPath?.PrecedeWith("/")}")
        {
            UserId = userId;
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{UserId}{resourceId?.PrecedeWith("/")}");
    }
}