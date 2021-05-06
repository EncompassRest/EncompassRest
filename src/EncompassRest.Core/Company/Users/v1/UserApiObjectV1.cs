using EncompassRest.Utilities;

namespace EncompassRest.Company.Users.v1
{
    internal abstract class UserApiObjectV1 : UserApiObject, IUserApiObject
    {
        internal UserApiObjectV1(EncompassRestClient client, IUserApis userApis, string userId, string? baseApiPath)
            : base(client, userApis, userId, $"encompass/v1/company/users/{userId}{baseApiPath?.PrecedeWith("/")}")
        {
        }
    }
}