using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class StatusOnlineEvent
    {
        public string Id { get; set; }
        public string DateText { get; set; }
        public string Description { get; set; }
    }
}