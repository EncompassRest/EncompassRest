using EncompassRest.Utilities;

namespace EncompassRest.Users
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class Users : ApiObject
    {
        internal Users(EncompassRestClient client)
            : base(client, "encompass/v1/users")
        {
        }

        public UserCustomDataObjects GetCustomDataObjects(string userId)
        {
            Preconditions.NotNullOrEmpty(userId, nameof(userId));

            return new UserCustomDataObjects(Client, userId);
        }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}