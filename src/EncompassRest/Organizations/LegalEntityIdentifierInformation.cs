namespace EncompassRest.Organizations
{
    public sealed class LegalEntityIdentifierInformation : ParentInformation
    {
        private DirtyValue<EntityReference> _hmdaProfile;
        private DirtyValue<string> _lei;

        public EntityReference HmdaProfile { get => _hmdaProfile; set => SetField(ref _hmdaProfile, value); }

        public string Lei { get => _lei; set => SetField(ref _lei, value); }
    }
}