namespace EncompassRest
{
    /// <summary>
    /// Object containing details of the error.
    /// </summary>
    public sealed class ErrorObject : ExtensibleObject
    {
        /// <summary>
        /// Any error codes returned.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Details of the error.
        /// </summary>
        public string? Details { get; set; }

        /// <summary>
        /// Summary of the error.
        /// </summary>
        public string? Summary { get; set; }
    }
}