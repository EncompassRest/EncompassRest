namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// OtherClassRights
    /// </summary>
    public sealed class SettingsOtherRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?> _accessToInputFormBuilder;
        private DirtyValue<bool?> _diagnosticMode;

        /// <summary>
        /// OtherClassRights AccessToInputFormBuilder
        /// </summary>
        public bool? AccessToInputFormBuilder { get => _accessToInputFormBuilder; set => SetField(ref _accessToInputFormBuilder, value); }

        /// <summary>
        /// OtherClassRights DiagnosticMode
        /// </summary>
        public bool? DiagnosticMode { get => _diagnosticMode; set => SetField(ref _diagnosticMode, value); }
    }
}