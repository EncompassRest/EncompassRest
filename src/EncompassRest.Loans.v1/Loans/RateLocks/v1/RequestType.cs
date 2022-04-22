﻿using System.Runtime.Serialization;

namespace EncompassRest.Loans.RateLocks.v1
{
    /// <summary>
    /// RequestType
    /// </summary>
    public enum RequestType
    {
        /// <summary>
        /// Lock
        /// </summary>
        Lock = 0,
        /// <summary>
        /// Re-Lock
        /// </summary>
        [EnumMember(Value = "Re-lock")]
        Relock = 1,
        /// <summary>
        /// Trade Extension
        /// </summary>
        [EnumMember(Value = "Trade Extension")]
        TradeExtension = 2,
        /// <summary>
        /// Cancellation
        /// </summary>
        Cancellation = 3
    }
}