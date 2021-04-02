using System.Runtime.Serialization;

namespace EncompassApi.Loans.RateLocks
{
    /// <summary>
    /// RequestIndicators
    /// </summary>
    public enum RequestIndicator
    {
        /// <summary>
        /// HideLog
        /// </summary>
        [EnumMember(Value = "hideLog")]
        HideLog = 0,
        /// <summary>
        /// FakeRequest
        /// </summary>
        [EnumMember(Value = "fakeRequest")]
        FakeRequest = 1,
        /// <summary>
        /// LockExtension
        /// </summary>
        [EnumMember(Value = "lockExtension")]
        LockExtension = 2,
        /// <summary>
        /// LockCancellation
        /// </summary>
        [EnumMember(Value = "lockCancellation")]
        LockCancellation = 3,
        /// <summary>
        /// Relock
        /// </summary>
        [EnumMember(Value = "reLock")]
        Relock = 4
    }
}