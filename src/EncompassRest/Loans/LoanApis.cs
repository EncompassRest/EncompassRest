using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.Apis;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.ResourceLocks;

namespace EncompassRest.Loans
{
    public class LoanApis : LoanApiObject
    {
        private LoanDocuments _documents;
        private LoanAttachments _attachments;
        private LoanCustomDataObjects _customDataObjects;
        private BorrowerPairs _borrowerPairs;

        public LoanDocuments Documents => _documents ?? (_documents = new LoanDocuments(Client, LoanId));

        public LoanAttachments Attachments => _attachments ?? (_attachments = new LoanAttachments(Client, LoanId));

        public LoanCustomDataObjects CustomDataObjects => _customDataObjects ?? (_customDataObjects = new LoanCustomDataObjects(Client, LoanId));

        public BorrowerPairs BorrowerPairs => _borrowerPairs ?? (_borrowerPairs = CreateBorrowerPairs());

        internal virtual BorrowerPairs CreateBorrowerPairs() => new BorrowerPairs(Client, LoanId);

        internal LoanApis(EncompassRestClient client, string loanId)
            : base(client, loanId, null)
        {
        }

        public Task<LoanMetadata> GetMetadataAsync(CancellationToken cancellationToken = default) => GetAsync<LoanMetadata>("metadata", null, nameof(GetMetadataAsync), null, cancellationToken);

        public Task<string> GetMetadataRawAsync(CancellationToken cancellationToken = default) => GetRawAsync("metadata", null, nameof(GetMetadataAsync), null, cancellationToken);

        public Task<List<ResourceLock>> GetLocksAsync(CancellationToken cancellationToken = default) => Client.ResourceLocks.GetResourceLocksAsync(LoanId, EntityType.Loan, cancellationToken);

        public Task<ResourceLock> GetLockAsync(string lockId, CancellationToken cancellationToken = default) => Client.ResourceLocks.GetResourceLockAsync(lockId, LoanId, EntityType.Loan, cancellationToken);

        public Task<string> LockAsync(ResourceLockType lockType, CancellationToken cancellationToken = default) => Client.ResourceLocks.LockResourceAsync(lockType, LoanId, EntityType.Loan, false, cancellationToken);

        public Task<string> LockAsync(ResourceLockType lockType, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.LockResourceAsync(lockType, LoanId, EntityType.Loan, force, cancellationToken);

        public Task<string> LockAsync(string lockType, CancellationToken cancellationToken = default) => Client.ResourceLocks.LockResourceAsync(lockType, LoanId, EntityType.Loan, false, cancellationToken);

        public Task<string> LockAsync(string lockType, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.LockResourceAsync(lockType, LoanId, EntityType.Loan, force, cancellationToken);

        public Task<bool> UnlockAsync(string lockId, CancellationToken cancellationToken = default) => Client.ResourceLocks.UnlockResourceAsync(lockId, LoanId, EntityType.Loan, cancellationToken);

        public Task<bool> UnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.UnlockResourceAsync(lockId, LoanId, EntityType.Loan, force, cancellationToken);
    }
}