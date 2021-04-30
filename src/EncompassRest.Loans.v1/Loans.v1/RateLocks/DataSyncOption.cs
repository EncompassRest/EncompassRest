using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// DataSyncOption
    /// </summary>
    public enum DataSyncOption
    {
        /// <summary>
        /// NoSync
        /// </summary>
        [EnumMember(Value = "noSync")]
        NoSync = 0,
        /// <summary>
        /// SyncLockToLoan
        /// </summary>
        [EnumMember(Value = "syncLockToLoan")]
        SyncLockToLoan = 1
    }
}