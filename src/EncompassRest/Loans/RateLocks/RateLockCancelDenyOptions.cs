namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// RateLockCancelDenyOptions
    /// </summary>
    public sealed partial class RateLockCancelDenyOptions
    {
        private string? _comments;

        /// <summary>
        /// Rate Lock cancellation or denial comments
        /// </summary>
        public string? Comments { get => _comments; set => _comments = value; }
    }
}