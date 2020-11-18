using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.RateLocks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// The Loan Rate Lock Apis.
    /// </summary>
    public interface ILoanRateLocks : ILoanApiObject
    {
        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="view">Specifies the level of detail to be returned for the ratelockrequest. Possible values are: Detailed and Summary. Summary is the default.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<RateLockRequest> GetRateLockAsync(string requestId, LockView? view = LockView.Summary, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan as raw json.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRateLockRawAsync(string requestId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the loan snapshot associated with the specified Rate Lock Request.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Dictionary<string, string>> GetRateLockSnapshotAsync(string requestId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the loan snapshot associated with the specified Rate Lock Request as raw json.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRateLockSnapshotRawAsync(string requestId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all rate lock requests for the specified loan. To retrieve the "current" rate lock on the loan, look for the rate lock with "lockStatus": "Locked"
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<RateLockRequest>> GetRateLocksAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all rate lock requests for the specified loan as raw json. To retrieve the "current" rate lock on the loan, look for the rate lock with "lockStatus": "Locked"
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetRateLocksRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="action">Possible actions for a Secondary user include: confirm: Creates and confirms a new rate lock. extend: Extends the confirmed and current rate lock. This creates a new rate lock. relock: Re-locks the confirmed rate lock. This creates a new rate lock. cancel: Cancels a confirmed rate lock request.</param>
        /// <param name="dataSyncOption">Determines whether the loan will be updated with lock data after a lock is confirmed. Possible values are - noSync: Does not update the loan with lock data upon lock confirmation. - syncLockToLoan: The default value. Updates the loan with the lock data upon lock confirmation.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> SubmitRateLockRequestAsync(RateLockRequest lockRequest, bool populate, LockAction? action = null, DataSyncOption? dataSyncOption = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request.</param>
        /// <param name="lockRequest">The lock request details as raw json</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> SubmitRateLockRequestRawAsync(string requestId, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update rate lock request of a specified request ID for a loan. A rate lock request can be updated if it has not been confirmed or denied or cancelled. Updating a rate lock request will not create a new request.
        /// </summary>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateRateLockRequestAsync(RateLockRequest lockRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// Update rate lock request of a specified request ID for a loan. A rate lock request can be updated if it has not been confirmed or denied or cancelled. Updating a rate lock request will not create a new request.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request.</param>
        /// <param name="lockRequest">The lock request details as raw json</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateRateLockRequestRawAsync(string requestId, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API to confirm a rate lock request. This call releases any existing rate lock on the specified loan and locks the new rate on the loan.
        /// </summary>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task ConfirmRateLockRequestAsync(RateLockRequest lockRequest, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Use this API to confirm a rate lock request. This call releases any existing rate lock on the specified loan and locks the new rate on the loan from raw json.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request.</param>
        /// <param name="lockRequest">The lock request details as raw json</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> ConfirmRateLockRequestRawAsync(string requestId, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancels an existing lock. Only locks that are recently requested or confirmed can be canceled.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationOptions">Lock cancellation comments</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<RateLockRequest> CancelRateLockRequestAsync(string requestId, bool populate, RateLockCancelDenyOptions? cancellationOptions = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancels an existing lock. Only locks that are recently requested or confirmed can be canceled.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="cancellationOptions">Lock cancellation comments</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CancelRateLockRequestRawAsync(string requestId, string cancellationOptions, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Denies a rate lock request for the specified request ID.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="denialOptions">Lock denial comments</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<RateLockRequest> DenyRateLockRequestAsync(string requestId, bool populate, RateLockCancelDenyOptions? denialOptions = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Denies a rate lock request for the specified request ID using raw json.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="denialOptions">Lock denial comments</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> DenyRateLockRequestRawAsync(string requestId, string denialOptions, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Rate Lock Apis.
    /// </summary>
    public sealed class LoanRateLocks : LoanApiObject, ILoanRateLocks
    {
        internal LoanRateLocks(EncompassRestClient client, string loanId)
            : base(client, loanId, "ratelockRequests")
        {
        }

        /// <summary>
        /// Retrieves all rate lock requests for the specified loan. To retrieve the "current" rate lock on the loan, look for the rate lock with "lockStatus": "Locked"
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<RateLockRequest>> GetRateLocksAsync(CancellationToken cancellationToken = default) => GetDirtyListAsync<RateLockRequest>(null, null, nameof(GetRateLocksAsync), null, cancellationToken);

        /// <summary>
        /// Retrieves all rate lock requests for the specified loan as raw json. To retrieve the "current" rate lock on the loan, look for the rate lock with "lockStatus": "Locked"
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetRateLocksRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetRateLocksRawAsync), null, cancellationToken);


        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="view">Specifies the level of detail to be returned for the ratelockrequest. Possible values are: Detailed and Summary. Summary is the default.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<RateLockRequest> GetRateLockAsync(string requestId, LockView? view = LockView.Summary, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            var queryParameters = new QueryParameters();

            if (view.HasValue)
            {
                queryParameters.Add("view", view.ToString().ToLower());
            }

            return await GetDirtyAsync<RateLockRequest>(requestId, queryParameters.ToString(), nameof(GetRateLockAsync), requestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves rate lock information for a specified request ID in a loan as raw json.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetRateLockRawAsync(string requestId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetRawAsync(requestId, queryString, nameof(GetRateLockRawAsync), requestId, cancellationToken);
        }

        /// <summary>
        /// Returns the loan snapshot associated with the specified Rate Lock Request.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public async Task<Dictionary<string, string>> GetRateLockSnapshotAsync(string requestId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return await GetAsync<Dictionary<string, string>>($"{requestId}/snapshot", null, nameof(GetRateLockAsync), requestId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns the loan snapshot associated with the specified Rate Lock Request as raw json.
        /// </summary>
        /// <param name="requestId">Unique identifier assigned to the request. The requestId is returned in the response as part of the location header after submitting a rate lock request.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetRateLockSnapshotRawAsync(string requestId, string? queryString = null, CancellationToken cancellationToken = default) {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return GetRawAsync($"{requestId}/snapshot", queryString, nameof(GetRateLockSnapshotRawAsync), requestId, cancellationToken);
        }

        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="action">Possible actions for a Secondary user include: confirm: Creates and confirms a new rate lock. extend: Extends the confirmed and current rate lock. This creates a new rate lock. relock: Re-locks the confirmed rate lock. This creates a new rate lock. cancel: Cancels a confirmed rate lock request.</param>
        /// <param name="dataSyncOption">Determines whether the loan will be updated with lock data after a lock is confirmed. Possible values are - noSync: Does not update the loan with lock data upon lock confirmation. - syncLockToLoan: The default value. Updates the loan with the lock data upon lock confirmation.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> SubmitRateLockRequestAsync(RateLockRequest lockRequest, bool populate, LockAction? action = null, DataSyncOption? dataSyncOption = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();

            if (action.HasValue)
            {
                queryParameters.Add("action", action.ToString().ToLower());
            }
            if (dataSyncOption.HasValue)
            {
                queryParameters.Add("dataSyncOption", dataSyncOption.ToString().ToLower());
            }
            if (lockRequest.Id != null)
            {
                queryParameters.Add("requestId", lockRequest.Id.ToLower());
            }

            return PostPopulateDirtyAsync(null, nameof(SubmitRateLockRequestAsync), lockRequest, populate, cancellationToken);
        }

        /// <summary>
        /// Use this API to create a new rate lock request if you are a Loan Officer. If you are a Secondary user, use this API to perform an action on an existing rate lock request for a specified loan, or submit and confirm a new rate lock request for the loan.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> SubmitRateLockRequestRawAsync(string requestId, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));
            Preconditions.NotNullOrEmpty(lockRequest, nameof(lockRequest));

            return PostRawAsync(requestId, queryString, JsonStreamContent.Create(lockRequest), nameof(SubmitRateLockRequestRawAsync), requestId, cancellationToken);
        }

        /// <summary>
        /// Update rate lock request of a specified request ID for a loan. A rate lock request can be updated if it has not been confirmed or denied or cancelled. Updating a rate lock request will not create a new request.
        /// </summary>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateRateLockRequestAsync(RateLockRequest lockRequest, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(lockRequest, nameof(lockRequest));
            Preconditions.NotNullOrEmpty(lockRequest.Id, nameof(lockRequest.Id));

            return PatchPopulateDirtyAsync(lockRequest.Id, JsonStreamContent.Create(lockRequest), nameof(UpdateRateLockRequestAsync), lockRequest.Id, lockRequest, true, cancellationToken);
        }

        /// <summary>
        /// Update rate lock request of a specified request ID for a loan. A rate lock request can be updated if it has not been confirmed or denied or cancelled. Updating a rate lock request will not create a new request.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request.</param>
        /// <param name="lockRequest">The lock request details as raw json</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateRateLockRequestRawAsync(string requestId, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));
            Preconditions.NotNullOrEmpty(lockRequest, nameof(lockRequest));

            return PatchRawAsync(requestId, queryString, JsonStreamContent.Create(lockRequest), nameof(UpdateRateLockRequestRawAsync), requestId, cancellationToken);
        }

        /// <summary>
        /// Use this API to confirm a rate lock request. This call releases any existing rate lock on the specified loan and locks the new rate on the loan.
        /// </summary>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task ConfirmRateLockRequestAsync(RateLockRequest lockRequest, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(lockRequest.Id, nameof(lockRequest.Id));

            return PutPopulateDirtyAsync($"{lockRequest.Id}/confirmation", JsonStreamContent.Create(lockRequest), nameof(ConfirmRateLockRequestAsync), lockRequest.Id, lockRequest, populate, cancellationToken);
        }

        /// <summary>
        /// Use this API to confirm a rate lock request. This call releases any existing rate lock on the specified loan and locks the new rate on the loan from raw json.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request.</param>
        /// <param name="lockRequest">The lock request details. Use the data provided in the sample request or create a lock request with default values using null</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> ConfirmRateLockRequestRawAsync(string requestId, string lockRequest, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));
            Preconditions.NotNullOrEmpty(lockRequest, nameof(lockRequest));

            return PutRawAsync($"{requestId}/confirmation", queryString, JsonStreamContent.Create(lockRequest), nameof(ConfirmRateLockRequestAsync), requestId, cancellationToken);
        }

        /// <summary>
        /// Cancels an existing lock. Only locks that are recently requested or confirmed can be canceled.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationOptions">Lock cancellation options</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<RateLockRequest> CancelRateLockRequestAsync(string requestId, bool populate, RateLockCancelDenyOptions? cancellationOptions = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            cancellationOptions = cancellationOptions == null ? new RateLockCancelDenyOptions() : cancellationOptions;

            var queryParameters = new QueryParameters();
            queryParameters.Add("view", populate ? "entity" : "id");

            return PutAsync($"{requestId}/cancellation", queryParameters.ToString(), JsonStreamContent.Create(cancellationOptions), nameof(CancelRateLockRequestAsync), requestId, cancellationToken, FuncCache<RateLockRequest>.ReadAsFunc);
        }

        /// <summary>
        /// Cancels an existing lock. Only locks that are recently requested or confirmed can be canceled from raw json.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="cancellationOptions">Lock cancellation options</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CancelRateLockRequestRawAsync(string requestId, string cancellationOptions, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return PutRawAsync($"{requestId}/cancellation", queryString, JsonStreamContent.Create(cancellationOptions), nameof(CancelRateLockRequestAsync), requestId, cancellationToken);
        }

        /// <summary>
        /// Denies a rate lock request for the specified request ID.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="populate">Indicates if the lock request object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="denialOptions">Lock denial options</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<RateLockRequest> DenyRateLockRequestAsync(string requestId, bool populate, RateLockCancelDenyOptions? denialOptions = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            denialOptions = denialOptions == null ? new RateLockCancelDenyOptions() : denialOptions;

            var queryParameters = new QueryParameters();
            queryParameters.Add("view", populate ? "entity" : "id");

            return PutAsync($"{requestId}/denial", queryParameters.ToString(), JsonStreamContent.Create(denialOptions), nameof(DenyRateLockRequestAsync), requestId, cancellationToken, FuncCache<RateLockRequest>.ReadAsFunc);
        }

        /// <summary>
        /// Denies a rate lock request for the specified request ID from raw json.
        /// </summary>
        /// <param name="requestId">The unique identifier of the existing rate lock request. Required for extend, relock and cancel actions.</param>
        /// <param name="denialOptions">Lock denial options</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> DenyRateLockRequestRawAsync(string requestId, string denialOptions, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(requestId, nameof(requestId));

            return PutRawAsync($"{requestId}/denial", queryString, JsonStreamContent.Create(denialOptions), nameof(DenyRateLockRequestRawAsync), requestId, cancellationToken);
        }
    }
}