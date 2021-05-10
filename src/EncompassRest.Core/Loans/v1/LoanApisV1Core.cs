using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.ResourceLocks.v1;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// The Loan Apis.
    /// </summary>
    public interface ILoanApisV1Core : ILoanApiObject
    {
        /// <summary>
        /// Retrieves the loan lock information with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id of the lock to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ResourceLock> GetLockAsync(string lockId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of loan lock information from Encompass.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<ResourceLock>> GetLocksAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves metadata from the loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanMetadata> GetMetadataAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves metadata from the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetMetadataRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to lock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> LockAsync(string lockType, bool force, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryUnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default);
    }

    internal sealed class LoanApisV1Core : LoanApiObjectV1, ILoanApisV1Core
    {
        internal LoanApisV1Core(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, null)
        {
        }

        public Task<LoanMetadata> GetMetadataAsync(CancellationToken cancellationToken = default) => GetAsync<LoanMetadata>("metadata", null, nameof(GetMetadataAsync), null, cancellationToken);

        public Task<string> GetMetadataRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("metadata", queryString, nameof(GetMetadataAsync), null, cancellationToken);

        public Task<List<ResourceLock>> GetLocksAsync(CancellationToken cancellationToken = default) => Client.ResourceLocks.GetResourceLocksAsync(LoanId, EntityType.Loan, cancellationToken);

        public Task<ResourceLock> GetLockAsync(string lockId, CancellationToken cancellationToken = default) => Client.ResourceLocks.GetResourceLockAsync(lockId, LoanId, EntityType.Loan, cancellationToken);

        public Task<string> LockAsync(string lockType, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.LockResourceAsync(lockType, LoanId, EntityType.Loan.GetValue()!, force, cancellationToken);

        public Task<bool> TryUnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.TryUnlockResourceAsync(lockId, LoanId, EntityType.Loan.GetValue()!, force, cancellationToken);

        public Task UnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.UnlockResourceAsync(lockId, LoanId, EntityType.Loan.GetValue()!, force, cancellationToken);

        
    }
}