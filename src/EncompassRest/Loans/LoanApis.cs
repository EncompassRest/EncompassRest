using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.Apis;
using EncompassRest.Loans.Associates;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Loans.MilestoneFreeRoles;
using EncompassRest.Loans.Milestones;
using EncompassRest.ResourceLocks;
using EnumsNET;

namespace EncompassRest.Loans
{
    public class LoanApis : LoanApiObject
    {
        private LoanDocuments _documents;
        private LoanAttachments _attachments;
        private LoanCustomDataObjects _customDataObjects;
        private LoanAssociates _associates;
        private LoanMilestones _milestones;
        private LoanMilestoneFreeRoles _milestoneFreeRoles;
        private BorrowerPairs _borrowerPairs;

        public LoanDocuments Documents => _documents ?? (_documents = new LoanDocuments(Client, LoanId));

        public LoanAttachments Attachments => _attachments ?? (_attachments = new LoanAttachments(Client, LoanId));

        public LoanCustomDataObjects CustomDataObjects => _customDataObjects ?? (_customDataObjects = new LoanCustomDataObjects(Client, LoanId));

        public LoanAssociates Associates => _associates ?? (_associates = new LoanAssociates(Client, LoanId));

        public LoanMilestones Milestones => _milestones ?? (_milestones = new LoanMilestones(Client, LoanId));

        public LoanMilestoneFreeRoles MilestoneFreeRoles => _milestoneFreeRoles ?? (_milestoneFreeRoles = new LoanMilestoneFreeRoles(Client, LoanId));

        public BorrowerPairs BorrowerPairs => _borrowerPairs ?? (_borrowerPairs = CreateBorrowerPairs());

        internal virtual BorrowerPairs CreateBorrowerPairs() => new BorrowerPairs(Client, LoanId);

        internal LoanApis(EncompassRestClient client, string loanId)
            : base(client, loanId, null)
        {
        }

        public Task<LoanMetadata> GetMetadataAsync(CancellationToken cancellationToken = default) => GetAsync<LoanMetadata>("metadata", null, nameof(GetMetadataAsync), null, cancellationToken);

        public Task<string> GetMetadataRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("metadata", queryString, nameof(GetMetadataAsync), null, cancellationToken);

        public Task<List<ResourceLock>> GetLocksAsync(CancellationToken cancellationToken = default) => Client.ResourceLocks.GetResourceLocksAsync(LoanId, EntityType.Loan, cancellationToken);

        public Task<ResourceLock> GetLockAsync(string lockId, CancellationToken cancellationToken = default) => Client.ResourceLocks.GetResourceLockAsync(lockId, LoanId, EntityType.Loan, cancellationToken);

        public Task<string> LockAsync(ResourceLockType lockType, CancellationToken cancellationToken = default) => LockAsync(lockType, false, cancellationToken);

        public Task<string> LockAsync(ResourceLockType lockType, bool force, CancellationToken cancellationToken = default) => LockAsync(lockType.AsString(), force, cancellationToken);

        public Task<string> LockAsync(string lockType, CancellationToken cancellationToken = default) => LockAsync(lockType, false, cancellationToken);

        public Task<string> LockAsync(string lockType, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.LockResourceAsync(lockType, LoanId, EntityType.Loan, force, cancellationToken);

        public Task<bool> UnlockAsync(string lockId, CancellationToken cancellationToken = default) => UnlockAsync(lockId, false, cancellationToken);

        public Task<bool> UnlockAsync(string lockId, bool force, CancellationToken cancellationToken = default) => Client.ResourceLocks.UnlockResourceAsync(lockId, LoanId, EntityType.Loan, force, cancellationToken);
    }
}