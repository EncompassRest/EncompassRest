using EncompassRest.Company;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// Object containing Legal Entity Identifier (LEI) information.
    /// </summary>
    public sealed class LegalEntityIdentifierInformation : ParentInformation
    {
        private EntityReference _hmdaProfile;
        private DirtyValue<string> _lei;

        /// <summary>
        /// The LEI associated with the organization.
        /// </summary>
        public EntityReference HmdaProfile { get => GetField(ref _hmdaProfile); set => SetField(ref _hmdaProfile, value); }

        /// <summary>
        /// The LEI code that is associated with the organization's HMDA profile.
        /// </summary>
        public string Lei { get => _lei; set => SetField(ref _lei, value); }
    }
}