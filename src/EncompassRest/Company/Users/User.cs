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
        private DirtyValue<string> _title;
        private UserApis _userApis;

        /// <summary>
        /// User ID belonging to a user in the organization.
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// The user's last name.
        /// </summary>
        public string LastName { get => _lastName; set => SetField(ref _lastName, value); }

        /// <summary>
        /// The user's first name.
        /// </summary>
        public string FirstName { get => _firstName; set => SetField(ref _firstName, value); }

        /// <summary>
        /// The user's full name.
        /// </summary>
        public string FullName { get => _fullName; set => SetField(ref _fullName, value); }

        /// <summary>
        /// The user's email address. The address is displayed in areas such as Conversation Log entries and file contact lists.
        /// </summary>
        public string Email { get => _email; set => SetField(ref _email, value); }

        /// <summary>
        /// The user's phone number. The number is displayed in areas such as Conversation Log entries and file contact lists.
        /// </summary>
        public string Phone { get => _phone; set => SetField(ref _phone, value); }

        /// <summary>
        /// The user's cell phone number.
        /// </summary>
        public string CellPhone { get => _cellPhone; set => SetField(ref _cellPhone, value); }

        /// <summary>
        /// The user's fax number, if applicable.
        /// </summary>
        public string Fax { get => _fax; set => SetField(ref _fax, value); }

        /// <summary>
        /// The Employee ID Number is intended for use with the Commissions360 product, which can import the field data from Encompass and pass the employee ID number to third-party payroll systems to streamline payments to Encompass users via the Commissions360 system.
        /// </summary>
        public string EmployeeId { get => _employeeId; set => SetField(ref _employeeId, value); }

        /// <summary>
        /// Indicates if the user is an API User.
        /// </summary>
        public bool? ApiUser { get => _apiUser; set => SetField(ref _apiUser, value); }

        /// <summary>
        /// The assigned oAuth Client ID of the user, if the user is defined as an API User.
        /// </summary>
        public string OAuthClientId { get => _oAuthClientId; set => SetField(ref _oAuthClientId, value); }

        /// <summary>
        /// The default folder for the user's loans.
        /// </summary>
        public string WorkingFolder { get => _workingFolder; set => SetField(ref _workingFolder, value); }

        /// <summary>
        /// EntityReference containing organization details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference Organization { get => _organization; set => SetField(ref _organization, value); }

        /// <summary>
        /// Indicates type of access that the user has to all loans in the organization hierarchy below their level.
        /// </summary>
        public StringEnumValue<SubordinateLoanAccess> SubordinateLoanAccess { get => _subordinateLoanAccess; set => SetField(ref _subordinateLoanAccess, value); }

        /// <summary>
        /// Includes list of indicators that are set to <c>true</c>.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> UserIndicators { get => GetField(ref _userIndicators); set => SetField(ref _userIndicators, value); }

        /// <summary>
        /// Indicates whether the user has access to edit loans in the same level of the organization hierarchy.
        /// </summary>
        public StringEnumValue<PeerLoanAccess> PeerLoanAccess { get => _peerLoanAccess; set => SetField(ref _peerLoanAccess, value); }

        /// <summary>
        /// The date and time the user last logged into Encompass.
        /// </summary>
        public DateTime? LastLogin { get => _lastLogin; set => SetField(ref _lastLogin, value); }

        /// <summary>
        /// The version number of Encompass the user is using.
        /// </summary>
        public string EncompassVersion { get => _encompassVersion; set => SetField(ref _encompassVersion, value); }

        /// <summary>
        /// The number assigned to the user for the HUD Computerized Homes Underwriting Management System (CHUMS).
        /// </summary>
        public string ChumId { get => _chumId; set => SetField(ref _chumId, value); }

        /// <summary>
        /// The number assigned to the user by the Nationwide Mortgage Licensing System (NMLS).
        /// </summary>
        public string NmlsOriginatorId { get => _nmlsOriginatorId; set => SetField(ref _nmlsOriginatorId, value); }

        /// <summary>
        /// The expiration date of the user's NMLS license.
        /// </summary>
        public DateTime? NmlsExpirationDate { get => _nmlsExpirationDate; set => SetField(ref _nmlsExpirationDate, value); }

        /// <summary>
        /// The user's signature inserted into the email templates used for the Status Online feature.
        /// </summary>
        public string EmailSignature { get => _emailSignature; set => SetField(ref _emailSignature, value); }

        /// <summary>
        /// Indicates whether the user is authorized to use the Status Online feature. If so, a Status Online update is triggered when the user exits a loan after making changes that match the criteria set configured in the status online templates.
        /// </summary>
        public bool? PersonalStatusOnline { get => _personalStatusOnline; set => SetField(ref _personalStatusOnline, value); }

        /// <summary>
        /// Comments added to the user's profile.
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// EntityReferences containing the user's persona information. The persona controls the views and features available to the user.
        /// </summary>
        public IList<EntityReference> Personas { get => GetField(ref _personas); set => SetField(ref _personas, value); }

        /// <summary>
        /// Object containing information about the user's Encompass Consumer Connect site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConsumerConnectSite CcSite { get => _ccSite; set => SetField(ref _ccSite, value); }

        /// <summary>
        /// User Title
        /// </summary>
        public string Title { get => _title; set => SetField(ref _title, value); }

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