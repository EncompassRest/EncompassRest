namespace EncompassRest.Schema
{
    public sealed class ParentFieldDefinition : FieldDefinition
    {
        public bool MultiInstance { get; set; }
        public int InstanceSpecifierType { get; set; }
    }
}