using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EDisclosuresRights
    /// </summary>
    public sealed class EDisclosuresRights : ParentAccessRights
    {
        /// <summary>
        /// EDisclosuresRights AddAdditionalDocs
        /// </summary>
        public bool? AddAdditionalDocs { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EDisclosuresRights DeselectDocs
        /// </summary>
        public bool? DeselectDocs { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EDisclosuresRights MoveDocsUpDown
        /// </summary>
        [JsonProperty("moveDocsUp/Down")]
        public bool? MoveDocsUpDown { get => GetValue<bool?>(); set => SetValue(value); }
    }
}