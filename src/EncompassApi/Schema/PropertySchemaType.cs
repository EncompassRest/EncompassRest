using System.Runtime.Serialization;

namespace EncompassApi.Schema
{
    /// <summary>
    /// PropertySchemaType
    /// </summary>
    public enum PropertySchemaType
    {
        /// <summary>
        /// bool
        /// </summary>
        [EnumMember(Value = "bool")]
        Bool = 0,
        /// <summary>
        /// date
        /// </summary>
        [EnumMember(Value = "date")]
        Date = 1,
        /// <summary>
        /// datetime
        /// </summary>
        [EnumMember(Value = "datetime")]
        DateTime = 2,
        /// <summary>
        /// decimal
        /// </summary>
        [EnumMember(Value = "decimal")]
        Decimal = 3,
        /// <summary>
        /// entity
        /// </summary>
        [EnumMember(Value = "entity")]
        Entity = 4,
        /// <summary>
        /// int
        /// </summary>
        [EnumMember(Value = "int")]
        Int = 5,
        /// <summary>
        /// list
        /// </summary>
        [EnumMember(Value = "list")]
        List = 6,
        /// <summary>
        /// NA&lt;decimal&gt;
        /// </summary>
        [EnumMember(Value = "NA<decimal>")]
        NADecimal = 7,
        /// <summary>
        /// set
        /// </summary>
        [EnumMember(Value = "set")]
        Set = 8,
        /// <summary>
        /// string
        /// </summary>
        [EnumMember(Value = "string")]
        String = 9,
        /// <summary>
        /// uuid
        /// </summary>
        [EnumMember(Value = "uuid")]
        Uuid = 10
    }
}