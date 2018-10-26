using System;
using System.Collections.Generic;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users
{
    /// <summary>
    /// User
    /// </summary>
    public sealed class User : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private DirtyValue<string> _lastName;
        private DirtyValue<string> _firstName;
        private NeverSerializeValue<string> _fullName;
        private DirtyValue<string> _email;
        private DirtyValue<string> _phone;
        private DirtyValue<string> _cellPhone;
        private DirtyValue<string> _fax;
        private DirtyValue<string> _employeeId;
        private DirtyValue<bool?> _apiUser;
        private DirtyValue<string> _oAuthClientId;
        private DirtyValue<string> _workingFolder;
        private EntityReference _organization;
        private DirtyValue<StringEnumValue<SubordinateLoanAccess>> _subordinateLoanAccess;
        private DirtyList<string> _userIndicators;
        private DirtyValue<StringEnumValue<PeerLoanAccess>> _peerLoanAccess;
        private NeverSerializeValue<DateTime?> _lastLogin;
        private DirtyValue<string> _encompassVersion;
        private DirtyValue<string> _chumId;
        private DirtyValue<string> _nmlsOriginatorId;
        private DirtyValue<DateTime?> _nmlsExpirationDate;
        private DirtyValue<string> _emailSignature;
        private NeverSerializeValue<bool?> _personalStatusOnline;
        private DirtyValue<string> _comments;
        private DirtyList<EntityReference> _personas;
        private ConsumerConnectSite _ccSite;
        private UserApis _userApis;

        /// <summary>
        /// User Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// User LastName
        /// </summary>
        public string LastName { get => _lastName; set => SetField(ref _lastName, value); }

        /// <summary>
        /// User FirstName
        /// </summary>
        public string FirstName { get => _firstName; set => SetField(ref _firstName, value); }

        /// <summary>
        /// User FullName
        /// </summary>
        public string FullName { get => _fullName; set => SetField(ref _fullName, value); }

        /// <summary>
        /// User Email
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// User Phone
        /// </summary>
        public string Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// User CellPhone
        /// </summary>
        public string CellPhone { get => _cellPhone; set => SetField(ref _cellPhone, value); }

        /// <summary>
        /// User Fax
        /// </summary>
        public string Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// User EmployeeId
        /// </summary>
        public string EmployeeId { get => _employeeId; set => SetField(ref _employeeId, value); }

        /// <summary>
        /// User ApiUser
        /// </summary>
        public bool? ApiUser { get => _apiUser; set => SetField(ref _apiUser, value); }

        /// <summary>
        /// User OAuthClientId
        /// </summary>
        public string OAuthClientId { get => _oAuthClientId; set => SetField(ref _oAuthClientId, value); }

        /// <summary>
        /// User WorkingFolder
        /// </summary>
        public string WorkingFolder { get => _workingFolder; set => SetField(ref _workingFolder, value); }

        /// <summary>
        /// User Organization
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference Organization { get => _organization; set => SetField(ref _organization, value); }

        /// <summary>
        /// User SubordinateLoanAccess
        /// </summary>
        public StringEnumValue<SubordinateLoanAccess> SubordinateLoanAccess { get => _subordinateLoanAccess; set => SetField(ref _subordinateLoanAccess, value); }

        /// <summary>
        /// User UserIndicators
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> UserIndicators { get => GetField(ref _userIndicators); set => SetField(ref _userIndicators, value); }

        /// <summary>
        /// User PeerLoanAccess
        /// </summary>
        public StringEnumValue<PeerLoanAccess> PeerLoanAccess { get => _peerLoanAccess; set => SetField(ref _peerLoanAccess, value); }

        /// <summary>
        /// User LastLogin
        /// </summary>
        public DateTime? LastLogin { get => _lastLogin; set => SetField(ref _lastLogin, value); }

        /// <summary>
        /// User EncompassVersion
        /// </summary>
        public string EncompassVersion { get => _encompassVersion; set => SetField(ref _encompassVersion, value); }

        /// <summary>
        /// User ChumId
        /// </summary>
        public string ChumId { get => _chumId; set => SetField(ref _chumId, value); }

        /// <summary>
        /// User NmlsOriginatorId
        /// </summary>
        public string NmlsOriginatorId { get => _nmlsOriginatorId; set => SetField(ref _nmlsOriginatorId, value); }

        /// <summary>
        /// User NmlsExpirationDate
        /// </summary>
        public DateTime? NmlsExpirationDate { get => _nmlsExpirationDate; set => SetField(ref _nmlsExpirationDate, value); }

        /// <summary>
        /// User EmailSignature
        /// </summary>
        public string EmailSignature { get => _emailSignature; set => SetField(ref _emailSignature, value); }

        /// <summary>
        /// User PersonalStatusOnline
        /// </summary>
        public bool? PersonalStatusOnline { get => _personalStatusOnline; set => SetField(ref _personalStatusOnline, value); }

        /// <summary>
        /// User Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// User Personas
        /// </summary>
        public IList<EntityReference> Personas { get => GetField(ref _personas); set => SetField(ref _personas, value); }

        /// <summary>
        /// User CcSite
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConsumerConnectSite CcSite { get => _ccSite; set => SetField(ref _ccSite, value); }

        /// <summary>
        /// User UserApis
        /// </summary>
        [JsonIgnore]
        public UserApis UserApis => _userApis ?? throw new InvalidOperationException("User object must be initialized to use UserApis");

        /// <summary>
        /// User Client
        /// </summary>
        [JsonIgnore]
        public EncompassRestClient Client { get; internal set; }

        /// <summary>
        /// User update constructor.
        /// </summary>
        /// <param name="client">The client to initialize the object.</param>
        /// <param name="userId">The user's id.</param>
        public User(EncompassRestClient client, string userId)
        {
            Initialize(client, userId);
        }

        /// <summary>
        /// User creation constructor.
        /// </summary>
        [JsonConstructor]
        public User()
        {
        }

        /// <summary>
        /// Initializes the user object with a client and user id so that you can use <see cref="UserApis"/>.
        /// </summary>
        /// <param name="client">The client to initialize the object.</param>
        /// <param name="userId">The user's id.</param>
        public void Initialize(EncompassRestClient client, string userId)
        {
            Preconditions.NotNull(client, nameof(client));
            Preconditions.NotNullOrEmpty(userId, nameof(userId));

            if (!string.IsNullOrEmpty(Id) && !string.Equals(Id, userId, StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException("Cannot initialize with different userId");
            }

            if (!ReferenceEquals(Client, client) || _userApis == null)
            {
                Client = client;
                Id = userId;
                _id.Dirty = false;
                _userApis = new UserApis(client, userId);
            }
        }
    }
}