using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.CustomDataObjects.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users.v1
{
    public static class UserCustomDataObjectsExtensions
    {
        public static IUserCustomDataObjectsV1? V1 { get; set; }

        private static IUserCustomDataObjectsV1 GetV1(IUserCustomDataObjects customDataObjects)
        {
            var v1 = V1;
            if (customDataObjects is UserCustomDataObjects o)
            {
                v1 = (IUserCustomDataObjectsV1)o.ExtensionData.GetOrAdd("v1", k => new UserCustomDataObjectsV1(o.Client, o.UserApis, o.UserId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(customDataObjects, nameof(customDataObjects));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Updates the specified custom data object. This call adds the data provided in the body to the end of the dataObject.
        /// </summary>
        /// <param name="cdo">The custom data object to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AppendToCustomDataObjectAsync(this IUserCustomDataObjects customDataObjects, CustomDataObject cdo, CancellationToken cancellationToken = default) => AppendToCustomDataObjectAsync(customDataObjects, cdo, populate: false, cancellationToken);

        /// <summary>
        /// Updates the specified custom data object. This call adds the data provided in the body to the end of the dataObject. Optionally populates the custom data object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="cdo">The custom data object to update.</param>
        /// <param name="populate">Indicates if the custom data object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AppendToCustomDataObjectAsync(this IUserCustomDataObjects customDataObjects, CustomDataObject cdo, bool populate, CancellationToken cancellationToken = default) => GetV1(customDataObjects).AppendToCustomDataObjectAsync(cdo, populate, cancellationToken);

        /// <summary>
        /// Updates the specified custom data object from raw json. This call adds the data provided in the body to the end of the dataObject.
        /// </summary>
        /// <param name="objectName">Name of the custom data object to update.</param>
        /// <param name="cdo">The custom data object to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> AppendToCustomDataObjectRawAsync(this IUserCustomDataObjects customDataObjects, string objectName, string cdo, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(customDataObjects).AppendToCustomDataObjectRawAsync(objectName, cdo, queryString, cancellationToken);

        /// <summary>
        /// Creates or replaces a custom data object.
        /// </summary>
        /// <param name="cdo">The custom data object to create or replace.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateOrReplaceCustomDataObjectAsync(this IUserCustomDataObjects customDataObjects, CustomDataObject cdo, CancellationToken cancellationToken = default) => GetV1(customDataObjects).CreateOrReplaceCustomDataObjectAsync(cdo, cancellationToken);

        /// <summary>
        /// Creates or replaces a custom data object from raw json.
        /// </summary>
        /// <param name="objectName">Name to assign to the custom data object. Or, the name of an existing custom data object to replace.</param>
        /// <param name="cdo">The custom data object to create or replace as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateOrReplaceCustomDataObjectRawAsync(this IUserCustomDataObjects customDataObjects, string objectName, string cdo, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(customDataObjects).CreateOrReplaceCustomDataObjectRawAsync(objectName, cdo, queryString, cancellationToken);

        /// <summary>
        /// Removes a custom data object.
        /// </summary>
        /// <param name="objectName">Name of the custom data object to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteCustomDataObjectAsync(this IUserCustomDataObjects customDataObjects, string objectName, CancellationToken cancellationToken = default) => GetV1(customDataObjects).DeleteCustomDataObjectAsync(objectName, cancellationToken);

        /// <summary>
        /// Retrieves the contents of a custom data object. Contents are retrieved as a Base64 string.
        /// </summary>
        /// <param name="objectName">The name of the custom data object to retrieve.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<CustomDataObject> GetCustomDataObjectAsync(this IUserCustomDataObjects customDataObjects, string objectName, CancellationToken cancellationToken = default) => GetV1(customDataObjects).GetCustomDataObjectAsync(objectName, cancellationToken);

        /// <summary>
        /// Retrieves the contents of a custom data object as raw json. Contents are retrieved as a Base64 string.
        /// </summary>
        /// <param name="objectName">The name of the custom data object to retrieve.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetCustomDataObjectRawAsync(this IUserCustomDataObjects customDataObjects, string objectName, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(customDataObjects).GetCustomDataObjectRawAsync(objectName, queryString, cancellationToken);

        /// <summary>
        /// Provides a list of names of custom data objects.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<string>> GetCustomDataObjectsAsync(this IUserCustomDataObjects customDataObjects, CancellationToken cancellationToken = default) => GetV1(customDataObjects).GetCustomDataObjectsAsync(cancellationToken);

        /// <summary>
        /// Provides a list of names of custom data objects as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetCustomDataObjectsRawAsync(this IUserCustomDataObjects customDataObjects, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(customDataObjects).GetCustomDataObjectsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Removes a custom data object.
        /// </summary>
        /// <param name="objectName">Name of the custom data object to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteCustomDataObjectAsync(this IUserCustomDataObjects customDataObjects, string objectName, CancellationToken cancellationToken = default) => GetV1(customDataObjects).TryDeleteCustomDataObjectAsync(objectName, cancellationToken);
    }
}