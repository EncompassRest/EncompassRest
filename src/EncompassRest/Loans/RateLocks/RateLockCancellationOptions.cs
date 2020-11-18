using System;
using System.Collections.Generic;

namespace EncompassRest.Loans.RateLocks
{
    /// <summary>
    /// RateLockCancellationOptions
    /// </summary>
    public sealed partial class RateLockCancelDenyOptions
    {
        private string? _comments;
        

        /// <summary>
        /// Rate Lock cancellation comments
        /// </summary>
        public string? Comments { get => _comments; set => _comments = value; }

    }
}