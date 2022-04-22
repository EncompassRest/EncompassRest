using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OrderClosingDocsRights
    /// </summary>
    public sealed class OrderClosingDocsRights : ParentAccessRights
    {
        /// <summary>
        /// OrderClosingDocsRights AddAdditionalDocs
        /// </summary>
        public bool? AddAdditionalDocs { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OrderClosingDocsRights DeselectDocs
        /// </summary>
        public bool? DeselectDocs { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OrderClosingDocsRights MoveDocsUpDown
        /// </summary>
        [JsonProperty("moveDocsUp/Down")]
        public bool? MoveDocsUpDown { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OrderClosingDocsRights OrderDocsEvenWithComplianceReviewFailures
        /// </summary>
        public bool? OrderDocsEvenWithComplianceReviewFailures { get => GetValue<bool?>(); set => SetValue(value); }
    }
}