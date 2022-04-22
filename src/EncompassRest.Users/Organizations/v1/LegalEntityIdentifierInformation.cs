using EncompassRest.Company.v1;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Object containing Legal Entity Identifier (LEI) information.
    /// </summary>
    public sealed class LegalEntityIdentifierInformation : ParentInformation
    {
        /// <summary>
        /// The LEI associated with the organization.
        /// </summary>
        public EntityReference? HmdaProfile { get => GetValue<EntityReference?>(); set => SetValue(value); }

        /// <summary>
        /// The LEI code that is associated with the organization's HMDA profile.
        /// </summary>
        public string? Lei { get => GetValue<string?>(); set => SetValue(value); }
    }
}