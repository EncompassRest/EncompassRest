namespace EncompassApi.Settings.Personas
{
    /// <summary>
    /// StandardWebFormRights
    /// </summary>
    public sealed class StandardWebFormRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _access;
        private DirtyValue<int?>? _formId;
        private DirtyValue<string?>? _formName;

        /// <summary>
        /// StandardWebFormRights Access
        /// </summary>
        public bool? Access { get => _access; set => SetField(ref _access, value); }

        /// <summary>
        /// StandardWebFormRights FormId
        /// </summary>
        public int? FormId { get => _formId; set => SetField(ref _formId, value); }

        /// <summary>
        /// StandardWebFormRights FormName
        /// </summary>
        public string? FormName { get => _formName; set => SetField(ref _formName, value); }
    }
}