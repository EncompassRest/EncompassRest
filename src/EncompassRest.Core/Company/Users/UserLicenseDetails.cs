namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Licenses Apis exposed as extension methods from the EncompassRest.Users package
    /// within the EncompassRest.Company.Users.v1 namespace.
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