using System.Collections.Generic;

namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// DocumentsRights
    /// </summary>
    public sealed class DocumentsRights : PersonaAccessRights
    {
        private DirtyList<string> _protectedDocuments;
        private DirtyList<string> _unprotectedDocuments;
        private DirtyList<string> _unassignedFiles;

        /// <summary>
        /// DocumentsRights ProtectedDocuments
        /// </summary>
        public IList<string> ProtectedDocuments { get => GetField(ref _protectedDocuments); set => SetField(ref _protectedDocuments, value); }

        /// <summary>
        /// DocumentsRights UnprotectedDocuments
        /// </summary>
        public IList<string> UnprotectedDocuments { get => GetField(ref _unprotectedDocuments); set => SetField(ref _unprotectedDocuments, value); }

        /// <summary>
        /// DocumentsRights UnassignedFields
        /// </summary>
        public IList<string> UnassignedFiles { get => GetField(ref _unassignedFiles); set => SetField(ref _unassignedFiles, value); }
    }
}