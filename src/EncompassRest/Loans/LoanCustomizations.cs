using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        /// <summary>
        /// The <see cref="EncompassRestClient"/> associated with this object.
        /// </summary>
        [JsonIgnore]
        public EncompassRestClient Client { get; internal set; }

        [JsonIgnore]
        [Obsolete("Use Loan.LoanApis.Documents instead.")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public LoanDocuments Documents => LoanApis.Documents;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [JsonIgnore]
        [Obsolete("Use Loan.LoanApis.Attachments instead.")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public LoanAttachments Attachments => LoanApis.Attachments;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        [JsonIgnore]
        [Obsolete("Use Loan.LoanApis.CustomDataObjects instead.")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public LoanCustomDataObjects CustomDataObjects => LoanApis.CustomDataObjects;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        /// <summary>
        /// The Loan Apis for this loan. Loan object must be initialized to use this.
        /// </summary>
        [JsonIgnore]
        public LoanObjectBoundApis LoanApis => _loanApis ?? throw new InvalidOperationException("Loan object must be initialized to use LoanApis");

        /// <summary>
        /// The loan fields collection.
        /// </summary>
        [JsonIgnore]
        public LoanFields Fields => _fields ?? (_fields = new LoanFields(this));

        [IdPropertyName(nameof(EncompassId))]
        string IIdentifiable.Id { get => EncompassId ?? Id; set { EncompassId = value; Id = value; } }

        private Application _currentApplication;

        /// <summary>
        /// The current application/borrower pair.
        /// </summary>
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
        /// The Loan update constructor.
        /// </summary>
        /// <param name="client">The client to initialize the loan object with.</param>
        /// <param name="loanId">The loan id of the Encompass loan to update.</param>
        public Loan(EncompassRestClient client, string loanId)
        {
            Initialize(client, loanId);
        }

        /// <summary>
        /// The Loan creation constructor.
        /// </summary>
        /// <param name="client">The client to associate the object with.</param>
        public Loan(EncompassRestClient client)
        {
            Preconditions.NotNull(client, nameof(client));

            Client = client;
        }

        /// <summary>
        /// The Loan deserialization constructor.
        /// </summary>
        [JsonConstructor]
        [Obsolete("Use EncompassRestClient parameter constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Loan()
        {
        }

        /// <summary>
        /// Initializes the loan object with the specified <paramref name="client"/> and <paramref name="loanId"/>. This allows the use of the <see cref="LoanApis"/> property.
        /// </summary>
        /// <param name="client">The client to initialize the loan object with.</param>
        /// <param name="loanId">The loan id of the Encompass loan.</param>
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