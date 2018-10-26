using EncompassRest.Utilities;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User Custom Data Objects Apis
    /// </summary>
    public sealed class UserCustomDataObjects : CustomDataObjects.CustomDataObjects
    {
        /// <summary>
        /// User's Id
        /// </summary>
        public string UserId { get; }

        internal UserCustomDataObjects(EncompassRestClient client, string userId)
            : base(client, $"encompass/v1/users/{userId}/customObjects")
        {
            UserId = userId;
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{UserId}{resourceId?.PrecedeWith("/")}");
    }
}