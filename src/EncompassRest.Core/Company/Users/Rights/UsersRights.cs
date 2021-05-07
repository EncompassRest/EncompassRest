namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// User Rights Apis exposed as extension methods from the EncompassRest.Users package
    /// within the EncompassRest.Company.Users.Rights.v1 namespace.
    /// </summary>
    public interface IUsersRights : IUserApiObject
    {
    }

    internal sealed class UsersRights : UserApiObject, IUsersRights
    {
        internal UsersRights(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, null)
        {
        }
    }
}