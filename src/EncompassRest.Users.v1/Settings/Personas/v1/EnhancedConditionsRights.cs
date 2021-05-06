namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// EnhancedConditionsRights
    /// </summary>
    public sealed class EnhancedConditionsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _access;

        /// <summary>
        /// EnhancedConditionsRights Access
        /// </summary>
        public bool? Access { get => _access; set => SetField(ref _access, value); }
    }
}