namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// RateLockCancelDenyOptions
    /// </summary>
    public sealed partial class RateLockCancelDenyOptions : ExtensibleObject
    {
        /// <summary>
        /// Rate Lock cancellation or denial comments
        /// </summary>
        public string? Comments { get; set; }
    }
}