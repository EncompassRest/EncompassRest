﻿using EncompassApi.Utilities;

namespace EncompassApi.Company.Users
{
    /// <summary>
    /// User Custom Data Objects Apis
    /// </summary>
    public interface IUserCustomDataObjects : CustomDataObjects.ICustomDataObjects, IUserApiObject
    {
    }

    /// <summary>
    /// User Custom Data Objects Apis
    /// </summary>
    public sealed class UserCustomDataObjects : CustomDataObjects.CustomDataObjects, IUserCustomDataObjects
    {
        /// <inheritdoc/>
        public string UserId { get; }

        internal UserCustomDataObjects(IEncompassApiClient client, string userId)
            : base(client, $"encompass/v1/users/{userId}/customObjects")
        {
            UserId = userId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{UserId}{resourceId?.PrecedeWith("/")}");
    }
}