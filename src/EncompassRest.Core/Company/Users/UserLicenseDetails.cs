namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Licenses Apis
    /// </summary>
    public interface IUserLicenseDetails : IUserApiObject
    {
    }

    internal sealed class UserLicenseDetails : UserApiObject, IUserLicenseDetails
    {
        internal UserLicenseDetails(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, null)
        {
        }
    }
}