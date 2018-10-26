using System.Collections.Generic;

namespace EncompassRest.Organizations
{
    public sealed class Organization : DirtyExtensibleObject, IIdentifiable
    {
        private ConsumerConnectSite _ccSite;
        private DirtyList<OrganizationReference> _children;
        private CompensationPlansInformation _compensationPlans;
        private ConsumerConnectLOSearchInformation _consumerConnectLOSearch;
        private DirtyValue<string> _description;
        private DirtyValue<string> _emailSignature;
        private DirtyValue<string> _id;
        private LegalEntityIdentifierInformation _legalEntityIdentifier;
        private LicenseInformation _license;
        private MersMinInformation _mersMin;
        private DirtyValue<string> _name;
        private NmlsInformation _nmls;
        private NeverSerializeValue<int?> _numberOfChildOrganizations;
        private NeverSerializeValue<int?> _numberOfChildUsers;
        private OnrpSettings _onrpSettings;
        private OrganizationInformation _orgInformation;
        private DirtyValue<EntityReference> _parentOrg;

        public IList<OrganizationReference> Children { get => GetField(ref _children); set => SetField(ref _children, value); }

        public ConsumerConnectSite CcSite { get => GetField(ref _ccSite); set => SetField(ref _ccSite, value); }

        public CompensationPlansInformation CompensationPlans { get => GetField(ref _compensationPlans); set => SetField(ref _compensationPlans, value); }

        public ConsumerConnectLOSearchInformation ConsumerConnectLOSearch { get => GetField(ref _consumerConnectLOSearch); set => SetField(ref _consumerConnectLOSearch, value); }

        public string Description { get => _description; set => SetField(ref _description, value); }

        public string EmailSignature { get => _emailSignature; set => SetField(ref _emailSignature, value); }

        public string Id { get => _id; set => SetField(ref _id, value); }

        public LegalEntityIdentifierInformation LegalEntityIdentifier { get => GetField(ref _legalEntityIdentifier); set => SetField(ref _legalEntityIdentifier, value); }

        public LicenseInformation License { get => GetField(ref _license); set => SetField(ref _license, value); }

        public MersMinInformation MersMin { get => GetField(ref _mersMin); set => SetField(ref _mersMin, value); }

        public string Name { get => _name; set => SetField(ref _name, value); }

        public NmlsInformation Nmls { get => GetField(ref _nmls); set => SetField(ref _nmls, value); }

        public int? NumberOfChildOrganizations { get => _numberOfChildOrganizations; set => SetField(ref _numberOfChildOrganizations, value); }

        public int? NumberOfChildUsers { get => _numberOfChildUsers; set => SetField(ref _numberOfChildUsers, value); }

        public OnrpSettings OnrpSettings { get => _onrpSettings; set => SetField(ref _onrpSettings, value); }

        public OrganizationInformation OrgInformation { get => GetField(ref _orgInformation); set => SetField(ref _orgInformation, value); }

        public EntityReference ParentOrg { get => _parentOrg; set => SetField(ref _parentOrg, value); }
    }
}