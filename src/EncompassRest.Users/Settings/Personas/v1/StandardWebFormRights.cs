namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// StandardWebFormRights
    /// </summary>
    public sealed class StandardWebFormRights : DirtyExtensibleObject
    {
        /// <summary>
        /// StandardWebFormRights Access
        /// </summary>
        public bool? Access { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// StandardWebFormRights FormId
        /// </summary>
        public int? FormId { get => GetValue<int?>(); set => SetValue(value); }

        /// <summary>
        /// StandardWebFormRights FormName
        /// </summary>
        public string? FormName { get => GetValue<string?>(); set => SetValue(value); }
    }
}