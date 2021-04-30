using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// UnassignedFilesRights
    /// </summary>
    public sealed class UnassignedFilesRights : DirtyExtensibleObject
    {
        private AddNotesToFileRights? _addNotesToFile;
        private DirtyValue<bool?>? _attachEncompassForms;
        private DirtyValue<bool?>? _autoAssign;
        private DirtyValue<bool?>? _browseAndAttach;
        private DeleteNotesRights? _deleteNotes;
        private EditFileRights? _editFile;
        private DirtyValue<bool?>? _mergeFiles;
        private DirtyValue<bool?>? _scanAndAttach;
        private DirtyValue<bool?>? _splitFile;
        private DirtyValue<bool?>? _suggestor;

        /// <summary>
        /// UnassignedFilesRights AddNotesToFile
        /// </summary>
        [AllowNull]
        public AddNotesToFileRights AddNotesToFile { get => GetField(ref _addNotesToFile); set => SetField(ref _addNotesToFile, value); }

        /// <summary>
        /// UnassignedFilesRights AttachEncompassForms
        /// </summary>
        public bool? AttachEncompassForms { get => _attachEncompassForms; set => SetField(ref _attachEncompassForms, value); }

        /// <summary>
        /// UnassignedFilesRights AutoAssign
        /// </summary>
        public bool? AutoAssign { get => _autoAssign; set => SetField(ref _autoAssign, value); }

        /// <summary>
        /// UnassignedFilesRights BrowseAndAttach
        /// </summary>
        public bool? BrowseAndAttach { get => _browseAndAttach; set => SetField(ref _browseAndAttach, value); }

        /// <summary>
        /// UnassignedFilesRights DeleteNotes
        /// </summary>
        [AllowNull]
        public DeleteNotesRights DeleteNotes { get => GetField(ref _deleteNotes); set => SetField(ref _deleteNotes, value); }

        /// <summary>
        /// UnassignedFilesRights EditFile
        /// </summary>
        [AllowNull]
        public EditFileRights EditFile { get => GetField(ref _editFile); set => SetField(ref _editFile, value); }

        /// <summary>
        /// UnassignedFilesRights MergeFiles
        /// </summary>
        public bool? MergeFiles { get => _mergeFiles; set => SetField(ref _mergeFiles, value); }

        /// <summary>
        /// UnassignedFilesRights ScanAndAttach
        /// </summary>
        public bool? ScanAndAttach { get => _scanAndAttach; set => SetField(ref _scanAndAttach, value); }

        /// <summary>
        /// UnassignedFilesRights SplitFile
        /// </summary>
        public bool? SplitFile { get => _splitFile; set => SetField(ref _splitFile, value); }

        /// <summary>
        /// UnassignedFilesRights Suggestor
        /// </summary>
        public bool? Suggestor { get => _suggestor; set => SetField(ref _suggestor, value); }
    }
}