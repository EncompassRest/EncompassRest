namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Groups Apis
    /// </summary>
    public interface IUserGroups : IUserApiObject
    {
    }

    internal sealed class UserGroups : UserApiObject, IUserGroups
    {
        internal UserGroups(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, null)
        {
        }
    }
}