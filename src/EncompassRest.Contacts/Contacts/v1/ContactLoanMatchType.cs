namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// ContactLoanMatchType
    /// </summary>
    public enum ContactLoanMatchType
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// AnyCompleted
        /// </summary>
        AnyCompleted = 1,
        /// <summary>
        /// LastCompleted
        /// </summary>
        LastCompleted = 2,
        /// <summary>
        /// AnyOriginated
        /// </summary>
        AnyOriginated = 3,
        /// <summary>
        /// LastOriginated
        /// </summary>
        LastOriginated = 4
    }
}