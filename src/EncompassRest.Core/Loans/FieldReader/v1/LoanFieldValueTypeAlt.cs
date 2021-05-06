using System.Runtime.Serialization;

namespace EncompassRest.Loans.FieldReader.v1
{
    /// <summary>
    /// LoanFieldValueTypeAlt
    /// </summary>
    public enum LoanFieldValueTypeAlt
    {
        /// <summary>
        /// date
        /// </summary>
        [EnumMember(Value = "date")]
        Date = 0,
        /// <summary>
        /// datetime
        /// </summary>
        [EnumMember(Value = "datetime")]
        DateTime = 1,
        /// <summary>
        /// decimal
        /// </summary>
        [EnumMember(Value = "decimal")]
        Decimal = 2,
        /// <summary>
        /// int
        /// </summary>
        [EnumMember(Value = "int")]
        Int = 3,
        /// <summary>
        /// string
        /// </summary>
        [EnumMember(Value = "string")]
        String = 4
    }
}