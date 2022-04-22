namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// VerificationAndDocumentationTrackingRights
    /// </summary>
    public sealed class VerificationAndDocumentationTrackingRights : ParentAccessRights
    {
        /// <summary>
        /// VerificationAndDocumentationTrackingRights CreateNewEntry
        /// </summary>
        public bool? CreateNewEntry { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// VerificationAndDocumentationTrackingRights EditEntry
        /// </summary>
        public bool? EditEntry { get => GetValue<bool?>(); set => SetValue(value); }
    }
}