using System.Runtime.Serialization;

namespace EncompassRest.Loans.Documents
{
    /// <summary>
    /// DocumentStatus
    /// </summary>
    public enum DocumentStatus
    {
        /// <summary>
        /// added
        /// </summary>
        [EnumMember(Value = "added")]
        Added = 0,
        /// <summary>
        /// fulfilled
        /// </summary>
        [EnumMember(Value = "fulfilled")]
        Fulfilled = 1,
        /// <summary>
        /// requested
        /// </summary>
        [EnumMember(Value = "requested")]
        Requested = 2,
        /// <summary>
        /// rerequested
        /// </summary>
        [EnumMember(Value = "rerequested")]
        Rerequested = 3,
        /// <summary>
        /// expected
        /// </summary>
        [EnumMember(Value = "expected")]
        Expected = 4,
        /// <summary>
        /// past due
        /// </summary>
        [EnumMember(Value = "past due")]
        PastDue = 5,
        /// <summary>
        /// received
        /// </summary>
        [EnumMember(Value = "received")]
        Received = 6,
        /// <summary>
        /// reviewed
        /// </summary>
        [EnumMember(Value = "reviewed")]
        Reviewed = 7,
        /// <summary>
        /// rejected
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected = 9,
        /// <summary>
        /// cleared
        /// </summary>
        [EnumMember(Value = "cleared")]
        Cleared = 10,
        /// <summary>
        /// waived
        /// </summary>
        [EnumMember(Value = "waived")]
        Waived = 11
    }
}