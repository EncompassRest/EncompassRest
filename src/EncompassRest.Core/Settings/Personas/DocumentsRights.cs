using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// DocumentsRights
    /// </summary>
    public sealed class DocumentsRights : PersonaAccessRights
    {
        private DirtyList<string>? _protectedDocuments;
        private DirtyList<string>? _unprotectedDocuments;
        private DirtyList<string>? _unassignedFiles;

        /// <summary>
        /// DocumentsRights ProtectedDocuments
        /// </summary>
        [AllowNull]
        public IList<string> ProtectedDocuments { get => GetField(ref _protectedDocuments); set => SetField(ref _protectedDocuments, value); }

        /// <summary>
        /// DocumentsRights UnprotectedDocuments
        /// </summary>
        [AllowNull]
        public IList<string> UnprotectedDocuments { get => GetField(ref _unprotectedDocuments); set => SetField(ref _unprotectedDocuments, value); }

        /// <summary>
        /// DocumentsRights UnassignedFields
        /// </summary>
        [AllowNull]
        public IList<string> UnassignedFiles { get => GetField(ref _unassignedFiles); set => SetField(ref _unassignedFiles, value); }
    }
}