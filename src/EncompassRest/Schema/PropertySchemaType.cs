using System.Runtime.Serialization;

namespace EncompassRest.Schema
{
    public enum PropertySchemaType
    {
        [EnumMember(Value = "bool")]
        Bool = 0,
        [EnumMember(Value = "date")]
        Date = 1,
        [EnumMember(Value = "datetime")]
        DateTime = 2,
        [EnumMember(Value = "decimal")]
        Decimal = 3,
        [EnumMember(Value = "entity")]
        Entity = 4,
        [EnumMember(Value = "int")]
        Int = 5,
        [EnumMember(Value = "list")]
        List = 6,
        [EnumMember(Value = "NA<decimal>")]
        NADecimal = 7,
        [EnumMember(Value = "set")]
        Set = 8,
        [EnumMember(Value = "string")]
        String = 9,
        [EnumMember(Value = "uuid")]
        Uuid = 10
    }
}