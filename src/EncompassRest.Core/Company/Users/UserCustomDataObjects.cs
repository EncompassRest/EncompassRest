namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Custom Data Objects Apis
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