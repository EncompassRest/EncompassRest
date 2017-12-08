using EncompassRest.Utilities;

namespace EncompassRest.Users
{
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
}