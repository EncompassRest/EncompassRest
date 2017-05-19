using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class LogAlert
    {
        public string Id { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? FollowedUpDate { get; set; }
        public LogRecord LogRecord { get; set; }
        public int? RoleId { get; set; }
        public string SystemId { get; set; }
        public string UserId { get; set; }
    }
}