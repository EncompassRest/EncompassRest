namespace EncompassRest.Schema.v3;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
/// <summary>
/// VirtualFieldSchema
/// </summary>
public sealed class VirtualFieldSchema : ExtensibleObject
{
    /// <summary>
    /// The virtual field ID that is mapped to the field name.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Description of the virtual field.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Data format of the field.
    /// </summary>
    public StringEnumValue<LoanFieldFormat> Format { get; set; }

    /// <summary>
    /// Indicates whether the field is repeatable within the entity.
    /// </summary>
    public bool MultiInstance { get; set; }

    /// <summary>
    /// Type of entity if the virtual field is a multiInstance field.
    /// </summary>
    public StringEnumValue<InstanceSpecifierType> InstanceSpecifierType { get; set; }

    /// <summary>
    /// VirtualFieldSchema ReadOnly
    /// </summary>
    public bool ReadOnly { get; set; }

    /// <summary>
    /// VirtualFieldSchema VirtualFieldType
    /// </summary>
    public StringEnumValue<VirtualFieldType> VirtualFieldType { get; set; }
}