using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Company.v1;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.v1
{
    /// <summary>
    /// User
    /// </summary>
    public sealed class User : DirtyExtensibleObject, IIdentifiable
    {
        private UserApis? _userApis;

        /// <summary>
        /// User ID belonging to a user in the organization.
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The user's last name.
        /// </summary>
        public string? LastName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The user's first name.
        /// </summary>
        public string? FirstName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The user's full name.
        /// </summary>
        public string? FullName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The user's email address. The address is displayed in areas such as Conversation Log entries and file contact lists.
        /// </summary>
        public string? Email { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The user's phone number. The number is displayed in areas such as Conversation Log entries and file contact lists.
        /// </summary>
        public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The user's cell phone number.
        /// </summary>
        public string? CellPhone { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The user's fax number, if applicable.
        /// </summary>
        public string? Fax { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The Employee ID Number is intended for use with the Commissions360 product, which can import the field data from Encompass and pass the employee ID number to third-party payroll systems to streamline payments to Encompass users via the Commissions360 system.
        /// </summary>
        public string? EmployeeId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates if the user is an API User.
        /// </summary>
        public bool? ApiUser { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// The assigned oAuth Client ID of the user, if the user is defined as an API User.
        /// </summary>
        public string? OAuthClientId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The default folder for the user's loans.
        /// </summary>
        public string? WorkingFolder { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// EntityReference containing organization details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public EntityReference? Organization { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates type of access that the user has to all loans in the organization hierarchy below their level.
        /// </summary>
        public StringEnumValue<SubordinateLoanAccess> SubordinateLoanAccess { get => GetValue<StringEnumValue<SubordinateLoanAccess>>(); set => SetValue(value); }

        /// <summary>
        /// Includes list of indicators that are set to <c>true</c>.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [AllowNull]
        public IList<string> UserIndicators { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// Indicates whether the user has access to edit loans in the same level of the organization hierarchy.
        /// </summary>
        public StringEnumValue<PeerLoanAccess> PeerLoanAccess { get => GetValue<StringEnumValue<PeerLoanAccess>>(); set => SetValue(value); }

        /// <summary>
        /// The date and time the user last logged into Encompass.
        /// </summary>
        public DateTime? LastLogin { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The version number of Encompass the user is using.
        /// </summary>
        public string? EncompassVersion { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The number assigned to the user for the HUD Computerized Homes Underwriting Management System (CHUMS).
        /// </summary>
        public string? ChumId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The number assigned to the user by the Nationwide Mortgage Licensing System (NMLS).
        /// </summary>
        public string? NmlsOriginatorId { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// The expiration date of the user's NMLS license.
        /// </summary>
        public DateTime? NmlsExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

        /// <summary>
        /// The user's signature inserted into the email templates used for the Status Online feature.
        /// </summary>
        public string? EmailSignature { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the user is authorized to use the Status Online feature. If so, a Status Online update is triggered when the user exits a loan after making changes that match the criteria set configured in the status online templates.
        /// </summary>
        public bool? PersonalStatusOnline { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Comments added to the user's profile.
        /// </summary>
        public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// EntityReferences containing the user's persona information. The persona controls the views and features available to the user.
        /// </summary>
        [AllowNull]
        public IList<EntityReference> Personas { get => GetList<EntityReference>(); set => SetList(value); }

        /// <summary>
        /// Object containing information about the user's Encompass Consumer Connect site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConsumerConnectSite? CcSite { get => GetValue<ConsumerConnectSite?>(); set => SetValue(value); }

        /// <summary>
        /// User Title
        /// </summary>
        public string? Title { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// User UserApis
        /// </summary>
        [JsonIgnore]
        public IUserApis UserApis => _userApis ?? throw new InvalidOperationException("User object must be initialized to use UserApis");

        /// <summary>
        /// User Client
        /// </summary>
        [JsonIgnore]
        public EncompassRestClient? Client { get; internal set; }

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
                SetPropertyDirty(nameof(Id), false);
                _userApis = new UserApis(client, userId);
            }
        }
    }
}