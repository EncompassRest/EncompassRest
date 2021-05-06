using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Company.Users.v1
{
    public static class UserLicenseDetailsExtensions
    {
        public static IUserLicenseDetailsV1? V1 { get; set; }

        private static IUserLicenseDetailsV1 GetV1(IUserLicenseDetails userLicenseDetails)
        {
            var v1 = V1;
            if (userLicenseDetails is UserLicenseDetails l)
            {
                v1 = (IUserLicenseDetailsV1)l.ExtensionData.GetOrAdd("v1", k => new UserLicenseDetailsV1(l.Client, l.UserApis, l.UserId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(userLicenseDetails, nameof(userLicenseDetails));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets the user's licenses.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<UserLicenseDetail>> GetLicenseDetailsAsync(this IUserLicenseDetails userLicenseDetails, CancellationToken cancellationToken = default) => GetLicenseDetailsAsync(userLicenseDetails, state: null, cancellationToken);

        /// <summary>
        /// Gets the user's licenses for a particular state.
        /// </summary>
        /// <param name="state">The state code for which to return license information.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<UserLicenseDetail>> GetLicenseDetailsAsync(this IUserLicenseDetails userLicenseDetails, State state, CancellationToken cancellationToken = default) => GetLicenseDetailsAsync(userLicenseDetails, state.Validate(nameof(state)).GetValue(), cancellationToken);

        /// <summary>
        /// Gets the user's licenses and for a particular state if specified.
        /// </summary>
        /// <param name="state">The state code for which to return license information.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<UserLicenseDetail>> GetLicenseDetailsAsync(this IUserLicenseDetails userLicenseDetails, string? state, CancellationToken cancellationToken = default) => GetV1(userLicenseDetails).GetLicenseDetailsAsync(state, cancellationToken);

        /// <summary>
        /// Gets the user's licenses as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetLicenseDetailsRawAsync(this IUserLicenseDetails userLicenseDetails, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(userLicenseDetails).GetLicenseDetailsRawAsync(queryString, cancellationToken);
    }
}