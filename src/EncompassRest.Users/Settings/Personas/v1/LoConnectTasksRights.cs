using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// LoConnectTasksRights
    /// </summary>
    public sealed class LoConnectTasksRights : PersonaAccessRights
    {
        private DirtyList<StandardWebFormRights>? _standardWebForms;

        /// <summary>
        /// LoConnectTasksRights StandardWebForms
        /// </summary>
        [AllowNull]
        public IList<StandardWebFormRights> StandardWebForms { get => GetField(ref _standardWebForms); set => SetField(ref _standardWebForms, value); }
    }
}