using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// OrderClosingDocsRights
    /// </summary>
    public sealed class OrderClosingDocsRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addAdditionalDocs;
        private DirtyValue<bool?>? _deselectDocs;
        private DirtyValue<bool?>? _moveDocsUpDown;
        private DirtyValue<bool?>? _orderDocsEvenWithComplianceReviewFailures;

        /// <summary>
        /// OrderClosingDocsRights AddAdditionalDocs
        /// </summary>
        public bool? AddAdditionalDocs { get => _addAdditionalDocs; set => SetField(ref _addAdditionalDocs, value); }

        /// <summary>
        /// OrderClosingDocsRights DeselectDocs
        /// </summary>
        public bool? DeselectDocs { get => _deselectDocs; set => SetField(ref _deselectDocs, value); }

        /// <summary>
        /// OrderClosingDocsRights MoveDocsUpDown
        /// </summary>
        [JsonProperty("moveDocsUp/Down")]
        public bool? MoveDocsUpDown { get => _moveDocsUpDown; set => SetField(ref _moveDocsUpDown, value); }

        /// <summary>
        /// OrderClosingDocsRights OrderDocsEvenWithComplianceReviewFailures
        /// </summary>
        public bool? OrderDocsEvenWithComplianceReviewFailures { get => _orderDocsEvenWithComplianceReviewFailures; set => SetField(ref _orderDocsEvenWithComplianceReviewFailures, value); }
    }
}