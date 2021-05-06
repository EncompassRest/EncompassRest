namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// User Rights Apis
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