using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// LoConnectTasksRights
    /// </summary>
    public sealed class LoConnectTasksRights : PersonaAccess
    {
        private DirtyList<string>? _rights;
        private DirtyList<StandardWebFormRights>? _standardWebForms;

        /// <summary>
        /// LoConnectTasksRights Rights
        /// </summary>
        [AllowNull]
        public IList<string> Rights { get => GetField(ref _rights); set => SetField(ref _rights, value); }

        /// <summary>
        /// LoConnectTasksRights StandardWebForms
        /// </summary>
        [AllowNull]
        public IList<StandardWebFormRights> StandardWebForms { get => GetField(ref _standardWebForms); set => SetField(ref _standardWebForms, value); }
    }
}