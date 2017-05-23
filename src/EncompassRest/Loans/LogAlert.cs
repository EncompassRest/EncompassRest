using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LogAlert
    {
        public JsonNullable<DateTime?> DueDate { get; set; }
        public JsonNullable<DateTime?> FollowedUpDate { get; set; }
        public string Id { get; set; }
        public JsonNullable<LogRecord> LogRecord { get; set; }
        public int? RoleId { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string UserId { get; set; }
    }
}