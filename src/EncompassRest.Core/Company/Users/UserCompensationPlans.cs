namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Compensation Apis
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