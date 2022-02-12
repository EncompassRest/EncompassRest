using System.ComponentModel;

namespace EncompassRest.Loans.Enums;

/// <summary>
/// PoolingMethodType
/// </summary>
public enum PoolingMethodType
{
    /// <summary>
    /// Concurrent Date
    /// </summary>
    [Description("Concurrent Date")]
    ConcurrentDate = 0,
    /// <summary>
    /// Internal Reserve
    /// </summary>
    [Description("Internal Reserve")]
    InternalReserve = 1
}