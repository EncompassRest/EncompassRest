using EncompassApi.Utilities;

namespace EncompassApi.Company.Users
{
    /// <summary>
    /// Base interface for User Apis
    /// </summary>
    public interface IUserApiObject : IApiObject
    {
        /// <summary>
        /// User's Id
        /// </summary>
        string UserId { get; }
    }

    /// <summary>
    /// Base class for User Apis
    /// </summary>
    public abstract class UserApiObject : ApiObject, IUserApiObject
    {
        /// <inheritdoc/>
        public string UserId { get; }

        internal UserApiObject(IEncompassApiClient client, string userId, string? baseApiPath)
            : base(client, $"encompass/v1/company/users/{userId}{baseApiPath?.PrecedeWith("/")}")
        {
            UserId = userId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{UserId}{resourceId?.PrecedeWith("/")}");
    }
}