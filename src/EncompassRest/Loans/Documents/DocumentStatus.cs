using System.Runtime.Serialization;

namespace EncompassRest.Loans.Documents
{
    public enum DocumentStatus
    {
        [EnumMember(Value = "added")]
        Added = 0,
        [EnumMember(Value = "fulfilled")]
        Fulfilled = 1,
        [EnumMember(Value = "requested")]
        Requested = 2,
        [EnumMember(Value = "rerequested")]
        Rerequested = 3,
        [EnumMember(Value = "expected")]
        Expected = 4,
        [EnumMember(Value = "past due")]
        PastDue = 5,
        [EnumMember(Value = "received")]
        Received = 6,
        [EnumMember(Value = "reviewed")]
        Reviewed = 7,
        [EnumMember(Value = "rejected")]
        Rejected = 9,
        [EnumMember(Value = "cleared")]
        Cleared = 10,
        [EnumMember(Value = "waived")]
        Waived = 11
    }
}