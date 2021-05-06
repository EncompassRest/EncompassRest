using System.Threading;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// The Users Apis exposed as extension methods from the EncompassRest.Users.v1 package
    /// within the EncompassRest.Company.Users.v1 namespace.
    /// </summary>
    public interface IUsers : IApiObject
    {
        /// <summary>
        /// Gets the Current User's Apis. Custom Data Objects are not currently supported through this property.
        /// </summary>
        IUserApis CurrentUserApis { get; }

        /// <summary>
        /// Gets the User Apis for the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The user's id.</param>
        /// <returns></returns>
        IUserApis GetUserApis(string userId);
    }

    internal sealed class Users : ApiObject, IUsers
    {
        private UserApis? _currentUserApis;

        public IUserApis CurrentUserApis
        {
            get
            {
                var currentUserApis = _currentUserApis;
                return currentUserApis ?? Interlocked.CompareExchange(ref _currentUserApis, (currentUserApis = new UserApis(Client, "me")), null) ?? currentUserApis;
            }
        }

        internal Users(EncompassRestClient client)
            : base(client, null)
        {
        }

        public IUserApis GetUserApis(string userId)
        {
            Preconditions.NotNullOrEmpty(userId, nameof(userId));

            return new UserApis(Client, userId);
        }
    }
}