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
        /// <summary>
        /// Unique Identifier of the organization.
        /// </summary>
        public string? Id { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Name of the organization.
        /// </summary>
        public string? Name { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Additional text describing the organization.
        /// </summary>
        public string? Description { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Organization OrgInformation
        /// </summary>
        [AllowNull]
        public OrganizationInformation OrgInformation { get => GetEntity<OrganizationInformation>(); set => SetEntity(value); }

        /// <summary>
        /// Object containing Nationwide Mortgage Licensing System (NMLS) information.
        /// </summary>
        [AllowNull]
        public NmlsInformation Nmls { get => GetEntity<NmlsInformation>(); set => SetEntity(value); }

        /// <summary>
        /// Object containing Mortgage Electronic Registration System (MERS) MIN information.
        /// </summary>
        [AllowNull]
        public MersMinInformation MersMin { get => GetEntity<MersMinInformation>(); set => SetEntity(value); }

        /// <summary>
        /// Object containing Legal Entity Identifier (LEI) information.
        /// </summary>
        [AllowNull]
        public LegalEntityIdentifierInformation LegalEntityIdentifier { get => GetEntity<LegalEntityIdentifierInformation>(); set => SetEntity(value); }

        /// <summary>
        /// Object containing information about Encompass Consumer Connect Loan Officer Search settings.
        /// </summary>
        /// <remarks>
        /// This applies if an Encompass Consumer Connect website is associated with the organization. If a website is associated with the organization, the organization will be listed in the website's search results for loan officers.
        /// </remarks>
        [AllowNull]
        public ConsumerConnectLOSearchInformation ConsumerConnectLOSearch { get => GetEntity<ConsumerConnectLOSearchInformation>(); set => SetEntity(value); }

        /// <summary>
        /// Object containing information about the Overnight Rate Protection (ONRP) settings.
        /// </summary>
        [AllowNull]
        public OnrpSettings OnrpSettings { get => GetEntity<OnrpSettings>(); set => SetEntity(value); }

        /// <summary>
        /// The organization's email signature that displays in email notifications for Status Online Updates.
        /// </summary>
        /// <remarks>
        /// The signature is added to an email when content is populated from a template with a signature field. However, if a signature is configured in the My Profile setting in the Personal Settings, the personal signature will be used instead.
        /// </remarks>
        public string? EmailSignature { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Object containing licensing information for the organization.
        /// </summary>
        /// <remarks>
        /// This licensing information is used when running compliance testing on a loan file.
        /// </remarks>
        [AllowNull]
        public LicenseInformation License { get => GetEntity<LicenseInformation>(); set => SetEntity(value); }

        /// <summary>
        /// Object containing information about the parent organization.
        /// </summary>
        public EntityReference? ParentOrg { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// Objects containing information about the child branches and users of the organization.
        /// </summary>
        [AllowNull]
        public IList<OrganizationReference> Children { get => GetList<OrganizationReference>(); set => SetList(value); }

        /// <summary>
        /// Object containing information about the organization's compensation plans.
        /// </summary>
        [AllowNull]
        public CompensationPlans CompensationPlans { get => GetEntity<CompensationPlans>(); set => SetEntity(value); }

        /// <summary>
        /// Object containing information about the associated Encompass Consumer Connect website.
        /// </summary>
        [AllowNull]
        public ConsumerConnectSite CcSite { get => GetEntity<ConsumerConnectSite>(); set => SetEntity(value); }

        /// <summary>
        /// Number of child organizations associated with this organization.
        /// </summary>
        public int? NumberOfChildOrganizations { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// Number of users associated with this organization.
        /// </summary>
        public int? NumberOfChildUsers { get => GetValue<int?>(); set => SetValue(value); }
    }
}