using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// LoConnectTasksRights
    /// </summary>
    public sealed class LoConnectTasksRights : PersonaAccessRights
    {
        /// <summary>
        /// LoConnectTasksRights StandardWebForms
        /// </summary>
        [AllowNull]
        public IList<StandardWebFormRights> StandardWebForms { get => GetList<StandardWebFormRights>(); set => SetList(value); }
    }
}