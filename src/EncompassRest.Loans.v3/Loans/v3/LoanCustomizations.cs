using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Loans.v3
{
    partial class Loan : ILoan
    {
        /// <summary>
        /// Implicitly converts the specified loan to an <see cref="EntityReference"/>.
        /// </summary>
        /// <param name="loan">The loan to convert to an <see cref="EntityReference"/>.</param>
        public static implicit operator EntityReference?(Loan? loan) => loan != null && loan.Id != null ? new EntityReference(loan.Id, EntityType.Loan) : null;

        private LoanFields? _fields;
        private ILoanObjectBoundApis? _loanApis;

        /// <summary>
        /// The <see cref="IEncompassRestClient"/> associated with this object.
        /// </summary>
        [JsonIgnore]
        public IEncompassRestClient? Client { get; internal set; }

        /// <summary>
        /// The Loan Apis for this loan. Loan object must be initialized to use this.
        /// </summary>
        [JsonIgnore]
        public ILoanObjectBoundApis LoanApis => _loanApis ?? throw new InvalidOperationException("Loan object must be initialized to use LoanApis");

        ILoanApis ILoan.LoanApis => LoanApis;

        /// <summary>
        /// The loan fields collection.
        /// </summary>
        [JsonIgnore]
        public LoanFields Fields => _fields ??= new LoanFields(this);

        ILoanFields ILoan.Fields => Fields;

        private Application? _currentApplication;

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
                    if (Applications.Count <= applicationIndex)
                    {
                        for (var i = Applications.Count; i <= applicationIndex; ++i)
                        {
                            Applications.Add(new Application());
                        }
                    }
                    currentApplication = Applications[applicationIndex];
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
        public Loan(IEncompassRestClient client, string loanId)
        {
            Initialize(client, loanId);
        }

        /// <summary>
        /// The Loan creation constructor.
        /// </summary>
        /// <param name="client">The client to associate the object with.</param>
        public Loan(IEncompassRestClient client)
        {
            Preconditions.NotNull(client, nameof(client));

            Client = client;
        }

        /// <summary>
        /// The Loan deserialization constructor.
        /// </summary>
        [JsonConstructor]
        [Obsolete("Use IEncompassRestClient parameter constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Loan()
        {
        }

        /// <summary>
        /// Initializes the loan object with the specified <paramref name="client"/> and <paramref name="loanId"/>. This allows the use of the <see cref="LoanApis"/> property.
        /// </summary>
        /// <param name="client">The client to initialize the loan object with.</param>
        /// <param name="loanId">The loan id of the Encompass loan.</param>
        public void Initialize(IEncompassRestClient client, string loanId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            if (!string.IsNullOrEmpty(Id) && !string.Equals(Id, loanId, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("Cannot initialize with different loanId");
            }

            if (!ReferenceEquals(Client, client) || _loanApis == null)
            {
                Client = client;
                Id = loanId;
                _loanApis = client.Loans.GetLoanApis(this);
            }
        }

        internal override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case nameof(CurrentApplicationIndex):
                    _currentApplication = null;
                    break;
            }
        }
    }
}