using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// FormsRights
    /// </summary>
    public sealed class FormsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// FormsRights InputForms
        /// </summary>
        [AllowNull]
        public IDictionary<string, bool> InputForms { get => GetDictionary<string, bool>(); set => SetDictionary(value); }
    }
}