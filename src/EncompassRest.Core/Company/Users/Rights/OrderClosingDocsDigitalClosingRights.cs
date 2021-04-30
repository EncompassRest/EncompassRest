using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// OrderClosingDocsDigitalClosingRights
    /// </summary>
    public sealed class OrderClosingDocsDigitalClosingRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _addAdditionalDocsDigitalClosing;
        private DirtyValue<bool?>? _deselectDocsDigitalClosing;
        private DirtyValue<bool?>? _moveDocsUpDownDigitalClosing;
        private DirtyValue<bool?>? _orderDocsEvenWithComplianceReviewFailuresDigitalClosing;

        /// <summary>
        /// OrderClosingDocsDigitalClosingRights AddAdditionalDocsDigitalClosing
        /// </summary>
        public bool? AddAdditionalDocsDigitalClosing { get => _addAdditionalDocsDigitalClosing; set => SetField(ref _addAdditionalDocsDigitalClosing, value); }

        /// <summary>
        /// OrderClosingDocsDigitalClosingRights DeselectDocsDigitalClosing
        /// </summary>
        public bool? DeselectDocsDigitalClosing { get => _deselectDocsDigitalClosing; set => SetField(ref _deselectDocsDigitalClosing, value); }

        /// <summary>
        /// OrderClosingDocsDigitalClosingRights MoveDocsUpDownDigitalClosing
        /// </summary>
        [JsonProperty("moveDocsUp/DownDigitalClosing")]
        public bool? MoveDocsUpDownDigitalClosing { get => _moveDocsUpDownDigitalClosing; set => SetField(ref _moveDocsUpDownDigitalClosing, value); }

        /// <summary>
        /// OrderClosingDocsDigitalClosingRights OrderDocsEvenWithComplianceReviewFailuresDigitalClosing
        /// </summary>
        public bool? OrderDocsEvenWithComplianceReviewFailuresDigitalClosing { get => _orderDocsEvenWithComplianceReviewFailuresDigitalClosing; set => SetField(ref _orderDocsEvenWithComplianceReviewFailuresDigitalClosing, value); }
    }
}