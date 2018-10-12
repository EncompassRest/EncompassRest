using System;
using System.Collections.Generic;
using System.Linq;
using EncompassRest.Loans.Attachments;
using EncompassRest.Loans.Documents;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    partial class Loan
    {
        private LoanFields _fields;
        private LoanObjectBoundApis _loanApis;
        internal List<TransientLoanUpdate> TransientLoanUpdates;

        [JsonIgnore]
        public EncompassRestClient Client { get; internal set; }

        [JsonIgnore]
        [Obsolete("Use LoanApis.Documents instead.")]
        public LoanDocuments Documents => LoanApis.Documents;

        [JsonIgnore]
        [Obsolete("Use LoanApis.Attachments instead.")]
        public LoanAttachments Attachments => LoanApis.Attachments;

        [JsonIgnore]
        [Obsolete("Use LoanApis.CustomDataObjects instead.")]
        public LoanCustomDataObjects CustomDataObjects => LoanApis.CustomDataObjects;

        [JsonIgnore]
        public LoanObjectBoundApis LoanApis => _loanApis ?? throw new InvalidOperationException("Loan object must be initialized to use LoanApis");

        [JsonIgnore]
        public LoanFields Fields => _fields ?? (_fields = new LoanFields(this));

        [IdPropertyName(nameof(EncompassId))]
        string IIdentifiable.Id { get => EncompassId ?? Id; set { EncompassId = value; Id = value; } }

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
        /// <param name="client"></param>
        public Loan(EncompassRestClient client)
        {
            Preconditions.NotNull(client, nameof(client));

            Client = client;
        }

        /// <summary>
        /// Loan deserialization constructor
        /// </summary>
        [JsonConstructor]
        [Obsolete("Use EncompassRestClient parameter constructor instead.")]
        public Loan()
        {
        }

        public void Initialize(EncompassRestClient client, string loanId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            if (!string.IsNullOrEmpty(EncompassId) && !string.Equals(EncompassId, loanId, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("Cannot initialize with different loanId");
            }

            if (!ReferenceEquals(Client, client) || _loanApis == null)
            {
                Client = client;
                EncompassId = loanId;
                _encompassId.Dirty = false;
                _loanApis = new LoanObjectBoundApis(client, this);
            }
        }

        internal override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case nameof(CurrentApplicationIndex):
                    _currentApplication = null;
                    break;
            }
        }

        internal sealed class TransientLoanUpdate
        {
            public string Body { get; set; }

            public string QueryString { get; set; }
        }
    }
}