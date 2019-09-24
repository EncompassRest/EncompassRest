namespace EncompassRest.Settings.Personas
{
    /// <summary>
    /// NonAccessibleColumn
    /// </summary>
    public sealed class NonAccessibleColumn : DirtyExtensibleObject
    {
        private DirtyValue<string> _canonicalName;
        private DirtyValue<string> _description;

        /// <summary>
        /// NonAccessibleColumn CanonicalName
        /// </summary>
        public string CanonicalName { get => _canonicalName; set => SetField(ref _canonicalName, value); }

        /// <summary>
        /// NonAccessibleColumn Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
    }
}