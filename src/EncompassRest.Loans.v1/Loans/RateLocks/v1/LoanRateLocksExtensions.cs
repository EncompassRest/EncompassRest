using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.RateLocks.v1
{
    public static class LoanRateLocksExtensions
    {
        public static ILoanRateLocksV1? V1 { get; set; }

        private static ILoanRateLocksV1 GetV1(ILoanRateLocks rateLocks)
        {
            var v1 = V1;
            if (rateLocks is LoanRateLocks l)
            {
                v1 = (ILoanRateLocksV1)l.ExtensionData.GetOrAdd("v1", k => new LoanRateLocksV1(l.Client, l.LoanApis, l.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(rateLocks, nameof(rateLocks));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="view">Specifies the level of detail to be returned for the ratelockrequest. Possible values are: Detailed and Summary. Summary is the default.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<RateLockRequest> GetRateLockAsync(this ILoanRateLocks rateLocks, string requestId, LockView? view, CancellationToken cancellationToken = default) => GetRateLockAsync(rateLocks, requestId, view?.Validate(nameof(view)).GetValue(), cancellationToken);

        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="view">Specifies the level of detail to be returned for the ratelockrequest. Possible values are: Detailed and Summary. Summary is the default.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<RateLockRequest> GetRateLockAsync(this ILoanRateLocks rateLocks, string requestId, string? view = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).GetRateLockAsync(requestId, view, cancellationToken);

        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan as raw json.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetRateLockRawAsync(this ILoanRateLocks rateLocks, string requestId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).GetRateLockRawAsync(requestId, queryString, cancellationToken);

        /// <summary>
        /// Returns the loan snapshot associated with the specified Rate Lock Request.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Dictionary<string, string>> GetRateLockSnapshotAsync(this ILoanRateLocks rateLocks, string requestId, CancellationToken cancellationToken = default) => GetV1(rateLocks).GetRateLockSnapshotAsync(requestId, cancellationToken);

        /// <summary>
        /// Returns the loan snapshot associated with the specified Rate Lock Request as raw json.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetRateLockSnapshotRawAsync(this ILoanRateLocks rateLocks, string requestId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).GetRateLockSnapshotRawAsync(requestId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves all rate lock requests for the specified loan. To retrieve the "current" rate lock on the loan, look for the rate lock with "lockStatus": "Locked"
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<RateLockRequest>> GetRateLocksAsync(this ILoanRateLocks rateLocks, CancellationToken cancellationToken = default) => GetV1(rateLocks).GetRateLocksAsync(cancellationToken);

        /// <summary>
        /// Retrieves all rate lock requests for the specified loan as raw json. To retrieve the "current" rate lock on the loan, look for the rate lock with "lockStatus": "Locked"
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetRateLocksRawAsync(this ILoanRateLocks rateLocks, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).GetRateLocksRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="action">Possible actions for a Secondary user include: confirm: Creates and confirms a new rate lock. extend: Extends the confirmed and current rate lock. This creates a new rate lock. relock: Re-locks the confirmed rate lock. This creates a new rate lock. cancel: Cancels a confirmed rate lock request.</param>
        /// <param name="dataSyncOption">Determines whether the loan will be updated with lock data after a lock is confirmed. Possible values are - noSync: Does not update the loan with lock data upon lock confirmation. - syncLockToLoan: The default value. Updates the loan with the lock data upon lock confirmation.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> SubmitRateLockRequestAsync(this ILoanRateLocks rateLocks, RateLockRequest lockRequest, bool populate, LockAction? action, DataSyncOption? dataSyncOption, CancellationToken cancellationToken = default) => SubmitRateLockRequestAsync(rateLocks, lockRequest, populate, action?.Validate(nameof(action)).GetValue(), dataSyncOption?.Validate(nameof(dataSyncOption)).GetValue(), cancellationToken);

        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="action">Possible actions for a Secondary user include: confirm: Creates and confirms a new rate lock. extend: Extends the confirmed and current rate lock. This creates a new rate lock. relock: Re-locks the confirmed rate lock. This creates a new rate lock. cancel: Cancels a confirmed rate lock request.</param>
        /// <param name="dataSyncOption">Determines whether the loan will be updated with lock data after a lock is confirmed. Possible values are - noSync: Does not update the loan with lock data upon lock confirmation. - syncLockToLoan: The default value. Updates the loan with the lock data upon lock confirmation.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> SubmitRateLockRequestAsync(this ILoanRateLocks rateLocks, RateLockRequest lockRequest, bool populate, string? action = null, string? dataSyncOption = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).SubmitRateLockRequestAsync(lockRequest, populate, action, dataSyncOption, cancellationToken);

        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="lockRequest">The lock request details as raw json</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> SubmitRateLockRequestRawAsync(this ILoanRateLocks rateLocks, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).SubmitRateLockRequestRawAsync(lockRequest, queryString, cancellationToken);

        /// <summary>
        /// Update rate lock request of a specified request ID for a loan. A rate lock request can be updated if it has not been confirmed or denied or cancelled. Updating a rate lock request will not create a new request.
        /// </summary>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateRateLockRequestAsync(this ILoanRateLocks rateLocks, RateLockRequest lockRequest, bool populate, CancellationToken cancellationToken = default) => GetV1(rateLocks).UpdateRateLockRequestAsync(lockRequest, populate, cancellationToken);

        /// <summary>
        /// Update rate lock request of a specified request ID for a loan. A rate lock request can be updated if it has not been confirmed or denied or cancelled. Updating a rate lock request will not create a new request.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request.</param>
        /// <param name="lockRequest">The lock request details as raw json</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateRateLockRequestRawAsync(this ILoanRateLocks rateLocks, string requestId, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).UpdateRateLockRequestRawAsync(requestId, lockRequest, queryString, cancellationToken);

        /// <summary>
        /// Use this API to confirm a rate lock request. This call releases any existing rate lock on the specified loan and locks the new rate on the loan.
        /// </summary>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task ConfirmRateLockRequestAsync(this ILoanRateLocks rateLocks, RateLockRequest lockRequest, bool populate, CancellationToken cancellationToken = default) => GetV1(rateLocks).ConfirmRateLockRequestAsync(lockRequest, populate, cancellationToken);

        /// <summary>
        /// Use this API to confirm a rate lock request. This call releases any existing rate lock on the specified loan and locks the new rate on the loan from raw json.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request.</param>
        /// <param name="lockRequest">The lock request details as raw json</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ConfirmRateLockRequestRawAsync(this ILoanRateLocks rateLocks, string requestId, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).ConfirmRateLockRequestRawAsync(requestId, lockRequest, queryString, cancellationToken);

        /// <summary>
        /// Cancels an existing lock. Only locks that are recently requested or confirmed can be canceled.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="cancellationOptions">Lock cancellation comments</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<RateLockRequest> CancelRateLockRequestAsync(this ILoanRateLocks rateLocks, string requestId, RateLockCancelDenyOptions? cancellationOptions = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).CancelRateLockRequestAsync(requestId, cancellationOptions, cancellationToken);

        /// <summary>
        /// Cancels an existing lock. Only locks that are recently requested or confirmed can be canceled.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="cancellationOptions">Lock cancellation comments</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CancelRateLockRequestRawAsync(this ILoanRateLocks rateLocks, string requestId, string cancellationOptions, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).CancelRateLockRequestRawAsync(requestId, cancellationOptions, queryString, cancellationToken);

        /// <summary>
        /// Denies a rate lock request for the specified request ID.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="denialOptions">Lock denial comments</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<RateLockRequest> DenyRateLockRequestAsync(this ILoanRateLocks rateLocks, string requestId, RateLockCancelDenyOptions? denialOptions = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).DenyRateLockRequestAsync(requestId, denialOptions, cancellationToken);

        /// <summary>
        /// Denies a rate lock request for the specified request ID using raw json.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="denialOptions">Lock denial comments</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> DenyRateLockRequestRawAsync(this ILoanRateLocks rateLocks, string requestId, string denialOptions, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(rateLocks).DenyRateLockRequestRawAsync(requestId, denialOptions, queryString, cancellationToken);
    }
}