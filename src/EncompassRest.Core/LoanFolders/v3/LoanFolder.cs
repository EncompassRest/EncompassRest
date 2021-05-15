using System.Collections.Generic;
using EncompassRest.Utilities;

namespace EncompassRest.LoanFolders.v3
{
    /// <summary>
    /// LoanFolder
    /// </summary>
    [IdPropertyName(nameof(LoanFolder.FolderName))]
    public sealed class LoanFolder : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string>? _folderName;
        private DirtyValue<string?>? _displayName;
        private DirtyValue<StringEnumValue<FolderType>>? _folderType;
        private DirtyList<StringEnumValue<FolderAction>>? _actionsAllowed;
        private DirtyValue<bool?>? _isArchiveFolder;
        private DirtyValue<bool?>? _includeDuplicateLoanCheck;

        /// <summary>
        /// Name of the folder.
        /// </summary>
        public string FolderName { get => _folderName; set => SetField(ref _folderName, value); }

        string? IIdentifiable.Id { get => FolderName; set => FolderName = value!; }

        /// <summary>
        /// Display name of the loan folder.
        /// </summary>
        public string? DisplayName { get => _displayName; set => SetField(ref _displayName, value); }

        /// <summary>
        /// Gets or sets the field folder type.
        /// </summary>
        public StringEnumValue<FolderType> FolderType { get => _folderType; set => SetField(ref _folderType, value); }

        /// <summary>
        /// Gets or sets the actions allowed on the loan folder.
        /// </summary>
        public IList<StringEnumValue<FolderAction>> ActionsAllowed { get => GetField(ref _actionsAllowed); set => SetField(ref _actionsAllowed, value); }

        /// <summary>
        /// Indicates whether the folder supports archive functionality.
        /// </summary>
        public bool? IsArchiveFolder { get => _isArchiveFolder; set => SetField(ref _isArchiveFolder, value); }

        /// <summary>
        /// Indicates whether the loan folder is part of duplicate loan checking.
        /// </summary>
        public bool? IncludeDuplicateLoanCheck { get => _includeDuplicateLoanCheck; set => SetField(ref _includeDuplicateLoanCheck, value); }

        /// <summary>
        /// LoanFolder constructor.
        /// </summary>
        /// <param name="folderName">Name of the folder.</param>
        public LoanFolder(string folderName)
        {
            Preconditions.NotNullOrEmpty(folderName, nameof(folderName));

            FolderName = folderName;
        }
    }
}