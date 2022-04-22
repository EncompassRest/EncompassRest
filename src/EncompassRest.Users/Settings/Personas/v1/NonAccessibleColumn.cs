namespace EncompassRest.Settings.Personas.v1
{
    /// <summary>
    /// NonAccessibleColumn
    /// </summary>
    public sealed class NonAccessibleColumn : DirtyExtensibleObject
    {
        /// <summary>
        /// NonAccessibleColumn CanonicalName
        /// </summary>
        public string? CanonicalName { get => GetValue<string?>(); set => SetValue(value); }

        /// <summary>
        /// NonAccessibleColumn Description
        /// </summary>
        public string? Description { get => GetValue<string?>(); set => SetValue(value); }
    }
}