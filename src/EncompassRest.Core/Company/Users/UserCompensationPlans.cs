namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Compensation Apis exposed as extension methods from the EncompassRest.Users.v1 package
    /// within the EncompassRest.Company.Users.v1 namespace.
    /// </summary>
    public interface IUserCompensationPlans : IUserApiObject
    {
    }

    internal sealed class UserCompensationPlans : UserApiObject, IUserCompensationPlans
    {
        internal UserCompensationPlans(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, userApis, userId, null)
        {
        }
    }
}