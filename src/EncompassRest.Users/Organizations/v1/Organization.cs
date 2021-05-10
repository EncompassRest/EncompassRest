using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Company.v1;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Organization
    /// </summary>
    public sealed class Organization : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _name;
        private DirtyValue<string?>? _description;
        private OrganizationInformation? _orgInformation;
        private NmlsInformation? _nmls;
        private MersMinInformation? _mersMin;
        private LegalEntityIdentifierInformation? _legalEntityIdentifier;
        private ConsumerConnectLOSearchInformation? _consumerConnectLOSearch;
        private OnrpSettings? _onrpSettings;
        private DirtyValue<string?>? _emailSignature;
        private LicenseInformation? _license;
        private DirtyValue<EntityReference?>? _parentOrg;
        private DirtyList<OrganizationReference>? _children;
        private CompensationPlans? _compensationPlans;
        private ConsumerConnectSite? _ccSite;
        private NeverSerializeValue<int?>? _numberOfChildOrganizations;
        private NeverSerializeValue<int?>? _numberOfChildUsers;

        /// <summary>
        /// Unique Identifier of the organization.
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Name of the organization.
        /// </summary>
        public string? Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// Additional text describing the organization.
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Organization OrgInformation
        /// </summary>
        [AllowNull]
        public OrganizationInformation OrgInformation { get => GetField(ref _orgInformation); set => SetField(ref _orgInformation, value); }

        /// <summary>
        /// Object containing Nationwide Mortgage Licensing System (NMLS) information.
        /// </summary>
        [AllowNull]
        public NmlsInformation Nmls { get => GetField(ref _nmls); set => SetField(ref _nmls, value); }

        /// <summary>
        /// Object containing Mortgage Electronic Registration System (MERS) MIN information.
        /// </summary>
        [AllowNull]
        public MersMinInformation MersMin { get => GetField(ref _mersMin); set => SetField(ref _mersMin, value); }

        /// <summary>
        /// Object containing Legal Entity Identifier (LEI) information.
        /// </summary>
        [AllowNull]
        public LegalEntityIdentifierInformation LegalEntityIdentifier { get => GetField(ref _legalEntityIdentifier); set => SetField(ref _legalEntityIdentifier, value); }

        /// <summary>
        /// Object containing information about Encompass Consumer Connect Loan Officer Search settings.
        /// </summary>
        /// <remarks>
        /// This applies if an Encompass Consumer Connect website is associated with the organization. If a website is associated with the organization, the organization will be listed in the website's search results for loan officers.
        /// </remarks>
        [AllowNull]
        public ConsumerConnectLOSearchInformation ConsumerConnectLOSearch { get => GetField(ref _consumerConnectLOSearch); set => SetField(ref _consumerConnectLOSearch, value); }

        /// <summary>
        /// Object containing information about the Overnight Rate Protection (ONRP) settings.
        /// </summary>
        [AllowNull]
        public OnrpSettings OnrpSettings { get => GetField(ref _onrpSettings); set => SetField(ref _onrpSettings, value); }

        /// <summary>
        /// The organization's email signature that displays in email notifications for Status Online Updates.
        /// </summary>
        /// <remarks>
        /// The signature is added to an email when content is populated from a template with a signature field. However, if a signature is configured in the My Profile setting in the Personal Settings, the personal signature will be used instead.
        /// </remarks>
        public string? EmailSignature { get => _emailSignature; set => SetField(ref _emailSignature, value); }

        /// <summary>
        /// Object containing licensing information for the organization.
        /// </summary>
        /// <remarks>
        /// This licensing information is used when running compliance testing on a loan file.
        /// </remarks>
        [AllowNull]
        public LicenseInformation License { get => GetField(ref _license); set => SetField(ref _license, value); }

        /// <summary>
        /// Object containing information about the parent organization.
        /// </summary>
        public EntityReference? ParentOrg { get => _parentOrg; set => SetField(ref _parentOrg, value); }

        /// <summary>
        /// Objects containing information about the child branches and users of the organization.
        /// </summary>
        [AllowNull]
        public IList<OrganizationReference> Children { get => GetField(ref _children); set => SetField(ref _children, value); }

        /// <summary>
        /// Object containing information about the organization's compensation plans.
        /// </summary>
        [AllowNull]
        public CompensationPlans CompensationPlans { get => GetField(ref _compensationPlans); set => SetField(ref _compensationPlans, value); }

        /// <summary>
        /// Object containing information about the associated Encompass Consumer Connect website.
        /// </summary>
        [AllowNull]
        public ConsumerConnectSite CcSite { get => GetField(ref _ccSite); set => SetField(ref _ccSite, value); }

        /// <summary>
        /// Number of child organizations associated with this organization.
        /// </summary>
        public int? NumberOfChildOrganizations { get => _numberOfChildOrganizations; set => SetField(ref _numberOfChildOrganizations, value); }

        /// <summary>
        /// Number of users associated with this organization.
        /// </summary>
        public int? NumberOfChildUsers { get => _numberOfChildUsers; set => SetField(ref _numberOfChildUsers, value); }
    }
}