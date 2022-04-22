using System.Collections.Generic;
using EncompassRest.Utilities;

namespace EncompassRest.LoanFolders.v3
{
    /// <summary>
    /// LoanFolder
    /// </summary>
    [IdPropertyName(nameof(FolderName))]
    public sealed class LoanFolder : DirtyExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Name of the folder.
        /// </summary>
        public string FolderName { get => GetValue<string>()!; set => SetValue(value); }

        string? IIdentifiable.Id { get => FolderName; set => FolderName = value!; }

        /// <summary>
        /// Display name of the loan folder.
        /// </summary>
        public string? DisplayName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// Gets or sets the field folder type.
        /// </summary>
        public StringEnumValue<FolderType> FolderType { get => GetValue<StringEnumValue<FolderType>>(); set => SetValue(value); }

        /// <summary>
        /// Gets or sets the actions allowed on the loan folder.
        /// </summary>
        public IList<StringEnumValue<FolderAction>> ActionsAllowed { get => GetList<StringEnumValue<FolderAction>>(); set => SetList(value); }

        /// <summary>
        /// Indicates whether the folder supports archive functionality.
        /// </summary>
        public bool? IsArchiveFolder { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// Indicates whether the loan folder is part of duplicate loan checking.
        /// </summary>
        public bool? IncludeDuplicateLoanCheck { get => GetValue<bool?>(); set => SetValue(value); }

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