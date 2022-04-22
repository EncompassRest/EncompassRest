using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// DocumentsRights
    /// </summary>
    public sealed class DocumentsRights : PersonaAccessRights
    {
        /// <summary>
        /// DocumentsRights ProtectedDocuments
        /// </summary>
        [AllowNull]
        public IList<string> ProtectedDocuments { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// DocumentsRights UnprotectedDocuments
        /// </summary>
        [AllowNull]
        public IList<string> UnprotectedDocuments { get => GetList<string>(); set => SetList(value); }

        /// <summary>
        /// DocumentsRights UnassignedFields
        /// </summary>
        [AllowNull]
        public IList<string> UnassignedFiles { get => GetList<string>(); set => SetList(value); }
    }
}