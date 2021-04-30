using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.v1.Enums
{
    /// <summary>
    /// PoolingMethodType
    /// </summary>
    public enum PoolingMethodType
    {
        /// <summary>
        /// Concurrent Date
        /// </summary>
        [Description("Concurrent Date")]
        [EnumMember(Value = "ConcurrentDate ")]
        ConcurrentDate = 0,
        /// <summary>
        /// Internal Reserve
        /// </summary>
        [Description("Internal Reserve")]
        InternalReserve = 1
    }
}