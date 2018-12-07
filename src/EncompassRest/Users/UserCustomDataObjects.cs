using EncompassRest.Utilities;

namespace EncompassRest.Users
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public sealed class UserCustomDataObjects : CustomDataObjects.CustomDataObjects
    {
        public string UserId { get; }

        internal UserCustomDataObjects(EncompassRestClient client, string userId)
            : base(client, $"encompass/v1/users/{userId}/customObjects")
        {
            UserId = userId;
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{UserId}{resourceId?.PrecedeWith("/")}");
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}