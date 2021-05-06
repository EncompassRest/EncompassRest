namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Groups Apis exposed as extension methods from the EncompassRest.Users.v1 package
    /// within the EncompassRest.Company.Users.v1 namespace.
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