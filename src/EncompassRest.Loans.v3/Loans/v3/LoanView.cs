using System.Runtime.Serialization;

namespace EncompassRest.Loans.v3
{
    /// <summary>
    /// LoanView
    /// </summary>
    public enum LoanView
    {
        /// <summary>
        /// Id
        /// </summary>
        [EnumMember(Value = "id")]
        Id = 0,
        /// <summary>
        /// Core loan data
        /// </summary>
        [EnumMember(Value = "entity")]
        Entity = 1,
        /// <summary>
        /// Log records
        /// </summary>
        [EnumMember(Value = "logs")]
        Logs = 2,
        /// <summary>
        /// Both core loan data and log records
        /// </summary>
        [EnumMember(Value = "full")]
        Full = 3
    }
}