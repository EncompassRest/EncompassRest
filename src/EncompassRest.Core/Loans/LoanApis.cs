using EncompassRest.Loans.Apis;
using EncompassRest.Loans.Associates;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Conditions;
using EncompassRest.Loans.Documents;
using EncompassRest.Loans.FieldReader;
using EncompassRest.Loans.MilestoneFreeRoles;
using EncompassRest.Loans.Milestones;
using EncompassRest.Loans.RateLocks;

namespace EncompassRest.Loans
{
    /// <summary>
    /// The Loan Apis exposed as extension methods from the EncompassRest.Loans.v1 package
    /// within the EncompassRest.Loans.v1 namespace.
    /// </summary>
    public interface ILoanApis : ILoanApiObject
    {
        /// <summary>
        /// The Loan Associates Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Loans.Associates.v1 namespace.
        /// </summary>
        ILoanAssociates Associates { get; }
        /// <summary>
        /// The Loan Attachments Apis exposed as extension methods from the EncompassRest.EFolder package
        /// within the EncompassRest.Loans.Attachments.v1 namespace.
        /// </summary>
        ILoanAttachments Attachments { get; }
        /// <summary>
        /// The Loan Borrower Pairs Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Loans.Apis.v1 namespace.
        /// </summary>
        IBorrowerPairs BorrowerPairs { get; }
        /// <summary>
        /// The Loan Conditions Apis.
        /// </summary>
        ILoanConditions Conditions { get; }
        /// <summary>
        /// The Loan Custom Data Objects Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Loans.v1 namespace.
        /// </summary>
        ILoanCustomDataObjects CustomDataObjects { get; }
        /// <summary>
        /// The Loan Documents Apis exposed as extension methods from the EncompassRest.EFolder package
        /// within the EncompassRest.Loans.Documents.v1 namespace.
        /// </summary>
        ILoanDocuments Documents { get; }
        /// <summary>
        /// The Loan Field Reader Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Loans.FieldReader.v1 namespace.
        /// </summary>
        ILoanFieldReader FieldReader { get; }
        /// <summary>
        /// The Loan Milestone Free Roles Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Loans.MilestoneFreeRoles.v1 namespace.
        /// </summary>
        ILoanMilestoneFreeRoles MilestoneFreeRoles { get; }
        /// <summary>
        /// The Loan Milestones Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Loans.Milestones.v1 namespace.
        /// </summary>
        ILoanMilestones Milestones { get; }
        /// <summary>
        /// The Loan Rate Lock Apis exposed as extension methods from the EncompassRest.Loans.v1 package
        /// within the EncompassRest.Loans.RateLocks.v1 namespace.
        /// </summary>
        ILoanRateLocks RateLocks { get; }
    }

    internal class LoanApis : LoanApiObject, ILoanApis
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

        public ILoanDocuments Documents => _documents ??= new LoanDocuments(Client, this, LoanId);

        public ILoanAttachments Attachments => _attachments ??= new LoanAttachments(Client, this, LoanId);

        public ILoanCustomDataObjects CustomDataObjects => _customDataObjects ??= new LoanCustomDataObjects(Client, this, LoanId);

        public ILoanAssociates Associates => _associates ??= new LoanAssociates(Client, this, LoanId);

        public ILoanMilestones Milestones => _milestones ??= new LoanMilestones(Client, this, LoanId);

        public ILoanMilestoneFreeRoles MilestoneFreeRoles => _milestoneFreeRoles ??= new LoanMilestoneFreeRoles(Client, this, LoanId);

        public ILoanFieldReader FieldReader => _fieldReader ??= new LoanFieldReader(Client, this, LoanId);

        public ILoanConditions Conditions => _conditions ??= new LoanConditions(Client, this, LoanId);

        public ILoanRateLocks RateLocks => _rateLocks ??= new LoanRateLocks(Client, this, LoanId);

        public IBorrowerPairs BorrowerPairs => _borrowerPairs ??= new BorrowerPairs(Client, this, LoanId);

        internal LoanApis(EncompassRestClient client, string loanId)
            : base(client, null, loanId, null)
        {
        }
    }
}