using EncompassRest.CustomDataObjects.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    /// User Custom Data Objects Apis
    /// </summary>
    public interface IUserCustomDataObjectsV1 : ICustomDataObjectsV1, IUserApiObject
    {
    }

    internal sealed class UserCustomDataObjectsV1 : CustomDataObjectsV1, IUserCustomDataObjectsV1
    {
        public IUserApis UserApis { get; }

        public string UserId { get; }

        internal UserCustomDataObjectsV1(EncompassRestClient client, IUserApis userApis, string userId)
            : base(client, $"encompass/v1/users/{userId}/customObjects")
        {
            UserApis = userApis;
            UserId = userId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{UserId}{resourceId?.PrecedeWith("/")}");
    }
}