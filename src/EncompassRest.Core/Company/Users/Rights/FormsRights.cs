using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// FormsRights
    /// </summary>
    public sealed class FormsRights : DirtyExtensibleObject
    {
        private DirtyDictionary<string, bool>? _inputForms;

        /// <summary>
        /// FormsRights InputForms
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> InputForms { get => GetField(ref _inputForms); set => SetField(ref _inputForms, value); }
    }
}