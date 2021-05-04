using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// DataSyncOption
    /// </summary>
    public enum DataSyncOption
    {
        /// <summary>
        /// noSync
        /// </summary>
        [EnumMember(Value = "noSync")]
        NoSync = 0,
        /// <summary>
        /// syncLockToLoan
        /// </summary>
        [EnumMember(Value = "syncLockToLoan")]
        SyncLockToLoan = 1
    }
}