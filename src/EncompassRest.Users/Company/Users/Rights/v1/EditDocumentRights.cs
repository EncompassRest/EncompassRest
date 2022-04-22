using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EditDocumentRights
    /// </summary>
    public sealed class EditDocumentRights : ParentAccessRights
    {
        /// <summary>
        /// EditDocumentRights AddComment
        /// </summary>
        public bool? AddComment { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights AddNotesToFile
        /// </summary>
        [AllowNull]
        public AddNotesToFileRights AddNotesToFile { get => GetEntity<AddNotesToFileRights>(); set => SetEntity(value); }

        /// <summary>
        /// EditDocumentRights AttachEncompassForms
        /// </summary>
        public bool? AttachEncompassForms { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights AttachUnassignedFiles
        /// </summary>
        public bool? AttachUnassignedFiles { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights BrowseAndAttach
        /// </summary>
        public bool? BrowseAndAttach { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights DeleteComment
        /// </summary>
        public bool? DeleteComment { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights EditDocumentDetails
        /// </summary>
        [AllowNull]
        public EditDocumentDetailsRights EditDocumentDetails { get => GetEntity<EditDocumentDetailsRights>(); set => SetEntity(value); }

        /// <summary>
        /// EditDocumentRights EditFile
        /// </summary>
        [AllowNull]
        public EditFileRights EditFile { get => GetEntity<EditFileRights>(); set => SetEntity(value); }

        /// <summary>
        /// EditDocumentRights MarkFileAsCurrentVersion
        /// </summary>
        public bool? MarkFileAsCurrentVersion { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights MarkStatusAsReviewed
        /// </summary>
        public bool? MarkStatusAsReviewed { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights MergeFiles
        /// </summary>
        public bool? MergeFiles { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights MoveFileUpDown
        /// </summary>
        [JsonProperty("moveFileUp/Down")]
        public bool? MoveFileUpDown { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights RemoveFilefromDocument
        /// </summary>
        public bool? RemoveFilefromDocument { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights ScanAndAttach
        /// </summary>
        public bool? ScanAndAttach { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EditDocumentRights SplitFile
        /// </summary>
        public bool? SplitFile { get => GetValue<bool?>(); set => SetValue(value); }
    }
}