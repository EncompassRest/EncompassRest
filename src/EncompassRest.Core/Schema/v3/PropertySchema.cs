using Newtonsoft.Json;

namespace EncompassRest.Schema.v3;

/// <summary>
/// PropertySchema
/// </summary>
public sealed class PropertySchema : SchemaBase
{
    /// <summary>
    /// PropertySchema Items
    /// </summary>
    [JsonConverter(typeof(SchemaBaseConverter<ItemsSchema>))]
    public ItemsSchema? Items { get; set; }

    /// <summary>
    /// PropertySchema MaxLength
    /// </summary>
    public int? MaxLength { get; set; }

    /// <summary>
    /// PropertySchema Format
    /// </summary>
    public StringEnumValue<PropertyFormat> Format { get; set; }

    /// <summary>
    /// PropertySchema Minimum
    /// </summary>
    public decimal? Minimum { get; set; }

    /// <summary>
    /// PropertySchema Maximum
    /// </summary>
    public decimal? Maximum { get; set; }

    /// <summary>
    /// PropertySchema Default
    /// </summary>
    public int? Default { get; set; }
}