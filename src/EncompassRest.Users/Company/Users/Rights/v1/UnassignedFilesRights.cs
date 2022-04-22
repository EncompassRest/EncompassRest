using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UnassignedFilesRights
    /// </summary>
    public sealed class UnassignedFilesRights : DirtyExtensibleObject
    {
        /// <summary>
        /// UnassignedFilesRights AddNotesToFile
        /// </summary>
        [AllowNull]
        public AddNotesToFileRights AddNotesToFile { get => GetEntity<AddNotesToFileRights>(); set => SetEntity(value); }

        /// <summary>
        /// UnassignedFilesRights AttachEncompassForms
        /// </summary>
        public bool? AttachEncompassForms { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnassignedFilesRights AutoAssign
        /// </summary>
        public bool? AutoAssign { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnassignedFilesRights BrowseAndAttach
        /// </summary>
        public bool? BrowseAndAttach { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnassignedFilesRights DeleteNotes
        /// </summary>
        [AllowNull]
        public DeleteNotesRights DeleteNotes { get => GetEntity<DeleteNotesRights>(); set => SetEntity(value); }

        /// <summary>
        /// UnassignedFilesRights EditFile
        /// </summary>
        [AllowNull]
        public EditFileRights EditFile { get => GetEntity<EditFileRights>(); set => SetEntity(value); }

        /// <summary>
        /// UnassignedFilesRights MergeFiles
        /// </summary>
        public bool? MergeFiles { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnassignedFilesRights ScanAndAttach
        /// </summary>
        public bool? ScanAndAttach { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnassignedFilesRights SplitFile
        /// </summary>
        public bool? SplitFile { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnassignedFilesRights Suggestor
        /// </summary>
        public bool? Suggestor { get => GetValue<bool?>(); set => SetValue(value); }
    }
}