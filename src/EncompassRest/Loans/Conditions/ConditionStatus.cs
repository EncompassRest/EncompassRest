namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// ConditionStatus
    /// </summary>
    public enum ConditionStatus
    {
        /// <summary>
        /// Added
        /// </summary>
        Added = 0,
        /// <summary>
        /// Expected
        /// </summary>
        Expected = 1,
        /// <summary>
        /// Requested
        /// </summary>
        Requested = 2,
        /// <summary>
        /// Received
        /// </summary>
        Received = 3,
        /// <summary>
        /// Rerequested
        /// </summary>
        Rerequested = 4,
        /// <summary>
        /// Fulfilled
        /// </summary>
        Fulfilled = 5,
        /// <summary>
        /// Reviewed
        /// </summary>
        Reviewed = 6,
        /// <summary>
        /// Sent
        /// </summary>
        Sent = 7,
        /// <summary>
        /// Cleared
        /// </summary>
        Cleared = 8,
        /// <summary>
        /// Waived
        /// </summary>
        Waived = 9,
        /// <summary>
        /// Expired
        /// </summary>
        Expired = 10,
        /// <summary>
        /// Rejected
        /// </summary>
        Rejected = 11
    }
}