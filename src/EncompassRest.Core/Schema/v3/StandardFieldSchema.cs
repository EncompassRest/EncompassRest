using System.Collections.Generic;
using EncompassRest.Loans.v3;

namespace EncompassRest.Schema.v3;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
/// <summary>
/// StandardFieldSchema
/// </summary>
public sealed class StandardFieldSchema : ExtensibleObject
{
    /// <summary>
    /// The Encompass field ID that is mapped to the field name.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Description of the Encompass field.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Data format of the field.
    /// </summary>
    public StringEnumValue<LoanFieldFormat> Format { get; set; }

    /// <summary>
    /// Indicates whether the field is editable.
    /// </summary>
    public bool ReadOnly { get; set; }

    /// <summary>
    /// Indicates whether the field is Nullable.
    /// </summary>
    public bool Nullable { get; set; }

    /// <summary>
    /// The field category.
    /// </summary>
    public StringEnumValue<FieldCategory> Category { get; set; }

    /// <summary>
    /// StandardFieldSchema DataType
    /// </summary>
    public StringEnumValue<FieldDataType> DataType { get; set; }

    /// <summary>
    /// The maximum length allowed for the field.
    /// </summary>
    public int MaxLength { get; set; }

    /// <summary>
    /// Indicates whether the field is repeatable within the entity.
    /// </summary>
    public bool MultiInstance { get; set; }

    /// <summary>
    /// Contract path of the field ID.
    /// </summary>
    public string ContractPath { get; set; }

    /// <summary>
    /// JSON path of the field in the loan object.
    /// </summary>
    public string JsonPath { get; set; }

    /// <summary>
    /// Indicates the entity the field ID belongs to in the loan object.
    /// </summary>
    public StringEnumValue<LoanEntityFilterKey> EntitiesFilterKey { get; set; }

    /// <summary>
    /// Values depend on the field type.
    /// </summary>
    public List<FieldOption> Options { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.