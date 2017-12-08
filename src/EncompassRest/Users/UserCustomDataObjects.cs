namespace EncompassRest.Users
{
    public sealed class UserCustomDataObjects : CustomDataObjects.CustomDataObjects
    {
        public string UserId { get; }

        internal UserCustomDataObjects(EncompassRestClient client, string userId)
            : base(client, $"encompass/v1/users/{userId}/customObjects")
        {
            UserId = userId;
        }

        internal override string CreateErrorMessage(string methodName, string resourceId = null) => base.CreateErrorMessage(methodName, $"{UserId}{(string.IsNullOrEmpty(resourceId) ? string.Empty : "/")}{resourceId}");
    }
}