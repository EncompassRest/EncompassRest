namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OtherClassRights
    /// </summary>
    public sealed class SettingsOtherRights : DirtyExtensibleObject
    {
        /// <summary>
        /// OtherClassRights AccessToInputFormBuilder
        /// </summary>
        public bool? AccessToInputFormBuilder { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OtherClassRights DiagnosticMode
        /// </summary>
        public bool? DiagnosticMode { get => GetValue<bool?>(); set => SetValue(value); }
    }
}