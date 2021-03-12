using Newtonsoft.Json;

namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// EDisclosuresRights
    /// </summary>
    public sealed class EDisclosuresRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _addAdditionalDocs;
        private DirtyValue<bool?>? _deselectDocs;
        private DirtyValue<bool?>? _moveDocsUpDown;

        /// <summary>
        /// EDisclosuresRights AddAdditionalDocs
        /// </summary>
        public bool? AddAdditionalDocs { get => _addAdditionalDocs; set => SetField(ref _addAdditionalDocs, value); }

        /// <summary>
        /// EDisclosuresRights DeselectDocs
        /// </summary>
        public bool? DeselectDocs { get => _deselectDocs; set => SetField(ref _deselectDocs, value); }

        /// <summary>
        /// EDisclosuresRights MoveDocsUpDown
        /// </summary>
        [JsonProperty("moveDocsUp/Down")]
        public bool? MoveDocsUpDown { get => _moveDocsUpDown; set => SetField(ref _moveDocsUpDown, value); }
    }
}