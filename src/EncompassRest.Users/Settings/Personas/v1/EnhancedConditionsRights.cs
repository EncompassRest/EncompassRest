namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// EnhancedConditionsRights
    /// </summary>
    public sealed class EnhancedConditionsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// EnhancedConditionsRights Access
        /// </summary>
        public bool? Access { get => GetValue<bool?>(); set => SetValue(value); }
    }
}