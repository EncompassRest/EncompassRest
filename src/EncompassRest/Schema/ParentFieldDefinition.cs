namespace EncompassRest.Schema
{
    /// <summary>
    /// ParentFieldDefinition
    /// </summary>
    public sealed class ParentFieldDefinition : FieldDefinition
    {
        /// <summary>
        /// ParentFieldDefinition MultiInstance
        /// </summary>
        public bool MultiInstance { get; set; }

        /// <summary>
        /// ParentFieldDefinition InstanceSpecifierType
        /// </summary>
        public int InstanceSpecifierType { get; set; }
    }
}