using System;
using System.Collections.Generic;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [Entity(PropertiesToAlwaysSerialize = nameof(EncompassId) + "," + nameof(CurrentApplicationIndex))]
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

        private DirtyDictionary<string, string> _virtualFields;
        public IDictionary<string, string> VirtualFields { get => _virtualFields ?? (_virtualFields = new DirtyDictionary<string, string>(StringComparer.OrdinalIgnoreCase)); set => _virtualFields = new DirtyDictionary<string, string>(value, StringComparer.OrdinalIgnoreCase); }

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
    }
}