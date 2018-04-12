using System.Linq;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public partial class Loan
    {
        private LoanFields _fields;

        [JsonIgnore]
        public EncompassRestClient Client { get; private set; }

        [JsonIgnore]
        public LoanDocuments Documents { get; private set; }

        [JsonIgnore]
        public LoanAttachments Attachments { get; private set; }

        [JsonIgnore]
        public LoanCustomDataObjects CustomDataObjects { get; private set; }

        [JsonIgnore]
        public LoanObjectBoundApis LoanApis { get; private set; }

        [JsonIgnore]
        public LoanFields Fields => _fields ?? (_fields = new LoanFields(this));

        [IdPropertyName(nameof(EncompassId))]
        string IIdentifiable.Id { get => EncompassId ?? Id; set { EncompassId = value; Id = value; } }

        private DirtyValue<int?> _currentApplicationIndex;
        public int? CurrentApplicationIndex
        {
            get => _currentApplicationIndex;
            set
            {
                _currentApplicationIndex = value;
                _currentApplication = null;
            }
        }

        private Application _currentApplication;
        [JsonIgnore]
        public Application CurrentApplication
        {
            get
            {
                var currentApplication = _currentApplication;
                if (currentApplication == null)
                {
                    var applicationIndex = CurrentApplicationIndex ?? 0;
                    CurrentApplicationIndex = applicationIndex;
                    currentApplication = Applications.FirstOrDefault(a => a.ApplicationIndex == applicationIndex);
                    if (currentApplication == null)
                    {
                        currentApplication = new Application { ApplicationIndex = applicationIndex };
                        Applications.Add(currentApplication);
                    }
                    _currentApplication = currentApplication;
                }
                return currentApplication;
            }
            set
            {
                _currentApplication = value;
                if (value != null)
                {
                    if (!value.ApplicationIndex.HasValue)
                    {
                        value.ApplicationIndex = CurrentApplicationIndex ?? 0;
                    }
                    CurrentApplicationIndex = value.ApplicationIndex;
                }
            }
        }

        /// <summary>
        /// Loan update constructor
        /// </summary>
        /// <param name="client"></param>
        /// <param name="loanId"></param>
        public Loan(EncompassRestClient client, string loanId)
        {
            Initialize(client, loanId);
        }

        /// <summary>
        /// Loan creation constructor
        /// </summary>
        [JsonConstructor]
        public Loan()
        {
        }

        public void Initialize(EncompassRestClient client, string loanId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            if (!ReferenceEquals(Client, client))
            {
                Client = client;
                EncompassId = loanId;
                Documents = new LoanDocuments(client, EncompassId);
                Attachments = new LoanAttachments(client, EncompassId);
                CustomDataObjects = new LoanCustomDataObjects(client, EncompassId);
                LoanApis = new LoanObjectBoundApis(client, this);
            }
        }

        internal override bool CustomDirty
        {
            get
            {
                return _currentApplicationIndex.Dirty;
            }
            set
            {
                _currentApplicationIndex.Dirty = value;
            }
        }
    }
}