using Newtonsoft.Json;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// EditDocumentRights
    /// </summary>
    public sealed class EditDocumentRights : ParentAccessRights
    {
        private DirtyValue<bool?> _addComment;
        private AddNotesToFileRights _addNotesToFile;
        private DirtyValue<bool?> _attachEncompassForms;
        private DirtyValue<bool?> _attachUnassignedFiles;
        private DirtyValue<bool?> _browseAndAttach;
        private DirtyValue<bool?> _deleteComment;
        private EditDocumentDetailsRights _editDocumentDetails;
        private EditFileRights _editFile;
        private DirtyValue<bool?> _markFileAsCurrentVersion;
        private DirtyValue<bool?> _markStatusAsReviewed;
        private DirtyValue<bool?> _mergeFiles;
        private DirtyValue<bool?> _moveFileUpDown;
        private DirtyValue<bool?> _removeFilefromDocument;
        private DirtyValue<bool?> _scanAndAttach;
        private DirtyValue<bool?> _splitFile;

        /// <summary>
        /// EditDocumentRights AddComment
        /// </summary>
        public bool? AddComment { get => _addComment; set => SetField(ref _addComment, value); }

        /// <summary>
        /// EditDocumentRights AddNotesToFile
        /// </summary>
        public AddNotesToFileRights AddNotesToFile { get => GetField(ref _addNotesToFile); set => SetField(ref _addNotesToFile, value); }

        /// <summary>
        /// EditDocumentRights AttachEncompassForms
        /// </summary>
        public bool? AttachEncompassForms { get => _attachEncompassForms; set => SetField(ref _attachEncompassForms, value); }

        /// <summary>
        /// EditDocumentRights AttachUnassignedFiles
        /// </summary>
        public bool? AttachUnassignedFiles { get => _attachUnassignedFiles; set => SetField(ref _attachUnassignedFiles, value); }

        /// <summary>
        /// EditDocumentRights BrowseAndAttach
        /// </summary>
        public bool? BrowseAndAttach { get => _browseAndAttach; set => SetField(ref _browseAndAttach, value); }

        /// <summary>
        /// EditDocumentRights DeleteComment
        /// </summary>
        public bool? DeleteComment { get => _deleteComment; set => SetField(ref _deleteComment, value); }

        /// <summary>
        /// EditDocumentRights EditDocumentDetails
        /// </summary>
        public EditDocumentDetailsRights EditDocumentDetails { get => GetField(ref _editDocumentDetails); set => SetField(ref _editDocumentDetails, value); }

        /// <summary>
        /// EditDocumentRights EditFile
        /// </summary>
        public EditFileRights EditFile { get => GetField(ref _editFile); set => SetField(ref _editFile, value); }

        /// <summary>
        /// EditDocumentRights MarkFileAsCurrentVersion
        /// </summary>
        public bool? MarkFileAsCurrentVersion { get => _markFileAsCurrentVersion; set => SetField(ref _markFileAsCurrentVersion, value); }

        /// <summary>
        /// EditDocumentRights MarkStatusAsReviewed
        /// </summary>
        public bool? MarkStatusAsReviewed { get => _markStatusAsReviewed; set => SetField(ref _markStatusAsReviewed, value); }

        /// <summary>
        /// EditDocumentRights MergeFiles
        /// </summary>
        public bool? MergeFiles { get => _mergeFiles; set => SetField(ref _mergeFiles, value); }

        /// <summary>
        /// EditDocumentRights MoveFileUpDown
        /// </summary>
        [JsonProperty("moveFileUp/Down")]
        public bool? MoveFileUpDown { get => _moveFileUpDown; set => SetField(ref _moveFileUpDown, value); }

        /// <summary>
        /// EditDocumentRights RemoveFilefromDocument
        /// </summary>
        public bool? RemoveFilefromDocument { get => _removeFilefromDocument; set => SetField(ref _removeFilefromDocument, value); }

        /// <summary>
        /// EditDocumentRights ScanAndAttach
        /// </summary>
        public bool? ScanAndAttach { get => _scanAndAttach; set => SetField(ref _scanAndAttach, value); }

        /// <summary>
        /// EditDocumentRights SplitFile
        /// </summary>
        public bool? SplitFile { get => _splitFile; set => SetField(ref _splitFile, value); }
    }
}