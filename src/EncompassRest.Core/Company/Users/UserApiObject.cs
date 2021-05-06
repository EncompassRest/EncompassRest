using System;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users
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
        /// <summary>
        /// Api's associated with the user.
        /// </summary>
        IUserApis UserApis { get; }
    }

    internal abstract class UserApiObject : ApiObject, IUserApiObject
    {
        public string UserId { get; }

        public IUserApis UserApis { get; }

        internal UserApiObject(EncompassRestClient client, IUserApis userApis, string userId, string? baseApiPath)
            : base(client, baseApiPath)
        {
            UserId = userId;
            UserApis = userApis ?? this as IUserApis ?? throw new ArgumentNullException(nameof(userApis));
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{UserId}{resourceId?.PrecedeWith("/")}");
    }
}