namespace EncompassRest.Loans.Documents
{
    public enum DocumentStatus
    {
        Added = 0,
        Fulfilled = 1,
        Requested = 2,
        Rerequested = 3,
        Expected = 4,
        PastDue = 5,
        Received = 6,
        Reviewed = 7,
        Rejected = 9,
        Cleared = 10,
        Waived = 11
    }
}