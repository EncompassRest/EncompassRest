namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Custom Data Objects Apis exposed as extension methods from the EncompassRest.Users package
    /// within the EncompassRest.Company.Users.v1 namespace.
    /// </summary>
    public interface IUserCustomDataObjects : IUserApiObject
    {
    }

    internal sealed class UserCustomDataObjects : UserApiObject, IUserCustomDataObjects
    {
        internal UserCustomDataObjects(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, null)
        {
        }
    }
}