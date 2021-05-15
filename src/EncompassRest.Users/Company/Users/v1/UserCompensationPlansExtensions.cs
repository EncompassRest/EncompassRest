using System;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Company.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    /// The User Compensation Plans Api extension methods.
    /// </summary>
    public static class UserCompensationPlansExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IUserCompensationPlansV1? V1 { get; set; }

        private static IUserCompensationPlansV1 GetV1(IUserCompensationPlans users)
        {
            var v1 = V1;
            if (users is UserCompensationPlans u)
            {
                v1 = u.ExtensionData.GetOrAdd(() => new UserCompensationPlansV1(u.Client, u.UserApis, u.UserId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(users, nameof(users));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Gets the user's compensation plans.
        /// </summary>
        /// <param name="userCompensationPlans">The User Compensation Plans Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<CompensationPlans> GetCompensationPlansAsync(this IUserCompensationPlans userCompensationPlans, CancellationToken cancellationToken = default) => GetV1(userCompensationPlans).GetCompensationPlansAsync(cancellationToken);

        /// <summary>
        /// Gets the user's compensation plans as raw json.
        /// </summary>
        /// <param name="userCompensationPlans">The User Compensation Plans Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetCompensationPlansRawAsync(this IUserCompensationPlans userCompensationPlans, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(userCompensationPlans).GetCompensationPlansRawAsync(queryString, cancellationToken);
    }
}