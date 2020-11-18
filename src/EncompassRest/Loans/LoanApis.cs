using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.Apis;
using EncompassRest.Loans.Associates;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Conditions;
using EncompassRest.Loans.Documents;
using EncompassRest.Loans.FieldReader;
using EncompassRest.Loans.MilestoneFreeRoles;
using EncompassRest.Loans.Milestones;
using EncompassRest.Loans.RateLocks;
using EncompassRest.ResourceLocks;
using EnumsNET;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loan Apis.
    /// </summary>
    public interface ILoanApis : ILoanApiObject
    {
        /// <summary>
        /// The Loan Associates Apis.
        /// </summary>
        ILoanAssociates Associates { get; }
        /// <summary>
        /// The Loan Attachments Apis.
        /// </summary>
        ILoanAttachments Attachments { get; }
        /// <summary>
        /// The Loan Borrower Pairs Apis.
        /// </summary>
        IBorrowerPairs BorrowerPairs { get; }
        /// <summary>
        /// The Loan Conditions Apis.
        /// </summary>
        ILoanConditions Conditions { get; }
        /// <summary>
        /// The Loan Custom Data Objects Apis.
        /// </summary>
        ILoanCustomDataObjects CustomDataObjects { get; }
        /// <summary>
        /// The Loan Documents Apis.
        /// </summary>
        ILoanDocuments Documents { get; }
        /// <summary>
        /// The Loan Field Reader Apis.
        /// </summary>
        ILoanFieldReader FieldReader { get; }
        /// <summary>
        /// The Loan Milestone Free Roles Apis.
        /// </summary>
        ILoanMilestoneFreeRoles MilestoneFreeRoles { get; }
        /// <summary>
        /// The Loan Milestone Apis.
        /// </summary>
        ILoanMilestones Milestones { get; }
        /// <summary>
        /// The Loan Rate Lock Apis.
        /// </summary>
        ILoanRateLocks RateLocks { get; }

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
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> LockAsync(ResourceLockType lockType, CancellationToken cancellationToken = default);
        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to lock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> LockAsync(ResourceLockType lockType, bool force, CancellationToken cancellationToken = default);
        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> LockAsync(string lockType, CancellationToken cancellationToken = default);
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
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryUnlockAsync(string lockId, CancellationToken cancellationToken = default);
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
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UnlockAsync(string lockId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Apis.
    /// </summary>
    public class LoanApis : LoanApiObject, ILoanApis
    {
        private LoanDocuments? _documents;
        private LoanAttachments? _attachments;
        private LoanCustomDataObjects? _customDataObjects;
        private LoanAssociates? _associates;
        private LoanMilestones? _milestones;
        private LoanMilestoneFreeRoles? _milestoneFreeRoles;
        private LoanFieldReader? _fieldReader;
        private LoanConditions? _conditions;
        private LoanRateLocks? _rateLocks;
        private BorrowerPairs? _borrowerPairs;

        /// <summary>
        /// The Loan Documents Apis.
        /// </summary>
        public LoanDocuments Documents => _documents ?? (_documents = new LoanDocuments(Client, LoanId));

        ILoanDocuments ILoanApis.Documents => Documents;

        /// <summary>
        /// The Loan Attachments Apis.
        /// </summary>
        public LoanAttachments Attachments => _attachments ?? (_attachments = new LoanAttachments(Client, LoanId));

        ILoanAttachments ILoanApis.Attachments => Attachments;

        /// <summary>
        /// The Loan Custom Data Objects Apis.
        /// </summary>
        public LoanCustomDataObjects CustomDataObjects => _customDataObjects ?? (_customDataObjects = new LoanCustomDataObjects(Client, LoanId));

        ILoanCustomDataObjects ILoanApis.CustomDataObjects => CustomDataObjects;

        /// <summary>
        /// The Loan Associates Apis.
        /// </summary>
        public LoanAssociates Associates => _associates ?? (_associates = new LoanAssociates(Client, LoanId));

        ILoanAssociates ILoanApis.Associates => Associates;

        /// <summary>
        /// The Loan Milestone Apis.
        /// </summary>
        public LoanMilestones Milestones => _milestones ?? (_milestones = new LoanMilestones(Client, LoanId));

        ILoanMilestones ILoanApis.Milestones => Milestones;

        /// <summary>
        /// The Loan Milestone Free Roles Apis.
        /// </summary>
        public LoanMilestoneFreeRoles MilestoneFreeRoles => _milestoneFreeRoles ?? (_milestoneFreeRoles = new LoanMilestoneFreeRoles(Client, LoanId));

        ILoanMilestoneFreeRoles ILoanApis.MilestoneFreeRoles => MilestoneFreeRoles;

        /// <summary>
        /// The Loan Field Reader Apis.
        /// </summary>
        public LoanFieldReader FieldReader => _fieldReader ?? (_fieldReader = new LoanFieldReader(Client, LoanId));

        ILoanFieldReader ILoanApis.FieldReader => FieldReader;

        /// <summary>
        /// The Loan Conditions Apis.
        /// </summary>
        public LoanConditions Conditions => _conditions ?? (_conditions = new LoanConditions(Client, LoanId));

        ILoanConditions ILoanApis.Conditions => Conditions;

        /// <summary>
        /// The Loan Rate Lock Apis.
        /// </summary>
        public LoanRateLocks RateLocks => _rateLocks ?? (_rateLocks = new LoanRateLocks(Client, LoanId));

        ILoanRateLocks ILoanApis.RateLocks => RateLocks;

        /// <summary>
        /// The Loan Borrower Pairs Apis.
        /// </summary>
        public BorrowerPairs BorrowerPairs => _borrowerPairs ?? (_borrowerPairs = new BorrowerPairs(Client, this as LoanObjectBoundApis, LoanId));

        IBorrowerPairs ILoanApis.BorrowerPairs => BorrowerPairs;

        internal LoanApis(EncompassRestClient client, string loanId)
            : base(client, loanId, null)
        {
        }

        /// <summary>
        /// Retrieves metadata from the loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<LoanMetadata> GetMetadataAsync(CancellationToken cancellationToken = default) => GetAsync<LoanMetadata>("metadata", null, nameof(GetMetadataAsync), null, cancellationToken);

        /// <summary>
        /// Retrieves metadata from the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetMetadataRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("metadata", queryString, nameof(GetMetadataAsync), null, cancellationToken);

        /// <summary>
        /// Retrieves a list of loan lock information from Encompass.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<ResourceLock>> GetLocksAsync(CancellationToken cancellationToken = default) => Client.ResourceLocks.GetResourceLocksAsync(LoanId, EntityType.Loan, cancellationToken);

        /// <summary>
        /// Retrieves the loan lock information with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id of the lock to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<ResourceLock> GetLockAsync(string lockId, CancellationToken cancellationToken = default) => Client.ResourceLocks.GetResourceLockAsync(lockId, LoanId, EntityType.Loan, cancellationToken);

        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> LockAsync(ResourceLockType lockType, CancellationToken cancellationToken = default) => LockAsync(lockType, false, cancellationToken);

        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to lock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> LockAsync(ResourceLockType lockType, bool force, CancellationToken cancellationToken = default) => LockAsync(lockType.Validate(nameof(lockType)).GetValue()!, force, cancellationToken);

        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> LockAsync(string lockType, CancellationToken cancellationToken = default) => LockAsync(lockType, false, cancellationToken);

        /// <summary>
        /// Locks the loan in Encompass and returns the lock id.
        /// </summary>
        /// <param name="lockType">Type of Lock.</param>
        /// <param name="force">Forcefully locks a loan. This parameter allows an administrator to lock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> LockAsync(string lockType, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.LockResourceAsync(lockType, LoanId, EntityType.Loan.GetValue()!, force, cancellationToken);

        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> TryUnlockAsync(string lockId, CancellationToken cancellationToken = default) => TryUnlockAsync(lockId, false, cancellationToken);

        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> TryUnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.TryUnlockResourceAsync(lockId, LoanId, EntityType.Loan.GetValue()!, force, cancellationToken);

        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UnlockAsync(string lockId, CancellationToken cancellationToken = default) => UnlockAsync(lockId, false, cancellationToken);

        /// <summary>
        /// Unlocks the loan in Encompass with the specified <paramref name="lockId"/>.
        /// </summary>
        /// <param name="lockId">The lock id to unlock.</param>
        /// <param name="force">Forcefully unlocks a loan. This parameter allows an administrator to unlock a loan that holds an exclusive lock. When set to <c>true</c>, the exclusive lock is released from the loan. The user holding the exclusive lock is notified about the lock being released and that changes cannot be saved. The default value is <c>false</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.UnlockResourceAsync(lockId, LoanId, EntityType.Loan.GetValue()!, force, cancellationToken);
    }
}