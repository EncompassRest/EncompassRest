using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OrderClosingDocsDigitalClosingRights
    /// </summary>
    public sealed class OrderClosingDocsDigitalClosingRights : DirtyExtensibleObject
    {
        /// <summary>
        /// OrderClosingDocsDigitalClosingRights AddAdditionalDocsDigitalClosing
        /// </summary>
        public bool? AddAdditionalDocsDigitalClosing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OrderClosingDocsDigitalClosingRights DeselectDocsDigitalClosing
        /// </summary>
        public bool? DeselectDocsDigitalClosing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OrderClosingDocsDigitalClosingRights MoveDocsUpDownDigitalClosing
        /// </summary>
        [JsonProperty("moveDocsUp/DownDigitalClosing")]
        public bool? MoveDocsUpDownDigitalClosing { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OrderClosingDocsDigitalClosingRights OrderDocsEvenWithComplianceReviewFailuresDigitalClosing
        /// </summary>
        public bool? OrderDocsEvenWithComplianceReviewFailuresDigitalClosing { get => GetValue<bool?>(); set => SetValue(value); }
    }
}